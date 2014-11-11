using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Medisoft2009.Usercontrol;
using LibTTB;

namespace TTB
{
	/// <summary>
	/// Summary description for frmNhap.
	/// </summary>
	public class frmKbtonct : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox manguon;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label lTen;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox tenbd;
		private System.Windows.Forms.TextBox mabd;
		private MaskedBox.MaskedBox dang;
		private Medisoft2009.Usercontrol.MaskedTextBox soluong;
		private Medisoft2009.Usercontrol.MaskedTextBox sotien;
		private System.Windows.Forms.Button butMoi;
		private System.Windows.Forms.Button butSua;
		private System.Windows.Forms.Button butLuu;
		private System.Windows.Forms.Button butBoqua;
		private System.Windows.Forms.Button butHuy;
		private System.Windows.Forms.Button butIn;
		private System.Windows.Forms.Button butKetthuc;
		private string s_mmyy,sql,format_sotien,format_dongia,format_soluong,user,xxx;
		private int i_nhom,i_makho,i_mabd,i_userid,itable;
		private decimal l_id;
		private decimal d_soluong,d_sotien,d_slnhap,d_slxuat,d_soluongcu,d_dongia;
		private bool bKhoaso;
        private LibTTB.AccessData ttb;
		private DataTable dtdmbd=new DataTable();
		private DataTable dt=new DataTable();
		private DataTable dtnguon=new DataTable();
		private System.Windows.Forms.Label ldvt;
		private DataRow r;
		private System.Windows.Forms.TextBox stt;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label24;
		private MaskedBox.MaskedBox handung;
		//private frmMain parent;
		private System.Windows.Forms.Label label1;
		private Medisoft2009.Usercontrol.MaskedTextBox dongia;
		private Medisoft2009.Usercontrol.MaskedTextBox losx;
		private System.Windows.Forms.TextBox tim;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
        private Medisoft2009.Usercontrol.MaskedTextBox sothe;
		private Medisoft2009.Usercontrol.MaskedTextBox tyle;
		private System.Windows.Forms.ComboBox phanloai;
		private System.Windows.Forms.ComboBox tinhtrang;
		private System.Windows.Forms.ComboBox nguongoc;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.NumericUpDown baohanh;
		private List listDMBD;
        private ComboBox nhomcc;
        private Label label14;
        private MaskedBox.MaskedBox namsx;
        private MaskedBox.MaskedBox namsd;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmKbtonct(AccessData acc,string mmyy,int nhom,int kho,string title,int userid)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            ttb = acc; i_nhom = nhom; i_makho = kho; s_mmyy = mmyy; i_userid = userid;
			this.Text="Tồn đầu "+title.Trim()+" tháng "+mmyy.Substring(0,2)+" năm "+mmyy.Substring(2,2);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKbtonct));
            this.label9 = new System.Windows.Forms.Label();
            this.manguon = new System.Windows.Forms.ComboBox();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.label13 = new System.Windows.Forms.Label();
            this.lTen = new System.Windows.Forms.Label();
            this.ldvt = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tenbd = new System.Windows.Forms.TextBox();
            this.mabd = new System.Windows.Forms.TextBox();
            this.dang = new MaskedBox.MaskedBox();
            this.soluong = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.sotien = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.butMoi = new System.Windows.Forms.Button();
            this.butSua = new System.Windows.Forms.Button();
            this.butLuu = new System.Windows.Forms.Button();
            this.butBoqua = new System.Windows.Forms.Button();
            this.butHuy = new System.Windows.Forms.Button();
            this.butIn = new System.Windows.Forms.Button();
            this.butKetthuc = new System.Windows.Forms.Button();
            this.stt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.handung = new MaskedBox.MaskedBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dongia = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.losx = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.tim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.sothe = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.tyle = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.phanloai = new System.Windows.Forms.ComboBox();
            this.tinhtrang = new System.Windows.Forms.ComboBox();
            this.nguongoc = new System.Windows.Forms.ComboBox();
            this.baohanh = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.listDMBD = new Medisoft2009.Usercontrol.List();
            this.nhomcc = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.namsx = new MaskedBox.MaskedBox();
            this.namsd = new MaskedBox.MaskedBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baohanh)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(583, 392);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nguồn :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // manguon
            // 
            this.manguon.BackColor = System.Drawing.SystemColors.HighlightText;
            this.manguon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manguon.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manguon.Location = new System.Drawing.Point(630, 391);
            this.manguon.Name = "manguon";
            this.manguon.Size = new System.Drawing.Size(154, 21);
            this.manguon.TabIndex = 3;
            this.manguon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.manguon_KeyDown);
            // 
            // dataGrid1
            // 
            this.dataGrid1.AlternatingBackColor = System.Drawing.Color.Lavender;
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
            this.dataGrid1.Location = new System.Drawing.Point(8, 5);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro;
            this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.RowHeaderWidth = 10;
            this.dataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue;
            this.dataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid1.Size = new System.Drawing.Size(776, 379);
            this.dataGrid1.TabIndex = 0;
            this.dataGrid1.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(26, 391);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 23);
            this.label13.TabIndex = 28;
            this.label13.Text = "Mã :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lTen
            // 
            this.lTen.Location = new System.Drawing.Point(82, 391);
            this.lTen.Name = "lTen";
            this.lTen.Size = new System.Drawing.Size(56, 23);
            this.lTen.TabIndex = 29;
            this.lTen.Text = "Tên :";
            this.lTen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ldvt
            // 
            this.ldvt.Location = new System.Drawing.Point(490, 392);
            this.ldvt.Name = "ldvt";
            this.ldvt.Size = new System.Drawing.Size(42, 23);
            this.ldvt.TabIndex = 30;
            this.ldvt.Text = "ĐVT :";
            this.ldvt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(302, 413);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 23);
            this.label16.TabIndex = 31;
            this.label16.Text = "Số lượng :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(574, 415);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 23);
            this.label18.TabIndex = 33;
            this.label18.Text = "Số tiền :";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tenbd
            // 
            this.tenbd.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tenbd.Enabled = false;
            this.tenbd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenbd.Location = new System.Drawing.Point(137, 391);
            this.tenbd.Name = "tenbd";
            this.tenbd.Size = new System.Drawing.Size(357, 21);
            this.tenbd.TabIndex = 1;
            this.tenbd.TextChanged += new System.EventHandler(this.tenbd_TextChanged);
            this.tenbd.Validated += new System.EventHandler(this.tenbd_Validated);
            this.tenbd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tenbd_KeyDown);
            // 
            // mabd
            // 
            this.mabd.BackColor = System.Drawing.SystemColors.HighlightText;
            this.mabd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mabd.Enabled = false;
            this.mabd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mabd.Location = new System.Drawing.Point(56, 391);
            this.mabd.Name = "mabd";
            this.mabd.Size = new System.Drawing.Size(50, 21);
            this.mabd.TabIndex = 0;
            this.mabd.TextChanged += new System.EventHandler(this.mabd_TextChanged);
            this.mabd.Validated += new System.EventHandler(this.mabd_Validated);
            this.mabd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tenbd_KeyDown);
            // 
            // dang
            // 
            this.dang.BackColor = System.Drawing.SystemColors.HighlightText;
            this.dang.Enabled = false;
            this.dang.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dang.Location = new System.Drawing.Point(535, 391);
            this.dang.Mask = "";
            this.dang.MaxLength = 10;
            this.dang.Name = "dang";
            this.dang.Size = new System.Drawing.Size(49, 21);
            this.dang.TabIndex = 2;
            // 
            // soluong
            // 
            this.soluong.BackColor = System.Drawing.SystemColors.HighlightText;
            this.soluong.Enabled = false;
            this.soluong.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soluong.Location = new System.Drawing.Point(357, 414);
            this.soluong.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.Decimal;
            this.soluong.Name = "soluong";
            this.soluong.Size = new System.Drawing.Size(65, 21);
            this.soluong.TabIndex = 5;
            this.soluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.soluong.Validated += new System.EventHandler(this.soluong_Validated);
            // 
            // sotien
            // 
            this.sotien.BackColor = System.Drawing.SystemColors.HighlightText;
            this.sotien.Enabled = false;
            this.sotien.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sotien.Location = new System.Drawing.Point(630, 414);
            this.sotien.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.Decimal;
            this.sotien.Name = "sotien";
            this.sotien.Size = new System.Drawing.Size(154, 21);
            this.sotien.TabIndex = 7;
            this.sotien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sotien.Validated += new System.EventHandler(this.sotien_Validated);
            // 
            // butMoi
            // 
            this.butMoi.Image = ((System.Drawing.Image)(resources.GetObject("butMoi.Image")));
            this.butMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butMoi.Location = new System.Drawing.Point(56, 488);
            this.butMoi.Name = "butMoi";
            this.butMoi.Size = new System.Drawing.Size(60, 25);
            this.butMoi.TabIndex = 20;
            this.butMoi.Text = "  &Mới";
            this.butMoi.Click += new System.EventHandler(this.butMoi_Click);
            // 
            // butSua
            // 
            this.butSua.Image = ((System.Drawing.Image)(resources.GetObject("butSua.Image")));
            this.butSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butSua.Location = new System.Drawing.Point(116, 488);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(60, 25);
            this.butSua.TabIndex = 21;
            this.butSua.Text = "   &Sửa";
            this.butSua.Click += new System.EventHandler(this.butSua_Click);
            // 
            // butLuu
            // 
            this.butLuu.Enabled = false;
            this.butLuu.Image = ((System.Drawing.Image)(resources.GetObject("butLuu.Image")));
            this.butLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butLuu.Location = new System.Drawing.Point(176, 488);
            this.butLuu.Name = "butLuu";
            this.butLuu.Size = new System.Drawing.Size(60, 25);
            this.butLuu.TabIndex = 18;
            this.butLuu.Text = "  &Lưu";
            this.butLuu.Click += new System.EventHandler(this.butLuu_Click);
            // 
            // butBoqua
            // 
            this.butBoqua.Enabled = false;
            this.butBoqua.Image = ((System.Drawing.Image)(resources.GetObject("butBoqua.Image")));
            this.butBoqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butBoqua.Location = new System.Drawing.Point(236, 488);
            this.butBoqua.Name = "butBoqua";
            this.butBoqua.Size = new System.Drawing.Size(60, 25);
            this.butBoqua.TabIndex = 19;
            this.butBoqua.Text = "   &Bỏ qua";
            this.butBoqua.Click += new System.EventHandler(this.butBoqua_Click);
            // 
            // butHuy
            // 
            this.butHuy.Image = ((System.Drawing.Image)(resources.GetObject("butHuy.Image")));
            this.butHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butHuy.Location = new System.Drawing.Point(296, 488);
            this.butHuy.Name = "butHuy";
            this.butHuy.Size = new System.Drawing.Size(60, 25);
            this.butHuy.TabIndex = 22;
            this.butHuy.Text = "&Hủy";
            this.butHuy.Click += new System.EventHandler(this.butHuy_Click);
            // 
            // butIn
            // 
            this.butIn.Image = ((System.Drawing.Image)(resources.GetObject("butIn.Image")));
            this.butIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butIn.Location = new System.Drawing.Point(356, 488);
            this.butIn.Name = "butIn";
            this.butIn.Size = new System.Drawing.Size(60, 25);
            this.butIn.TabIndex = 23;
            this.butIn.Text = "&In";
            this.butIn.Click += new System.EventHandler(this.butIn_Click);
            // 
            // butKetthuc
            // 
            this.butKetthuc.Image = ((System.Drawing.Image)(resources.GetObject("butKetthuc.Image")));
            this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butKetthuc.Location = new System.Drawing.Point(416, 488);
            this.butKetthuc.Name = "butKetthuc";
            this.butKetthuc.Size = new System.Drawing.Size(72, 25);
            this.butKetthuc.TabIndex = 24;
            this.butKetthuc.Text = "   &Kết thúc";
            this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
            // 
            // stt
            // 
            this.stt.Enabled = false;
            this.stt.Location = new System.Drawing.Point(64, 256);
            this.stt.Name = "stt";
            this.stt.Size = new System.Drawing.Size(40, 20);
            this.stt.TabIndex = 60;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(-3, 434);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 23);
            this.label15.TabIndex = 61;
            this.label15.Text = "Hạn dùng :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(98, 438);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(64, 23);
            this.label24.TabIndex = 62;
            this.label24.Text = "Số hiệu :";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // handung
            // 
            this.handung.BackColor = System.Drawing.SystemColors.HighlightText;
            this.handung.Enabled = false;
            this.handung.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handung.Location = new System.Drawing.Point(56, 437);
            this.handung.Mask = "####";
            this.handung.Name = "handung";
            this.handung.Size = new System.Drawing.Size(57, 21);
            this.handung.TabIndex = 8;
            this.handung.Text = "    ";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(419, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 67;
            this.label1.Text = "Đơn giá :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dongia
            // 
            this.dongia.BackColor = System.Drawing.SystemColors.HighlightText;
            this.dongia.Enabled = false;
            this.dongia.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dongia.Location = new System.Drawing.Point(476, 414);
            this.dongia.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.Decimal;
            this.dongia.Name = "dongia";
            this.dongia.Size = new System.Drawing.Size(108, 21);
            this.dongia.TabIndex = 6;
            this.dongia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dongia.Validated += new System.EventHandler(this.dongia_Validated);
            // 
            // losx
            // 
            this.losx.BackColor = System.Drawing.SystemColors.HighlightText;
            this.losx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.losx.Enabled = false;
            this.losx.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.losx.Location = new System.Drawing.Point(160, 437);
            this.losx.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.losx.MaxLength = 20;
            this.losx.Name = "losx";
            this.losx.Size = new System.Drawing.Size(144, 21);
            this.losx.TabIndex = 9;
            // 
            // tim
            // 
            this.tim.Location = new System.Drawing.Point(8, 2);
            this.tim.Name = "tim";
            this.tim.Size = new System.Drawing.Size(776, 20);
            this.tim.TabIndex = 68;
            this.tim.Text = "Tìm kiếm";
            this.tim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tim.TextChanged += new System.EventHandler(this.tim_TextChanged);
            this.tim.Enter += new System.EventHandler(this.tim_Enter);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(294, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 69;
            this.label2.Text = "Số QĐ :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(460, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 70;
            this.label3.Text = "Năm SX :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(592, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 71;
            this.label4.Text = "Năm đưa vào sử dụng :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(142, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 72;
            this.label5.Text = "Tỷ lệ khấu hao :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(272, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 23);
            this.label6.TabIndex = 73;
            this.label6.Text = "%";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(624, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 23);
            this.label7.TabIndex = 74;
            this.label7.Text = "Phân loại :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(293, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 23);
            this.label8.TabIndex = 75;
            this.label8.Text = "Tình trạng :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(453, 459);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 23);
            this.label10.TabIndex = 76;
            this.label10.Text = "Nguồn gốc :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(-6, 461);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 23);
            this.label11.TabIndex = 77;
            this.label11.Text = "Bảo hành :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sothe
            // 
            this.sothe.BackColor = System.Drawing.SystemColors.HighlightText;
            this.sothe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.sothe.Enabled = false;
            this.sothe.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sothe.Location = new System.Drawing.Point(357, 437);
            this.sothe.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.sothe.MaxLength = 20;
            this.sothe.Name = "sothe";
            this.sothe.Size = new System.Drawing.Size(105, 21);
            this.sothe.TabIndex = 10;
            // 
            // tyle
            // 
            this.tyle.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tyle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tyle.Enabled = false;
            this.tyle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tyle.Location = new System.Drawing.Point(230, 461);
            this.tyle.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.tyle.Name = "tyle";
            this.tyle.Size = new System.Drawing.Size(40, 21);
            this.tyle.TabIndex = 14;
            // 
            // phanloai
            // 
            this.phanloai.BackColor = System.Drawing.SystemColors.HighlightText;
            this.phanloai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.phanloai.Enabled = false;
            this.phanloai.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phanloai.Location = new System.Drawing.Point(696, 461);
            this.phanloai.Name = "phanloai";
            this.phanloai.Size = new System.Drawing.Size(88, 21);
            this.phanloai.TabIndex = 17;
            this.phanloai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phanloai_KeyDown);
            // 
            // tinhtrang
            // 
            this.tinhtrang.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tinhtrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tinhtrang.Enabled = false;
            this.tinhtrang.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinhtrang.Location = new System.Drawing.Point(357, 461);
            this.tinhtrang.Name = "tinhtrang";
            this.tinhtrang.Size = new System.Drawing.Size(105, 21);
            this.tinhtrang.TabIndex = 15;
            this.tinhtrang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tinhtrang_KeyDown);
            // 
            // nguongoc
            // 
            this.nguongoc.BackColor = System.Drawing.SystemColors.HighlightText;
            this.nguongoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nguongoc.Enabled = false;
            this.nguongoc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nguongoc.Location = new System.Drawing.Point(531, 461);
            this.nguongoc.Name = "nguongoc";
            this.nguongoc.Size = new System.Drawing.Size(103, 21);
            this.nguongoc.TabIndex = 16;
            this.nguongoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nguongoc_KeyDown);
            // 
            // baohanh
            // 
            this.baohanh.BackColor = System.Drawing.SystemColors.HighlightText;
            this.baohanh.Enabled = false;
            this.baohanh.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baohanh.Location = new System.Drawing.Point(56, 461);
            this.baohanh.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.baohanh.Name = "baohanh";
            this.baohanh.Size = new System.Drawing.Size(48, 21);
            this.baohanh.TabIndex = 13;
            this.baohanh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.namsx_KeyDown);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(110, 459);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 23);
            this.label12.TabIndex = 86;
            this.label12.Text = "tháng";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listDMBD
            // 
            this.listDMBD.BackColor = System.Drawing.SystemColors.Info;
            this.listDMBD.ColumnCount = 0;
            this.listDMBD.Location = new System.Drawing.Point(456, 536);
            this.listDMBD.MatchBufferTimeOut = 1000;
            this.listDMBD.MatchEntryStyle = Medisoft2009.Usercontrol.MatchEntryStyle.FirstLetterInsensitive;
            this.listDMBD.Name = "listDMBD";
            this.listDMBD.Size = new System.Drawing.Size(75, 17);
            this.listDMBD.TabIndex = 132;
            this.listDMBD.TextIndex = -1;
            this.listDMBD.TextMember = null;
            this.listDMBD.ValueIndex = -1;
            this.listDMBD.Visible = false;
            this.listDMBD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listDMBD_KeyDown);
            // 
            // nhomcc
            // 
            this.nhomcc.BackColor = System.Drawing.SystemColors.HighlightText;
            this.nhomcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nhomcc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhomcc.Location = new System.Drawing.Point(56, 414);
            this.nhomcc.Name = "nhomcc";
            this.nhomcc.Size = new System.Drawing.Size(248, 21);
            this.nhomcc.TabIndex = 4;
            this.nhomcc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nhomcc_KeyDown_1);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(-6, 412);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 23);
            this.label14.TabIndex = 134;
            this.label14.Text = "Nhà cc :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // namsx
            // 
            this.namsx.BackColor = System.Drawing.SystemColors.HighlightText;
            this.namsx.Enabled = false;
            this.namsx.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namsx.Location = new System.Drawing.Point(521, 437);
            this.namsx.Mask = "##/##/####";
            this.namsx.MaxLength = 10;
            this.namsx.Name = "namsx";
            this.namsx.Size = new System.Drawing.Size(64, 21);
            this.namsx.TabIndex = 11;
            this.namsx.Text = "  /  /    ";
            this.namsx.Validated += new System.EventHandler(this.namsx_Validated);
            // 
            // namsd
            // 
            this.namsd.BackColor = System.Drawing.SystemColors.HighlightText;
            this.namsd.Enabled = false;
            this.namsd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namsd.Location = new System.Drawing.Point(720, 437);
            this.namsd.Mask = "####";
            this.namsd.MaxLength = 4;
            this.namsd.Name = "namsd";
            this.namsd.Size = new System.Drawing.Size(64, 21);
            this.namsd.TabIndex = 12;
            this.namsd.Text = "    ";
            this.namsd.Validated += new System.EventHandler(this.namsd_Validated);
            // 
            // frmKbtonct
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.losx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.namsd);
            this.Controls.Add(this.namsx);
            this.Controls.Add(this.manguon);
            this.Controls.Add(this.nhomcc);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.listDMBD);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.baohanh);
            this.Controls.Add(this.nguongoc);
            this.Controls.Add(this.tinhtrang);
            this.Controls.Add(this.phanloai);
            this.Controls.Add(this.tyle);
            this.Controls.Add(this.sothe);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tim);
            this.Controls.Add(this.dongia);
            this.Controls.Add(this.soluong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mabd);
            this.Controls.Add(this.sotien);
            this.Controls.Add(this.tenbd);
            this.Controls.Add(this.handung);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dang);
            this.Controls.Add(this.butKetthuc);
            this.Controls.Add(this.butIn);
            this.Controls.Add(this.butHuy);
            this.Controls.Add(this.butBoqua);
            this.Controls.Add(this.butLuu);
            this.Controls.Add(this.butSua);
            this.Controls.Add(this.butMoi);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ldvt);
            this.Controls.Add(this.lTen);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.stt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKbtonct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tồn đầu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKbtonct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baohanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void frmKbtonct_Load(object sender, System.EventArgs e)
		{
            if (Screen.PrimaryScreen.WorkingArea.Width > 800) this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            user = ttb.user; itable = ttb.tableid(s_mmyy, "ttb_tonkhoct"); xxx = user;// +s_mmyy;
			format_sotien=ttb.format_sotien(i_nhom);
			format_dongia=ttb.format_dongia(i_nhom);
			format_soluong=ttb.format_soluong(i_nhom);
			bKhoaso=ttb.bKhoaso(i_nhom,s_mmyy);
			manguon.DisplayMember="TEN";
			manguon.ValueMember="ID";
			if (ttb.bQuanlynguon(i_nhom))
				dtnguon=ttb.get_data("select * from "+user+".ttb_dmnguon where nhom="+i_nhom+" order by stt").Tables[0];
			else
                dtnguon = ttb.get_data("select * from " + user + ".ttb_dmnguon where id=0 or nhom=" + i_nhom + " order by stt").Tables[0];
			manguon.DataSource=dtnguon;

            nhomcc.DisplayMember = "TEN";
            nhomcc.ValueMember = "ID";
            if (ttb.bQuanlynhomcc(i_nhom))
                nhomcc.DataSource = ttb.get_data("select * from " + user + ".ttb_dmnx where nhom=" + i_nhom + " order by stt").Tables[0];
            else
                nhomcc.DataSource = ttb.get_data("select * from " + user + ".ttb_dmnx where id=0 or nhom=" + i_nhom + " order by stt").Tables[0];

			tinhtrang.DisplayMember="TEN";
			tinhtrang.ValueMember="ID";
            tinhtrang.DataSource = ttb.get_data("select * from " + user + ".ttb_dmtinhtrang where nhom=" + i_nhom + " order by stt").Tables[0];

			nguongoc.DisplayMember="TEN";
			nguongoc.ValueMember="ID";
            nguongoc.DataSource = ttb.get_data("select * from " + user + ".ttb_dmnguongoc where nhom=" + i_nhom + " order by stt").Tables[0];

			phanloai.DisplayMember="TEN";
			phanloai.ValueMember="ID";
            phanloai.DataSource = ttb.get_data("select * from " + user + ".ttb_dmloai where nhom=" + i_nhom + " order by stt").Tables[0];

			listDMBD.DisplayMember="TEN";
			listDMBD.ValueMember="MA";
			load_dm();
			
			load_grid();
			AddGridTableStyle();
			ref_text(0);
		}

		private void load_grid()
		{
			sql="select 1 as tt,a.stt,t.manguon,t.nhomcc,c.ten as tennguon,d.ten as tennhomcc,b.ma,trim(b.ten)||' '||b.hamluong as tenbd,b.tenhc,b.dang,t.handung,t.losx,a.tondau,a.tondau*t.giamua as sttondau,a.slnhap,a.slnhap*t.giamua as stnhap,a.slxuat,a.slxuat*t.giamua as stxuat,t.giamua as dongia,";
			sql+="t.namsx,t.namsd,case when e.tyle is null then 0 else e.tyle end as tyle,case when e.phanloai is null then 0 else e.phanloai end as phanloai,t.baohanh,t.nguongoc,t.tinhtrang,t.sothe,b.id ";
			sql+=" from "+xxx+".ttb_tonkhoct a inner join "+user+".ttb_dmbd b on a.mabd=b.id ";
            sql+=" inner join "+xxx+".ttb_theodoi t on a.stt=t.id ";
            sql+=" inner join "+user+".ttb_dmnguon c on t.manguon=c.id ";
            sql+=" inner join "+user+".ttb_dmnx d on t.nhomcc=d.id ";
            sql+=" left join "+xxx+".ttb_theodoitscd e on t.id=e.sttt";
            sql+=" left join "+user+".ttb_dmloaitscd f on e.phanloai=f.id ";
            sql+=" left join "+user+".ttb_dmtinhtrang g on t.tinhtrang=g.id ";
            sql+=" left join "+user+".ttb_dmnguongoc h on t.nguongoc=h.id ";
			sql+=" where a.mmyy='"+s_mmyy+"' and a.tondau<>0 and a.makho="+i_makho;
			sql+=" order by a.stt";
			dt=ttb.get_data(sql).Tables[0];
			dataGrid1.DataSource=dt;
			string mmyyt=ttb.Mmyy_truoc(s_mmyy);
			if (ttb.bMmyy(mmyyt))
			{
				DataRow r1;
				DataTable tmp=ttb.get_data("select stt from "+user+".ttb_tonkhoct where (tondau<>0 or slnhap<>0 or slxuat<>0) and mmyy='"+mmyyt+"' and (makho="+i_makho+")").Tables[0];
				foreach(DataRow r in dt.Rows)
				{
					r1=ttb.getrowbyid(tmp,"stt="+decimal.Parse(r["stt"].ToString()));
					if (r1==null) r["tt"]=0;
				}
			}
		}

		private void AddGridTableStyle()
		{
			DataGridColoredTextBoxColumn TextCol;
			delegateGetColorRowCol de = new delegateGetColorRowCol(MyGetColorRowCol);
			DataGridTableStyle ts =new DataGridTableStyle();
			ts.AlternatingBackColor = Color.Beige;
			ts.BackColor = Color.GhostWhite;
			ts.ForeColor = Color.MidnightBlue;
			ts.GridLineColor = Color.RoyalBlue;
			ts.HeaderBackColor = Color.MidnightBlue;
			ts.HeaderForeColor = Color.Lavender;
			ts.SelectionBackColor = Color.Teal;
			ts.SelectionForeColor = Color.PaleGreen;
			ts.RowHeaderWidth=10;
			ts.MappingName = dt.TableName;
			ts.AllowSorting=false;
			
			TextCol=new DataGridColoredTextBoxColumn(de, 0);
			TextCol.MappingName = "stt";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridColoredTextBoxColumn(de, 1);
			TextCol.MappingName = "tennguon";
			TextCol.HeaderText = "Nguồn";
			TextCol.Width = (ttb.bQuanlynguon(i_nhom))?80:0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridColoredTextBoxColumn(de, 2);
			TextCol.MappingName = "ma";
			TextCol.HeaderText = "Mã số";
			TextCol.Width = 50;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridColoredTextBoxColumn(de, 3);
			TextCol.MappingName = "tenbd";
			TextCol.HeaderText = "Tên";
			TextCol.Width = 200;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridColoredTextBoxColumn(de, 4);
			TextCol.MappingName = "dang";
			TextCol.HeaderText = "ĐVT";
			TextCol.Width = 50;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridColoredTextBoxColumn(de, 5);
			TextCol.MappingName = "handung";
			TextCol.HeaderText = "Date";
			TextCol.Width = (ttb.bQuanlyhandung(i_nhom))?30:0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridColoredTextBoxColumn(de, 6);
			TextCol.MappingName = "losx";
			TextCol.HeaderText = "Số hiệu";
			TextCol.Width = 80;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridColoredTextBoxColumn(de, 7);
			TextCol.MappingName = "sothe";
			TextCol.HeaderText = "Số QĐ";
			TextCol.Width = 100;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridColoredTextBoxColumn(de, 8);
			TextCol.MappingName = "tondau";
			TextCol.HeaderText = "Tồn đầu";
			TextCol.Width = 60;
			TextCol.Format=format_soluong;
			TextCol.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridColoredTextBoxColumn(de, 9);
			TextCol.MappingName = "dongia";
			TextCol.HeaderText = "Đơn giá";
			TextCol.Width = 80;
			TextCol.Format=format_dongia;
			TextCol.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridColoredTextBoxColumn(de, 10);
			TextCol.MappingName = "sttondau";
			TextCol.HeaderText = "Số tiền";
			TextCol.Width = 100;
			TextCol.Format=format_sotien;
			TextCol.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridColoredTextBoxColumn(de, 11);
			TextCol.MappingName = "tt";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

		}

		public Color MyGetColorRowCol(int row, int col)
		{
			return (this.dataGrid1[row,11].ToString().Trim()=="0")?Color.Red:Color.Black;
		}

		public delegate Color delegateGetColorRowCol(int row, int col);
		public class DataGridColoredTextBoxColumn : DataGridTextBoxColumn
		{
			private delegateGetColorRowCol _getColorRowCol;
			private int _column;
			public DataGridColoredTextBoxColumn(delegateGetColorRowCol getcolorRowCol, int column)
			{
				_getColorRowCol = getcolorRowCol;
				_column = column;
			}
			protected override void Paint(System.Drawing.Graphics g, System.Drawing.Rectangle bounds, System.Windows.Forms.CurrencyManager source, int rowNum, System.Drawing.Brush backBrush, System.Drawing.Brush foreBrush, bool alignToRight)
			{
				try
				{
					foreBrush = new SolidBrush(_getColorRowCol(rowNum, this._column));
					//backBrush = new SolidBrush(Color.GhostWhite);
				}
			
				catch{}
				finally
				{
					base.Paint(g, bounds, source, rowNum, backBrush, foreBrush, alignToRight);
				}
			}
		}

		private void ref_text(decimal id)
		{
			try
			{
				if (id==0)
				{
					int i=dataGrid1.CurrentCell.RowNumber;
					r=ttb.getrowbyid(dt,"stt="+decimal.Parse(dataGrid1[i,0].ToString()));
				}
				else r=ttb.getrowbyid(dt,"stt="+id);
				if (r!=null)
				{
					stt.Text=r["stt"].ToString();
					manguon.SelectedValue=r["manguon"].ToString();
					mabd.Text=r["ma"].ToString();
					tenbd.Text=r["tenbd"].ToString();
					dang.Text=r["dang"].ToString();
					handung.Text=r["handung"].ToString();
					losx.Text=r["losx"].ToString();
					sothe.Text=r["sothe"].ToString();
					baohanh.Value=decimal.Parse(r["baohanh"].ToString());
					tyle.Text=r["tyle"].ToString();
					namsx.Text=r["namsx"].ToString();
					namsd.Text=r["namsd"].ToString();
					nguongoc.SelectedValue=r["nguongoc"].ToString();
					tinhtrang.SelectedValue=r["tinhtrang"].ToString();
					phanloai.SelectedValue=r["phanloai"].ToString();
					d_soluong=(r["tondau"].ToString()!="")?decimal.Parse(r["tondau"].ToString()):0;
					d_sotien=(r["sttondau"].ToString()!="")?decimal.Parse(r["sttondau"].ToString()):0;
					d_dongia=(r["dongia"].ToString()!="")?decimal.Parse(r["dongia"].ToString()):0;
					d_slnhap=(r["slnhap"].ToString()!="")?decimal.Parse(r["slnhap"].ToString()):0;
					d_slxuat=(r["slxuat"].ToString()!="")?decimal.Parse(r["slxuat"].ToString()):0;
					soluong.Text=d_soluong.ToString(format_soluong);
					dongia.Text=d_dongia.ToString(format_dongia);
					sotien.Text=d_sotien.ToString(format_sotien);
					l_id=decimal.Parse(stt.Text);
					d_soluongcu=d_soluong;
                    nhomcc.SelectedValue = r["nhomcc"].ToString();
				}
			}
			catch{}
		}

		private void load_dm()
		{
            dtdmbd = ttb.get_data("select a.ma,trim(a.ten)||' '||a.hamluong as ten,a.dang,a.sodk,b.ten as tenhang,c.ten as tennuoc,a.id,a.tyle from " + user + ".ttb_dmbd a left join " + user + ".ttb_dmhang b on a.mahang=b.id left join "+user+".ttb_dmnuoc c on a.manuoc=c.id where a.nhom=" + i_nhom + " and a.hide=0 order by a.ten").Tables[0];
			listDMBD.DataSource=dtdmbd;
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

		private void tenbd_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Down || e.KeyCode==Keys.Up) listDMBD.Focus();
			else if (e.KeyCode==Keys.Enter)
			{
				if (listDMBD.Visible) listDMBD.Focus();
				else SendKeys.Send("{Tab}");
			}
		}

		private void tenbd_TextChanged(object sender, System.EventArgs e)
		{
			if (this.ActiveControl==tenbd)
			{
				Filter_dmbd(tenbd.Text);
				if (manguon.Enabled)
					listDMBD.BrowseToDmttb(tenbd,mabd,manguon,mabd.Location.X,mabd.Location.Y + mabd.Height-2,mabd.Width*2+tenbd.Width*2+25+nhomcc.Width,mabd.Height+5);
				else 
					listDMBD.BrowseToDmttb(tenbd,mabd,soluong,mabd.Location.X,mabd.Location.Y + mabd.Height-2,mabd.Width*2+tenbd.Width*2+25+nhomcc.Width,mabd.Height+5);
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
                    losx.Text = r["sodk"].ToString();
                    tyle.Text = r["tyle"].ToString();
				}
			}
			SendKeys.Send("{F4}");
		}

		private void ena_object(bool ena)
		{
			dataGrid1.Enabled=!ena;
			if (ttb.bQuanlynguon(i_nhom)) manguon.Enabled=ena;
			else manguon.SelectedValue="0";
            if (ttb.bQuanlynhomcc(i_nhom)) nhomcc.Enabled = ena;
            else nhomcc.SelectedValue = "0";
			if (ttb.bNhapmaso) mabd.Enabled=ena;
			tenbd.Enabled=ena;
			soluong.Enabled=ena;
			if (ttb.bQuanlyhandung(i_nhom)) handung.Enabled=ena;
			if (ttb.bQuanlylosx(i_nhom)) losx.Enabled=ena;
			if (ttb.bDongia(i_nhom)) dongia.Enabled=ena;
			else sotien.Enabled=ena;
			butMoi.Enabled=!ena;
			butSua.Enabled=!ena;
			butLuu.Enabled=ena;
			butBoqua.Enabled=ena;
			butHuy.Enabled=!ena;
			butIn.Enabled=!ena;
			butKetthuc.Enabled=!ena;
			tinhtrang.Enabled=ena;
			nguongoc.Enabled=ena;
			phanloai.Enabled=ena;
			sothe.Enabled=ena;
			namsx.Enabled=ena;
			namsd.Enabled=ena;
			//tyle.Enabled=ena;
			baohanh.Enabled=ena;
			if (ttb.bDanhmuc || ttb.bDmbd)
			{
				if (ttb.bDanhmuc) ttb.writeXml("ttb_thongso","c01","0");
				else ttb.writeXml("ttb_thongso","c06","0");
				load_dm();
			}
        }

		private void emp_detail()
		{
			l_id=0;
			mabd.Text="";
			tenbd.Text="";
			dang.Text="";
			soluong.Text="";
			sotien.Text="";
			dongia.Text="";
			handung.Text="";
			losx.Text="";
			sothe.Text="";
			stt.Text="";
			d_soluongcu=0;
			d_slnhap=0;
			d_slxuat=0;
			tyle.Text="0";
			baohanh.Value=0;
			namsx.Text="";namsd.Text="";
		}

		private void butMoi_Click(object sender, System.EventArgs e)
		{
			if (bKhoaso)
			{
				MessageBox.Show("Số liệu tháng "+s_mmyy.Substring(0,2)+" năm "+s_mmyy.Substring(2,2)+" đã khóa !\nNếu cần thay đổi thì vào mục khai báo hệ thống",ttb.Msg);
				return;
			}
			ena_object(true);
			emp_detail();
			if (mabd.Enabled) mabd.Focus();
			else tenbd.Focus();
		}
		private void butSua_Click(object sender, System.EventArgs e)
		{
			if (dt.Rows.Count==0) return;
			if (bKhoaso)
			{
				MessageBox.Show("Số liệu tháng "+s_mmyy.Substring(0,2)+" năm "+s_mmyy.Substring(2,2)+" đã khóa !\nNếu cần thay đổi thì vào mục khai báo hệ thống",ttb.Msg);
				return;
			}
			l_id=decimal.Parse(stt.Text);
			ena_object(true);
            mabd.Enabled = false;
            tenbd.Enabled = false;
            soluong.Focus();
            /*
			if (mabd.Enabled) mabd.Focus();
			else tenbd.Focus();
            */
		}

		private bool KiemtraDetail()
		{
			i_mabd=0;
			if (mabd.Text=="" && tenbd.Text=="")
			{
				mabd.Focus();
				return false;
			}
			if ((mabd.Text=="" && tenbd.Text!="") || (mabd.Text!="" && tenbd.Text==""))
			{
				if (mabd.Text=="")
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
				mabd.Focus();
				return false;
			}
			i_mabd=int.Parse(r["id"].ToString());
			if (soluong.Text=="" || soluong.Text=="0.00" || soluong.Text=="0")
			{
				MessageBox.Show("Nhập số lượng !",ttb.Msg);
				soluong.Focus();
				return false;
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
            if (ttb.bQuanlynhomcc(i_nhom))
            {
                if (nhomcc.SelectedIndex == -1 || nhomcc.SelectedValue.ToString() == "0")
                {
                    MessageBox.Show("Nhà cung cấp không hợp lệ !", ttb.Msg);
                    nhomcc.Focus();
                    return false;
                }
            }
            else nhomcc.SelectedValue = "0";
			d_soluong=(soluong.Text!="")?decimal.Parse(soluong.Text):0;
			d_dongia=(dongia.Text!="")?decimal.Parse(dongia.Text):0;
			d_sotien=(sotien.Text!="")?decimal.Parse(sotien.Text):0;
			handung.Text=handung.Text.Trim().PadRight(4,'0');
			handung.Refresh();
            if ((sothe.Text != "" || losx.Text != "") && l_id == 0)
            {
                DataRow r1 = ttb.getrowbyid(dt, "id=" + i_mabd + " and losx='" + losx.Text + "' and sothe='" + sothe.Text + "'");
                if (r1 != null)
                {
                    MessageBox.Show("Số hiệu : " + losx.Text + "\nSố QĐ : " + sothe.Text + "\nĐã nhập !", ttb.Msg);
                    if (mabd.Enabled) mabd.Focus();
                    else tenbd.Focus();
                    return false;
                }
            }
			return true;
		}

		private void butLuu_Click(object sender, System.EventArgs e)
		{
			if (!KiemtraDetail()) return;
			bool bEdit=l_id!=0;
            if (l_id == 0)
            {
                l_id = ttb.get_id_tonkho;
                ttb.upd_eve_tables(s_mmyy, itable, i_userid, "ins");
            }
            else
            {
                ttb.upd_eve_upd_del(s_mmyy, itable, i_userid, "upd", ttb.fields("ttb_tonkhoct", "makho=" + i_makho + " and stt=" + l_id));
                ttb.upd_eve_tables(s_mmyy, itable, i_userid, "upd");
            }
            decimal _dongia = ttb.Round(d_sotien / d_soluong, 10);
            if (manguon.SelectedValue == null)
            {
                manguon.Focus();
                return;
            }
            if (nhomcc.SelectedValue == null)
            {
                nhomcc.Focus();
                return;
            }
            ttb.upd_theodoi(s_mmyy, l_id, i_mabd, int.Parse(manguon.SelectedValue.ToString()), int.Parse(nhomcc.SelectedValue.ToString()), handung.Text, losx.Text, sothe.Text, namsx.Text, namsd.Text, Convert.ToInt16(baohanh.Value), (nguongoc.SelectedIndex == -1) ? 0 : int.Parse(nguongoc.SelectedValue.ToString()), (tinhtrang.SelectedIndex == -1) ? 0 : int.Parse(tinhtrang.SelectedValue.ToString()), _dongia, d_dongia, _dongia, 0, 0);
			if (!ttb.upd_tonkhoct(s_mmyy,i_makho,l_id,i_mabd,d_soluong))
			{
				MessageBox.Show("Không cập nhật được thông tin tồn kho !",ttb.Msg);
				return;
			}
            ttb.upd_tonkhoth(s_mmyy, i_makho, int.Parse(manguon.SelectedValue.ToString()), i_mabd, d_soluong, "tondau");
			ttb.upd_theodoitscd(s_mmyy,l_id,decimal.Parse("20"+s_mmyy.Substring(2,2)),(tyle.Text=="")?0:decimal.Parse(tyle.Text),(phanloai.SelectedIndex==-1)?0:int.Parse(phanloai.SelectedValue.ToString()));
			if (d_dongia>0) ttb.execute_data("update "+user+".ttb_dmbd set dongia="+d_dongia+",giaban="+d_dongia+" where id="+i_mabd);
			if (bEdit) ttb.upd_tonkho(s_mmyy,i_nhom,1);			
			ena_object(false);
			load_grid();
			ref_text(0);
			butMoi.Focus();
		}

		private void butBoqua_Click(object sender, System.EventArgs e)
		{
			ena_object(false);
			butMoi.Focus();
		}

		private void manguon_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter || e.KeyCode==Keys.Tab)
			{
				if (manguon.SelectedIndex==-1) manguon.SelectedIndex=0;
				SendKeys.Send("{Tab}{F4}");
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
                    losx.Text = r["sodk"].ToString();
                    tyle.Text = r["tyle"].ToString();
				}
			}
			if(!listDMBD.Focused) listDMBD.Hide();
		}

		private void listDMBD_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter)	mabd_Validated(null,null);
		}

		private void dataGrid1_CurrentCellChanged(object sender, System.EventArgs e)
		{
			ref_text(0);
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
				if (d_soluong+d_slnhap-d_slxuat<0)
				{
					MessageBox.Show("Số lượng không hợp lệ (Tồn kho sẽ bị âm) !",ttb.Msg);
					soluong.Text=d_soluongcu.ToString(format_soluong);
					soluong.Focus();
				}
			}
			catch{}
			tinh_giatri();
		}

		private void tinh_giatri()
		{
			try
			{
				d_soluong=(soluong.Text!="")?decimal.Parse(soluong.Text):0;
				if (ttb.bDongia(i_nhom))
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
			}
			catch{}
		}

		private void butHuy_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (dt.Rows.Count==0) return;
				if (bKhoaso)
				{
					MessageBox.Show("Số liệu tháng "+s_mmyy.Substring(0,2)+" năm "+s_mmyy.Substring(2,2)+" đã khóa !\nNếu cần thay đổi thì vào mục khai báo hệ thống",ttb.Msg);
					return;
				}
				if (d_slnhap!=0 || d_slxuat!=0)
				{
					MessageBox.Show(tenbd.Text.Trim()+" "+dang.Text.Trim()+"\nĐã nhập/xuất không cho phép hủy !",ttb.Msg);
					return;
				}
				if (MessageBox.Show("Đồng ý hủy thông tin này ?",ttb.Msg,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
				{
					r=ttb.getrowbyid(dtdmbd,"ma='"+mabd.Text+"'");
					if (r!=null)
					{
                        ttb.upd_eve_upd_del(s_mmyy, itable, i_userid, "del", ttb.fields("ttb_tonkhoct", "makho=" + i_makho + " and stt=" + l_id));
                        ttb.upd_eve_tables(s_mmyy, itable, i_userid, "del");
                        ttb.execute_data("delete from " + xxx + ".ttb_tonkhoct where mmyy='" + s_mmyy + "' and makho=" + i_makho + " and stt=" + l_id);
						ttb.upd_tonkhoth(ttb.delete,s_mmyy,i_makho,int.Parse(r["id"].ToString()),int.Parse(manguon.SelectedValue.ToString()),decimal.Parse(soluong.Text),"tondau");
						load_grid();
						ref_text(0);
					}
				}
			}
			catch{}
		}

		private void butIn_Click(object sender, System.EventArgs e)
		{
			string sql="select b.ma,trim(b.ten)||' '||b.hamluong as ten,b.tenhc,b.dang,a.tondau,a.tondau*t.giamua as sttondau, c.stt, c.ten as nhombd, t.manguon, d.ten as tennguon,t.giamua,t.giaban "+
				" from "+xxx+".ttb_tonkhoct a,"+user+".ttb_dmbd b,"+user+".ttb_dmnhom c,"+user+".ttb_dmnguon d,"+xxx+".ttb_theodoi t "+
                " where  a.mmyy='"+s_mmyy+"' and a.stt=t.id and a.mabd=b.id and b.manhom=c.id and t.manguon=d.id and a.tondau<>0 and a.makho=" + i_makho + " order by b.ten";
			DataTable ldt=ttb.get_data(sql).Tables[0];
			string tenfile="ttb_tondau.rpt";
			frmReport f=new frmReport(ttb,ldt,tenfile,this.Text.Trim().ToUpper(),"","","","","","","","","");
			f.ShowDialog();			
		}

		public void RefreshChildren(string text)
		{
			try
			{
				CurrencyManager cm= (CurrencyManager)BindingContext[dataGrid1.DataSource];
				DataView dv=(DataView)cm.List;
				dv.RowFilter="tenbd like '%"+text.Trim()+"%' or tenhc like '%"+text.Trim()+"%' or ma like '%"+text.Trim()+"%'";
				if (text!="") ref_text(0);
				else ref_text(l_id);
			}
			catch{}
		}

		private void nhomcc_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter || e.KeyCode==Keys.Tab) SendKeys.Send("{Tab}");
		}

		private void mabd_TextChanged(object sender, System.EventArgs e)
		{
			if (this.ActiveControl==mabd)
			{
				Filter_mabd(mabd.Text);
				if (manguon.Enabled)
					listDMBD.BrowseToDmttb(mabd,tenbd,manguon,mabd.Location.X,mabd.Location.Y + mabd.Height-2,mabd.Width*2+tenbd.Width*2+25+nhomcc.Width,mabd.Height+5);
				else 
					listDMBD.BrowseToDmttb(mabd,tenbd,soluong,mabd.Location.X,mabd.Location.Y + mabd.Height-2,mabd.Width*2+tenbd.Width*2+25+nhomcc.Width,mabd.Height+5);
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

		private void tim_Enter(object sender, System.EventArgs e)
		{
			tim.Text="";
		}

		private void tim_TextChanged(object sender, System.EventArgs e)
		{
			if (this.ActiveControl==tim) RefreshChildren(tim.Text);
		}

		private void namsx_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
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

		private void phanloai_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter || e.KeyCode==Keys.Tab)
			{
				if (phanloai.SelectedIndex==-1 && phanloai.Items.Count>0) phanloai.SelectedIndex=0;
				SendKeys.Send("{Tab}");
			}
		}

        private void nhomcc_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab) SendKeys.Send("{Tab}");
        }

        private void namsx_Validated(object sender, EventArgs e)
        {
            if (namsx.Text == "") return;
            namsx.Text = namsx.Text.Trim();
            if (namsx.Text.Length == 6) namsx.Text = namsx.Text + DateTime.Now.Year.ToString();
            if (!ttb.bNgay(namsx.Text))
            {
                MessageBox.Show("Ngày không hợp lệ !", ttb.Msg);
                namsx.Focus();
                return;
            }
            namsx.Text = ttb.Ktngaygio(namsx.Text, 10);
        }

        private void namsd_Validated(object sender, EventArgs e)
        {
            if (namsd.Text == "") return;
            namsd.Text = namsd.Text.Trim();
            //if (namsd.Text.Length == 6) namsd.Text = namsd.Text + DateTime.Now.Year.ToString();
            //if (!ttb.bNgay(namsd.Text))
            //{
            //    MessageBox.Show("Ngày không hợp lệ !", ttb.Msg);
            //    namsd.Focus();
            //    return;
            //}
            //namsd.Text = ttb.Ktngaygio(namsd.Text, 10);
        }
	}
}
