using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace surveyApp
{
    public partial class 관리자로그인 : UserControl
    {
        MainForm mf;
        Bool_inf state;
        public 관리자로그인(MainForm mf, Bool_inf state)
        {
            this.mf = mf;
            this.state = state;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\user\Documents\admin_login.mdf; Integrated Security = True; Connect Timeout = 30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from USERINFO where USERNAME='"+id_text.Text+"' and PASSWORD='"+pwd_text.Text+"'",con);
            DataTable loginTable = new DataTable();

            sda.Fill(loginTable);

            if(loginTable.Rows[0][0].ToString() == "1")
            {
                this.mf.Controls.Clear();
                this.mf.Controls.Add(new AdminForm());
            }
            else
            {
                MessageBox.Show("아이디와 비밀번호를 확인해주세요.");
           }

           //if(id_text.Text == "admin" && pwd_text.Text == "0000")
           //{
           //this.mf.Controls.Clear();
           //this.mf.Controls.Add(new AdminForm());
           //} 
           //else
           // {
           // MessageBox.Show("아이디와 비밀번호를 확인해주세요.");
           //}
        }
    }
}
