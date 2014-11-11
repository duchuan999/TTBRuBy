using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Data;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;
using System.Security.AccessControl;
using Medisoft2009.Usercontrol;
using LibTTB;

namespace TTB
{
	/// <summary>
	/// Summary description for frmDm.
	/// </summary>
	public class frmDmTTB : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button butKetthuc;
        private LibTTB.AccessData ttb = new LibTTB.AccessData();
		private DataRow r;
		private DataTable dt=new DataTable();
		private DataTable dtnhom=new DataTable();
		private DataTable dtloai=new DataTable();
		private DataTable dthang=new DataTable();
		private DataTable dtnuoc=new DataTable();
		private DataTable dtnhombo=new DataTable();
		private DataTable dtnhomin=new DataTable();
		private DataTable dtsotk=new DataTable();
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button butMoi;
		private System.Windows.Forms.Button butSua;
		private System.Windows.Forms.Button butLuu;
		private System.Windows.Forms.Button butBoqua;
		private System.Windows.Forms.Button butHuy;
		private decimal l_id;
		private int i_nhom,iNhom,iLoai,iHang,iNuoc,iNhomin,iNhombo,iSotk,itable,i_userid;
		private System.Windows.Forms.TextBox ten;
		private System.Windows.Forms.TextBox ma;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox hamluong;
		private System.Windows.Forms.TextBox dang;
		private System.Windows.Forms.TextBox manhom;
		private System.Windows.Forms.TextBox maloai;
		private System.Windows.Forms.TextBox mahang;
		private System.Windows.Forms.TextBox manuoc;
		private System.Windows.Forms.TextBox sotk;
		private string sql,s_mmyy,s_manhom,user,hostPicture;
		private bool bAdmin;
		private List listDang;
		private List listLoai;
		private List listHang;
		private List listNuoc;
		private List listNhombo;
		private List listSotk;
		private List listNhom;
		private System.Windows.Forms.Label lNhombo;
		private System.Windows.Forms.Label lSotk;
		private System.Windows.Forms.Label lPhanloai;
		private System.Windows.Forms.Label lHang;
		private System.Windows.Forms.TextBox nhombo;
		private System.Windows.Forms.Label lNuoc;
		private System.Windows.Forms.Button butIn;
		private Medisoft2009.Usercontrol.MaskedTextBox sodk;
		private Medisoft2009.Usercontrol.MaskedTextBox sltoithieu;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lsltoithieu;
		private Medisoft2009.Usercontrol.MaskedTextBox tyle;
		private System.Windows.Forms.Label ltyle;
		private System.Windows.Forms.Label lphantram;
		private System.Windows.Forms.NumericUpDown stt;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button butSTT;
		private System.Windows.Forms.TextBox nhomin;
		private List listNhomin;
		private System.Windows.Forms.Label lNhomin;
		private System.Windows.Forms.TextBox find;
		private System.Windows.Forms.Button butNo;
		private System.Windows.Forms.TextBox duongdung;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox chkBHYT;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox hinh;
		private System.Windows.Forms.Button butHinh;
		private System.Windows.Forms.Label label10;
        private CheckBox hide;
        private Panel panel1;
        private PictureBox pic;
        private byte[] image;
        //private System.IO.MemoryStream memo;
        private System.IO.FileStream fstr;
        private Bitmap map;
        private Button butxoahinh;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmDmTTB(LibTTB.AccessData acc,int nhom,string mmyy,bool admin,string _manhom,int userid)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			ttb=acc;	i_nhom=nhom;s_manhom=_manhom;
            bAdmin = admin; s_mmyy = mmyy; i_userid = userid;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDmTTB));
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.butKetthuc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ten = new System.Windows.Forms.TextBox();
            this.butMoi = new System.Windows.Forms.Button();
            this.butSua = new System.Windows.Forms.Button();
            this.butLuu = new System.Windows.Forms.Button();
            this.butBoqua = new System.Windows.Forms.Button();
            this.butHuy = new System.Windows.Forms.Button();
            this.ma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lNhombo = new System.Windows.Forms.Label();
            this.lSotk = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lPhanloai = new System.Windows.Forms.Label();
            this.lHang = new System.Windows.Forms.Label();
            this.lNuoc = new System.Windows.Forms.Label();
            this.hamluong = new System.Windows.Forms.TextBox();
            this.dang = new System.Windows.Forms.TextBox();
            this.manhom = new System.Windows.Forms.TextBox();
            this.maloai = new System.Windows.Forms.TextBox();
            this.mahang = new System.Windows.Forms.TextBox();
            this.manuoc = new System.Windows.Forms.TextBox();
            this.nhombo = new System.Windows.Forms.TextBox();
            this.sotk = new System.Windows.Forms.TextBox();
            this.listDang = new Medisoft2009.Usercontrol.List();
            this.listLoai = new Medisoft2009.Usercontrol.List();
            this.listHang = new Medisoft2009.Usercontrol.List();
            this.listNuoc = new Medisoft2009.Usercontrol.List();
            this.listNhombo = new Medisoft2009.Usercontrol.List();
            this.listSotk = new Medisoft2009.Usercontrol.List();
            this.listNhom = new Medisoft2009.Usercontrol.List();
            this.butIn = new System.Windows.Forms.Button();
            this.sodk = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.sltoithieu = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lsltoithieu = new System.Windows.Forms.Label();
            this.tyle = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.ltyle = new System.Windows.Forms.Label();
            this.lphantram = new System.Windows.Forms.Label();
            this.stt = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.butSTT = new System.Windows.Forms.Button();
            this.lNhomin = new System.Windows.Forms.Label();
            this.nhomin = new System.Windows.Forms.TextBox();
            this.listNhomin = new Medisoft2009.Usercontrol.List();
            this.find = new System.Windows.Forms.TextBox();
            this.butNo = new System.Windows.Forms.Button();
            this.duongdung = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkBHYT = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hinh = new System.Windows.Forms.TextBox();
            this.butHinh = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.hide = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.butxoahinh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stt)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
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
            this.dataGrid1.Location = new System.Drawing.Point(4, 8);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro;
            this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.RowHeaderWidth = 10;
            this.dataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue;
            this.dataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid1.Size = new System.Drawing.Size(784, 376);
            this.dataGrid1.TabIndex = 19;
            this.dataGrid1.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
            // 
            // butKetthuc
            // 
            this.butKetthuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butKetthuc.Image = ((System.Drawing.Image)(resources.GetObject("butKetthuc.Image")));
            this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butKetthuc.Location = new System.Drawing.Point(501, 501);
            this.butKetthuc.Name = "butKetthuc";
            this.butKetthuc.Size = new System.Drawing.Size(73, 25);
            this.butKetthuc.TabIndex = 25;
            this.butKetthuc.Text = "     &Kết thúc";
            this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Location = new System.Drawing.Point(103, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tên :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ten
            // 
            this.ten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ten.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ten.Enabled = false;
            this.ten.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ten.Location = new System.Drawing.Point(136, 388);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(280, 21);
            this.ten.TabIndex = 1;
            this.ten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ten_KeyDown);
            // 
            // butMoi
            // 
            this.butMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butMoi.Image = ((System.Drawing.Image)(resources.GetObject("butMoi.Image")));
            this.butMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butMoi.Location = new System.Drawing.Point(135, 501);
            this.butMoi.Name = "butMoi";
            this.butMoi.Size = new System.Drawing.Size(60, 25);
            this.butMoi.TabIndex = 20;
            this.butMoi.Text = "     &Mới";
            this.butMoi.Click += new System.EventHandler(this.butMoi_Click);
            // 
            // butSua
            // 
            this.butSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butSua.Image = ((System.Drawing.Image)(resources.GetObject("butSua.Image")));
            this.butSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butSua.Location = new System.Drawing.Point(195, 501);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(60, 25);
            this.butSua.TabIndex = 21;
            this.butSua.Text = "     &Sửa";
            this.butSua.Click += new System.EventHandler(this.butSua_Click);
            // 
            // butLuu
            // 
            this.butLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butLuu.Enabled = false;
            this.butLuu.Image = ((System.Drawing.Image)(resources.GetObject("butLuu.Image")));
            this.butLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butLuu.Location = new System.Drawing.Point(255, 501);
            this.butLuu.Name = "butLuu";
            this.butLuu.Size = new System.Drawing.Size(60, 25);
            this.butLuu.TabIndex = 18;
            this.butLuu.Text = "     &Lưu";
            this.butLuu.Click += new System.EventHandler(this.butLuu_Click);
            // 
            // butBoqua
            // 
            this.butBoqua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butBoqua.Enabled = false;
            this.butBoqua.Image = ((System.Drawing.Image)(resources.GetObject("butBoqua.Image")));
            this.butBoqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butBoqua.Location = new System.Drawing.Point(315, 501);
            this.butBoqua.Name = "butBoqua";
            this.butBoqua.Size = new System.Drawing.Size(66, 25);
            this.butBoqua.TabIndex = 19;
            this.butBoqua.Text = "     &Bỏ qua";
            this.butBoqua.Click += new System.EventHandler(this.butBoqua_Click);
            // 
            // butHuy
            // 
            this.butHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butHuy.Image = ((System.Drawing.Image)(resources.GetObject("butHuy.Image")));
            this.butHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butHuy.Location = new System.Drawing.Point(381, 501);
            this.butHuy.Name = "butHuy";
            this.butHuy.Size = new System.Drawing.Size(60, 25);
            this.butHuy.TabIndex = 22;
            this.butHuy.Text = "      &Hủy";
            this.butHuy.Click += new System.EventHandler(this.butHuy_Click);
            // 
            // ma
            // 
            this.ma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ma.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ma.Enabled = false;
            this.ma.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ma.Location = new System.Drawing.Point(45, 388);
            this.ma.MaxLength = 10;
            this.ma.Name = "ma";
            this.ma.Size = new System.Drawing.Size(60, 21);
            this.ma.TabIndex = 0;
            this.ma.Validated += new System.EventHandler(this.ma_Validated);
            this.ma.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ma_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Location = new System.Drawing.Point(8, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Location = new System.Drawing.Point(-8, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Nhóm :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lNhombo
            // 
            this.lNhombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lNhombo.Location = new System.Drawing.Point(194, 431);
            this.lNhombo.Name = "lNhombo";
            this.lNhombo.Size = new System.Drawing.Size(87, 23);
            this.lNhombo.TabIndex = 29;
            this.lNhombo.Text = "Nhóm báo cáo :";
            this.lNhombo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSotk
            // 
            this.lSotk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lSotk.Location = new System.Drawing.Point(381, 454);
            this.lSotk.Name = "lSotk";
            this.lSotk.Size = new System.Drawing.Size(88, 23);
            this.lSotk.TabIndex = 31;
            this.lSotk.Text = "Nhóm kế toán :";
            this.lSotk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Location = new System.Drawing.Point(522, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 23);
            this.label8.TabIndex = 35;
            this.label8.Text = "ĐVT :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Location = new System.Drawing.Point(387, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 23);
            this.label9.TabIndex = 36;
            this.label9.Text = "Model :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lPhanloai
            // 
            this.lPhanloai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lPhanloai.Location = new System.Drawing.Point(196, 409);
            this.lPhanloai.Name = "lPhanloai";
            this.lPhanloai.Size = new System.Drawing.Size(58, 23);
            this.lPhanloai.TabIndex = 37;
            this.lPhanloai.Text = "Phân loại :";
            this.lPhanloai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lHang
            // 
            this.lHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lHang.Location = new System.Drawing.Point(413, 409);
            this.lHang.Name = "lHang";
            this.lHang.Size = new System.Drawing.Size(44, 23);
            this.lHang.TabIndex = 38;
            this.lHang.Text = "Hãng :";
            this.lHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lNuoc
            // 
            this.lNuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lNuoc.Location = new System.Drawing.Point(-5, 432);
            this.lNuoc.Name = "lNuoc";
            this.lNuoc.Size = new System.Drawing.Size(43, 23);
            this.lNuoc.TabIndex = 39;
            this.lNuoc.Text = "Nước :";
            this.lNuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hamluong
            // 
            this.hamluong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.hamluong.BackColor = System.Drawing.SystemColors.HighlightText;
            this.hamluong.Enabled = false;
            this.hamluong.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hamluong.Location = new System.Drawing.Point(470, 388);
            this.hamluong.Name = "hamluong";
            this.hamluong.Size = new System.Drawing.Size(56, 21);
            this.hamluong.TabIndex = 2;
            this.hamluong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hamluong_KeyDown);
            // 
            // dang
            // 
            this.dang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dang.BackColor = System.Drawing.SystemColors.HighlightText;
            this.dang.Enabled = false;
            this.dang.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dang.Location = new System.Drawing.Point(560, 388);
            this.dang.Name = "dang";
            this.dang.Size = new System.Drawing.Size(46, 21);
            this.dang.TabIndex = 3;
            this.dang.TextChanged += new System.EventHandler(this.dang_TextChanged);
            this.dang.Validated += new System.EventHandler(this.dang_Validated);
            this.dang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dang_KeyDown);
            // 
            // manhom
            // 
            this.manhom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.manhom.BackColor = System.Drawing.SystemColors.HighlightText;
            this.manhom.Enabled = false;
            this.manhom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manhom.Location = new System.Drawing.Point(45, 410);
            this.manhom.Name = "manhom";
            this.manhom.Size = new System.Drawing.Size(152, 21);
            this.manhom.TabIndex = 5;
            this.manhom.TextChanged += new System.EventHandler(this.manhom_TextChanged);
            this.manhom.Validated += new System.EventHandler(this.manhom_Validated);
            this.manhom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.manhom_KeyDown);
            // 
            // maloai
            // 
            this.maloai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.maloai.BackColor = System.Drawing.SystemColors.HighlightText;
            this.maloai.Enabled = false;
            this.maloai.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maloai.Location = new System.Drawing.Point(280, 410);
            this.maloai.Name = "maloai";
            this.maloai.Size = new System.Drawing.Size(136, 21);
            this.maloai.TabIndex = 6;
            this.maloai.TextChanged += new System.EventHandler(this.maloai_TextChanged);
            this.maloai.Validated += new System.EventHandler(this.maloai_Validated);
            this.maloai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maloai_KeyDown);
            // 
            // mahang
            // 
            this.mahang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mahang.BackColor = System.Drawing.SystemColors.HighlightText;
            this.mahang.Enabled = false;
            this.mahang.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mahang.Location = new System.Drawing.Point(470, 410);
            this.mahang.Name = "mahang";
            this.mahang.Size = new System.Drawing.Size(179, 21);
            this.mahang.TabIndex = 7;
            this.mahang.TextChanged += new System.EventHandler(this.mahang_TextChanged);
            this.mahang.Validated += new System.EventHandler(this.mahang_Validated);
            this.mahang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mahang_KeyDown);
            // 
            // manuoc
            // 
            this.manuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.manuoc.BackColor = System.Drawing.SystemColors.HighlightText;
            this.manuoc.Enabled = false;
            this.manuoc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manuoc.Location = new System.Drawing.Point(45, 432);
            this.manuoc.Name = "manuoc";
            this.manuoc.Size = new System.Drawing.Size(152, 21);
            this.manuoc.TabIndex = 8;
            this.manuoc.TextChanged += new System.EventHandler(this.manuoc_TextChanged);
            this.manuoc.Validated += new System.EventHandler(this.manuoc_Validated);
            this.manuoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.manuoc_KeyDown);
            // 
            // nhombo
            // 
            this.nhombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nhombo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.nhombo.Enabled = false;
            this.nhombo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhombo.Location = new System.Drawing.Point(280, 432);
            this.nhombo.Name = "nhombo";
            this.nhombo.Size = new System.Drawing.Size(136, 21);
            this.nhombo.TabIndex = 9;
            this.nhombo.TextChanged += new System.EventHandler(this.nhombo_TextChanged);
            this.nhombo.Validated += new System.EventHandler(this.nhombo_Validated);
            this.nhombo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nhombo_KeyDown);
            // 
            // sotk
            // 
            this.sotk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sotk.BackColor = System.Drawing.SystemColors.HighlightText;
            this.sotk.Enabled = false;
            this.sotk.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sotk.Location = new System.Drawing.Point(470, 455);
            this.sotk.Name = "sotk";
            this.sotk.Size = new System.Drawing.Size(179, 21);
            this.sotk.TabIndex = 13;
            this.sotk.TextChanged += new System.EventHandler(this.sotk_TextChanged);
            this.sotk.Validated += new System.EventHandler(this.sotk_Validated);
            this.sotk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sotk_KeyDown);
            // 
            // listDang
            // 
            this.listDang.BackColor = System.Drawing.SystemColors.Info;
            this.listDang.ColumnCount = 0;
            this.listDang.Location = new System.Drawing.Point(612, 555);
            this.listDang.MatchBufferTimeOut = 1000;
            this.listDang.MatchEntryStyle = Medisoft2009.Usercontrol.MatchEntryStyle.FirstLetterInsensitive;
            this.listDang.Name = "listDang";
            this.listDang.Size = new System.Drawing.Size(75, 17);
            this.listDang.TabIndex = 43;
            this.listDang.TextIndex = -1;
            this.listDang.TextMember = null;
            this.listDang.ValueIndex = -1;
            this.listDang.Visible = false;
            // 
            // listLoai
            // 
            this.listLoai.BackColor = System.Drawing.SystemColors.Info;
            this.listLoai.ColumnCount = 0;
            this.listLoai.Location = new System.Drawing.Point(176, 555);
            this.listLoai.MatchBufferTimeOut = 1000;
            this.listLoai.MatchEntryStyle = Medisoft2009.Usercontrol.MatchEntryStyle.FirstLetterInsensitive;
            this.listLoai.Name = "listLoai";
            this.listLoai.Size = new System.Drawing.Size(75, 17);
            this.listLoai.TabIndex = 44;
            this.listLoai.TextIndex = -1;
            this.listLoai.TextMember = null;
            this.listLoai.ValueIndex = -1;
            this.listLoai.Visible = false;
            // 
            // listHang
            // 
            this.listHang.BackColor = System.Drawing.SystemColors.Info;
            this.listHang.ColumnCount = 0;
            this.listHang.Location = new System.Drawing.Point(268, 555);
            this.listHang.MatchBufferTimeOut = 1000;
            this.listHang.MatchEntryStyle = Medisoft2009.Usercontrol.MatchEntryStyle.FirstLetterInsensitive;
            this.listHang.Name = "listHang";
            this.listHang.Size = new System.Drawing.Size(75, 17);
            this.listHang.TabIndex = 45;
            this.listHang.TextIndex = -1;
            this.listHang.TextMember = null;
            this.listHang.ValueIndex = -1;
            this.listHang.Visible = false;
            // 
            // listNuoc
            // 
            this.listNuoc.BackColor = System.Drawing.SystemColors.Info;
            this.listNuoc.ColumnCount = 0;
            this.listNuoc.Location = new System.Drawing.Point(354, 555);
            this.listNuoc.MatchBufferTimeOut = 1000;
            this.listNuoc.MatchEntryStyle = Medisoft2009.Usercontrol.MatchEntryStyle.FirstLetterInsensitive;
            this.listNuoc.Name = "listNuoc";
            this.listNuoc.Size = new System.Drawing.Size(75, 17);
            this.listNuoc.TabIndex = 46;
            this.listNuoc.TextIndex = -1;
            this.listNuoc.TextMember = null;
            this.listNuoc.ValueIndex = -1;
            this.listNuoc.Visible = false;
            // 
            // listNhombo
            // 
            this.listNhombo.BackColor = System.Drawing.SystemColors.Info;
            this.listNhombo.ColumnCount = 0;
            this.listNhombo.Location = new System.Drawing.Point(440, 555);
            this.listNhombo.MatchBufferTimeOut = 1000;
            this.listNhombo.MatchEntryStyle = Medisoft2009.Usercontrol.MatchEntryStyle.FirstLetterInsensitive;
            this.listNhombo.Name = "listNhombo";
            this.listNhombo.Size = new System.Drawing.Size(75, 17);
            this.listNhombo.TabIndex = 47;
            this.listNhombo.TextIndex = -1;
            this.listNhombo.TextMember = null;
            this.listNhombo.ValueIndex = -1;
            this.listNhombo.Visible = false;
            // 
            // listSotk
            // 
            this.listSotk.BackColor = System.Drawing.SystemColors.Info;
            this.listSotk.ColumnCount = 0;
            this.listSotk.Location = new System.Drawing.Point(526, 555);
            this.listSotk.MatchBufferTimeOut = 1000;
            this.listSotk.MatchEntryStyle = Medisoft2009.Usercontrol.MatchEntryStyle.FirstLetterInsensitive;
            this.listSotk.Name = "listSotk";
            this.listSotk.Size = new System.Drawing.Size(75, 17);
            this.listSotk.TabIndex = 48;
            this.listSotk.TextIndex = -1;
            this.listSotk.TextMember = null;
            this.listSotk.ValueIndex = -1;
            this.listSotk.Visible = false;
            // 
            // listNhom
            // 
            this.listNhom.BackColor = System.Drawing.SystemColors.Info;
            this.listNhom.ColumnCount = 0;
            this.listNhom.Location = new System.Drawing.Point(96, 555);
            this.listNhom.MatchBufferTimeOut = 1000;
            this.listNhom.MatchEntryStyle = Medisoft2009.Usercontrol.MatchEntryStyle.FirstLetterInsensitive;
            this.listNhom.Name = "listNhom";
            this.listNhom.Size = new System.Drawing.Size(75, 17);
            this.listNhom.TabIndex = 49;
            this.listNhom.TextIndex = -1;
            this.listNhom.TextMember = null;
            this.listNhom.ValueIndex = -1;
            this.listNhom.Visible = false;
            // 
            // butIn
            // 
            this.butIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butIn.Image = ((System.Drawing.Image)(resources.GetObject("butIn.Image")));
            this.butIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butIn.Location = new System.Drawing.Point(441, 501);
            this.butIn.Name = "butIn";
            this.butIn.Size = new System.Drawing.Size(60, 25);
            this.butIn.TabIndex = 23;
            this.butIn.Text = "   &In";
            this.butIn.Click += new System.EventHandler(this.butIn_Click);
            // 
            // sodk
            // 
            this.sodk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sodk.BackColor = System.Drawing.SystemColors.HighlightText;
            this.sodk.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.sodk.Enabled = false;
            this.sodk.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sodk.Location = new System.Drawing.Point(45, 477);
            this.sodk.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.sodk.Name = "sodk";
            this.sodk.Size = new System.Drawing.Size(349, 21);
            this.sodk.TabIndex = 14;
            // 
            // sltoithieu
            // 
            this.sltoithieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sltoithieu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.sltoithieu.Enabled = false;
            this.sltoithieu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sltoithieu.Location = new System.Drawing.Point(470, 478);
            this.sltoithieu.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.Digit;
            this.sltoithieu.Name = "sltoithieu";
            this.sltoithieu.Size = new System.Drawing.Size(48, 21);
            this.sltoithieu.TabIndex = 16;
            this.sltoithieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sltoithieu.Validated += new System.EventHandler(this.sltoithieu_Validated);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.Location = new System.Drawing.Point(-8, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 53;
            this.label5.Text = "Số hiệu :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lsltoithieu
            // 
            this.lsltoithieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lsltoithieu.Location = new System.Drawing.Point(389, 475);
            this.lsltoithieu.Name = "lsltoithieu";
            this.lsltoithieu.Size = new System.Drawing.Size(80, 23);
            this.lsltoithieu.TabIndex = 54;
            this.lsltoithieu.Text = "Tồn tối thiểu :";
            this.lsltoithieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tyle
            // 
            this.tyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tyle.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tyle.Enabled = false;
            this.tyle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tyle.Location = new System.Drawing.Point(280, 455);
            this.tyle.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.Decimal;
            this.tyle.Name = "tyle";
            this.tyle.Size = new System.Drawing.Size(48, 21);
            this.tyle.TabIndex = 12;
            this.tyle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tyle.Validated += new System.EventHandler(this.tyle_Validated);
            // 
            // ltyle
            // 
            this.ltyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ltyle.Location = new System.Drawing.Point(185, 454);
            this.ltyle.Name = "ltyle";
            this.ltyle.Size = new System.Drawing.Size(96, 23);
            this.ltyle.TabIndex = 57;
            this.ltyle.Text = "Tỷ lệ khấu hao :";
            this.ltyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lphantram
            // 
            this.lphantram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lphantram.Location = new System.Drawing.Point(339, 454);
            this.lphantram.Name = "lphantram";
            this.lphantram.Size = new System.Drawing.Size(16, 23);
            this.lphantram.TabIndex = 58;
            this.lphantram.Text = "%";
            this.lphantram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stt
            // 
            this.stt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.stt.Enabled = false;
            this.stt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stt.Location = new System.Drawing.Point(45, 455);
            this.stt.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.stt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stt.Name = "stt";
            this.stt.Size = new System.Drawing.Size(52, 21);
            this.stt.TabIndex = 11;
            this.stt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.duongdung_KeyDown);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.Location = new System.Drawing.Point(-13, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 62;
            this.label6.Text = "Stt :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // butSTT
            // 
            this.butSTT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butSTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butSTT.Location = new System.Drawing.Point(4, 528);
            this.butSTT.Name = "butSTT";
            this.butSTT.Size = new System.Drawing.Size(60, 25);
            this.butSTT.TabIndex = 24;
            this.butSTT.Text = "Stt";
            this.butSTT.Visible = false;
            this.butSTT.Click += new System.EventHandler(this.butSTT_Click);
            // 
            // lNhomin
            // 
            this.lNhomin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lNhomin.Location = new System.Drawing.Point(414, 430);
            this.lNhomin.Name = "lNhomin";
            this.lNhomin.Size = new System.Drawing.Size(56, 23);
            this.lNhomin.TabIndex = 64;
            this.lNhomin.Text = "Nhóm in :";
            this.lNhomin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nhomin
            // 
            this.nhomin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nhomin.BackColor = System.Drawing.SystemColors.HighlightText;
            this.nhomin.Enabled = false;
            this.nhomin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhomin.Location = new System.Drawing.Point(470, 432);
            this.nhomin.Name = "nhomin";
            this.nhomin.Size = new System.Drawing.Size(179, 21);
            this.nhomin.TabIndex = 10;
            this.nhomin.TextChanged += new System.EventHandler(this.nhomin_TextChanged);
            this.nhomin.Validated += new System.EventHandler(this.nhomin_Validated);
            this.nhomin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nhomin_KeyDown);
            // 
            // listNhomin
            // 
            this.listNhomin.BackColor = System.Drawing.SystemColors.Info;
            this.listNhomin.ColumnCount = 0;
            this.listNhomin.Location = new System.Drawing.Point(16, 555);
            this.listNhomin.MatchBufferTimeOut = 1000;
            this.listNhomin.MatchEntryStyle = Medisoft2009.Usercontrol.MatchEntryStyle.FirstLetterInsensitive;
            this.listNhomin.Name = "listNhomin";
            this.listNhomin.Size = new System.Drawing.Size(75, 17);
            this.listNhomin.TabIndex = 66;
            this.listNhomin.TextIndex = -1;
            this.listNhomin.TextMember = null;
            this.listNhomin.ValueIndex = -1;
            this.listNhomin.Visible = false;
            // 
            // find
            // 
            this.find.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.find.BackColor = System.Drawing.SystemColors.HighlightText;
            this.find.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find.Location = new System.Drawing.Point(4, 4);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(784, 21);
            this.find.TabIndex = 67;
            this.find.Text = "Tìm kiếm";
            this.find.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.find.TextChanged += new System.EventHandler(this.find_TextChanged);
            this.find.Enter += new System.EventHandler(this.find_Enter);
            // 
            // butNo
            // 
            this.butNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butNo.Enabled = false;
            this.butNo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNo.Location = new System.Drawing.Point(40, 501);
            this.butNo.Name = "butNo";
            this.butNo.Size = new System.Drawing.Size(23, 21);
            this.butNo.TabIndex = 71;
            this.butNo.Text = "...";
            this.butNo.Visible = false;
            this.butNo.Click += new System.EventHandler(this.butNo_Click);
            // 
            // duongdung
            // 
            this.duongdung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.duongdung.BackColor = System.Drawing.SystemColors.HighlightText;
            this.duongdung.Enabled = false;
            this.duongdung.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duongdung.Location = new System.Drawing.Point(664, 388);
            this.duongdung.Name = "duongdung";
            this.duongdung.Size = new System.Drawing.Size(120, 21);
            this.duongdung.TabIndex = 4;
            this.duongdung.KeyDown += new System.Windows.Forms.KeyEventHandler(this.duongdung_KeyDown);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(602, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 70;
            this.label7.Text = "Công suất :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkBHYT
            // 
            this.chkBHYT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkBHYT.Checked = true;
            this.chkBHYT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBHYT.Enabled = false;
            this.chkBHYT.Location = new System.Drawing.Point(684, 555);
            this.chkBHYT.Name = "chkBHYT";
            this.chkBHYT.Size = new System.Drawing.Size(104, 24);
            this.chkBHYT.TabIndex = 15;
            this.chkBHYT.Text = "Theo dõi tài sản";
            this.chkBHYT.Visible = false;
            this.chkBHYT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.duongdung_KeyDown);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(23, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 23);
            this.label3.TabIndex = 72;
            this.label3.Text = "Hình :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Visible = false;
            // 
            // hinh
            // 
            this.hinh.BackColor = System.Drawing.SystemColors.HighlightText;
            this.hinh.Enabled = false;
            this.hinh.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hinh.Location = new System.Drawing.Point(69, 531);
            this.hinh.Name = "hinh";
            this.hinh.Size = new System.Drawing.Size(560, 21);
            this.hinh.TabIndex = 73;
            this.hinh.Visible = false;
            // 
            // butHinh
            // 
            this.butHinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butHinh.Enabled = false;
            this.butHinh.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butHinh.Image = ((System.Drawing.Image)(resources.GetObject("butHinh.Image")));
            this.butHinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butHinh.Location = new System.Drawing.Point(652, 528);
            this.butHinh.Name = "butHinh";
            this.butHinh.Size = new System.Drawing.Size(80, 24);
            this.butHinh.TabIndex = 74;
            this.butHinh.Text = "   Chọn hình";
            this.butHinh.Click += new System.EventHandler(this.butHinh_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.Location = new System.Drawing.Point(-5, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 23);
            this.label10.TabIndex = 75;
            this.label10.Text = "Mã :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hide
            // 
            this.hide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hide.Enabled = false;
            this.hide.Location = new System.Drawing.Point(521, 477);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(104, 22);
            this.hide.TabIndex = 17;
            this.hide.Text = "Không nhập mới";
            this.hide.KeyDown += new System.Windows.Forms.KeyEventHandler(this.duongdung_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pic);
            this.panel1.Location = new System.Drawing.Point(652, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 116);
            this.panel1.TabIndex = 257;
            // 
            // pic
            // 
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(132, 116);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 254;
            this.pic.TabStop = false;
            // 
            // butxoahinh
            // 
            this.butxoahinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butxoahinh.Enabled = false;
            this.butxoahinh.Image = ((System.Drawing.Image)(resources.GetObject("butxoahinh.Image")));
            this.butxoahinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butxoahinh.Location = new System.Drawing.Point(733, 528);
            this.butxoahinh.Name = "butxoahinh";
            this.butxoahinh.Size = new System.Drawing.Size(51, 24);
            this.butxoahinh.TabIndex = 258;
            this.butxoahinh.Text = "     Xóa";
            this.butxoahinh.UseVisualStyleBackColor = true;
            this.butxoahinh.Click += new System.EventHandler(this.butxoahinh_Click);
            // 
            // frmDmTTB
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.butxoahinh);
            this.Controls.Add(this.tyle);
            this.Controls.Add(this.butNo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.maloai);
            this.Controls.Add(this.ma);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.butHinh);
            this.Controls.Add(this.hinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stt);
            this.Controls.Add(this.nhomin);
            this.Controls.Add(this.sodk);
            this.Controls.Add(this.chkBHYT);
            this.Controls.Add(this.duongdung);
            this.Controls.Add(this.sotk);
            this.Controls.Add(this.dang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ten);
            this.Controls.Add(this.find);
            this.Controls.Add(this.listNhomin);
            this.Controls.Add(this.manhom);
            this.Controls.Add(this.nhombo);
            this.Controls.Add(this.lNhomin);
            this.Controls.Add(this.butSTT);
            this.Controls.Add(this.sltoithieu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lphantram);
            this.Controls.Add(this.ltyle);
            this.Controls.Add(this.lsltoithieu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.butIn);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.listNhom);
            this.Controls.Add(this.listSotk);
            this.Controls.Add(this.listNhombo);
            this.Controls.Add(this.listNuoc);
            this.Controls.Add(this.listHang);
            this.Controls.Add(this.listLoai);
            this.Controls.Add(this.listDang);
            this.Controls.Add(this.manuoc);
            this.Controls.Add(this.mahang);
            this.Controls.Add(this.hamluong);
            this.Controls.Add(this.lNuoc);
            this.Controls.Add(this.lHang);
            this.Controls.Add(this.lPhanloai);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lSotk);
            this.Controls.Add(this.lNhombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butHuy);
            this.Controls.Add(this.butBoqua);
            this.Controls.Add(this.butLuu);
            this.Controls.Add(this.butSua);
            this.Controls.Add(this.butMoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butKetthuc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDmTTB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục trang thiết bị y tế";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDmbd_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDmbd_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stt)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void frmDmbd_Load(object sender, System.EventArgs e)
		{

            //DataSet ds = ttb.get_data("select * from my_bfile_table");
            //byte[] image = (byte[])(ds.Tables[0].Rows[0]["b"]);
            //System.IO.MemoryStream memo = new System.IO.MemoryStream(image);
            //Bitmap map = new Bitmap(Image.FromStream(memo));
            //pictureBox1.Image = map;
            
            if (Screen.PrimaryScreen.WorkingArea.Width > 800) this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            user = ttb.user;
            hostPicture = ttb.Thongso(617, -2);
            itable = ttb.tableid("", "ttb_dmbd");
			butNo.Visible=!ttb.bMabd;
			listNhom.DisplayMember="TEN";
			listNhom.ValueMember="TEN";

			listLoai.DisplayMember="TEN";
			listLoai.ValueMember="TEN";

			listHang.DisplayMember="TEN";
			listHang.ValueMember="TEN";

			listNuoc.DisplayMember="TEN";
			listNuoc.ValueMember="TEN";

			listNhombo.DisplayMember="TEN";
			listNhombo.ValueMember="TEN";

			listNhomin.DisplayMember="TEN";
			listNhomin.ValueMember="TEN";

			listSotk.DisplayMember="TEN";
			listSotk.ValueMember="TEN";

			listDang.DisplayMember="TEN";
			listDang.ValueMember="TEN";
			
			load_dm();
			load_grid();
			AddGridTableStyle();
			ref_text(0);
		}

		private void load_dm()
		{
			sql="select * from "+user+".ttb_dmnhom where nhom="+i_nhom;
			if (s_manhom!="") sql+=" and id in ("+s_manhom.Substring(0,s_manhom.Length-1)+")";
			sql+=" order by stt";
			dtnhom=ttb.get_data(sql).Tables[0];
            dtloai = ttb.get_data("select * from " + user + ".ttb_dmloai where nhom=" + i_nhom + " order by stt").Tables[0];
            dthang = ttb.get_data("select * from " + user + ".ttb_dmhang where nhom=" + i_nhom + " order by stt").Tables[0];
            dtnuoc = ttb.get_data("select * from " + user + ".ttb_dmnuoc where nhom=" + i_nhom + " order by stt").Tables[0];
            dtnhombo = ttb.get_data("select id ma,ten,stt from " + user + ".ttb_nhombo order by stt").Tables[0];
            dtnhomin = ttb.get_data("select * from " + user + ".ttb_nhomin where nhom=" + i_nhom + " order by stt").Tables[0];
            dtsotk = ttb.get_data("select id,ten,ma from " + user + ".ttb_dmnhomkt where nhom=" + i_nhom + " order by stt").Tables[0];
            listDang.DataSource = ttb.get_data("select * from " + user + ".ttb_dmdvt order by stt").Tables[0];
			listSotk.DataSource=dtsotk;
			listNhombo.DataSource=dtnhombo;
			listNhomin.DataSource=dtnhomin;
			listNuoc.DataSource=dtnuoc;
			listHang.DataSource=dthang;
			listLoai.DataSource=dtloai;
			listNhom.DataSource=dtnhom;		
		}

		private void load_grid()
		{
            try
            {
                sql = "select a.*,trim(a.ten)||' '||a.hamluong as tenbd,b.ten as tennhom,c.ten as tenloai,d.ten as tenhang,e.ten as tennuoc,f.ten as tenbo,g.ten as nhomkt,h.ten as tenin ";
                sql += " from " + user + ".ttb_dmbd a inner join " + user + ".ttb_dmnhom b on a.manhom=b.id ";
                sql += " inner join " + user + ".ttb_dmloai c on a.maloai=c.id ";
                sql += " inner join " + user + ".ttb_dmhang d on a.mahang=d.id ";
                sql += " inner join " + user + ".ttb_dmnuoc e on a.manuoc=e.id ";
                sql += " left join " + user + ".ttb_nhombo f on a.nhombo=f.id ";
                sql += " left join " + user + ".ttb_dmnhomkt g on a.sotk=g.id ";
                sql += " left join " + user + ".ttb_nhomin h on a.nhomin=h.id ";
                sql += " where a.nhom=" + i_nhom;
                if (s_manhom != "") sql += " and a.manhom in (" + s_manhom.Substring(0, s_manhom.Length - 1) + ")";
                sql += " order by a.ten";
                dt = ttb.get_data_withImage(sql).Tables[0];
                dataGrid1.DataSource = dt;
                DataTable dttam = ttb.get_data("select * from ttb_dmbd").Tables[0];
            }
            catch //(Exception exx)
            { }
        }

		private void AddGridTableStyle()
		{
			DataGridTableStyle ts =new DataGridTableStyle();
			ts.MappingName = dt.TableName;
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
			TextCol.MappingName = "id";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "stt";
			TextCol.HeaderText = "Stt";
			TextCol.Width = 40;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tenhc";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "ma";
			TextCol.HeaderText = "Mã";
			TextCol.Width = 53;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tenbd";
			TextCol.HeaderText = "Tên";
			TextCol.Width = 200;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "dang";
			TextCol.HeaderText = "ĐVT";
			TextCol.Width = 50;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tennhom";
			TextCol.HeaderText = "Nhóm";
			TextCol.Width = 250;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tenloai";
			TextCol.HeaderText = "Loại";
			TextCol.Width = 200;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tenhang";
			TextCol.HeaderText = "Hãng";
			TextCol.Width = 150;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tennuoc";
			TextCol.HeaderText = "Nước";
			TextCol.Width = 150;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tenin";
			TextCol.HeaderText = "Phiếu in";
			TextCol.Width = 150;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tenbo";
			TextCol.HeaderText = "Nhóm báo cáo";
			TextCol.Width = 150;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);
		}

		private void butKetthuc_Click(object sender, System.EventArgs e)
		{
            //try
            //{
                //DataSet ds = ttb.get_data("select * from my_bfile_table");
                //byte[] image = (byte[])(ds.Tables[0].Rows[0]["b"]);
                //System.IO.MemoryStream memo = new System.IO.MemoryStream(image);
                //Bitmap map = new Bitmap(Image.FromStream(memo));
                //pic.Image = map;
                //DirectoryInfo inf = new DirectoryInfo("\\\\192.168.1.114\\picture");
                            
                //drs.AddAccessRule(new FileSystemAccessRule("root", FileSystemRights.Write, AccessControlType.Allow));
                //Directory.SetAccessControl("////192.168.1.114/u01/app/oracle/picture", drs);
                //File.Copy("RHM.bmp", "\\\\192.168.1.114\\u01\\app\\oracle\\picture", true);
                //File.Copy("RHM.bmp", "\\\\192.168.1.114\\picture\\rhm.bmp", true);

                //DirectoryInfo dInfo = new DirectoryInfo("\\\\192.168.1.114\\picture");

                // Get a DirectorySecurity object that represents the 
                // current security settings.
                //DirectorySecurity dSecurity = dInfo.GetAccessControl(AccessControlActions.View);

                // Add the FileSystemAccessRule to the security settings. 
                //dSecurity.AddAccessRule(new FileSystemAccessRule(,
                //                                                Rights,
                //                                                ControlType));

                //// Set the new access settings.
                //dInfo.SetAccessControl(dSecurity);

                //Directory.CreateDirectory("//192.168.1.114/u01/app/oracle/picture",);
                this.Close();
            //}
            //catch (Exception exx)
            //{ }
		}

		private void ten_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");
		}

		private void ena_object(bool ena)
		{
			if (!ttb.bMabd) ma.Enabled=ena;
			ten.Enabled=ena;
			dataGrid1.Enabled=!ena;
			hamluong.Enabled=ena;
			dang.Enabled=ena;
			stt.Enabled=ena;
			chkBHYT.Enabled=ena;
            hide.Enabled = ena;
			manhom.Enabled=ena;
			maloai.Enabled=ena;
			mahang.Enabled=ena;
			manuoc.Enabled=ena;
			sodk.Enabled=ena;
			sltoithieu.Enabled=ena;
			duongdung.Enabled=ena;
			if (butNo.Visible) butNo.Enabled=ena;
			if (ttb.bNhomin_mabd(i_nhom)) nhomin.Enabled=ena;
			if (ttb.bNhombc) nhombo.Enabled=ena;
			if (ttb.bNhomkt) sotk.Enabled=ena;
			tyle.Enabled=ena;
			butSTT.Enabled=ena;
			butMoi.Enabled=!ena;
			butSua.Enabled=!ena;
			butLuu.Enabled=ena;
			butBoqua.Enabled=ena;
			butHuy.Enabled=!ena;
			butKetthuc.Enabled=!ena;
			butHinh.Enabled=ena;
            butxoahinh.Enabled = ena;
			if (!ena) butMoi.Focus();
			else
			{
				if (ttb.bDanhmuc)
				{
					ttb.writeXml("ttb_thongso","c01","0");
					load_dm();
				}
			}
		}

		private void butMoi_Click(object sender, System.EventArgs e)
		{
			l_id=0;
			try
			{
                DataTable tmp = ttb.get_data("select max(stt) stt from " + user + ".ttb_dmbd where nhom=" + i_nhom).Tables[0];
				if (tmp.Rows[0]["stt"].ToString()!="")
					stt.Value=int.Parse(tmp.Rows[0]["stt"].ToString())+1;
			}
			catch{stt.Value=1;}
			ma.Text="";
			ten.Text="";
			manhom.Text="";
			maloai.Text="";
			mahang.Text="";
			manuoc.Text="";
			nhombo.Text="";
			nhomin.Text="";
			sotk.Text="";
			sodk.Text="";
			chkBHYT.Checked=true;
			sltoithieu.Text="0";
			dang.Text="";
			tyle.Text="0";
			hamluong.Text="";
			duongdung.Text="";
            pic.Tag = "0000.bmp";
            fstr = new System.IO.FileStream(pic.Tag.ToString(), System.IO.FileMode.Open, System.IO.FileAccess.Read);
            map = new Bitmap(Image.FromStream(fstr));
            pic.Image = (Bitmap)map;
            image = new byte[fstr.Length];
            fstr.Read(image, 0, System.Convert.ToInt32(fstr.Length));
            fstr.Close();
            pic.Tag = image;
            ena_object(true);
			if (ma.Enabled) ma.Focus();
			else ten.Focus();

		}

		private void butSua_Click(object sender, System.EventArgs e)
		{
			if (dt.Rows.Count==0) return;
			l_id=decimal.Parse(dataGrid1[dataGrid1.CurrentCell.RowNumber,0].ToString());
			ref_text(l_id);
			ena_object(true);
			if (!bAdmin)
			{
                if (ttb.get_data("select * from " + user + ".ttb_dmbd_sudung where mabd=" + l_id).Tables[0].Rows.Count != 0)
				{
					ten.Enabled=false;dang.Enabled=false;
					hamluong.Enabled=false;mahang.Enabled=false;manuoc.Enabled=false;
				}
			}
			ma.Enabled=false;
			ten.Focus();
		}

		private bool Exist(string ten,string hamluong,string dang,string manuoc,string mahang,string sodk)
		{
			r=ttb.getrowbyid(dt,"tenbd='"+ten+" "+hamluong+"' and dang='"+dang+"' and tennuoc='"+manuoc+"' and tenhang='"+mahang+"' and sodk='"+sodk+"'");
			return r!=null;
		}

		private bool kiemtra()
		{
			if (l_id==0)
			{
				if (Exist(ten.Text.Trim(),hamluong.Text.Trim(),dang.Text.Trim(),manuoc.Text.Trim(),mahang.Text.Trim(),sodk.Text.Trim()))
				{
					MessageBox.Show("Đã tồn tại tên : "+ten.Text.Trim()+" "+hamluong.Text+" Dạng : "+dang.Text+" Nước sx : "+manuoc.Text+" Tên hãng: "+mahang.Text,ttb.Msg);
					ten.Focus();
					return false;
				}
			}

			if (ma.Enabled)
			{
                if (ma.Text == "")
                {
                    ma.Text = ttb.getMabd("ttb_dmbd", ten.Text, i_nhom);
                }
			}
			if (ten.Text=="")
			{
				ten.Focus();
				return false;
			}
			if (manhom.Text=="")
			{
				MessageBox.Show("Chọn nhóm !",ttb.Msg);
				manhom.Focus();
				return false;
			}
			else 
			{
				r=ttb.getrowbyid(dtnhom,"ten='"+manhom.Text+"'");
				if (r==null)
				{
					MessageBox.Show("Nhóm không hợp lệ!",ttb.Msg);
					manhom.Focus();
					return false;
				}
				else iNhom=int.Parse(r["id"].ToString());
			}
			if (maloai.Text=="")
			{
				MessageBox.Show("Chọn loại !",ttb.Msg);
				maloai.Focus();
				return false;
			}
			else 
			{
				r=ttb.getrowbyid(dtloai,"ten='"+maloai.Text+"'");
				if (r==null)
				{
					MessageBox.Show("Loại không hợp lệ!",ttb.Msg);
					maloai.Focus();
					return false;
				}
				else iLoai=int.Parse(r["id"].ToString());
			}
			if (mahang.Text=="")
			{
				MessageBox.Show("Chọn hãng !",ttb.Msg);
				mahang.Focus();
				return false;
			}
			else 
			{
				r=ttb.getrowbyid(dthang,"ten='"+mahang.Text+"'");
				if (r==null)
				{
					MessageBox.Show("Hãng không hợp lệ!",ttb.Msg);
					mahang.Focus();
					return false;
				}
				else iHang=int.Parse(r["id"].ToString());
			}
			if (manuoc.Text=="")
			{
				MessageBox.Show("Chọn nước !",ttb.Msg);
				manuoc.Focus();
				return false;
			}
			else 
			{
				r=ttb.getrowbyid(dtnuoc,"ten='"+manuoc.Text+"'");
				if (r==null)
				{
					MessageBox.Show("Nước không hợp lệ!",ttb.Msg);
					manuoc.Focus();
					return false;
				}
				else iNuoc=int.Parse(r["id"].ToString());
			}
			if (sotk.Enabled)
			{
				if (sotk.Text=="")
				{
					MessageBox.Show("Chọn nhóm kế toán !",ttb.Msg);
					sotk.Focus();
					return false;
				}
				else 
				{
					r=ttb.getrowbyid(dtsotk,"ten='"+sotk.Text+"'");
					if (r==null)
					{
						MessageBox.Show("Nhóm kế toán không hợp lệ!",ttb.Msg);
						sotk.Focus();
						return false;
					}
					else iSotk=int.Parse(r["id"].ToString());
				}
			}
			else
			{
				if (sotk.Text=="") iSotk=0;
				else
				{
					r=ttb.getrowbyid(dtsotk,"ten='"+sotk.Text+"'");
					if (r==null)
					{
						MessageBox.Show("Nhóm kế toán không hợp lệ!",ttb.Msg);
						sotk.Focus();
						return false;
					}
					else iSotk=int.Parse(r["id"].ToString());
				}
			}
			if (nhombo.Enabled)
			{
				if (nhombo.Text=="")
				{
					MessageBox.Show("Chọn nhóm báo cáo !",ttb.Msg);
					nhombo.Focus();
					return false;
				}
				else 
				{
					r=ttb.getrowbyid(dtnhombo,"ten='"+nhombo.Text+"'");
					if (r==null)
					{
						MessageBox.Show("Nhóm báo cáo không hợp lệ!",ttb.Msg);
						nhombo.Focus();
						return false;
					}
					else iNhombo=int.Parse(r["ma"].ToString());
				}
			}
			else
			{
				if (nhombo.Text=="") iNhombo=0;
				else
				{
					r=ttb.getrowbyid(dtnhombo,"ten='"+nhombo.Text+"'");
					if (r==null)
					{
						MessageBox.Show("Nhóm báo cáo không hợp lệ!",ttb.Msg);
						nhombo.Focus();
						return false;
					}
					else iNhombo=int.Parse(r["ma"].ToString());
				}
			}
			if (nhomin.Enabled)
			{
				if (nhomin.Text=="")
				{
					MessageBox.Show("Chọn nhóm in phiếu !",ttb.Msg);
					nhomin.Focus();
					return false;
				}
				else 
				{
					r=ttb.getrowbyid(dtnhomin,"ten='"+nhomin.Text+"'");
					if (r==null)
					{
						MessageBox.Show("Nhóm in phiếu không hợp lệ!",ttb.Msg);
						nhomin.Focus();
						return false;
					}
					else iNhomin=int.Parse(r["id"].ToString());
				}
			}
			else iNhomin=0;
			return true;
		}

        private void butLuu_Click(object sender, System.EventArgs e)
        {
            if (!kiemtra()) return;
            if (ma.Text == "") ma.Text = ttb.getMabd("ttb_dmbd", ten.Text, i_nhom);
            if (l_id == 0)
            {
                DataRow r = ttb.getrowbyid(dt, "ma='" + ma.Text + "'");
                if (r != null)
                {
                    MessageBox.Show("Mã mặt hàng đã tồn tại !", ttb.Msg);
                    if (!ma.Enabled) ma.Enabled = true;
                    ma.Focus();
                    return;
                }
                l_id = ttb.get_id_dmbd;
                ttb.upd_eve_tables(itable, i_userid, "ins");
            }
            else
            {
                ttb.upd_eve_tables(itable, i_userid, "upd");
                ttb.upd_eve_upd_del(itable, i_userid, "upd", ttb.fields(user + ".ttb_dmbd", "id=" + l_id));
            }
            byte[] image = new byte[0];
            if (pic.Image != null)
            {
                Image imag = pic.Image;
                MemoryStream mem = new MemoryStream();
                imag.Save(mem, System.Drawing.Imaging.ImageFormat.Gif);
                image = mem.ToArray();
            }
            if (!ttb.upd_dmbd(l_id, ma.Text, ten.Text, dang.Text, hamluong.Text, iNhom, iLoai, iHang, iNuoc,
                iNhombo, (chkBHYT.Checked) ? 1 : 0, 0, iSotk, "", "", 1, i_nhom, sodk.Text,
                (sltoithieu.Text == "") ? 0 : decimal.Parse(sltoithieu.Text), 0, 0, 0,
                (tyle.Text != "") ? decimal.Parse(tyle.Text) : 0, stt.Value, image, iNhomin, 0, "",
                duongdung.Text, 0, dang.Text, 1, dang.Text, hide.Checked ? 1 : 0))
            {
                MessageBox.Show("Không cập nhật thông tin " + this.Text.Trim() + " !", ttb.Msg);
                return;
            }
            load_grid();
            ena_object(false);
        }

		private void butBoqua_Click(object sender, System.EventArgs e)
		{
			ena_object(false);
			ref_text(0);
		}

		private void butHuy_Click(object sender, System.EventArgs e)
		{
			if (dt.Rows.Count==1)
			{
				MessageBox.Show("Không cho phép hủy ?",ttb.Msg);
				return;
			}	
			try
			{
				if (ttb.get_data("select * from "+user+".ttb_dmbd_sudung where mabd="+decimal.Parse(dataGrid1[dataGrid1.CurrentCell.RowNumber,0].ToString())).Tables[0].Rows.Count!=0)
				{
					MessageBox.Show("Nội dung đang sử dụng không cho phép hủy !",ttb.Msg);
					return;
				}
			}
			catch{}
			if (MessageBox.Show("Đồng ý hủy thông tin này !",ttb.Msg,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
			{
                l_id = decimal.Parse(dataGrid1[dataGrid1.CurrentCell.RowNumber, 0].ToString());
                ttb.upd_eve_tables(itable, i_userid, "del");
                ttb.upd_eve_upd_del(itable, i_userid, "del", ttb.fields(user + ".ttb_dmbd", "id=" + l_id));
				ttb.execute_data("delete from "+user+".ttb_dmbd where id="+l_id);
				if (!ttb.bDmbd) ttb.writeXml("ttb_thongso","c06","1");
				load_grid();
				ref_text(0);
			}
		}

		private void ref_text(decimal id)
		{
			try
			{
				if (id==0)
				{
					int i=dataGrid1.CurrentCell.RowNumber;
					r=ttb.getrowbyid(dt,"id="+decimal.Parse(dataGrid1[i,0].ToString()));
				}
				else r=ttb.getrowbyid(dt,"id="+id);
				if (r!=null)
				{
					ma.Text=r["ma"].ToString();
					ten.Text=r["ten"].ToString();
					hamluong.Text=r["hamluong"].ToString();
					dang.Text=r["dang"].ToString();
					manhom.Text=r["tennhom"].ToString();
					maloai.Text=r["tenloai"].ToString();
					mahang.Text=r["tenhang"].ToString();
					manuoc.Text=r["tennuoc"].ToString();
					sotk.Text=r["nhomkt"].ToString();
					nhombo.Text=r["tenbo"].ToString();
					nhomin.Text=r["tenin"].ToString();
					sodk.Text=r["sodk"].ToString();
					duongdung.Text=r["congsuat"].ToString();
					sltoithieu.Text=r["sltoithieu"].ToString();
					stt.Value=decimal.Parse(r["stt"].ToString());
					l_id=decimal.Parse(r["id"].ToString());
					decimal dtyle=decimal.Parse(r["tyle"].ToString());
					tyle.Text=dtyle.ToString("##0.00");
                    try
                    {
                        byte[] image = (byte[])(r["image"]);
                        MemoryStream memo = new MemoryStream(image);
                        Bitmap map = new Bitmap(Image.FromStream(memo));
                        pic.Image = map;
                    }
                    catch
                    {
                        pic.Image = null;
                    }
                    hide.Checked = r["hide"].ToString() == "1";
				}
			}
			catch{}
		}

		private void dataGrid1_CurrentCellChanged(object sender, System.EventArgs e)
		{
			ref_text(0);
		}

		private void frmDmbd_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.F10) butKetthuc_Click(sender,e);
		}

		private void ma_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");	
		}

		private void ma_Validated(object sender, System.EventArgs e)
		{
			if (ma.Text!="")
			{
				r=ttb.getrowbyid(dt,"ma='"+ma.Text+"'");
				if (r!=null)
				{
					MessageBox.Show("Mã này đã nhập !",ttb.Msg);
					ma.Focus();
					return;
				}
				if (ten.Text=="") ten.Text=ma.Text;
			}
		}

		private void hamluong_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");
		}

		private void Filter(string ten,List list)
		{
			try
			{
				CurrencyManager cm= (CurrencyManager)BindingContext[list.DataSource];
				DataView dv=(DataView)cm.List;
				dv.RowFilter="ten like '%"+ten.Trim()+"%'";
			}
			catch{}
		}

		private void dang_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Down || e.KeyCode==Keys.Up) listDang.Focus();
			else if (e.KeyCode==Keys.Enter)
			{
				if (listDang.Visible) listDang.Focus();
				else SendKeys.Send("{Tab}");
			}
		}

		private void dang_TextChanged(object sender, System.EventArgs e)
		{
			Filter(dang.Text,listDang);
			listDang.BrowseToDanhmuc(dang,duongdung,0);
		}

		private void dang_Validated(object sender, System.EventArgs e)
		{
			if(!listDang.Focused) listDang.Hide();
		}

		private void manhom_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Down || e.KeyCode==Keys.Up) listNhom.Focus();
			else if (e.KeyCode==Keys.Enter)
			{
				if (listNhom.Visible) listNhom.Focus();
				else SendKeys.Send("{Tab}");
			}
		}

		private void manhom_TextChanged(object sender, System.EventArgs e)
		{
			Filter(manhom.Text,listNhom);
			listNhom.BrowseToDanhmuc(manhom,maloai,lPhanloai.Width+maloai.Width);
		}

		private void manhom_Validated(object sender, System.EventArgs e)
		{
			if(!listNhom.Focused) listNhom.Hide();
		}

		private void maloai_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Down || e.KeyCode==Keys.Up) listLoai.Focus();
			else if (e.KeyCode==Keys.Enter)
			{
				if (listLoai.Visible) listLoai.Focus();
				else SendKeys.Send("{Tab}");
			}
		}

		private void maloai_TextChanged(object sender, System.EventArgs e)
		{
			Filter(maloai.Text,listLoai);
			listLoai.BrowseToDanhmuc(maloai,mahang,lHang.Width+mahang.Width);
		}

		private void maloai_Validated(object sender, System.EventArgs e)
		{
			if(!listLoai.Focused) listLoai.Hide();
		}

		private void mahang_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Down || e.KeyCode==Keys.Up) listHang.Focus();
			else if (e.KeyCode==Keys.Enter)
			{
				if (listHang.Visible) listHang.Focus();
				else SendKeys.Send("{Tab}");
			}
		}

		private void mahang_TextChanged(object sender, System.EventArgs e)
		{
			Filter(mahang.Text,listHang);
			listHang.BrowseToDanhmuc(mahang,manuoc,lNuoc.Width+manuoc.Width);
		}

		private void mahang_Validated(object sender, System.EventArgs e)
		{
			if(!listHang.Focused) listHang.Hide();		
		}

		private void manuoc_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Down || e.KeyCode==Keys.Up) listNuoc.Focus();
			else if (e.KeyCode==Keys.Enter)
			{
				if (listNuoc.Visible) listNuoc.Focus();
				else SendKeys.Send("{Tab}{F4}");
			}
		}

		private void manuoc_TextChanged(object sender, System.EventArgs e)
		{
			Filter(manuoc.Text,listNuoc);
			listNuoc.BrowseToDanhmuc(manuoc,nhombo,0);
		}

		private void manuoc_Validated(object sender, System.EventArgs e)
		{
			if(!listNuoc.Focused) listNuoc.Hide();
		}

		private void nhombo_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Down || e.KeyCode==Keys.Up) listNhombo.Focus();
			else if (e.KeyCode==Keys.Enter)
			{
				if (listNhombo.Visible)	listNhombo.Focus();
				else SendKeys.Send("{Tab}");
			}
		}

		private void nhombo_TextChanged(object sender, System.EventArgs e)
		{
			Filter(nhombo.Text,listNhombo);
			listNhombo.BrowseToDanhmuc(nhombo,nhomin,0);
		}

		private void nhombo_Validated(object sender, System.EventArgs e)
		{
			if(!listNhombo.Focused) listNhombo.Hide();
		}

		private void sotk_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Down || e.KeyCode==Keys.Up) listSotk.Focus();
			else if (e.KeyCode==Keys.Enter)
			{
				if (listSotk.Visible) listSotk.Focus();
				else SendKeys.Send("{Tab}");
			}
		}

		private void sotk_TextChanged(object sender, System.EventArgs e)
		{
            if (this.ActiveControl == sotk)
            {
                Filter(sotk.Text, listSotk);
                listSotk.BrowseToDanhmuc(sotk, sodk, 0);
            }
		}

		private void sotk_Validated(object sender, System.EventArgs e)
		{
			if(!listSotk.Focused) listSotk.Hide();		
		}

		public void RefreshChildren(string text)
		{
			try
			{
				CurrencyManager cm= (CurrencyManager)BindingContext[dataGrid1.DataSource];
				DataView dv=(DataView)cm.List;
				dv.RowFilter="tenbd like '%"+text.Trim()+"%' or tenhc like '%"+text.Trim()+"%' or ma like '%"+text.Trim()+"%' or tennhom like '%"+text.Trim()+"%' or tenloai like '%"+text.Trim()+"%' or tenin like '%"+text.Trim()+"%'";
				if (text!="")
				{
					ref_text(0);
					l_id=decimal.Parse(dataGrid1[dataGrid1.CurrentCell.RowNumber,0].ToString());
				}
				else ref_text(l_id);
			}
			catch{}
		}

		private void butIn_Click(object sender, System.EventArgs e)
		{
            frmChonindmbd f1 = new frmChonindmbd(ttb, ttb.get_data("select * from " + user + ".ttb_dmnhom where nhom=" + i_nhom + " order by stt").Tables[0], ttb.get_data("select * from " + user + ".ttb_dmloai where nhom=" + i_nhom + " order by stt").Tables[0], s_mmyy, i_nhom);
			f1.ShowDialog(this);
		}

		private void sltoithieu_Validated(object sender, System.EventArgs e)
		{
			try
			{
				int iSoluong=int.Parse(sltoithieu.Text);
				sltoithieu.Text=iSoluong.ToString("###,###,###");
			}
			catch{sltoithieu.Text="0";}
		}

		private void tyle_Validated(object sender, System.EventArgs e)
		{
			try
			{
				decimal dtl=(tyle.Text!="")?decimal.Parse(tyle.Text):0;
				tyle.Text=dtl.ToString("##0.00");
			}
			catch{tyle.Text="0";}
		}

		private void butSTT_Click(object sender, System.EventArgs e)
		{
			frmSuastt f=new frmSuastt(ttb,i_nhom);
			f.ShowDialog();
			load_grid();
		}

		private void nhomin_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Down || e.KeyCode==Keys.Up) listNhomin.Focus();
			else if (e.KeyCode==Keys.Enter)
			{
				if (listNhomin.Visible)	listNhomin.Focus();
				else SendKeys.Send("{Tab}{F4}");
			}
		}

		private void nhomin_TextChanged(object sender, System.EventArgs e)
		{
			Filter(nhomin.Text,listNhomin);
			listNhomin.BrowseToDanhmuc(nhomin,stt,0);
		}

		private void nhomin_Validated(object sender, System.EventArgs e)
		{
			if(!listNhomin.Focused) listNhomin.Hide();
		}

		private void find_TextChanged(object sender, System.EventArgs e)
		{
			if (this.ActiveControl==find) RefreshChildren(find.Text);		
		}

		private void find_Enter(object sender, System.EventArgs e)
		{
			find.Text="";
		}

		private void duongdung_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");
		}

		private void butNo_Click(object sender, System.EventArgs e)
		{
			if (ma.Text!="")
			{
				MessageBox.Show("Số thứ tự mã "+ma.Text.Trim()+"\nlà "+ttb.get_stt(ma.Text.Trim(),i_nhom),ttb.Msg);
				ma.Focus();
			}
		}

		private void butHinh_Click(object sender, System.EventArgs e)
		{
            string sDir = System.Environment.CurrentDirectory.ToString();
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "Chọn hình ảnh";
            of.Filter = "Files (*.gif)|*.gif|(*.jpg)|*.jpg|All Files (*.*)|*.*";
            of.RestoreDirectory = true;
            pic.Name = "";
            pic.Tag = null; 
            if (of.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(of.FileName);
                pic.Image = image;
                pic.Tag = pic.Image;
            }
            butLuu.Focus();
		}

        private void butxoahinh_Click(object sender, EventArgs e)
        {
            pic.Image = null;
            pic.Tag = null;
        }
	}
}
