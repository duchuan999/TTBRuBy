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
	public class rptBbkiemkec53 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button butIn;
		private System.Windows.Forms.Button butKetthuc;
        private LibTTB.AccessData ttb;
		private int i_nhom;
		private string sql,s_mmyy,s_kho,s_makp,s_nhom,s_tennhom,user,xxx;
		private DataRow r1,r2,r3,r4;
		private DataSet ds=new DataSet();
		private DataSet dsxml=new DataSet();
		private DataSet dsrpt=new DataSet();
		private DataTable dt=new DataTable();
		private DataTable dtkho=new DataTable();
		private DataTable dtmakp=new DataTable();
		private DataTable dtnhom=new DataTable();
		private Medisoft2009.Usercontrol.MaskedTextBox c1;
		private Medisoft2009.Usercontrol.MaskedTextBox c2;
		private Medisoft2009.Usercontrol.MaskedTextBox c3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private Medisoft2009.Usercontrol.MaskedTextBox c11;
		private Medisoft2009.Usercontrol.MaskedTextBox c13;
		private Medisoft2009.Usercontrol.MaskedTextBox c12;
		private System.Windows.Forms.NumericUpDown yyyy;
		private System.Windows.Forms.NumericUpDown mm;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rb1;
		private System.Windows.Forms.RadioButton rb2;
		private System.Windows.Forms.RadioButton rb3;
		private System.Windows.Forms.CheckedListBox kho;
		private System.Windows.Forms.CheckedListBox makp;
		private System.Windows.Forms.CheckedListBox manhom;
		private Medisoft2009.Usercontrol.MaskedTextBox c16;
		private Medisoft2009.Usercontrol.MaskedTextBox c15;
		private Medisoft2009.Usercontrol.MaskedTextBox c14;
		private Medisoft2009.Usercontrol.MaskedTextBox c6;
		private Medisoft2009.Usercontrol.MaskedTextBox c5;
		private Medisoft2009.Usercontrol.MaskedTextBox c4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public rptBbkiemkec53(AccessData acc,int nhom,string _kho,string mmyy,string _makp)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			ttb=acc;
			i_nhom=nhom;s_kho=_kho;s_makp=_makp;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptBbkiemkec53));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butIn = new System.Windows.Forms.Button();
            this.butKetthuc = new System.Windows.Forms.Button();
            this.c1 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c2 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c3 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.c13 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c12 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c11 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.yyyy = new System.Windows.Forms.NumericUpDown();
            this.mm = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.kho = new System.Windows.Forms.CheckedListBox();
            this.makp = new System.Windows.Forms.CheckedListBox();
            this.manhom = new System.Windows.Forms.CheckedListBox();
            this.c16 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c15 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c14 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c6 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c5 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c4 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yyyy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mm)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.butIn.Location = new System.Drawing.Point(153, 341);
            this.butIn.Name = "butIn";
            this.butIn.Size = new System.Drawing.Size(60, 25);
            this.butIn.TabIndex = 18;
            this.butIn.Text = "&In";
            this.butIn.Click += new System.EventHandler(this.butIn_Click);
            // 
            // butKetthuc
            // 
            this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butKetthuc.Location = new System.Drawing.Point(214, 341);
            this.butKetthuc.Name = "butKetthuc";
            this.butKetthuc.Size = new System.Drawing.Size(60, 25);
            this.butKetthuc.TabIndex = 19;
            this.butKetthuc.Text = "&Kết thúc";
            this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
            // 
            // c1
            // 
            this.c1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1.Location = new System.Drawing.Point(52, 192);
            this.c1.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(192, 21);
            this.c1.TabIndex = 6;
            // 
            // c2
            // 
            this.c2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c2.Location = new System.Drawing.Point(52, 216);
            this.c2.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(192, 21);
            this.c2.TabIndex = 8;
            // 
            // c3
            // 
            this.c3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c3.Location = new System.Drawing.Point(52, 240);
            this.c3.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(192, 21);
            this.c3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(-3, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "1. ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(-3, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "2. ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(-3, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "3. ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // c13
            // 
            this.c13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c13.Location = new System.Drawing.Point(246, 240);
            this.c13.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c13.Name = "c13";
            this.c13.Size = new System.Drawing.Size(170, 21);
            this.c13.TabIndex = 11;
            this.c13.Text = "Ủy viên";
            // 
            // c12
            // 
            this.c12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c12.Location = new System.Drawing.Point(246, 216);
            this.c12.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c12.Name = "c12";
            this.c12.Size = new System.Drawing.Size(170, 21);
            this.c12.TabIndex = 9;
            this.c12.Text = "Ủy viên";
            // 
            // c11
            // 
            this.c11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c11.Location = new System.Drawing.Point(246, 192);
            this.c11.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c11.Name = "c11";
            this.c11.Size = new System.Drawing.Size(170, 21);
            this.c11.TabIndex = 7;
            this.c11.Text = "Trưởng ban";
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
            this.mm.Location = new System.Drawing.Point(52, 11);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb3);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Location = new System.Drawing.Point(192, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 32);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // rb3
            // 
            this.rb3.Location = new System.Drawing.Point(131, 8);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(88, 23);
            this.rb3.TabIndex = 2;
            this.rb3.Text = "Khoa/phòng";
            this.rb3.CheckedChanged += new System.EventHandler(this.rb3_CheckedChanged);
            this.rb3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // rb2
            // 
            this.rb2.Location = new System.Drawing.Point(84, 8);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(48, 22);
            this.rb2.TabIndex = 1;
            this.rb2.Text = "Kho";
            this.rb2.CheckedChanged += new System.EventHandler(this.rb2_CheckedChanged);
            this.rb2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // rb1
            // 
            this.rb1.Checked = true;
            this.rb1.Location = new System.Drawing.Point(8, 8);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(73, 22);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "Toàn viện";
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            this.rb1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // kho
            // 
            this.kho.BackColor = System.Drawing.SystemColors.HighlightText;
            this.kho.CheckOnClick = true;
            this.kho.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kho.Location = new System.Drawing.Point(52, 90);
            this.kho.Name = "kho";
            this.kho.Size = new System.Drawing.Size(180, 100);
            this.kho.TabIndex = 4;
            this.kho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // makp
            // 
            this.makp.BackColor = System.Drawing.SystemColors.HighlightText;
            this.makp.CheckOnClick = true;
            this.makp.Enabled = false;
            this.makp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makp.Location = new System.Drawing.Point(236, 36);
            this.makp.Name = "makp";
            this.makp.Size = new System.Drawing.Size(180, 148);
            this.makp.TabIndex = 5;
            this.makp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // manhom
            // 
            this.manhom.CheckOnClick = true;
            this.manhom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manhom.Location = new System.Drawing.Point(52, 36);
            this.manhom.Name = "manhom";
            this.manhom.Size = new System.Drawing.Size(180, 52);
            this.manhom.TabIndex = 3;
            this.manhom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // c16
            // 
            this.c16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c16.Location = new System.Drawing.Point(246, 312);
            this.c16.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c16.Name = "c16";
            this.c16.Size = new System.Drawing.Size(170, 21);
            this.c16.TabIndex = 17;
            // 
            // c15
            // 
            this.c15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c15.Location = new System.Drawing.Point(246, 288);
            this.c15.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c15.Name = "c15";
            this.c15.Size = new System.Drawing.Size(170, 21);
            this.c15.TabIndex = 15;
            // 
            // c14
            // 
            this.c14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c14.Location = new System.Drawing.Point(246, 264);
            this.c14.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c14.Name = "c14";
            this.c14.Size = new System.Drawing.Size(170, 21);
            this.c14.TabIndex = 13;
            // 
            // c6
            // 
            this.c6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c6.Location = new System.Drawing.Point(52, 312);
            this.c6.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c6.Name = "c6";
            this.c6.Size = new System.Drawing.Size(192, 21);
            this.c6.TabIndex = 16;
            // 
            // c5
            // 
            this.c5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c5.Location = new System.Drawing.Point(52, 288);
            this.c5.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c5.Name = "c5";
            this.c5.Size = new System.Drawing.Size(192, 21);
            this.c5.TabIndex = 14;
            // 
            // c4
            // 
            this.c4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c4.Location = new System.Drawing.Point(52, 264);
            this.c4.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(192, 21);
            this.c4.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(-3, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "6. ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(-3, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 23);
            this.label7.TabIndex = 23;
            this.label7.Text = "5. ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(-3, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 23);
            this.label8.TabIndex = 22;
            this.label8.Text = "4. ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rptBbkiemkec53
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(426, 383);
            this.Controls.Add(this.c16);
            this.Controls.Add(this.c15);
            this.Controls.Add(this.c14);
            this.Controls.Add(this.c6);
            this.Controls.Add(this.c5);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.manhom);
            this.Controls.Add(this.makp);
            this.Controls.Add(this.kho);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.yyyy);
            this.Controls.Add(this.mm);
            this.Controls.Add(this.c13);
            this.Controls.Add(this.c12);
            this.Controls.Add(this.c11);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
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
            this.Name = "rptBbkiemkec53";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biên bản kiểm kê";
            this.Load += new System.EventHandler(this.rptBbkiemkec53_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yyyy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mm)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void rptBbkiemkec53_Load(object sender, System.EventArgs e)
		{
            user = ttb.user;
			sql="select * from "+user+".d_duockp ";
			sql+=" where nhom like '%"+i_nhom.ToString()+",%'";
			if (s_makp!="")  sql+=" and makp in ("+s_makp.Substring(0,s_makp.Length-1)+")";
			sql+=" order by stt";
			dtmakp=ttb.get_data(sql).Tables[0];
			makp.DataSource=dtmakp;
            makp.DisplayMember = "TEN";
            makp.ValueMember = "ID";

			sql="select * from "+user+".ttb_dmnhom where theodoi=1 and nhom="+i_nhom+" order by stt";
			dtnhom=ttb.get_data(sql).Tables[0];
            manhom.DataSource = dtnhom;
			manhom.DisplayMember="TEN";
			manhom.ValueMember="ID";

			sql="select * from "+user+".ttb_dmkho ";
			if (i_nhom==10) sql+=" where nhom in (2,10)";
			else if (i_nhom==3) sql+=" where nhom in (3,9)";
			else sql+=" where nhom="+i_nhom;
			if (s_kho!="") sql+=" and id in ("+s_kho.Substring(0,s_kho.Length-1)+")";
			sql+=" order by stt";
			dtkho=ttb.get_data(sql).Tables[0];
			kho.DataSource=dtkho;
            kho.DisplayMember = "TEN";
            kho.ValueMember = "ID";
			//
            sql = "select a.*, b.stt, b.ten as tennhom, a.maloai as idnn, f.ten as noingoai from " + user + ".ttb_dmbd a, " + user + ".ttb_dmnhom b, " + user + ".ttb_dmhang e, " + user + ".ttb_dmloai f";
			sql+=" where a.manhom=b.id and a.mahang=e.id and a.maloai=f.id ";
			if (i_nhom==10) sql+=" and a.nhom in (2,10)";
			else if (i_nhom==3) sql+=" and a.nhom in (3,9)";
			else sql+=" and a.nhom="+i_nhom;
			sql+=" order by a.id";
			dt=ttb.get_data(sql).Tables[0];
			//
			ds.ReadXml("..\\..\\..\\xml\\ttb_bbkiemkec53.xml");
			dsrpt.ReadXml("..\\..\\..\\xml\\ttb_bbkiemkec53.xml");
			dsxml.ReadXml("..\\..\\..\\xml\\ttb_tskiemke.xml");
			c1.Text=dsxml.Tables[0].Rows[0]["c01"].ToString();
			c2.Text=dsxml.Tables[0].Rows[0]["c02"].ToString();
			c3.Text=dsxml.Tables[0].Rows[0]["c03"].ToString();
			c4.Text=dsxml.Tables[0].Rows[0]["c04"].ToString();
			c5.Text=dsxml.Tables[0].Rows[0]["c05"].ToString();
			c6.Text=dsxml.Tables[0].Rows[0]["c06"].ToString();
			c11.Text=dsxml.Tables[0].Rows[0]["c11"].ToString();
			c12.Text=dsxml.Tables[0].Rows[0]["c12"].ToString();
			c13.Text=dsxml.Tables[0].Rows[0]["c13"].ToString();
			c14.Text=dsxml.Tables[0].Rows[0]["c14"].ToString();
			c15.Text=dsxml.Tables[0].Rows[0]["c15"].ToString();
			c16.Text=dsxml.Tables[0].Rows[0]["c16"].ToString();
			//
		}

		private void butIn_Click(object sender, System.EventArgs e)
		{
			s_mmyy=mm.Value.ToString().PadLeft(2,'0')+yyyy.Value.ToString().PadLeft(4,'0').Substring(2,2);
			ds.Clear();
			s_nhom="";s_tennhom="";
			for(int i=0;i<manhom.Items.Count;i++)
				if (manhom.GetItemChecked(i))
				{
					s_nhom+=dtnhom.Rows[i]["id"].ToString().Trim()+",";
					s_tennhom+=dtnhom.Rows[i]["ten"].ToString().Trim()+",";
				}
			if (s_nhom.IndexOf("93,")!=-1 && i_nhom==10)
			{
                foreach (DataRow r in ttb.get_data("select id from " + user + ".ttb_dmnhom where nhom=2 and theodoi=1").Tables[0].Rows)
					s_nhom+=r["id"].ToString().Trim()+",";
			}
			else if (s_nhom.IndexOf("99,")!=-1 && i_nhom==3)
			{
                foreach (DataRow r in ttb.get_data("select id from " + user + ".ttb_dmnhom where nhom=9 and theodoi=1").Tables[0].Rows)
					s_nhom+=r["id"].ToString().Trim()+",";
			}
			s_kho="";
			for(int i=0;i<kho.Items.Count;i++)
				if (kho.GetItemChecked(i)) s_kho+=dtkho.Rows[i]["id"].ToString().Trim()+",";
			s_makp="";
			for(int i=0;i<makp.Items.Count;i++)
				if (makp.GetItemChecked(i)) s_makp+=dtmakp.Rows[i]["id"].ToString().Trim()+",";

			get_data();
			if (ds.Tables[0].Rows.Count==0)
			{
				MessageBox.Show("Không có số liệu !",ttb.Msg);
				return;
			}
			get_sort();
			frmReport f=new frmReport(ttb,dsrpt.Tables[0],"d_bbkiemkec53.rpt","","Tháng "+mm.Value.ToString().PadLeft(2,'0')+" năm "+yyyy.Value.ToString(),c1.Text.Trim()+"+"+c11.Text,c2.Text.Trim()+"+"+c12.Text,c3.Text.Trim()+"+"+c13.Text,c4.Text.Trim()+"+"+c14.Text,c5.Text.Trim()+"+"+c15.Text,c6.Text.Trim()+"+"+c16.Text,"","");
			f.ShowDialog();
		}

		private void get_sort()
		{
			dsrpt.Clear();
			if (rb3.Checked) sql="tennhom,tenkp,ten";
			else sql="tennhom,ten,tenkp";
			dsrpt.Merge(ds.Tables[0].Select("soluong>0",sql));
			s_tennhom=(s_tennhom!="")?s_tennhom.Substring(0,s_tennhom.Length-1).ToUpper():"TÀI SẢN CỐ ĐỊNH VÀ DỤNG CỤ";
			foreach(DataRow r in dsrpt.Tables[0].Rows)
			{
				r["tennhom"]=s_tennhom;
				r["sotien"]=decimal.Parse(r["soluong"].ToString())*decimal.Parse(r["giamua"].ToString());
				if (decimal.Parse(r["tyle"].ToString())==0) r["sotienhm"]=r["sotien"].ToString();
				else
				{
					if (decimal.Parse(r["namsd"].ToString())+1<=yyyy.Value && decimal.Parse(r["namsd"].ToString())>0)
					{
						r["sotienhm"]=(decimal.Parse(r["namsd"].ToString())+1==yyyy.Value)?0:decimal.Parse(r["sotien"].ToString())*decimal.Parse(r["tyle"].ToString())/100*(yyyy.Value-decimal.Parse(r["namsd"].ToString())-1);
						r["nam"]=(decimal.Parse(r["namsd"].ToString())==yyyy.Value)?0:decimal.Parse(r["sotien"].ToString())*decimal.Parse(r["tyle"].ToString())/100;
					}
				}
			}
		}

		private void ins_items()
		{
			DataRow [] dr;
			foreach(DataRow r in ttb.get_data(sql).Tables[0].Rows)
			{
				r1=ttb.getrowbyid(dt,"id="+int.Parse(r["mabd"].ToString()));
				if (r1!=null)
				{
                    sql = "makp=" + int.Parse(r["makp"].ToString()) + " and mabd=" + int.Parse(r["mabd"].ToString()) + " and giamua=" + decimal.Parse(r["giamua"].ToString());
                    try
                    {
                        if (r["namsd"].ToString().Trim() != "") sql += " and namsd=" + int.Parse(r["namsd"].ToString());
                    }
                    catch { }
					r2=ttb.getrowbyid(ds.Tables[0],sql);
					if (r2==null)
					{
						r3=ds.Tables[0].NewRow();
						r3["tennhom"]=r1["tennhom"].ToString();
						r3["makp"]=r["makp"].ToString();
						r3["mabd"]=r["mabd"].ToString();
						r3["ma"]=r1["ma"].ToString();
						r3["ten"]=r1["ten"].ToString().Trim()+" "+r1["hamluong"].ToString();
						r3["dang"]=r1["dang"].ToString();
						r3["soluong"]=r["soluong"].ToString();
						r3["giamua"]=r["giamua"].ToString();
                        try
                        {
                            r3["namsd"] = r["namsd"].ToString() == "   " ? "0" : r["namsd"].ToString().Substring(r["namsd"].ToString().Length - 4, 4);
                        }
                        catch
                        {
                            r3["namsd"] = "0";
                        }
                      
						r3["tyle"]=r1["tyle"].ToString();
						r3["nam"]=0;
						r3["sotienhm"]=0;
						if (r["makp"].ToString()=="0") r3["tenkp"]="";
						else
						{
							r4=ttb.getrowbyid(dtmakp,"id="+int.Parse(r["makp"].ToString()));
							if (r4!=null) r3["tenkp"]=r4["ten"].ToString();
							else r3["tenkp"]="";
						}
						ds.Tables[0].Rows.Add(r3);
					}
					else
					{
						dr=ds.Tables[0].Select(sql);
						if (dr.Length>0) dr[0]["soluong"]=decimal.Parse(dr[0]["soluong"].ToString())+decimal.Parse(r["soluong"].ToString());
					}
				}
			}
		}
		private void get_data()
		{
            xxx = user;// +s_mmyy;
			if (rb1.Checked || rb2.Checked)
			{
				sql="select 0 as makp,a.mabd,d.giamua,d.namsd,sum(a.tondau+a.slnhap-a.slxuat) as soluong ";
				sql+=" from "+xxx+".ttb_tonkhoct a, "+user+".ttb_dmbd b,"+user+".ttb_dmnhom c,"+xxx+".ttb_theodoi d";
				sql+=" where a.stt=d.id and a.mabd=b.id and b.manhom=c.id and c.theodoi=1 and b.bhyt<>0 ";
				if (s_nhom!="") sql+=" and b.manhom in ("+s_nhom.Substring(0,s_nhom.Length-1)+")";
				if (s_kho!="" && kho.Enabled) sql+=" and a.makho in ("+s_kho.Substring(0,s_kho.Length-1)+")";
				if (s_kho=="" && i_nhom==10) sql+=" and b.nhom in (2,10)";
				else if (s_kho=="" && i_nhom==3) sql+=" and b.nhom in (3,9)";
				else sql+=" and b.nhom="+i_nhom;
                sql += " and a.mmyy='" + s_mmyy + "' group by a.mabd,d.giamua,d.namsd";
				ins_items();
			}
			if (rb1.Checked || rb3.Checked)
			{
				sql="select a.makp,a.mabd,d.giamua,d.namsd,sum(a.tondau+a.slnhap-a.slxuat) as soluong ";
				sql+=" from "+xxx+".ttb_tutrucct a, "+user+".ttb_dmbd b,"+user+".ttb_dmnhom c,"+xxx+".ttb_theodoi d";
				sql+=" where a.stt=d.id and a.mabd=b.id and b.manhom=c.id and c.theodoi=1 and b.bhyt<>0 ";
				if (s_nhom!="") sql+=" and b.manhom in ("+s_nhom.Substring(0,s_nhom.Length-1)+")";
				if (s_kho!="" && kho.Enabled) sql+=" and a.makho in ("+s_kho.Substring(0,s_kho.Length-1)+")";
				if (s_makp!="" && makp.Enabled) sql+=" and a.makp in ("+s_makp.Substring(0,s_makp.Length-1)+")";
				if (s_kho=="" && i_nhom==10) sql+=" and b.nhom in (2,10)";
				else if (s_kho=="" && i_nhom==3) sql+=" and b.nhom in (3,9)";
				else sql+=" and b.nhom="+i_nhom;
                sql += "and a.mmyy='" + s_mmyy + "' group by a.makp,a.mabd,d.giamua,d.namsd";
				ins_items();
			}
		}

		private void butKetthuc_Click(object sender, System.EventArgs e)
		{
			ttb.writeXml("ttb_tskiemke","c01",c1.Text);
			ttb.writeXml("ttb_tskiemke","c02",c2.Text);
			ttb.writeXml("ttb_tskiemke","c03",c3.Text);
			ttb.writeXml("ttb_tskiemke","c04",c4.Text);
			ttb.writeXml("ttb_tskiemke","c05",c5.Text);
			ttb.writeXml("ttb_tskiemke","c06",c6.Text);
			ttb.writeXml("ttb_tskiemke","c11",c11.Text);
			ttb.writeXml("ttb_tskiemke","c12",c12.Text);
			ttb.writeXml("ttb_tskiemke","c13",c13.Text);
			ttb.writeXml("ttb_tskiemke","c14",c14.Text);
			ttb.writeXml("ttb_tskiemke","c15",c15.Text);
			ttb.writeXml("ttb_tskiemke","c16",c16.Text);
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

		private void rb2_CheckedChanged(object sender, System.EventArgs e)
		{
			kho.Enabled=rb2.Checked;
			makp.Enabled=!rb2.Checked;
		}

		private void rb3_CheckedChanged(object sender, System.EventArgs e)
		{
			kho.Enabled=!rb3.Checked;
			makp.Enabled=rb3.Checked;
		}

		private void rb1_CheckedChanged(object sender, System.EventArgs e)
		{
			makp.Enabled=false;
			kho.Enabled=rb1.Checked;
		}
	}
}
