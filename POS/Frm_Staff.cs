using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace POS
{
    public partial class Frm_Staff : MetroForm
    { 
        //add param
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

         int incNumber = 0;
        
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();


        public void User()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_UserInfo WHERE Employee_ID = @eid", conn);
            cmd.Parameters.AddWithValue("eid", txt_searchUpdate.Text);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();

            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
                string gEmployID = reader.GetInt32(reader.GetOrdinal("Employee_ID")).ToString();
                string glName = reader.GetString(reader.GetOrdinal("Last_name"));
                string gfName = reader.GetString(reader.GetOrdinal("First_name"));
                string gmName = reader.GetString(reader.GetOrdinal("Middle_name"));
                string gStreet = reader.GetString(reader.GetOrdinal("Street"));
                string gBrgy = reader.GetString(reader.GetOrdinal("Brgy"));
                string gCity = reader.GetString(reader.GetOrdinal("City"));
                string gProvince = reader.GetString(reader.GetOrdinal("Province"));
                string gContact = reader.GetString(reader.GetOrdinal("Contact_number"));

                txt_eid.Text = gEmployID;
                txt_lnUpdate.Text = glName;
                txt_fnUpdate.Text = gfName;
                txt_miUpdate.Text = gmName;
                txt_streetUpdate.Text = gStreet;
                txt_brgyUpdate.Text = gBrgy;
                txt_cityUpdate.Text = gCity;
                txt_provinceUpdate.Text = gProvince;
                txt_contactUpdate.Text = gContact;
            }
            if (count == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "No records found!", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clearupdate();
            }
            else
            {
                //TODO:NOTHING
            }
            conn.Close();
            cmd.Parameters.Clear();
        }

        public void clearupdate()
        {
            txt_eid.Text = null;
            txt_lnUpdate.Text = null;
            txt_fnUpdate.Text = null;
            txt_miUpdate.Text = null;
            txt_streetUpdate.Text = null;
            txt_brgyUpdate.Text = null;
            txt_cityUpdate.Text = null;
            txt_provinceUpdate.Text = null;
            txt_contactUpdate.Text = null;
        }

        
        public Frm_Staff()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        private void Frm_mainStaff_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = tabPage1;

            //string nyNumber = "EID" + incNumber.ToString("0000");
            //incNumber++;

            //txt_employeeID.Text = nyNumber;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
         
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Do you want to add this information?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                Cls_cmd.AddStaff();
                Cls_cmd.AddUser();
                MetroFramework.MetroMessageBox.Show(this, "Registration complete!", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //TODO: NOTHING
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT tbl_S.Employee_ID, tbl_S.Uid, tbl_S.Last_name, tbl_s.First_name, tbl_S.Middle_name, tbl_S.Street, tbl_S.Brgy, tbl_S.City, tbl_S.Province, tbl_S.Contact_number, tbl_U.Username, tbl_U.Password, tbl_U.Role FROM tbl_StaffInformation AS tbl_S INNER JOIN tbl_UserInfo AS tbl_U ON tbl_S.Uid = tbl_U.Uid WHERE tbl_S.Employee_ID = @eid", conn);
            cmd.Parameters.AddWithValue("eid", txt_searchUpdate.Text);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();

            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
                string gEmployID = reader.GetString(reader.GetOrdinal("Employee_ID")).ToString();
                string gUid = reader.GetInt32(reader.GetOrdinal("Uid")).ToString();
                string glName = reader.GetString(reader.GetOrdinal("Last_name"));
                string gfName = reader.GetString(reader.GetOrdinal("First_name"));
                string gmName = reader.GetString(reader.GetOrdinal("Middle_name"));
                string gStreet = reader.GetString(reader.GetOrdinal("Street"));
                string gBrgy = reader.GetString(reader.GetOrdinal("Brgy"));
                string gCity = reader.GetString(reader.GetOrdinal("City"));
                string gProvince = reader.GetString(reader.GetOrdinal("Province"));
                string gContact = reader.GetString(reader.GetOrdinal("Contact_number"));
                string gUser = reader.GetString(reader.GetOrdinal("Username"));
                string gPass = reader.GetString(reader.GetOrdinal("Password"));
                string gRole = reader.GetString(reader.GetOrdinal("Role"));

                txt_eid.Text = gEmployID;
                txt_uid.Text = gUid;
                txt_lnUpdate.Text = glName;
                txt_fnUpdate.Text = gfName;
                txt_miUpdate.Text = gmName;
                txt_streetUpdate.Text = gStreet;
                txt_brgyUpdate.Text = gBrgy;
                txt_cityUpdate.Text = gCity;
                txt_provinceUpdate.Text = gProvince;
                txt_contactUpdate.Text = gContact;
                txt_unUpdate.Text = gUser;
                txt_pwUpdate.Text = gPass;
                cBoxRoleUpdate.Text = gRole;
            }
            if (count == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "No records found!", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clearupdate();
            }
            else
            {
                //TODO:NOTHING
            }
            conn.Close();
            cmd.Parameters.Clear();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (cBoxSearchBy.Text == "Employee ID")
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT tbl_S.Employee_ID, tbl_S.Uid, (tbl_S.Last_name+' '+tbl_s.First_name+' '+tbl_S.Middle_name)[Full name], tbl_S.Street, tbl_S.Brgy, tbl_S.City, tbl_S.Province, tbl_S.Contact_number, tbl_U.Username, tbl_U.Password, tbl_U.Role FROM tbl_StaffInformation AS tbl_S INNER JOIN tbl_UserInfo AS tbl_U ON tbl_S.Uid = tbl_U.Uid WHERE tbl_S.Employee_ID = @eid";
                cmd.Parameters.AddWithValue("eid", txt_search.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                metroGrid1.DataSource = dt;
                metroGrid1.Refresh();
                conn.Close();
                cmd.Parameters.Clear();
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //auto increment
            //int counter = 0;
            //string sampleNum = "s" + counter++.ToString("00");
            //counter++;

            string nyNumber = "s" + incNumber.ToString("00");
            incNumber++;

            txt_employeeID.Text = nyNumber;
        }
    }
}
