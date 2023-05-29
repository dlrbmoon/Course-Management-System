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

    public partial class Grade_Add : Form
    {
        string[] str = new string[3];
        public Grade_Add(string[] a)
        {
            InitializeComponent();
            // 传递原始数据
            for (int i = 0; i < 3; i++)
            {
                str[i] = a[i];
            }
            textBox1.Text = str[0];
            textBox2.Text = str[1];
            textBox3.Text = str[2];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("输入为空，请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBox3.Text != str[2])
                {
                    string sql = "update Student_Course set grade='" + textBox3.Text + "' where Sno='" + str[1] + "' and Cno='" + str[0] + "'";
                    Dao dao = new Dao();
                    dao.Execute(sql);
                    str[2] = textBox3.Text;
                    MessageBox.Show("录入成功");
                }
                else
                {
                    MessageBox.Show("成绩未发生变化");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
        }
    }
}
