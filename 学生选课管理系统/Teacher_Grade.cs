using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 学生选课管理系统
{
    public partial class Teacher_Grade : Form
    {
        string Tno;
        public Teacher_Grade(string tno)
        {
            Tno= tno;
            InitializeComponent();
            Table();
        }
        private void Table()
        {
            dataGridView1.Rows.Clear();
            string sql = "select Course.Cno,Cname,Student.Sno,Student.Sname,Student.Sclass,Student_Course.grade from Course,Teacher_Course,Student_Course,Student where Teacher_Course.Cno=Student_Course.Cno and Teacher_Course.Cno=Course.Cno and Student_Course.Sno=Student.Sno and Tno='" + Tno+"'";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string l1, l2, l3, l4, l5, l6;
                l1 = dr["Cno"].ToString();
                l2 = dr["Cname"].ToString();
                l3 = dr["Sno"].ToString();
                l4 = dr["Sname"].ToString();
                l5 = dr["Sclass"].ToString();
                l6 = dr["grade"].ToString();
                string[] str = { l1, l2, l3, l4, l5, l6 };
                dataGridView1.Rows.Add(str);
            }
        }


        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Grade_Add_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void 成绩录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] str = { dataGridView1.SelectedCells[0].Value.ToString(), dataGridView1.SelectedCells[2].Value.ToString(), dataGridView1.SelectedCells[5].Value.ToString() };
            Grade_Add form = new Grade_Add(str);
            form.ShowDialog();
        }

        private void 按学号查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text == "")
            {
                MessageBox.Show("输入为空，请输入内容", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView1.Rows.Clear();
                string sql = "select Course.Cno,Cname,Student.Sno,Student.Sname,Student.Sclass,Student_Course.grade from Course,Teacher_Course,Student_Course,Student where Teacher_Course.Cno=Student_Course.Cno and Teacher_Course.Cno=Course.Cno and Student_Course.Sno=Student.Sno and Tno='" + Tno + "' and Student.Sno='" + toolStripTextBox1.Text + "' order by grade desc";
                Dao dao = new Dao();
                IDataReader dr = dao.read(sql);
                while (dr.Read())
                {
                    string l1, l2, l3, l4, l5, l6;
                    l1 = dr["Cno"].ToString();
                    l2 = dr["Cname"].ToString();
                    l3 = dr["Sno"].ToString();
                    l4 = dr["Sname"].ToString();
                    l5 = dr["Sclass"].ToString();
                    l6 = dr["grade"].ToString();
                    string[] str = { l1, l2, l3, l4, l5, l6 };
                    dataGridView1.Rows.Add(str);
                }
            }
        }

        private void 按课程号查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox2.Text == "")
            {
                MessageBox.Show("输入为空，请输入内容", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView1.Rows.Clear();
                string sql = "select Course.Cno,Cname,Student.Sno,Student.Sname,Student.Sclass,Student_Course.grade from Course,Teacher_Course,Student_Course,Student where Teacher_Course.Cno=Student_Course.Cno and Teacher_Course.Cno=Course.Cno and Student_Course.Sno=Student.Sno and Tno='" + Tno + "' and Sclass='" + toolStripTextBox2.Text + "' order by grade desc";
                Dao dao = new Dao();
                IDataReader dr = dao.read(sql);
                while (dr.Read())
                {
                    string l1, l2, l3, l4, l5, l6;
                    l1 = dr["Cno"].ToString();
                    l2 = dr["Cname"].ToString();
                    l3 = dr["Sno"].ToString();
                    l4 = dr["Sname"].ToString();
                    l5 = dr["Sclass"].ToString();
                    l6 = dr["grade"].ToString();
                    string[] str = { l1, l2, l3, l4, l5, l6 };
                    dataGridView1.Rows.Add(str);
                }
            }
        }

        private void 查询所有学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table();
        }
    }
}
