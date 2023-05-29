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
    public partial class Course_Add : Form
    {
        string[] str = new string[8];
        // 构造函数，用于添加操作
        public Course_Add()
        {
            InitializeComponent();
            button3.Visible = false; //隐藏修改按钮
            button1.Visible = true;
        }

        // 构造函数，用于修改操作
        public Course_Add(string[] a)
        {
            InitializeComponent();
            // 传递原始数据
            for (int i = 0; i < 8; i++)
            {
                str[i] = a[i];
            }
            textBox1.Text = str[0];
            textBox2.Text = str[1];
            textBox3.Text = str[3];
            textBox4.Text = str[5];
            textBox5.Text = str[4];
            textBox6.Text = str[7];
            comboBox1.Text = str[2];
            textBox7.Text = str[6];
            button1.Visible = false;    // 隐藏保存按钮
            button3.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == ""  || comboBox1.Text == "")
            {
                MessageBox.Show("输入不完整，请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql1 = "insert into Course values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox7.Text + "')";
                string sql2 = "insert into Teacher_Course values('" + textBox1.Text + "','" + textBox6.Text + "')";
                Dao dao = new Dao();
                dao.Execute(sql1); 
                dao.Execute(sql2);
                
                
                MessageBox.Show("添加成功");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "一层")
            {
                pictureBox1.Visible = true;
                button4.Visible= true;
                button5.Visible= true;
                button6.Visible= true;          
                button7.Visible= true;
                button8.Visible= true;
                button9.Visible= true;
                button10.Visible= true;
                button11.Visible= true;
                button12.Visible= true;
                button13.Visible= true;
                button14.Visible= true;
                button15.Visible= true;
                button16.Visible= true;
                button17.Visible= true;
                button18.Visible= true;
                button19.Visible= true;
                button20.Visible= true;
                button21.Visible= true;
                button23.Visible= true;
                button24.Visible= true;
            }
            if (comboBox2.Text == "二层")
            {
                pictureBox2.Visible = true;
                button25.Visible= true;
                button26.Visible= true;
                button27.Visible= true;
                button28.Visible= true;
                button29.Visible= true;
                button30.Visible= true;
                button31.Visible= true;
                button32.Visible= true;
                button33.Visible= true;
                button34.Visible= true;
                button35.Visible= true;
                button36.Visible= true;
                button37.Visible= true;
                button38.Visible= true;
                button39.Visible= true;
                button40.Visible= true;
                button41.Visible= true;
                button42.Visible= true;
                button43.Visible= true;
                button44.Visible= true;

            }
            if (comboBox2.Text == "三层")
            {
                pictureBox3.Visible = true;
                button45.Visible= true;
                button46.Visible= true;
                button47.Visible= true;
                button48.Visible= true;
                button49.Visible= true;
                button50.Visible= true;
                button51.Visible= true;
                button52.Visible= true;
                button53.Visible= true;
                button54.Visible= true;
                button55.Visible= true;
                button56.Visible= true;
                button57.Visible= true;
                button58.Visible= true;
                button59.Visible= true;
                button60.Visible= true;
                button61.Visible= true;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("修改后信息不完整，请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBox1.Text != str[0])
                {
                    string sql = "update Course set Cno='" + textBox1.Text + "' where Cno='" + str[0] + "'";
                    Dao dao = new Dao();
                    dao.Execute(sql);
                    str[0] = textBox1.Text;
                }
                if (textBox2.Text != str[1])
                {
                    string sql = "update Course set Cname='" + textBox2.Text + "' where Cno='" + str[0] + "'";
                    Dao dao = new Dao();
                    dao.Execute(sql);
                    str[1] = textBox2.Text;
                }
                if (textBox3.Text != str[2])
                {
                    string sql = "update Course set credit='" + textBox3.Text + "' where Cno='" + str[0] + "'";
                    Dao dao = new Dao();
                    dao.Execute(sql);
                    str[2] = textBox3.Text;
                }
                if (textBox4.Text != str[3])
                {
                    string sql = "update Course set capacity='" + textBox4.Text + "' where Cno='" + str[0] + "'";
                    Dao dao = new Dao();
                    dao.Execute(sql);
                    str[3] = textBox4.Text;
                }
                if (textBox5.Text != str[4])
                {
                    string sql = "update Course set time='" + textBox5.Text + "' where Cno='" + str[0] + "'";
                    Dao dao = new Dao();
                    dao.Execute(sql);
                    str[4] = textBox5.Text;
                }
                if (textBox6.Text != str[5])
                {
                    string sql = "update Teacher_Course set Tno='" + textBox6.Text + "' where Cno='" + str[0] + "'";
                    Dao dao = new Dao();
                    dao.Execute(sql);
                    str[5] = textBox6.Text;
                }
                if (comboBox1.Text != str[6])
                {
                    string sql = "update Course set type='" + comboBox1.Text + "' where Cno='" + str[0] + "'";
                    Dao dao = new Dao();
                    dao.Execute(sql);
                    str[6] = comboBox1.Text;
                }
                if (textBox7.Text != str[7])
                {
                    string sql = "update Course set Rno='" + textBox7.Text + "' where Cno='" + str[0] + "'";
                    Dao dao = new Dao();
                    dao.Execute(sql);
                    str[7] = textBox7.Text;
                }
                MessageBox.Show("修改成功");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button24.Text;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button22.Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button21.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button12.Text;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button13.Text;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button14.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button15.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button16.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button17.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button18.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button19.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button20.Text;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button25.Text;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button26.Text;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button27.Text;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button28.Text;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button29.Text;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button30.Text;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button31.Text;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button32.Text;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button33.Text;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button34.Text;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button35.Text;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button36.Text;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button37.Text;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button38.Text;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button39.Text;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button41.Text;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button40.Text;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button42.Text;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button43.Text;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button44.Text;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button45.Text;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button46.Text;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button47.Text;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button48.Text;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button49.Text;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button50.Text;
        }

        private void button51_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button51.Text;
        }

        private void button52_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button52.Text;
        }

        private void button53_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button53.Text;
        }

        private void button54_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button54.Text;
        }

        private void button55_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button55.Text;
        }

        private void button56_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button56.Text;
        }

        private void button57_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button57.Text;
        }

        private void button58_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button58.Text;
        }

        private void button59_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button59.Text;
        }

        private void button60_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button60.Text;
        }

        private void button61_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.button61.Text;
        }
    }
}
