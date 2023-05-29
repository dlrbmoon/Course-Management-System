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
    public partial class Student_Rank : Form
    {
        public Student_Rank()
        {
            InitializeComponent();
            Table();
        }
        private void Table()
        {
            dataGridView1.Rows.Clear();
            string sql = "select distinct Student.Sno,Sname,Sclass,GPA from Student_Course,Student where Student.Sno=Student_Course.Sno order by GPA desc";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string l1, l2, l3, l4;
                l1 = dr["Sno"].ToString();
                l2 = dr["Sname"].ToString();
                l3 = dr["Sclass"].ToString();
                l4 = dr["GPA"].ToString();
                string[] str = { l1, l2, l3, l4 };
                dataGridView1.Rows.Add(str);
            }
        }

        //  列前序号
        private void dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,e.RowBounds.Location.Y,dataGridView1.RowHeadersWidth - 4,e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),dataGridView1.RowHeadersDefaultCellStyle.Font,rectangle,dataGridView1.RowHeadersDefaultCellStyle.ForeColor,TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
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
                string sql = "select distinct Student.Sno,Sname,Sclass,GPA from Student_Course,Student where Student.Sno=Student_Course.Sno and Student.Sno='" + toolStripTextBox1.Text + "' order by GPA desc ";
                Dao dao = new Dao();
                IDataReader dr = dao.read(sql);
                while (dr.Read())
                {
                    string l1, l2, l3, l4;
                    l1 = dr["Sno"].ToString();
                    l2 = dr["Sname"].ToString();
                    l3 = dr["Sclass"].ToString();
                    l4 = dr["GPA"].ToString();
                    string[] str = { l1, l2, l3, l4 };
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
                string sql = "select distinct Student.Sno,Sname,Sclass,GPA from Student_Course,Student where Student.Sno=Student_Course.Sno and Student.Sclass='" + toolStripTextBox2.Text + "' order by GPA desc";
                Dao dao = new Dao();
                IDataReader dr = dao.read(sql);
                while (dr.Read())
                {
                    string l1, l2, l3, l4;
                    l1 = dr["Sno"].ToString();
                    l2 = dr["Sname"].ToString();
                    l3 = dr["Sclass"].ToString();
                    l4 = dr["GPA"].ToString();
                    string[] str = { l1, l2, l3, l4 };
                    dataGridView1.Rows.Add(str);
                }
            }
        }

        private void 查询所有学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table();
        }

        private void dataGridView1_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_RowPostPaint);
        }
    }
}
