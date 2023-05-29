using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学生选课管理系统.教室平面图
{
    public partial class Floor2 : Form
    {
        public Floor2(string Rno)
        {
            InitializeComponent();
            Floor2_Load(Rno);
        }
        public Floor2()
        {
            InitializeComponent();
        }

        private void Floor2_Load(string Rno)
        {
            if (Rno == "1-201     " || Rno == "2-201     ")
            {
                this.button1.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-202     " || Rno == "2-202     ")
            {
                this.button2.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-203     " || Rno == "2-203     ")
            {
                this.button3.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-204     " || Rno == "2-204     ")
            {
                this.button4.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-205     " || Rno == "2-205     ")
            {
                this.button5.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-206     " || Rno == "2-206     ")
            {
                this.button6.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-207     " || Rno == "2-207     ")
            {
                this.button7.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-208     " || Rno == "2-208     ")
            {
                this.button8.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-209     " || Rno == "2-209     ")
            {
                this.button9.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-210     " || Rno == "2-210     ")
            {
                this.button10.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-211     " || Rno == "2-211     ")
            {
                this.button11.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-112     " || Rno == "2-212     ")
            {
                this.button12.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-213     " || Rno == "2-213     ")
            {
                this.button13.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-214     " || Rno == "2-214     ")
            {
                this.button14.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-215     " || Rno == "2-215     ")
            {
                this.button15.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-116     " || Rno == "2-216     ")
            {
                this.button16.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-217     " || Rno == "2-217     ")
            {
                this.button17.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-218     " || Rno == "2-218     ")
            {
                this.button18.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-219     " || Rno == "2-219     ")
            {
                this.button19.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-220     " || Rno == "2-220     ")
            {
                this.button20.BackColor = Color.OrangeRed;
            }
            else
            {
                MessageBox.Show("此教室不存在！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
