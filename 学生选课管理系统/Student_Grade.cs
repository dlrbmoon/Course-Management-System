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
    public partial class Student_Grade : Form
    {
        string Sno;
        public Student_Grade(string sno)
        {
            InitializeComponent();
            Sno = sno;
            Table1();
            Table2();
        }
        private void Table1()
        {
            dataGridView1.Rows.Clear();
            string sql1 = "select Student_Course.Cno,Course.Cname,Teacher.Tname,Course.type,Course.credit,Student_Course.grade,Student_Course.level,Student_Course.grade_point,Student_Course.multi_point from Student_Course,Course,Teacher,Teacher_Course where Course.Cno=Student_Course.Cno and Course.Cno=Teacher_Course.Cno and Teacher_Course.Tno=Teacher.Tno  and Sno='" + Sno+"' ";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql1);
            while (dr.Read())
            {
                string l1, l2, l3, l4, l5, l6, l7, l8,l9;
                l1 = dr["Cno"].ToString();
                l2 = dr["Cname"].ToString();
                l3 = dr["Tname"].ToString();
                l4 = dr["type"].ToString();
                l5 = dr["credit"].ToString();
                l6 = dr["grade"].ToString();
                l7 = dr["level"].ToString();
                l8 = dr["grade_point"].ToString();
                l9 = dr["multi_point"].ToString();
                string[] str1 = { l1, l2, l3, l4, l5, l6, l7, l8,l9 };
                dataGridView1.Rows.Add(str1);
            }
        }
        private void Table2()
        {
            dataGridView2.Rows.Clear();
            string sql2 = "select distinct GPA from Student_Course Where Sno='" + Sno + "' ";
            Dao dao = new Dao();
            IDataReader dr2 = dao.read(sql2);
            while (dr2.Read())
            {
                string str2;
                str2 = dr2["GPA"].ToString();
                dataGridView2.Rows.Add(str2);
            }
        }

    }
}
