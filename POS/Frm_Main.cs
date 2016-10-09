using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace POS
{
    public partial class Frm_Main : MetroForm
    {
        SqlConnection conn = new SqlConnection();
        public Frm_Main()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        private void invetoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_product fcrud = new Frm_product();
            fcrud.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            conn.Open();
            lbl_dbStatus.Text = "Connected";
            conn.Close();

            lbl_accountStats.Text = Frm_Login.userType;
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Frm_Staff fstaff = new Frm_Staff();
            fstaff.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Frm_product fproduct = new Frm_product();
            fproduct.ShowDialog();
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_Login flogin = new Frm_Login();
            flogin.Show();
            
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Frm_POS fpos = new Frm_POS();
            fpos.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Frm_category fcategory = new POS.Frm_category();
            fcategory.ShowDialog();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            Frm_settingsSystem fsystem = new Frm_settingsSystem();
            fsystem.ShowDialog();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
