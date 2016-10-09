using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace POS
{
    public partial class Frm_settingsSystem : MetroForm
    {
        public static string nameCompany = "";
        public static string Address = "";
        public static string phoneNumber = "";
        public static string eAddress = "";
        public static string Website = "";
        public static string tinNumber = "";
        public static string vat = "";
        public Frm_settingsSystem()
        {
            InitializeComponent();
        }

        private void Frm_settingsSystem_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectTab(tabPage3);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Do you want to save this information?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                nameCompany = txt_name.Text;
                Address = txt_address.Text;
                phoneNumber = txt_phoneNo.Text;
                eAddress = txt_email.Text;
                Website = txt_website.Text;
                tinNumber = txt_TINNumber.Text;
                Cls_cmd.AddCompany();
                MetroMessageBox.Show(this, "Saved successfully!", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //TODO:NOTHING
            }
        }

        private void btn_saveVAT_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Do you want to save this information?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                vat = txt_percent.Text;
                Cls_cmd.AddVat();
                MetroMessageBox.Show(this, "Saved successfully!", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //TODO:IF NO, DO NOTHING.
            }

        }
    }
}
