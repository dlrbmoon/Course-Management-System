using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

// 工具→连接到数据库→SQL Server→填写服务器名称，数据库名称等
namespace 学生选课管理系统
{
    class Dao
    {
        // 链接数据库
        public SqlConnection connect()  // CS1069报错：工具→NuGet包管理器→管理解决方案的NuGet程序包→搜索安装System.Data.SqlClient
        {
            string str = "Data Source=DESKTOP-K4RTCMM;Initial Catalog=Course_Managemnent_System;Integrated Security=True";
            SqlConnection sc = new SqlConnection(str);
            sc.Open();      // 打开数据库链接
            return sc;
        }

        // 数据库操作 
        public SqlCommand command(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connect());    // 调用connect
            return cmd;
        }

        // delete insert update 返回受影响的行数
        public int Execute(string sql)
        {
            return command(sql).ExecuteNonQuery();
        }

        // select 返回数据对象
        public SqlDataReader read(string sql)
        {
            return command(sql).ExecuteReader();
        }

    }

}

