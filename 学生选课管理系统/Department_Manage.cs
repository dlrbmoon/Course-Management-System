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
    public partial class Department_Manage : Form
    {
        public Department_Manage()
        {
            InitializeComponent();
            Table();
        }
        private void Table()
        {
            dataGridView1.Rows.Clear();
            string sql = "select * from Department";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string l1, l2, l3;
                l1 = dr["Dno"].ToString();
                l2 = dr["Dname"].ToString();
                l3 = dr["Dphone"].ToString();
                string[] str = { l1, l2, l3 };
                dataGridView1.Rows.Add(str);
            }
        }

        private void 添加院系信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Department_Add form = new Department_Add();
            form.ShowDialog();
            Table();
        }

        private void 修改院系信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] str = { dataGridView1.SelectedCells[0].Value.ToString(), dataGridView1.SelectedCells[1].Value.ToString(), dataGridView1.SelectedCells[2].Value.ToString() };
            Department_Add form = new Department_Add(str);
            form.ShowDialog();
            Table();
        }

        private void 删除院系信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("确定要删除吗", "提示", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                string l1, l2, l3;
                l1 = dataGridView1.SelectedCells[0].Value.ToString();
                l2 = dataGridView1.SelectedCells[1].Value.ToString();
                l3 = dataGridView1.SelectedCells[2].Value.ToString();
                string sql = "delete from Department where Dno='" + l1 + "'and Dname='" + l2 + "' and Dphone='" + l3 + "'";
                MessageBox.Show(sql);
                Dao dao = new Dao();
                dao.Execute(sql);
                Table();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Table();
        }

        private void 系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
