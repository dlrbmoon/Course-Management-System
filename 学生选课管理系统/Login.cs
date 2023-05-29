using System.Data;


namespace 学生选课管理系统
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X < 150)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 1, pictureBox1.Location.Y);
                pictureBox3.Visible = true;
            }
            else
            {
                timer1.Stop();
                if (comboBox1.Text == "学生")
                {
                    Dao dao = new Dao();
                    string sql = $"select * from Student_Password where Spass='{textBox2.Text}' and (Sno='{textBox1.Text}' )";
                    IDataReader dr = dao.read(sql);
                    dr.Read();
                    string Sno = dr["Sno"].ToString();
                    Choose_Course form1 = new Choose_Course(Sno);
                    form1.Show();   //显示该窗体
                    this.Hide();    //隐藏主窗体
                }
                if (comboBox1.Text == "教师")
                {
                    Dao dao = new Dao();
                    string sql = $"select * from Teacher_Password where Tpass='{textBox2.Text}' and (Tno='{textBox1.Text}' )";
                    IDataReader dr = dao.read(sql);
                    dr.Read();
                    string Tno = dr["Tno"].ToString();
                    Teacher_Grade form2 = new Teacher_Grade(Tno);
                    form2.Show();
                    this.Hide();
                }
                if (comboBox1.Text == "管理员")
                {
                    Admin form4 = new Admin();
                    form4.Show();
                    this.Hide();
                }

            }
        }

        // 登录事件
        private void button1_Click(object sender, EventArgs e)
        {
            // 登录成功
            if (login())
            {
                timer1.Start();
                textBox1.Visible = false;
                textBox2.Visible = false;
                comboBox1.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
            }
            else
            {
                MessageBox.Show("账号或密码不正确，请重新输入", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool login()
        {
            // 账号或密码为空时登录失败
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("输入不完整，请重新输入", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // 权限为空时登录失败
            if (comboBox1.Text == "")
            {
                MessageBox.Show("请选择您的权限", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (comboBox1.Text == "学生")
            {
                Dao dao = new Dao();
                string sql = $"select * from Student_Password where Spass='{textBox2.Text}' and (Sno='{textBox1.Text}' )";
                IDataReader dr = dao.read(sql);
                if (dr.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (comboBox1.Text == "教师")
            {
                Dao dao = new Dao();
                string sql = $"select * from Teacher_Password where Tpass='{textBox2.Text}' and (Tno='{textBox1.Text}' )";
                IDataReader dr = dao.read(sql);
                if (dr.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (comboBox1.Text == "管理员")
            {
                Dao dao = new Dao();
                string sql = $"select * from Admin_Password where Apass='{textBox2.Text}' and (Ano='{textBox1.Text}' )";
                IDataReader dr = dao.read(sql);
                if (dr.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            comboBox1.Text = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
}