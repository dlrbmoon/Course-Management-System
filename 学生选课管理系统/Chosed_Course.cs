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
    public partial class Chosed_Course : Form
    {
        string Sno;
        public Chosed_Course(string sno)
        {
            InitializeComponent();
            Sno = sno;
            Table();
        }
        private void Table()
        {
            dataGridView1.Rows.Clear();
            string sql = "select Student_Course.Cno,Course.Cname,Course.type,Course.credit,Course.time,Course.capacity,Teacher.Tname,Course.Rno from Course,Student_Course,Teacher,Teacher_Course where Teacher.Tno=Teacher_Course.Tno and Course.Cno=Student_Course.Cno and Student_Course.Cno=Teacher_Course.Cno and Sno='"+Sno+"'";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string l1, l2, l3, l4, l5, l6,l7, l8;
                l1 = dr["Cno"].ToString();
                l2 = dr["Cname"].ToString();
                l3 = dr["type"].ToString();
                l4 = dr["credit"].ToString();
                l5 = dr["time"].ToString();
                l6 = dr["capacity"].ToString();
                l7 = dr["Tname"].ToString();
                l8 = dr["Rno"].ToString();
                string[] str = { l1, l2, l3, l4, l5, l6, l7,l8 };
                dataGridView1.Rows.Add(str);
            }
        }

        private void 退课ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("确定要退掉该课程吗", "提示", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                string Cno = dataGridView1.SelectedCells[0].Value.ToString();
                string sql = "delete Student_Course where Sno='" + Sno + "' and Cno='" + Cno + "'";
                Dao dao = new Dao();
                dao.Execute(sql);
                Table();
            }
        }

        private void 成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Grade form = new Student_Grade(Sno);
            form.Show();
        }

        private string fl;
        private void 教学楼指引ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void 教室指引ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Map form = new Map();
            form.Show();
        }
    }
}
