﻿using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010;
using Microsoft.ApplicationBlocks.Data;
using DevExpress.XtraBars.Navigation;
using System.IO;
using System.Collections.Generic;
using DevExpress.XtraLayout;

namespace Vs.HRM
{
    public partial class ucQuyetDinhThoiViec : DevExpress.XtraEditors.XtraUserControl
    {
        public ucQuyetDinhThoiViec()
        {
            InitializeComponent();
            Commons.Modules.ObjSystems.ThayDoiNN(this, new List<LayoutControlGroup> { Root, layoutControlGroup1 }, windowsUIButton);
        }
        private void ucQuyetDinhThoiViec_Load(object sender, EventArgs e)
        {
            Commons.Modules.sPS = "0Load";
            Commons.Modules.ObjSystems.LoadCboDonVi(cboSearch_DV);
            Commons.Modules.ObjSystems.LoadCboXiNghiep(cboSearch_DV, cboSearch_XN);
            Commons.Modules.ObjSystems.LoadCboTo(cboSearch_DV, cboSearch_XN, cboSearch_TO);
            LoadGridCongNhan(-1);
            Commons.Modules.sPS = "";
            LoadCboLyDoThoiViec();
            LoadNguoiKy();
        }
        private void enableButon(bool visible)
        {
            windowsUIButton.Buttons[0].Properties.Visible = visible;
            windowsUIButton.Buttons[1].Properties.Visible = visible;
            windowsUIButton.Buttons[2].Properties.Visible = visible;
            windowsUIButton.Buttons[3].Properties.Visible = !visible;
            windowsUIButton.Buttons[4].Properties.Visible = !visible;
            windowsUIButton.Buttons[5].Properties.Visible = visible;
            searchControl.Visible = visible;
        }
        private void windowsUIButton_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            XtraUserControl ctl = new XtraUserControl();
            switch (btn.Tag.ToString())
            {
                case "themsua":
                    {
                        LoadText();
                        navigationFrame.SelectedPage = navigationPage2;
                        enableButon(false);
                        break;
                    }

                case "xoa":
                    {
                        break;
                    }
                case "luu":
                    {
                        if (!dxValidationProvider1.Validate()) return;
                        try
                        {
                            LoadGridCongNhan(Convert.ToInt32(
                            SqlHelper.ExecuteScalar(Commons.IConnections.CNStr, "spGetUpdateQuyetDinhThoiViec",
(grvCongNhan.GetFocusedRowCellValue("ID_QDTV").ToString() == string.Empty) ? -1 : Convert.ToInt32(grvCongNhan.GetFocusedRowCellValue("ID_QDTV")),
grvCongNhan.GetFocusedRowCellValue("ID_CN"),
SO_QDTextEdit.EditValue,
NGAY_NHAN_DONDateEdit.EditValue,
NGAY_THOI_VIECDateEdit.EditValue,
HS_LUONGTextEdit.EditValue,
LUONG_TOI_THIEUTextEdit.EditValue,
TIEN_TRO_CAPTextEdit.EditValue,
TIEN_PHEPTextEdit.EditValue,
TRO_CAP_KHACTextEdit.EditValue,
TONG_CONGTextEdit.EditValue,
NGAY_KYDateEdit.EditValue,
ID_LD_TVLookUpEdit.EditValue,
NGAY_VAO_CTYTextEdit.EditValue,
NGAY_PHEPTextEdit.EditValue,
NGUYEN_NHANTextEdit.EditValue,
GHI_CHUMemoEdit.EditValue,
ID_NKLookUpEdit.EditValue,
LUONG_TINH_PHEPTextEdit.EditValue
)));
                        }
                        catch (Exception ex)
                        {
                        }

                        navigationFrame.SelectedPage = navigationPage1;
                        enableButon(true);
                        break;
                    }

                case "trove":
                    {
                        navigationFrame.SelectedPage = navigationPage1;
                        enableButon(true);
                        break;
                    }
                case "thoat":
                    {
                        if (XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgBanCoMuonThoatChuongtrinh"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgTieuDeThoat"), MessageBoxButtons.YesNo) == DialogResult.No) return;
                        Application.Exit();
                        break;
                    }
                default:
                    break;
            }
        }
        private void cboSearch_TO_EditValueChanged(object sender, EventArgs e)
        {
            if (Commons.Modules.sPS == "0Load") return;
            Commons.Modules.sPS = "0Load";
            LoadGridCongNhan(-1);
            Commons.Modules.sPS = "";
        }
        private void cboSearch_DV_EditValueChanged(object sender, EventArgs e)
        {
            if (Commons.Modules.sPS == "0Load") return;
            Commons.Modules.sPS = "0Load";
            Commons.Modules.ObjSystems.LoadCboXiNghiep(cboSearch_DV, cboSearch_XN);
            Commons.Modules.ObjSystems.LoadCboTo(cboSearch_DV, cboSearch_XN, cboSearch_TO);
            LoadGridCongNhan(-1);
            Commons.Modules.sPS = "";
        }
        private void cboSearch_XN_EditValueChanged(object sender, EventArgs e)
        {
            if (Commons.Modules.sPS == "0Load") return;
            Commons.Modules.sPS = "0Load";
            Commons.Modules.ObjSystems.LoadCboTo(cboSearch_DV, cboSearch_XN, cboSearch_TO);
            LoadGridCongNhan(-1);
            Commons.Modules.sPS = "";
        }
        private void LoadGridCongNhan(int idCN)
        {
            DataTable dt = new DataTable();
            dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetCongNhanQDTV", cboSearch_DV.EditValue, cboSearch_XN.EditValue, cboSearch_TO.EditValue, Commons.Modules.UserName, Commons.Modules.TypeLanguage));
            dt.PrimaryKey = new DataColumn[] { dt.Columns["ID_CN"] };
            Commons.Modules.ObjSystems.MLoadXtraGrid(grdCongNhan, grvCongNhan, dt, false, false, true, true, true, "");
            grvCongNhan.Columns["ID_CN"].Visible = false;
            grvCongNhan.Columns["MS_CN"].Visible = false;
            grvCongNhan.Columns["ID_QDTV"].Visible = false;
            grvCongNhan.Columns["TinhTrang"].Visible = false;
            grvCongNhan.Columns["ID_LD_TV"].Visible = false;
            grvCongNhan.Columns["NGAY_SINH"].Visible = false;
            grvCongNhan.Columns["Hinh_CN"].Visible = false;
            grvCongNhan.Columns["DT_DI_DONG"].Visible = false;
            grvCongNhan.Columns["NGUYEN_QUAN"].Visible = false;
            grvCongNhan.Columns["MS_CN"].Visible = false;
            grvCongNhan.Columns["NGAY_VAO_CTY"].Visible = false;
            if (idCN != -1)
            {
                int index = dt.Rows.IndexOf(dt.Rows.Find(idCN));
                grvCongNhan.FocusedRowHandle = grvCongNhan.GetRowHandle(index);
            }
        }

        private void LoadCboLyDoThoiViec()
        {
            DataTable dt = new DataTable();
            dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetComBoLyDoThoiViec", Commons.Modules.UserName, Commons.Modules.TypeLanguage));
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_LD_TVLookUpEdit, dt, "ID_LD_TV", "TEN_LD_TV", "TEN_LD_TV");
        }

        private void LoadNguoiKy()
        {
            DataTable dt = new DataTable();
            dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetComBoNguoiKi", Commons.Modules.UserName, Commons.Modules.TypeLanguage));
            Commons.Modules.ObjSystems.MLoadLookUpEdit(ID_NKLookUpEdit, dt, "ID_NK", "HO_TEN", "HO_TEN");

        }

        private void radTinhTrangLV_EditValueChanged(object sender, EventArgs e)
        {
            DataTable dtTmp = new DataTable();
            string sdkien = "( 1 = 1 )";
            try
            {
                dtTmp = (DataTable)grdCongNhan.DataSource;

                if (radTinhTrangLV.SelectedIndex == 1) sdkien = "(TinhTrang = 0)";
                if (radTinhTrangLV.SelectedIndex == 2) sdkien = "(TinhTrang = 1)";
                dtTmp.DefaultView.RowFilter = sdkien;
            }
            catch
            {
                try
                {
                    dtTmp.DefaultView.RowFilter = "";
                }
                catch { }
            }
        }
        private void grvCongNhan_DoubleClick(object sender, EventArgs e)
        {
            navigationFrame.SelectedPage = navigationPage2;
            enableButon(false);
        }
        private void LoadText()
        {
            MS_CNtextEdit.EditValue = grvCongNhan.GetFocusedRowCellValue("MS_CN");
            TEN_CNtextEdit.EditValue = grvCongNhan.GetFocusedRowCellValue("TEN_CN");
            NGAY_SINHTextEdit.EditValue = Convert.ToDateTime(grvCongNhan.GetFocusedRowCellValue("NGAY_SINH")).ToShortDateString();
            SO_DTtextEdit.EditValue = grvCongNhan.GetFocusedRowCellValue("DT_DI_DONG");
            NGUYEN_QUANtextEdit.EditValue = grvCongNhan.GetFocusedRowCellValue("NGUYEN_QUAN");
            NGAY_VAO_CTYTextEdit.EditValue = grvCongNhan.GetFocusedRowCellValue("NGAY_VAO_CTY");
            try
            {
                Byte[] data = new Byte[0];
                data = (Byte[])(grvCongNhan.GetFocusedRowCellValue("Hinh_CN"));
                MemoryStream mem = new MemoryStream(data);
                Hinh_CNpictureEdit.Image = Image.FromStream(mem);
            }
            catch (Exception ex)
            {
                throw;
            }

            try
            {
                if (grvCongNhan.GetFocusedRowCellValue("ID_QDTV").ToString() != string.Empty)
                {
                    string sSql = "SELECT * FROM dbo.QUYET_DINH_THOI_VIEC WHERE ID_QDTV = " + grvCongNhan.GetFocusedRowCellValue("ID_QDTV") + "";
                    DataTable dt = new DataTable();
                    dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, CommandType.Text, sSql));
                    DataRow row = dt.Rows[0];
                    SO_QDTextEdit.EditValue = row["SO_QD"];
                    NGAY_NHAN_DONDateEdit.EditValue = row["NGAY_NHAN_DON"];
                    NGAY_THOI_VIECDateEdit.EditValue = row["NGAY_THOI_VIEC"];
                    TIEN_TRO_CAPTextEdit.EditValue = row["TIEN_TRO_CAP"];
                    TRO_CAP_KHACTextEdit.EditValue = row["TRO_CAP_KHAC"];
                    TONG_CONGTextEdit.EditValue = row["TONG_CONG"];
                    NGAY_KYDateEdit.EditValue = row["NGAY_KY"];
                    ID_LD_TVLookUpEdit.EditValue = row["ID_LD_TV"];
                    NGAY_VAO_CTYTextEdit.EditValue = row["NGAY_VAO_CTY"];
                    NGUYEN_NHANTextEdit.EditValue = row["NGUYEN_NHAN"];


                    //HS_LUONGTextEdit.EditValue = row["HS_LUONG"];
                    //NGAY_PHEPTextEdit.EditValue = row["NGAY_PHEP"];
                    //LUONG_TINH_PHEPTextEdit.EditValue = row["LUONG_TINH_PHEP"];
                    //TIEN_PHEPTextEdit.EditValue = row["TIEN_PHEP"];
                    //LUONG_TOI_THIEUTextEdit.EditValue = row["LUONG_TOI_THIEU"];
                }
                else
                {
                    SO_QDTextEdit.EditValue = "";
                    NGAY_NHAN_DONDateEdit.EditValue = DateTime.Today;
                    NGAY_THOI_VIECDateEdit.EditValue = DateTime.Today;
                    TRO_CAP_KHACTextEdit.EditValue = 0;
                    NGAY_KYDateEdit.EditValue = DateTime.Today;
                    ID_LD_TVLookUpEdit.EditValue = "";
                    NGAY_VAO_CTYTextEdit.EditValue = DateTime.Today;
                    NGUYEN_NHANTextEdit.EditValue = "";
                    GHI_CHUMemoEdit.EditValue = "";
                    ID_NKLookUpEdit.EditValue = "";
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void navigationFrame_SelectedPageChanging(object sender, SelectedPageChangingEventArgs e)
        {
            if (navigationFrame.SelectedPage == navigationPage1)
            {
                if (grvCongNhan.RowCount == 0)
                {
                    XtraMessageBox.Show(Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgBanCoChuaChonCongNhan"), Commons.Modules.ObjLanguages.GetLanguage(this.Name, "msgThongBao"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
                else
                {
                    LoadText();
                    dxValidationProvider1.Validate();
                }
            }
        }
        private void NGAY_THOI_VIECDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            //tính lương
            try
            {
                DataTable dt = new DataTable();
                string sSql = "SELECT * FROM dbo.funTinhKeHoachNghiPhep(" + grvCongNhan.GetFocusedRowCellValue("ID_CN") + ",'" + NGAY_THOI_VIECDateEdit.DateTime.ToString("MM/dd/yyyy") + "')";
                dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, CommandType.Text, sSql));
                HS_LUONGTextEdit.EditValue = dt.Rows[0]["HS_LUONG"];
                LUONG_TOI_THIEUTextEdit.EditValue = dt.Rows[0]["LUONG_TOI_THIEU"];
                TIEN_TRO_CAPTextEdit.EditValue = dt.Rows[0]["TIEN_TRO_CAP"];
                NGAY_PHEPTextEdit.EditValue = dt.Rows[0]["NGAY_PHEP"];
                LUONG_TINH_PHEPTextEdit.EditValue = dt.Rows[0]["LUONG_TINH_PHEP"];
                TIEN_PHEPTextEdit.EditValue = dt.Rows[0]["TIEN_PHEP"];
                TONG_CONGTextEdit.EditValue = Convert.ToInt32(TIEN_TRO_CAPTextEdit.EditValue) + Convert.ToInt32(TIEN_PHEPTextEdit.EditValue) + Convert.ToInt32(TRO_CAP_KHACTextEdit.EditValue);
                dxValidationProvider1.Validate();
            }
            catch (Exception ex)
            {

            }
        }

        private void TRO_CAP_KHACTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                TONG_CONGTextEdit.EditValue = Convert.ToInt32(TIEN_TRO_CAPTextEdit.EditValue) + Convert.ToInt32(TIEN_PHEPTextEdit.EditValue) + Convert.ToInt32(TRO_CAP_KHACTextEdit.EditValue);
            }
            catch
            {
            }

        }
    }
}