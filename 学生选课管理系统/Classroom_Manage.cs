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
    public partial class Classroom_Manage : Form
    {
        public Classroom_Manage()
        {
            InitializeComponent();
            Table();
        }
        private void Table()
        {
            dataGridView1.Rows.Clear();
            string sql = "select * from Classroom";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string l1, l2, l3, l4;
                l1 = dr["Rno"].ToString();
                l2 = dr["floor"].ToString();
                l3 = dr["capacity"].ToString();
                l4 = dr["location"].ToString();
                string[] str = { l1, l2, l3, l4 };
                dataGridView1.Rows.Add(str);
            }
        }

        private void 添加班级信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classroom_Add form = new Classroom_Add();
            form.ShowDialog();
            Table();
        }

        private void 删除教室信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("确定要删除吗", "提示", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                string l1, l2, l3, l4;
                l1 = dataGridView1.SelectedCells[0].Value.ToString();
                l2 = dataGridView1.SelectedCells[1].Value.ToString();
                l3 = dataGridView1.SelectedCells[2].Value.ToString();
                l4 = dataGridView1.SelectedCells[3].Value.ToString();
                string sql = "delete from Classroom where Rno='" + l1 + "'";
                MessageBox.Show(sql);
                Dao dao = new Dao();
                dao.Execute(sql);
                Table();
            }
        }

        private void 系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 修改教室信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] str = { dataGridView1.SelectedCells[0].Value.ToString(), dataGridView1.SelectedCells[1].Value.ToString(), dataGridView1.SelectedCells[2].Value.ToString(), dataGridView1.SelectedCells[3].Value.ToString() };
            Classroom_Add form = new Classroom_Add(str);
            form.ShowDialog();
            Table();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Table();
        }

        private void 查询所有教室ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table();
        }

        private void 按位置查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text == "")
            {
                MessageBox.Show("输入为空，请输入内容", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView1.Rows.Clear();
                string sql = "select * from Classroom where location='"+ toolStripComboBox1.Text + "'";
                Dao dao = new Dao();
                IDataReader dr = dao.read(sql);
                while (dr.Read())
                {
                    string l1, l2, l3, l4;
                    l1 = dr["Rno"].ToString();
                    l2 = dr["floor"].ToString();
                    l3 = dr["capacity"].ToString();
                    l4 = dr["location"].ToString();
                    string[] str = { l1, l2, l3, l4 };
                    dataGridView1.Rows.Add(str);
                }
            }
        }

        private void 按楼层查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text == "")
            {
                MessageBox.Show("输入为空，请输入内容", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView1.Rows.Clear();
                string sql = "select * from Classroom where floor='" + toolStripComboBox2.Text + "'";
                Dao dao = new Dao();
                IDataReader dr = dao.read(sql);
                while (dr.Read())
                {
                    string l1, l2, l3, l4;
                    l1 = dr["Rno"].ToString();
                    l2 = dr["floor"].ToString();
                    l3 = dr["capacity"].ToString();
                    l4 = dr["location"].ToString();
                    string[] str = { l1, l2, l3, l4 };
                    dataGridView1.Rows.Add(str);
                }
            }
        }
    }
}
