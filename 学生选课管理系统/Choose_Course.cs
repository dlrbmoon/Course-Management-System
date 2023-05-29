using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学生选课管理系统
{
    public partial class Choose_Course : Form
    {
        string Sno;
        public Choose_Course(string sno)
        {
            Sno = sno;
            InitializeComponent();
            toolStripStatusLabel1.Text = "欢迎学号" + Sno + "同学登录选课系统";
            Table();
        }

        private void Table()
        {
            dataGridView1.Rows.Clear();
            string sql = "select Course.Cno,Cname,type,credit,time,capacity,Teacher.Tname,Rno from Course,Teacher,Teacher_Course where Teacher_Course.Tno=Teacher.Tno and Teacher_Course.Cno=Course.Cno";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string l1, l2, l3, l4, l5, l6, l7, l8;
                l1 = dr["Cno"].ToString();
                l2 = dr["Cname"].ToString();
                l3 = dr["type"].ToString();
                l4 = dr["credit"].ToString();
                l5 = dr["time"].ToString();
                l6 = dr["capacity"].ToString();
                l7 = dr["Tname"].ToString();
                l8 = dr["Rno"].ToString();
                string[] str = { l1, l2, l3, l4, l5, l6, l7, l8 };
                dataGridView1.Rows.Add(str);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void 选择课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Cno = dataGridView1.SelectedCells[0].Value.ToString();   //获取选中的课程号
            string type = dataGridView1.SelectedCells[2].Value.ToString();   //获取选中的课程类型
            string credit = dataGridView1.SelectedCells[3].Value.ToString();   //获取选中的课程学分


            string sql1 = "select * from Student_Course where Sno='" + Sno + "' and Cno='" + Cno + "'";
            Dao dao = new Dao();
            IDataReader dc = dao.read(sql1);
            if (!dc.Read())   // 判断是否重复选课
            {
                string sql = "insert into Student_Course(Sno,Cno,type,credit) values('" + Sno + "','" + Cno + "','" + type + "','" + credit + "')";
                int i = dao.Execute(sql);
                if (i > 0)
                {
                    MessageBox.Show("选课成功");
                }

            }
            else
            {
                MessageBox.Show("不允许重复选课");
            }
        }

        private void 已选课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chosed_Course form31 = new Chosed_Course(Sno);
            form31.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void 成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Grade form = new Student_Grade(Sno);
            form.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 地图指引ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Map form = new Map();
            form.Show();
        }

        private string fl;
        private void 教室平面图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Rno = dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells[7].Value.ToString();
            string sql = "select floor from Classroom where Rno='" + Rno + "' ";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                fl = dr["floor"].ToString();
            }
            if (fl == "1")
            {
                教室平面图.Floor1 form = new 教室平面图.Floor1(Rno);
                form.Show();
            }
            else if (fl == "2")
            {
                教室平面图.Floor2 form = new 教室平面图.Floor2(Rno);
                form.Show();
            }
            else if (fl == "3")
            {
                教室平面图.Floor3 form = new 教室平面图.Floor3(Rno);
                form.Show();
            }
            else
            {
                MessageBox.Show("查询失败");
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void 按课程名查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text == "")
            {
                MessageBox.Show("输入为空，请输入内容", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView1.Rows.Clear();
                string sql = "select Course.Cno,Cname,type,credit,time,capacity,Teacher.Tname,Rno from Course,Teacher,Teacher_Course where Teacher_Course.Tno=Teacher.Tno and Teacher_Course.Cno=Course.Cno and Course.Cname='" + toolStripTextBox1.Text + "'";
                Dao dao = new Dao();
                IDataReader dr = dao.read(sql);
                while (dr.Read())
                {
                    string l1, l2, l3, l4, l5, l6, l7, l8;
                    l1 = dr["Cno"].ToString();
                    l2 = dr["Cname"].ToString();
                    l3 = dr["type"].ToString();
                    l4 = dr["credit"].ToString();
                    l5 = dr["time"].ToString();
                    l6 = dr["capacity"].ToString();
                    l7 = dr["Tname"].ToString();
                    l8 = dr["Rno"].ToString();
                    string[] str = { l1, l2, l3, l4, l5, l6, l7, l8 };
                    dataGridView1.Rows.Add(str);
                }
            }
        }

        private void 按课程类型查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text == "")
            {
                MessageBox.Show("输入为空，请输入内容", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView1.Rows.Clear();
                string sql = "select Course.Cno,Cname,type,credit,time,capacity,Teacher.Tname,Rno from Course,Teacher,Teacher_Course where Teacher_Course.Tno=Teacher.Tno and Teacher_Course.Cno=Course.Cno and type='" + toolStripComboBox1.Text + "'";
                Dao dao = new Dao();
                IDataReader dr = dao.read(sql);
                while (dr.Read())
                {
                    string l1, l2, l3, l4, l5, l6, l7, l8;
                    l1 = dr["Cno"].ToString();
                    l2 = dr["Cname"].ToString();
                    l3 = dr["type"].ToString();
                    l4 = dr["credit"].ToString();
                    l5 = dr["time"].ToString();
                    l6 = dr["capacity"].ToString();
                    l7 = dr["Tname"].ToString();
                    l8 = dr["Rno"].ToString();
                    string[] str = { l1, l2, l3, l4, l5, l6, l7, l8 };
                    dataGridView1.Rows.Add(str);
                }
            }
        }

        private void 按教师查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox2.Text == "")
            {
                MessageBox.Show("输入为空，请输入内容", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView1.Rows.Clear();
                string sql = "select Course.Cno,Cname,type,credit,time,capacity,Teacher.Tname,Rno from Course,Teacher,Teacher_Course where Teacher_Course.Tno=Teacher.Tno and Teacher_Course.Cno=Course.Cno and Tname='" + toolStripTextBox2.Text + "'";
                Dao dao = new Dao();
                IDataReader dr = dao.read(sql);
                while (dr.Read())
                {
                    string l1, l2, l3, l4, l5, l6, l7, l8;
                    l1 = dr["Cno"].ToString();
                    l2 = dr["Cname"].ToString();
                    l3 = dr["type"].ToString();
                    l4 = dr["credit"].ToString();
                    l5 = dr["time"].ToString();
                    l6 = dr["capacity"].ToString();
                    l7 = dr["Tname"].ToString();
                    l8 = dr["Rno"].ToString();
                    string[] str = { l1, l2, l3, l4, l5, l6, l7, l8 };
                    dataGridView1.Rows.Add(str);
                }
            }
        }

        private void 查询所有课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table();
        }
    }
}
