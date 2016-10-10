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
    public partial class Frm_selectCategory : MetroForm
    {
        public static string category = "";

        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public void loadtable()
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "select * from tbl_category";
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            ListView1.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["category_number"].ToString());
                item.SubItems.Add(reader["category_name"].ToString());
                item.SubItems.Add(reader["description"].ToString());
                ListView1.Items.Add(item);

            }
            conn.Close();
        }
        public Frm_selectCategory()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        private void Frm_selectCategory_Load(object sender, EventArgs e)
        {
            loadtable();
        }

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
            txt_catName.Text = ListView1.SelectedItems[0].SubItems[1].Text;
            category = txt_catName.Text;
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_catName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
