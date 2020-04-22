﻿using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using Microsoft.ApplicationBlocks.Data;
using DevExpress.XtraBars.Navigation;
using Vs.HRM;

namespace VietSoftHRM
{
    public partial class ucCongNhan : DevExpress.XtraEditors.XtraUserControl
    {
        public Color color;
        public int iLoai;
        public int iIDOut;
        public string slinkcha;
        public ucCongNhan()
        {
            InitializeComponent();
        }
        //load tất danh mục từ menu
        private void LoadCongNhan()
        {
               
            DataTable dt = new DataTable();
            dt.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetMenuLeft", Commons.Modules.UserName, Commons.Modules.TypeLanguage, iLoai));
            foreach (DataRow item in dt.Rows)
            {
                AccordionControlElement element = new AccordionControlElement();
                element.Expanded = true;
                element.Text = item["NAME"].ToString();
                element.Name = item["KEY_MENU"].ToString();
                element.Tag = item["CONTROLS"].ToString();
                accorMenuleft.Elements.Add(element);
                element.Click += Element_Click;
                DataTable dtchill = new DataTable();
                dtchill.Load(SqlHelper.ExecuteReader(Commons.IConnections.CNStr, "spGetMenuLeft", Commons.Modules.UserName, Commons.Modules.TypeLanguage, Convert.ToInt32(item["ID_MENU"])));
                if (dtchill.Rows.Count > 0)
                {
                    foreach (DataRow itemchill in dtchill.Rows)
                    {
                        AccordionControlElement elementchill = new AccordionControlElement();
                        elementchill.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                        elementchill.Text = itemchill["NAME"].ToString();
                        elementchill.Name = itemchill["KEY_MENU"].ToString();
                        elementchill.Tag = itemchill["CONTROLS"].ToString();
                        elementchill.Click += Elementchill_Click;
                        element.Elements.Add(elementchill);
                    }
                }
                else
                {
                    element.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                }

            }
        }

        //sự kiện click cha
        private void Element_Click(object sender, EventArgs e)
        {
            var button = sender as AccordionControlElement;
            lab_Link.Text = slinkcha + "/" + button.Text;
            switch (button.Name)
            {
                case "mnuKHNghiPhep":
                    {
                        if (!panel2.Controls.Contains(ucKeHoachNghiPhep.Instance))
                        {
                            panel2.Controls.Clear();
                            panel2.Controls.Add(ucKeHoachNghiPhep.Instance);
                            ucKeHoachNghiPhep.Instance.Dock = DockStyle.Fill;
                            ucKeHoachNghiPhep.Instance.BringToFront();
                        }
                        break;
                    }
                case "mnuDaoTao":
                    {
                        if (!panel2.Controls.Contains(ucDaoTao.Instance))
                        {
                            panel2.Controls.Clear();
                            panel2.Controls.Add(ucDaoTao.Instance);
                            ucDaoTao.Instance.Dock = DockStyle.Fill;
                            ucDaoTao.Instance.BringToFront();
                        }
                        break;
                    }
                case "mnuThoiViec":
                    {
                        ucQuyetDinhThoiViec thoiviec = new ucQuyetDinhThoiViec();
                        panel2.Controls.Clear();
                        panel2.Controls.Add(thoiviec);
                        thoiviec.Dock = DockStyle.Fill;
                        break;
                    }
                case "mnuNhanSu":
                    {
                        ucQLNS ns = new ucQLNS();
                        ns.accorMenuleft = accorMenuleft;
                        panel2.Controls.Clear();
                        panel2.Controls.Add(ns);
                        ns.Dock = DockStyle.Fill;
                        break;
                    }
              
                default:
                    break;
            }
        }
        //sự kiện click con
        private void Elementchill_Click(object sender, EventArgs e)
        {
            var button = sender as AccordionControlElement;
            lab_Link.Text = slinkcha + "/" + button.Text;
            switch (button.Name)
            {
                case "mnuKHNghiPhep":
                    {
                        if (!panel2.Controls.Contains(ucKeHoachNghiPhep.Instance))
                        {
                            panel2.Controls.Clear();
                            panel2.Controls.Add(ucKeHoachNghiPhep.Instance);
                            ucKeHoachNghiPhep.Instance.Dock = DockStyle.Fill;
                            ucKeHoachNghiPhep.Instance.BringToFront();
                        }
                        break;
                    }
                case "mnuDaoTao":
                    {
                        if (!panel2.Controls.Contains(ucDaoTao.Instance))
                        {
                            panel2.Controls.Clear();
                            panel2.Controls.Add(ucDaoTao.Instance);
                            ucDaoTao.Instance.Dock = DockStyle.Fill;
                            ucDaoTao.Instance.BringToFront();
                        }
                        break;
                    }
                case "mnuThoiViec":
                    {
                        ucQuyetDinhThoiViec thoiviec = new ucQuyetDinhThoiViec();
                        panel2.Controls.Clear();
                        panel2.Controls.Add(thoiviec);
                        thoiviec.Dock = DockStyle.Fill;
                        break;
                    }
                case "mnuNhanSu":
                    {
                        Vs.HRM.ucQLNS ns = new Vs.HRM.ucQLNS();
                        ns.accorMenuleft = accorMenuleft;
                        panel2.Controls.Clear();
                        panel2.Controls.Add(ns);
                        ns.Dock = DockStyle.Fill;
                        break;
                    }
                case "mnuTroCap":
                    {
                        ucTroCapBHXH tc = new ucTroCapBHXH();
                        panel2.Controls.Clear();
                        panel2.Controls.Add(tc);
                        tc.Dock = DockStyle.Fill;
                        break;
                    }
                default:
                    break;
            }
        }
        private void ucSystems_Load(object sender, EventArgs e)
        {
            slinkcha = lab_Link.Text;
            LoadCongNhan();
            try
            {
                accorMenuleft.SelectElement(accorMenuleft.Elements[0].Elements[0]);
                Element_Click(accorMenuleft.Elements[0].Elements[0], null);
            }
            catch 
            {
            }
        }
    }
}