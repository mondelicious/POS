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
using Microsoft.VisualBasic;

namespace POS
{
    public partial class Frm_Main : MetroForm
    {
        public Frm_Main()
        {
            InitializeComponent();
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
    }
}
