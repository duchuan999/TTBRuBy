using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using LibDuoc;
using doiso;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Duoc
{
	/// <summary>
	/// Summary description for frmTrathuoc.
	/// </summary>
	public class frmTrathuoc : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label10;
		private MaskedBox.MaskedBox ngaysp;
		private System.Windows.Forms.ComboBox makho;
		private LibList.List listDMBD;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label lTen;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox tenbd;
		private System.Windows.Forms.TextBox mabd;
		private MaskedBox.MaskedBox dang;
		private MaskedTextBox.MaskedTextBox soluong;
		private MaskedTextBox.MaskedTextBox dongia;
		private MaskedTextBox.MaskedTextBox sotien;
		private System.Windows.Forms.Button butMoi;
		private System.Windows.Forms.Button butSua;
		private System.Windows.Forms.Button butLuu;
		private System.Windows.Forms.Button butThem;
		private System.Windows.Forms.Button butXoa;
		private System.Windows.Forms.Button butBoqua;
		private System.Windows.Forms.Button butHuy;
		private System.Windows.Forms.Button butIn;
		private System.Windows.Forms.Button butKetthuc;
		private System.Windows.Forms.ComboBox cmbSophieu;
		private string s_mmyy,s_ngay,sql,s_loai,s_ngaysp,s_makho,s_userid,format_soluong,format_dongia,format_sotien;
		private int i_nhom,i_userid,i_mabd,i_old,i_songay,i_quayban;
		private long l_id;
		private decimal d_soluong,d_dongia,d_sotien,d_giaban;
		private bool bKhoaso,bGiaban,bNew,bAdmin,bNgtru_mabn;
		private AccessData d;
		private Doisototext doiso=new Doisototext();
		private DataTable dtdmbd=new DataTable();
		private DataTable dtdmnx=new DataTable();
		private DataTable dtll=new DataTable();
		private DataTable dtct=new DataTable();
		private DataTable dtold=new DataTable();
		private DataSet dsxoa=new DataSet();
		private System.Windows.Forms.Label ldvt;
		private DataRow r;
		private System.Windows.Forms.TextBox stt;
		private System.Windows.Forms.TextBox tenhc;
		private System.Windows.Forms.Label lTenhc;
		private MaskedTextBox.MaskedTextBox sophieu;
		private MaskedTextBox.MaskedTextBox giaban;
		private System.Windows.Forms.Label label25;
		private System.Drawing.Printing.PrintDocument docToPrint = new System.Drawing.Printing.PrintDocument();
		private PrintDialog p=new PrintDialog();
		private DialogResult result;
		private System.Windows.Forms.Label label3;
		private MaskedTextBox.MaskedTextBox hoten;
		private System.Windows.Forms.ComboBox manguon;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lbl;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTrathuoc(AccessData acc,string loai,string mmyy,string ngay,int nhom,int userid,string kho,string title,bool ban,bool admin,string user,int quayban)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			d=acc;
			i_quayban=quayban;
			i_nhom=nhom;s_makho=kho;
			i_userid=userid;s_mmyy=mmyy;s_ngay=ngay;
			s_loai=loai;s_userid=user;bGiaban=ban;bAdmin=admin;
			this.Text=title;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmTrathuoc));
			this.lbl = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.ngaysp = new MaskedBox.MaskedBox();
			this.makho = new System.Windows.Forms.ComboBox();
			this.listDMBD = new LibList.List();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.label13 = new System.Windows.Forms.Label();
			this.lTen = new System.Windows.Forms.Label();
			this.ldvt = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.tenbd = new System.Windows.Forms.TextBox();
			this.mabd = new System.Windows.Forms.TextBox();
			this.dang = new MaskedBox.MaskedBox();
			this.soluong = new MaskedTextBox.MaskedTextBox();
			this.dongia = new MaskedTextBox.MaskedTextBox();
			this.sotien = new MaskedTextBox.MaskedTextBox();
			this.butMoi = new System.Windows.Forms.Button();
			this.butSua = new System.Windows.Forms.Button();
			this.butLuu = new System.Windows.Forms.Button();
			this.butThem = new System.Windows.Forms.Button();
			this.butXoa = new System.Windows.Forms.Button();
			this.butBoqua = new System.Windows.Forms.Button();
			this.butHuy = new System.Windows.Forms.Button();
			this.butIn = new System.Windows.Forms.Button();
			this.butKetthuc = new System.Windows.Forms.Button();
			this.cmbSophieu = new System.Windows.Forms.ComboBox();
			this.stt = new System.Windows.Forms.TextBox();
			this.tenhc = new System.Windows.Forms.TextBox();
			this.lTenhc = new System.Windows.Forms.Label();
			this.sophieu = new MaskedTextBox.MaskedTextBox();
			this.giaban = new MaskedTextBox.MaskedTextBox();
			this.label25 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.hoten = new MaskedTextBox.MaskedTextBox();
			this.manguon = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl
			// 
			this.lbl.Location = new System.Drawing.Point(120, 8);
			this.lbl.Name = "lbl";
			this.lbl.Size = new System.Drawing.Size(56, 23);
			this.lbl.TabIndex = 2;
			this.lbl.Text = "Mã BN :";
			this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Ngày :";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(648, 8);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(48, 23);
			this.label10.TabIndex = 9;
			this.label10.Text = "Kho :";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ngaysp
			// 
			this.ngaysp.BackColor = System.Drawing.SystemColors.HighlightText;
			this.ngaysp.Enabled = false;
			this.ngaysp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ngaysp.Location = new System.Drawing.Point(56, 8);
			this.ngaysp.Mask = "##/##/####";
			this.ngaysp.MaxLength = 10;
			this.ngaysp.Name = "ngaysp";
			this.ngaysp.Size = new System.Drawing.Size(64, 21);
			this.ngaysp.TabIndex = 1;
			this.ngaysp.Text = "";
			this.ngaysp.Validated += new System.EventHandler(this.ngaysp_Validated);
			// 
			// makho
			// 
			this.makho.BackColor = System.Drawing.SystemColors.HighlightText;
			this.makho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.makho.Enabled = false;
			this.makho.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.makho.Location = new System.Drawing.Point(696, 8);
			this.makho.Name = "makho";
			this.makho.Size = new System.Drawing.Size(88, 21);
			this.makho.TabIndex = 7;
			this.makho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.makho_KeyDown);
			// 
			// listDMBD
			// 
			this.listDMBD.ColumnCount = 0;
			this.listDMBD.Location = new System.Drawing.Point(376, 544);
			this.listDMBD.MatchBufferTimeOut = 1000;
			this.listDMBD.MatchEntryStyle = AsYetUnnamed.MatchEntryStyle.FirstLetterInsensitive;
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
			this.dataGrid1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGrid1.CaptionBackColor = System.Drawing.SystemColors.Control;
			this.dataGrid1.CaptionFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGrid1.CaptionForeColor = System.Drawing.Color.MidnightBlue;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.FlatMode = true;
			this.dataGrid1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGrid1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.dataGrid1.GridLineColor = System.Drawing.Color.Gainsboro;
			this.dataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
			this.dataGrid1.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.dataGrid1.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
			this.dataGrid1.LinkColor = System.Drawing.Color.Teal;
			this.dataGrid1.Location = new System.Drawing.Point(8, 16);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro;
			this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.RowHeaderWidth = 10;
			this.dataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue;
			this.dataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
			this.dataGrid1.Size = new System.Drawing.Size(776, 416);
			this.dataGrid1.TabIndex = 27;
			this.dataGrid1.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(38, 436);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(32, 23);
			this.label13.TabIndex = 28;
			this.label13.Text = "Mã :";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lTen
			// 
			this.lTen.Location = new System.Drawing.Point(125, 436);
			this.lTen.Name = "lTen";
			this.lTen.Size = new System.Drawing.Size(30, 23);
			this.lTen.TabIndex = 29;
			this.lTen.Text = "Tên :";
			this.lTen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ldvt
			// 
			this.ldvt.Location = new System.Drawing.Point(36, 459);
			this.ldvt.Name = "ldvt";
			this.ldvt.Size = new System.Drawing.Size(34, 23);
			this.ldvt.TabIndex = 30;
			this.ldvt.Text = "ĐVT :";
			this.ldvt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(128, 458);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(56, 23);
			this.label16.TabIndex = 31;
			this.label16.Text = "Số lượng :";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(304, 458);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(56, 23);
			this.label17.TabIndex = 32;
			this.label17.Text = "Giá mua :";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(464, 458);
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
			this.tenbd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tenbd.Location = new System.Drawing.Point(154, 436);
			this.tenbd.Name = "tenbd";
			this.tenbd.Size = new System.Drawing.Size(286, 21);
			this.tenbd.TabIndex = 15;
			this.tenbd.Text = "";
			this.tenbd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tenbd_KeyDown);
			this.tenbd.Validated += new System.EventHandler(this.tenbd_Validated);
			this.tenbd.TextChanged += new System.EventHandler(this.tenbd_TextChanged);
			// 
			// mabd
			// 
			this.mabd.BackColor = System.Drawing.SystemColors.HighlightText;
			this.mabd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.mabd.Enabled = false;
			this.mabd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mabd.Location = new System.Drawing.Point(69, 436);
			this.mabd.Name = "mabd";
			this.mabd.Size = new System.Drawing.Size(57, 21);
			this.mabd.TabIndex = 14;
			this.mabd.Text = "";
			this.mabd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tenbd_KeyDown);
			this.mabd.Validated += new System.EventHandler(this.mabd_Validated);
			this.mabd.TextChanged += new System.EventHandler(this.mabd_TextChanged);
			// 
			// dang
			// 
			this.dang.BackColor = System.Drawing.SystemColors.HighlightText;
			this.dang.Enabled = false;
			this.dang.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dang.Location = new System.Drawing.Point(69, 459);
			this.dang.Mask = "";
			this.dang.MaxLength = 10;
			this.dang.Name = "dang";
			this.dang.Size = new System.Drawing.Size(59, 21);
			this.dang.TabIndex = 16;
			this.dang.Text = "";
			// 
			// soluong
			// 
			this.soluong.BackColor = System.Drawing.SystemColors.HighlightText;
			this.soluong.Enabled = false;
			this.soluong.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.soluong.Location = new System.Drawing.Point(184, 459);
			this.soluong.Masked = MaskedTextBox.MaskedTextBox.Mask.Decimal;
			this.soluong.Name = "soluong";
			this.soluong.Size = new System.Drawing.Size(115, 21);
			this.soluong.TabIndex = 17;
			this.soluong.Text = "";
			this.soluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.soluong.Validated += new System.EventHandler(this.soluong_Validated);
			// 
			// dongia
			// 
			this.dongia.BackColor = System.Drawing.SystemColors.HighlightText;
			this.dongia.Enabled = false;
			this.dongia.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dongia.Location = new System.Drawing.Point(360, 459);
			this.dongia.Masked = MaskedTextBox.MaskedTextBox.Mask.Decimal;
			this.dongia.Name = "dongia";
			this.dongia.Size = new System.Drawing.Size(111, 21);
			this.dongia.TabIndex = 18;
			this.dongia.Text = "";
			this.dongia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.dongia.Validated += new System.EventHandler(this.dongia_Validated);
			// 
			// sotien
			// 
			this.sotien.BackColor = System.Drawing.SystemColors.HighlightText;
			this.sotien.Enabled = false;
			this.sotien.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.sotien.Location = new System.Drawing.Point(520, 459);
			this.sotien.Masked = MaskedTextBox.MaskedTextBox.Mask.Decimal;
			this.sotien.Name = "sotien";
			this.sotien.Size = new System.Drawing.Size(112, 21);
			this.sotien.TabIndex = 19;
			this.sotien.Text = "";
			this.sotien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.sotien.Validated += new System.EventHandler(this.sotien_Validated);
			// 
			// butMoi
			// 
			this.butMoi.Image = ((System.Drawing.Bitmap)(resources.GetObject("butMoi.Image")));
			this.butMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butMoi.Location = new System.Drawing.Point(51, 490);
			this.butMoi.Name = "butMoi";
			this.butMoi.Size = new System.Drawing.Size(75, 28);
			this.butMoi.TabIndex = 29;
			this.butMoi.Text = "      &Mới";
			this.butMoi.Click += new System.EventHandler(this.butMoi_Click);
			// 
			// butSua
			// 
			this.butSua.Image = ((System.Drawing.Bitmap)(resources.GetObject("butSua.Image")));
			this.butSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butSua.Location = new System.Drawing.Point(128, 490);
			this.butSua.Name = "butSua";
			this.butSua.Size = new System.Drawing.Size(75, 28);
			this.butSua.TabIndex = 30;
			this.butSua.Text = "     &Sửa";
			this.butSua.Click += new System.EventHandler(this.butSua_Click);
			// 
			// butLuu
			// 
			this.butLuu.Enabled = false;
			this.butLuu.Image = ((System.Drawing.Bitmap)(resources.GetObject("butLuu.Image")));
			this.butLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butLuu.Location = new System.Drawing.Point(205, 490);
			this.butLuu.Name = "butLuu";
			this.butLuu.Size = new System.Drawing.Size(75, 28);
			this.butLuu.TabIndex = 27;
			this.butLuu.Text = "     &Lưu";
			this.butLuu.Click += new System.EventHandler(this.butLuu_Click);
			// 
			// butThem
			// 
			this.butThem.Enabled = false;
			this.butThem.Image = ((System.Drawing.Bitmap)(resources.GetObject("butThem.Image")));
			this.butThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butThem.Location = new System.Drawing.Point(282, 490);
			this.butThem.Name = "butThem";
			this.butThem.Size = new System.Drawing.Size(75, 28);
			this.butThem.TabIndex = 25;
			this.butThem.Text = "       &Thêm";
			this.butThem.Click += new System.EventHandler(this.butThem_Click);
			// 
			// butXoa
			// 
			this.butXoa.Enabled = false;
			this.butXoa.Image = ((System.Drawing.Bitmap)(resources.GetObject("butXoa.Image")));
			this.butXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butXoa.Location = new System.Drawing.Point(359, 490);
			this.butXoa.Name = "butXoa";
			this.butXoa.Size = new System.Drawing.Size(75, 28);
			this.butXoa.TabIndex = 26;
			this.butXoa.Text = "       &Xóa";
			this.butXoa.Click += new System.EventHandler(this.butXoa_Click);
			// 
			// butBoqua
			// 
			this.butBoqua.Enabled = false;
			this.butBoqua.Image = ((System.Drawing.Bitmap)(resources.GetObject("butBoqua.Image")));
			this.butBoqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butBoqua.Location = new System.Drawing.Point(436, 490);
			this.butBoqua.Name = "butBoqua";
			this.butBoqua.Size = new System.Drawing.Size(75, 28);
			this.butBoqua.TabIndex = 28;
			this.butBoqua.Text = "     &Bỏ qua";
			this.butBoqua.Click += new System.EventHandler(this.butBoqua_Click);
			// 
			// butHuy
			// 
			this.butHuy.Image = ((System.Drawing.Bitmap)(resources.GetObject("butHuy.Image")));
			this.butHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butHuy.Location = new System.Drawing.Point(513, 490);
			this.butHuy.Name = "butHuy";
			this.butHuy.Size = new System.Drawing.Size(75, 28);
			this.butHuy.TabIndex = 31;
			this.butHuy.Text = "     &Hủy";
			this.butHuy.Click += new System.EventHandler(this.butHuy_Click);
			// 
			// butIn
			// 
			this.butIn.Image = ((System.Drawing.Bitmap)(resources.GetObject("butIn.Image")));
			this.butIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butIn.Location = new System.Drawing.Point(590, 490);
			this.butIn.Name = "butIn";
			this.butIn.Size = new System.Drawing.Size(75, 28);
			this.butIn.TabIndex = 32;
			this.butIn.Text = "   &In";
			this.butIn.Click += new System.EventHandler(this.butIn_Click);
			// 
			// butKetthuc
			// 
			this.butKetthuc.Image = ((System.Drawing.Bitmap)(resources.GetObject("butKetthuc.Image")));
			this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butKetthuc.Location = new System.Drawing.Point(667, 490);
			this.butKetthuc.Name = "butKetthuc";
			this.butKetthuc.Size = new System.Drawing.Size(75, 28);
			this.butKetthuc.TabIndex = 33;
			this.butKetthuc.Text = "&Kết thúc";
			this.butKetthuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
			// 
			// cmbSophieu
			// 
			this.cmbSophieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSophieu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbSophieu.Location = new System.Drawing.Point(175, 8);
			this.cmbSophieu.Name = "cmbSophieu";
			this.cmbSophieu.Size = new System.Drawing.Size(96, 21);
			this.cmbSophieu.TabIndex = 4;
			this.cmbSophieu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSophieu_KeyDown);
			this.cmbSophieu.SelectedIndexChanged += new System.EventHandler(this.cmbSophieu_SelectedIndexChanged);
			// 
			// stt
			// 
			this.stt.Enabled = false;
			this.stt.Location = new System.Drawing.Point(64, 352);
			this.stt.Name = "stt";
			this.stt.Size = new System.Drawing.Size(40, 20);
			this.stt.TabIndex = 60;
			this.stt.Text = "";
			// 
			// tenhc
			// 
			this.tenhc.BackColor = System.Drawing.SystemColors.HighlightText;
			this.tenhc.Enabled = false;
			this.tenhc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tenhc.Location = new System.Drawing.Point(498, 436);
			this.tenhc.Name = "tenhc";
			this.tenhc.Size = new System.Drawing.Size(286, 21);
			this.tenhc.TabIndex = 63;
			this.tenhc.Text = "";
			// 
			// lTenhc
			// 
			this.lTenhc.Location = new System.Drawing.Point(440, 435);
			this.lTenhc.Name = "lTenhc";
			this.lTenhc.Size = new System.Drawing.Size(59, 23);
			this.lTenhc.TabIndex = 64;
			this.lTenhc.Text = "Hoạt chất :";
			this.lTenhc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// sophieu
			// 
			this.sophieu.BackColor = System.Drawing.SystemColors.HighlightText;
			this.sophieu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.sophieu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.sophieu.Location = new System.Drawing.Point(175, 8);
			this.sophieu.Masked = MaskedTextBox.MaskedTextBox.Mask.None;
			this.sophieu.Name = "sophieu";
			this.sophieu.Size = new System.Drawing.Size(96, 21);
			this.sophieu.TabIndex = 3;
			this.sophieu.Text = "";
			this.sophieu.Validated += new System.EventHandler(this.sophieu_Validated);
			// 
			// giaban
			// 
			this.giaban.BackColor = System.Drawing.SystemColors.HighlightText;
			this.giaban.Enabled = false;
			this.giaban.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.giaban.Location = new System.Drawing.Point(688, 459);
			this.giaban.Masked = MaskedTextBox.MaskedTextBox.Mask.Digit;
			this.giaban.Name = "giaban";
			this.giaban.Size = new System.Drawing.Size(96, 21);
			this.giaban.TabIndex = 22;
			this.giaban.Text = "";
			this.giaban.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.giaban.Validated += new System.EventHandler(this.giaban_Validated);
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(632, 458);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(56, 23);
			this.label25.TabIndex = 66;
			this.label25.Text = "Giá bán :";
			this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(272, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 23);
			this.label3.TabIndex = 67;
			this.label3.Text = "Họ tên :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// hoten
			// 
			this.hoten.BackColor = System.Drawing.SystemColors.HighlightText;
			this.hoten.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.hoten.Enabled = false;
			this.hoten.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.hoten.Location = new System.Drawing.Point(320, 8);
			this.hoten.Masked = MaskedTextBox.MaskedTextBox.Mask.None;
			this.hoten.Name = "hoten";
			this.hoten.Size = new System.Drawing.Size(192, 21);
			this.hoten.TabIndex = 5;
			this.hoten.Text = "";
			// 
			// manguon
			// 
			this.manguon.BackColor = System.Drawing.SystemColors.HighlightText;
			this.manguon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.manguon.Enabled = false;
			this.manguon.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.manguon.Location = new System.Drawing.Point(556, 8);
			this.manguon.Name = "manguon";
			this.manguon.Size = new System.Drawing.Size(108, 21);
			this.manguon.TabIndex = 6;
			this.manguon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.manguon_KeyDown);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(508, 8);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(48, 23);
			this.label9.TabIndex = 68;
			this.label9.Text = "Nguồn :";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// frmTrathuoc
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(792, 573);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.hoten,
																		  this.manguon,
																		  this.label9,
																		  this.label3,
																		  this.cmbSophieu,
																		  this.ngaysp,
																		  this.sophieu,
																		  this.makho,
																		  this.label10,
																		  this.label2,
																		  this.lbl,
																		  this.giaban,
																		  this.label25,
																		  this.tenbd,
																		  this.tenhc,
																		  this.lTenhc,
																		  this.dang,
																		  this.butKetthuc,
																		  this.butIn,
																		  this.butHuy,
																		  this.butBoqua,
																		  this.butXoa,
																		  this.butThem,
																		  this.butLuu,
																		  this.butSua,
																		  this.butMoi,
																		  this.soluong,
																		  this.sotien,
																		  this.dongia,
																		  this.mabd,
																		  this.label18,
																		  this.label17,
																		  this.label16,
																		  this.ldvt,
																		  this.lTen,
																		  this.label13,
																		  this.dataGrid1,
																		  this.listDMBD,
																		  this.stt});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmTrathuoc";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Phiếu trả thuốc";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmTrathuoc_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTrathuoc_Load(object sender, System.EventArgs e)
		{
			format_soluong=d.format_soluong(i_nhom);
			format_sotien=d.format_sotien(i_nhom);
			format_dongia=d.format_dongia(i_nhom);
			bNgtru_mabn=d.bNgtru_mabn;
			if (!bNgtru_mabn) lbl.Text="Số toa :";
			bKhoaso=d.bKhoaso(i_nhom,s_mmyy);
			i_songay=d.Ngaylv_Ngayht;

			manguon.DisplayMember="TEN";
			manguon.ValueMember="ID";
			if (d.bQuanlynguon(i_nhom))
				manguon.DataSource=d.get_data("select * from d_dmnguon where nhom="+i_nhom+" order by stt").Tables[0];
			else
				manguon.DataSource=d.get_data("select * from d_dmnguon where nhom=0 or nhom="+i_nhom+" order by stt").Tables[0];

			makho.DisplayMember="TEN";
			makho.ValueMember="ID";
			sql="select * from d_dmkho where nhom="+i_nhom;
			if (s_makho!="") sql+=" and id in ("+s_makho.Substring(0,s_makho.Length-1)+")";
			sql+=" order by stt";
			makho.DataSource=d.get_data(sql).Tables[0];
			makho.SelectedIndex=0;

			listDMBD.DisplayMember="TEN";
			listDMBD.ValueMember="MA";

			load_dm();
			
			sql="select id,sophieu,to_char(ngaysp,'dd/mm/yyyy') ngaysp,sohd,to_char(ngayhd,'dd/mm/yyyy') ngayhd,bbkiem,to_char(ngaykiem,'dd/mm/yyyy') ngaykiem,nguoigiao,madv,makho,manguon,nhomcc,no,co from d_nhapll where loai='"+s_loai+"'"+" and nhom="+i_nhom+" and mmyy='"+s_mmyy+"'";
			sql+=" and to_char(ngaysp,'dd/mm/yyyy')='"+s_ngay+"'";
			if (!bAdmin) sql+=" and userid="+i_userid+"  and madv="+i_quayban;
			sql+=" order by id";
			dtll=d.get_data(s_mmyy,sql).Tables[0];
			cmbSophieu.DisplayMember="SOPHIEU";
			cmbSophieu.ValueMember="ID";
			cmbSophieu.DataSource=dtll;
			load_grid();
			AddGridTableStyle();
			ref_text();
			dsxoa.ReadXml("..\\..\\..\\xml\\d_nhapct.xml");
		}

		private void load_grid()
		{
			sql="select a.stt,a.mabd,b.ma,trim(b.ten)||' '||b.hamluong ten,b.tenhc,b.dang,a.handung,a.losx,a.soluong,a.dongia,a.vat,a.sotien,round(a.sotien+a.sotien*a.vat/100,3) sotienvat,a.giaban,a.giamua,a.sl1,a.sl2,a.tyle,a.baohanh,a.nguongoc,a.tinhtrang,a.sothe ";
			sql+=" from d_nhapct a,"+d.user+".d_dmbd b where a.mabd=b.id and a.id="+l_id+" order by a.stt";
			dtct=d.get_data(s_mmyy,sql).Tables[0];
			dataGrid1.DataSource=dtct;
		}

		private void ref_text()
		{
			try
			{
				int i=dataGrid1.CurrentCell.RowNumber;
				stt.Text=dataGrid1[i,0].ToString();
				mabd.Text=dataGrid1[i,1].ToString();
				tenbd.Text=dataGrid1[i,2].ToString();
				tenhc.Text=dataGrid1[i,3].ToString();
				dang.Text=dataGrid1[i,4].ToString();
				d_soluong=(dataGrid1[i,7].ToString()!="")?decimal.Parse(dataGrid1[i,7].ToString()):0;
				d_dongia=(dataGrid1[i,8].ToString()!="")?decimal.Parse(dataGrid1[i,8].ToString()):0;
				d_sotien=(dataGrid1[i,9].ToString()!="")?decimal.Parse(dataGrid1[i,9].ToString()):0;
				d_giaban=(dataGrid1[i,12].ToString()!="")?decimal.Parse(dataGrid1[i,12].ToString()):0;
				soluong.Text=d_soluong.ToString(format_soluong);
				dongia.Text=d_dongia.ToString(format_dongia);
				sotien.Text=d_sotien.ToString(format_sotien);
				giaban.Text=d_giaban.ToString("#,###,###,##0");
				if (butLuu.Enabled)
				{
					r=d.getrowbyid(dtdmbd,"ma='"+mabd.Text+"'");
					if (r!=null)
					{
						i_mabd=int.Parse(r["id"].ToString());
						tenbd.Enabled=d.get_iXuat(s_mmyy,int.Parse(makho.SelectedValue.ToString()),l_id,int.Parse(stt.Text))==0;
						if (d.bNhapmaso) mabd.Enabled=tenbd.Enabled;
						soluong.Enabled=tenbd.Enabled;
						if (d.bDongia(i_nhom)) dongia.Enabled=tenbd.Enabled;
						else sotien.Enabled=tenbd.Enabled;
						if (bGiaban) giaban.Enabled=tenbd.Enabled;
					}
				}
			}
			catch{}
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
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "ma";
			TextCol.HeaderText = "Mã số";
			TextCol.Width = 50;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "ten";
			TextCol.HeaderText = "Tên";
			TextCol.Width = (bGiaban)?200:230;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tenhc";
			TextCol.HeaderText = "Hoạt chất";
			TextCol.Width = (d.bHoatchat)?200:0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "dang";
			TextCol.HeaderText = "ĐVT";
			TextCol.Width = 50;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "handung";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "losx";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "soluong";
			TextCol.HeaderText = "Số lượng";
			TextCol.Width = 80;
			TextCol.Format=format_soluong;
			TextCol.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "dongia";
			TextCol.HeaderText = "Giá mua";
			TextCol.Width = 100;
			TextCol.Format=format_dongia;
			TextCol.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "sotien";
			TextCol.HeaderText = "Số tiền";
			TextCol.Width = 100;
			TextCol.Format=format_sotien;
			TextCol.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "vat";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "sotienvat";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "giaban";
			TextCol.HeaderText = (bGiaban)?"Giá bán":"";
			TextCol.Width = (bGiaban)?100:0;
			TextCol.Format="###,###,###,##0";
			TextCol.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);
		}

		private void load_dm()
		{
			dtdmbd=d.get_data("select ma,trim(ten)||' '||hamluong ten,tenhc,dang,id,dongia,giaban from d_dmbd where nhom="+i_nhom+" order by ten").Tables[0];
			listDMBD.DataSource=dtdmbd;
		}

		private void sophieu_Validated(object sender, System.EventArgs e)
		{
			if (l_id!=0) return;
			try
			{
				if (sophieu.Text=="" || sophieu.Text.Trim().Length<3) return;
				if (sophieu.Text.Trim().Length!=8) sophieu.Text=sophieu.Text.Substring(0,2)+sophieu.Text.Substring(2).PadLeft(6,'0');
				foreach(DataRow r1 in d.get_data("select hoten,namsinh from btdbn where mabn='"+sophieu.Text+"'").Tables[0].Rows)
				{
					hoten.Text=r1["hoten"].ToString();
					break;
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
			try
			{
				l_id=long.Parse(cmbSophieu.SelectedValue.ToString());
				r=d.getrowbyid(dtll,"id="+l_id);
				if (r!=null)
				{
					sophieu.Text=r["sophieu"].ToString();
					ngaysp.Text=r["ngaysp"].ToString();
					makho.SelectedValue=r["makho"].ToString();
					manguon.SelectedValue=r["manguon"].ToString();
					hoten.Text=r["nguoigiao"].ToString();
					s_ngaysp=ngaysp.Text;
				}
			}
			catch{l_id=0;}
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
				dv.RowFilter="ten like '%"+ten.Trim()+"%'"+" or tenhc like '%"+ten.Trim()+"%'";
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
				r=d.getrowbyid(dtdmbd,"ten='"+tenbd.Text+"'");
				if (r!=null)
				{
					mabd.Text=r["ma"].ToString();
					dang.Text=r["dang"].ToString();
					tenhc.Text=r["tenhc"].ToString();
					d_dongia=decimal.Parse(r["dongia"].ToString());
					d_giaban=decimal.Parse(r["giaban"].ToString());
					dongia.Text=d_dongia.ToString(format_dongia);
					giaban.Text=d_giaban.ToString("###,###,###,###0");
				}
			}
		}

		private void ena_object(bool ena)
		{
			sophieu.Visible=ena;
			cmbSophieu.Visible=!ena;
			sophieu.Enabled=ena;
			ngaysp.Enabled=ena;
			makho.Enabled=ena;
			manguon.Enabled=ena;
			hoten.Enabled=ena;
			if (d.bNhapmaso) mabd.Enabled=ena;
			tenbd.Enabled=ena;
			soluong.Enabled=ena;
			if (d.bDongia(i_nhom)) dongia.Enabled=ena;
			else sotien.Enabled=ena;
			if (bGiaban) giaban.Enabled=ena;
			butMoi.Enabled=!ena;
			butSua.Enabled=!ena;
			butThem.Enabled=ena;
			butXoa.Enabled=ena;
			butLuu.Enabled=ena;
			butBoqua.Enabled=ena;
			butHuy.Enabled=!ena;
			butIn.Enabled=!ena;
			butKetthuc.Enabled=!ena;
			i_old=cmbSophieu.SelectedIndex;
			if (d.bDanhmuc || d.bDmbd)
			{
				if (d.bDanhmuc) d.writeXml("d_thongso","c01","0");
				else d.writeXml("d_thongso","c06","0");
				load_dm();
			}
        }

		private void emp_head()
		{
			l_id=0;
			sophieu.Text=d.get_stt(dtll,"sophieu").ToString();
			hoten.Text="";
			ngaysp.Text=s_ngay;
			makho.SelectedIndex=0;
			s_ngaysp=ngaysp.Text;
			dsxoa.Clear();
		}
		
		private void emp_detail()
		{
			mabd.Text="";
			tenbd.Text="";
			tenhc.Text="";
			dang.Text="";
			soluong.Text="";
			dongia.Text="";
			sotien.Text="";
			giaban.Text="0";
			stt.Text=d.get_stt(dtct).ToString();
		}
		private void butMoi_Click(object sender, System.EventArgs e)
		{
			if (bKhoaso)
			{
				MessageBox.Show("Số liệu tháng "+s_mmyy.Substring(0,2)+" năm "+s_mmyy.Substring(2,2)+" đã khóa !\nNếu cần thay đổi thì vào mục khai báo hệ thống",d.Msg);
				return;
			}
			ena_object(true);
			dtct.Clear();
			dtold.Clear();
			emp_head();
			emp_detail();
			bNew=true;
			if (sophieu.Enabled) sophieu.Focus();
			else hoten.Focus();
		}
		private void butSua_Click(object sender, System.EventArgs e)
		{
			if (cmbSophieu.Items.Count==0) return;
			if (bKhoaso)
			{
				MessageBox.Show("Số liệu tháng "+s_mmyy.Substring(0,2)+" năm "+s_mmyy.Substring(2,2)+" đã khóa !\nNếu cần thay đổi thì vào mục khai báo hệ thống",d.Msg);
				return;
			}
			l_id=long.Parse(cmbSophieu.SelectedValue.ToString());
			ena_object(true);
			bNew=false;
			dtold=dtct.Copy();
			sophieu.Focus();
			ref_text();
		}
		private bool KiemtraHead()
		{
			if (sophieu.Text=="")
			{
				MessageBox.Show("Nhập số toa !",d.Msg);
				sophieu.Focus();
				return false;
			}
			if (ngaysp.Text=="")
			{
				MessageBox.Show("Nhập ngày số toa !",d.Msg);
				ngaysp.Focus();
				return false;
			}

			if (manguon.SelectedIndex==-1)
			{
				MessageBox.Show("Nhập nguồn hàng !",d.Msg);
				manguon.Focus();
				return false;
			}

			if (makho.SelectedIndex==-1)
			{
				MessageBox.Show("Nhập kho nhập !",d.Msg);
				makho.Focus();
				return false;
			}
			if (dtct.Rows.Count==0)
			{
				MessageBox.Show("Đề nghị nhập chi tiết !",d.Msg);
				butThem.Focus();
				return false;
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
					MessageBox.Show("Nhập mã số !",d.Msg);
					mabd.Focus();
					return false;
				}
				else if (tenbd.Text=="")
				{
					MessageBox.Show("Nhập tên !",d.Msg);
					tenbd.Focus();
					return false;
				}
			}
			r=d.getrowbyid(dtdmbd,"ma='"+mabd.Text+"'");
			if (r==null)
			{
				MessageBox.Show("Mã số không hợp lệ !",d.Msg);
				if (mabd.Enabled) mabd.Focus();
				else tenbd.Focus();
				return false;
			}
			i_mabd=int.Parse(r["id"].ToString());
			if (soluong.Text=="" || soluong.Text=="0.00" || soluong.Text=="0")
			{
				MessageBox.Show("Nhập số lượng !",d.Msg);
				soluong.Focus();
				return false;
			}
			if (d.bGiaban(i_nhom) && giaban.Enabled)
			{
				try
				{
					d_dongia=(dongia.Text!="")?decimal.Parse(dongia.Text):0;
					d_giaban=(giaban.Text!="")?decimal.Parse(giaban.Text):0;
					if (d_giaban<d_dongia)
					{
						MessageBox.Show("Giá bán không hợp lệ !",d.Msg);
						giaban.Focus();
						return false;
					}
				}
				catch{return false;}
			}
			return true;
		}

		private void butLuu_Click(object sender, System.EventArgs e)
		{
			upd_table(dtct);
			dtct.AcceptChanges();
			if (!KiemtraHead()) return;
			i_old=(bNew)?0:1;
			l_id=(bNew)?d.get_id_nhap:l_id;
			if (!d.upd_nhapll(l_id,i_nhom,sophieu.Text,ngaysp.Text,sophieu.Text,ngaysp.Text,"","",s_loai,hoten.Text,i_quayban,int.Parse(makho.SelectedValue.ToString()),int.Parse(manguon.SelectedValue.ToString()),0,"","",s_mmyy,i_userid,0))
			{
				MessageBox.Show("Không cập nhật được thông tin trả thuốc !",d.Msg);
				return;
			}
			if (!bNew)
			{
				foreach(DataRow r1 in dsxoa.Tables[0].Rows)
					d.execute_data(s_mmyy,"delete from d_nhapct where id="+l_id+" and stt="+int.Parse(r1["stt"].ToString()));
				foreach(DataRow r1 in dtold.Rows)
					d.upd_tonkhoct_nhapct(d.delete,s_mmyy,ngaysp.Text,l_id,int.Parse(r1["stt"].ToString()),decimal.Parse(r1["soluong"].ToString()),decimal.Parse(r1["sotien"].ToString()),int.Parse(r1["vat"].ToString()),int.Parse(makho.SelectedValue.ToString()),int.Parse(manguon.SelectedValue.ToString()),0,int.Parse(r1["mabd"].ToString()),r1["handung"].ToString(),r1["losx"].ToString(),decimal.Parse(r1["giaban"].ToString()),0,0,0,s_loai,0,0,0,i_nhom,"");
			}
			foreach(DataRow r1 in dtct.Rows)
			{
				d.upd_nhapct(s_mmyy,l_id,int.Parse(r1["stt"].ToString()),int.Parse(r1["mabd"].ToString()),r1["handung"].ToString(),r1["losx"].ToString(),int.Parse(r1["vat"].ToString()),decimal.Parse(r1["soluong"].ToString()),decimal.Parse(r1["dongia"].ToString()),decimal.Parse(r1["sotien"].ToString()),decimal.Parse(r1["giaban"].ToString()),decimal.Parse(r1["giamua"].ToString()),decimal.Parse(r1["soluong"].ToString()),1,0,0,0,0,"",0,0,0,"");
				d.upd_tonkhoct_nhapct(d.insert,s_mmyy,ngaysp.Text,l_id,int.Parse(r1["stt"].ToString()),decimal.Parse(r1["soluong"].ToString()),decimal.Parse(r1["sotien"].ToString()),int.Parse(r1["vat"].ToString()),int.Parse(makho.SelectedValue.ToString()),int.Parse(manguon.SelectedValue.ToString()),0,int.Parse(r1["mabd"].ToString()),r1["handung"].ToString(),r1["losx"].ToString(),decimal.Parse(r1["giaban"].ToString()),0,0,0,s_loai,0,0,0,i_nhom,"");
			}
			d.updrec_nhapll(dtll,l_id,sophieu.Text,ngaysp.Text,sophieu.Text,ngaysp.Text,"","",hoten.Text,0,int.Parse(makho.SelectedValue.ToString()),int.Parse(manguon.SelectedValue.ToString()),"","");
			try
			{
				if (i_old==0 && dtll.Rows.Count>0) cmbSophieu.SelectedIndex=dtll.Rows.Count-1;
			}
			catch{}
			ena_object(false);
			butMoi.Focus();
		}

		private void butBoqua_Click(object sender, System.EventArgs e)
		{
			cmbSophieu.SelectedIndex=i_old;
			ena_object(false);
			butMoi.Focus();
		}

		private void ngaysp_Validated(object sender, System.EventArgs e)
		{
			if (ngaysp.Text=="") return;
			ngaysp.Text=ngaysp.Text.Trim();
			if (!d.bNgay(ngaysp.Text))
			{
				MessageBox.Show("Ngày không hợp lệ !",d.Msg);
				ngaysp.Focus();
				return;
			}
			ngaysp.Text=d.Ktngaygio(ngaysp.Text,10);
			if (ngaysp.Text!=s_ngaysp)
			{
				if (!d.ngay(d.StringToDate(ngaysp.Text.Substring(0,10)),DateTime.Now,i_songay))
				{
					MessageBox.Show("Ngày không hợp lệ so với khai báo hệ thống ("+i_songay.ToString()+")!",d.Msg);
					ngaysp.Focus();
					return;
				}
			}
		}

		private void butThem_Click(object sender, System.EventArgs e)
		{
			tenbd.Enabled=true;
			if (d.bNhapmaso) mabd.Enabled=tenbd.Enabled;
			soluong.Enabled=tenbd.Enabled;
			if (d.bDongia(i_nhom)) dongia.Enabled=tenbd.Enabled;
			else sotien.Enabled=tenbd.Enabled;
			if (bGiaban) giaban.Enabled=tenbd.Enabled;
			if (!upd_table(dtct)) return;
			emp_detail();
			if (mabd.Enabled) mabd.Focus();
			else tenbd.Focus();
		}

		private void butXoa_Click(object sender, System.EventArgs e)
		{
			i_mabd=d.get_iXuat(s_mmyy,int.Parse(makho.SelectedValue.ToString()),l_id,int.Parse(stt.Text));
			if (i_mabd!=0)
			{
				r=d.getrowbyid(dtdmbd,"id="+i_mabd);
				if (r!=null)
				{
					MessageBox.Show(r["ten"].ToString().Trim()+" "+r["dang"].ToString().Trim()+"\nĐã xuất không cho phép hủy !",d.Msg);
					return;
				}
			}
			if (!upd_table(dsxoa.Tables[0])) return;
			d.delrec(dtct,"stt="+int.Parse(stt.Text));
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
			d_giaban=(giaban.Text!="")?decimal.Parse(giaban.Text):0;
			d.updrec_nhapct(dt,int.Parse(stt.Text),i_mabd,mabd.Text,tenbd.Text,tenhc.Text,dang.Text,"0000","",d_soluong,d_dongia,d_sotien,0,d_sotien,d_giaban,d_dongia,d_soluong,1,0,0,0,0,"",0,0,0,"");
			return true;
		}

		private void makho_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter || e.KeyCode==Keys.Tab)
			{
				if (makho.SelectedIndex==-1) makho.SelectedIndex=0;
				SendKeys.Send("{Tab}");
			}
		}

		private void mabd_Validated(object sender, System.EventArgs e)
		{
			if (mabd.Text!="")
			{
				r=d.getrowbyid(dtdmbd,"ma='"+mabd.Text+"'");
				if (r!=null) 
				{
					tenbd.Text=r["ten"].ToString();
					tenhc.Text=r["tenhc"].ToString();
					dang.Text=r["dang"].ToString();
					d_dongia=decimal.Parse(r["dongia"].ToString());
					d_giaban=decimal.Parse(r["giaban"].ToString());
					dongia.Text=d_dongia.ToString(format_dongia);
					giaban.Text=d_giaban.ToString("###,###,###,##0");
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
				d_soluong=(soluong.Text!="")?decimal.Parse(soluong.Text):0;
				if (d.bDongia(i_nhom))
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
				if (!bGiaban) giaban.Text=d_dongia.ToString("#,###,###,##0");
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
			upd_table(dtct);
			r=d.getrowbyid(dtdmbd,"ma='"+mabd.Text+"'");
			if (r!=null)
			{
				DataTable tmp=d.get_data("select a.*,trim(b.ten)||' '||trim(b.hamluong)||' '||trim(b.dang) ten,trim(b.ten)||' '||b.hamluong tenbd,b.dang,b.tenhc,b.ma,b.giaban,b.dongia from d_dmbdkemtheo a,d_dmbd b where a.mabd=b.id and a.id="+int.Parse(r["id"].ToString())).Tables[0];
				if (tmp.Rows.Count>0)
				{
					foreach(DataRow r1 in tmp.Rows)
					{
						i_mabd=int.Parse(r1["mabd"].ToString());
						d.updrec_nhapct(dtct,d.get_stt(dtct),i_mabd,mabd.Text,r1["tenbd"].ToString(),r1["tenhc"].ToString(),r1["dang"].ToString(),"0000","",decimal.Parse(r1["soluong"].ToString()),decimal.Parse(r1["dongia"].ToString()),decimal.Parse(r1["soluong"].ToString())*decimal.Parse(r1["dongia"].ToString()),0,decimal.Parse(r1["soluong"].ToString())*decimal.Parse(r1["dongia"].ToString()),decimal.Parse(r1["giaban"].ToString()),decimal.Parse(r1["giamua"].ToString()),decimal.Parse(r1["soluong"].ToString()),1,0,0,0,0,"",0,0,0,"");
					}						 			
				}
			}
			tinh_giatri();
		}

		private void butHuy_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (cmbSophieu.Items.Count==0) return;
				if (bKhoaso)
				{
					MessageBox.Show("Số liệu tháng "+s_mmyy.Substring(0,2)+" năm "+s_mmyy.Substring(2,2)+" đã khóa !\nNếu cần thay đổi thì vào mục khai báo hệ thống",d.Msg);
					return;
				}
				foreach(DataRow r1 in dtct.Rows)
				{
					i_mabd=d.get_iXuat(s_mmyy,int.Parse(makho.SelectedValue.ToString()),l_id,int.Parse(r1["stt"].ToString()));
					if (i_mabd!=0)
					{
						r=d.getrowbyid(dtdmbd,"id="+i_mabd);
						if (r!=null)
						{
							MessageBox.Show(r["ten"].ToString().Trim()+" "+r["dang"].ToString().Trim()+"\nĐã xuất không cho phép hủy !",d.Msg);
							return;
						}
					}
				}
				if (MessageBox.Show("Đồng ý hủy số phiếu này ?",d.Msg,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
				{
					l_id=long.Parse(cmbSophieu.SelectedValue.ToString());
					d.execute_data(s_mmyy,"delete from d_nhapct where id="+l_id);
					d.execute_data(s_mmyy,"delete from d_nhapll where id="+l_id);
					foreach(DataRow r1 in dtct.Rows)
						d.upd_tonkhoct_nhapct(d.delete,s_mmyy,ngaysp.Text,l_id,int.Parse(r1["stt"].ToString()),decimal.Parse(r1["soluong"].ToString()),decimal.Parse(r1["sotien"].ToString()),int.Parse(r1["vat"].ToString()),int.Parse(makho.SelectedValue.ToString()),int.Parse(manguon.SelectedValue.ToString()),0,int.Parse(r1["mabd"].ToString()),r1["handung"].ToString(),r1["losx"].ToString(),decimal.Parse(r1["giaban"].ToString()),0,0,0,s_loai,0,0,0,i_nhom,"");
					d.delrec(dtll,"id="+l_id);
					cmbSophieu.Refresh();
					load_grid();
				}
			}
			catch{}
		}

		private void giaban_Validated(object sender, System.EventArgs e)
		{
			try
			{
				d_dongia=(dongia.Text!="")?decimal.Parse(dongia.Text):0;
				d_giaban=(giaban.Text!="")?decimal.Parse(giaban.Text):0;
				giaban.Text=d_giaban.ToString("#,###,###,##0");
				if (d.bGiaban(i_nhom))
				{
					if (d_giaban<d_dongia)
					{
						MessageBox.Show("Giá bán không hợp lệ !",d.Msg);
						giaban.Focus();
						return;
					}
				}
			}
			catch{giaban.Text="0";}
		}

		private void butIn_Click(object sender, System.EventArgs e)
		{	
			if (dtct.Rows.Count==0) return;
			string s_tenkho=(s_makho=="")?"":makho.Text;
			if (d.bPreview)
			{
				frmReport f=new frmReport(d,dtct,"d_trathuoc.rpt",cmbSophieu.Text,hoten.Text,"","",ngaysp.Text,s_userid,"","","","");
				f.ShowDialog();
			}
			else
			{
				ReportDocument oRpt=new ReportDocument();
				oRpt.Load("..\\..\\..\\report\\d_trathuoc.rpt",OpenReportMethod.OpenReportByTempCopy);
				oRpt.SetDataSource(dtct);
				oRpt.DataDefinition.FormulaFields["soyte"].Text="'"+d.Syte+"'";
				oRpt.DataDefinition.FormulaFields["benhvien"].Text="'"+d.Tenbv+"'";
				oRpt.DataDefinition.FormulaFields["c1"].Text="'"+cmbSophieu.Text+"'";
				oRpt.DataDefinition.FormulaFields["c2"].Text="'"+hoten.Text+"'";
				oRpt.DataDefinition.FormulaFields["c3"].Text="";
				oRpt.DataDefinition.FormulaFields["c4"].Text="";
				oRpt.DataDefinition.FormulaFields["c5"].Text="'"+ngaysp.Text+"'";
				oRpt.DataDefinition.FormulaFields["c6"].Text="'"+s_userid+"'";
				oRpt.DataDefinition.FormulaFields["c7"].Text="";
				oRpt.DataDefinition.FormulaFields["c8"].Text="";
				oRpt.DataDefinition.FormulaFields["c9"].Text="";
				oRpt.DataDefinition.FormulaFields["c10"].Text="";
				oRpt.DataDefinition.FormulaFields["giamdoc"].Text="";
				oRpt.DataDefinition.FormulaFields["phutrach"].Text="";
				oRpt.DataDefinition.FormulaFields["thongke"].Text="";
				oRpt.DataDefinition.FormulaFields["ketoan"].Text="";
				oRpt.DataDefinition.FormulaFields["thukho"].Text="";
				oRpt.PrintOptions.PaperSize=PaperSize.PaperA4;
				oRpt.PrintOptions.PaperOrientation=PaperOrientation.Portrait;
				if (d.bPrintDialog)
				{
					result=Thongso();
					if (result==DialogResult.OK)
					{
						oRpt.PrintOptions.PrinterName=p.PrinterSettings.PrinterName;
						oRpt.PrintToPrinter(p.PrinterSettings.Copies,false,p.PrinterSettings.FromPage,p.PrinterSettings.ToPage);
					}
				}
				else oRpt.PrintToPrinter(1,false,0,0);
			}
		}

		private DialogResult Thongso()
		{
			p.AllowSomePages = true;
			p.ShowHelp = true;
			p.Document = docToPrint;
			return p.ShowDialog();
		}

		private void tenbd_TextChanged(object sender, System.EventArgs e)
		{
			if (this.ActiveControl==tenbd)
			{
				if (butMoi.Enabled) return;
				Filter_dmbd(tenbd.Text);
				listDMBD.BrowseToDmbd(tenbd,mabd,soluong,mabd.Location.X,mabd.Location.Y + mabd.Height-2,mabd.Width+lTen.Width+tenbd.Width+lTenhc.Width+tenhc.Width,mabd.Height+5);
			}
		}

		private void mabd_TextChanged(object sender, System.EventArgs e)
		{
			if (this.ActiveControl==mabd)
			{
				if (butMoi.Enabled) return;
				Filter_mabd(mabd.Text);
				listDMBD.BrowseToDmbd(mabd,tenbd,soluong,mabd.Location.X,mabd.Location.Y + mabd.Height-2,mabd.Width+lTen.Width+tenbd.Width+lTenhc.Width+tenhc.Width,mabd.Height+5);
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

		private void manguon_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter || e.KeyCode==Keys.Tab)
			{
				if (manguon.SelectedIndex==-1) manguon.SelectedIndex=0;
				SendKeys.Send("{Tab}{F4}");
			}
		}
	}
}
