﻿namespace PRN292_Group1_QLSvien
{
    partial class frmMain
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lbMaSV = new MetroFramework.Controls.MetroLabel();
            this.lbHo = new MetroFramework.Controls.MetroLabel();
            this.lbTen = new MetroFramework.Controls.MetroLabel();
            this.lbNgaySinh = new MetroFramework.Controls.MetroLabel();
            this.lbGioiTinh = new MetroFramework.Controls.MetroLabel();
            this.lbMaKhoa = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnRemove = new MetroFramework.Controls.MetroTile();
            this.btnEdit = new MetroFramework.Controls.MetroTile();
            this.btnAdd = new MetroFramework.Controls.MetroTile();
            this.btnShow = new MetroFramework.Controls.MetroTile();
            this.txtMaKhoa = new MetroFramework.Controls.MetroTextBox();
            this.txtGioiTinh = new MetroFramework.Controls.MetroTextBox();
            this.txtNgaySinh = new MetroFramework.Controls.MetroTextBox();
            this.txtTen = new MetroFramework.Controls.MetroTextBox();
            this.txtHo = new MetroFramework.Controls.MetroTextBox();
            this.txtMaSV = new MetroFramework.Controls.MetroTextBox();
            this.dgvManager = new System.Windows.Forms.DataGridView();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaSV
            // 
            this.lbMaSV.AutoSize = true;
            this.lbMaSV.Location = new System.Drawing.Point(11, 16);
            this.lbMaSV.Name = "lbMaSV";
            this.lbMaSV.Size = new System.Drawing.Size(69, 19);
            this.lbMaSV.TabIndex = 0;
            this.lbMaSV.Text = "Student ID";
            // 
            // lbHo
            // 
            this.lbHo.AutoSize = true;
            this.lbHo.Location = new System.Drawing.Point(11, 53);
            this.lbHo.Name = "lbHo";
            this.lbHo.Size = new System.Drawing.Size(66, 19);
            this.lbHo.TabIndex = 1;
            this.lbHo.Text = "Firstname";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(11, 94);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(64, 19);
            this.lbTen.TabIndex = 2;
            this.lbTen.Text = "Lastname";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Location = new System.Drawing.Point(11, 129);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(84, 19);
            this.lbNgaySinh.TabIndex = 3;
            this.lbNgaySinh.Text = "Date of birth";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Location = new System.Drawing.Point(11, 168);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(44, 19);
            this.lbGioiTinh.TabIndex = 4;
            this.lbGioiTinh.Text = "Genre";
            // 
            // lbMaKhoa
            // 
            this.lbMaKhoa.AutoSize = true;
            this.lbMaKhoa.Location = new System.Drawing.Point(11, 205);
            this.lbMaKhoa.Name = "lbMaKhoa";
            this.lbMaKhoa.Size = new System.Drawing.Size(54, 19);
            this.lbMaKhoa.TabIndex = 5;
            this.lbMaKhoa.Text = "Term ID";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnRemove);
            this.metroPanel1.Controls.Add(this.btnEdit);
            this.metroPanel1.Controls.Add(this.btnAdd);
            this.metroPanel1.Controls.Add(this.btnShow);
            this.metroPanel1.Controls.Add(this.txtMaKhoa);
            this.metroPanel1.Controls.Add(this.txtGioiTinh);
            this.metroPanel1.Controls.Add(this.txtNgaySinh);
            this.metroPanel1.Controls.Add(this.txtTen);
            this.metroPanel1.Controls.Add(this.txtHo);
            this.metroPanel1.Controls.Add(this.txtMaSV);
            this.metroPanel1.Controls.Add(this.lbGioiTinh);
            this.metroPanel1.Controls.Add(this.lbMaKhoa);
            this.metroPanel1.Controls.Add(this.lbTen);
            this.metroPanel1.Controls.Add(this.lbNgaySinh);
            this.metroPanel1.Controls.Add(this.lbMaSV);
            this.metroPanel1.Controls.Add(this.lbHo);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(661, 520);
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnRemove
            // 
            this.btnRemove.ActiveControl = null;
            this.btnRemove.Location = new System.Drawing.Point(499, 129);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(154, 99);
            this.btnRemove.TabIndex = 19;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemove.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRemove.TileImage = ((System.Drawing.Image)(resources.GetObject("btnRemove.TileImage")));
            this.btnRemove.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemove.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnRemove.UseSelectable = true;
            this.btnRemove.UseTileImage = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ActiveControl = null;
            this.btnEdit.Location = new System.Drawing.Point(339, 129);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(157, 99);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnEdit.TileImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.TileImage")));
            this.btnEdit.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnEdit.UseSelectable = true;
            this.btnEdit.UseTileImage = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveControl = null;
            this.btnAdd.Location = new System.Drawing.Point(499, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 98);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAdd.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.TileImage")));
            this.btnAdd.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.UseTileImage = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShow
            // 
            this.btnShow.ActiveControl = null;
            this.btnShow.Location = new System.Drawing.Point(339, 14);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(157, 98);
            this.btnShow.TabIndex = 15;
            this.btnShow.Text = "Show Data";
            this.btnShow.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShow.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnShow.TileImage = ((System.Drawing.Image)(resources.GetObject("btnShow.TileImage")));
            this.btnShow.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShow.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnShow.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnShow.UseSelectable = true;
            this.btnShow.UseTileImage = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtMaKhoa
            // 
            // 
            // 
            // 
            this.txtMaKhoa.CustomButton.Image = null;
            this.txtMaKhoa.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.txtMaKhoa.CustomButton.Name = "";
            this.txtMaKhoa.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMaKhoa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaKhoa.CustomButton.TabIndex = 1;
            this.txtMaKhoa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaKhoa.CustomButton.UseSelectable = true;
            this.txtMaKhoa.CustomButton.Visible = false;
            this.txtMaKhoa.Lines = new string[0];
            this.txtMaKhoa.Location = new System.Drawing.Point(101, 205);
            this.txtMaKhoa.MaxLength = 32767;
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.PasswordChar = '\0';
            this.txtMaKhoa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaKhoa.SelectedText = "";
            this.txtMaKhoa.SelectionLength = 0;
            this.txtMaKhoa.SelectionStart = 0;
            this.txtMaKhoa.ShortcutsEnabled = true;
            this.txtMaKhoa.Size = new System.Drawing.Size(214, 23);
            this.txtMaKhoa.TabIndex = 11;
            this.txtMaKhoa.UseSelectable = true;
            this.txtMaKhoa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaKhoa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtGioiTinh
            // 
            // 
            // 
            // 
            this.txtGioiTinh.CustomButton.Image = null;
            this.txtGioiTinh.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.txtGioiTinh.CustomButton.Name = "";
            this.txtGioiTinh.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGioiTinh.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGioiTinh.CustomButton.TabIndex = 1;
            this.txtGioiTinh.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGioiTinh.CustomButton.UseSelectable = true;
            this.txtGioiTinh.CustomButton.Visible = false;
            this.txtGioiTinh.Lines = new string[0];
            this.txtGioiTinh.Location = new System.Drawing.Point(101, 167);
            this.txtGioiTinh.MaxLength = 32767;
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.PasswordChar = '\0';
            this.txtGioiTinh.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGioiTinh.SelectedText = "";
            this.txtGioiTinh.SelectionLength = 0;
            this.txtGioiTinh.SelectionStart = 0;
            this.txtGioiTinh.ShortcutsEnabled = true;
            this.txtGioiTinh.Size = new System.Drawing.Size(214, 23);
            this.txtGioiTinh.TabIndex = 10;
            this.txtGioiTinh.UseSelectable = true;
            this.txtGioiTinh.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGioiTinh.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNgaySinh
            // 
            // 
            // 
            // 
            this.txtNgaySinh.CustomButton.Image = null;
            this.txtNgaySinh.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.txtNgaySinh.CustomButton.Name = "";
            this.txtNgaySinh.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNgaySinh.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNgaySinh.CustomButton.TabIndex = 1;
            this.txtNgaySinh.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNgaySinh.CustomButton.UseSelectable = true;
            this.txtNgaySinh.CustomButton.Visible = false;
            this.txtNgaySinh.Lines = new string[0];
            this.txtNgaySinh.Location = new System.Drawing.Point(101, 129);
            this.txtNgaySinh.MaxLength = 32767;
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.PasswordChar = '\0';
            this.txtNgaySinh.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNgaySinh.SelectedText = "";
            this.txtNgaySinh.SelectionLength = 0;
            this.txtNgaySinh.SelectionStart = 0;
            this.txtNgaySinh.ShortcutsEnabled = true;
            this.txtNgaySinh.Size = new System.Drawing.Size(214, 23);
            this.txtNgaySinh.TabIndex = 9;
            this.txtNgaySinh.UseSelectable = true;
            this.txtNgaySinh.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNgaySinh.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTen
            // 
            // 
            // 
            // 
            this.txtTen.CustomButton.Image = null;
            this.txtTen.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.txtTen.CustomButton.Name = "";
            this.txtTen.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTen.CustomButton.TabIndex = 1;
            this.txtTen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTen.CustomButton.UseSelectable = true;
            this.txtTen.CustomButton.Visible = false;
            this.txtTen.Lines = new string[0];
            this.txtTen.Location = new System.Drawing.Point(101, 93);
            this.txtTen.MaxLength = 32767;
            this.txtTen.Name = "txtTen";
            this.txtTen.PasswordChar = '\0';
            this.txtTen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTen.SelectedText = "";
            this.txtTen.SelectionLength = 0;
            this.txtTen.SelectionStart = 0;
            this.txtTen.ShortcutsEnabled = true;
            this.txtTen.Size = new System.Drawing.Size(214, 23);
            this.txtTen.TabIndex = 8;
            this.txtTen.UseSelectable = true;
            this.txtTen.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTen.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtHo
            // 
            // 
            // 
            // 
            this.txtHo.CustomButton.Image = null;
            this.txtHo.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.txtHo.CustomButton.Name = "";
            this.txtHo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHo.CustomButton.TabIndex = 1;
            this.txtHo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHo.CustomButton.UseSelectable = true;
            this.txtHo.CustomButton.Visible = false;
            this.txtHo.Lines = new string[0];
            this.txtHo.Location = new System.Drawing.Point(101, 52);
            this.txtHo.MaxLength = 32767;
            this.txtHo.Name = "txtHo";
            this.txtHo.PasswordChar = '\0';
            this.txtHo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHo.SelectedText = "";
            this.txtHo.SelectionLength = 0;
            this.txtHo.SelectionStart = 0;
            this.txtHo.ShortcutsEnabled = true;
            this.txtHo.Size = new System.Drawing.Size(214, 23);
            this.txtHo.TabIndex = 7;
            this.txtHo.UseSelectable = true;
            this.txtHo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMaSV
            // 
            // 
            // 
            // 
            this.txtMaSV.CustomButton.Image = null;
            this.txtMaSV.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.txtMaSV.CustomButton.Name = "";
            this.txtMaSV.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMaSV.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaSV.CustomButton.TabIndex = 1;
            this.txtMaSV.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaSV.CustomButton.UseSelectable = true;
            this.txtMaSV.CustomButton.Visible = false;
            this.txtMaSV.Lines = new string[0];
            this.txtMaSV.Location = new System.Drawing.Point(101, 14);
            this.txtMaSV.MaxLength = 32767;
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.PasswordChar = '\0';
            this.txtMaSV.ReadOnly = true;
            this.txtMaSV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaSV.SelectedText = "";
            this.txtMaSV.SelectionLength = 0;
            this.txtMaSV.SelectionStart = 0;
            this.txtMaSV.ShortcutsEnabled = true;
            this.txtMaSV.Size = new System.Drawing.Size(214, 23);
            this.txtMaSV.TabIndex = 6;
            this.txtMaSV.UseSelectable = true;
            this.txtMaSV.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaSV.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgvManager
            // 
            this.dgvManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManager.Location = new System.Drawing.Point(18, 299);
            this.dgvManager.Name = "dgvManager";
            this.dgvManager.Size = new System.Drawing.Size(665, 294);
            this.dgvManager.TabIndex = 7;
            this.dgvManager.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManager_CellClick);
            this.dgvManager.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvManager_CellFormatting);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 600);
            this.Controls.Add(this.dgvManager);
            this.Controls.Add(this.metroPanel1);
            this.Name = "frmMain";
            this.Text = "Students Management";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbMaSV;
        private MetroFramework.Controls.MetroLabel lbHo;
        private MetroFramework.Controls.MetroLabel lbTen;
        private MetroFramework.Controls.MetroLabel lbNgaySinh;
        private MetroFramework.Controls.MetroLabel lbGioiTinh;
        private MetroFramework.Controls.MetroLabel lbMaKhoa;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtMaKhoa;
        private MetroFramework.Controls.MetroTextBox txtGioiTinh;
        private MetroFramework.Controls.MetroTextBox txtNgaySinh;
        private MetroFramework.Controls.MetroTextBox txtTen;
        private MetroFramework.Controls.MetroTextBox txtHo;
        private MetroFramework.Controls.MetroTextBox txtMaSV;
        public System.Windows.Forms.DataGridView dgvManager;
        private MetroFramework.Controls.MetroTile btnShow;
        public MetroFramework.Controls.MetroTile btnAdd;
        public MetroFramework.Controls.MetroTile btnEdit;
        private MetroFramework.Controls.MetroTile btnRemove;
    }
}