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
    public partial class Teacher_Add : Form
    {
        string[] str = new string[5];

        // 构造函数，用于添加操作
        public Teacher_Add()
        {
            InitializeComponent();
            button3.Visible = false; //隐藏修改按钮
            button1.Visible = true;
        }

        // 构造函数，用于修改操作
        public Teacher_Add(string[] a)
        {
            InitializeComponent();
            // 传递原始数据
            for (int i = 0; i < 4; i++)
            {
                str[i] = a[i];
            }
            textBox1.Text = str[0];
            textBox2.Text = str[1];
            textBox3.Text = str[2];
            textBox4.Text = str[3];
            textBox5.Text = str[4];
            button1.Visible = false;    // 隐藏保存按钮
            button3.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("输入不完整，请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql = "insert into Teacher values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                Dao dao = new Dao();
                int i = dao.Execute(sql);
                if (i > 0)
                {
                    MessageBox.Show("添加成功");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" )
            {
                MessageBox.Show("修改后信息不完整，请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBox1.Text != str[0])
                {
                    string sql = "update Teacher set Tno='" + textBox1.Text + "' where Tno='" + str[0] + "'";
                    Dao dao = new Dao();
                    dao.Execute(sql);
                    str[0] = textBox1.Text;
                }
                if (textBox2.Text != str[1])
                {
                    string sql = "update Teacher set Tname='" + textBox2.Text + "' where Tno='" + str[0] + "'";
                    Dao dao = new Dao();
                    dao.Execute(sql);
                    str[1] = textBox2.Text;
                }
                if (textBox3.Text != str[2])
                {
                    string sql = "update Teacher set post='" + textBox3.Text + "' where Tno='" + str[0] + "'";
                    Dao dao = new Dao();
                    dao.Execute(sql);
                    str[2] = textBox3.Text;
                }
                if (textBox4.Text != str[3])
                {
                    string sql = "update Teacher set Tphone='" + textBox4.Text + "' where Tno='" + str[0] + "'";
                    Dao dao = new Dao();
                    dao.Execute(sql);
                    str[3] = textBox4.Text;
                }
                if (textBox5.Text != str[4])
                {
                    string sql = "update Teacher set Dno='" + textBox5.Text + "' where Tno='" + str[0] + "'";
                    Dao dao = new Dao();
                    dao.Execute(sql);
                    str[4] = textBox5.Text;
                }
                MessageBox.Show("修改成功");
            }
        }
    }
}
