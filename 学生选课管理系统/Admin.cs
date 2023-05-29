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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student_Manage form = new Student_Manage();
            form.Show();   //显示该窗体
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teacher_Manage form = new Teacher_Manage();
            form.Show();   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Course_Manage form = new Course_Manage();
            form.Show();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Classroom_Manage form = new Classroom_Manage();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Department_Manage form = new Department_Manage();
            form.Show();
        }
    }
}
