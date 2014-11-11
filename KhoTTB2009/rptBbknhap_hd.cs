using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using LibTTB;
using Medisoft2009.Usercontrol;

namespace TTB
{
	/// <summary>
	/// Summary description for rptBbknhap.
	/// </summary>
	public class rptBbknhap_hd : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker tu;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button butIn;
		private System.Windows.Forms.Button butKetthuc;
		private System.Windows.Forms.DateTimePicker den;
        private LibTTB.AccessData ttb;
		private int i_nhom,i_madv,i_makho;
		private bool bClear=true;
		private string stime,user,xxx,sql,s_tongcong,dau,s_kho,tenfile,so,s_sohd,s_ngayhd,s_nghd,s_ngsp;
		private decimal sotien;
		private DataRow r,r1,r2,r3,r4,r5,r6,r7,r8;
		private DataSet ds=new DataSet();
		private DataSet dsst=new DataSet();
		private DataTable dt=new DataTable();
		private DataTable dtnhom=new DataTable();
		private DataTable dtnuoc=new DataTable();
		private DataTable dtnhombc=new DataTable();
		private DataTable dtnhomnuoc=new DataTable();
		private DataTable dtdmnx=new DataTable();
		private DataSet dssohd;
        private Medisoft2009.Usercontrol.MaskedTextBox c1;
		private Medisoft2009.Usercontrol.MaskedTextBox c3;
		private Medisoft2009.Usercontrol.MaskedTextBox c4;
		private Medisoft2009.Usercontrol.MaskedTextBox c5;
		private Medisoft2009.Usercontrol.MaskedTextBox c6;
        private Medisoft2009.Usercontrol.MaskedTextBox c7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
		private Medisoft2009.Usercontrol.MaskedTextBox c11;
		private System.Windows.Forms.ComboBox kho;
		private System.Windows.Forms.Label label12;
		private Medisoft2009.Usercontrol.MaskedTextBox c18;
		private Medisoft2009.Usercontrol.MaskedTextBox c17;
		private Medisoft2009.Usercontrol.MaskedTextBox c16;
		private Medisoft2009.Usercontrol.MaskedTextBox c15;
		private Medisoft2009.Usercontrol.MaskedTextBox c14;
		private Medisoft2009.Usercontrol.MaskedTextBox c13;
		private Medisoft2009.Usercontrol.MaskedTextBox c12;
		private System.Windows.Forms.TextBox tendv;
		private System.Windows.Forms.TextBox madv;
        private List listNX;
		private System.Windows.Forms.ComboBox manguon;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ComboBox noingoai;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private Medisoft2009.Usercontrol.MaskedTextBox bbkiem;
		private System.Windows.Forms.CheckedListBox sohd;
		private System.Windows.Forms.Button butLoc;
		private System.Windows.Forms.CheckBox chkngay;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public rptBbknhap_hd(AccessData acc,int nhom,string kho,string file,string _madv,string _tendv,string _nghd,string _ngsp,int _makho)
		{
			InitializeComponent();
			ttb=acc;i_nhom=nhom;s_kho=kho;tenfile=file;i_makho=_makho;
			madv.Text=_madv.Trim();tendv.Text=_tendv;s_nghd=_nghd;s_ngsp=_ngsp;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptBbknhap_hd));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tu = new System.Windows.Forms.DateTimePicker();
            this.den = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.butIn = new System.Windows.Forms.Button();
            this.butKetthuc = new System.Windows.Forms.Button();
            this.tendv = new System.Windows.Forms.TextBox();
            this.c1 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c3 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c4 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c5 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c6 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c7 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.c18 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c17 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c16 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c15 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c14 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c13 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c12 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c11 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.kho = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.madv = new System.Windows.Forms.TextBox();
            this.listNX = new Medisoft2009.Usercontrol.List();
            this.manguon = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.noingoai = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.bbkiem = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.sohd = new System.Windows.Forms.CheckedListBox();
            this.butLoc = new System.Windows.Forms.Button();
            this.chkngay = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(130, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "đến :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tu
            // 
            this.tu.CustomFormat = "dd/MM/yyyy";
            this.tu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tu.Location = new System.Drawing.Point(52, 10);
            this.tu.Name = "tu";
            this.tu.Size = new System.Drawing.Size(80, 21);
            this.tu.TabIndex = 1;
            this.tu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // den
            // 
            this.den.CustomFormat = "dd/MM/yyyy";
            this.den.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.den.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.den.Location = new System.Drawing.Point(165, 10);
            this.den.Name = "den";
            this.den.Size = new System.Drawing.Size(80, 21);
            this.den.TabIndex = 3;
            this.den.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(-3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Đơn vị :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // butIn
            // 
            this.butIn.Image = ((System.Drawing.Image)(resources.GetObject("butIn.Image")));
            this.butIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butIn.Location = new System.Drawing.Point(329, 254);
            this.butIn.Name = "butIn";
            this.butIn.Size = new System.Drawing.Size(60, 25);
            this.butIn.TabIndex = 12;
            this.butIn.Text = "&In";
            this.butIn.Click += new System.EventHandler(this.butIn_Click);
            // 
            // butKetthuc
            // 
            this.butKetthuc.Image = ((System.Drawing.Image)(resources.GetObject("butKetthuc.Image")));
            this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butKetthuc.Location = new System.Drawing.Point(389, 254);
            this.butKetthuc.Name = "butKetthuc";
            this.butKetthuc.Size = new System.Drawing.Size(74, 25);
            this.butKetthuc.TabIndex = 13;
            this.butKetthuc.Text = "&Kết thúc";
            this.butKetthuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
            // 
            // tendv
            // 
            this.tendv.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tendv.Location = new System.Drawing.Point(112, 56);
            this.tendv.Name = "tendv";
            this.tendv.Size = new System.Drawing.Size(368, 21);
            this.tendv.TabIndex = 10;
            this.tendv.TextChanged += new System.EventHandler(this.tendv_TextChanged);
            this.tendv.Validated += new System.EventHandler(this.tendv_Validated);
            this.tendv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tendv_KeyDown);
            // 
            // c1
            // 
            this.c1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.c1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1.Location = new System.Drawing.Point(52, 102);
            this.c1.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(192, 21);
            this.c1.TabIndex = 16;
            // 
            // c3
            // 
            this.c3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.c3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c3.Location = new System.Drawing.Point(52, 126);
            this.c3.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(192, 21);
            this.c3.TabIndex = 22;
            // 
            // c4
            // 
            this.c4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.c4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c4.Location = new System.Drawing.Point(52, 150);
            this.c4.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(192, 21);
            this.c4.TabIndex = 25;
            // 
            // c5
            // 
            this.c5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.c5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c5.Location = new System.Drawing.Point(52, 174);
            this.c5.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c5.Name = "c5";
            this.c5.Size = new System.Drawing.Size(192, 21);
            this.c5.TabIndex = 28;
            // 
            // c6
            // 
            this.c6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.c6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c6.Location = new System.Drawing.Point(52, 198);
            this.c6.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c6.Name = "c6";
            this.c6.Size = new System.Drawing.Size(192, 21);
            this.c6.TabIndex = 31;
            // 
            // c7
            // 
            this.c7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.c7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c7.Location = new System.Drawing.Point(52, 222);
            this.c7.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c7.Name = "c7";
            this.c7.Size = new System.Drawing.Size(192, 21);
            this.c7.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(-3, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "1. ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(-3, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "2. ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(-3, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "3. ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(-3, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 23);
            this.label7.TabIndex = 24;
            this.label7.Text = "4. ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(-3, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 23);
            this.label8.TabIndex = 27;
            this.label8.Text = "5. ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(-3, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 23);
            this.label9.TabIndex = 30;
            this.label9.Text = "6. ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // c18
            // 
            this.c18.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c18.Location = new System.Drawing.Point(776, 270);
            this.c18.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c18.Name = "c18";
            this.c18.Size = new System.Drawing.Size(234, 21);
            this.c18.TabIndex = 38;
            this.c18.Text = "Thủ kho - Ủy viên";
            this.c18.Visible = false;
            // 
            // c17
            // 
            this.c17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c17.Location = new System.Drawing.Point(246, 222);
            this.c17.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c17.Name = "c17";
            this.c17.Size = new System.Drawing.Size(234, 21);
            this.c17.TabIndex = 35;
            this.c17.Tag = "Thủ kho - Ủy viên";
            this.c17.Text = "Thủ kho - Ủy viên";
            // 
            // c16
            // 
            this.c16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c16.Location = new System.Drawing.Point(246, 198);
            this.c16.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c16.Name = "c16";
            this.c16.Size = new System.Drawing.Size(234, 21);
            this.c16.TabIndex = 32;
            this.c16.Tag = "Kế toán - Ủy viên";
            this.c16.Text = "Kế toán - Ủy viên";
            // 
            // c15
            // 
            this.c15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c15.Location = new System.Drawing.Point(246, 174);
            this.c15.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c15.Name = "c15";
            this.c15.Size = new System.Drawing.Size(234, 21);
            this.c15.TabIndex = 29;
            this.c15.Tag = "Phụ trách phỏng TCKT - Ủy viên";
            this.c15.Text = "Phụ trách phỏng TCKT - Ủy viên";
            // 
            // c14
            // 
            this.c14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c14.Location = new System.Drawing.Point(246, 150);
            this.c14.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c14.Name = "c14";
            this.c14.Size = new System.Drawing.Size(234, 21);
            this.c14.TabIndex = 26;
            this.c14.Tag = "Phụ trách khoa - Ủy viên";
            this.c14.Text = "Phụ trách khoa - Ủy viên";
            // 
            // c13
            // 
            this.c13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c13.Location = new System.Drawing.Point(246, 126);
            this.c13.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c13.Name = "c13";
            this.c13.Size = new System.Drawing.Size(234, 21);
            this.c13.TabIndex = 23;
            this.c13.Tag = "Phó CN kho - Phụ trách kho - Ủy viên";
            this.c13.Text = "Phó CN kho - Phụ trách kho - Ủy viên";
            // 
            // c12
            // 
            this.c12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c12.Location = new System.Drawing.Point(776, 126);
            this.c12.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c12.Name = "c12";
            this.c12.Size = new System.Drawing.Size(234, 21);
            this.c12.TabIndex = 20;
            this.c12.Text = "Trưởng phòng KHTH - Ủy viên";
            this.c12.Visible = false;
            // 
            // c11
            // 
            this.c11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c11.Location = new System.Drawing.Point(246, 102);
            this.c11.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c11.Name = "c11";
            this.c11.Size = new System.Drawing.Size(234, 21);
            this.c11.TabIndex = 17;
            this.c11.Tag = "Chủ tịch hội đồng";
            this.c11.Text = "Chủ tịch hội đồng";
            // 
            // kho
            // 
            this.kho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kho.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kho.Location = new System.Drawing.Point(280, 10);
            this.kho.Name = "kho";
            this.kho.Size = new System.Drawing.Size(200, 21);
            this.kho.TabIndex = 5;
            this.kho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kho_KeyDown);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(248, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 23);
            this.label12.TabIndex = 4;
            this.label12.Text = "Kho :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // madv
            // 
            this.madv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.madv.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.madv.Location = new System.Drawing.Point(52, 56);
            this.madv.Name = "madv";
            this.madv.Size = new System.Drawing.Size(58, 21);
            this.madv.TabIndex = 9;
            this.madv.Validated += new System.EventHandler(this.madv_Validated);
            this.madv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.madv_KeyDown);
            // 
            // listNX
            // 
            this.listNX.BackColor = System.Drawing.SystemColors.Info;
            this.listNX.ColumnCount = 0;
            this.listNX.Location = new System.Drawing.Point(503, 240);
            this.listNX.MatchBufferTimeOut = 1000;
            this.listNX.MatchEntryStyle = Medisoft2009.Usercontrol.MatchEntryStyle.FirstLetterInsensitive;
            this.listNX.Name = "listNX";
            this.listNX.Size = new System.Drawing.Size(75, 17);
            this.listNX.TabIndex = 43;
            this.listNX.TextIndex = -1;
            this.listNX.TextMember = null;
            this.listNX.ValueIndex = -1;
            this.listNX.Visible = false;
            // 
            // manguon
            // 
            this.manguon.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manguon.Location = new System.Drawing.Point(52, 79);
            this.manguon.Name = "manguon";
            this.manguon.Size = new System.Drawing.Size(196, 21);
            this.manguon.TabIndex = 12;
            this.manguon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kho_KeyDown);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(-8, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 23);
            this.label14.TabIndex = 11;
            this.label14.Text = "Nguồn";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // noingoai
            // 
            this.noingoai.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noingoai.Location = new System.Drawing.Point(320, 78);
            this.noingoai.Name = "noingoai";
            this.noingoai.Size = new System.Drawing.Size(160, 21);
            this.noingoai.TabIndex = 14;
            this.noingoai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kho_KeyDown);
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(256, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 23);
            this.label15.TabIndex = 13;
            this.label15.Text = "Nội/ngoại";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(-3, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 23);
            this.label16.TabIndex = 6;
            this.label16.Text = "BB kiểm :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bbkiem
            // 
            this.bbkiem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.bbkiem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbkiem.Location = new System.Drawing.Point(52, 33);
            this.bbkiem.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.bbkiem.Name = "bbkiem";
            this.bbkiem.Size = new System.Drawing.Size(428, 21);
            this.bbkiem.TabIndex = 7;
            // 
            // sohd
            // 
            this.sohd.CheckOnClick = true;
            this.sohd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sohd.Location = new System.Drawing.Point(483, 9);
            this.sohd.Name = "sohd";
            this.sohd.Size = new System.Drawing.Size(232, 228);
            this.sohd.TabIndex = 44;
            // 
            // butLoc
            // 
            this.butLoc.Image = ((System.Drawing.Image)(resources.GetObject("butLoc.Image")));
            this.butLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butLoc.Location = new System.Drawing.Point(269, 254);
            this.butLoc.Name = "butLoc";
            this.butLoc.Size = new System.Drawing.Size(60, 25);
            this.butLoc.TabIndex = 11;
            this.butLoc.Text = "&Tìm";
            this.butLoc.Click += new System.EventHandler(this.butLoc_Click);
            // 
            // chkngay
            // 
            this.chkngay.Checked = true;
            this.chkngay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkngay.Location = new System.Drawing.Point(610, 240);
            this.chkngay.Name = "chkngay";
            this.chkngay.Size = new System.Drawing.Size(104, 24);
            this.chkngay.TabIndex = 46;
            this.chkngay.Text = "Ngày hoá đơn";
            // 
            // rptBbknhap_hd
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(722, 299);
            this.Controls.Add(this.chkngay);
            this.Controls.Add(this.butLoc);
            this.Controls.Add(this.sohd);
            this.Controls.Add(this.bbkiem);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.noingoai);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.manguon);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.listNX);
            this.Controls.Add(this.madv);
            this.Controls.Add(this.kho);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.c18);
            this.Controls.Add(this.c17);
            this.Controls.Add(this.c16);
            this.Controls.Add(this.c15);
            this.Controls.Add(this.c14);
            this.Controls.Add(this.c13);
            this.Controls.Add(this.c12);
            this.Controls.Add(this.c11);
            this.Controls.Add(this.c7);
            this.Controls.Add(this.c6);
            this.Controls.Add(this.c5);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.tendv);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butKetthuc);
            this.Controls.Add(this.butIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.den);
            this.Controls.Add(this.tu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rptBbknhap_hd";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biên bản kiểm nhập";
            this.Load += new System.EventHandler(this.rptBbknhap_hd_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.rptBbknhap_hd_FormClosing);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rptBbknhap_hd_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void rptBbknhap_hd_Load(object sender, System.EventArgs e)
		{
            user = ttb.user; stime = "'" + ttb.f_ngay + "'";
			sohd.DisplayMember="SONGAY";
			sohd.ValueMember="SOHD";

			listNX.DisplayMember="MA";
			listNX.ValueMember="TEN";
			dtdmnx=ttb.get_data("select ma,ten,id from "+user+".ttb_dmnx where nhom="+i_nhom+" order by stt").Tables[0];
			listNX.DataSource=dtdmnx;

			kho.DisplayMember="TEN";
			kho.ValueMember="ID";
            sql = "select * from " + user + ".ttb_dmkho where nhom=" + i_nhom;
			if (s_kho!="") sql+=" and id in ("+s_kho.Substring(0,s_kho.Length-1)+")";
			sql+=" order by stt";
			kho.DataSource=ttb.get_data(sql).Tables[0];
			//
			manguon.DisplayMember="TEN";
			manguon.ValueMember="ID";
            sql = "select * from " + user + ".ttb_dmnguon where nhom=" + i_nhom;			
			sql+=" order by stt";
			manguon.DataSource=ttb.get_data(sql).Tables[0];
			manguon.SelectedIndex=-1;
			//
            sql = "select a.*, b.stt, b.ten tennhom, a.maloai idnn, f.ten noingoai from " + user + ".ttb_dmbd a," + user + ".ttb_dmnhom b," + user + ".ttb_dmhang e," + user + ".ttb_dmloai f";
			sql+=" where a.manhom=b.id and a.mahang=e.id and a.maloai=f.id and a.nhom="+i_nhom+" order by a.id";
			dt=ttb.get_data(sql).Tables[0];
            dtnhom = ttb.get_data("select * from " + user + ".ttb_dmnhom where nhom=" + i_nhom + " order by id").Tables[0];
            dtnuoc = ttb.get_data("select * from " + user + ".ttb_dmhang where nhom=" + i_nhom + " order by id").Tables[0];
            dtnhombc = ttb.get_data("select * from " + user + ".ttb_nhombc where nhom=" + i_nhom + " order by id").Tables[0];
            dtnhomnuoc = ttb.get_data("select * from " + user + ".ttb_nhomnuoc where nhom=" + i_nhom + " order by id").Tables[0];
			ds.ReadXml("..\\..\\..\\xml\\ttb_Bbknhap.xml");
			dsst.ReadXml("..\\..\\..\\xml\\ttb_stnhap.xml");
            c1.Text = ttb.Thongso("c501").Trim('0');
            c3.Text = ttb.Thongso("c503").Trim('0');
            c4.Text = ttb.Thongso("c504").Trim('0');
            c5.Text = ttb.Thongso("c505").Trim('0');
            c6.Text = ttb.Thongso("c506").Trim('0');
            c7.Text = ttb.Thongso("c507").Trim('0');
            c11.Text = ttb.Thongso("c511").Trim('0');
            c12.Text = ttb.Thongso("c512").Trim('0');
            c13.Text = ttb.Thongso("c513").Trim('0');
            c14.Text = ttb.Thongso("c514").Trim('0');
            c15.Text = ttb.Thongso("c515").Trim('0');
            c16.Text = ttb.Thongso("c516").Trim('0');
            c17.Text = ttb.Thongso("c517").Trim('0');
            c18.Text = ttb.Thongso("c518").Trim('0');
            if (c1.Text.Trim() == "" || c3.Text.Trim() == "" || c4.Text.Trim() == "" || c5.Text.Trim() == "" || c6.Text.Trim() == "" ||
                c7.Text.Trim() == "" || c11.Text.Trim() == "" || c12.Text.Trim() == "" || c13.Text.Trim() == "" || c14.Text.Trim() == "" ||
                c15.Text.Trim() == "" || c16.Text.Trim() == "" || c17.Text.Trim() == "" || c18.Text.Trim() == "")
            {
                ttb.ins_thongso(i_nhom, 501, 516);
                foreach (DataRow r in ttb.get_data("select * from " + user + ".ttb_thongso where id between 501 and 516 and nhom=" + i_nhom).Tables[0].Rows)
                {
                    switch (int.Parse(r["id"].ToString()))
                    {
                        case 501: if (c1.Text.Trim() == "") c1.Text = r["ten"].ToString().Trim().Trim('0'); break;
                        case 503: if (c3.Text.Trim() == "") c3.Text = r["ten"].ToString().Trim().Trim('0'); break;
                        case 504: if (c4.Text.Trim() == "") c4.Text = r["ten"].ToString().Trim().Trim('0'); break;
                        case 505: if (c5.Text.Trim() == "") c5.Text = r["ten"].ToString().Trim().Trim('0'); break;
                        case 506: if (c6.Text.Trim() == "") c6.Text = r["ten"].ToString().Trim().Trim('0'); break;
                        case 507: if (c7.Text.Trim() == "") c7.Text = r["ten"].ToString().Trim().Trim('0'); break;
                        case 511: if (c11.Text.Trim() == "") c11.Text = r["ten"].ToString().Trim().Trim('0'); break;
                        case 512: if (c12.Text.Trim() == "") c12.Text = r["ten"].ToString().Trim().Trim('0'); break;
                        case 513: if (c13.Text.Trim() == "") c13.Text = r["ten"].ToString().Trim().Trim('0'); break;
                        case 514: if (c14.Text.Trim() == "") c14.Text = r["ten"].ToString().Trim().Trim('0'); break;
                        case 515: if (c15.Text.Trim() == "") c15.Text = r["ten"].ToString().Trim().Trim('0'); break;
                        case 516: if (c16.Text.Trim() == "") c16.Text = r["ten"].ToString().Trim().Trim('0'); break;
                        case 517: if (c17.Text.Trim() == "") c17.Text = r["ten"].ToString().Trim().Trim('0'); break;
                        case 518: if (c18.Text.Trim() == "") c18.Text = r["ten"].ToString().Trim().Trim('0'); break;
                    }
                }
            }
            if (c1.Text.Trim()+ c3.Text.Trim() + c4.Text.Trim() + c5.Text.Trim() + c6.Text.Trim() +
                c7.Text.Trim() + c11.Text.Trim() + c12.Text.Trim() + c13.Text.Trim() + c14.Text.Trim() +
                c15.Text.Trim() + c16.Text.Trim() + c17.Text.Trim() + c18.Text.Trim() == "")
            {
                if (c11.Text.Trim() == "") c11.Text = c11.Tag.ToString();
                if (c13.Text.Trim() == "") c13.Text = c13.Tag.ToString();
                if (c14.Text.Trim() == "") c14.Text = c14.Tag.ToString();
                if (c15.Text.Trim() == "") c15.Text = c15.Tag.ToString();
                if (c16.Text.Trim() == "") c16.Text = c16.Tag.ToString();
                if (c17.Text.Trim() == "") c17.Text = c17.Tag.ToString();
            }
			manguon.Enabled=ttb.bQuanlynguon(i_nhom);
			noingoai.DisplayMember="TEN";
			noingoai.ValueMember="ID";
            noingoai.DataSource = ttb.get_data("select * from " + user + ".ttb_dmloai where nhom=" + i_nhom + " order by stt ").Tables[0];

			noingoai.SelectedIndex=-1;
			if (s_nghd!="" && s_ngsp!="")
			{
				if (chkngay.Checked) tu.Value=new DateTime(int.Parse(s_nghd.Substring(6,4)),int.Parse(s_nghd.Substring(3,2)),int.Parse(s_nghd.Substring(0,2)),0,0,0);
				else tu.Value=new DateTime(int.Parse(s_ngsp.Substring(6,4)),int.Parse(s_ngsp.Substring(3,2)),int.Parse(s_ngsp.Substring(0,2)),0,0,0);
				den.Value=tu.Value;	
				try
				{
					kho.SelectedValue=i_makho.ToString();
				}
				catch{}
				butLoc_Click(sender,e);
			}
		}

		private void butIn_Click(object sender, System.EventArgs e)
		{
			if(kho.SelectedIndex<0)
			{
				MessageBox.Show("Đề nghị chọn kho!","Kho",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				return;
			}
			if (madv.Text!="")
			{
				i_madv=0;
				r=ttb.getrowbyid(dtdmnx,"ma='"+madv.Text+"'");
				if (r==null)
				{
					MessageBox.Show("Nhà cung cấp không hợp lệ !",ttb.Msg);
					madv.Focus();
					return;
				}
				i_madv=int.Parse(r["id"].ToString());
			}
			if(ttb.bQuanlynguon(i_nhom)==false)manguon.SelectedIndex=-1;
			so="'";
			s_sohd="";s_ngayhd="";
			if (madv.Text!="" && sohd.SelectedItems.Count>0)
			{
				if (sohd.CheckedItems.Count==0) for(int i=0;i<sohd.Items.Count;i++) sohd.SetItemCheckState(i,CheckState.Checked);
				for(int i=0;i<sohd.Items.Count;i++) 
					if (sohd.GetItemChecked(i))
					{
						so+=dssohd.Tables[0].Rows[i]["sohd"].ToString().Trim()+"','";
						s_sohd+=dssohd.Tables[0].Rows[i]["sohd"].ToString().Trim()+",";
						if (s_ngayhd.IndexOf(dssohd.Tables[0].Rows[i]["ngayhd"].ToString().Trim()+",")==-1) s_ngayhd+=dssohd.Tables[0].Rows[i]["ngayhd"].ToString().Trim()+",";
					}
			}
			ds.Clear();
			dsst.Clear();
            get_nhap("");
			if (ds.Tables[0].Rows.Count==0)
			{
				MessageBox.Show("Không có số liệu !",ttb.Msg);
				return;
			}
			s_tongcong="";
			DataRow []dr=dsst.Tables[0].Select("sotien<>0","maloai,tenloai desc,manuoc");
			for(int i=0;i<dr.Length;i++)
			{
				sotien=decimal.Parse(dr[i]["sotien"].ToString());
				dau=(dr[i]["tenloai"].ToString()!="")?"+":"";
				dau+="       ";
				s_tongcong+=dr[i]["tenloai"].ToString()+dau+dr[i]["tennuoc"].ToString()+" : "+sotien.ToString("###,###,###,###0.000")+"+";
			}
			s_tongcong=(s_tongcong!="")?s_tongcong.Substring(0,s_tongcong.Length-1):"";
			string ngay=(tu.Text==den.Text)?"Ngày "+tu.Text:"Từ ngày "+tu.Text+" đến "+den.Text;
			if(manguon.SelectedIndex>=0)ngay="Nguồn: "+manguon.Text+" - "+ngay;
			ngay+=";"+s_tongcong;
			frmReport f=new frmReport(ttb,ds.Tables[0],tenfile,tendv.Text.Trim()+"+"+kho.Text,ngay,c1.Text.Trim()+"+"+c11.Text.Trim(),""+"+"+"",c3.Text.Trim()+"+"+c13.Text.Trim(),c4.Text.Trim()+"+"+c14.Text.Trim(),c5.Text.Trim()+"+"+c15.Text.Trim(),c6.Text.Trim()+"+"+c16.Text.Trim(),c7.Text.Trim()+"+"+c17.Text.Trim(),s_sohd.Trim()+"++"+s_ngayhd.Trim());
			f.ShowDialog();
		}

		private void get_nhap(string d_mmyy)
		{
            xxx = user;// +d_mmyy;
			sql="select to_char(a.ngayhd,'dd/mm/yyyy') as ngayhd,trim(a.sohd)||' - '||to_char(a.ngayhd,'dd/mm/yyyy') as sohd,";
			sql+=" b.mabd,b.soluong,b.vat,b.sotien,b.losx,b.handung, d.stt, d.ten as nhombd ";
			sql+=" from ttb_nhapll a,ttb_nhapct b,"+user+".ttb_dmbd c,"+user+".ttb_dmnhom d, "+user+".ttb_dmhang e ";
			sql+=" where a.id=b.id and b.mabd=c.id and c.manhom=d.id and c.mahang=e.id and a.nhom="+i_nhom;
            if (chkngay.Checked) sql += " and " + ttb.for_ngay("a.ngayhd", stime) + " between to_date('" + tu.Text + "'," + stime + ") and to_date('" + den.Text + "'," + stime + ")";
            else sql += " and " + ttb.for_ngay("a.ngaysp", stime) + " between to_date('" + tu.Text + "'," + stime + ") and to_date('" + den.Text + "'," + stime + ")";
			if (so.Length>1) sql+=" and trim(a.sohd) in ("+so.Substring(0,so.Length-2)+")";
			if (kho.SelectedIndex!=-1) sql+=" and a.makho="+int.Parse(kho.SelectedValue.ToString());
			if (madv.Text!="") sql+=" and a.madv="+i_madv;
			if(manguon.SelectedIndex>=0)sql+=" and a.manguon="+manguon.SelectedValue.ToString();
            sql += " order by a.id,d.loai, d.stt, d.ten ";
			foreach(DataRow r in ttb.get_data(sql).Tables[0].Rows)
			{
				r1=ttb.getrowbyid(dt,"id="+int.Parse(r["mabd"].ToString()));
				if (r1!=null)
				{
					r2=ttb.getrowbyid(dtnhom,"id="+int.Parse(r1["manhom"].ToString()));
					r3=ttb.getrowbyid(dtnuoc,"id="+int.Parse(r1["mahang"].ToString()));
					r4 = ds.Tables[0].NewRow();
					r4["mabd"]=r["mabd"].ToString();
					r4["ma"]=r1["ma"].ToString();
					r4["ten"]=r1["ten"].ToString().Trim()+" "+r1["hamluong"].ToString();
					r4["tenhc"]=r1["tenhc"].ToString();
					r4["dang"]=r1["dang"].ToString();
					r4["sohd"]=r["sohd"].ToString();
					r4["ngayhd"]=r["ngayhd"].ToString();
					r4["handung"]=r["handung"].ToString();
					r4["losx"]=r["losx"].ToString();
					r4["stt"]=r["stt"].ToString();
					r4["nhombd"]=r["nhombd"].ToString();
					r4["idnn"]=r1["idnn"].ToString();
					r4["noingoai"]=r1["noingoai"].ToString();
					r4["tennhom"]=bbkiem.Text;
					if (r3!=null) r4["tennuoc"]=r3["ten"].ToString();
					r4["soluong"]=r["soluong"].ToString();
					r4["vat"]=r["vat"].ToString();
					r4["sotien"]=r["sotien"].ToString();
					ds.Tables[0].Rows.Add(r4);
					if (r2!=null && r3!=null)
					{
						r4=ttb.getrowbyid(dsst.Tables[0],"maloai="+int.Parse(r2["loai"].ToString())+" and manuoc="+int.Parse(r3["loai"].ToString()));
						if (r4==null)
						{
							r5=dsst.Tables[0].NewRow();
							r6=ttb.getrowbyid(dtnhombc,"id="+int.Parse(r2["loai"].ToString()));
							r7=ttb.getrowbyid(dtnhomnuoc,"id="+int.Parse(r3["loai"].ToString()));
							r5["maloai"]=r2["loai"].ToString();
							r5["manuoc"]=r3["loai"].ToString();
							if (r6!=null)
							{
								r8=ttb.getrowbyid(dsst.Tables[0],"tenloai='"+r6["ten"].ToString()+"'");
								if (r8==null) r5["tenloai"]=r6["ten"].ToString();
							}
							if (r7!=null) r5["tennuoc"]=r7["ten"].ToString();
							r5["sotien"]=decimal.Parse(r["sotien"].ToString())+decimal.Parse(r["sotien"].ToString())*decimal.Parse(r["vat"].ToString())/100;
							dsst.Tables[0].Rows.Add(r5);
						}
						else
						{
							DataRow []dr=dsst.Tables[0].Select("maloai="+int.Parse(r2["loai"].ToString())+" and manuoc="+int.Parse(r3["loai"].ToString()));
							dr[0]["sotien"]=decimal.Parse(dr[0]["sotien"].ToString())+decimal.Parse(r["sotien"].ToString())+decimal.Parse(r["sotien"].ToString())*decimal.Parse(r["vat"].ToString())/100;
						}
					}
				}
			}
			ds.AcceptChanges();
			dsst.AcceptChanges();
		}

		private void get_nhap_kl(string d_mmyy)
		{
            xxx = user;// +d_mmyy;
			sql="select to_char(a.ngay,'dd/mm/yyyy') as ngayhd,a.sophieu as sohd,b.mabd,b.soluong,0 as vat,b.soluong*t.giamua as sotien,t.losx,t.handung, d.stt, d.ten as nhombd ";
			sql+=" from ttb_xuatll a,ttb_xuatct b,"+user+".ttb_dmbd c,"+user+".ttb_dmnhom d, "+user+".ttb_dmhang e,ttb_theodoi t";
			sql+=" where a.mmyy in ('"+d_mmyy+"') and a.id=b.id and b.sttt=t.id and b.mabd=c.id and t.manhom=d.id and c.mahang=e.id  and a.nhom="+i_nhom+" and a.loai='CK'";
            sql += " and " + ttb.for_ngay("a.ngay", stime) + " between to_date('" + tu.Text + "'," + stime + ") and to_date('" + den.Text + "'," + stime + ")";
			if (kho.SelectedIndex!=-1) sql+=" and a.khon="+int.Parse(kho.SelectedValue.ToString());
			if(manguon.SelectedIndex>=0)sql+=" and t.manguon="+manguon.SelectedValue.ToString();
			if(noingoai.SelectedIndex>=0)sql+=" and c.maloai="+int.Parse(noingoai.SelectedValue.ToString());
			sql+=" order by a.id,d.loai, d.stt, d.ten ";
			foreach(DataRow r in ttb.get_data(sql).Tables[0].Rows)
			{
				r1=ttb.getrowbyid(dt,"id="+int.Parse(r["mabd"].ToString()));
				if (r1!=null)
				{
					r2=ttb.getrowbyid(dtnhom,"id="+int.Parse(r1["manhom"].ToString()));
					r3=ttb.getrowbyid(dtnuoc,"id="+int.Parse(r1["manuoc"].ToString()));
					r4 = ds.Tables[0].NewRow();
					r4["mabd"]=r["mabd"].ToString();
					r4["ma"]=r1["ma"].ToString();
					r4["ten"]=r1["ten"].ToString().Trim()+" "+r1["hamluong"].ToString();
					r4["tenhc"]=r1["tenhc"].ToString();
					r4["dang"]=r1["dang"].ToString();
					r4["sohd"]=r["sohd"].ToString();
					r4["ngayhd"]=r["ngayhd"].ToString();
					r4["handung"]=r["handung"].ToString();
					r4["losx"]=r["losx"].ToString();
					r4["stt"]=r["stt"].ToString();
					r4["nhombd"]=r["nhombd"].ToString();
					r4["idnn"]=r1["idnn"].ToString();
					r4["noingoai"]=r1["noingoai"].ToString();
					r4["tennhom"]="";
					if (r3!=null) r4["tennuoc"]=r3["ten"].ToString();
					r4["soluong"]=r["soluong"].ToString();
					r4["vat"]=r["vat"].ToString();
					r4["sotien"]=r["sotien"].ToString();
					ds.Tables[0].Rows.Add(r4);
					if (r2!=null && r3!=null)
					{
						r4=ttb.getrowbyid(dsst.Tables[0],"maloai="+int.Parse(r2["loai"].ToString())+" and manuoc="+int.Parse(r3["loai"].ToString()));
						if (r4==null)
						{
							r5=dsst.Tables[0].NewRow();
							r6=ttb.getrowbyid(dtnhombc,"id="+int.Parse(r2["loai"].ToString()));
							r7=ttb.getrowbyid(dtnhomnuoc,"id="+int.Parse(r3["loai"].ToString()));
							r5["maloai"]=r2["loai"].ToString();
							r5["manuoc"]=r3["loai"].ToString();
							if (r6!=null)
							{
								r8=ttb.getrowbyid(dsst.Tables[0],"tenloai='"+r6["ten"].ToString()+"'");
								if (r8==null) r5["tenloai"]=r6["ten"].ToString();
							}
							if (r7!=null) r5["tennuoc"]=r7["ten"].ToString();
							r5["sotien"]=decimal.Parse(r["sotien"].ToString())+decimal.Parse(r["sotien"].ToString())*decimal.Parse(r["vat"].ToString())/100;
							dsst.Tables[0].Rows.Add(r5);
						}
						else
						{
							DataRow []dr=dsst.Tables[0].Select("maloai="+int.Parse(r2["loai"].ToString())+" and manuoc="+int.Parse(r3["loai"].ToString()));
							dr[0]["sotien"]=decimal.Parse(dr[0]["sotien"].ToString())+decimal.Parse(r["sotien"].ToString())+decimal.Parse(r["sotien"].ToString())*decimal.Parse(r["vat"].ToString())/100;
						}
					}
				}
			}
			ds.AcceptChanges();
			dsst.AcceptChanges();
		}

        private void butKetthuc_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

		private void tu_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");
		}

		private void rptBbknhap_hd_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (bClear)
			{
				if (manguon.Enabled)manguon.SelectedIndex=-1;
				noingoai.SelectedIndex=-1;
				bClear=false;
			}
		}

		private void kho_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");		
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
				listNX.BrowseToDmnx(tendv,madv,butLoc);
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
		private void madv_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");
		}
		private void madv_Validated(object sender, System.EventArgs e)
		{
			if (madv.Text!="")
			{
				r=ttb.getrowbyid(dtdmnx,"ma='"+madv.Text+"'");
				if (r!=null) tendv.Text=r["ten"].ToString();
			}
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
		private int get_khott(int i_kho)
		{
			int i_khott=0;
			string sql="select khott from "+user+".ttb_dmkho where id="+i_kho;
			DataTable ldt=ttb.get_data(sql).Tables[0];
			foreach(DataRow r in ldt.Rows)
			{
				i_khott=int.Parse(r["khott"].ToString());
				break;
			}
			ldt.Dispose();
			return i_khott;
		}

        private void butLoc_Click(object sender, System.EventArgs e)
        {
            if (madv.Text == "")
            {
                MessageBox.Show("Chọn nhà cung cấp !", ttb.Msg);
                madv.Focus();
                return;
            }
            dssohd = new DataSet();
            xxx = user;
            sql = "select distinct to_char(a.ngayhd,'dd/mm/yyyy')||'     '||a.sohd as songay,a.sohd,to_char(a.ngayhd,'dd/mm/yyyy') as ngayhd ";
            sql += " from " + xxx + ".ttb_nhapll a," + user + ".ttb_dmnx b where a.madv=b.id";
            if (chkngay.Checked) sql += " and " + ttb.for_ngay("a.ngayhd", stime) + " between to_date('" + tu.Text + "'," + stime + ") and to_date('" + den.Text + "'," + stime + ")";
            else sql += " and " + ttb.for_ngay("a.ngaysp", stime) + " between to_date('" + tu.Text + "'," + stime + ") and to_date('" + den.Text + "'," + stime + ")";
            if (madv.Text != "") sql += " and trim(b.ma)='" + madv.Text + "'";
            sql += " and a.nhom=" + i_nhom;
            dssohd = ttb.get_data(sql);
            sohd.DataSource = dssohd.Tables[0];
            sohd.DisplayMember = "SONGAY";
            sohd.ValueMember = "SOHD";
        }

        private void rptBbknhap_hd_FormClosing(object sender, FormClosingEventArgs e)
        {
            ttb.writeXml("ttb_thongso.xml","c501", c1.Text.Trim());
            ttb.writeXml("ttb_thongso.xml", "c503", c3.Text.Trim());
            ttb.writeXml("ttb_thongso.xml", "c504", c4.Text.Trim());
            ttb.writeXml("ttb_thongso.xml", "c505", c5.Text.Trim());
            ttb.writeXml("ttb_thongso.xml", "c506", c6.Text.Trim());
            ttb.writeXml("ttb_thongso.xml", "c507", c7.Text.Trim());
            ttb.writeXml("ttb_thongso.xml", "c511", c11.Text.Trim());
            ttb.writeXml("ttb_thongso.xml", "c512", c12.Text.Trim());
            ttb.writeXml("ttb_thongso.xml", "c513", c13.Text.Trim());
            ttb.writeXml("ttb_thongso.xml", "c514", c14.Text.Trim());
            ttb.writeXml("ttb_thongso.xml", "c515", c15.Text.Trim());
            ttb.writeXml("ttb_thongso.xml", "c516", c16.Text.Trim());
            ttb.writeXml("ttb_thongso.xml", "c517", c17.Text.Trim());
            ttb.writeXml("ttb_thongso.xml", "c518", c18.Text.Trim());
        }
	}
}
