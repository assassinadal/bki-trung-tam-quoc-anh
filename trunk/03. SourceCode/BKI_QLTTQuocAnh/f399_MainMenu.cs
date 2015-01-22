﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BKI_QLTTQuocAnh;
//using DevComponents.DotNetBar;
using IP.Core.IPSystemAdmin;
using System.Security.Policy;
using BKI_QLTTQuocAnh.NghiepVu;
using BKI_QLTTQuocAnh.BaoCao;
using BKI_QLTTQuocAnh.DanhMuc;
using BKI_QLTTQuocAnh.HeThong;
using GuiDev;
using DevExpress.XtraTab;

namespace Form_menu {
    public partial class f399_MainMenu : DevComponents.DotNetBar.Office2007RibbonForm {
        TabAdd m_tab_add = new TabAdd();
        public f399_MainMenu() {
            InitializeComponent();
            format_controls();
            m_tab_add.setCloseButtonTab(xtraTabControl1, ClosePageButtonShowMode.InAllTabPageHeaders);
        }
        #region Members
        int trangthaiweb = 1;
        #endregion
        #region Public Interface
        public void display(ref IP.Core.IPCommon.IPConstants.HowUserWantTo_Exit_MainForm v_exitmode) {
            try {
                this.ShowDialog();
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }

        }
        #endregion
        #region Private Method

        private void format_controls() {
            //CControlFormat.setFormStyle(this, new CAppContext_201());
            set_define_events();
            this.ShowInTaskbar = true;
            m_cmd_dang_nhap.Enabled = false;
            m_cmd_thong_tin.Enabled = false;
            m_cmd_sao_luu.Enabled = false;
            m_cmd_phuc_hoi.Enabled = false;
            m_cmd_doi_mat_khau.Enabled = true;
            m_cmd_nhat_ky_he_thong.Enabled = false;
            m_cmd_mua_hang.Enabled = false;
            m_cmd_ban_hang.Enabled = false;
            m_cmd_nhap_tu_excel.Enabled = false;
            m_cmd_tien_te.Enabled = false;
            m_cmd_thue.Enabled = false;
            m_cmd_tai_khoan.Enabled = false;
            //m_cmd_nha_cung_cap.Enabled = false;
            //m_cmd_nhap_so_du_dau.Enabled = false;
            m_cmd_ma_vach.Enabled = false;
        }
        public void closeTabPage(EventArgs e)
        {
            m_tab_add.setCloseTabInEventCloseForm(xtraTabControl1, e);
        }
        #endregion
        // Event handlers
        private void set_define_events() {
            xtraTabControl1.CloseButtonClick += xtraTabControl1_CloseButtonClick;
            m_cmd_bc_thuc_thu_phai_thu_hs.Click += m_cmd_bc_thuc_thu_phai_thu_hs_Click;
            m_cmd_bc_phai_thu_thuc_thu_theo_lm_hs.Click += m_cmd_bc_phai_thu_thuc_thu_theo_lm_hs_Click;
            m_cmd_phai_thu_theo_lm_hs.Click += m_cmd_phai_thu_theo_lm_hs_Click;
        }

        void m_cmd_phai_thu_theo_lm_hs_Click(object sender, EventArgs e)
        {
            try
            {
                F420_bao_cao_tien_phai_thu_theo_lop_mon_hoc_sinh v_frm = new F420_bao_cao_tien_phai_thu_theo_lop_mon_hoc_sinh();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);

            }
        }

        void m_cmd_bc_phai_thu_thuc_thu_theo_lm_hs_Click(object sender, EventArgs e)
        {
            try
            {
                f480_bao_cao_tinh_hinh_tai_chinh_theo_hs_lm v_frm = new f480_bao_cao_tinh_hinh_tai_chinh_theo_hs_lm();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);

            }
        }

        void m_cmd_bc_thuc_thu_phai_thu_hs_Click(object sender, EventArgs e)
        {
            try
            {
                f470_bao_cao_tinh_hinh_tai_chinh_theo_hoc_sinh v_frm = new f470_bao_cao_tinh_hinh_tai_chinh_theo_hoc_sinh();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);

            }
        }
   

        public void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            closeTabPage(e);
        }

        private void m_cmd_phan_quyen_Click(object sender, EventArgs e) {
            try {
                f999_ht_nguoi_su_dung v_frm = new f999_ht_nguoi_su_dung();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);

            }
        }

        private void m_cmd_thoat_Click(object sender, EventArgs e) {
            try {
                this.Close();
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_tu_dien_Click(object sender, EventArgs e) {
            try {
                f100_TuDien v_frm = new f100_TuDien();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_nhom_nguoi_sd_Click(object sender, EventArgs e) {
            try
            {
                f306_HT_USER_GROUP v_frm = new f306_HT_USER_GROUP();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch (System.Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_phan_quyen_cho_nhom_Click(object sender, EventArgs e) {
            try
            {
                f995_ht_phan_quyen_cho_nhom v_frm = new f995_ht_phan_quyen_cho_nhom();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch (System.Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_phan_quyen_he_thong_Click(object sender, EventArgs e) {
            try
            {
                f993_phan_quyen_he_thong v_frm = new f993_phan_quyen_he_thong();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch (System.Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_phan_quyen_chi_tiet_Click(object sender, EventArgs e) {
            try
            {
                f994_phan_quyen_detail v_frm = new f994_phan_quyen_detail();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch (System.Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
        }

    }
}
