using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS
{
    class Cls_cmd
    {
        public static void AddProduct()
        {
            Frm_product _owner = new Frm_product();

            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();

            conn.Open();
            cmd.Connection = conn;
            string INSERT = "INSERT INTO tbl_ProductInfo(Product_Code,Description,Barcode,Category,Unit_Price,Stock,Reorder_level)VALUES(@proCode,@description,@barCode,@category,@unitPrice,@quantityStock,@reorderLevel)";
            cmd.Parameters.AddWithValue("proCode", Frm_product.productCode);
            cmd.Parameters.AddWithValue("description", Frm_product.description);
            cmd.Parameters.AddWithValue("barCode", Frm_product.barcode);
            cmd.Parameters.AddWithValue("category", Frm_product.category);
            cmd.Parameters.AddWithValue("unitPrice", Frm_product.unitPrice);
            cmd.Parameters.AddWithValue("quantityStock", Frm_product.quantityStock);
            cmd.Parameters.AddWithValue("reorderLevel", Frm_product.reorderLevel);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Parameters.Clear();

            Frm_product.productNo = null;
            Frm_product.productCode = null;
            Frm_product.description = null;
            Frm_product.barcode = null;
            Frm_product.category = null;
            Frm_product.unitPrice = null;
            Frm_product.quantityStock = null;
            Frm_product.reorderLevel = null;
        }

        public static void UpdateProduct()
        {
            Frm_product _owner = new Frm_product();

            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();

            conn.Open();
            cmd.Connection = conn;
            string INSERT = "INSERT INTO tbl_ProductInfo(Product_Code,Description,Barcode,Category,Unit_Price,Stock,Reorder_level)VALUES(@proCode,@description,@barCode,@category,@unitPrice,@quantityStock,@reorderLevel)";
            cmd.Parameters.AddWithValue("proCode", Frm_product.productCode);
            cmd.Parameters.AddWithValue("description", Frm_product.description);
            cmd.Parameters.AddWithValue("barCode", Frm_product.barcode);
            cmd.Parameters.AddWithValue("category", Frm_product.category);
            cmd.Parameters.AddWithValue("unitPrice", Frm_product.unitPrice);
            cmd.Parameters.AddWithValue("quantityStock", Frm_product.quantityStock);
            cmd.Parameters.AddWithValue("reorderLevel", Frm_product.reorderLevel);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Parameters.Clear();

            Frm_product.productNo = null;
            Frm_product.productCode = null;
            Frm_product.description = null;
            Frm_product.barcode = null;
            Frm_product.category = null;
            Frm_product.unitPrice = null;
            Frm_product.quantityStock = null;
            Frm_product.reorderLevel = null;
        }

        public static void AddStock()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();

            conn.Open();
            cmd.Connection = conn;
            string UPDATE = "UPDATE tbl_ProductInfo SET Stock = @st WHERE Product_Code = @proCode";
            cmd.Parameters.AddWithValue("st", Frm_product.Stock);
            cmd.Parameters.AddWithValue("proCode", Frm_product.productCodeStock);
            cmd.CommandText = UPDATE;
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Parameters.Clear();

        }
        public static void AddStaff()
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();

            conn.Open();
            cmd.Connection = conn;
            string INSERT = "INSERT INTO tbl_StaffInformation(Last_name,First_name,Middle_name,Street,Brgy,City,Province,Contact_number)VALUES(@ln,@fn,@mn,@st,@brgy,@city,@province,@contactNumber)";
            cmd.Parameters.AddWithValue("ln", Frm_Staff.lastName);
            cmd.Parameters.AddWithValue("fn", Frm_Staff.firstName);
            cmd.Parameters.AddWithValue("mn", Frm_Staff.middleName);
            cmd.Parameters.AddWithValue("st", Frm_Staff.street);
            cmd.Parameters.AddWithValue("brgy", Frm_Staff.barangay);
            cmd.Parameters.AddWithValue("city", Frm_Staff.city);
            cmd.Parameters.AddWithValue("province", Frm_Staff.province);
            cmd.Parameters.AddWithValue("contactnumber", Frm_Staff.contactNumber);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Parameters.Clear();

        }

        public static void AddUser()
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();

            conn.Open();
            cmd.Connection = conn;
            string INSERT = "INSERT INTO tbl_UserInfo(Username,Password,Role)VALUES(@un,@pw,@rl)";
            cmd.Parameters.AddWithValue("un", Frm_Staff.userName);
            cmd.Parameters.AddWithValue("pw", Frm_Staff.passWord);
            cmd.Parameters.AddWithValue("rl", Frm_Staff.role);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Parameters.Clear();
        }

        public static void AddCompany()
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();

            conn.Open();
            cmd.Connection = conn;
            string INSERT = "INSERT INTO tbl_CompanyInfo(Name,Address,Phone_number,Email_Address,Website,TIN_number)VALUES(@name,@add,@pn,@eAdd,@web,@tin)";
            cmd.Parameters.AddWithValue("name", Frm_settingsSystem.nameCompany);
            cmd.Parameters.AddWithValue("add", Frm_settingsSystem.Address);
            cmd.Parameters.AddWithValue("pn", Frm_settingsSystem.phoneNumber);
            cmd.Parameters.AddWithValue("eAdd", Frm_settingsSystem.eAddress);
            cmd.Parameters.AddWithValue("web", Frm_settingsSystem.Website);
            cmd.Parameters.AddWithValue("tin", Frm_settingsSystem.tinNumber);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Parameters.Clear();

            Frm_settingsSystem.nameCompany = null;
            Frm_settingsSystem.Address = null;
            Frm_settingsSystem.phoneNumber = null;
            Frm_settingsSystem.eAddress = null;
            Frm_settingsSystem.Website = null;
            Frm_settingsSystem.tinNumber = null;
        }
        public static void EditStaff()
        {
            

            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();

            conn.Open();
            cmd.Connection = conn;
            string UPDATE = "UPDATE tbl_StaffInformation SET Last_name =@ln, First_name = @fn, Middle_name = @mi, Street = @st, Brgy = @brgy, City = @city, Province = @province, Contact_number = @contact WHERE employee_number = @eid";
            cmd.Parameters.AddWithValue("eid", Frm_editStaff.eCode);
            cmd.Parameters.AddWithValue("ln", Frm_editStaff.lastName);
            cmd.Parameters.AddWithValue("fn", Frm_editStaff.firstName);
            cmd.Parameters.AddWithValue("mi", Frm_editStaff.middleName);
            cmd.Parameters.AddWithValue("st", Frm_editStaff.street);
            cmd.Parameters.AddWithValue("brgy", Frm_editStaff.barangay);
            cmd.Parameters.AddWithValue("city", Frm_editStaff.city);
            cmd.Parameters.AddWithValue("province", Frm_editStaff.province);
            cmd.Parameters.AddWithValue("contact", Frm_editStaff.contactNumber);
            cmd.CommandText = UPDATE;
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Parameters.Clear();
            
            Frm_editStaff.lastName = null;
            Frm_editStaff.firstName = null;
            Frm_editStaff.middleName = null;
            Frm_editStaff.street = null;
            Frm_editStaff.barangay = null;
            Frm_editStaff.city = null;
            Frm_editStaff.province = null;
            Frm_editStaff.contactNumber = null;
            Frm_editStaff.userName = null;
            Frm_editStaff.passWord = null;
            Frm_editStaff.role = null;
        }

        public static void AddCategory()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();

            conn.Open();
            cmd.Connection = conn;
            string ADD = "INSERT INTO tbl_Category(Category_name,Description)VALUES(@cname,@des)";
            cmd.Parameters.AddWithValue("cname", Frm_category.categoryName);
            cmd.Parameters.AddWithValue("des", Frm_category.description);
            cmd.CommandText = ADD;
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Parameters.Clear();
        }
    }
}
