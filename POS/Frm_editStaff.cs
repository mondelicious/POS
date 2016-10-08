using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace POS
{
    public partial class Frm_editStaff : MetroForm
    {
        public static string eCode = "";
        public static string lastName = "";
        public static string firstName = "";
        public static string middleName = "";
        public static string street = "";
        public static string barangay = "";
        public static string city = "";
        public static string province = "";
        public static string contactNumber = "";
        public static string userName = "";
        public static string passWord = "";
        public static string role = "";

        SqlConnection conn = new SqlConnection();


        public void clearUpdate()
        {
            txt_ln.Text = null;
            txt_fn.Text = null;
            txt_mi.Text = null;
            txt_street.Text = null;
            txt_brgy.Text = null;
            txt_city.Text = null;
            txt_province.Text = null;
            txt_contact.Text = null;
            txt_un.Text = null;
            txt_pw.Text = null;
            cBoxRole.Text = null;
        }
        public Frm_editStaff()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        private void Frm_editStaff_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_staff WHERE employee_number = @eid", conn);
            cmd.Parameters.AddWithValue("eid", txt_employeeID.Text);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();

            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
                string gEmployID = reader.GetInt32(reader.GetOrdinal("employee_number")).ToString();
                string glName = reader.GetString(reader.GetOrdinal("last_name"));
                string gfName = reader.GetString(reader.GetOrdinal("first_name"));
                string gmName = reader.GetString(reader.GetOrdinal("middle_name"));
                string gStreet = reader.GetString(reader.GetOrdinal("street"));
                string gBrgy = reader.GetString(reader.GetOrdinal("barangay"));
                string gCity = reader.GetString(reader.GetOrdinal("city"));
                string gProvince = reader.GetString(reader.GetOrdinal("province"));
                string gContact = reader.GetString(reader.GetOrdinal("contact_number"));
                string gUsername = reader.GetString(reader.GetOrdinal("username"));
                string gPassword = reader.GetString(reader.GetOrdinal("password"));
                string gRole = reader.GetString(reader.GetOrdinal("role"));

                txt_ln.Text = glName;
                txt_fn.Text = gfName;
                txt_mi.Text = gmName;
                txt_street.Text = gStreet;
                txt_brgy.Text = gBrgy;
                txt_city.Text = gCity;
                txt_province.Text = gProvince;
                txt_contact.Text = gContact;
                txt_un.Text = gUsername;
                txt_pw.Text = gPassword;
                cBoxRole.Text = gRole;
            }
            if (count == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "No records found!", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clearUpdate();
            }
            else
            {
                //TODO:NOTHING
            }
            conn.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Do you want to update this information?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                eCode = txt_employeeID.Text;
                lastName = txt_ln.Text;
                firstName = txt_fn.Text;
                middleName = txt_mi.Text;
                street = txt_street.Text;
                barangay = txt_brgy.Text;
                city = txt_city.Text;
                province = txt_province.Text;
                contactNumber = txt_contact.Text;
                userName = txt_un.Text;
                passWord = txt_pw.Text;
                role = cBoxRole.Text;
                Cls_cmd.EditStaff();
                btn_edit.Show();
                MetroFramework.MetroMessageBox.Show(this, "Update complete!", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                //TODO: NOTHING
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            btn_edit.Hide();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
