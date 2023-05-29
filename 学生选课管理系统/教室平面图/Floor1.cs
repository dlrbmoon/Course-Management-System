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
    public partial class Floor1 : Form
    {
        public Floor1(string Rno)
        {
            InitializeComponent();
            Floor1_Load(Rno);
        }
        public Floor1()
        {
            InitializeComponent();
        }

        private void Floor1_Load(string Rno)
        {
            if (Rno== "1-101     " || Rno == "2-101     ")
            {
                this.button1.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-102     " || Rno == "2-102     ")
            {
                this.button2.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-103     " || Rno == "2-103     ")
            {
                this.button3.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-104     " || Rno == "2-104     ")
            {
                this.button4.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-105     " || Rno == "2-105     ")
            {
                this.button5.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-106     " || Rno == "2-106     ")
            {
                this.button6.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-107     " || Rno == "2-107     ")
            {
                this.button7.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-108     " || Rno == "2-108     ")
            {
                this.button8.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-109     " || Rno == "2-109     ")
            {
                this.button9.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-110     " || Rno == "2-110     ")
            {
                this.button10.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-111     " || Rno == "2-111     ")
            {
                this.button11.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-112     " || Rno == "2-112     ")
            {
                this.button12.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-113     " || Rno == "2-113     ")
            {
                this.button13.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-114     " || Rno == "2-114     ")
            {
                this.button14.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-115     " || Rno == "2-115     ")
            {
                this.button15.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-116     " || Rno == "2-116     ")
            {
                this.button16.BackColor = Color.OrangeRed;
            }   
            else if (Rno == "1-117     " || Rno == "2-117     ")
            {
                this.button17.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-118     " || Rno == "2-118     ")
            {
                this.button18.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-119     " || Rno == "2-119     ")
            {
                this.button19.BackColor = Color.OrangeRed;
            }
            else if (Rno == "1-120     " || Rno == "2-120     ")
            {
                this.button20.BackColor = Color.OrangeRed;
            }
            else
            {
                MessageBox.Show("此教室不存在！");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
