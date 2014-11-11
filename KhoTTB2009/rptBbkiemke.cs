using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using LibTTB;

namespace TTB
{
	/// <summary>
	/// Summary description for rptBbkiemke.
	/// </summary>
	public class rptBbkiemke : System.Windows.Forms.Form
	{
		private bool bln_noingoai=false,bnhom,bGiaban;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button butIn;
		private System.Windows.Forms.Button butKetthuc;
        private LibTTB.AccessData ttb;
		private int i_nhom,i_dongiale;
		private string sql,s_mmyy,s_kho,user,xxx;
		private DataRow r1,r2,r3;
		private DataSet ds=new DataSet();
		private DataSet dsrpt=new DataSet();
		private DataTable dt=new DataTable();
		private DataTable dtnhom=new DataTable();
		private Medisoft2009.Usercontrol.MaskedTextBox c1;
		private Medisoft2009.Usercontrol.MaskedTextBox c2;
		private Medisoft2009.Usercontrol.MaskedTextBox c3;
		private Medisoft2009.Usercontrol.MaskedTextBox c4;
		private Medisoft2009.Usercontrol.MaskedTextBox c5;
		private Medisoft2009.Usercontrol.MaskedTextBox c6;
		private Medisoft2009.Usercontrol.MaskedTextBox c7;
		private Medisoft2009.Usercontrol.MaskedTextBox c8;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
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
		private System.Windows.Forms.NumericUpDown yyyy;
		private System.Windows.Forms.NumericUpDown mm;
		private System.Windows.Forms.ComboBox nguon;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox noingoai;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.CheckBox chkloai;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public rptBbkiemke(AccessData acc,int nhom,string kho,string mmyy,bool dmnhom,bool giaban)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			ttb=acc;
			i_nhom=nhom;
			s_kho=kho;bnhom=dmnhom;bGiaban=giaban;
			mm.Value=decimal.Parse(mmyy.Substring(0,2));
			yyyy.Value=decimal.Parse("20"+mmyy.Substring(2,2));
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptBbkiemke));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butIn = new System.Windows.Forms.Button();
            this.butKetthuc = new System.Windows.Forms.Button();
            this.c1 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c2 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c3 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c4 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c5 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c6 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c7 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c8 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
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
            this.yyyy = new System.Windows.Forms.NumericUpDown();
            this.mm = new System.Windows.Forms.NumericUpDown();
            this.nguon = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.noingoai = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.chkloai = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.yyyy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mm)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tháng :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(99, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "năm :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // butIn
            // 
            this.butIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butIn.Location = new System.Drawing.Point(188, 259);
            this.butIn.Name = "butIn";
            this.butIn.Size = new System.Drawing.Size(60, 25);
            this.butIn.TabIndex = 21;
            this.butIn.Text = "&In";
            this.butIn.Click += new System.EventHandler(this.butIn_Click);
            // 
            // butKetthuc
            // 
            this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butKetthuc.Location = new System.Drawing.Point(250, 259);
            this.butKetthuc.Name = "butKetthuc";
            this.butKetthuc.Size = new System.Drawing.Size(60, 25);
            this.butKetthuc.TabIndex = 22;
            this.butKetthuc.Text = "&Kết thúc";
            this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
            // 
            // c1
            // 
            this.c1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1.Location = new System.Drawing.Point(52, 59);
            this.c1.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(192, 21);
            this.c1.TabIndex = 5;
            // 
            // c2
            // 
            this.c2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c2.Location = new System.Drawing.Point(52, 83);
            this.c2.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(192, 21);
            this.c2.TabIndex = 7;
            // 
            // c3
            // 
            this.c3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c3.Location = new System.Drawing.Point(52, 107);
            this.c3.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(192, 21);
            this.c3.TabIndex = 9;
            // 
            // c4
            // 
            this.c4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c4.Location = new System.Drawing.Point(52, 131);
            this.c4.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(192, 21);
            this.c4.TabIndex = 11;
            // 
            // c5
            // 
            this.c5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c5.Location = new System.Drawing.Point(52, 155);
            this.c5.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c5.Name = "c5";
            this.c5.Size = new System.Drawing.Size(192, 21);
            this.c5.TabIndex = 13;
            // 
            // c6
            // 
            this.c6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c6.Location = new System.Drawing.Point(52, 179);
            this.c6.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c6.Name = "c6";
            this.c6.Size = new System.Drawing.Size(192, 21);
            this.c6.TabIndex = 15;
            // 
            // c7
            // 
            this.c7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c7.Location = new System.Drawing.Point(52, 203);
            this.c7.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c7.Name = "c7";
            this.c7.Size = new System.Drawing.Size(192, 21);
            this.c7.TabIndex = 17;
            // 
            // c8
            // 
            this.c8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c8.Location = new System.Drawing.Point(52, 227);
            this.c8.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c8.Name = "c8";
            this.c8.Size = new System.Drawing.Size(192, 21);
            this.c8.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(-3, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "1. ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(-3, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "2. ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(-3, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "3. ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(-3, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "4. ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(-3, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "5. ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(-3, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "6. ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(-3, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "7. ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(-3, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 23);
            this.label11.TabIndex = 20;
            this.label11.Text = "8. ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // c18
            // 
            this.c18.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c18.Location = new System.Drawing.Point(246, 227);
            this.c18.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c18.Name = "c18";
            this.c18.Size = new System.Drawing.Size(234, 21);
            this.c18.TabIndex = 20;
            this.c18.Text = "Thủ kho - Ủy viên";
            // 
            // c17
            // 
            this.c17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c17.Location = new System.Drawing.Point(246, 203);
            this.c17.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c17.Name = "c17";
            this.c17.Size = new System.Drawing.Size(234, 21);
            this.c17.TabIndex = 18;
            this.c17.Text = "Thủ kho - Ủy viên";
            // 
            // c16
            // 
            this.c16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c16.Location = new System.Drawing.Point(246, 179);
            this.c16.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c16.Name = "c16";
            this.c16.Size = new System.Drawing.Size(234, 21);
            this.c16.TabIndex = 16;
            this.c16.Text = "Kế toán - Ủy viên";
            // 
            // c15
            // 
            this.c15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c15.Location = new System.Drawing.Point(246, 155);
            this.c15.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c15.Name = "c15";
            this.c15.Size = new System.Drawing.Size(234, 21);
            this.c15.TabIndex = 14;
            this.c15.Text = "Phụ trách phỏng TCKT - Ủy viên";
            // 
            // c14
            // 
            this.c14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c14.Location = new System.Drawing.Point(246, 131);
            this.c14.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c14.Name = "c14";
            this.c14.Size = new System.Drawing.Size(234, 21);
            this.c14.TabIndex = 12;
            this.c14.Text = "Phụ trách khoa dược - Ủy viên";
            // 
            // c13
            // 
            this.c13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c13.Location = new System.Drawing.Point(246, 107);
            this.c13.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c13.Name = "c13";
            this.c13.Size = new System.Drawing.Size(234, 21);
            this.c13.TabIndex = 10;
            this.c13.Text = "Phó CN kho - Phụ trách kho - Ủy viên";
            // 
            // c12
            // 
            this.c12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c12.Location = new System.Drawing.Point(246, 83);
            this.c12.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c12.Name = "c12";
            this.c12.Size = new System.Drawing.Size(234, 21);
            this.c12.TabIndex = 8;
            this.c12.Text = "Trưởng phòng KHTH - Ủy viên";
            // 
            // c11
            // 
            this.c11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c11.Location = new System.Drawing.Point(246, 59);
            this.c11.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c11.Name = "c11";
            this.c11.Size = new System.Drawing.Size(234, 21);
            this.c11.TabIndex = 6;
            this.c11.Text = "Chủ tịch hội đồng";
            // 
            // kho
            // 
            this.kho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kho.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kho.Location = new System.Drawing.Point(246, 11);
            this.kho.Name = "kho";
            this.kho.Size = new System.Drawing.Size(234, 21);
            this.kho.TabIndex = 2;
            this.kho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kho_KeyDown);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(211, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 23);
            this.label12.TabIndex = 22;
            this.label12.Text = "Kho :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // yyyy
            // 
            this.yyyy.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yyyy.Location = new System.Drawing.Point(137, 11);
            this.yyyy.Maximum = new decimal(new int[] {
            3004,
            0,
            0,
            0});
            this.yyyy.Minimum = new decimal(new int[] {
            2004,
            0,
            0,
            0});
            this.yyyy.Name = "yyyy";
            this.yyyy.Size = new System.Drawing.Size(48, 21);
            this.yyyy.TabIndex = 1;
            this.yyyy.Value = new decimal(new int[] {
            2004,
            0,
            0,
            0});
            this.yyyy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // mm
            // 
            this.mm.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mm.Location = new System.Drawing.Point(53, 11);
            this.mm.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.mm.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mm.Name = "mm";
            this.mm.Size = new System.Drawing.Size(40, 21);
            this.mm.TabIndex = 0;
            this.mm.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // nguon
            // 
            this.nguon.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nguon.Location = new System.Drawing.Point(52, 35);
            this.nguon.Name = "nguon";
            this.nguon.Size = new System.Drawing.Size(196, 21);
            this.nguon.TabIndex = 3;
            this.nguon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nguồn";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // noingoai
            // 
            this.noingoai.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noingoai.Location = new System.Drawing.Point(312, 35);
            this.noingoai.Name = "noingoai";
            this.noingoai.Size = new System.Drawing.Size(168, 21);
            this.noingoai.TabIndex = 4;
            this.noingoai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kho_KeyDown);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(246, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 23);
            this.label14.TabIndex = 28;
            this.label14.Text = "Nội/ngoại";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkloai
            // 
            this.chkloai.Location = new System.Drawing.Point(56, 251);
            this.chkloai.Name = "chkloai";
            this.chkloai.Size = new System.Drawing.Size(104, 24);
            this.chkloai.TabIndex = 29;
            this.chkloai.Text = "In phân lọai";
            // 
            // rptBbkiemke
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(498, 302);
            this.Controls.Add(this.chkloai);
            this.Controls.Add(this.noingoai);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.nguon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yyyy);
            this.Controls.Add(this.mm);
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
            this.Controls.Add(this.c8);
            this.Controls.Add(this.c7);
            this.Controls.Add(this.c6);
            this.Controls.Add(this.c5);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butKetthuc);
            this.Controls.Add(this.butIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rptBbkiemke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biên bản kiểm kê";
            this.Load += new System.EventHandler(this.rptBbkiemke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yyyy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void rptBbkiemke_Load(object sender, System.EventArgs e)
		{
            user = ttb.user;
			i_dongiale=ttb.d_dongia_le(i_nhom);
			if (bnhom) label14.Text="Nhóm :";
			kho.DisplayMember="TEN";
			kho.ValueMember="ID";
			sql="select * from "+user+".ttb_dmkho where nhom="+i_nhom;
			if (s_kho!="") sql+=" and id in ("+s_kho.Substring(0,s_kho.Length-1)+")";
			sql+=" order by stt";
			kho.DataSource=ttb.get_data(sql).Tables[0];
			//
			//Load_nguon
			nguon.DisplayMember="TEN";
			nguon.ValueMember="ID";
			sql="select * from "+user+".ttb_dmnguon where nhom="+i_nhom;			
			sql+=" order by stt";
			nguon.DataSource=ttb.get_data(sql).Tables[0];
			nguon.SelectedIndex=-1;
			//
			if (!bnhom) bln_noingoai=ttb.bNoiNgoai_Hang(i_nhom) || ttb.bNoiNgoai_Nuoc(i_nhom);
			if(bln_noingoai)
			{
				if (ttb.bNoiNgoai_Hang(i_nhom))
				{
                    sql = "select a.*, b.stt, b.ten as tennhom, e.loai as idnn, f.ten as noingoai,e.ten as tenhang from " + user + ".ttb_dmbd a, " + user + ".ttb_dmnhom b, " + user + ".ttb_dmhang e, " + user + ".ttb_nhomhang f";
					sql+=" where a.manhom=b.id and a.mahang=e.id and e.loai=f.id and a.nhom="+i_nhom+" order by a.id";
				}
				else
				{
                    sql = "select a.*, b.stt, b.ten as tennhom, e.loai as idnn, f.ten as noingoai,e.ten as tenhang from " + user + ".ttb_dmbd a, " + user + ".ttb_dmnhom b, " + user + ".ttb_dmnuoc e, " + user + ".ttb_nhomnuoc f";
					sql+=" where a.manhom=b.id and a.manuoc=e.id and e.loai=f.id and a.nhom="+i_nhom+" order by a.id";
				}
			}
			else
			{
                sql = "select a.*, b.stt, b.ten as tennhom, a.maloai as idnn, f.ten as noingoai from " + user + ".ttb_dmbd a, " + user + ".ttb_dmnhom b, " + user + ".ttb_dmhang e, " + user + ".ttb_dmloai f";
				sql+=" where a.manhom=b.id and a.mahang=e.id and a.maloai=f.id and a.nhom="+i_nhom+" order by a.id";
			}
			dt=ttb.get_data(sql).Tables[0];
			//
            dtnhom = ttb.get_data("select * from " + user + ".ttb_dmnhom where nhom=" + i_nhom + " order by id").Tables[0];
			ds.ReadXml("..\\..\\..\\xml\\ttb_Bbkiemke.xml");
			dsrpt.ReadXml("..\\..\\..\\xml\\ttb_Bbkiemke.xml");
			ttb.ins_thongso(i_nhom,601,616);
            foreach (DataRow r in ttb.get_data("select * from " + user + ".ttb_thongso where id between 601 and 616 and nhom=" + i_nhom).Tables[0].Rows)
			{
				switch (int.Parse(r["id"].ToString()))
				{
					case 601:c1.Text=r["ten"].ToString().Trim();break;
					case 602:c2.Text=r["ten"].ToString().Trim();break;
					case 603:c3.Text=r["ten"].ToString().Trim();break;
					case 604:c4.Text=r["ten"].ToString().Trim();break;
					case 605:c5.Text=r["ten"].ToString().Trim();break;
					case 606:c6.Text=r["ten"].ToString().Trim();break;
					case 607:c7.Text=r["ten"].ToString().Trim();break;
					case 608:c8.Text=r["ten"].ToString().Trim();break;
					case 609:c11.Text=r["ten"].ToString().Trim();break;
					case 610:c12.Text=r["ten"].ToString().Trim();break;
					case 611:c13.Text=r["ten"].ToString().Trim();break;
					case 612:c14.Text=r["ten"].ToString().Trim();break;
					case 613:c15.Text=r["ten"].ToString().Trim();break;
					case 614:c16.Text=r["ten"].ToString().Trim();break;
					case 615:c17.Text=r["ten"].ToString().Trim();break;
					case 616:c18.Text=r["ten"].ToString().Trim();break;
				}
			}
			noingoai.DisplayMember="TEN";
			noingoai.ValueMember="ID";
			if(bln_noingoai)
			{
                if (ttb.bNoiNgoai_Hang(i_nhom)) noingoai.DataSource = ttb.get_data("select * from " + user + ".ttb_nhomhang where nhom=" + i_nhom + " order by stt").Tables[0];
                else noingoai.DataSource = ttb.get_data("select * from " + user + ".ttb_nhomnuoc where nhom=" + i_nhom + " order by stt").Tables[0];
			}
            else if (bnhom) noingoai.DataSource = ttb.get_data("select * from " + user + ".ttb_dmnhom where nhom=" + i_nhom + " order by stt").Tables[0];
            else noingoai.DataSource = ttb.get_data("select * from " + user + ".ttb_dmloai where nhom=" + i_nhom + " order by stt").Tables[0];
			noingoai.SelectedIndex=-1;
		}

		private void butIn_Click(object sender, System.EventArgs e)
		{
			s_mmyy=mm.Value.ToString().PadLeft(2,'0')+yyyy.Value.ToString().PadLeft(4,'0').Substring(2,2);
			ds.Clear();
			get_tonkhoct();
			if (ds.Tables[0].Rows.Count==0)
			{
				MessageBox.Show("Không có số liệu !",ttb.Msg);
				return;
			}
			get_sort();
			string tenfile=(chkloai.Checked)?"d_bbkiemke_loai":(noingoai.SelectedIndex==-1)?"d_bbkiemke_nn":"d_bbkiemke";
			if (bGiaban) tenfile+="_gban";
			else if (ttb.bKiemke_c14(i_nhom)) tenfile="d_bbkiemke_c14";
			tenfile+=".rpt";
			frmReport f=new frmReport(ttb,dsrpt.Tables[0],tenfile,kho.Text+((nguon.SelectedIndex>=0)?" - Nguồn: "+nguon.Text:""),"Tháng "+mm.Value.ToString().PadLeft(2,'0')+" năm "+yyyy.Value.ToString(),c1.Text.Trim()+"+"+c11.Text,c2.Text.Trim()+"+"+c12.Text,c3.Text.Trim()+"+"+c13.Text,c4.Text.Trim()+"+"+c14.Text,c5.Text.Trim()+"+"+c15.Text,c6.Text.Trim()+"+"+c16.Text,c7.Text.Trim()+"+"+c17.Text,c8.Text.Trim()+"+"+c18.Text);
			f.ShowDialog();
		}

		private void get_sort()
		{
			dsrpt.Clear();
			DataRow r1,r2;
			DataRow [] dr;
			string sort=(ttb.bKiemke_c14(i_nhom))?"ten":"idnn,stt,ten";
			foreach(DataRow r in ds.Tables[0].Select("sttondau+stnhap-stxuat>0 or tondau+slnhap-slxuat>0 or thua+thieu+hongvo>=0",sort))
			{
				sql="mabd="+int.Parse(r["mabd"].ToString())+" and giamua="+decimal.Parse(r["giamua"].ToString())+" and handung='"+r["handung"].ToString()+"'";
				r1=ttb.getrowbyid(dsrpt.Tables[0],sql);
				if (r1==null)
				{
					r2=dsrpt.Tables[0].NewRow();
					r2["tennhom"]=r["tennhom"].ToString();
					r2["mabd"]=r["mabd"].ToString();
					r2["ma"]=r["ma"].ToString();
					r2["ten"]=r["ten"].ToString();
					r2["tenhc"]=r["tenhc"].ToString();
					r2["dang"]=r["dang"].ToString();
					r2["tondau"]=r["tondau"].ToString();
					r2["sttondau"]=r["sttondau"].ToString();
					r2["slnhap"]=r["slnhap"].ToString();
					r2["stnhap"]=r["stnhap"].ToString();
					r2["slxuat"]=r["slxuat"].ToString();
					r2["stxuat"]=r["stxuat"].ToString();
					r2["stt"]=r["stt"].ToString();
					r2["handung"]=r["handung"].ToString();
					r2["losx"]=r["losx"].ToString();
					r2["nuocsx"]=r["nuocsx"].ToString();
					r2["idnn"]=r["idnn"].ToString();
					r2["noingoai"]=r["noingoai"].ToString();
					r2["giamua"]=r["giamua"].ToString();
					r2["giaban"]=r["giaban"].ToString();
					r2["thua"]=r["thua"].ToString();
					r2["thieu"]=r["thieu"].ToString();
					r2["hongvo"]=r["hongvo"].ToString();
					r2["sttt"]=r["sttt"].ToString();
					dsrpt.Tables[0].Rows.Add(r2);
				}
				else
				{
					dr=dsrpt.Tables[0].Select(sql);
					if (dr.Length>0)
					{
						dr[0]["tondau"]=decimal.Parse(dr[0]["tondau"].ToString())+decimal.Parse(r["tondau"].ToString());
						dr[0]["sttondau"]=decimal.Parse(dr[0]["sttondau"].ToString())+decimal.Parse(r["sttondau"].ToString());
						dr[0]["slnhap"]=decimal.Parse(dr[0]["slnhap"].ToString())+decimal.Parse(r["slnhap"].ToString());
						dr[0]["stnhap"]=decimal.Parse(dr[0]["stnhap"].ToString())+decimal.Parse(r["stnhap"].ToString());
						dr[0]["slxuat"]=decimal.Parse(dr[0]["slxuat"].ToString())+decimal.Parse(r["slxuat"].ToString());
						dr[0]["stxuat"]=decimal.Parse(dr[0]["stxuat"].ToString())+decimal.Parse(r["stxuat"].ToString());
						dr[0]["thua"]=decimal.Parse(dr[0]["thua"].ToString())+decimal.Parse(r["thua"].ToString());
						dr[0]["thieu"]=decimal.Parse(dr[0]["thieu"].ToString())+decimal.Parse(r["thieu"].ToString());
						dr[0]["hongvo"]=decimal.Parse(dr[0]["hongvo"].ToString())+decimal.Parse(r["hongvo"].ToString());
					}
				}
			}
		}

		private void get_tonkhoct()
		{
            xxx = user + s_mmyy;
			sql="select a.mabd,trunc(f.giamua,"+i_dongiale+") giamua,a.stt as sttt,sum(a.tondau) as tondau,sum(a.slnhap) as slnhap,sum(a.slxuat) as slxuat,sum(a.tondau*f.giamua) as sttondau,sum(a.slnhap*f.giamua) as stnhap,sum(a.slxuat*f.giamua) as stxuat, c.stt, c.ten as nhombd, f.handung,f.losx, b.manuoc, b.mahang, d.ten as nuocsx, e.ten as tenhang ";
            if (bGiaban) sql += ",trunc(f.giamua," + i_dongiale + ") as giaban";
			else sql+=",0 as giaban";
			sql+=" from "+xxx+".ttb_tonkhoct a, "+user+".ttb_dmbd b, "+user+".ttb_dmnhom c, "+user+".ttb_dmnuoc d, "+user+".ttb_dmhang e,"+xxx+".ttb_theodoi f ";
			sql+=" where a.mabd=b.id and b.manhom=c.id and b.manuoc=d.id and b.mahang=e.id and a.stt=f.id";
			sql+=" and makho="+int.Parse(kho.SelectedValue.ToString());
			if(nguon.SelectedIndex>=0) sql+=" and f.manguon="+nguon.SelectedValue.ToString();
			if(noingoai.SelectedIndex>=0)
			{
				if (bln_noingoai)
				{
					if (ttb.bNoiNgoai_Hang(i_nhom)) sql+=" and e.loai="+int.Parse(noingoai.SelectedValue.ToString());
					else sql+=" and d.loai="+int.Parse(noingoai.SelectedValue.ToString());
				}
				else sql+=" and "+((bnhom)?"b.manhom=":"b.maloai=")+int.Parse(noingoai.SelectedValue.ToString());
			}
			sql+=" group by a.mabd,trunc(f.giamua,"+i_dongiale+"),a.stt,c.stt,c.ten,f.handung,f.losx,b.manuoc,b.mahang,d.ten,e.ten";
			if (bGiaban) sql+=",b.giaban";
			foreach(DataRow r in ttb.get_data(sql).Tables[0].Rows)
			{
				r1=ttb.getrowbyid(dt,"id="+int.Parse(r["mabd"].ToString()));
				if (r1!=null)
				{
					r2=ttb.getrowbyid(dtnhom,"id="+int.Parse(r1["manhom"].ToString()));
					r3 = ds.Tables[0].NewRow();
					r3["mabd"]=r["mabd"].ToString();
					r3["ma"]=r1["ma"].ToString();
					r3["ten"]=r1["ten"].ToString().Trim()+" "+r1["hamluong"].ToString();
					r3["tenhc"]=r1["tenhc"].ToString();
					r3["dang"]=r1["dang"].ToString();
					if (r2!=null) r3["tennhom"]=r2["ten"].ToString();
					r3["tondau"]=r["tondau"].ToString();
					r3["sttondau"]=r["sttondau"].ToString();
					r3["slnhap"]=r["slnhap"].ToString();
					r3["stnhap"]=r["stnhap"].ToString();
					r3["slxuat"]=r["slxuat"].ToString();
					r3["stxuat"]=r["stxuat"].ToString();
					r3["giamua"]=r["giamua"].ToString();
					r3["giaban"]=r["giaban"].ToString();
					r3["sttt"]=r["sttt"].ToString();
					r3["thua"]=0;
					r3["thieu"]=0;
					r3["hongvo"]=0;
					//Add STT Nhombd: de group by
					r3["stt"]=r["stt"].ToString();
					r3["handung"]=r["handung"].ToString();
					r3["losx"]=r["losx"].ToString();
					string s_tensx=(r["mahang"].ToString()=="0")?"":r["tenhang"].ToString();
					s_tensx+=(r["manuoc"].ToString()=="0")?"":" - "+r["nuocsx"].ToString();
					r3["nuocsx"]=s_tensx.Trim();
					r3["idnn"]=r1["idnn"].ToString();
					r3["noingoai"]=r1["noingoai"].ToString();
					//
					ds.Tables[0].Rows.Add(r3);
				}
			}
			sql="select b.mabd,trunc(f.giamua,"+i_dongiale+") as giamua,b.sttt,a.khon,sum(b.soluong) as soluong from "+xxx+".ttb_xuatll a,"+xxx+".ttb_xuatct b,"+user+".ttb_dmbd c,"+user+".ttb_dmhang d,"+xxx+".ttb_theodoi f,"+user+".ttb_dmnuoc g  where a.id=b.id and b.mabd=c.id and c.mahang=d.id and b.sttt=f.id and c.manuoc=g.id";
			sql+=" and a.khox="+int.Parse(kho.SelectedValue.ToString());
			sql+=" and a.loai='XK' and a.khon in (1,2,3)";
			if(nguon.SelectedIndex>=0) sql+=" and f.manguon="+nguon.SelectedValue.ToString();
			if(noingoai.SelectedIndex>=0)
			{
				if (bln_noingoai)
				{
					if (ttb.bNoiNgoai_Hang(i_nhom)) sql+=" and e.loai="+int.Parse(noingoai.SelectedValue.ToString());
					else sql+=" and g.loai="+int.Parse(noingoai.SelectedValue.ToString());
				}
				else sql+=" and "+((bnhom)?"c.manhom=":"c.maloai=")+int.Parse(noingoai.SelectedValue.ToString());
			}
			sql+=" group by b.mabd,trunc(f.giamua,"+i_dongiale+"),b.sttt,a.khon";
			string fie;
			foreach(DataRow r in ttb.get_data(sql).Tables[0].Rows)
			{
				fie=(r["khon"].ToString()=="3")?"thieu":"hongvo";
                r1=ttb.getrowbyid(ds.Tables[0],"mabd="+int.Parse(r["mabd"].ToString())+" and giamua="+decimal.Parse(r["giamua"].ToString())+" and sttt="+decimal.Parse(r["sttt"].ToString()));
				if (r1!=null)
					r1[fie]=r["soluong"].ToString();
			}
			//
			sql="select b.mabd,trunc(f.giamua,"+i_dongiale+") as giamua,e.stt sttt,sum(b.soluong) as soluong from "+xxx+".ttb_nhapll a,"+xxx+".ttb_nhapct b,"+user+".ttb_dmbd c,"+user+".ttb_dmhang d,"+xxx+".ttb_tonkhoct e,"+xxx+".ttb_theodoi f,"+user+".ttb_dmnuoc g where a.id=b.id and b.mabd=c.id and c.mahang=d.id and a.id=e.idn and e.stt=f.id and c.manuoc=g.id";
			sql+=" and a.makho="+int.Parse(kho.SelectedValue.ToString());
			sql+=" and a.loai='T'";
			if(nguon.SelectedIndex>=0) sql+=" and f.manguon="+nguon.SelectedValue.ToString();
			if(noingoai.SelectedIndex>=0)
			{
				if (bln_noingoai)
				{
					if (ttb.bNoiNgoai_Hang(i_nhom)) sql+=" and e.loai="+int.Parse(noingoai.SelectedValue.ToString());
					else sql+=" and g.loai="+int.Parse(noingoai.SelectedValue.ToString());
				}
				else sql+=" and "+((bnhom)?"c.manhom=":"c.maloai=")+int.Parse(noingoai.SelectedValue.ToString());
			}
			sql+=" group by b.mabd,trunc(f.giamua,"+i_dongiale+"),e.stt";
			foreach(DataRow r in ttb.get_data(sql).Tables[0].Rows)
			{
				r1=ttb.getrowbyid(ds.Tables[0],"mabd="+int.Parse(r["mabd"].ToString())+" and giamua="+decimal.Parse(r["giamua"].ToString())+" and sttt="+decimal.Parse(r["sttt"].ToString()));
				if (r1!=null)
					r1["thua"]=r["soluong"].ToString();
			}
			ds.AcceptChanges();
		}

		private void butKetthuc_Click(object sender, System.EventArgs e)
		{
			ttb.upd_thongso(i_nhom,601,"",c1.Text.Trim());
			ttb.upd_thongso(i_nhom,602,"",c2.Text.Trim());
			ttb.upd_thongso(i_nhom,603,"",c3.Text.Trim());
			ttb.upd_thongso(i_nhom,604,"",c4.Text.Trim());
			ttb.upd_thongso(i_nhom,605,"",c5.Text.Trim());
			ttb.upd_thongso(i_nhom,606,"",c6.Text.Trim());
			ttb.upd_thongso(i_nhom,607,"",c7.Text.Trim());
			ttb.upd_thongso(i_nhom,608,"",c8.Text.Trim());
			ttb.upd_thongso(i_nhom,609,"",c11.Text.Trim());
			ttb.upd_thongso(i_nhom,610,"",c12.Text.Trim());
			ttb.upd_thongso(i_nhom,611,"",c13.Text.Trim());
			ttb.upd_thongso(i_nhom,612,"",c14.Text.Trim());
			ttb.upd_thongso(i_nhom,613,"",c15.Text.Trim());
			ttb.upd_thongso(i_nhom,614,"",c16.Text.Trim());
			ttb.upd_thongso(i_nhom,615,"",c17.Text.Trim());
			ttb.upd_thongso(i_nhom,616,"",c18.Text.Trim());
			this.Close();
		}

		private void tu_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");
		}

		private void kho_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");		
		}
	}
}
