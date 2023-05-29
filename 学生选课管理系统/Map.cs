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
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "一组团")
            {
                if (comboBox2.Text == "公教一")
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox15.Visible = false;
                }
                else if (comboBox2.Text == "公教二")
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox15.Visible = false;
                }
                else if (comboBox2.Text == "地理与信息工程学院")
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox15.Visible = false;
                }
                else
                {
                    MessageBox.Show("查询失败！请检查您的输入内容！", "查询失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (comboBox1.Text == "二组团")
            {
                if (comboBox2.Text == "公教一")
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox15.Visible = false;
                }
                else if (comboBox2.Text == "公教二")
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox15.Visible = false;
                }
                else if (comboBox2.Text == "地理与信息工程学院")
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = true;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox15.Visible = false;
                }
                else
                {
                    MessageBox.Show("查询失败！请检查您的输入内容！", "查询失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (comboBox1.Text == "三组团")
            {
                if (comboBox2.Text == "公教一")
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = true;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox15.Visible = false;
                }
                else if (comboBox2.Text == "公教二")
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = true;
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox15.Visible = false;
                }
                else if (comboBox2.Text == "地理与信息工程学院")
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = true;
                    pictureBox10.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox15.Visible = false;
                }
                else
                {
                    MessageBox.Show("查询失败！请检查您的输入内容！", "查询失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (comboBox1.Text == "四组团")
            {
                if (comboBox2.Text == "公教一")
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = true;
                    pictureBox11.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox15.Visible = false;
                }
                else if (comboBox2.Text == "公教二")
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox11.Visible = true;
                    pictureBox12.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox15.Visible = false;
                }
                else if (comboBox2.Text == "地理与信息工程学院")
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox12.Visible = true;
                    pictureBox13.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox15.Visible = false;
                }
                else
                {
                    MessageBox.Show("查询失败！请检查您的输入内容！", "查询失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (comboBox1.Text == "五组团")
            {
                if (comboBox2.Text == "公教一")
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox13.Visible = true;
                    pictureBox14.Visible = false;
                    pictureBox15.Visible = false;
                }
                else if (comboBox2.Text == "公教二")
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox14.Visible = true;
                    pictureBox15.Visible = false;
                }
                else if (comboBox2.Text == "地理与信息工程学院")
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox15.Visible = true;
                }
                else
                {
                    MessageBox.Show("查询失败！请检查您的输入内容！", "查询失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("查询失败！请检查您的输入内容！", "查询失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
