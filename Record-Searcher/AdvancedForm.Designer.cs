﻿namespace Record_Searcher
{
    partial class AdvancedForm
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
            this.progressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.Btn1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ListView1 = new MetroFramework.Controls.MetroListView();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.TypeBox = new MetroFramework.Controls.MetroComboBox();
            this.BookBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.FirstNameBox = new MetroFramework.Controls.MetroTextBox();
            this.LastNameBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.DateBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(155, 492);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(541, 40);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Btn1
            // 
            this.Btn1.ActiveControl = null;
            this.Btn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn1.Location = new System.Drawing.Point(748, 492);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(83, 40);
            this.Btn1.TabIndex = 1;
            this.Btn1.Text = "Search";
            this.Btn1.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(39, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Type:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ListView1
            // 
            this.ListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ListView1.FullRowSelect = true;
            this.ListView1.Location = new System.Drawing.Point(23, 123);
            this.ListView1.Name = "ListView1";
            this.ListView1.OwnerDraw = true;
            this.ListView1.Size = new System.Drawing.Size(808, 339);
            this.ListView1.TabIndex = 3;
            this.ListView1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroTile2.Location = new System.Drawing.Point(23, 492);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(75, 39);
            this.metroTile2.TabIndex = 4;
            this.metroTile2.Text = "Reload";
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.Reload);
            // 
            // TypeBox
            // 
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.ItemHeight = 23;
            this.TypeBox.Location = new System.Drawing.Point(68, 60);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(82, 29);
            this.TypeBox.TabIndex = 5;
            this.TypeBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TypeBox.UseSelectable = true;
            this.TypeBox.SelectionChangeCommitted += new System.EventHandler(this.BookBoxUpdate);
            // 
            // BookBox
            // 
            this.BookBox.FormattingEnabled = true;
            this.BookBox.ItemHeight = 23;
            this.BookBox.Location = new System.Drawing.Point(222, 60);
            this.BookBox.Name = "BookBox";
            this.BookBox.Size = new System.Drawing.Size(112, 29);
            this.BookBox.TabIndex = 6;
            this.BookBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BookBox.UseSelectable = true;
            this.BookBox.SelectionChangeCommitted += new System.EventHandler(this.DateUpdate);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(174, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Book:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // FirstNameBox
            // 
            // 
            // 
            // 
            this.FirstNameBox.CustomButton.Image = null;
            this.FirstNameBox.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.FirstNameBox.CustomButton.Name = "";
            this.FirstNameBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.FirstNameBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.FirstNameBox.CustomButton.TabIndex = 1;
            this.FirstNameBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FirstNameBox.CustomButton.UseSelectable = true;
            this.FirstNameBox.CustomButton.Visible = false;
            this.FirstNameBox.Lines = new string[0];
            this.FirstNameBox.Location = new System.Drawing.Point(434, 64);
            this.FirstNameBox.MaxLength = 32767;
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.PasswordChar = '\0';
            this.FirstNameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FirstNameBox.SelectedText = "";
            this.FirstNameBox.SelectionLength = 0;
            this.FirstNameBox.SelectionStart = 0;
            this.FirstNameBox.ShortcutsEnabled = true;
            this.FirstNameBox.Size = new System.Drawing.Size(75, 23);
            this.FirstNameBox.TabIndex = 8;
            this.FirstNameBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FirstNameBox.UseSelectable = true;
            this.FirstNameBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FirstNameBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LastNameBox
            // 
            // 
            // 
            // 
            this.LastNameBox.CustomButton.Image = null;
            this.LastNameBox.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.LastNameBox.CustomButton.Name = "";
            this.LastNameBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.LastNameBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LastNameBox.CustomButton.TabIndex = 1;
            this.LastNameBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LastNameBox.CustomButton.UseSelectable = true;
            this.LastNameBox.CustomButton.Visible = false;
            this.LastNameBox.Lines = new string[0];
            this.LastNameBox.Location = new System.Drawing.Point(595, 63);
            this.LastNameBox.MaxLength = 32767;
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.PasswordChar = '\0';
            this.LastNameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LastNameBox.SelectedText = "";
            this.LastNameBox.SelectionLength = 0;
            this.LastNameBox.SelectionStart = 0;
            this.LastNameBox.ShortcutsEnabled = true;
            this.LastNameBox.Size = new System.Drawing.Size(75, 23);
            this.LastNameBox.TabIndex = 9;
            this.LastNameBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LastNameBox.UseSelectable = true;
            this.LastNameBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LastNameBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(352, 64);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(76, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "First Name:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(515, 64);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(74, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Last Name:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // DateBox
            // 
            // 
            // 
            // 
            this.DateBox.CustomButton.Image = null;
            this.DateBox.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.DateBox.CustomButton.Name = "";
            this.DateBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.DateBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DateBox.CustomButton.TabIndex = 1;
            this.DateBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DateBox.CustomButton.UseSelectable = true;
            this.DateBox.CustomButton.Visible = false;
            this.DateBox.Lines = new string[0];
            this.DateBox.Location = new System.Drawing.Point(734, 63);
            this.DateBox.MaxLength = 32767;
            this.DateBox.Name = "DateBox";
            this.DateBox.PasswordChar = '\0';
            this.DateBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DateBox.SelectedText = "";
            this.DateBox.SelectionLength = 0;
            this.DateBox.SelectionStart = 0;
            this.DateBox.ShortcutsEnabled = true;
            this.DateBox.Size = new System.Drawing.Size(75, 23);
            this.DateBox.TabIndex = 12;
            this.DateBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DateBox.UseSelectable = true;
            this.DateBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DateBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.DateBox.Leave += new System.EventHandler(this.ValidateDate);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(689, 64);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(39, 19);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "Date:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // AdvancedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 555);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.BookBox);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.progressBar1);
            this.Name = "AdvancedForm";
            this.Text = "AdvancedForm";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.AdvancedForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressBar progressBar1;
        private MetroFramework.Controls.MetroTile Btn1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroListView ListView1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroComboBox TypeBox;
        private MetroFramework.Controls.MetroComboBox BookBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox FirstNameBox;
        private MetroFramework.Controls.MetroTextBox LastNameBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox DateBox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}