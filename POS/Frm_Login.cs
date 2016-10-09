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
using System.Configuration;
using MetroFramework.Forms;
using MetroFramework;

namespace POS
{
    public partial class Frm_Login : MetroForm
    {
        public static string userType = "";

        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public Frm_Login()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {


        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;
            string LOGIN = "SELECT * FROM tbl_UserInfo WHERE Username = @un AND Password = @pwd AND Role = @rl";
            cmd.Parameters.AddWithValue("un", txt_un.Text);
            cmd.Parameters.AddWithValue("pwd", txt_pw.Text);
            cmd.Parameters.AddWithValue("rl", cBoxUser.Text);
            cmd.CommandText = LOGIN;
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                if (cBoxUser.Text == "Admin")
                {
                    MetroMessageBox.Show(this, "Welcome " + txt_un.Text, "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    userType = cBoxUser.Text;
                    Frm_Main fmain = new Frm_Main();
                    fmain.Show();
                    Hide();
                }
                else if(cBoxUser.Text == "Cashier")
                {
                    MetroMessageBox.Show(this, "Welcome " + txt_un.Text, "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    userType = cBoxUser.Text;
                    Frm_POS fpos = new Frm_POS();
                    fpos.Show();
                    Hide();
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Wrong password/username/usertype. Please check again.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conn.Close();
            cmd.Parameters.Clear();
        }
    }
}
