﻿using PRN292_Group1_QLSvien.Models.SinhVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN292_Group1_QLSvien
{
    public partial class frmAdd_Update : MetroFramework.Forms.MetroForm
    {
        public frmAdd_Update()
        {
            InitializeComponent();
        }

        frmMain MainForm = new frmMain();
        Boolean GioiTinh;

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // check MaSV 
            // nếu không có data thì hiển thị thông báo "Bạn có muốn thêm sinh viên mới không" nút save sẽ thành nút ADD
            // nếu có data thì show lên các textbox, cho phép modify và nút save sẽ thành nút UPDATE
            bool result = true;
            if (!SinhVienDAO.IsExistedMASV(txtMaSV.Text.Trim()))
            {
                // ADD 
                DialogResult dialogResult1 = MetroFramework.MetroMessageBox.Show(this, "MaSV is not already existed\nWould you like to ADD new???", "Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult1 == DialogResult.Yes)
                {
                    try
                    {
                        result = SinhVienDAO.InsertStudent(txtMaSV.Text.Trim(), txtHo.Text.Trim(), txtTen.Text.Trim(),
                            txtNgaySinh.Value.Date, GioiTinh, txtMaKhoa.Text.Trim());
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (dialogResult1 == DialogResult.No)
                {
                    // Thoát form này
                    this.Close();
                }
            }
            else if (SinhVienDAO.IsExistedMASV(txtMaSV.Text.Trim()))
            {
                DialogResult dialogResult2 = MetroFramework.MetroMessageBox.Show(this, "MaSV is already existed\nWould you like to UPDATE???", "Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // UPDATE 
                // Nếu maSV tồn tại
                if (dialogResult2 == DialogResult.Yes)
                {
                    try
                    {
                        // Get value from sql 
                        // Phía dưới sai rồi
                        txtMaSV.ReadOnly = true;
                        string HO = txtHo.Text.Trim();
                        string TEN = txtTen.Text.Trim();
                        DateTime NGAYSINH = txtNgaySinh.Value.Date;
                        string MAKH = txtMaKhoa.Text.Trim();
                        result = SinhVienDAO.UpdateInfo(txtMaSV.Text.Trim(), HO, TEN, NGAYSINH, GioiTinh, MAKH);
                        //result = SinhVienDAO.UpdateInfo(txtMaSV.Text.Trim(), txtHo.Text.Trim(), txtTen.Text.Trim(),
                        //    txtNgaySinh.Value.Date, GioiTinh, txtMaKhoa.Text.Trim());
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (dialogResult2 == DialogResult.No)
                {
                    this.Close();
                }
            }
            if (result)
            {
                // UPDATE thành công
                MetroFramework.MetroMessageBox.Show(this, "Successed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rdMale_CheckedChanged(object sender, EventArgs e)
        {
            
            GioiTinh = true;
        }

        private void rdFemale_CheckedChanged(object sender, EventArgs e)
        {
            GioiTinh = false;
        }
    }
}
