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
    public partial class Teacher_Manage : Form
    {
        public Teacher_Manage()
        {
            InitializeComponent();
            Table();
        }
        private void Table()
        {
            dataGridView1.Rows.Clear();
            string sql = "select * from Teacher";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string l1, l2, l3, l4,l5;
                l1 = dr["Tno"].ToString();
                l2 = dr["Tname"].ToString();
                l3 = dr["post"].ToString();
                l4 = dr["Tphone"].ToString();
                l5 = dr["Dno"].ToString();
                string[] str = { l1, l2, l3, l4,l5 };
                dataGridView1.Rows.Add(str);
            }
        }

        private void 添加教师信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teacher_Add form = new Teacher_Add();
            form.ShowDialog();
            Table();
        }

        private void 修改教师信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] str = { dataGridView1.SelectedCells[0].Value.ToString(), dataGridView1.SelectedCells[1].Value.ToString(), dataGridView1.SelectedCells[2].Value.ToString(), dataGridView1.SelectedCells[3].Value.ToString(), dataGridView1.SelectedCells[4].Value.ToString() };
            Teacher_Add form = new Teacher_Add(str);
            form.ShowDialog();
            Table();
        }

        private void 删除教师信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("确定要删除吗", "提示", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                string l1, l2, l3, l4,l5;
                l1 = dataGridView1.SelectedCells[0].Value.ToString();
                l2 = dataGridView1.SelectedCells[1].Value.ToString();
                l3 = dataGridView1.SelectedCells[2].Value.ToString();
                l4 = dataGridView1.SelectedCells[3].Value.ToString();
                l5 = dataGridView1.SelectedCells[4].Value.ToString();
                string sql = "delete from Teacher where Tno='" + l1 + "'and Tname='" + l2 + "' and post='" + l3 + "' and Tphone ='" + l4 + "'and Dno ='" + l5 + "'";
                MessageBox.Show(sql);
                Dao dao = new Dao();
                dao.Execute(sql);
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

        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {
            Table();
        }

        private void Teacher_Manage_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void 按教师证号查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text == "")
            {
                MessageBox.Show("输入为空，请输入内容", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView1.Rows.Clear();
                string sql = "select * from Teacher where Tno='"+ toolStripTextBox1.Text + "'";
                Dao dao = new Dao();
                IDataReader dr = dao.read(sql);
                while (dr.Read())
                {
                    string l1, l2, l3, l4, l5;
                    l1 = dr["Tno"].ToString();
                    l2 = dr["Tname"].ToString();
                    l3 = dr["post"].ToString();
                    l4 = dr["Tphone"].ToString();
                    l5 = dr["Dno"].ToString();
                    string[] str = { l1, l2, l3, l4, l5 };
                    dataGridView1.Rows.Add(str);
                }
            }
        }

        private void 按系代号查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox2.Text == "")
            {
                MessageBox.Show("输入为空，请输入内容", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView1.Rows.Clear();
                string sql = "select * from Teacher where Dno='" + toolStripTextBox2.Text + "'";
                Dao dao = new Dao();
                IDataReader dr = dao.read(sql);
                while (dr.Read())
                {
                    string l1, l2, l3, l4, l5;
                    l1 = dr["Tno"].ToString();
                    l2 = dr["Tname"].ToString();
                    l3 = dr["post"].ToString();
                    l4 = dr["Tphone"].ToString();
                    l5 = dr["Dno"].ToString();
                    string[] str = { l1, l2, l3, l4, l5 };
                    dataGridView1.Rows.Add(str);
                }
            }
        }

        private void 按职称查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text == "")
            {
                MessageBox.Show("输入为空，请输入内容", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView1.Rows.Clear();
                string sql = "select * from Teacher where post='" + toolStripComboBox1.Text + "'";
                Dao dao = new Dao();
                IDataReader dr = dao.read(sql);
                while (dr.Read())
                {
                    string l1, l2, l3, l4, l5;
                    l1 = dr["Tno"].ToString();
                    l2 = dr["Tname"].ToString();
                    l3 = dr["post"].ToString();
                    l4 = dr["Tphone"].ToString();
                    l5 = dr["Dno"].ToString();
                    string[] str = { l1, l2, l3, l4, l5 };
                    dataGridView1.Rows.Add(str);
                }
            }
        }
    }
}
