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
    public partial class Floor3 : Form
    {
        public Floor3(string Rno)
        {
            InitializeComponent();
            Floor3_Load(Rno);
        }
        public Floor3()
        {
            InitializeComponent();
        }
        private void Floor3_Load(string Rno)
        {
            if (Rno == "1-302     "|| Rno == "2-302     ")
            {
                this.button2.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-303     "|| Rno == "2-303     ")
            {
                this.button3.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-304     "|| Rno == "2-304     ")
            {
                this.button4.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-305     "|| Rno == "2-305     ")
            {
                this.button5.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-306     " || Rno == "2-306     ")
            {
                this.button6.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-307     " || Rno == "2-307     ")
            {
                this.button7.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-308     " || Rno == "2-308     ")
            {
                this.button8.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-309     " || Rno == "2-309     ")
            {
                this.button9.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-310     " || Rno == "2-310     ")
            {
                this.button10.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-311     " || Rno == "2-311     ")
            {
                this.button11.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-312     " || Rno == "2-312     ")
            {
                this.button12.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-313     " || Rno == "2-313     ")
            {
                this.button13.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-314     " || Rno == "2-314     ")
            {
                this.button14.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-315     "|| Rno == "2-315     ")
            {
                this.button15.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-316     " || Rno == "2-316     ")
            {
                this.button16.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-317     " || Rno == "2-317     ")
            {
                this.button17.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-318     " || Rno == "2-318     ")
            {
                this.button18.BackColor = Color.OrangeRed;
            }
            else
            {
                MessageBox.Show("此教室不存在！");
            }
        }
    }
}
