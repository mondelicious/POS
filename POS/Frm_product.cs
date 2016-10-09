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
using MetroFramework;

namespace POS
{
    public partial class Frm_product : MetroForm
    {
        //add
        public static string productNo = "";
        public static string productCode = "";
        public static string description = "";
        public static string barcode = "";
        public static string category = "";
        public static string unitPrice = "";
        public static string quantityStock = "";
        public static string reorderLevel = "";

        //update
        public static string productNoUpdate = "";
        public static string productCodeUpdate = "";
        public static string descriptionUpdate = "";
        public static string barcodeUpdate = "";
        public static string categoryUpdate = "";
        public static string unitPriceUpdate = "";
        public static string quantityStockUpdate = "";
        public static string reorderLevelUpdate = "";

        //add stock
        public static string Stock = "";
        public static string productCodeStock = "";


        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public void loadCategory()
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM tbl_Category";
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string gCategory = reader.GetString(reader.GetOrdinal("Category_name"));
                cBoxCategory.Items.Add(gCategory);
                cBoxCatUpdate.Items.Add(gCategory);
            }
            conn.Close();
        }
        public void empty()
        {
            txt_productCode.Text = null;
        }
        public Frm_product()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            loadCategory();
        }
        private void Frm_CRUD_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectTab(metroTabPage1);
        } 

        private void metroTile1_Click(object sender, EventArgs e)
        {
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //metroPanel1.Hide();
            empty();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_exitUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btn_category_Click(object sender, EventArgs e)
        {
            Frm_selectCategory fcat = new Frm_selectCategory();
            fcat.ShowDialog();
        }

        private void btn_Add_Click_1(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Do you want to add this information?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                productNo = lbl_productNo.Text;
                productCode = txt_productCode.Text;
                description = txt_description.Text;
                barcode = txt_barCode.Text;
                category = cBoxCategory.Text;
                unitPrice = txt_unitPrice.Text;
                quantityStock = txt_stocksOnHand.Text;
                reorderLevel = txt_reorderLevel.Text;
                Cls_cmd.AddProduct();
                MetroMessageBox.Show(this, "Registration complete!", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //TODO: NOTHING
            }

        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            empty();

        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_ProductInfo WHERE Product_Code = @ecode", conn);
            cmd.Parameters.AddWithValue("ecode", txt_search.Text);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();

            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
                //string gProductNumber = reader.GetInt32(reader.GetOrdinal("product_number")).ToString();
                string gDescription = reader.GetString(reader.GetOrdinal("Product_Code"));
                string gProductCode = reader.GetString(reader.GetOrdinal("Description"));
                string gBarcode = reader.GetString(reader.GetOrdinal("Barcode"));
                string gCategory = reader.GetString(reader.GetOrdinal("Category"));
                string gUnitprice = reader.GetInt32(reader.GetOrdinal("Unit_Price")).ToString();
                string gQuantity = reader.GetInt32(reader.GetOrdinal("Stock")).ToString();
                string gReorder = reader.GetString(reader.GetOrdinal("Reorder_level"));

                //txt_productCodeUpdate.Text = gProductNumber;
                txt_productCodeUpdate.Text = gProductCode;
                txt_descriptionUpdate.Text = gDescription;
                txt_barcodeUpdate.Text = gBarcode;
                cBoxCatUpdate.Text = gCategory;
                txt_unitPriceUpdate.Text = gUnitprice;
                txt_stockUpdate.Text = gQuantity;
                txt_reorderUpdate.Text = gReorder;
            }
            if (count == 0)
            {
                MetroMessageBox.Show(this, "No records found!", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_productCodeUpdate.Text = null;
                txt_descriptionUpdate.Text = null;
                txt_barcodeUpdate.Text = null;
                cBoxCatUpdate.Text = null;
                txt_unitPriceUpdate.Text = null;
                txt_stockUpdate.Text = null;
                txt_reorderUpdate.Text = null;
            }
            else
            {
                //TODO:NOTHING
            }
            conn.Close();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_searchB_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_ProductInfo WHERE Product_Code = @ecode", conn);
            cmd.Parameters.AddWithValue("ecode", txt_searchProduct.Text);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();

            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
                //string gProductNumber = reader.GetInt32(reader.GetOrdinal("product_number")).ToString();
                string gDescription = reader.GetString(reader.GetOrdinal("Product_Code"));
                string gProductCode = reader.GetString(reader.GetOrdinal("Description"));
                string gBarcode = reader.GetString(reader.GetOrdinal("Barcode"));
                string gCategory = reader.GetString(reader.GetOrdinal("Category"));
                string gUnitprice = reader.GetInt32(reader.GetOrdinal("Unit_Price")).ToString();
                string gQuantity = reader.GetInt32(reader.GetOrdinal("Stock")).ToString();
                string gReorder = reader.GetString(reader.GetOrdinal("Reorder_level"));

                //txt_productCodeUpdate.Text = gProductNumber;
                txt_searchProductCode.Text = gProductCode;
                txt_searchDescription.Text = gDescription;
                txt_searchBarcode.Text = gBarcode;
                cBoxSearchCategory.Text = gCategory;
                txt_searchUnit.Text = gUnitprice;
                txt_searchStock.Text = gQuantity;
                txt_searchReorder.Text = gReorder;
            }
            if (count == 0)
            {
                MetroMessageBox.Show(this, "No records found!", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_searchProductCode.Text = null;
                txt_searchDescription.Text = null;
                txt_searchBarcode.Text = null;
                cBoxSearchCategory.Text = null;
                txt_searchUnit.Text = null;
                txt_searchStock.Text = null;
                txt_searchReorder.Text = null;
            }
            else
            {
                //TODO:NOTHING
            }
            conn.Close();
        }

        private void btn_searchStock_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_ProductInfo WHERE Product_Code = @ecode", conn);
            cmd.Parameters.AddWithValue("ecode", txt_stockSearch.Text);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();

            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
                //string gProductNumber = reader.GetInt32(reader.GetOrdinal("product_number")).ToString();
                string gProductCode = reader.GetString(reader.GetOrdinal("Product_Code"));
                string gDescription = reader.GetString(reader.GetOrdinal("Description"));
                string gBarcode = reader.GetString(reader.GetOrdinal("Barcode"));
                string gCategory = reader.GetString(reader.GetOrdinal("Category"));
                string gUnitprice = reader.GetInt32(reader.GetOrdinal("Unit_Price")).ToString();
                string gQuantity = reader.GetInt32(reader.GetOrdinal("Stock")).ToString();
                string gReorder = reader.GetString(reader.GetOrdinal("Reorder_level"));

                //txt_productCodeUpdate.Text = gProductNumber;
                lbl_ProductCode.Text = gProductCode;
                lbl_Description.Text = gDescription;
                lbl_Price.Text = gUnitprice;
                lbl_CurrentStocks.Text = gQuantity;
                txt_TotalStocks.Text = gQuantity;
                txt_searchReorder.Text = gReorder;
            }
            if (count == 0)
            {
                MetroMessageBox.Show(this, "No records found!", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lbl_ProductCode.Text = null;
                lbl_Description.Text = null;
                lbl_Price.Text = null;
                lbl_CurrentStocks.Text = null;
                txt_TotalStocks.Text = null;
                txt_searchReorder.Text = null;
            }
            else
            {
                //TODO:NOTHING
            }
            conn.Close();
        }

        private void txt_Quantity_TextChanged(object sender, EventArgs e)
        {
            if (txt_Quantity.Text == string.Empty)
            {
                txt_Quantity.Text = "0";
            }
            else
            {
                int a = int.Parse(txt_Quantity.Text);
                int b = int.Parse(lbl_CurrentStocks.Text);

                txt_TotalStocks.Text = (a + b).ToString();
            }
        }

        private void btn_addStock_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Do you want to add this stock?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Stock = txt_TotalStocks.Text;
                productCodeStock = lbl_ProductCode.Text;
                Cls_cmd.AddStock();
                MetroMessageBox.Show(this, "Successfully added this information to the database!", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbl_ProductCode.Text = null;
                lbl_Description.Text = null;
                lbl_Price.Text = null;
                lbl_CurrentStocks.Text = null;
                txt_TotalStocks.Text = null;
                txt_searchReorder.Text = null;
            }
            else
            {
                //TODO: NOTHING
            }
            

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void btn_StockExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
