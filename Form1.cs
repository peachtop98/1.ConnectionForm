using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _1.ConnectionForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=阿斯顿\\SQLEXPRESS;Initial Catalog=School;User ID=sa;Password=123456";
            //string connStr = "server=阿斯顿/SQLEXPRESS;uid=sa;pwd=123456;database=School";
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                MessageBox.Show("数据库连接成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库连接失败！" + ex.Message);
            }
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
