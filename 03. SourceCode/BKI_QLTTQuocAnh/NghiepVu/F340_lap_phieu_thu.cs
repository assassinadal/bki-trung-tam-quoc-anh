


using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;
using IP.Core.IPSystemAdmin;

using BKI_QLTTQuocAnh.US;
using BKI_QLTTQuocAnh.DS;
using BKI_QLTTQuocAnh.DS.CDBNames;
using BKI_QLTTQuocAnh.BaoCao;
using BKI_QLTTQuocAnh.DanhMuc;
using C1.Win.C1FlexGrid;

namespace BKI_QLTTQuocAnh.NghiepVu {



    public class f340_lap_phieu_thu : System.Windows.Forms.Form {
        #region Design_Form
        internal System.Windows.Forms.ImageList ImageList;
        private Panel panel1;
        private Label m_lbl_header;
        internal ImageList imageList1;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        internal SIS.Controls.Button.SiSButton m_cmd_delete;
        internal SIS.Controls.Button.SiSButton m_cmd_ds_phieu;
        internal SIS.Controls.Button.SiSButton m_cmd_update;
        internal SIS.Controls.Button.SiSButton m_cmd_insert;
        internal Panel m_pnl_out_place_dm;
        private Panel panel2;
        private C1FlexGrid m_fg;
        private Panel panel3;
        internal SIS.Controls.Button.SiSButton m_cmd_chon_hs;
        private ComboBox m_cbo_nhan_vien_thu;
        private ComboBox m_cbo_nhan_vien_nhap;
        private Label m_lbl_ngay_thu;
        private DateTimePicker m_dat_ngay_nhap;
        private DateTimePicker m_dat_ngay_thu;
        private TextBox m_txt_noi_dung;
        private Label m_lbl_hoc_sinh;
        private Label m_lbl_den_ngay;
        private Label m_lbl_noi_dung;
        private TextBox m_txt_ten_nguoi_nop_tien;
        private Label m_lbl_nhan_vien_nhap;
        private TextBox m_txt_ho_ten_hs;
        private Label m_lbl_ten_nguoi_nop_tien;
        private Label m_lbl_nhan_vien_thu;
        private Label m_lbl_so_phieu;
        private TextBox m_txt_so_phieu;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private System.ComponentModel.IContainer components;
        #endregion

        public f340_lap_phieu_thu() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            format_controls();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f340_lap_phieu_thu));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_ds_phieu = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_cmd_chon_hs = new SIS.Controls.Button.SiSButton();
            this.m_cbo_nhan_vien_thu = new System.Windows.Forms.ComboBox();
            this.m_cbo_nhan_vien_nhap = new System.Windows.Forms.ComboBox();
            this.m_lbl_ngay_thu = new System.Windows.Forms.Label();
            this.m_dat_ngay_nhap = new System.Windows.Forms.DateTimePicker();
            this.m_dat_ngay_thu = new System.Windows.Forms.DateTimePicker();
            this.m_txt_noi_dung = new System.Windows.Forms.TextBox();
            this.m_lbl_hoc_sinh = new System.Windows.Forms.Label();
            this.m_lbl_den_ngay = new System.Windows.Forms.Label();
            this.m_lbl_noi_dung = new System.Windows.Forms.Label();
            this.m_txt_ten_nguoi_nop_tien = new System.Windows.Forms.TextBox();
            this.m_lbl_nhan_vien_nhap = new System.Windows.Forms.Label();
            this.m_txt_ho_ten_hs = new System.Windows.Forms.TextBox();
            this.m_lbl_ten_nguoi_nop_tien = new System.Windows.Forms.Label();
            this.m_lbl_nhan_vien_thu = new System.Windows.Forms.Label();
            this.m_lbl_so_phieu = new System.Windows.Forms.Label();
            this.m_txt_so_phieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.m_pnl_out_place_dm.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "");
            this.ImageList.Images.SetKeyName(1, "");
            this.ImageList.Images.SetKeyName(2, "");
            this.ImageList.Images.SetKeyName(3, "");
            this.ImageList.Images.SetKeyName(4, "");
            this.ImageList.Images.SetKeyName(5, "");
            this.ImageList.Images.SetKeyName(6, "");
            this.ImageList.Images.SetKeyName(7, "");
            this.ImageList.Images.SetKeyName(8, "");
            this.ImageList.Images.SetKeyName(9, "");
            this.ImageList.Images.SetKeyName(10, "");
            this.ImageList.Images.SetKeyName(11, "");
            this.ImageList.Images.SetKeyName(12, "");
            this.ImageList.Images.SetKeyName(13, "");
            this.ImageList.Images.SetKeyName(14, "");
            this.ImageList.Images.SetKeyName(15, "");
            this.ImageList.Images.SetKeyName(16, "");
            this.ImageList.Images.SetKeyName(17, "");
            this.ImageList.Images.SetKeyName(18, "");
            this.ImageList.Images.SetKeyName(19, "");
            this.ImageList.Images.SetKeyName(20, "");
            this.ImageList.Images.SetKeyName(21, "");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_lbl_header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 42);
            this.panel1.TabIndex = 21;
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(1005, 41);
            this.m_lbl_header.TabIndex = 27;
            this.m_lbl_header.Text = "LẬP PHIẾU THỰC THU";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            this.imageList1.Images.SetKeyName(12, "");
            this.imageList1.Images.SetKeyName(13, "");
            this.imageList1.Images.SetKeyName(14, "");
            this.imageList1.Images.SetKeyName(15, "");
            this.imageList1.Images.SetKeyName(16, "");
            this.imageList1.Images.SetKeyName(17, "");
            this.imageList1.Images.SetKeyName(18, "");
            this.imageList1.Images.SetKeyName(19, "");
            this.imageList1.Images.SetKeyName(20, "");
            this.imageList1.Images.SetKeyName(21, "");
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 12;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(913, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_delete.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_delete.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_delete.ImageIndex = 4;
            this.m_cmd_delete.ImageList = this.ImageList;
            this.m_cmd_delete.Location = new System.Drawing.Point(825, 4);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_delete.TabIndex = 14;
            this.m_cmd_delete.Text = "&Xoá";
            this.m_cmd_delete.Visible = false;
            // 
            // m_cmd_ds_phieu
            // 
            this.m_cmd_ds_phieu.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_ds_phieu.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_ds_phieu.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_ds_phieu.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_ds_phieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_ds_phieu.ImageIndex = 19;
            this.m_cmd_ds_phieu.ImageList = this.ImageList;
            this.m_cmd_ds_phieu.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_ds_phieu.Name = "m_cmd_ds_phieu";
            this.m_cmd_ds_phieu.Size = new System.Drawing.Size(144, 28);
            this.m_cmd_ds_phieu.TabIndex = 21;
            this.m_cmd_ds_phieu.Text = "Danh sách phiếu";
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_update.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_update.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_update.ImageIndex = 3;
            this.m_cmd_update.ImageList = this.ImageList;
            this.m_cmd_update.Location = new System.Drawing.Point(737, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_update.TabIndex = 13;
            this.m_cmd_update.Text = "&Sửa";
            this.m_cmd_update.Visible = false;
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_insert.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_insert.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_insert.ImageIndex = 2;
            this.m_cmd_insert.ImageList = this.ImageList;
            this.m_cmd_insert.Location = new System.Drawing.Point(649, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_insert.TabIndex = 12;
            this.m_cmd_insert.Text = "&Lập phiếu";
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_ds_phieu);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 434);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(1005, 36);
            this.m_pnl_out_place_dm.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_fg);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 392);
            this.panel2.TabIndex = 23;
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 284);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(1005, 108);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 62;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dateTimePicker2);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.m_cmd_chon_hs);
            this.panel3.Controls.Add(this.m_cbo_nhan_vien_thu);
            this.panel3.Controls.Add(this.m_cbo_nhan_vien_nhap);
            this.panel3.Controls.Add(this.m_lbl_ngay_thu);
            this.panel3.Controls.Add(this.m_dat_ngay_nhap);
            this.panel3.Controls.Add(this.m_dat_ngay_thu);
            this.panel3.Controls.Add(this.m_txt_noi_dung);
            this.panel3.Controls.Add(this.m_lbl_hoc_sinh);
            this.panel3.Controls.Add(this.m_lbl_den_ngay);
            this.panel3.Controls.Add(this.m_lbl_noi_dung);
            this.panel3.Controls.Add(this.m_txt_ten_nguoi_nop_tien);
            this.panel3.Controls.Add(this.m_lbl_nhan_vien_nhap);
            this.panel3.Controls.Add(this.m_txt_ho_ten_hs);
            this.panel3.Controls.Add(this.m_lbl_ten_nguoi_nop_tien);
            this.panel3.Controls.Add(this.m_lbl_nhan_vien_thu);
            this.panel3.Controls.Add(this.m_lbl_so_phieu);
            this.panel3.Controls.Add(this.m_txt_so_phieu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1005, 284);
            this.panel3.TabIndex = 63;
            // 
            // m_cmd_chon_hs
            // 
            this.m_cmd_chon_hs.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_chon_hs.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_chon_hs.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_chon_hs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_chon_hs.ImageIndex = 7;
            this.m_cmd_chon_hs.ImageList = this.ImageList;
            this.m_cmd_chon_hs.Location = new System.Drawing.Point(218, 56);
            this.m_cmd_chon_hs.Name = "m_cmd_chon_hs";
            this.m_cmd_chon_hs.Size = new System.Drawing.Size(81, 28);
            this.m_cmd_chon_hs.TabIndex = 78;
            this.m_cmd_chon_hs.Text = "&Chọn HS";
            // 
            // m_cbo_nhan_vien_thu
            // 
            this.m_cbo_nhan_vien_thu.FormattingEnabled = true;
            this.m_cbo_nhan_vien_thu.Location = new System.Drawing.Point(109, 92);
            this.m_cbo_nhan_vien_thu.Name = "m_cbo_nhan_vien_thu";
            this.m_cbo_nhan_vien_thu.Size = new System.Drawing.Size(190, 21);
            this.m_cbo_nhan_vien_thu.TabIndex = 68;
            // 
            // m_cbo_nhan_vien_nhap
            // 
            this.m_cbo_nhan_vien_nhap.FormattingEnabled = true;
            this.m_cbo_nhan_vien_nhap.Location = new System.Drawing.Point(109, 188);
            this.m_cbo_nhan_vien_nhap.Name = "m_cbo_nhan_vien_nhap";
            this.m_cbo_nhan_vien_nhap.Size = new System.Drawing.Size(127, 21);
            this.m_cbo_nhan_vien_nhap.TabIndex = 69;
            // 
            // m_lbl_ngay_thu
            // 
            this.m_lbl_ngay_thu.AutoSize = true;
            this.m_lbl_ngay_thu.Location = new System.Drawing.Point(11, 34);
            this.m_lbl_ngay_thu.Name = "m_lbl_ngay_thu";
            this.m_lbl_ngay_thu.Size = new System.Drawing.Size(53, 13);
            this.m_lbl_ngay_thu.TabIndex = 62;
            this.m_lbl_ngay_thu.Text = "Ngày thu:";
            // 
            // m_dat_ngay_nhap
            // 
            this.m_dat_ngay_nhap.CustomFormat = "dd/MM/yyyy";
            this.m_dat_ngay_nhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_ngay_nhap.Location = new System.Drawing.Point(109, 223);
            this.m_dat_ngay_nhap.Name = "m_dat_ngay_nhap";
            this.m_dat_ngay_nhap.Size = new System.Drawing.Size(84, 20);
            this.m_dat_ngay_nhap.TabIndex = 65;
            // 
            // m_dat_ngay_thu
            // 
            this.m_dat_ngay_thu.CustomFormat = "dd/MM/yyyy";
            this.m_dat_ngay_thu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_ngay_thu.Location = new System.Drawing.Point(109, 32);
            this.m_dat_ngay_thu.Name = "m_dat_ngay_thu";
            this.m_dat_ngay_thu.Size = new System.Drawing.Size(103, 20);
            this.m_dat_ngay_thu.TabIndex = 64;
            // 
            // m_txt_noi_dung
            // 
            this.m_txt_noi_dung.Location = new System.Drawing.Point(109, 131);
            this.m_txt_noi_dung.Multiline = true;
            this.m_txt_noi_dung.Name = "m_txt_noi_dung";
            this.m_txt_noi_dung.Size = new System.Drawing.Size(190, 46);
            this.m_txt_noi_dung.TabIndex = 76;
            // 
            // m_lbl_hoc_sinh
            // 
            this.m_lbl_hoc_sinh.AutoSize = true;
            this.m_lbl_hoc_sinh.Location = new System.Drawing.Point(11, 64);
            this.m_lbl_hoc_sinh.Name = "m_lbl_hoc_sinh";
            this.m_lbl_hoc_sinh.Size = new System.Drawing.Size(92, 13);
            this.m_lbl_hoc_sinh.TabIndex = 74;
            this.m_lbl_hoc_sinh.Text = "Họ tên học sinh(*)";
            // 
            // m_lbl_den_ngay
            // 
            this.m_lbl_den_ngay.AutoSize = true;
            this.m_lbl_den_ngay.Location = new System.Drawing.Point(11, 225);
            this.m_lbl_den_ngay.Name = "m_lbl_den_ngay";
            this.m_lbl_den_ngay.Size = new System.Drawing.Size(62, 13);
            this.m_lbl_den_ngay.TabIndex = 63;
            this.m_lbl_den_ngay.Text = "Ngày nhập:";
            // 
            // m_lbl_noi_dung
            // 
            this.m_lbl_noi_dung.AutoSize = true;
            this.m_lbl_noi_dung.Location = new System.Drawing.Point(11, 134);
            this.m_lbl_noi_dung.Name = "m_lbl_noi_dung";
            this.m_lbl_noi_dung.Size = new System.Drawing.Size(60, 13);
            this.m_lbl_noi_dung.TabIndex = 77;
            this.m_lbl_noi_dung.Text = "Nội dung(*)";
            // 
            // m_txt_ten_nguoi_nop_tien
            // 
            this.m_txt_ten_nguoi_nop_tien.Location = new System.Drawing.Point(109, 259);
            this.m_txt_ten_nguoi_nop_tien.Name = "m_txt_ten_nguoi_nop_tien";
            this.m_txt_ten_nguoi_nop_tien.Size = new System.Drawing.Size(219, 20);
            this.m_txt_ten_nguoi_nop_tien.TabIndex = 72;
            // 
            // m_lbl_nhan_vien_nhap
            // 
            this.m_lbl_nhan_vien_nhap.AutoSize = true;
            this.m_lbl_nhan_vien_nhap.Location = new System.Drawing.Point(11, 191);
            this.m_lbl_nhan_vien_nhap.Name = "m_lbl_nhan_vien_nhap";
            this.m_lbl_nhan_vien_nhap.Size = new System.Drawing.Size(93, 13);
            this.m_lbl_nhan_vien_nhap.TabIndex = 67;
            this.m_lbl_nhan_vien_nhap.Text = "Nhân viên nhập(*)";
            // 
            // m_txt_ho_ten_hs
            // 
            this.m_txt_ho_ten_hs.Location = new System.Drawing.Point(109, 61);
            this.m_txt_ho_ten_hs.Name = "m_txt_ho_ten_hs";
            this.m_txt_ho_ten_hs.Size = new System.Drawing.Size(103, 20);
            this.m_txt_ho_ten_hs.TabIndex = 73;
            // 
            // m_lbl_ten_nguoi_nop_tien
            // 
            this.m_lbl_ten_nguoi_nop_tien.AutoSize = true;
            this.m_lbl_ten_nguoi_nop_tien.Location = new System.Drawing.Point(11, 262);
            this.m_lbl_ten_nguoi_nop_tien.Name = "m_lbl_ten_nguoi_nop_tien";
            this.m_lbl_ten_nguoi_nop_tien.Size = new System.Drawing.Size(99, 13);
            this.m_lbl_ten_nguoi_nop_tien.TabIndex = 75;
            this.m_lbl_ten_nguoi_nop_tien.Text = "Tên người nộp tiền:";
            // 
            // m_lbl_nhan_vien_thu
            // 
            this.m_lbl_nhan_vien_thu.AutoSize = true;
            this.m_lbl_nhan_vien_thu.Location = new System.Drawing.Point(11, 95);
            this.m_lbl_nhan_vien_thu.Name = "m_lbl_nhan_vien_thu";
            this.m_lbl_nhan_vien_thu.Size = new System.Drawing.Size(84, 13);
            this.m_lbl_nhan_vien_thu.TabIndex = 66;
            this.m_lbl_nhan_vien_thu.Text = "Nhân viên thu(*)";
            // 
            // m_lbl_so_phieu
            // 
            this.m_lbl_so_phieu.AutoSize = true;
            this.m_lbl_so_phieu.Location = new System.Drawing.Point(11, 5);
            this.m_lbl_so_phieu.Name = "m_lbl_so_phieu";
            this.m_lbl_so_phieu.Size = new System.Drawing.Size(59, 13);
            this.m_lbl_so_phieu.TabIndex = 71;
            this.m_lbl_so_phieu.Text = "Số phiếu(*)";
            // 
            // m_txt_so_phieu
            // 
            this.m_txt_so_phieu.Location = new System.Drawing.Point(109, 2);
            this.m_txt_so_phieu.Name = "m_txt_so_phieu";
            this.m_txt_so_phieu.Size = new System.Drawing.Size(103, 20);
            this.m_txt_so_phieu.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Thu từ ngày";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(424, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(103, 20);
            this.dateTimePicker1.TabIndex = 80;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(424, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(103, 20);
            this.dateTimePicker2.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "Đến ngày";
            // 
            // f340_lap_phieu_thu
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1005, 470);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Controls.Add(this.panel1);
            this.Name = "f340_lap_phieu_thu";
            this.Text = "F340 - Lập phiếu thực thu";
            this.Load += new System.EventHandler(this.f340_lap_phieu_thu_Load);
            this.panel1.ResumeLayout(false);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Public Interface
        public void display() {
            this.ShowDialog();
        }

        public void display(US_V_RPT_BAO_CAO_DANH_SACH_PHIEU_THU ip_us, decimal ip_dc_id_loai_phieu_thu, decimal ip_dc_id_nguoi_nhap) {
            m_txt_so_phieu.Text = ip_us.strSO_PHIEU.Trim();
            m_txt_ho_ten_hs.Text = ip_us.strHO_TEN_HS.Trim();
            m_txt_ten_nguoi_nop_tien.Text = ip_us.strHO_TEN_PH.Trim();
            m_txt_noi_dung.Text = ip_us.strNOI_DUNG.Trim();
            if (ip_dc_id_loai_phieu_thu == ID_LOAI_PHIEU_THU.ID_PHIEU_PHAI_THU) {
                //m_txt_so_tien_bang_so.Text = ip_us.dcTIEN_PHAI_THU.ToString("#,###");
                //m_txt_so_tien_bang_chu.Text = CTienNo2Text.So_chu((double)ip_us.dcTIEN_PHAI_THU);
                m_lbl_header.Text = "CHI TIẾT PHIẾU PHẢI THU";
            }
            else if (ip_dc_id_loai_phieu_thu == ID_LOAI_PHIEU_THU.ID_PHIEU_GIAM_TRU) {
                //m_txt_so_tien_bang_so.Text = ip_us.dcTIEN_GIAM_TRU.ToString("#,###");
                //m_txt_so_tien_bang_chu.Text = CTienNo2Text.So_chu((double)ip_us.dcTIEN_GIAM_TRU);
                m_lbl_header.Text = "CHI TIẾT PHIẾU GIẢM TRỪ";
            }
            else if (ip_dc_id_loai_phieu_thu == ID_LOAI_PHIEU_THU.ID_PHIEU_THUC_THU) {
                //m_txt_so_tien_bang_so.Text = ip_us.dcTIEN_THUC_THU.ToString("#,###");
                //m_txt_so_tien_bang_chu.Text = CTienNo2Text.So_chu((double)ip_us.dcTIEN_THUC_THU);
                m_lbl_header.Text = "CHI TIẾT PHIẾU THỰC THU";
            }
            //lap ham xu ly tien bang so qua bang chu
            m_cbo_nhan_vien_thu.SelectedValue = ip_us.dcID_NGUOI_THU;
            US_V_GD_PHIEU_THU v_us_v_pt = new US_V_GD_PHIEU_THU(ip_us.dcID);
            //m_lbl_header.Text = "LẬP " + v_us_v_pt.strTEN_NGAN;

            m_dat_ngay_thu.Value = ip_us.datNGAY_THU;
            m_dat_ngay_nhap.Value = DateTime.Now;

            load_data_2_cbo();
            m_cbo_nhan_vien_nhap.SelectedValue = ip_dc_id_nguoi_nhap;
            m_cbo_nhan_vien_thu.SelectedValue = ip_us.dcID_NGUOI_THU;

            m_fg.Visible = false;
            m_cmd_ds_phieu.Visible = false;
            this.ShowDialog();
        }



        #endregion

        #region Data Structure
        private enum e_col_Number {
            MA_LOP_MON = 3
,
            HO_TEN_PH = 4
                ,
            TONG_GIAM_TRU = 10
                ,
            MA_DOI_TUONG = 1
                ,
            TONG_THUC_THU = 11
                ,
            SDT_PH = 6
                ,
            TONG_CON_NO = 12
                ,
            TONG_PHAI_THU = 9
                ,
            HO_TEN = 2
                ,
            EMAIL_PH = 8
                ,
            SDT_HS = 5
                , EMAIL_HS = 7

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_RPT_NGHIEP_VU_LAP_PHIEU_THU m_ds = new DS_V_RPT_NGHIEP_VU_LAP_PHIEU_THU();
        US_V_RPT_NGHIEP_VU_LAP_PHIEU_THU m_us = new US_V_RPT_NGHIEP_VU_LAP_PHIEU_THU();
        US_V_DM_HOC_SINH m_us_v_dm_hoc_sinh = new US_V_DM_HOC_SINH();
        DataEntryFormMode m_e_form_mode;
        #endregion

        #region Private Methods
        private void load_data_2_cbo() {
            load_data_2_cbo_nguoi_nhap();
            load_data_2_cbo_nguoi_thu();
        }
        private void format_controls() {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            set_define_events();
            m_fg.AllowEditing = true;
            m_fg.Cols[(int)e_col_Number.TONG_PHAI_THU].AllowEditing = false;
            m_fg.Cols[(int)e_col_Number.TONG_GIAM_TRU].AllowEditing = false;
            m_fg.Cols[(int)e_col_Number.MA_LOP_MON].AllowEditing = false;
            m_fg.Cols[(int)e_col_Number.HO_TEN].AllowEditing = false;

            this.KeyPreview = true;
        }
        private void set_initial_form_load() {
            m_obj_trans = get_trans_object(m_fg);
            load_data_2_cbo();
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg) {
            Hashtable v_htb = new Hashtable();
            DS_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON v_ds = new DS_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON();
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON.MA_LOP_MON, e_col_Number.MA_LOP_MON);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON.HO_TEN_PH, e_col_Number.HO_TEN_PH);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON.TONG_GIAM_TRU, e_col_Number.TONG_GIAM_TRU);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON.MA_DOI_TUONG, e_col_Number.MA_DOI_TUONG);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON.TONG_THUC_THU, e_col_Number.TONG_THUC_THU);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON.SDT_PH, e_col_Number.SDT_PH);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON.TONG_CON_NO, e_col_Number.TONG_CON_NO);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON.TONG_PHAI_THU, e_col_Number.TONG_PHAI_THU);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON.HO_TEN, e_col_Number.HO_TEN);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON.EMAIL_PH, e_col_Number.EMAIL_PH);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON.SDT_HS, e_col_Number.SDT_HS);
            v_htb.Add(V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON.EMAIL_HS, e_col_Number.EMAIL_HS);

            //ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON.NewRow());
            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, v_ds.V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON.NewRow());
            return v_obj_trans;
        }

        private void load_data_2_cbo_nguoi_thu() {
            DS_V_HT_NGUOI_SU_DUNG v_ds = new DS_V_HT_NGUOI_SU_DUNG();
            US_V_HT_NGUOI_SU_DUNG v_us = new US_V_HT_NGUOI_SU_DUNG();

            v_us.FillDataset(v_ds);

            DataRow v_dr = v_ds.V_HT_NGUOI_SU_DUNG.NewRow();
            v_dr[V_HT_NGUOI_SU_DUNG.ID] = -1;
            v_dr[V_HT_NGUOI_SU_DUNG.TEN_TRUY_CAP] = "All";
            v_dr[V_HT_NGUOI_SU_DUNG.TEN] = "--Chưa chọn---";
            v_dr[V_HT_NGUOI_SU_DUNG.MAT_KHAU] = 123;
            v_dr[V_HT_NGUOI_SU_DUNG.NGAY_TAO] = "2015-01-20";
            v_dr[V_HT_NGUOI_SU_DUNG.NGUOI_TAO] = "ADMIN";
            v_dr[V_HT_NGUOI_SU_DUNG.TRANG_THAI] = "0";
            v_dr[V_HT_NGUOI_SU_DUNG.BUILT_IN_YN] = "Y";
            v_dr[V_HT_NGUOI_SU_DUNG.ID_USER_GROUP] = 3;


            v_ds.V_HT_NGUOI_SU_DUNG.Rows.InsertAt(v_dr, 0);

            m_cbo_nhan_vien_thu.DataSource = v_ds.V_HT_NGUOI_SU_DUNG;
            m_cbo_nhan_vien_thu.DisplayMember = V_HT_NGUOI_SU_DUNG.TEN;
            m_cbo_nhan_vien_thu.ValueMember = V_HT_NGUOI_SU_DUNG.ID;

            m_cbo_nhan_vien_thu.SelectedIndex = 0;
        }

        private void load_data_2_cbo_nguoi_nhap() {
            DS_V_HT_NGUOI_SU_DUNG v_ds = new DS_V_HT_NGUOI_SU_DUNG();
            US_V_HT_NGUOI_SU_DUNG v_us = new US_V_HT_NGUOI_SU_DUNG();

            v_us.FillDataset(v_ds);

            DataRow v_dr = v_ds.V_HT_NGUOI_SU_DUNG.NewRow();
            v_dr[V_HT_NGUOI_SU_DUNG.ID] = -1;
            v_dr[V_HT_NGUOI_SU_DUNG.TEN_TRUY_CAP] = "All";
            v_dr[V_HT_NGUOI_SU_DUNG.TEN] = "--Chưa chọn---";
            v_dr[V_HT_NGUOI_SU_DUNG.MAT_KHAU] = 123;
            v_dr[V_HT_NGUOI_SU_DUNG.NGAY_TAO] = "2015-01-20";
            v_dr[V_HT_NGUOI_SU_DUNG.NGUOI_TAO] = "ADMIN";
            v_dr[V_HT_NGUOI_SU_DUNG.TRANG_THAI] = "0";
            v_dr[V_HT_NGUOI_SU_DUNG.BUILT_IN_YN] = "Y";
            v_dr[V_HT_NGUOI_SU_DUNG.ID_USER_GROUP] = 3;


            v_ds.V_HT_NGUOI_SU_DUNG.Rows.InsertAt(v_dr, 0);

            m_cbo_nhan_vien_nhap.DataSource = v_ds.V_HT_NGUOI_SU_DUNG;
            m_cbo_nhan_vien_nhap.DisplayMember = V_HT_NGUOI_SU_DUNG.TEN;
            m_cbo_nhan_vien_nhap.ValueMember = V_HT_NGUOI_SU_DUNG.ID;

            m_cbo_nhan_vien_nhap.SelectedIndex = 0;
        }

        private void load_data_2_grid() {
            DS_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON v_ds = new DS_V_RPT_BAO_CAO_TINH_HINH_TAI_CHINH_HOC_SINH_LOP_MON();
            DateTime v_dat_tu_ngay = DateTime.Now.Date.AddDays(-DateTime.Now.Date.Day + 1);
            DateTime v_dat_den_ngay = DateTime.Now.Date.AddMonths(1).AddDays(-DateTime.Now.Date.Day + 1);
            m_us.FillDataset(v_ds, v_dat_tu_ngay, v_dat_den_ngay, m_us_v_dm_hoc_sinh.strHO_TEN);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(v_ds, m_fg, m_obj_trans);
            m_fg.Redraw = true;
        }

        private void grid2us_object(US_V_RPT_NGHIEP_VU_LAP_PHIEU_THU i_us
            , int i_grid_row) {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_RPT_NGHIEP_VU_LAP_PHIEU_THU i_us
            , int i_grid_row) {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }


        private void insert_v_rpt_nghiep_vu_lap_phieu_thu() {
            //	f340_lap_phieu_thu_DE v_fDE = new  f340_lap_phieu_thu_DE();								
            //	v_fDE.display();
            save_data();
            //load_data_2_grid();
        }

        private void update_v_rpt_nghiep_vu_lap_phieu_thu() {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	f340_lap_phieu_thu_DE v_fDE = new f340_lap_phieu_thu_DE();
            //	v_fDE.display(m_us);
            load_data_2_grid();
        }

        private void delete_v_rpt_nghiep_vu_lap_phieu_thu() {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_V_RPT_NGHIEP_VU_LAP_PHIEU_THU v_us = new US_V_RPT_NGHIEP_VU_LAP_PHIEU_THU();
            grid2us_object(v_us, m_fg.Row);
            try {
                v_us.BeginTransaction();
                v_us.Delete();
                v_us.CommitTransaction();
                m_fg.Rows.Remove(m_fg.Row);
            }
            catch (Exception v_e) {
                v_us.Rollback();
                CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_objErrHandler.showErrorMessage();
            }
        }

        private void view_v_rpt_nghiep_vu_lap_phieu_thu() {
            //if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            //if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            //grid2us_object(m_us, m_fg.Row);
            //	f340_lap_phieu_thu_DE v_fDE = new f340_lap_phieu_thu_DE();			
            //	v_fDE.display(m_us);
        }
        private void check_validate_data() {
            if (!CValidateTextBox.IsValid(m_txt_so_phieu, DataType.StringType, allowNull.NO)) {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập SỐ PHIẾU!");
                return;
            }
            if (!CValidateTextBox.IsValid(m_txt_ho_ten_hs, DataType.StringType, allowNull.NO)) {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập HỌ TÊN học sinh!");
                return;
            }
            if (!CValidateTextBox.IsValid(m_txt_noi_dung, DataType.StringType, allowNull.NO)) {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập NỘI DUNG phiếu!");
                return;
            }
        }
        private void form_2_us_obj() {
            m_us.strSO_PHIEU = m_txt_so_phieu.Text.Trim();
            m_us.datNGAY_THU = m_dat_ngay_thu.Value.Date;
            m_us.datNGAY_NHAP = m_dat_ngay_nhap.Value.Date;
            m_us.strTEN_NGUOI_NOP_TIEN = m_txt_ten_nguoi_nop_tien.Text.Trim();
            m_us.dcID_HOC_SINH = m_us_v_dm_hoc_sinh.dcID;
            m_us.dcID_NGUOI_THU = CIPConvert.ToDecimal(m_cbo_nhan_vien_thu.SelectedValue);
            m_us.dcID_NGUOI_NHAP = CIPConvert.ToDecimal(m_cbo_nhan_vien_nhap.SelectedValue);
            m_us.strNOI_DUNG = m_txt_noi_dung.Text.Trim();
        }
        private void save_data() {
            check_validate_data();
            form_2_us_obj();
            switch (m_e_form_mode) {
                case DataEntryFormMode.InsertDataState:
                    m_us.Insert();
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    break;
                case DataEntryFormMode.ViewDataState:
                    break;
                default:
                    break;
            }
        }

        #endregion

        //
        //
        //		EVENT HANLDERS
        //
        //

        private void set_define_events() {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            m_cmd_ds_phieu.Click += new EventHandler(m_cmd_view_Click);
            m_cmd_chon_hs.Click += m_cmd_chon_hs_Click;
        }

        void m_cmd_chon_hs_Click(object sender, EventArgs e) {
            try {
                f220_cap_nhat_thong_tin_hoc_sinh v_frm = new f220_cap_nhat_thong_tin_hoc_sinh();
                v_frm.display(ref m_us_v_dm_hoc_sinh);

                m_txt_ho_ten_hs.Text = m_us_v_dm_hoc_sinh.strHO_TEN;
                load_data_2_grid();
            }
            catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void f340_lap_phieu_thu_Load(object sender, System.EventArgs e) {
            try {
                set_initial_form_load();
            }
            catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_cmd_exit_Click(object sender, EventArgs e) {
            try {
                this.Close();
            }
            catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_insert_Click(object sender, EventArgs e) {
            try {
                insert_v_rpt_nghiep_vu_lap_phieu_thu();
            }
            catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_update_Click(object sender, EventArgs e) {
            try {
                update_v_rpt_nghiep_vu_lap_phieu_thu();
            }
            catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_delete_Click(object sender, EventArgs e) {
            try {
                delete_v_rpt_nghiep_vu_lap_phieu_thu();
            }
            catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_view_Click(object sender, EventArgs e) {
            try {
                view_v_rpt_nghiep_vu_lap_phieu_thu();
            }
            catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

    }
}