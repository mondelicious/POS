﻿namespace POS
{
    partial class Frm_settingsSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_save = new MetroFramework.Controls.MetroTile();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_TINNumber = new System.Windows.Forms.TextBox();
            this.txt_website = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_phoneNo = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_saveVAT = new MetroFramework.Controls.MetroTile();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_percent = new System.Windows.Forms.TextBox();
            this.metroTabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage3);
            this.metroTabControl1.Controls.Add(this.tabPage4);
            this.metroTabControl1.Location = new System.Drawing.Point(11, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(449, 388);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(441, 346);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Company";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.Label7);
            this.groupBox1.Controls.Add(this.Label5);
            this.groupBox1.Controls.Add(this.Label4);
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Controls.Add(this.txt_address);
            this.groupBox1.Controls.Add(this.txt_TINNumber);
            this.groupBox1.Controls.Add(this.txt_website);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_phoneNo);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 334);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Company Information";
            // 
            // btn_save
            // 
            this.btn_save.ActiveControl = null;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Location = new System.Drawing.Point(323, 263);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(86, 65);
            this.btn_save.TabIndex = 18;
            this.btn_save.Text = "Save";
            this.btn_save.UseSelectable = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click_1);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(10, 80);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(62, 13);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Address :";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(10, 239);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(85, 13);
            this.Label7.TabIndex = 11;
            this.Label7.Text = "TIN Number :";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(10, 212);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(60, 13);
            this.Label5.TabIndex = 12;
            this.Label5.Text = "Website :";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(10, 185);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(65, 13);
            this.Label4.TabIndex = 13;
            this.Label4.Text = "Email ID :";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(10, 158);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(70, 13);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "Phone No :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(10, 23);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(49, 13);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Name :";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(108, 80);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(301, 69);
            this.txt_address.TabIndex = 8;
            // 
            // txt_TINNumber
            // 
            this.txt_TINNumber.Location = new System.Drawing.Point(108, 236);
            this.txt_TINNumber.Name = "txt_TINNumber";
            this.txt_TINNumber.Size = new System.Drawing.Size(301, 21);
            this.txt_TINNumber.TabIndex = 17;
            // 
            // txt_website
            // 
            this.txt_website.Location = new System.Drawing.Point(108, 209);
            this.txt_website.Name = "txt_website";
            this.txt_website.Size = new System.Drawing.Size(301, 21);
            this.txt_website.TabIndex = 16;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(108, 182);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(301, 21);
            this.txt_email.TabIndex = 15;
            // 
            // txt_phoneNo
            // 
            this.txt_phoneNo.Location = new System.Drawing.Point(108, 155);
            this.txt_phoneNo.Name = "txt_phoneNo";
            this.txt_phoneNo.Size = new System.Drawing.Size(150, 21);
            this.txt_phoneNo.TabIndex = 14;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(108, 20);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(301, 54);
            this.txt_name.TabIndex = 6;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 38);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(441, 346);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "VAT";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_saveVAT);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_percent);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 343);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // btn_saveVAT
            // 
            this.btn_saveVAT.ActiveControl = null;
            this.btn_saveVAT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_saveVAT.Location = new System.Drawing.Point(328, 272);
            this.btn_saveVAT.Name = "btn_saveVAT";
            this.btn_saveVAT.Size = new System.Drawing.Size(86, 65);
            this.btn_saveVAT.TabIndex = 19;
            this.btn_saveVAT.Text = "Save";
            this.btn_saveVAT.UseSelectable = true;
            this.btn_saveVAT.Click += new System.EventHandler(this.btn_saveVAT_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Vat Percent :";
            // 
            // txt_percent
            // 
            this.txt_percent.Location = new System.Drawing.Point(93, 29);
            this.txt_percent.Name = "txt_percent";
            this.txt_percent.Size = new System.Drawing.Size(84, 21);
            this.txt_percent.TabIndex = 0;
            // 
            // Frm_settingsSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 463);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.Name = "Frm_settingsSystem";
            this.Resizable = false;
            this.Text = "System Settings";
            this.Load += new System.EventHandler(this.Frm_settingsSystem_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTile btn_save;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txt_address;
        internal System.Windows.Forms.TextBox txt_TINNumber;
        internal System.Windows.Forms.TextBox txt_website;
        internal System.Windows.Forms.TextBox txt_email;
        internal System.Windows.Forms.TextBox txt_phoneNo;
        internal System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TabPage tabPage4;
        internal System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTile btn_saveVAT;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox txt_percent;
    }
}