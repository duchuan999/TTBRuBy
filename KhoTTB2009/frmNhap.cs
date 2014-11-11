using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Medisoft2009.Usercontrol;
using LibTTB;
using doiso;

namespace TTB
{
	/// <summary>
	/// Summary description for frmNhap.
	/// </summary>
	public class frmNhap : System.Windows.Forms.Form
	{
        bool bSoPhieuNhapKhoTangTuDong = false;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private MaskedBox.MaskedBox ngaysp;
		private MaskedBox.MaskedBox ngayhd;
		private MaskedBox.MaskedBox ngaykiem;
		private System.Windows.Forms.TextBox madv;
		private System.Windows.Forms.TextBox tendv;
		private System.Windows.Forms.ComboBox manguon;
		private System.Windows.Forms.ComboBox makho;
		private List listNX;
		private List listDMBD;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label lTen;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox tenbd;
		private System.Windows.Forms.TextBox mabd;
		private MaskedBox.MaskedBox dang;
		private Medisoft2009.Usercontrol.MaskedTextBox soluong;
		private Medisoft2009.Usercontrol.MaskedTextBox dongia;
		private Medisoft2009.Usercontrol.MaskedTextBox sotien;
		private Medisoft2009.Usercontrol.MaskedTextBox vat;
		private Medisoft2009.Usercontrol.MaskedTextBox sotienvat;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button butMoi;
		private System.Windows.Forms.Button butSua;
		private System.Windows.Forms.Button butLuu;
		private System.Windows.Forms.Button butThem;
		private System.Windows.Forms.Button butXoa;
		private System.Windows.Forms.Button butBoqua;
		private System.Windows.Forms.Button butHuy;
		private System.Windows.Forms.Button butIn;
		private System.Windows.Forms.Button butKetthuc;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox chuathue;
		private System.Windows.Forms.TextBox cothue;
		private System.Windows.Forms.ComboBox cmbSophieu;
		private string s_mmyy,s_ngay,sql,s_loai,s_vat,s_ngaysp,s_ngayhd,s_ngaykiem,s_makho,format_sotien,format_dongia,format_soluong,format_giaban,s_manhom,s_sophieu,user,xxx;
		private int i_nhom,i_userid,i_madv,i_mabd,i_vat,i_nhomcc,i_old,i_songay,manguon_old,makho_old,i_sole_giaban,i_sole_dongia,itable;
		private decimal l_id;
		private decimal d_soluong,d_dongia,d_sotien,d_sotienvat,d_chuathue,d_cothue,d_giaban,d_cuocvc,d_chaythu,d_tyle;
		private bool bKhoaso,bGiaban,bNew,bAdmin,bQuidoi,bGiaban_nguon,bNhom_nx,bKinhphi,bBienban,bNguoigiao,bDinhkhoan;
        private LibTTB.AccessData ttb;
		private Doisototext doiso=new Doisototext();
		private DataTable dtdmbd=new DataTable();
		private DataTable dtdmnx=new DataTable();
		private DataTable dtll=new DataTable();
		private DataTable dtct=new DataTable();
		private DataTable dtold=new DataTable();
		private DataTable dtnguon=new DataTable();
		private DataSet dsxoa=new DataSet();
		private System.Windows.Forms.Label ldvt;
		private DataRow r;
		private System.Windows.Forms.TextBox stt;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label24;
		private MaskedBox.MaskedBox handung;
		private Medisoft2009.Usercontrol.MaskedTextBox sophieu;
		private Medisoft2009.Usercontrol.MaskedTextBox sohd;
		private Medisoft2009.Usercontrol.MaskedTextBox bbkiem;
		private Medisoft2009.Usercontrol.MaskedTextBox nguoigiao;
		private Medisoft2009.Usercontrol.MaskedTextBox no;
		private Medisoft2009.Usercontrol.MaskedTextBox co;
		private MaskedBox.MaskedBox tenhang;
		private MaskedBox.MaskedBox tennuoc;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.TextBox find;
		private Medisoft2009.Usercontrol.MaskedTextBox losx;
		private System.Windows.Forms.CheckBox chkIn;
		private System.Windows.Forms.Label label32;
		private Medisoft2009.Usercontrol.MaskedTextBox sothe;
		private Medisoft2009.Usercontrol.MaskedTextBox cuocvc;
		private Medisoft2009.Usercontrol.MaskedTextBox chaythu;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		private Medisoft2009.Usercontrol.MaskedTextBox tyle;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.ComboBox nguongoc;
		private System.Windows.Forms.ComboBox tinhtrang;
		private System.Windows.Forms.NumericUpDown baohanh;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.ComboBox lydo;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Button butKemtheo;
		private System.Windows.Forms.NumericUpDown namsx;
		private System.Windows.Forms.Label label37;
		private Medisoft2009.Usercontrol.MaskedTextBox tailieu;
		private System.Windows.Forms.ComboBox chonin;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmNhap(AccessData acc,string loai,string mmyy,string ngay,int nhom,int userid,string kho,string title,bool ban,bool admin,string _manhom)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			ttb=acc;
			i_nhom=nhom;s_manhom=_manhom;
			s_makho=kho;i_userid=userid;
			s_mmyy=mmyy;s_ngay=ngay;
			s_loai=loai;bGiaban=ban;
			bAdmin=admin;this.Text=title;
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ngaysp = new MaskedBox.MaskedBox();
            this.ngayhd = new MaskedBox.MaskedBox();
            this.ngaykiem = new MaskedBox.MaskedBox();
            this.madv = new System.Windows.Forms.TextBox();
            this.tendv = new System.Windows.Forms.TextBox();
            this.manguon = new System.Windows.Forms.ComboBox();
            this.makho = new System.Windows.Forms.ComboBox();
            this.listNX = new Medisoft2009.Usercontrol.List();
            this.listDMBD = new Medisoft2009.Usercontrol.List();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.label13 = new System.Windows.Forms.Label();
            this.lTen = new System.Windows.Forms.Label();
            this.ldvt = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tenbd = new System.Windows.Forms.TextBox();
            this.mabd = new System.Windows.Forms.TextBox();
            this.dang = new MaskedBox.MaskedBox();
            this.soluong = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.dongia = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.sotien = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.vat = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.sotienvat = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.butMoi = new System.Windows.Forms.Button();
            this.butSua = new System.Windows.Forms.Button();
            this.butLuu = new System.Windows.Forms.Button();
            this.butThem = new System.Windows.Forms.Button();
            this.butXoa = new System.Windows.Forms.Button();
            this.butBoqua = new System.Windows.Forms.Button();
            this.butHuy = new System.Windows.Forms.Button();
            this.butIn = new System.Windows.Forms.Button();
            this.butKetthuc = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.chuathue = new System.Windows.Forms.TextBox();
            this.cothue = new System.Windows.Forms.TextBox();
            this.cmbSophieu = new System.Windows.Forms.ComboBox();
            this.stt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.handung = new MaskedBox.MaskedBox();
            this.sophieu = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.sohd = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.bbkiem = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.nguoigiao = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.no = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.co = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.tenhang = new MaskedBox.MaskedBox();
            this.tennuoc = new MaskedBox.MaskedBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.find = new System.Windows.Forms.TextBox();
            this.losx = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.chkIn = new System.Windows.Forms.CheckBox();
            this.label32 = new System.Windows.Forms.Label();
            this.sothe = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.cuocvc = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.chaythu = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.tyle = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.nguongoc = new System.Windows.Forms.ComboBox();
            this.tinhtrang = new System.Windows.Forms.ComboBox();
            this.baohanh = new System.Windows.Forms.NumericUpDown();
            this.label34 = new System.Windows.Forms.Label();
            this.lydo = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.butKemtheo = new System.Windows.Forms.Button();
            this.namsx = new System.Windows.Forms.NumericUpDown();
            this.label37 = new System.Windows.Forms.Label();
            this.tailieu = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.chonin = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baohanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namsx)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(22, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 37;
            this.label1.Text = "Số phiếu :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(154, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 38;
            this.label2.Text = "Ngày nhập:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(275, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "Hóa đơn :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(420, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 40;
            this.label4.Text = "Ngày HĐ:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(-29, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 23);
            this.label5.TabIndex = 43;
            this.label5.Text = "Nhà cung cấp :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(409, 473);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 23);
            this.label6.TabIndex = 41;
            this.label6.Text = "BB kiểm số :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(556, 473);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 23);
            this.label7.TabIndex = 42;
            this.label7.Text = "Ngày :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Location = new System.Drawing.Point(542, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 23);
            this.label8.TabIndex = 44;
            this.label8.Text = "Người giao :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(165, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 23);
            this.label9.TabIndex = 45;
            this.label9.Text = "Nguồn :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(284, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 23);
            this.label10.TabIndex = 46;
            this.label10.Text = "Kho :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(573, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 23);
            this.label11.TabIndex = 47;
            this.label11.Text = "Nợ :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(725, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 23);
            this.label12.TabIndex = 48;
            this.label12.Text = "Có :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ngaysp
            // 
            this.ngaysp.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ngaysp.Enabled = false;
            this.ngaysp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaysp.Location = new System.Drawing.Point(213, 6);
            this.ngaysp.Mask = "##/##/####";
            this.ngaysp.MaxLength = 10;
            this.ngaysp.Name = "ngaysp";
            this.ngaysp.Size = new System.Drawing.Size(64, 21);
            this.ngaysp.TabIndex = 1;
            this.ngaysp.Text = "  /  /    ";
            this.ngaysp.Validated += new System.EventHandler(this.ngaysp_Validated);
            // 
            // ngayhd
            // 
            this.ngayhd.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ngayhd.Enabled = false;
            this.ngayhd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayhd.Location = new System.Drawing.Point(473, 6);
            this.ngayhd.Mask = "##/##/####";
            this.ngayhd.MaxLength = 10;
            this.ngayhd.Name = "ngayhd";
            this.ngayhd.Size = new System.Drawing.Size(64, 21);
            this.ngayhd.TabIndex = 3;
            this.ngayhd.Text = "  /  /    ";
            this.ngayhd.Validated += new System.EventHandler(this.ngayhd_Validated);
            // 
            // ngaykiem
            // 
            this.ngaykiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ngaykiem.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ngaykiem.Enabled = false;
            this.ngaykiem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaykiem.Location = new System.Drawing.Point(595, 473);
            this.ngaykiem.Mask = "##/##/####";
            this.ngaykiem.Name = "ngaykiem";
            this.ngaykiem.ReadOnly = true;
            this.ngaykiem.Size = new System.Drawing.Size(102, 21);
            this.ngaykiem.TabIndex = 6;
            this.ngaykiem.Text = "  /  /    ";
            this.ngaykiem.Visible = false;
            this.ngaykiem.Validated += new System.EventHandler(this.ngaykiem_Validated);
            // 
            // madv
            // 
            this.madv.BackColor = System.Drawing.SystemColors.HighlightText;
            this.madv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.madv.Enabled = false;
            this.madv.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.madv.Location = new System.Drawing.Point(72, 29);
            this.madv.Name = "madv";
            this.madv.Size = new System.Drawing.Size(64, 21);
            this.madv.TabIndex = 5;
            this.madv.Validated += new System.EventHandler(this.madv_Validated);
            this.madv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.madv_KeyDown);
            // 
            // tendv
            // 
            this.tendv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tendv.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tendv.Enabled = false;
            this.tendv.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tendv.Location = new System.Drawing.Point(138, 29);
            this.tendv.Name = "tendv";
            this.tendv.Size = new System.Drawing.Size(399, 21);
            this.tendv.TabIndex = 6;
            this.tendv.TextChanged += new System.EventHandler(this.tendv_TextChanged);
            this.tendv.Validated += new System.EventHandler(this.tendv_Validated);
            this.tendv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tendv_KeyDown);
            // 
            // manguon
            // 
            this.manguon.BackColor = System.Drawing.SystemColors.HighlightText;
            this.manguon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manguon.Enabled = false;
            this.manguon.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manguon.Location = new System.Drawing.Point(213, 52);
            this.manguon.Name = "manguon";
            this.manguon.Size = new System.Drawing.Size(83, 21);
            this.manguon.TabIndex = 10;
            this.manguon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.manguon_KeyDown);
            // 
            // makho
            // 
            this.makho.BackColor = System.Drawing.SystemColors.HighlightText;
            this.makho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.makho.Enabled = false;
            this.makho.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makho.Location = new System.Drawing.Point(329, 52);
            this.makho.Name = "makho";
            this.makho.Size = new System.Drawing.Size(208, 21);
            this.makho.TabIndex = 11;
            this.makho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.makho_KeyDown);
            // 
            // listNX
            // 
            this.listNX.BackColor = System.Drawing.SystemColors.Info;
            this.listNX.ColumnCount = 0;
            this.listNX.Location = new System.Drawing.Point(504, 552);
            this.listNX.MatchBufferTimeOut = 1000;
            this.listNX.MatchEntryStyle = Medisoft2009.Usercontrol.MatchEntryStyle.FirstLetterInsensitive;
            this.listNX.Name = "listNX";
            this.listNX.Size = new System.Drawing.Size(75, 17);
            this.listNX.TabIndex = 25;
            this.listNX.TextIndex = -1;
            this.listNX.TextMember = null;
            this.listNX.ValueIndex = -1;
            this.listNX.Visible = false;
            // 
            // listDMBD
            // 
            this.listDMBD.BackColor = System.Drawing.SystemColors.Info;
            this.listDMBD.ColumnCount = 0;
            this.listDMBD.Location = new System.Drawing.Point(584, 552);
            this.listDMBD.MatchBufferTimeOut = 1000;
            this.listDMBD.MatchEntryStyle = Medisoft2009.Usercontrol.MatchEntryStyle.FirstLetterInsensitive;
            this.listDMBD.Name = "listDMBD";
            this.listDMBD.Size = new System.Drawing.Size(75, 17);
            this.listDMBD.TabIndex = 26;
            this.listDMBD.TextIndex = -1;
            this.listDMBD.TextMember = null;
            this.listDMBD.ValueIndex = -1;
            this.listDMBD.Visible = false;
            this.listDMBD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listDMBD_KeyDown);
            // 
            // dataGrid1
            // 
            this.dataGrid1.AlternatingBackColor = System.Drawing.Color.Lavender;
            this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid1.CaptionBackColor = System.Drawing.SystemColors.Control;
            this.dataGrid1.CaptionFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid1.CaptionForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid1.DataMember = "";
            this.dataGrid1.FlatMode = true;
            this.dataGrid1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid1.GridLineColor = System.Drawing.Color.Gainsboro;
            this.dataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dataGrid1.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dataGrid1.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid1.LinkColor = System.Drawing.Color.Teal;
            this.dataGrid1.Location = new System.Drawing.Point(8, 59);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro;
            this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.RowHeaderWidth = 10;
            this.dataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue;
            this.dataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid1.Size = new System.Drawing.Size(811, 272);
            this.dataGrid1.TabIndex = 100;
            this.dataGrid1.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.Location = new System.Drawing.Point(32, 358);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 23);
            this.label13.TabIndex = 28;
            this.label13.Text = "Mã :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lTen
            // 
            this.lTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lTen.Location = new System.Drawing.Point(158, 358);
            this.lTen.Name = "lTen";
            this.lTen.Size = new System.Drawing.Size(43, 23);
            this.lTen.TabIndex = 29;
            this.lTen.Text = "Tên :";
            this.lTen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ldvt
            // 
            this.ldvt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ldvt.Location = new System.Drawing.Point(467, 358);
            this.ldvt.Name = "ldvt";
            this.ldvt.Size = new System.Drawing.Size(42, 23);
            this.ldvt.TabIndex = 30;
            this.ldvt.Text = "ĐVT :";
            this.ldvt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.Location = new System.Drawing.Point(553, 358);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 23);
            this.label16.TabIndex = 31;
            this.label16.Text = "Số lượng :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.Location = new System.Drawing.Point(675, 358);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 23);
            this.label17.TabIndex = 32;
            this.label17.Text = "Đơn giá :";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.Location = new System.Drawing.Point(16, 381);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 23);
            this.label18.TabIndex = 33;
            this.label18.Text = "Số tiền :";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.Location = new System.Drawing.Point(162, 381);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 23);
            this.label19.TabIndex = 34;
            this.label19.Text = "Thuế :";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label20.Location = new System.Drawing.Point(429, 381);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 23);
            this.label20.TabIndex = 35;
            this.label20.Text = "Nguyên giá :";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tenbd
            // 
            this.tenbd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tenbd.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tenbd.Enabled = false;
            this.tenbd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenbd.Location = new System.Drawing.Point(198, 359);
            this.tenbd.Name = "tenbd";
            this.tenbd.Size = new System.Drawing.Size(245, 21);
            this.tenbd.TabIndex = 13;
            this.tenbd.TextChanged += new System.EventHandler(this.tenbd_TextChanged);
            this.tenbd.Validated += new System.EventHandler(this.tenbd_Validated);
            this.tenbd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tenbd_KeyDown);
            // 
            // mabd
            // 
            this.mabd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mabd.BackColor = System.Drawing.SystemColors.HighlightText;
            this.mabd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mabd.Enabled = false;
            this.mabd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mabd.Location = new System.Drawing.Point(64, 359);
            this.mabd.Name = "mabd";
            this.mabd.Size = new System.Drawing.Size(57, 21);
            this.mabd.TabIndex = 12;
            this.mabd.TextChanged += new System.EventHandler(this.mabd_TextChanged);
            this.mabd.Validated += new System.EventHandler(this.mabd_Validated);
            this.mabd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tenbd_KeyDown);
            // 
            // dang
            // 
            this.dang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dang.BackColor = System.Drawing.SystemColors.HighlightText;
            this.dang.Enabled = false;
            this.dang.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dang.Location = new System.Drawing.Point(507, 359);
            this.dang.Mask = "";
            this.dang.MaxLength = 10;
            this.dang.Name = "dang";
            this.dang.Size = new System.Drawing.Size(57, 21);
            this.dang.TabIndex = 14;
            // 
            // soluong
            // 
            this.soluong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.soluong.BackColor = System.Drawing.SystemColors.HighlightText;
            this.soluong.Enabled = false;
            this.soluong.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soluong.Location = new System.Drawing.Point(618, 359);
            this.soluong.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.Decimal;
            this.soluong.Name = "soluong";
            this.soluong.Size = new System.Drawing.Size(57, 21);
            this.soluong.TabIndex = 15;
            this.soluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.soluong.Validated += new System.EventHandler(this.soluong_Validated);
            // 
            // dongia
            // 
            this.dongia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dongia.BackColor = System.Drawing.SystemColors.HighlightText;
            this.dongia.Enabled = false;
            this.dongia.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dongia.Location = new System.Drawing.Point(731, 359);
            this.dongia.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.Decimal;
            this.dongia.Name = "dongia";
            this.dongia.Size = new System.Drawing.Size(88, 21);
            this.dongia.TabIndex = 16;
            this.dongia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dongia.Validated += new System.EventHandler(this.dongia_Validated);
            // 
            // sotien
            // 
            this.sotien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sotien.BackColor = System.Drawing.SystemColors.HighlightText;
            this.sotien.Enabled = false;
            this.sotien.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sotien.Location = new System.Drawing.Point(64, 382);
            this.sotien.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.Decimal;
            this.sotien.Name = "sotien";
            this.sotien.Size = new System.Drawing.Size(82, 21);
            this.sotien.TabIndex = 17;
            this.sotien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sotien.Validated += new System.EventHandler(this.sotien_Validated);
            // 
            // vat
            // 
            this.vat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.vat.BackColor = System.Drawing.SystemColors.HighlightText;
            this.vat.Enabled = false;
            this.vat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vat.Location = new System.Drawing.Point(198, 382);
            this.vat.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.Digit;
            this.vat.MaxLength = 3;
            this.vat.Name = "vat";
            this.vat.Size = new System.Drawing.Size(26, 21);
            this.vat.TabIndex = 18;
            this.vat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vat.Validated += new System.EventHandler(this.vat_Validated);
            // 
            // sotienvat
            // 
            this.sotienvat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sotienvat.BackColor = System.Drawing.SystemColors.HighlightText;
            this.sotienvat.Enabled = false;
            this.sotienvat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sotienvat.Location = new System.Drawing.Point(507, 382);
            this.sotienvat.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.Decimal;
            this.sotienvat.Name = "sotienvat";
            this.sotienvat.Size = new System.Drawing.Size(168, 21);
            this.sotienvat.TabIndex = 20;
            this.sotienvat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.Location = new System.Drawing.Point(229, 382);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(8, 21);
            this.label14.TabIndex = 45;
            this.label14.Text = "%";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butMoi
            // 
            this.butMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butMoi.Image = ((System.Drawing.Image)(resources.GetObject("butMoi.Image")));
            this.butMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butMoi.Location = new System.Drawing.Point(25, 454);
            this.butMoi.Name = "butMoi";
            this.butMoi.Size = new System.Drawing.Size(60, 25);
            this.butMoi.TabIndex = 34;
            this.butMoi.Text = "    &Mới";
            this.butMoi.Click += new System.EventHandler(this.butMoi_Click);
            // 
            // butSua
            // 
            this.butSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butSua.Image = ((System.Drawing.Image)(resources.GetObject("butSua.Image")));
            this.butSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butSua.Location = new System.Drawing.Point(86, 454);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(60, 25);
            this.butSua.TabIndex = 35;
            this.butSua.Text = "    &Sửa";
            this.butSua.Click += new System.EventHandler(this.butSua_Click);
            // 
            // butLuu
            // 
            this.butLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butLuu.Enabled = false;
            this.butLuu.Image = ((System.Drawing.Image)(resources.GetObject("butLuu.Image")));
            this.butLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butLuu.Location = new System.Drawing.Point(147, 454);
            this.butLuu.Name = "butLuu";
            this.butLuu.Size = new System.Drawing.Size(60, 25);
            this.butLuu.TabIndex = 32;
            this.butLuu.Text = "     &Lưu";
            this.butLuu.Click += new System.EventHandler(this.butLuu_Click);
            // 
            // butThem
            // 
            this.butThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butThem.Enabled = false;
            this.butThem.Image = ((System.Drawing.Image)(resources.GetObject("butThem.Image")));
            this.butThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butThem.Location = new System.Drawing.Point(208, 454);
            this.butThem.Name = "butThem";
            this.butThem.Size = new System.Drawing.Size(60, 25);
            this.butThem.TabIndex = 30;
            this.butThem.Text = "     &Thêm";
            this.butThem.Click += new System.EventHandler(this.butThem_Click);
            // 
            // butXoa
            // 
            this.butXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butXoa.Enabled = false;
            this.butXoa.Image = ((System.Drawing.Image)(resources.GetObject("butXoa.Image")));
            this.butXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butXoa.Location = new System.Drawing.Point(269, 454);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(60, 25);
            this.butXoa.TabIndex = 31;
            this.butXoa.Text = "    &Xóa";
            this.butXoa.Click += new System.EventHandler(this.butXoa_Click);
            // 
            // butBoqua
            // 
            this.butBoqua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butBoqua.Enabled = false;
            this.butBoqua.Image = ((System.Drawing.Image)(resources.GetObject("butBoqua.Image")));
            this.butBoqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butBoqua.Location = new System.Drawing.Point(330, 454);
            this.butBoqua.Name = "butBoqua";
            this.butBoqua.Size = new System.Drawing.Size(70, 25);
            this.butBoqua.TabIndex = 33;
            this.butBoqua.Text = "     &Bỏ qua";
            this.butBoqua.Click += new System.EventHandler(this.butBoqua_Click);
            // 
            // butHuy
            // 
            this.butHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butHuy.Image = ((System.Drawing.Image)(resources.GetObject("butHuy.Image")));
            this.butHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butHuy.Location = new System.Drawing.Point(401, 454);
            this.butHuy.Name = "butHuy";
            this.butHuy.Size = new System.Drawing.Size(60, 25);
            this.butHuy.TabIndex = 36;
            this.butHuy.Text = "    &Hủy";
            this.butHuy.Click += new System.EventHandler(this.butHuy_Click);
            // 
            // butIn
            // 
            this.butIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butIn.Image = ((System.Drawing.Image)(resources.GetObject("butIn.Image")));
            this.butIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butIn.Location = new System.Drawing.Point(595, 454);
            this.butIn.Name = "butIn";
            this.butIn.Size = new System.Drawing.Size(60, 25);
            this.butIn.TabIndex = 37;
            this.butIn.Text = "   &In";
            this.butIn.Click += new System.EventHandler(this.butIn_Click);
            // 
            // butKetthuc
            // 
            this.butKetthuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butKetthuc.Image = ((System.Drawing.Image)(resources.GetObject("butKetthuc.Image")));
            this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butKetthuc.Location = new System.Drawing.Point(741, 454);
            this.butKetthuc.Name = "butKetthuc";
            this.butKetthuc.Size = new System.Drawing.Size(70, 25);
            this.butKetthuc.TabIndex = 39;
            this.butKetthuc.Text = "     &Kết thúc";
            this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label21.Location = new System.Drawing.Point(195, 332);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(120, 23);
            this.label21.TabIndex = 55;
            this.label21.Text = "Tổng cộng chưa thuế :";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label22.Location = new System.Drawing.Point(499, 332);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(120, 23);
            this.label22.TabIndex = 56;
            this.label22.Text = "Tổng cộng có thuế :";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chuathue
            // 
            this.chuathue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chuathue.BackColor = System.Drawing.SystemColors.HighlightText;
            this.chuathue.Enabled = false;
            this.chuathue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chuathue.Location = new System.Drawing.Point(313, 335);
            this.chuathue.Name = "chuathue";
            this.chuathue.Size = new System.Drawing.Size(130, 21);
            this.chuathue.TabIndex = 57;
            this.chuathue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cothue
            // 
            this.cothue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cothue.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cothue.Enabled = false;
            this.cothue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cothue.Location = new System.Drawing.Point(618, 335);
            this.cothue.Name = "cothue";
            this.cothue.Size = new System.Drawing.Size(201, 21);
            this.cothue.TabIndex = 58;
            this.cothue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbSophieu
            // 
            this.cmbSophieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSophieu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSophieu.Location = new System.Drawing.Point(72, 6);
            this.cmbSophieu.Name = "cmbSophieu";
            this.cmbSophieu.Size = new System.Drawing.Size(79, 21);
            this.cmbSophieu.TabIndex = 0;
            this.cmbSophieu.SelectedIndexChanged += new System.EventHandler(this.cmbSophieu_SelectedIndexChanged);
            this.cmbSophieu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSophieu_KeyDown);
            // 
            // stt
            // 
            this.stt.Enabled = false;
            this.stt.Location = new System.Drawing.Point(-4, 337);
            this.stt.Name = "stt";
            this.stt.Size = new System.Drawing.Size(40, 20);
            this.stt.TabIndex = 60;
            this.stt.Visible = false;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.Location = new System.Drawing.Point(670, 381);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 23);
            this.label15.TabIndex = 61;
            this.label15.Text = "Hạn SD :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label24.Location = new System.Drawing.Point(8, 404);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(56, 23);
            this.label24.TabIndex = 62;
            this.label24.Text = "Số hiệu :";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // handung
            // 
            this.handung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.handung.BackColor = System.Drawing.SystemColors.HighlightText;
            this.handung.Enabled = false;
            this.handung.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handung.Location = new System.Drawing.Point(731, 382);
            this.handung.Mask = "####";
            this.handung.Name = "handung";
            this.handung.Size = new System.Drawing.Size(88, 21);
            this.handung.TabIndex = 21;
            this.handung.Text = "    ";
            // 
            // sophieu
            // 
            this.sophieu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.sophieu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.sophieu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sophieu.Location = new System.Drawing.Point(72, 6);
            this.sophieu.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.sophieu.Name = "sophieu";
            this.sophieu.Size = new System.Drawing.Size(79, 21);
            this.sophieu.TabIndex = 1;
            this.sophieu.Validated += new System.EventHandler(this.sophieu_Validated);
            // 
            // sohd
            // 
            this.sohd.BackColor = System.Drawing.SystemColors.HighlightText;
            this.sohd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.sohd.Enabled = false;
            this.sohd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sohd.Location = new System.Drawing.Point(329, 6);
            this.sohd.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.sohd.MaxLength = 50;
            this.sohd.Name = "sohd";
            this.sohd.Size = new System.Drawing.Size(93, 21);
            this.sohd.TabIndex = 2;
            this.sohd.Validated += new System.EventHandler(this.sohd_Validated);
            // 
            // bbkiem
            // 
            this.bbkiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bbkiem.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bbkiem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.bbkiem.Enabled = false;
            this.bbkiem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbkiem.Location = new System.Drawing.Point(481, 473);
            this.bbkiem.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.bbkiem.MaxLength = 15;
            this.bbkiem.Name = "bbkiem";
            this.bbkiem.ReadOnly = true;
            this.bbkiem.Size = new System.Drawing.Size(112, 21);
            this.bbkiem.TabIndex = 5;
            this.bbkiem.Visible = false;
            // 
            // nguoigiao
            // 
            this.nguoigiao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nguoigiao.BackColor = System.Drawing.SystemColors.HighlightText;
            this.nguoigiao.Enabled = false;
            this.nguoigiao.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nguoigiao.Location = new System.Drawing.Point(603, 6);
            this.nguoigiao.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.nguoigiao.Name = "nguoigiao";
            this.nguoigiao.Size = new System.Drawing.Size(216, 21);
            this.nguoigiao.TabIndex = 4;
            this.nguoigiao.Validated += new System.EventHandler(this.nguoigiao_Validated);
            // 
            // no
            // 
            this.no.BackColor = System.Drawing.SystemColors.HighlightText;
            this.no.Enabled = false;
            this.no.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no.Location = new System.Drawing.Point(603, 29);
            this.no.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(64, 21);
            this.no.TabIndex = 7;
            // 
            // co
            // 
            this.co.BackColor = System.Drawing.SystemColors.HighlightText;
            this.co.Enabled = false;
            this.co.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.co.Location = new System.Drawing.Point(759, 29);
            this.co.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.co.MaxLength = 10;
            this.co.Name = "co";
            this.co.Size = new System.Drawing.Size(60, 21);
            this.co.TabIndex = 8;
            // 
            // tenhang
            // 
            this.tenhang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tenhang.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tenhang.Enabled = false;
            this.tenhang.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenhang.Location = new System.Drawing.Point(198, 427);
            this.tenhang.Mask = "";
            this.tenhang.Name = "tenhang";
            this.tenhang.Size = new System.Drawing.Size(245, 21);
            this.tenhang.TabIndex = 28;
            // 
            // tennuoc
            // 
            this.tennuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tennuoc.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tennuoc.Enabled = false;
            this.tennuoc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tennuoc.Location = new System.Drawing.Point(507, 427);
            this.tennuoc.Mask = "";
            this.tennuoc.Name = "tennuoc";
            this.tennuoc.Size = new System.Drawing.Size(312, 21);
            this.tennuoc.TabIndex = 29;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label23.Location = new System.Drawing.Point(161, 426);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(40, 23);
            this.label23.TabIndex = 69;
            this.label23.Text = "Hãng :";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.Location = new System.Drawing.Point(461, 426);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(48, 23);
            this.label26.TabIndex = 70;
            this.label26.Text = "Nước :";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // find
            // 
            this.find.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.find.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find.Location = new System.Drawing.Point(603, 52);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(216, 21);
            this.find.TabIndex = 104;
            this.find.Text = "Tìm kiếm";
            this.find.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.find.TextChanged += new System.EventHandler(this.find_TextChanged);
            this.find.Enter += new System.EventHandler(this.find_Enter);
            // 
            // losx
            // 
            this.losx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.losx.BackColor = System.Drawing.SystemColors.HighlightText;
            this.losx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.losx.Enabled = false;
            this.losx.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.losx.Location = new System.Drawing.Point(64, 405);
            this.losx.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.losx.MaxLength = 20;
            this.losx.Name = "losx";
            this.losx.Size = new System.Drawing.Size(82, 21);
            this.losx.TabIndex = 22;
            // 
            // chkIn
            // 
            this.chkIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkIn.Location = new System.Drawing.Point(66, 337);
            this.chkIn.Name = "chkIn";
            this.chkIn.Size = new System.Drawing.Size(112, 16);
            this.chkIn.TabIndex = 105;
            this.chkIn.Text = "Xem trước khi in";
            // 
            // label32
            // 
            this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label32.Location = new System.Drawing.Point(552, 473);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(56, 23);
            this.label32.TabIndex = 109;
            this.label32.Text = "Số QĐ :";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label32.Visible = false;
            // 
            // sothe
            // 
            this.sothe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sothe.BackColor = System.Drawing.SystemColors.HighlightText;
            this.sothe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.sothe.Enabled = false;
            this.sothe.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sothe.Location = new System.Drawing.Point(603, 473);
            this.sothe.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.sothe.MaxLength = 20;
            this.sothe.Name = "sothe";
            this.sothe.ReadOnly = true;
            this.sothe.Size = new System.Drawing.Size(115, 21);
            this.sothe.TabIndex = 27;
            this.sothe.Visible = false;
            // 
            // cuocvc
            // 
            this.cuocvc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cuocvc.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cuocvc.Enabled = false;
            this.cuocvc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuocvc.Location = new System.Drawing.Point(336, 382);
            this.cuocvc.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.Decimal;
            this.cuocvc.Name = "cuocvc";
            this.cuocvc.Size = new System.Drawing.Size(107, 21);
            this.cuocvc.TabIndex = 19;
            this.cuocvc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cuocvc.Validated += new System.EventHandler(this.cuocvc_Validated);
            // 
            // chaythu
            // 
            this.chaythu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chaythu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.chaythu.Enabled = false;
            this.chaythu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chaythu.Location = new System.Drawing.Point(462, 473);
            this.chaythu.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.Decimal;
            this.chaythu.Name = "chaythu";
            this.chaythu.ReadOnly = true;
            this.chaythu.Size = new System.Drawing.Size(88, 21);
            this.chaythu.TabIndex = 24;
            this.chaythu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chaythu.Visible = false;
            this.chaythu.Validated += new System.EventHandler(this.chaythu_Validated);
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label25.Location = new System.Drawing.Point(236, 381);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(104, 23);
            this.label25.TabIndex = 113;
            this.label25.Text = "Cước vận chuyển :";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label27.Location = new System.Drawing.Point(406, 474);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(56, 23);
            this.label27.TabIndex = 114;
            this.label27.Text = "Chạy thử :";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label27.Visible = false;
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label28.Location = new System.Drawing.Point(130, 404);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(72, 23);
            this.label28.TabIndex = 115;
            this.label28.Text = "Khấu hao :";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tyle
            // 
            this.tyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tyle.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tyle.Enabled = false;
            this.tyle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tyle.Location = new System.Drawing.Point(198, 405);
            this.tyle.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.tyle.MaxLength = 6;
            this.tyle.Name = "tyle";
            this.tyle.Size = new System.Drawing.Size(40, 21);
            this.tyle.TabIndex = 23;
            this.tyle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tyle.Validated += new System.EventHandler(this.tyle_Validated);
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.Location = new System.Drawing.Point(240, 404);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(8, 23);
            this.label29.TabIndex = 117;
            this.label29.Text = "%";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label30.Location = new System.Drawing.Point(445, 404);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(64, 23);
            this.label30.TabIndex = 118;
            this.label30.Text = "Bảo hành :";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label31.Location = new System.Drawing.Point(-8, 426);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(72, 23);
            this.label31.TabIndex = 119;
            this.label31.Text = "Nguồn gốc :";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label33
            // 
            this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label33.Location = new System.Drawing.Point(666, 404);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(64, 23);
            this.label33.TabIndex = 120;
            this.label33.Text = "Tình trạng :";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nguongoc
            // 
            this.nguongoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nguongoc.BackColor = System.Drawing.SystemColors.HighlightText;
            this.nguongoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nguongoc.Enabled = false;
            this.nguongoc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nguongoc.Location = new System.Drawing.Point(64, 427);
            this.nguongoc.Name = "nguongoc";
            this.nguongoc.Size = new System.Drawing.Size(82, 21);
            this.nguongoc.TabIndex = 27;
            this.nguongoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nguongoc_KeyDown);
            // 
            // tinhtrang
            // 
            this.tinhtrang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tinhtrang.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tinhtrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tinhtrang.Enabled = false;
            this.tinhtrang.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinhtrang.Location = new System.Drawing.Point(731, 405);
            this.tinhtrang.Name = "tinhtrang";
            this.tinhtrang.Size = new System.Drawing.Size(88, 21);
            this.tinhtrang.TabIndex = 26;
            this.tinhtrang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tinhtrang_KeyDown);
            // 
            // baohanh
            // 
            this.baohanh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.baohanh.BackColor = System.Drawing.SystemColors.HighlightText;
            this.baohanh.Enabled = false;
            this.baohanh.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baohanh.Location = new System.Drawing.Point(507, 405);
            this.baohanh.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.baohanh.Name = "baohanh";
            this.baohanh.Size = new System.Drawing.Size(56, 21);
            this.baohanh.TabIndex = 25;
            this.baohanh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.baohanh_KeyDown);
            // 
            // label34
            // 
            this.label34.Location = new System.Drawing.Point(30, 51);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(48, 23);
            this.label34.TabIndex = 124;
            this.label34.Text = "Nhập :";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lydo
            // 
            this.lydo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lydo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lydo.Enabled = false;
            this.lydo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lydo.Location = new System.Drawing.Point(72, 52);
            this.lydo.Name = "lydo";
            this.lydo.Size = new System.Drawing.Size(78, 21);
            this.lydo.TabIndex = 9;
            this.lydo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lydo_KeyDown);
            // 
            // label35
            // 
            this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label35.Location = new System.Drawing.Point(568, 404);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(40, 23);
            this.label35.TabIndex = 125;
            this.label35.Text = "tháng";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label36
            // 
            this.label36.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label36.Location = new System.Drawing.Point(66, 476);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(48, 23);
            this.label36.TabIndex = 126;
            this.label36.Text = "Tài liệu :";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label36.Visible = false;
            // 
            // butKemtheo
            // 
            this.butKemtheo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butKemtheo.Image = ((System.Drawing.Image)(resources.GetObject("butKemtheo.Image")));
            this.butKemtheo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butKemtheo.Location = new System.Drawing.Point(656, 454);
            this.butKemtheo.Name = "butKemtheo";
            this.butKemtheo.Size = new System.Drawing.Size(84, 25);
            this.butKemtheo.TabIndex = 38;
            this.butKemtheo.Text = "   Kèm theo";
            this.butKemtheo.Click += new System.EventHandler(this.butKemtheo_Click);
            // 
            // namsx
            // 
            this.namsx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.namsx.BackColor = System.Drawing.SystemColors.HighlightText;
            this.namsx.Enabled = false;
            this.namsx.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namsx.Location = new System.Drawing.Point(336, 405);
            this.namsx.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.namsx.Name = "namsx";
            this.namsx.Size = new System.Drawing.Size(107, 21);
            this.namsx.TabIndex = 24;
            this.namsx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.namsx_KeyDown);
            // 
            // label37
            // 
            this.label37.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label37.Location = new System.Drawing.Point(280, 404);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(56, 23);
            this.label37.TabIndex = 129;
            this.label37.Text = "Năm SX :";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tailieu
            // 
            this.tailieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tailieu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tailieu.Enabled = false;
            this.tailieu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tailieu.Location = new System.Drawing.Point(114, 476);
            this.tailieu.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.tailieu.Name = "tailieu";
            this.tailieu.ReadOnly = true;
            this.tailieu.Size = new System.Drawing.Size(264, 21);
            this.tailieu.TabIndex = 33;
            this.tailieu.Visible = false;
            // 
            // chonin
            // 
            this.chonin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chonin.BackColor = System.Drawing.SystemColors.Info;
            this.chonin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chonin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chonin.Items.AddRange(new object[] {
            "Phiếu nhập",
            "Biên bản giao nhận",
            "Biên bản bàn giao",
            "Kiểm nhập",
            "Phiếu đề nghị thanh toán"});
            this.chonin.Location = new System.Drawing.Point(462, 455);
            this.chonin.Name = "chonin";
            this.chonin.Size = new System.Drawing.Size(132, 24);
            this.chonin.TabIndex = 131;
            // 
            // frmNhap
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(827, 489);
            this.Controls.Add(this.losx);
            this.Controls.Add(this.chonin);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.namsx);
            this.Controls.Add(this.butKemtheo);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.baohanh);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.tinhtrang);
            this.Controls.Add(this.nguongoc);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.tyle);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.tenhang);
            this.Controls.Add(this.cuocvc);
            this.Controls.Add(this.handung);
            this.Controls.Add(this.sotienvat);
            this.Controls.Add(this.dongia);
            this.Controls.Add(this.tennuoc);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.chkIn);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.tenbd);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dang);
            this.Controls.Add(this.cothue);
            this.Controls.Add(this.chuathue);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.butKetthuc);
            this.Controls.Add(this.butIn);
            this.Controls.Add(this.butHuy);
            this.Controls.Add(this.butBoqua);
            this.Controls.Add(this.butXoa);
            this.Controls.Add(this.butThem);
            this.Controls.Add(this.butLuu);
            this.Controls.Add(this.butSua);
            this.Controls.Add(this.butMoi);
            this.Controls.Add(this.soluong);
            this.Controls.Add(this.vat);
            this.Controls.Add(this.sotien);
            this.Controls.Add(this.mabd);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ldvt);
            this.Controls.Add(this.lTen);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.stt);
            this.Controls.Add(this.tailieu);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.lydo);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.sothe);
            this.Controls.Add(this.chaythu);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.find);
            this.Controls.Add(this.co);
            this.Controls.Add(this.no);
            this.Controls.Add(this.nguoigiao);
            this.Controls.Add(this.bbkiem);
            this.Controls.Add(this.sohd);
            this.Controls.Add(this.cmbSophieu);
            this.Controls.Add(this.sophieu);
            this.Controls.Add(this.makho);
            this.Controls.Add(this.manguon);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.listDMBD);
            this.Controls.Add(this.listNX);
            this.Controls.Add(this.tendv);
            this.Controls.Add(this.madv);
            this.Controls.Add(this.ngaykiem);
            this.Controls.Add(this.ngayhd);
            this.Controls.Add(this.ngaysp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNhap";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu nhập kho";
            this.Load += new System.EventHandler(this.frmNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baohanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namsx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void frmNhap_Load(object sender, System.EventArgs e)
		{
             if (Screen.PrimaryScreen.WorkingArea.Width > 800) this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            user = ttb.user; xxx = user;// + s_mmyy;
            this.bSoPhieuNhapKhoTangTuDong = ttb.SoPhieuNhapKhoTangTuDong;
			chonin.SelectedIndex=0;
			chkIn.Checked=ttb.bPreview;
			bKinhphi=ttb.bKinhphi(i_nhom);
			format_sotien=ttb.format_sotien(i_nhom);
			format_dongia=ttb.format_dongia(i_nhom);
			format_giaban=ttb.format_giaban(i_nhom);
			format_soluong=ttb.format_soluong(i_nhom);
			bGiaban_nguon=ttb.bGiaban_nguon(i_nhom);
			bNhom_nx=ttb.bNhom_nhapxuat(i_nhom);
			i_sole_giaban=ttb.d_giaban_le(i_nhom);
			i_sole_dongia=ttb.d_dongia_le(i_nhom);
			bBienban=ttb.bBbankiemso;
			bNguoigiao=ttb.bNguoigiao;
			bDinhkhoan=ttb.bDinhkhoan;
			bQuidoi=ttb.bQuidoi(i_nhom);
			bKhoaso=ttb.bKhoaso(i_nhom,s_mmyy);
			i_songay=ttb.Ngaylv_Ngayht;
			manguon.DisplayMember="TEN";
			manguon.ValueMember="ID";
			if (ttb.bQuanlynguon(i_nhom))
				dtnguon=ttb.get_data("select * from "+user+".ttb_dmnguon where nhom="+i_nhom+" order by stt").Tables[0];
			else
                dtnguon = ttb.get_data("select * from " + user + ".ttb_dmnguon where id=0 or nhom=" + i_nhom + " order by stt").Tables[0];
			manguon.DataSource=dtnguon;
			makho.DisplayMember="TEN";
			makho.ValueMember="ID";
            sql = "select * from " + user + ".ttb_dmkho where nhom=" + i_nhom;
			if (s_loai=="M") sql+=" and khott=1";
			if (s_makho!="") sql+=" and id in ("+s_makho.Substring(0,s_makho.Length-1)+")";
			sql+=" order by stt";
			makho.DataSource=ttb.get_data(sql).Tables[0];
			if (makho.Items.Count>0) makho.SelectedIndex=0;
			else makho.SelectedIndex=-1;
            if (makho.Items.Count <= 0)
            {
                MessageBox.Show("Chưa khai báo kho trung tâm!");
                return;
            }
			listDMBD.DisplayMember="TEN";
			listDMBD.ValueMember="MA";

			listNX.DisplayMember="MA";
			listNX.ValueMember="TEN";

			load_dm();

            sql = "select id,sophieu,to_char(ngaysp,'dd/mm/yyyy') as ngaysp,sohd,to_char(ngayhd,'dd/mm/yyyy') as ngayhd,bbkiem,to_char(ngaykiem,'dd/mm/yyyy') as ngaykiem,nguoigiao,madv,makho,manguon,nhomcc,no,co,lydo,chietkhau from ttb_nhapll ";
			sql+="where mmyy='"+s_mmyy+"' and  loai='"+s_loai+"'";
			if (!bAdmin) sql+=" and userid="+i_userid;
			sql+=" and nhom="+i_nhom;
			if (ttb.bPhieunhap_sophieu(i_nhom)) sql+=" order by sophieu";
			else sql+=" order by manguon,id";
			dtll=ttb.get_data(sql).Tables[0];
			cmbSophieu.DisplayMember="SOPHIEU";
			cmbSophieu.ValueMember="ID";
			cmbSophieu.DataSource=dtll;
			if (dtll.Rows.Count>0) l_id=decimal.Parse(cmbSophieu.SelectedValue.ToString());
			else l_id=0;
			load_head();
			AddGridTableStyle();
            dsxoa = new DataSet();
			dsxoa.Tables.Add(dtct.Clone());//.ReadXml("..\\..\\..\\xml\\ttb_nhapct.xml");
		}

		private void load_grid()
		{
            sql = "select a.stt,a.mabd,b.ma,trim(b.ten)||' '||b.hamluong as ten,b.tenhc as tenhc,b.dang,a.handung,a.losx,a.soluong,a.dongia,a.vat,a.sotien,round(a.sotien+a.sotien*a.vat/100,3)+cuocvc+chaythu as sotienvat,a.giaban,a.giamua,c.ten as tenhang,d.ten as tennuoc,a.sl1,a.sl2,a.tyle,a.cuocvc,a.chaythu,a.namsx,a.tailieu,a.baohanh,a.nguongoc,a.tinhtrang,a.sothe,a.giabancu,a.giamuacu,a.giaban2,a.tyle2,a.tyle_ggia,a.st_ggia,round(a.sotien+a.sotien*a.vat/100,3)+cuocvc+chaythu as tongtien,a.id ";
			sql+=" from ttb_nhapct a,"+user+".ttb_dmbd b,"+user+".ttb_dmhang c,"+user+".ttb_dmnuoc d where  a.mabd=b.id and b.mahang=c.id and b.manuoc=d.id and a.id="+l_id+" order by a.stt";
			dtct=ttb.get_data(sql).Tables[0];
			dataGrid1.DataSource=dtct;
			tongcong();
		}


		private void AddGridTableStyle()
		{
			DataGridTableStyle ts =new DataGridTableStyle();
			ts.MappingName = dtct.TableName;
			ts.AlternatingBackColor = Color.Beige;
			ts.BackColor = Color.GhostWhite;
			ts.ForeColor = Color.MidnightBlue;
			ts.GridLineColor = Color.RoyalBlue;
			ts.HeaderBackColor = Color.MidnightBlue;
			ts.HeaderForeColor = Color.Lavender;
			ts.SelectionBackColor = Color.Teal;
			ts.SelectionForeColor = Color.PaleGreen;
			ts.ReadOnly=false;
			ts.RowHeaderWidth=10;
						
			DataGridTextBoxColumn TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "stt";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "ma";
			TextCol.HeaderText = "Mã số";
			TextCol.Width = 50;
			ts.GridColumnStyles.Add(TextCol);
			

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "ten";
			TextCol.HeaderText = "Tên";
			TextCol.Width = (bGiaban)?200:230;
			ts.GridColumnStyles.Add(TextCol);
			

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "dang";
			TextCol.HeaderText = "ĐVT";
			TextCol.Width = 50;
			ts.GridColumnStyles.Add(TextCol);
			

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "handung";
			TextCol.HeaderText = "Date";
			TextCol.Width = (ttb.bQuanlyhandung(i_nhom))?30:0;
			ts.GridColumnStyles.Add(TextCol);
			

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "losx";
			TextCol.HeaderText = "Lô SX";
			TextCol.Width = (ttb.bQuanlylosx(i_nhom))?50:0;
			ts.GridColumnStyles.Add(TextCol);
			

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "soluong";
			TextCol.HeaderText = "Số lượng";
			TextCol.Width = 80;
			TextCol.Format=format_soluong;
			TextCol.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol);
			

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "dongia";
			TextCol.HeaderText = "Đơn giá";
			TextCol.Width = 100;
			TextCol.Format=format_dongia;
			TextCol.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol);
			

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "sotien";
			TextCol.HeaderText = "Số tiền";
			TextCol.Width = 100;
			TextCol.Format=format_sotien;
			TextCol.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol);
			

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "vat";
			TextCol.HeaderText = "Thuế";
			TextCol.Width = 30;
			TextCol.Format="##0";
			TextCol.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol);
			

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "cuocvc";
			TextCol.HeaderText = "Cước vận chuyển";
			TextCol.Width = 100;
			TextCol.Format=format_sotien;
			TextCol.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol);
			

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "chaythu";
			TextCol.HeaderText = "Chạy thử";
			TextCol.Width = 100;
			TextCol.Format=format_sotien;
			TextCol.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol);
			

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tyle";
			TextCol.HeaderText = "Khấu hao";
			TextCol.Width = 50;
			ts.GridColumnStyles.Add(TextCol);
			

            TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "sotienvat";
			TextCol.HeaderText = "Nguyên giá";
			TextCol.Width = 100;
			TextCol.Format=format_sotien;
			TextCol.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol);
			

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tenhang";
			TextCol.HeaderText = "Hãng";
			TextCol.Width = 150;
			ts.GridColumnStyles.Add(TextCol);
			

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tennuoc";
			TextCol.HeaderText = "Nước";
			TextCol.Width = 150;
			ts.GridColumnStyles.Add(TextCol);
            dataGrid1.TableStyles.Add(ts);
		}

		private void ref_text()
		{
			try
			{
				int i=dataGrid1.CurrentCell.RowNumber;
				stt.Text=dataGrid1[i,0].ToString();
				r=ttb.getrowbyid(dtct,"stt="+int.Parse(stt.Text));
				if (r!=null)
				{
					mabd.Text=r["ma"].ToString();
					tenbd.Text=r["ten"].ToString();
					dang.Text=r["dang"].ToString();
					handung.Text=r["handung"].ToString();
					losx.Text=r["losx"].ToString();
					tenhang.Text=r["tenhang"].ToString();
					tennuoc.Text=r["tennuoc"].ToString();
					d_soluong=(r["soluong"].ToString()!="")?decimal.Parse(r["soluong"].ToString()):0;
					d_dongia=(r["dongia"].ToString()!="")?decimal.Parse(r["dongia"].ToString()):0;
					d_sotien=(r["sotien"].ToString()!="")?decimal.Parse(r["sotien"].ToString()):0;
					i_vat=(r["vat"].ToString()!="")?int.Parse(r["vat"].ToString()):0;
					d_sotienvat=(r["sotienvat"].ToString()!="")?decimal.Parse(r["sotienvat"].ToString()):0;
					d_cuocvc=(r["cuocvc"].ToString()!="")?decimal.Parse(r["cuocvc"].ToString()):0;
					d_chaythu=(r["chaythu"].ToString()!="")?decimal.Parse(r["chaythu"].ToString()):0;
					d_tyle=(r["tyle"].ToString()!="")?decimal.Parse(r["tyle"].ToString()):0;
					tyle.Text=d_tyle.ToString("##0.00");
					soluong.Text=d_soluong.ToString(format_soluong);
					dongia.Text=d_dongia.ToString(format_dongia);
					sotien.Text=d_sotien.ToString(format_sotien);
					cuocvc.Text=d_cuocvc.ToString(format_sotien);
					chaythu.Text=d_chaythu.ToString(format_sotien);
					vat.Text=i_vat.ToString("##0");
					sotienvat.Text=d_sotienvat.ToString(format_sotien);
					baohanh.Value=decimal.Parse(r["baohanh"].ToString());
					namsx.Value=decimal.Parse(r["namsx"].ToString());
					nguongoc.SelectedValue=r["nguongoc"].ToString();
					tinhtrang.SelectedValue=r["tinhtrang"].ToString();
					tailieu.Text=r["tailieu"].ToString();
					sothe.Text=r["sothe"].ToString();
					if (butLuu.Enabled)
					{
						DataRow r1=ttb.getrowbyid(dtdmbd,"ma='"+mabd.Text+"'");
						if (r1!=null)
						{
							i_mabd=int.Parse(r1["id"].ToString());
							tenbd.Enabled=ttb.get_iXuat(s_mmyy,int.Parse(makho.SelectedValue.ToString()),l_id,int.Parse(stt.Text))==0;
							if (ttb.bNhapmaso) mabd.Enabled=tenbd.Enabled;
							soluong.Enabled=tenbd.Enabled;
							if (ttb.bQuanlyhandung(i_nhom)) handung.Enabled=tenbd.Enabled;
							losx.Enabled=tenbd.Enabled;
							if (ttb.bDongia(i_nhom)) dongia.Enabled=tenbd.Enabled;
							else sotien.Enabled=tenbd.Enabled;
							vat.Enabled=tenbd.Enabled;
						}
					}
				}
			}
			catch{}
		}

		private void load_dm()
		{
            sql = "select a.ma,trim(a.ten)||' '||a.hamluong as ten,a.dang,a.sodk,b.ten as tenhang,c.ten as tennuoc,a.tenhc,a.id,a.giaban,a.dongia,a.manhom,d.ma as sotk from " + user + ".ttb_dmbd a inner join " + user + ".ttb_dmhang b on a.mahang=b.id inner join "+user+".ttb_dmnuoc c on a.manuoc=c.id left join "+user+".ttb_dmnhomkt d on a.sotk=d.id where a.hide=0 and a.nhom=" + i_nhom;
			if (s_manhom!="") sql+=" and a.manhom in ("+s_manhom.Substring(0,s_manhom.Length-1)+")";
			sql+=" order by a.ten";
			dtdmbd=ttb.get_data(sql).Tables[0];
			listDMBD.DataSource=dtdmbd;
			dtdmnx=ttb.get_data("select ma,ten,id,nhomcc,diachi,masothue,daidien from "+user+".ttb_dmnx where nhom="+i_nhom+" order by stt").Tables[0];
			listNX.DataSource=dtdmnx;

			lydo.DisplayMember="TEN";
			lydo.ValueMember="ID";
            lydo.DataSource = ttb.get_data("select * from " + user + ".ttb_dmlydotscd where nhom=" + i_nhom + " and loai=0 order by stt").Tables[0];

			nguongoc.DisplayMember="TEN";
			nguongoc.ValueMember="ID";
            nguongoc.DataSource = ttb.get_data("select * from " + user + ".ttb_dmnguongoc where nhom=" + i_nhom + " order by stt").Tables[0];

			tinhtrang.DisplayMember="TEN";
			tinhtrang.ValueMember="ID";
            tinhtrang.DataSource = ttb.get_data("select * from " + user + ".ttb_dmtinhtrang where nhom=" + i_nhom + " order by stt").Tables[0];
		}

		private void sophieu_Validated(object sender, System.EventArgs e)
		{
			if (l_id!=0) return;
			try
			{
				r=ttb.getrowbyid(dtll,"sophieu='"+sophieu.Text+"'");
				if (r!=null)
				{
					MessageBox.Show("Số phiếu đã nhập !",ttb.Msg);
					sophieu.Focus();
				}
			}
			catch{}
		}

		private void cmbSophieu_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter || e.KeyCode==Keys.Tab) butMoi.Focus();
		}

		private void cmbSophieu_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (this.ActiveControl==cmbSophieu)
			{
				try
				{
					l_id=decimal.Parse(cmbSophieu.SelectedValue.ToString());
				}
				catch{l_id=0;}
				load_head();
			}
		}

		private void load_head()
		{
			try
			{
				r=ttb.getrowbyid(dtll,"id="+l_id);
				if (r!=null)
				{
					sophieu.Text=r["sophieu"].ToString();
					ngaysp.Text=r["ngaysp"].ToString();
					sohd.Text=r["sohd"].ToString();
					ngayhd.Text=r["ngayhd"].ToString();
					bbkiem.Text=r["bbkiem"].ToString();
					ngaykiem.Text=r["ngaykiem"].ToString();
					nguoigiao.Text=r["nguoigiao"].ToString();
					makho.SelectedValue=r["makho"].ToString();
					manguon.SelectedValue=r["manguon"].ToString();
					DataRow r1=ttb.getrowbyid(dtdmnx,"id="+int.Parse(r["madv"].ToString()));
					if (r1!=null)
					{
						madv.Text=r1["ma"].ToString();
						tendv.Text=r1["ten"].ToString();
					}
					no.Text=r["no"].ToString();
					co.Text=r["co"].ToString();
					s_ngaysp=ngaysp.Text;
					s_ngayhd=ngayhd.Text;
					s_ngaykiem=ngaykiem.Text;
					lydo.SelectedValue=r["lydo"].ToString();
				}
			}
			catch{}
			load_grid();
			ref_text();
		}

		private void butKetthuc_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void Filter_dmbd(string ten)
		{
			try
			{
				CurrencyManager cm= (CurrencyManager)BindingContext[listDMBD.DataSource];
				DataView dv=(DataView)cm.List;
				dv.RowFilter="ten like '%"+ten.Trim()+"%' or tenhc like '%"+ten.Trim()+"%'";
			}
			catch{}
		}

		private void Filter_dmnx(string ten)
		{
			try
			{
				CurrencyManager cm= (CurrencyManager)BindingContext[listNX.DataSource];
				DataView dv=(DataView)cm.List;
				dv.RowFilter="ten like '%"+ten.Trim()+"%'";
			}
			catch{}
		}

		private void tenbd_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Down || e.KeyCode==Keys.Up) listDMBD.Focus();
			else if (e.KeyCode==Keys.Enter)
			{
				if (listDMBD.Visible) listDMBD.Focus();
				else SendKeys.Send("{Tab}");
			}
		}

		private void tenbd_Validated(object sender, System.EventArgs e)
		{
			if(!listDMBD.Focused) listDMBD.Hide();
			if (tenbd.Text!="" && mabd.Text=="")
			{
				r=ttb.getrowbyid(dtdmbd,"ten='"+tenbd.Text+"'");
				if (r!=null)
				{
					mabd.Text=r["ma"].ToString();
					dang.Text=r["dang"].ToString();
					tenhang.Text=r["tenhang"].ToString();
					tennuoc.Text=r["tennuoc"].ToString();
					if (bDinhkhoan)
					{
						string sotk=no.Text.Trim();
						if (sotk.IndexOf(r["sotk"].ToString().Trim())==-1)
						{
							sotk+=(sotk!="")?",":"";
							sotk+=r["sotk"].ToString().Trim();
							no.Text=sotk;
						}
					}
					if (s_loai=="T")
					{
						d_dongia=decimal.Parse(r["dongia"].ToString());
						dongia.Text=d_dongia.ToString(format_dongia);
					}
				}
			}
		}

		private void tendv_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Down || e.KeyCode==Keys.Up) listNX.Focus();
			else if (e.KeyCode==Keys.Enter)
			{
				if (listNX.Visible)	listNX.Focus();
				else SendKeys.Send("{Tab}");
			}
		}

		private void tendv_TextChanged(object sender, System.EventArgs e)
		{
			if (this.ActiveControl==tendv)
			{
				Filter_dmnx(tendv.Text);
				listNX.BrowseToDmnx(tendv,madv,no);
			}
		}

		private void tendv_Validated(object sender, System.EventArgs e)
		{
			if(!listNX.Focused) listNX.Hide();
			if (tendv.Text!="" && madv.Text=="")
			{
				r=ttb.getrowbyid(dtdmnx,"ten='"+tendv.Text+"'");
				if (r!=null) madv.Text=r["ma"].ToString();
			}
		}

		private void ena_object(bool ena)
		{
			find.Enabled=!ena;
			sophieu.Visible=ena;
			cmbSophieu.Visible=!ena;
			sophieu.Enabled=ena && !this.bSoPhieuNhapKhoTangTuDong;
			ngaysp.Enabled=ena;
			sohd.Enabled=ena;
			ngayhd.Enabled=ena;
			if (bBienban) bbkiem.Enabled=ena;
			ngaykiem.Enabled=bbkiem.Enabled;
			madv.Enabled=ena;
			tendv.Enabled=ena;
			if (bNguoigiao) nguoigiao.Enabled=ena;
			if (ttb.bQuanlynguon(i_nhom)) manguon.Enabled=ena;
			else manguon.SelectedValue="0";
			makho.Enabled=ena;
			if (bDinhkhoan) no.Enabled=ena;
			co.Enabled=no.Enabled;
			if (ttb.bNhapmaso) mabd.Enabled=ena;
			tenbd.Enabled=ena;
			soluong.Enabled=ena;
			if (ttb.bQuanlyhandung(i_nhom)) handung.Enabled=ena;
			losx.Enabled=ena;
			sothe.Enabled=ena;
			if (ttb.bDongia(i_nhom)) dongia.Enabled=ena;
			else sotien.Enabled=ena;
			vat.Enabled=ena;
			chonin.Enabled=!ena;
			butMoi.Enabled=!ena;
			butSua.Enabled=!ena;
			butThem.Enabled=ena;
			butXoa.Enabled=ena;
			butLuu.Enabled=ena;
			butBoqua.Enabled=ena;
			butHuy.Enabled=!ena;
			butIn.Enabled=!ena;
			butKetthuc.Enabled=!ena;
			butKemtheo.Enabled=!ena;
			namsx.Enabled=ena;
			tyle.Enabled=ena;
			baohanh.Enabled=ena;
			lydo.Enabled=ena;
			nguongoc.Enabled=ena;
			tinhtrang.Enabled=ena;
			tailieu.Enabled=ena;
			cuocvc.Enabled=ena;
			chaythu.Enabled=ena;
			i_old=cmbSophieu.SelectedIndex;
			if (ttb.bDanhmuc || ttb.bDmbd)
			{
				load_dm();
			}
        }

		private void emp_head()
		{
			l_id=0;
			sophieu.Text="";
			ngaysp.Text=s_ngay;
			sohd.Text="";
			ngayhd.Text=s_ngay;
			bbkiem.Text="";
			ngaykiem.Text="";
			madv.Text="";
			tendv.Text="";
			nguoigiao.Text="";
			makho.SelectedIndex=0;
			no.Text="";
			co.Text="";
			s_ngaysp=ngaysp.Text;
			s_ngayhd=ngayhd.Text;
			s_ngaykiem=ngaykiem.Text;
			dsxoa.Clear();
		}
		
		private void emp_detail()
		{
			mabd.Text="";
			tenbd.Text="";
			dang.Text="";
			soluong.Text="";
			dongia.Text="";
			sotien.Text="";
			vat.Text="";
			sotienvat.Text="";
			chuathue.Text="";
			cothue.Text="";
			handung.Text="";
			losx.Text="";
			tyle.Text="0";
			namsx.Value=DateTime.Now.Year;
			tailieu.Text="";
			sothe.Text="";
			tenhang.Text="";
			tennuoc.Text="";
			cuocvc.Text="0";
			chaythu.Text="0";
			stt.Text=ttb.get_stt(dtct).ToString();
		}
		private void butMoi_Click(object sender, System.EventArgs e)
		{
			if (bKhoaso)
			{
				MessageBox.Show("Số liệu tháng "+s_mmyy.Substring(0,2)+" năm "+s_mmyy.Substring(2,2)+" đã khóa !\nNếu cần thay đổi thì vào mục khai báo hệ thống",ttb.Msg);
				return;
			}
			ena_object(true);
			emp_head();
			emp_detail();
			dtct.Clear();
			dtold.Clear();
			if (sophieu.Text!="")
			{
				emp_head();
				emp_detail();
				dtct.Clear();
			}
			bNew=true;
			manguon_old=0;makho_old=0;
            if (sophieu.Enabled) sophieu.Focus();
            else 
            {
                ngaysp.Focus();
            }
		}
		private void butSua_Click(object sender, System.EventArgs e)
		{
			if (cmbSophieu.Items.Count==0) return;
			if (bKhoaso)
			{
				MessageBox.Show("Số liệu tháng "+s_mmyy.Substring(0,2)+" năm "+s_mmyy.Substring(2,2)+" đã khóa !\nNếu cần thay đổi thì vào mục khai báo hệ thống",ttb.Msg);
				return;
			}
			l_id=decimal.Parse(cmbSophieu.SelectedValue.ToString());
			if (ttb.get_paid("ttb_nhapll",s_mmyy,l_id))
			{
				MessageBox.Show("Số phiếu đã thanh toán !",ttb.Msg);
				return;
			}
			ena_object(true);
			bNew=false;
			s_sophieu=sophieu.Text;
            if (ttb.bQuanlynguon(i_nhom))
			    manguon_old=int.Parse(manguon.SelectedValue.ToString());
			makho_old=int.Parse(makho.SelectedValue.ToString());
			dtold=dtct.Copy();
			dsxoa.Clear();
			sophieu.Focus();
			ref_text();
		}
		private bool KiemtraHead()
		{
            if (sophieu.Text == "" && !bSoPhieuNhapKhoTangTuDong)
            {
                MessageBox.Show("Nhập số phiếu !", ttb.Msg);
                sophieu.Focus();
                return false;
            }
            else 
            {
                if (sophieu.Text.Trim() == "")
                {
                    sophieu.Text = ttb.get_sophieu(s_mmyy.Substring(2), "ttb_nhapll", "sophieu", "");
                }
            }
			if (ngaysp.Text=="")
			{
				MessageBox.Show("Nhập ngày số phiếu !",ttb.Msg);
				ngaysp.Focus();
				return false;
			}
			if (sohd.Text=="")
			{
				MessageBox.Show("Nhập số hóa đơn !",ttb.Msg);
				sohd.Focus();
				return false;
			}
			if (ngayhd.Text=="")
			{
				MessageBox.Show("Nhập ngày hóa đơn !",ttb.Msg);
				ngayhd.Focus();
				return false;
			}
			if (bBienban)
			{
				if ((bbkiem.Text=="" && ngaykiem.Text!="") || (bbkiem.Text!="" && ngaykiem.Text==""))
				{
					if (bbkiem.Text=="")
					{
						MessageBox.Show("Nhập biên bản kiểm số !",ttb.Msg);
						bbkiem.Focus();
						return false;
					}
					else if (ngaykiem.Text=="")
					{
						MessageBox.Show("Nhập ngày biên bản kiểm !",ttb.Msg);
						ngaykiem.Focus();
						return false;
					}
				}
			}
			if (ttb.bQuanlynguon(i_nhom))
			{
				if (manguon.SelectedIndex==-1 || manguon.SelectedValue.ToString()=="0")
				{
					MessageBox.Show("Nguồn không hợp lệ !",ttb.Msg);
					manguon.Focus();
					return false;
				}
			}
			else manguon.SelectedValue="0";

			if (lydo.SelectedIndex==-1)
			{
				lydo.Focus();
				return false;
			}
			if (makho.SelectedIndex==-1)
			{
				MessageBox.Show("Nhập kho nhập !",ttb.Msg);
				makho.Focus();
				return false;
			}
			if (madv.Text=="" && tendv.Text=="")
			{
				MessageBox.Show("Chọn nhà cung cấp !",ttb.Msg);
				madv.Focus();
				return false;
			}
			if ((madv.Text!="" && tendv.Text=="") || (madv.Text=="" && tendv.Text!=""))
			{
				if (madv.Text=="")
				{
					madv.Focus();
					return false;
				}
				else if (tendv.Text=="")
				{
					tendv.Focus();
					return false;
				}
			}
			i_madv=0;
			r=ttb.getrowbyid(dtdmnx,"ma='"+madv.Text+"'");
			if (r==null)
			{
				MessageBox.Show("Nhà cung cấp không hợp lệ !",ttb.Msg);
				madv.Focus();
				return false;
			}
			i_madv=int.Parse(r["id"].ToString());
			if (ttb.bQuanlynhomcc(i_nhom)) i_nhomcc=int.Parse(r["nhomcc"].ToString());
			else i_nhomcc=0;
			i_nhomcc=i_madv;
			if (dtct.Rows.Count==0)
			{
				MessageBox.Show("Đề nghị nhập chi tiết !",ttb.Msg);
				butThem.Focus();
				return false;
			}
			if (bDinhkhoan)
			{
				if ((no.Text=="" && co.Text!="") || (no.Text!="" && co.Text==""))
				{
					if (no.Text=="")
					{
						no.Focus();
						return false;
					}
					else if (co.Text=="")
					{
						co.Focus();
						return false;
					}
				}
			}
			if (!bNew)
			{
				if (sophieu.Text!=s_sophieu)
				{
					sql="select * from ttb_nhapll where loai='M' and sophieu='"+sophieu.Text+"' and id<>"+l_id;
					if (ttb.get_data(sql).Tables[0].Rows.Count>0)
					{
						MessageBox.Show("Số phiếu "+sophieu.Text+" đã nhập !",ttb.Msg);
						sophieu.Focus();
						return false;
					}
				}
				if (manguon_old!=int.Parse(manguon.SelectedValue.ToString()) || makho_old!=int.Parse(makho.SelectedValue.ToString()))
				{
					foreach(DataRow r1 in dtct.Rows)
					{
						i_mabd=ttb.get_iXuat(s_mmyy,makho_old,l_id,int.Parse(r1["stt"].ToString()));
						if (i_mabd!=0)
						{
							r=ttb.getrowbyid(dtdmbd,"id="+i_mabd);
							if (r!=null)
							{
								MessageBox.Show(r["ten"].ToString().Trim()+" "+r["dang"].ToString().Trim()+"\nĐã xuất không cho phép chỉnh sửa !",ttb.Msg);
								return false;
							}
						}
					}
				}
			}
			return true;
		}

		private bool KiemtraDetail()
		{
			i_mabd=0;
			if (mabd.Text=="" && tenbd.Text=="")
			{
				if (mabd.Enabled) mabd.Focus();
				else tenbd.Focus();
				return false;
			}
			if ((mabd.Text=="" && tenbd.Text!="") || (mabd.Text!="" && tenbd.Text==""))
			{
				if (mabd.Text=="" && mabd.Enabled)
				{
					MessageBox.Show("Nhập mã số !",ttb.Msg);
					mabd.Focus();
					return false;
				}
				else if (tenbd.Text=="")
				{
					MessageBox.Show("Nhập tên !",ttb.Msg);
					tenbd.Focus();
					return false;
				}
			}
			r=ttb.getrowbyid(dtdmbd,"ma='"+mabd.Text+"'");
			if (r==null)
			{
				MessageBox.Show("Mã số không hợp lệ !",ttb.Msg);
				if (mabd.Enabled) mabd.Focus();
				else tenbd.Focus();
				return false;
			}
			i_mabd=int.Parse(r["id"].ToString());
			if (soluong.Text=="" || soluong.Text=="0.00" || soluong.Text=="0")
			{
				MessageBox.Show("Nhập số lượng !",ttb.Msg);
				soluong.Focus();
				return false;
			}
			return true;
		}

		private void butLuu_Click(object sender, System.EventArgs e)
		{
			upd_table(dtct);
			dtct.AcceptChanges();
			if (!KiemtraHead()) return;
			i_old=(bNew)?0:1;
			l_id=(bNew)?ttb.get_id_nhap:l_id;
            itable = ttb.tableid(s_mmyy, "ttb_nhapll");
            if (bNew) ttb.upd_eve_tables(s_mmyy, itable, i_userid, "ins");
            else
            {
                ttb.upd_eve_tables(s_mmyy, itable, i_userid, "upd");
                ttb.upd_eve_upd_del(s_mmyy, itable, i_userid, "upd", ttb.fields("ttb_nhapll", "id=" + l_id));
            }
            if (manguon.SelectedValue== null)
            {
                manguon.SelectedValue = 1;
            }
			if (!ttb.upd_nhapll(s_mmyy,l_id,i_nhom,sophieu.Text,ngaysp.Text,sohd.Text,ngayhd.Text,bbkiem.Text,ngaykiem.Text,s_loai,nguoigiao.Text,i_madv,int.Parse(makho.SelectedValue.ToString()),int.Parse(manguon.SelectedValue.ToString()),i_nhomcc,no.Text,co.Text,i_userid,(lydo.SelectedIndex!=-1)?int.Parse(lydo.SelectedValue.ToString()):0,0))
			{
				MessageBox.Show("Không cập nhật được thông tin phiếu nhập kho !",ttb.Msg);
				return;
			}
            itable = ttb.tableid(s_mmyy, "ttb_nhapct");
			if (!bNew)
			{
				if (manguon_old!=int.Parse(manguon.SelectedValue.ToString()) || makho_old!=int.Parse(makho.SelectedValue.ToString()))
				{
					foreach(DataRow r1 in dtold.Rows)
					{
                        ttb.upd_eve_tables(s_mmyy, itable, i_userid, "del");
                        ttb.upd_eve_upd_del(s_mmyy, itable, i_userid, "del", ttb.fields("ttb_nhapct", "id=" + l_id+" and stt="+int.Parse(r1["stt"].ToString())));
						ttb.execute_data("delete from ttb_nhapct where id="+l_id+" and stt="+int.Parse(r1["stt"].ToString()));
						if (s_loai=="M" && bKinhphi)
						{
							r=ttb.getrowbyid(dtdmbd,"id="+int.Parse(r1["mabd"].ToString()));
							if (r!=null) ttb.execute_data("update "+user+".ttb_kinhphi set dasudung=dasudung-"+Math.Round(decimal.Parse(r1["sotien"].ToString())+decimal.Parse(r1["sotien"].ToString())*decimal.Parse(r1["vat"].ToString())/100,3)+" where nhom="+i_nhom+" and yy='"+s_mmyy.Substring(2,2)+"' and id_nhom="+int.Parse(r["manhom"].ToString()));
						}
                        ttb.upd_tonkhoct_nhapct(ttb.delete, s_mmyy, ngayhd.Text, l_id, int.Parse(r1["stt"].ToString()), decimal.Parse(r1["soluong"].ToString()), decimal.Parse(r1["sotien"].ToString()), int.Parse(r1["vat"].ToString()), makho_old, manguon_old, i_nhomcc, int.Parse(r1["mabd"].ToString()), r1["handung"].ToString(), r1["losx"].ToString(), decimal.Parse(r1["giaban"].ToString()), r1["namsx"].ToString(), decimal.Parse(r1["cuocvc"].ToString()), decimal.Parse(r1["chaythu"].ToString()), s_loai, int.Parse(r1["baohanh"].ToString()), int.Parse(r1["nguongoc"].ToString()), int.Parse(r1["tinhtrang"].ToString()), i_nhom, r1["sothe"].ToString(), decimal.Parse(r1["tyle"].ToString()), 2, 0, decimal.Parse(r1["giaban"].ToString()), 0, decimal.Parse(r1["sotien"].ToString()), 0, 0, decimal.Parse(r1["sotien"].ToString()) / decimal.Parse(r1["soluong"].ToString()),false);
					}
					dtold.Clear();
				}
                foreach (DataRow r1 in dsxoa.Tables[0].Rows)
                {
                    ttb.upd_eve_tables(s_mmyy, itable, i_userid, "del");
                    ttb.upd_eve_upd_del(s_mmyy, itable, i_userid, "del", ttb.fields("ttb_nhapct", "id=" + l_id + " and stt=" + int.Parse(r1["stt"].ToString())));
                    ttb.execute_data("delete from ttb_nhapct where id=" + l_id + " and stt=" + int.Parse(r1["stt"].ToString()));
                }
				foreach(DataRow r1 in dtold.Rows)
				{
					if (s_loai=="M" && bKinhphi)
					{
						r=ttb.getrowbyid(dtdmbd,"id="+int.Parse(r1["mabd"].ToString()));
						if (r!=null) ttb.execute_data("update "+user+".ttb_kinhphi set dasudung=dasudung-"+Math.Round(decimal.Parse(r1["sotien"].ToString())+decimal.Parse(r1["sotien"].ToString())*decimal.Parse(r1["vat"].ToString())/100,3)+" where nhom="+i_nhom+" and yy='"+s_mmyy.Substring(2,2)+"' and id_nhom="+int.Parse(r["manhom"].ToString()));
					}
                    ttb.upd_tonkhoct_nhapct(ttb.delete, s_mmyy, ngayhd.Text, l_id, int.Parse(r1["stt"].ToString()), decimal.Parse(r1["soluong"].ToString()), decimal.Parse(r1["sotien"].ToString()), int.Parse(r1["vat"].ToString()), int.Parse(makho.SelectedValue.ToString()), int.Parse(manguon.SelectedValue.ToString()), i_nhomcc, int.Parse(r1["mabd"].ToString()), r1["handung"].ToString(), r1["losx"].ToString(), decimal.Parse(r1["giaban"].ToString()), r1["namsx"].ToString(), decimal.Parse(r1["cuocvc"].ToString()), decimal.Parse(r1["chaythu"].ToString()), s_loai, int.Parse(r1["baohanh"].ToString()), int.Parse(r1["nguongoc"].ToString()), int.Parse(r1["tinhtrang"].ToString()), i_nhom, r1["sothe"].ToString(), decimal.Parse(r1["tyle"].ToString()), 2, 0, decimal.Parse(r1["giaban"].ToString()), 0, decimal.Parse(r1["sotien"].ToString()), 0, 0, decimal.Parse(r1["sotien"].ToString()) / decimal.Parse(r1["soluong"].ToString()),false);
				}
			}
			foreach(DataRow r1 in dtct.Rows)
			{
                if (ttb.get_data("select * from ttb_nhapct where id=" + l_id + " and stt=" + int.Parse(r1["stt"].ToString())).Tables[0].Rows.Count == 0)
                    ttb.upd_eve_tables(s_mmyy, itable, i_userid, "ins");
                else
                {
                    ttb.upd_eve_tables(s_mmyy, itable, i_userid, "upd");
                    ttb.upd_eve_upd_del(s_mmyy, itable, i_userid, "upd", ttb.fields("ttb_nhapct", "id=" + l_id + " and stt=" + int.Parse(r1["stt"].ToString())));
                }
                ttb.upd_nhapct(s_mmyy, l_id, int.Parse(r1["stt"].ToString()), int.Parse(r1["mabd"].ToString()), r1["handung"].ToString(), r1["losx"].ToString(), int.Parse(r1["vat"].ToString()), decimal.Parse(r1["soluong"].ToString()), decimal.Parse(r1["dongia"].ToString()), decimal.Parse(r1["sotien"].ToString()), decimal.Parse(r1["giaban"].ToString()), decimal.Parse(r1["giamua"].ToString()), decimal.Parse(r1["sl1"].ToString()), decimal.Parse(r1["sl2"].ToString()), decimal.Parse(r1["tyle"].ToString()), decimal.Parse(r1["cuocvc"].ToString()), decimal.Parse(r1["chaythu"].ToString()), r1["namsx"].ToString(), r1["tailieu"].ToString(), int.Parse(r1["baohanh"].ToString()), int.Parse(r1["nguongoc"].ToString()), int.Parse(r1["tinhtrang"].ToString()), r1["sothe"].ToString(), 0, 0, decimal.Parse(r1["giaban"].ToString()), decimal.Parse(r1["tyle"].ToString()),0,0);
				if (s_loai=="M" && bKinhphi)
				{
					r=ttb.getrowbyid(dtdmbd,"id="+int.Parse(r1["mabd"].ToString()));
					if (r!=null) ttb.upd_kinhphi_sd(i_nhom,s_mmyy.Substring(2,2),int.Parse(r["manhom"].ToString()),Math.Round(decimal.Parse(r1["sotien"].ToString())+decimal.Parse(r1["sotien"].ToString())*decimal.Parse(r1["vat"].ToString())/100,3));
				}
                ttb.upd_tonkhoct_nhapct(ttb.insert, s_mmyy, ngayhd.Text, l_id, int.Parse(r1["stt"].ToString()), decimal.Parse(r1["soluong"].ToString()), decimal.Parse(r1["sotien"].ToString()), int.Parse(r1["vat"].ToString()), int.Parse(makho.SelectedValue.ToString()), int.Parse(manguon.SelectedValue.ToString()), i_nhomcc, int.Parse(r1["mabd"].ToString()), r1["handung"].ToString(), r1["losx"].ToString(), decimal.Parse(r1["giaban"].ToString()), r1["namsx"].ToString(), decimal.Parse(r1["cuocvc"].ToString()), decimal.Parse(r1["chaythu"].ToString()), s_loai, int.Parse(r1["baohanh"].ToString()), int.Parse(r1["nguongoc"].ToString()), int.Parse(r1["tinhtrang"].ToString()), i_nhom, r1["sothe"].ToString(), decimal.Parse(r1["tyle"].ToString()), 2, 0, decimal.Parse(r1["giaban"].ToString()), 0, decimal.Parse(r1["sotien"].ToString()), 0, 0, decimal.Parse(r1["sotien"].ToString()) / decimal.Parse(r1["soluong"].ToString()),false);
			}
			ttb.updrec_nhapll(dtll,l_id,sophieu.Text,ngaysp.Text,sohd.Text,ngayhd.Text,bbkiem.Text,ngaykiem.Text,nguoigiao.Text,i_madv,int.Parse(makho.SelectedValue.ToString()),int.Parse(manguon.SelectedValue.ToString()),no.Text,co.Text,(lydo.SelectedIndex!=-1)?int.Parse(lydo.SelectedValue.ToString()):0,0);
			try
			{
				if (i_old==0 && dtll.Rows.Count>0) cmbSophieu.SelectedIndex=dtll.Rows.Count-1;
			}
			catch{}
			tongcong();
			ena_object(false);
			butMoi.Focus();
		}

		private void butBoqua_Click(object sender, System.EventArgs e)
		{
			cmbSophieu.SelectedIndex=i_old;
			try
			{
				l_id=decimal.Parse(cmbSophieu.SelectedValue.ToString());
			}
			catch{l_id=0;}
			load_head();
			ena_object(false);
			butMoi.Focus();
		}

		private void ngaysp_Validated(object sender, System.EventArgs e)
		{
			if (ngaysp.Text=="") return;
            ngaysp.Text = ngaysp.Text.Trim();
            if (ngaysp.Text.Length == 6) ngaysp.Text = ngaysp.Text + DateTime.Now.Year.ToString();
			if (!ttb.bNgay(ngaysp.Text))
			{
				MessageBox.Show("Ngày không hợp lệ !",ttb.Msg);
				ngaysp.Focus();
				return;
			}
			ngaysp.Text=ttb.Ktngaygio(ngaysp.Text,10);
			if (ngaysp.Text!=s_ngaysp)
			{
				if (!ttb.ngay(ttb.StringToDate(ngaysp.Text.Substring(0,10)),DateTime.Now,i_songay))
				{
					MessageBox.Show("Ngày không hợp lệ so với khai báo hệ thống ("+i_songay.ToString()+")!",ttb.Msg);
					ngaysp.Focus();
					return;
				}
			}
		}

		private void ngayhd_Validated(object sender, System.EventArgs e)
		{
			if (ngayhd.Text=="") return;
			ngayhd.Text=ngayhd.Text.Trim();
            if (ngayhd.Text.Length == 6) ngayhd.Text = ngayhd.Text + DateTime.Now.Year.ToString();
			if (!ttb.bNgay(ngayhd.Text))
			{
				MessageBox.Show("Ngày không hợp lệ !",ttb.Msg);
				ngayhd.Focus();
				return;
			}
			ngayhd.Text=ttb.Ktngaygio(ngayhd.Text,10);
			if (ngayhd.Text!=s_ngayhd)
			{
				if (!ttb.ngay(ttb.StringToDate(ngayhd.Text.Substring(0,10)),DateTime.Now,i_songay))
				{
					MessageBox.Show("Ngày không hợp lệ so với khai báo hệ thống ("+i_songay.ToString()+")!",ttb.Msg);
					ngayhd.Focus();
					return;
				}
			}
		}

		private void ngaykiem_Validated(object sender, System.EventArgs e)
		{
			if (ngaykiem.Text=="") return;
			ngaykiem.Text=ngaykiem.Text.Trim();
			if (!ttb.bNgay(ngaykiem.Text))
			{
				MessageBox.Show("Ngày không hợp lệ !",ttb.Msg);
				ngaykiem.Focus();
				return;
			}
			ngaykiem.Text=ttb.Ktngaygio(ngaykiem.Text,10);
			if (ngaykiem.Text!=s_ngaykiem)
			{
				if (!ttb.ngay(ttb.StringToDate(ngaykiem.Text.Substring(0,10)),DateTime.Now,i_songay))
				{
					MessageBox.Show("Ngày không hợp lệ so với khai báo hệ thống ("+i_songay.ToString()+")!",ttb.Msg);
					ngaykiem.Focus();
					return;
				}
			}
		}

		private void butThem_Click(object sender, System.EventArgs e)
		{
			tenbd.Enabled=true;
			if (ttb.bNhapmaso) mabd.Enabled=tenbd.Enabled;
			soluong.Enabled=tenbd.Enabled;
			if (ttb.bQuanlyhandung(i_nhom)) handung.Enabled=tenbd.Enabled;
			if (ttb.bQuanlylosx(i_nhom)) losx.Enabled=tenbd.Enabled;
			if (ttb.bDongia(i_nhom)) dongia.Enabled=tenbd.Enabled;
			else sotien.Enabled=tenbd.Enabled;
			vat.Enabled=tenbd.Enabled;
			if (!upd_table(dtct)) return;
			string s_tyle=tyle.Text;
			s_vat=vat.Text;
			emp_detail();
			vat.Text=s_vat;
			tyle.Text=s_tyle;
			if (mabd.Enabled) mabd.Focus();
			else tenbd.Focus();
		}

		private void butXoa_Click(object sender, System.EventArgs e)
		{
			i_mabd=ttb.get_iXuat(s_mmyy,int.Parse(makho.SelectedValue.ToString()),l_id,int.Parse(stt.Text));
			if (i_mabd!=0)
			{
				r=ttb.getrowbyid(dtdmbd,"id="+i_mabd);
				if (r!=null)
				{
					MessageBox.Show(r["ten"].ToString().Trim()+" "+r["dang"].ToString().Trim()+"\nĐã xuất không cho phép hủy !",ttb.Msg);
					return;
				}
			}
			if (!upd_table(dsxoa.Tables[0])) return;
			ttb.delrec(dtct,"stt="+int.Parse(stt.Text));
			dtct.AcceptChanges();
			if (dtct.Rows.Count==0) emp_detail();
			else ref_text();
		}

		private bool upd_table(DataTable dt)
		{
			if (!KiemtraDetail()) return false;
			d_soluong=(soluong.Text!="")?decimal.Parse(soluong.Text):0;
			d_dongia=(dongia.Text!="")?decimal.Parse(dongia.Text):0;
			d_sotien=(sotien.Text!="")?decimal.Parse(sotien.Text):0;
			d_cuocvc=(cuocvc.Text!="")?decimal.Parse(cuocvc.Text):0;
			d_chaythu=(chaythu.Text!="")?decimal.Parse(chaythu.Text):0;
			d_sotienvat=(sotienvat.Text!="")?decimal.Parse(sotienvat.Text):0;
			i_vat=(vat.Text!="")?int.Parse(vat.Text):0;
			d_tyle=(tyle.Text=="")?0:decimal.Parse(tyle.Text);
			d_giaban=Math.Round(d_sotienvat/d_soluong,i_sole_giaban);
			handung.Text=handung.Text.Trim().PadRight(4,'0');
			handung.Refresh();
            ttb.updrec_nhapct(dt, int.Parse(stt.Text), i_mabd, mabd.Text, tenbd.Text, "", dang.Text, handung.Text, losx.Text, d_soluong, d_dongia, d_sotien, i_vat, d_sotienvat, d_giaban, d_giaban, d_soluong, 1, d_tyle, d_cuocvc, d_chaythu, namsx.Value, tailieu.Text, Convert.ToInt16(baohanh.Value), (nguongoc.SelectedIndex != -1) ? int.Parse(nguongoc.SelectedValue.ToString()) : 0, (tinhtrang.SelectedIndex != -1) ? int.Parse(tinhtrang.SelectedValue.ToString()) : 0, sothe.Text, 0, 0, d_giaban,d_tyle,0,0,d_sotienvat);
			return true;
		}

		private void madv_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");
		}

		private void manguon_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter || e.KeyCode==Keys.Tab)
			{
				if (manguon.SelectedIndex==-1) manguon.SelectedIndex=0;
				SendKeys.Send("{Tab}{F4}");
			}
		}

		private void makho_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter || e.KeyCode==Keys.Tab)
			{
				if (makho.SelectedIndex==-1) makho.SelectedIndex=0;
				SendKeys.Send("{Tab}");
			}
		}

		private void madv_Validated(object sender, System.EventArgs e)
		{
			if (madv.Text!="")
			{
				r=ttb.getrowbyid(dtdmnx,"ma='"+madv.Text+"'");
				if (r!=null) tendv.Text=r["ten"].ToString();
			}
		}

		private void mabd_Validated(object sender, System.EventArgs e)
		{
			if (mabd.Text!="")
			{
				r=ttb.getrowbyid(dtdmbd,"ma='"+mabd.Text+"'");
				if (r!=null) 
				{
					tenbd.Text=r["ten"].ToString();
					dang.Text=r["dang"].ToString();
					tenhang.Text=r["tenhang"].ToString();
					tennuoc.Text=r["tennuoc"].ToString();
                    losx.Text= r["sodk"].ToString();
					if (bDinhkhoan)
					{
						string sotk=no.Text.Trim();
						if (sotk.IndexOf(r["sotk"].ToString().Trim())==-1)
						{
							sotk+=(sotk!="")?",":"";
							sotk+=r["sotk"].ToString().Trim();
							no.Text=sotk;
						}
					}
					if (s_loai=="T")
					{
						d_dongia=decimal.Parse(r["dongia"].ToString());
						dongia.Text=d_dongia.ToString(format_dongia);
					}
				}
			}
			if(!listDMBD.Focused) listDMBD.Hide();
		}

		private void listDMBD_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) mabd_Validated(null,null);
		}

		private void dataGrid1_CurrentCellChanged(object sender, System.EventArgs e)
		{
			ref_text();
		}

		private void tinh_giatri()
		{
			try
			{
                d_soluong = (soluong.Text != "") ? decimal.Parse(soluong.Text) : 0; 
                i_vat = (vat.Text != "") ? int.Parse(vat.Text) : 0;
				if (ttb.bDongia(i_nhom) )
				{
					d_dongia=(dongia.Text!="")?decimal.Parse(dongia.Text):0;
					d_sotien=Math.Round(d_soluong*d_dongia,3);
					sotien.Text=d_sotien.ToString(format_sotien);
				}
				else
				{	
					d_sotien=(sotien.Text!="")?decimal.Parse(sotien.Text):0;
					d_dongia=Math.Round(d_sotien/d_soluong,3);
					dongia.Text=d_dongia.ToString(format_dongia);
				}				
				d_cuocvc=(cuocvc.Text!="")?decimal.Parse(cuocvc.Text):0;
				d_chaythu=(chaythu.Text!="")?decimal.Parse(chaythu.Text):0;
				d_sotienvat=Math.Round(d_sotien+d_sotien*i_vat/100,3)+d_cuocvc+d_chaythu;
				sotienvat.Text=d_sotienvat.ToString(format_sotien);
			}
			catch{}
		}

		private void vat_Validated(object sender, System.EventArgs e)
		{
			try
			{
				if (vat.Text=="") vat.Text="0";
			}
			catch{}
			tinh_giatri();
		}

		private void dongia_Validated(object sender, System.EventArgs e)
		{
			try
			{
				d_dongia=(dongia.Text!="")?decimal.Parse(dongia.Text):0;
				dongia.Text=d_dongia.ToString(format_dongia);
			}
			catch{dongia.Text="0";}
			tinh_giatri();
		}

		private void sotien_Validated(object sender, System.EventArgs e)
		{
			try
			{
				d_sotien=(sotien.Text!="")?decimal.Parse(sotien.Text):0;
				sotien.Text=d_sotien.ToString(format_sotien);
			}
			catch{}
			tinh_giatri();
		}

		private void soluong_Validated(object sender, System.EventArgs e)
		{
			try
			{
				d_soluong=(soluong.Text!="")?decimal.Parse(soluong.Text):0;
				soluong.Text=d_soluong.ToString(format_soluong);
			}
			catch{}
			tinh_giatri();
		}

		private void butHuy_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (cmbSophieu.Items.Count==0) return;
				if (bKhoaso)
				{
					MessageBox.Show("Số liệu tháng "+s_mmyy.Substring(0,2)+" năm "+s_mmyy.Substring(2,2)+" đã khóa !\nNếu cần thay đổi thì vào mục khai báo hệ thống",ttb.Msg);
					return;
				}
				l_id=decimal.Parse(cmbSophieu.SelectedValue.ToString());
				if (ttb.get_paid("ttb_nhapll",s_mmyy,l_id))
				{
					MessageBox.Show("Số phiếu đã thanh toán !",ttb.Msg);
					return;
				}
				foreach(DataRow r1 in dtct.Rows)
				{
					i_mabd=ttb.get_iXuat(s_mmyy,int.Parse(makho.SelectedValue.ToString()),l_id,int.Parse(r1["stt"].ToString()));
					if (i_mabd!=0)
					{
						r=ttb.getrowbyid(dtdmbd,"id="+i_mabd);
						if (r!=null)
						{
							MessageBox.Show(r["ten"].ToString().Trim()+" "+r["dang"].ToString().Trim()+"\nĐã xuất không cho phép hủy !",ttb.Msg);
							return;
						}
					}
				}
				if (MessageBox.Show("Đồng ý hủy số phiếu này ?",ttb.Msg,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
				{
                    itable = ttb.tableid(s_mmyy, "ttb_nhapct");
					foreach(DataRow r1 in dtct.Rows)
					{
                        ttb.upd_eve_tables(s_mmyy, itable, i_userid, "del");
                        ttb.upd_eve_upd_del(s_mmyy, itable, i_userid, "del", ttb.fields( "ttb_nhapct", "id=" + l_id + " and stt=" + int.Parse(r1["stt"].ToString())));
                        ttb.upd_tonkhoct_nhapct(ttb.delete, s_mmyy, ngayhd.Text, l_id, int.Parse(r1["stt"].ToString()), decimal.Parse(r1["soluong"].ToString()), decimal.Parse(r1["sotien"].ToString()), int.Parse(r1["vat"].ToString()), int.Parse(makho.SelectedValue.ToString()), int.Parse(manguon.SelectedValue.ToString()), i_nhomcc, int.Parse(r1["mabd"].ToString()), r1["handung"].ToString(), r1["losx"].ToString(), decimal.Parse(r1["giaban"].ToString()), r1["namsx"].ToString(), decimal.Parse(r1["cuocvc"].ToString()), decimal.Parse(r1["chaythu"].ToString()), s_loai, int.Parse(r1["baohanh"].ToString()), int.Parse(r1["nguongoc"].ToString()), int.Parse(r1["tinhtrang"].ToString()), i_nhom, r1["sothe"].ToString(), decimal.Parse(r1["tyle"].ToString()), 2, 0, decimal.Parse(r1["giaban"].ToString()), 0, decimal.Parse(r1["sotien"].ToString()), 0, 0, decimal.Parse(r1["sotien"].ToString()) / decimal.Parse(r1["soluong"].ToString()),false);
						if (s_loai=="M" && bKinhphi)
						{
							r=ttb.getrowbyid(dtdmbd,"id="+int.Parse(r1["mabd"].ToString()));
							if (r!=null) ttb.execute_data("update "+user+".ttb_kinhphi set dasudung=dasudung-"+Math.Round(decimal.Parse(r1["sotien"].ToString())+decimal.Parse(r1["sotien"].ToString())*decimal.Parse(r1["vat"].ToString())/100,3)+" where nhom="+i_nhom+" and yy='"+s_mmyy.Substring(2,2)+"' and id_nhom="+int.Parse(r["manhom"].ToString()));
						}
                        //ttb.execute_data("delete from ttb_theodoitscd where sttt=" + l_id);
					}
                    itable = ttb.tableid(s_mmyy, "ttb_nhapll");
                    ttb.upd_eve_tables(s_mmyy, itable, i_userid, "del");
                    ttb.upd_eve_upd_del(s_mmyy, itable, i_userid, "del", ttb.fields("ttb_nhapll", "id=" + l_id));
					ttb.execute_data("delete from ttb_nhapct where id="+l_id);
                    ttb.execute_data("delete from ttb_thanhtoan where id=" + l_id);
                    ttb.execute_data("delete from ttb_nhapll where id="+l_id);
					ttb.delrec(dtll,"id="+l_id);
					cmbSophieu.Refresh();
					if (cmbSophieu.Items.Count>0) l_id=decimal.Parse(cmbSophieu.SelectedValue.ToString());
					else l_id=0;
					load_head();
				}
			}
			catch //(Exception exx)
            {
                //MessageBox.Show("Không hủy được phiếu!", ttb.Msg);
            }
		}

		private void nguoigiao_Validated(object sender, System.EventArgs e)
		{
			SendKeys.Send("{F4}");
		}

		private void tongcong()
		{
			try
			{
				d_chuathue=0;
				d_cothue=0;
				foreach(DataRow r1 in dtct.Rows)
				{
					d_sotien=decimal.Parse(r1["sotien"].ToString());
					d_chuathue+=d_sotien;
					d_cothue+=decimal.Parse(r1["sotienvat"].ToString());
				}
				chuathue.Text=d_chuathue.ToString(format_sotien);
				cothue.Text=d_cothue.ToString(format_sotien);
			}
			catch{}
		}

		private void sohd_Validated(object sender, System.EventArgs e)
		{
			if (l_id!=0) return;
			try
			{
				r=ttb.getrowbyid(dtll,"sohd='"+sohd.Text+"'");
				if (r!=null)
				{
					MessageBox.Show("Số hóa đơn đã nhập !",ttb.Msg);
					sohd.Focus();
				}
			}
			catch{}		
		}

		private void butIn_Click(object sender, System.EventArgs e)
		{	
			switch (chonin.SelectedIndex)
			{
				case 0: phieunhap();break;
				case 1: giaonhan();break;
				case 2: bangiao();break;
				case 3: kiemnhap();break;
				case 4: indenghi();break;
			}
		}

		private void kiemnhap()
		{
			if (dtct.Rows.Count==0) return;
			rptBbknhap_hd f=new rptBbknhap_hd(ttb,i_nhom,s_makho,"ttb_Bbknhap_hd.rpt",madv.Text,tendv.Text,ngayhd.Text,ngaysp.Text,int.Parse(makho.SelectedValue.ToString()));
			f.ShowDialog();
		}

		private void tenbd_TextChanged(object sender, System.EventArgs e)
		{
			if (this.ActiveControl==tenbd)
			{
				if (butMoi.Enabled) return;
				Filter_dmbd(tenbd.Text);
				listDMBD.BrowseToDmttb(tenbd,mabd,soluong,mabd.Location.X,mabd.Location.Y + mabd.Height-2,mabd.Width+lTen.Width+tenbd.Width*2+ldvt.Width+dang.Width-40,mabd.Height+5);
			}
		}

		private void mabd_TextChanged(object sender, System.EventArgs e)
		{
			if (this.ActiveControl==mabd)
			{
				if (butMoi.Enabled) return;
				Filter_mabd(mabd.Text);
				listDMBD.BrowseToDmttb(mabd,tenbd,soluong,mabd.Location.X,mabd.Location.Y + mabd.Height-2,mabd.Width+lTen.Width+tenbd.Width*2+ldvt.Width+dang.Width-40,mabd.Height+5);
			}
		}

		private void Filter_mabd(string ma)
		{
			try
			{
				CurrencyManager cm= (CurrencyManager)BindingContext[listDMBD.DataSource];
				DataView dv=(DataView)cm.List;
				dv.RowFilter="ma like '%"+ma.Trim()+"%'";
			}
			catch{}
		}

		private void tyle_Validated(object sender, System.EventArgs e)
		{
			try
			{
				d_tyle=(tyle.Text=="")?0:decimal.Parse(tyle.Text);
				tyle.Text=d_tyle.ToString("##0.00");
			}
			catch{tyle.Text="0";}
			tinh_giatri();
		}

		private void find_TextChanged(object sender, System.EventArgs e)
		{
			if (this.ActiveControl==find) RefreshChildren(find.Text);
		}

		private void RefreshChildren(string text)
		{
			try
			{
				CurrencyManager cm= (CurrencyManager)BindingContext[cmbSophieu.DataSource];
				DataView dv=(DataView)cm.List;			
				dv.RowFilter="sophieu like '%"+text.Trim()+"%' or sohd like '%"+text+"%'";
				if(cmbSophieu.SelectedIndex>=0)	l_id=decimal.Parse(cmbSophieu.SelectedValue.ToString());
				else l_id=0;
				load_head();
			}
			catch(Exception ex){MessageBox.Show(ex.Message);}
		}

		private void find_Enter(object sender, System.EventArgs e)
		{
			find.Text="";
		}

		private void lydo_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");
		}

		private void baohanh_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");
		}

		private void tinhtrang_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter || e.KeyCode==Keys.Tab)
			{
				if (tinhtrang.SelectedIndex==-1 && tinhtrang.Items.Count>0) tinhtrang.SelectedIndex=0;
				SendKeys.Send("{Tab}");
			}
		}

		private void nguongoc_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter || e.KeyCode==Keys.Tab)
			{
				if (nguongoc.SelectedIndex==-1 && nguongoc.Items.Count>0) nguongoc.SelectedIndex=0;
				SendKeys.Send("{Tab}");
			}
		}

		private void namsx_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");
		}

		private void cuocvc_Validated(object sender, System.EventArgs e)
		{
			try
			{
				d_cuocvc=(cuocvc.Text!="")?decimal.Parse(cuocvc.Text):0;
				cuocvc.Text=d_cuocvc.ToString(format_sotien);
			}
			catch{}
			tinh_giatri();
		}

		private void chaythu_Validated(object sender, System.EventArgs e)
		{
			try
			{
				d_chaythu=(chaythu.Text!="")?decimal.Parse(chaythu.Text):0;
				chaythu.Text=d_chaythu.ToString(format_sotien);
			}
			catch{}
			tinh_giatri();
		}

		private void butKemtheo_Click(object sender, System.EventArgs e)
		{
			if (cmbSophieu.Items.Count==0) return;
			frmNhapct f=new frmNhapct(ttb,i_nhom,l_id,s_manhom,s_mmyy,i_userid);
			f.ShowDialog(this);
		}

		private void phieunhap()
		{
			if (dtct.Rows.Count==0) return;
			DataTable dttmp=dtct.Copy();
			if (bNhom_nx && ttb.Mabv_so!=701424)
			{
                sql = "select a.stt,a.mabd,b.ma,trim(b.ten)||' '||b.hamluong as ten,b.tenhc,b.dang,a.handung,a.losx,a.soluong,a.dongia,a.vat,a.sotien,a.sotien+a.sotien*a.vat/100+a.cuocvc+a.chaythu as sotienvat,a.giaban,c.ten as tenhang,d.ten as tennuoc,a.sl1,a.sl2,a.tyle,b.manhom,e.ten as tennhom,f.ten as noingoai,f.stt as sttnn ";
				sql+=" from ttb_nhapct a,"+user+".ttb_dmbd b,"+user+".ttb_dmhang c,"+user+".ttb_dmnuoc d,"+user+".ttb_dmnhom e,"+user+".ttb_nhomhang f ";
				sql+=" where a.mabd=b.id and b.mahang=c.id and b.manuoc=d.id and b.manhom=e.id and c.loai=f.id and a.id="+l_id;
				if (ttb.bInHangNuoc_Nhapxuat(i_nhom)) sql+=" order by f.stt,e.stt,a.stt";
				else sql+=" order by e.stt,a.stt";
				dttmp=ttb.get_data(sql).Tables[0];
			}
			r=ttb.getrowbyid(dtdmnx,"ma='"+madv.Text+"'");
			string c11=no.Text,c12=co.Text,_dc=r["diachi"].ToString().Trim(),_maso=r["masothue"].ToString().Trim();
			if (r==null)
			{
				MessageBox.Show("Nhà cung cấp không hợp lệ !",ttb.Msg);
				madv.Focus();
				return;
			}
			string tenfile=(ttb.Mabv_so==701424)?"ttb_phieunhap.rpt":(ttb.bInHangNuoc_Nhapxuat(i_nhom))?"ttb_phieunhap_ct_nhom.rpt":(bNhom_nx)?"ttb_phieunhap_nhom.rpt":"ttb_phieunhap.rpt";
			if (tenfile=="ttb_phieunhap.rpt")
			{
				if (c11.IndexOf(",")==-1) c11+=",";
				decimal st=0;
				string s12="NỢ :     ";
                sql = "select c.ma,sum(a.sotien+a.sotien*a.vat/100+a.cuocvc+a.chaythu) as sotienvat from ttb_nhapct a,";
				sql+=user+".ttb_dmbd b,"+user+".ttb_dmnhomkt c where a.mabd=b.id and b.sotk=c.id and a.id="+l_id+" group by c.ma";
                foreach (DataRow r1 in ttb.get_data(sql).Tables[0].Rows)
				{
					st=decimal.Parse(r1["sotienvat"].ToString());
					s12=s12+r1["ma"].ToString().Trim()+" :     "+st.ToString(format_sotien).Trim()+";      ";
				}
				c12=c12+","+s12;
			}
			if (chkIn.Checked)
			{
                //dtdmbd.DataSet.WriteXml("phieunhap.xml", XmlWriteMode.WriteSchema);
				frmReport f=new frmReport(ttb,dttmp,tenfile,cmbSophieu.Text,ngaysp.Text,c11,c12,nguoigiao.Text,sohd.Text,ngayhd.Text,tendv.Text,makho.Text,doiso.Doiso_Unicode(Convert.ToInt64(d_cothue).ToString()),_dc,_maso);
				f.ShowDialog();
			}
			else
			{
				ReportDocument oRpt=new ReportDocument();
				oRpt.Load("..\\..\\..\\report\\"+tenfile,OpenReportMethod.OpenReportByTempCopy);
				oRpt.SetDataSource(dttmp);
				oRpt.DataDefinition.FormulaFields["soyte"].Text="'"+ttb.Syte+"'";
				oRpt.DataDefinition.FormulaFields["benhvien"].Text="'"+ttb.Tenbv+"'";
				oRpt.DataDefinition.FormulaFields["c1"].Text="'"+cmbSophieu.Text+"'";
				oRpt.DataDefinition.FormulaFields["c2"].Text="'"+ngaysp.Text+"'";
				oRpt.DataDefinition.FormulaFields["c3"].Text="'"+c11+"'";
				oRpt.DataDefinition.FormulaFields["c4"].Text="'"+c12+"'";
				oRpt.DataDefinition.FormulaFields["c5"].Text="'"+nguoigiao.Text+"'";
				oRpt.DataDefinition.FormulaFields["c6"].Text="'"+sohd.Text+"'";
				oRpt.DataDefinition.FormulaFields["c7"].Text="'"+ngayhd.Text+"'";
				oRpt.DataDefinition.FormulaFields["c8"].Text="'"+tendv.Text+"'";
				oRpt.DataDefinition.FormulaFields["c9"].Text="'"+makho.Text+"'";
				oRpt.DataDefinition.FormulaFields["c10"].Text="'"+doiso.Doiso_Unicode(Convert.ToInt64(d_cothue).ToString())+"'";
				if (_dc!="") oRpt.DataDefinition.FormulaFields["c11"].Text="'"+_dc+"'";
				if (_maso!="") oRpt.DataDefinition.FormulaFields["c12"].Text="'"+_maso+"'";
				oRpt.DataDefinition.FormulaFields["giamdoc"].Text="'"+ttb.Giamdoc(i_nhom)+"'";
				oRpt.DataDefinition.FormulaFields["phutrach"].Text="'"+ttb.Phutrach(i_nhom)+"'";
				oRpt.DataDefinition.FormulaFields["thongke"].Text="'"+ttb.Thongke(i_nhom)+"'";
				oRpt.DataDefinition.FormulaFields["ketoan"].Text="'"+ttb.Ketoan(i_nhom)+"'";
				oRpt.DataDefinition.FormulaFields["thukho"].Text="'"+ttb.Thukho(i_nhom)+"'";
				oRpt.PrintOptions.PaperSize=PaperSize.DefaultPaperSize;
				oRpt.PrintOptions.PaperOrientation=PaperOrientation.Portrait;
				oRpt.PrintToPrinter(1,false,0,0);
                oRpt.Close(); oRpt.Dispose();
			}
		}

		private void indenghi()
		{
			if (dtct.Rows.Count==0) return;
			frmDenghi f1=new frmDenghi();
			f1.ShowDialog(this);
			if (!f1.ok) return;
			DataSet dsxml=new DataSet();
			DataSet dsdn=new DataSet();
			dsxml.ReadXml("..\\..\\..\\xml\\ttb_denghi.xml");
			dsdn.ReadXml("..\\..\\..\\xml\\ttb_denghict.xml");
			r=dsdn.Tables[0].NewRow();
			r["sohd"]=sohd.Text;
			r["ngayhd"]=ngayhd.Text;
			r["sophieu"]="1";
			r["ngaysp"]=ngaysp.Text;
			r["sotien"]=d_cothue;
			dsdn.Tables[0].Rows.Add(r);
			r=ttb.getrowbyid(dtdmnx,"ma='"+madv.Text+"'");
			if (r==null)
			{
				MessageBox.Show("Nhà cung cấp không hợp lệ !",ttb.Msg);
				madv.Focus();
				return;
			}
			string _dc=r["diachi"].ToString().Trim(),_maso=r["masothue"].ToString().Trim();
			if (chkIn.Checked)
			{
				frmReport f=new frmReport(ttb,dsdn.Tables[0],"ttb_denghi.rpt",dsxml.Tables[0].Rows[0]["KINHGUI"].ToString(),dsxml.Tables[0].Rows[0]["NGAY"].ToString(),dsxml.Tables[0].Rows[0]["DENGHI"].ToString(),dsxml.Tables[0].Rows[0]["BOPHAN"].ToString(),dsxml.Tables[0].Rows[0]["NOIDUNG"].ToString().Trim()+" "+tendv.Text.ToString().Trim().ToUpper(),dsxml.Tables[0].Rows[0]["KETOAN"].ToString(),dsxml.Tables[0].Rows[0]["GIAMDOC"].ToString(),no.Text,co.Text,doiso.Doiso_Unicode(Convert.ToInt64(d_cothue).ToString()),_dc,_maso);
				f.ShowDialog();
			}
			else
			{
				ReportDocument oRpt=new ReportDocument();
				oRpt.Load("..\\..\\..\\report\\ttb_denghi.rpt",OpenReportMethod.OpenReportByTempCopy);
				oRpt.SetDataSource(dsdn.Tables[0]);
				oRpt.DataDefinition.FormulaFields["soyte"].Text="'"+ttb.Syte+"'";
				oRpt.DataDefinition.FormulaFields["benhvien"].Text="'"+ttb.Tenbv+"'";
				oRpt.DataDefinition.FormulaFields["c1"].Text="'"+dsxml.Tables[0].Rows[0]["KINHGUI"].ToString()+"'";
				oRpt.DataDefinition.FormulaFields["c2"].Text="'"+dsxml.Tables[0].Rows[0]["NGAY"].ToString()+"'";
				oRpt.DataDefinition.FormulaFields["c3"].Text="'"+dsxml.Tables[0].Rows[0]["DENGHI"].ToString()+"'";
				oRpt.DataDefinition.FormulaFields["c4"].Text="'"+dsxml.Tables[0].Rows[0]["BOPHAN"].ToString()+"'";
				oRpt.DataDefinition.FormulaFields["c5"].Text="'"+dsxml.Tables[0].Rows[0]["NOIDUNG"].ToString().Trim()+" "+tendv.Text.ToString().Trim().ToUpper()+"'";
				oRpt.DataDefinition.FormulaFields["c6"].Text="'"+dsxml.Tables[0].Rows[0]["KETOAN"].ToString()+"'";
				oRpt.DataDefinition.FormulaFields["c7"].Text="'"+dsxml.Tables[0].Rows[0]["GIAMDOC"].ToString()+"'";
				oRpt.DataDefinition.FormulaFields["c8"].Text="'"+no.Text+"'";
				oRpt.DataDefinition.FormulaFields["c9"].Text="'"+co.Text+"'";
				oRpt.DataDefinition.FormulaFields["c10"].Text="'"+doiso.Doiso_Unicode(Convert.ToInt64(d_cothue).ToString())+"'";
				if (_dc!="") oRpt.DataDefinition.FormulaFields["c11"].Text="'"+_dc+"'";
				if (_maso!="") oRpt.DataDefinition.FormulaFields["c12"].Text="'"+_maso+"'";
				oRpt.DataDefinition.FormulaFields["giamdoc"].Text="'"+ttb.Giamdoc(i_nhom)+"'";
				oRpt.DataDefinition.FormulaFields["phutrach"].Text="'"+ttb.Phutrach(i_nhom)+"'";
				oRpt.DataDefinition.FormulaFields["thongke"].Text="'"+ttb.Thongke(i_nhom)+"'";
				oRpt.DataDefinition.FormulaFields["ketoan"].Text="'"+ttb.Ketoan(i_nhom)+"'";
				oRpt.DataDefinition.FormulaFields["thukho"].Text="'"+ttb.Thukho(i_nhom)+"'";
				oRpt.PrintOptions.PaperSize=PaperSize.DefaultPaperSize;
				oRpt.PrintOptions.PaperOrientation=PaperOrientation.Portrait;
				oRpt.PrintToPrinter(1,false,0,0);
                oRpt.Close(); oRpt.Dispose();
			}
		}

		private void bangiao()
		{
			if (dtct.Rows.Count==0) return;
			r=ttb.getrowbyid(dtdmnx,"ma='"+madv.Text+"'");
			if (r==null)
			{
				MessageBox.Show("Nhà cung cấp không hợp lệ !",ttb.Msg);
				madv.Focus();
				return;
			}
			string _dc=r["diachi"].ToString().Trim(),_maso=r["masothue"].ToString().Trim();
			frmBangiao f1=new frmBangiao(r["daidien"].ToString());
			f1.ShowDialog(this);
			if (!f1.ok) return;
			DataSet dsxml=new DataSet();
			dsxml.ReadXml("..\\..\\..\\xml\\ttb_bangiao.xml");
			if (chkIn.Checked)
			{
				frmReport f=new frmReport(ttb,dtct,"ttb_bangiao.rpt",dsxml.Tables[0].Rows[0]["NGAY"].ToString(),dsxml.Tables[0].Rows[0]["BENA"].ToString(),dsxml.Tables[0].Rows[0]["CVA"].ToString(),dsxml.Tables[0].Rows[0]["NGUOIGIAO"].ToString(),dsxml.Tables[0].Rows[0]["BENB"].ToString().Trim(),dsxml.Tables[0].Rows[0]["CVB"].ToString().Trim(),dsxml.Tables[0].Rows[0]["NGUOINHAN"].ToString().Trim(),dsxml.Tables[0].Rows[0]["BANGIAO"].ToString().Trim(),tendv.Text.ToString().Trim().ToUpper(),ngayhd.Text,_dc,_maso);
				f.ShowDialog();
			}
			else
			{
				ReportDocument oRpt=new ReportDocument();
				oRpt.Load("..\\..\\..\\report\\ttb_bangiao.rpt",OpenReportMethod.OpenReportByTempCopy);
				oRpt.SetDataSource(dtct);
				oRpt.DataDefinition.FormulaFields["soyte"].Text="'"+ttb.Syte+"'";
				oRpt.DataDefinition.FormulaFields["benhvien"].Text="'"+ttb.Tenbv+"'";
				oRpt.DataDefinition.FormulaFields["c1"].Text="'"+dsxml.Tables[0].Rows[0]["NGAY"].ToString()+"'";
				oRpt.DataDefinition.FormulaFields["c2"].Text="'"+dsxml.Tables[0].Rows[0]["BENA"].ToString()+"'";
				oRpt.DataDefinition.FormulaFields["c3"].Text="'"+dsxml.Tables[0].Rows[0]["CVA"].ToString()+"'";
				oRpt.DataDefinition.FormulaFields["c4"].Text="'"+dsxml.Tables[0].Rows[0]["NGUOIGIAO"].ToString()+"'";
				oRpt.DataDefinition.FormulaFields["c5"].Text="'"+dsxml.Tables[0].Rows[0]["BENB"].ToString().Trim()+" "+tendv.Text.ToString().Trim().ToUpper()+"'";
				oRpt.DataDefinition.FormulaFields["c6"].Text="'"+dsxml.Tables[0].Rows[0]["CVB"].ToString()+"'";
				oRpt.DataDefinition.FormulaFields["c7"].Text="'"+dsxml.Tables[0].Rows[0]["NGUOINHAN"].ToString()+"'";
				oRpt.DataDefinition.FormulaFields["c8"].Text="'"+dsxml.Tables[0].Rows[0]["BANGIAO"].ToString()+"'";
				oRpt.DataDefinition.FormulaFields["c9"].Text="'"+tendv.Text.ToString().Trim().ToUpper()+"'";
				oRpt.DataDefinition.FormulaFields["c10"].Text="'"+ngayhd.Text+"'";
				oRpt.DataDefinition.FormulaFields["diachi"].Text="'"+_dc+"'";
				oRpt.DataDefinition.FormulaFields["masothue"].Text="'"+_maso+"'";
				oRpt.DataDefinition.FormulaFields["giamdoc"].Text="'"+ttb.Giamdoc(i_nhom)+"'";
				oRpt.DataDefinition.FormulaFields["phutrach"].Text="'"+ttb.Phutrach(i_nhom)+"'";
				oRpt.DataDefinition.FormulaFields["thongke"].Text="'"+ttb.Thongke(i_nhom)+"'";
				oRpt.DataDefinition.FormulaFields["ketoan"].Text="'"+ttb.Ketoan(i_nhom)+"'";
				oRpt.DataDefinition.FormulaFields["thukho"].Text="'"+ttb.Thukho(i_nhom)+"'";
				oRpt.PrintOptions.PaperSize=PaperSize.DefaultPaperSize;
				oRpt.PrintOptions.PaperOrientation=PaperOrientation.Portrait;
				oRpt.PrintToPrinter(1,false,0,0);
                oRpt.Close(); oRpt.Dispose();
			}
		}

		private void giaonhan()
		{
			if (dtct.Rows.Count==0) return;
			frmGiaonhan f1=new frmGiaonhan(ttb);
			f1.ShowDialog(this);
			if (!f1.ok) return;
			sql="select a.stt,a.mabd,b.ma,trim(b.ten)||' '||b.hamluong as ten,b.tenhc,b.dang,a.handung,a.losx,"+
                " a.soluong,a.dongia,a.vat,a.sotien,round(a.sotien+a.sotien*a.vat/100,3)+cuocvc+chaythu as sotienvat,"+
                " a.giaban,a.giamua,c.ten as tenhang,d.ten as tennuoc,a.sl1,a.sl2,a.tyle,a.cuocvc,a.chaythu,a.namsx,"+
                " a.tailieu,a.baohanh,a.nguongoc,a.tinhtrang,a.sothe,a.giabancu,b.congsuat ";
            sql += " from " + user + ".ttb_nhapct a," + user + ".ttb_dmbd b," + user + ".ttb_dmhang c," + user + ".ttb_dmnuoc d " +
                " where a.mabd=b.id and b.mahang=c.id and b.manuoc=d.id and a.id="+l_id+" order by a.stt";
            DataSet ds = new DataSet();
            ds = ttb.get_data(sql);
            sql = "select a.stt,a.mabd,b.ma,trim(b.ten)||' '||b.hamluong as ten,b.tenhc,b.dang," +
                " a.soluong,a.sotien,c.ten as tenhang,d.ten as tennuoc";
            sql += " from " + user + ".ttb_nhapct2 a," + user + ".ttb_dmbd b," + user + ".ttb_dmhang c," + user + ".ttb_dmnuoc d " +
                " where a.mabd=b.id and b.mahang=c.id and b.manuoc=d.id and a.id=" + l_id + " order by a.stt";
            DataTable dttmp = ttb.get_data(sql).Tables[0];
            dttmp.TableName = "kemtheo";
            ds.Tables.Add(dttmp.Copy());
			DataSet dsxml=new DataSet();
			dsxml.ReadXml("..\\..\\..\\xml\\ttb_giaonhan.xml");
			if (chkIn.Checked)
			{
				frmReport f=new frmReport(ttb,ds,"ttb_giaonhan.rpt",dsxml.Tables[0].Rows[0]["NGAY"].ToString(),
                    dsxml.Tables[0].Rows[0]["SOQD"].ToString(),dsxml.Tables[0].Rows[0]["NGAYQD"].ToString(),
                    dsxml.Tables[0].Rows[0]["CUAQD"].ToString(),
                    dsxml.Tables[0].Rows[0]["HT1"].ToString().Trim()+"+"+dsxml.Tables[0].Rows[0]["CV1"].ToString().Trim(),
                    dsxml.Tables[0].Rows[0]["HT2"].ToString().Trim()+"+"+dsxml.Tables[0].Rows[0]["CV2"].ToString().Trim(),
                    dsxml.Tables[0].Rows[0]["HT3"].ToString().Trim()+"+"+dsxml.Tables[0].Rows[0]["CV3"].ToString().Trim(),
                    dsxml.Tables[0].Rows[0]["DD"].ToString().Trim(),ngayhd.Text,sophieu.Text,no.Text,co.Text);
				f.ShowDialog();
			}
			else
			{
				ReportDocument oRpt=new ReportDocument();
				oRpt.Load("..\\..\\..\\report\\ttb_giaonhan.rpt",OpenReportMethod.OpenReportByTempCopy);
                oRpt.SetDataSource(ds);
				oRpt.DataDefinition.FormulaFields["soyte"].Text="'"+ttb.Syte+"'";
				oRpt.DataDefinition.FormulaFields["benhvien"].Text="'"+ttb.Tenbv+"'";
				oRpt.DataDefinition.FormulaFields["c1"].Text="'"+dsxml.Tables[0].Rows[0]["NGAY"].ToString()+"'";
				oRpt.DataDefinition.FormulaFields["c2"].Text="'"+dsxml.Tables[0].Rows[0]["SOQD"].ToString()+"'";
				oRpt.DataDefinition.FormulaFields["c3"].Text="'"+dsxml.Tables[0].Rows[0]["NGAYQD"].ToString()+"'";
				oRpt.DataDefinition.FormulaFields["c4"].Text="'"+dsxml.Tables[0].Rows[0]["CUAQD"].ToString()+"'";
				oRpt.DataDefinition.FormulaFields["c5"].Text="'"+dsxml.Tables[0].Rows[0]["HT1"].ToString().Trim()+" "+tendv.Text.ToString().Trim().ToUpper()+"'";
				oRpt.DataDefinition.FormulaFields["c6"].Text="'"+dsxml.Tables[0].Rows[0]["CV1"].ToString()+"'";
				oRpt.DataDefinition.FormulaFields["c7"].Text="'"+dsxml.Tables[0].Rows[0]["HT2"].ToString()+"'";
				oRpt.DataDefinition.FormulaFields["c8"].Text="'"+dsxml.Tables[0].Rows[0]["CV2"].ToString()+"'";
				oRpt.DataDefinition.FormulaFields["c9"].Text="'"+dsxml.Tables[0].Rows[0]["HT3"].ToString()+"'";
				oRpt.DataDefinition.FormulaFields["c10"].Text="'"+dsxml.Tables[0].Rows[0]["CV3"].ToString()+"'";
				oRpt.DataDefinition.FormulaFields["diachi"].Text="'"+dsxml.Tables[0].Rows[0]["DD"].ToString()+"'";
				oRpt.DataDefinition.FormulaFields["masothue"].Text="'"+ngayhd.Text+"'";
				oRpt.DataDefinition.FormulaFields["giamdoc"].Text="'"+ttb.Giamdoc(i_nhom)+"'";
				oRpt.DataDefinition.FormulaFields["phutrach"].Text="'"+ttb.Phutrach(i_nhom)+"'";
				oRpt.DataDefinition.FormulaFields["thongke"].Text="'"+ttb.Thongke(i_nhom)+"'";
				oRpt.DataDefinition.FormulaFields["ketoan"].Text="'"+ttb.Ketoan(i_nhom)+"'";
				oRpt.DataDefinition.FormulaFields["thukho"].Text="'"+ttb.Thukho(i_nhom)+"'";
				oRpt.PrintOptions.PaperSize=PaperSize.DefaultPaperSize;
				oRpt.PrintOptions.PaperOrientation=PaperOrientation.Portrait;
				oRpt.PrintToPrinter(1,false,0,0);
                oRpt.Close(); oRpt.Dispose();
			}
		}
	}
}
