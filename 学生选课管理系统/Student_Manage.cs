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
    public partial class Student_Manage : Form
    {
        public Student_Manage()
        {
            InitializeComponent();
            Table();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        // 显示数据库表中的数据
        private void Table()
        {
            dataGridView1.Rows.Clear();
            string sql = "select * from Student";
            Dao dao= new Dao();
            IDataReader dr=dao.read(sql);
            while (dr.Read())
            {
                string l1, l2, l3, l4, l5;
                l1 =dr["Sno"].ToString();
                l2 = dr["Sname"].ToString();
                l3 = dr["Ssex"].ToString();
                l4 = dr["Sbirth"].ToString();
                l5 = dr["Sclass"].ToString();
                string[] str = { l1, l2, l3, l4, l5 };
                dataGridView1.Rows.Add(str);
            }
        }

        private void 添加学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Add form21= new Student_Add();
            form21.ShowDialog();
            Table();
        }

        private void 修改学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] str = { dataGridView1.SelectedCells[0].Value.ToString(), dataGridView1.SelectedCells[1].Value.ToString(), dataGridView1.SelectedCells[2].Value.ToString(), dataGridView1.SelectedCells[3].Value.ToString(), dataGridView1.SelectedCells[4].Value.ToString() };
            Student_Add form21 = new Student_Add(str);
            form21.ShowDialog();
            Table();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Table();
        }

        private void 系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 删除学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("确定要删除吗", "提示", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK) 
            {
            string l1, l2, l3, l4, l5;
            l1 = dataGridView1.SelectedCells[0].Value.ToString();
            l2 = dataGridView1.SelectedCells[1].Value.ToString();
            l3 = dataGridView1.SelectedCells[2].Value.ToString();
            l4 = dataGridView1.SelectedCells[3].Value.ToString();
            l5 = dataGridView1.SelectedCells[4].Value.ToString();
            string sql="delete from Student where Sno='"+l1+ "'and Sname='"+l2+ "' and Ssex='"+l3+ "' and Sbirth ='"+l4+ "' and Sclass='"+l5+"'";
            MessageBox.Show(sql);
            Dao dao= new Dao();
            dao.Execute(sql);
            Table(); 
            }
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
                string sql = "select * from Student where Sno='"+ toolStripTextBox1.Text+ "'";
                Dao dao = new Dao();
                IDataReader dr = dao.read(sql);
                while (dr.Read())
                {
                    string l1, l2, l3, l4, l5;
                    l1 = dr["Sno"].ToString();
                    l2 = dr["Sname"].ToString();
                    l3 = dr["Ssex"].ToString();
                    l4 = dr["Sbirth"].ToString();
                    l5 = dr["Sclass"].ToString();
                    string[] str = { l1, l2, l3, l4, l5 };
                    dataGridView1.Rows.Add(str);
                }
            }
        }

        private void 按班级查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox2.Text == "")
            {
                MessageBox.Show("输入为空，请输入内容", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView1.Rows.Clear();
                string sql = "select * from Student where Sclass='" + toolStripTextBox2.Text + "'";
                Dao dao = new Dao();
                IDataReader dr = dao.read(sql);
                while (dr.Read())
                {
                    string l1, l2, l3, l4, l5;
                    l1 = dr["Sno"].ToString();
                    l2 = dr["Sname"].ToString();
                    l3 = dr["Ssex"].ToString();
                    l4 = dr["Sbirth"].ToString();
                    l5 = dr["Sclass"].ToString();
                    string[] str = { l1, l2, l3, l4, l5 };
                    dataGridView1.Rows.Add(str);
                }
            }
        }

        private void 查询所有学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table();
        }

        private void 绩点查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Rank form = new Student_Rank();
            form.ShowDialog();
        }
    }
}
