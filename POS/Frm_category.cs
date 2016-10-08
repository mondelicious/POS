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

namespace POS
{
    public partial class Frm_category : MetroForm
    {
        public static string categoryNumber = "";
        public static string categoryName = "";
        public static string description = "";

        public Frm_category()
        {
            InitializeComponent();
        }

        private void Frm_category_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Do you want to add this category?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                categoryNumber = txt_categoryNo.Text;
                categoryName = txt_categoryName.Text;
                description = txt_description.Text;
                Cls_cmd.AddCategory();

                txt_categoryNo.Text = null;
                txt_categoryName.Text = null;
                txt_description.Text = null;
                MetroFramework.MetroMessageBox.Show(this, "Successfully added this category to the database.", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //TODO: NOTHING
            }
        }
    }
}
