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
    public partial class Course_Manage : Form
    {
        public Course_Manage()
        {
            InitializeComponent();
            Table();
        }
        private void Table()
        {
            dataGridView1.Rows.Clear();
            string sql = "select Course.Cno,Cname,type,credit,time,capacity,Rno,Tno from Course,Teacher_Course where Course.Cno=Teacher_Course.Cno";
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
                l7 = dr["Rno"].ToString();
                l8 = dr["Tno"].ToString();
                string[] str = { l1, l2, l3, l4, l5, l6, l7, l8 };
                dataGridView1.Rows.Add(str);
            }
        }

        private void 添加课程信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Course_Add form = new Course_Add();
            form.ShowDialog();
            Table();
        }

        private void 修改课程信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] str = { dataGridView1.SelectedCells[0].Value.ToString(), dataGridView1.SelectedCells[1].Value.ToString(), dataGridView1.SelectedCells[2].Value.ToString(), dataGridView1.SelectedCells[3].Value.ToString(), dataGridView1.SelectedCells[4].Value.ToString(), dataGridView1.SelectedCells[5].Value.ToString(), dataGridView1.SelectedCells[6].Value.ToString(), dataGridView1.SelectedCells[7].Value.ToString() };
            Course_Add form = new Course_Add(str);
            form.ShowDialog();
            Table();
        }

        private void 删除课程信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("确定要删除吗", "提示", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                string l1, l2, l3, l4, l5, l6, l7, l8;
                l1 = dataGridView1.SelectedCells[0].Value.ToString();
                l2 = dataGridView1.SelectedCells[1].Value.ToString();
                l3 = dataGridView1.SelectedCells[2].Value.ToString();
                l4 = dataGridView1.SelectedCells[3].Value.ToString();
                l5 = dataGridView1.SelectedCells[4].Value.ToString();
                l6 = dataGridView1.SelectedCells[5].Value.ToString();
                l7 = dataGridView1.SelectedCells[6].Value.ToString();
                l8 = dataGridView1.SelectedCells[7].Value.ToString();
                string sql1 = "delete from Course where Cno='" + l1 + "'";
                string sql2 = "delete from Teacher_Course where Cno='" + l1 + "' and Tno='"+l8+"'";
                Dao dao = new Dao();
                dao.Execute(sql2);
                dao.Execute(sql1);
 
                Table();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Table();
        }

        private void 系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Course_Manage_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void 按课程号查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text == "")
            {
                MessageBox.Show("输入为空，请输入内容", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView1.Rows.Clear();
                string sql = "select Course.Cno,Cname,type,credit,time,capacity,Rno,Tno from Course,Teacher_Course where Course.Cno=Teacher_Course.Cno and Course.Cno='" + toolStripTextBox1.Text + "'";
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
                    l7 = dr["Rno"].ToString();
                    l8 = dr["Tno"].ToString();
                    string[] str = { l1, l2, l3, l4, l5, l6, l7, l8 };
                    dataGridView1.Rows.Add(str);
                }
            }
        }

        private void 按教师号查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox2.Text == "")
            {
                MessageBox.Show("输入为空，请输入内容", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView1.Rows.Clear();
                string sql = "select Course.Cno,Cname,type,credit,time,capacity,Rno,Tno from Course,Teacher_Course where Course.Cno=Teacher_Course.Cno and Tno='" + toolStripTextBox2.Text + "'";
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
                    l7 = dr["Rno"].ToString();
                    l8 = dr["Tno"].ToString();
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
                string sql = "select Course.Cno,Cname,type,credit,time,capacity,Rno,Tno from Course,Teacher_Course where Course.Cno=Teacher_Course.Cno and type='" + toolStripComboBox1.Text + "'";
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
                    l7 = dr["Rno"].ToString();
                    l8 = dr["Tno"].ToString();
                    string[] str = { l1, l2, l3, l4, l5, l6, l7, l8 };
                    dataGridView1.Rows.Add(str);
                }
            }
        }
    }
}
