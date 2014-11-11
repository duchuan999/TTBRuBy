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
	/// Summary description for frmThongso.
	/// </summary>
	public class frmThongso : System.Windows.Forms.Form
	{
		private System.Windows.Forms.CheckBox c02;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private Medisoft2009.Usercontrol.MaskedTextBox c07;
		private Medisoft2009.Usercontrol.MaskedTextBox c08;
		private Medisoft2009.Usercontrol.MaskedTextBox c09;
		private System.Windows.Forms.Button butOK;
		private System.Windows.Forms.Button butKetthuc;
		private DataSet ds=new DataSet();
		private DataSet dstt=new DataSet();
		private DataSet dsmua=new DataSet();
        private LibTTB.AccessData ttb;
		private System.Windows.Forms.CheckBox c05;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.NumericUpDown c10;
		private System.Windows.Forms.CheckBox c11;
		private System.Windows.Forms.CheckBox c12;
		private string s_mmyy,user,xxx;
		private int i_nhom,i_userid;
		private Medisoft2009.Usercontrol.MaskedTextBox c15;
		private System.Windows.Forms.Label label4;
		private Medisoft2009.Usercontrol.MaskedTextBox c16;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown c22;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox c23;
		private System.Windows.Forms.CheckBox c24;
		private System.Windows.Forms.CheckBox c25;
		private Medisoft2009.Usercontrol.MaskedTextBox ma13;
		private Medisoft2009.Usercontrol.MaskedTextBox ma16;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.CheckBox c26;
		private System.Windows.Forms.CheckBox c27;
		private System.Windows.Forms.CheckBox c28;
		private System.Windows.Forms.CheckBox c29;
		private System.Windows.Forms.CheckBox c30;
		private System.Windows.Forms.CheckBox c31;
		private Medisoft2009.Usercontrol.MaskedTextBox c32;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button butHinh;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private Medisoft2009.Usercontrol.MaskedTextBox kho;
		private Medisoft2009.Usercontrol.MaskedTextBox hinh;
		private System.Windows.Forms.CheckBox c34;
		private System.Windows.Forms.CheckBox c36;
		private System.Windows.Forms.CheckBox c35;
		private System.Windows.Forms.CheckBox c37;
		private System.Windows.Forms.CheckBox c38;
		private System.Windows.Forms.CheckBox c39;
		private System.Windows.Forms.CheckBox c40;
		private System.Windows.Forms.CheckBox c41;
		private System.Windows.Forms.Label label19;
		private Medisoft2009.Usercontrol.MaskedTextBox c48;
		private Medisoft2009.Usercontrol.MaskedTextBox c49;
		private Medisoft2009.Usercontrol.MaskedTextBox c50;
		private Medisoft2009.Usercontrol.MaskedTextBox c51;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private Medisoft2009.Usercontrol.MaskedTextBox c52;
		private Medisoft2009.Usercontrol.MaskedTextBox c53;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.NumericUpDown c57;
		private System.Windows.Forms.NumericUpDown c58;
		private System.Windows.Forms.NumericUpDown c59;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.TabControl tab;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Label label18;
		private Medisoft2009.Usercontrol.MaskedTextBox c47;
		private System.Windows.Forms.Label label24;
		private Medisoft2009.Usercontrol.MaskedTextBox c56;
		private System.Windows.Forms.CheckBox c62;
		private System.Windows.Forms.CheckBox c70;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.NumericUpDown c79;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label33;
		private Medisoft2009.Usercontrol.MaskedTextBox c83;
		private Medisoft2009.Usercontrol.MaskedTextBox c84;
		private System.Windows.Forms.CheckBox c94;
		private System.Windows.Forms.CheckBox c95;
		private System.Windows.Forms.CheckBox c96;
		private System.Windows.Forms.CheckBox c97;
		private System.Windows.Forms.CheckBox c106;
		private System.Windows.Forms.Label label40;
		private Medisoft2009.Usercontrol.MaskedTextBox c112;
		private System.Windows.Forms.CheckBox c116;
		private System.Windows.Forms.Label label41;
		private Medisoft2009.Usercontrol.MaskedTextBox c120;
		private Medisoft2009.Usercontrol.MaskedTextBox c121;
		private System.Windows.Forms.Label label42;
		private System.Windows.Forms.Label label43;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.DataGrid dataGrid2;
		private System.Windows.Forms.CheckBox c13;
		private System.Windows.Forms.CheckBox c04;
		private System.Windows.Forms.CheckBox c45;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.NumericUpDown c105;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmThongso(AccessData acc,string mmyy,int nhom,int userid,bool giaban)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			ttb=acc;
			s_mmyy=mmyy;
			i_nhom=nhom;
			i_userid=userid;
			c13.Text="Khoá số liệu tháng "+mmyy.Substring(0,2)+" năm "+mmyy.Substring(2,2);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongso));
            this.c02 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.c07 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c08 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c09 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.butOK = new System.Windows.Forms.Button();
            this.butKetthuc = new System.Windows.Forms.Button();
            this.c05 = new System.Windows.Forms.CheckBox();
            this.c10 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.c11 = new System.Windows.Forms.CheckBox();
            this.c12 = new System.Windows.Forms.CheckBox();
            this.c15 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.c16 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.c22 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.c23 = new System.Windows.Forms.CheckBox();
            this.c24 = new System.Windows.Forms.CheckBox();
            this.c25 = new System.Windows.Forms.CheckBox();
            this.ma13 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.ma16 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.c26 = new System.Windows.Forms.CheckBox();
            this.c27 = new System.Windows.Forms.CheckBox();
            this.c28 = new System.Windows.Forms.CheckBox();
            this.c29 = new System.Windows.Forms.CheckBox();
            this.c30 = new System.Windows.Forms.CheckBox();
            this.c31 = new System.Windows.Forms.CheckBox();
            this.c32 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.butHinh = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.kho = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.hinh = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c34 = new System.Windows.Forms.CheckBox();
            this.c36 = new System.Windows.Forms.CheckBox();
            this.c35 = new System.Windows.Forms.CheckBox();
            this.c37 = new System.Windows.Forms.CheckBox();
            this.c38 = new System.Windows.Forms.CheckBox();
            this.c39 = new System.Windows.Forms.CheckBox();
            this.c40 = new System.Windows.Forms.CheckBox();
            this.c41 = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.c48 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c49 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c50 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c51 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.c52 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c53 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.c57 = new System.Windows.Forms.NumericUpDown();
            this.c58 = new System.Windows.Forms.NumericUpDown();
            this.c59 = new System.Windows.Forms.NumericUpDown();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label37 = new System.Windows.Forms.Label();
            this.c105 = new System.Windows.Forms.NumericUpDown();
            this.label36 = new System.Windows.Forms.Label();
            this.c45 = new System.Windows.Forms.CheckBox();
            this.c04 = new System.Windows.Forms.CheckBox();
            this.c13 = new System.Windows.Forms.CheckBox();
            this.c116 = new System.Windows.Forms.CheckBox();
            this.c106 = new System.Windows.Forms.CheckBox();
            this.c97 = new System.Windows.Forms.CheckBox();
            this.c96 = new System.Windows.Forms.CheckBox();
            this.c95 = new System.Windows.Forms.CheckBox();
            this.c94 = new System.Windows.Forms.CheckBox();
            this.c70 = new System.Windows.Forms.CheckBox();
            this.c62 = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.c121 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c120 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.c56 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c47 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c112 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.c84 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c83 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.c79 = new System.Windows.Forms.NumericUpDown();
            this.label32 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.dataGrid2 = new System.Windows.Forms.DataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.c10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c57)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c58)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c59)).BeginInit();
            this.tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c105)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c79)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // c02
            // 
            this.c02.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c02.Location = new System.Drawing.Point(19, 32);
            this.c02.Name = "c02";
            this.c02.Size = new System.Drawing.Size(136, 20);
            this.c02.TabIndex = 2;
            this.c02.Text = "Mã số tự động";
            this.c02.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c02_KeyDown);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(499, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ban giám đốc :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(470, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phụ trách bộ phận :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(499, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Người lập biểu :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // c07
            // 
            this.c07.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c07.Location = new System.Drawing.Point(587, 32);
            this.c07.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c07.Name = "c07";
            this.c07.Size = new System.Drawing.Size(171, 21);
            this.c07.TabIndex = 13;
            // 
            // c08
            // 
            this.c08.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c08.Location = new System.Drawing.Point(587, 80);
            this.c08.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c08.Name = "c08";
            this.c08.Size = new System.Drawing.Size(171, 21);
            this.c08.TabIndex = 15;
            // 
            // c09
            // 
            this.c09.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c09.Location = new System.Drawing.Point(587, 104);
            this.c09.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c09.Name = "c09";
            this.c09.Size = new System.Drawing.Size(171, 21);
            this.c09.TabIndex = 16;
            // 
            // butOK
            // 
            this.butOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butOK.Location = new System.Drawing.Point(337, 401);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(60, 25);
            this.butOK.TabIndex = 56;
            this.butOK.Text = "&Cập nhật";
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // butKetthuc
            // 
            this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butKetthuc.Location = new System.Drawing.Point(398, 401);
            this.butKetthuc.Name = "butKetthuc";
            this.butKetthuc.Size = new System.Drawing.Size(60, 25);
            this.butKetthuc.TabIndex = 57;
            this.butKetthuc.Text = "&Kết thúc";
            this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
            // 
            // c05
            // 
            this.c05.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c05.Location = new System.Drawing.Point(276, 154);
            this.c05.Name = "c05";
            this.c05.Size = new System.Drawing.Size(136, 20);
            this.c05.TabIndex = 6;
            this.c05.Text = "Xem trước khi in";
            this.c05.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c02_KeyDown);
            // 
            // c10
            // 
            this.c10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c10.Location = new System.Drawing.Point(688, 176);
            this.c10.Name = "c10";
            this.c10.Size = new System.Drawing.Size(48, 21);
            this.c10.TabIndex = 19;
            this.c10.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.c10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c02_KeyDown);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(736, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "ngày";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(504, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Ngày làm việc so với ngày hệ thống :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // c11
            // 
            this.c11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c11.Location = new System.Drawing.Point(19, 85);
            this.c11.Name = "c11";
            this.c11.Size = new System.Drawing.Size(269, 20);
            this.c11.TabIndex = 21;
            this.c11.Text = "Nhập nhóm báo cáo trong khai báo danh mục";
            this.c11.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c02_KeyDown);
            // 
            // c12
            // 
            this.c12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c12.Location = new System.Drawing.Point(19, 103);
            this.c12.Name = "c12";
            this.c12.Size = new System.Drawing.Size(250, 21);
            this.c12.TabIndex = 22;
            this.c12.Text = "Nhập nhóm kế toán trong khai báo danh mục";
            this.c12.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c02_KeyDown);
            // 
            // c15
            // 
            this.c15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c15.Location = new System.Drawing.Point(587, 56);
            this.c15.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c15.Name = "c15";
            this.c15.Size = new System.Drawing.Size(171, 21);
            this.c15.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(510, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Kế toán kho :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // c16
            // 
            this.c16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c16.Location = new System.Drawing.Point(587, 152);
            this.c16.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c16.Name = "c16";
            this.c16.Size = new System.Drawing.Size(171, 21);
            this.c16.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(510, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "Thủ kho :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // c22
            // 
            this.c22.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c22.Location = new System.Drawing.Point(688, 200);
            this.c22.Name = "c22";
            this.c22.Size = new System.Drawing.Size(48, 21);
            this.c22.TabIndex = 20;
            this.c22.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.c22.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c02_KeyDown);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(736, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "ngày";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(502, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 19);
            this.label7.TabIndex = 32;
            this.label7.Text = "Số ngày hoàn trả so với ngày lãnh là :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // c23
            // 
            this.c23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c23.Location = new System.Drawing.Point(19, 66);
            this.c23.Name = "c23";
            this.c23.Size = new System.Drawing.Size(136, 20);
            this.c23.TabIndex = 3;
            this.c23.Text = "Nhập tên hoạt chất";
            this.c23.Visible = false;
            this.c23.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c02_KeyDown);
            // 
            // c24
            // 
            this.c24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c24.Location = new System.Drawing.Point(19, 225);
            this.c24.Name = "c24";
            this.c24.Size = new System.Drawing.Size(186, 21);
            this.c24.TabIndex = 27;
            this.c24.Text = "Nhập họ tên trong xuất ngoại trú";
            this.c24.Visible = false;
            this.c24.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c02_KeyDown);
            // 
            // c25
            // 
            this.c25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c25.Location = new System.Drawing.Point(19, 243);
            this.c25.Name = "c25";
            this.c25.Size = new System.Drawing.Size(202, 21);
            this.c25.TabIndex = 28;
            this.c25.Text = "Nhập năm sinh trong xuất ngoại trú";
            this.c25.Visible = false;
            this.c25.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c02_KeyDown);
            // 
            // ma13
            // 
            this.ma13.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ma13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ma13.Location = new System.Drawing.Point(112, 32);
            this.ma13.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.ma13.Name = "ma13";
            this.ma13.Size = new System.Drawing.Size(456, 21);
            this.ma13.TabIndex = 48;
            this.ma13.Visible = false;
            // 
            // ma16
            // 
            this.ma16.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ma16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ma16.Location = new System.Drawing.Point(112, 56);
            this.ma16.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.ma16.Name = "ma16";
            this.ma16.Size = new System.Drawing.Size(456, 21);
            this.ma16.TabIndex = 52;
            this.ma16.Visible = false;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(24, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 23);
            this.label12.TabIndex = 37;
            this.label12.Text = "Số thẻ 16 ký tự :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.Visible = false;
            // 
            // c26
            // 
            this.c26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c26.Location = new System.Drawing.Point(176, 36);
            this.c26.Name = "c26";
            this.c26.Size = new System.Drawing.Size(85, 16);
            this.c26.TabIndex = 40;
            this.c26.Text = "Nhập mã số";
            this.c26.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c02_KeyDown);
            // 
            // c27
            // 
            this.c27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c27.Location = new System.Drawing.Point(19, 136);
            this.c27.Name = "c27";
            this.c27.Size = new System.Drawing.Size(178, 22);
            this.c27.TabIndex = 23;
            this.c27.Text = "Nhập số thẻ trong bảo hiểm";
            this.c27.Visible = false;
            // 
            // c28
            // 
            this.c28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c28.Location = new System.Drawing.Point(276, 99);
            this.c28.Name = "c28";
            this.c28.Size = new System.Drawing.Size(160, 20);
            this.c28.TabIndex = 8;
            this.c28.Text = "Lọc ngày trong phiếu lĩnh";
            this.c28.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c02_KeyDown);
            // 
            // c29
            // 
            this.c29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c29.Location = new System.Drawing.Point(276, 117);
            this.c29.Name = "c29";
            this.c29.Size = new System.Drawing.Size(176, 20);
            this.c29.TabIndex = 9;
            this.c29.Text = "Lọc ngày trong phiếu hoàn trả";
            this.c29.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c02_KeyDown);
            // 
            // c30
            // 
            this.c30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c30.Location = new System.Drawing.Point(276, 49);
            this.c30.Name = "c30";
            this.c30.Size = new System.Drawing.Size(184, 20);
            this.c30.TabIndex = 10;
            this.c30.Text = "Lọc ngày trong xuất bảo hiểm";
            this.c30.Visible = false;
            this.c30.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c02_KeyDown);
            // 
            // c31
            // 
            this.c31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c31.Location = new System.Drawing.Point(276, 66);
            this.c31.Name = "c31";
            this.c31.Size = new System.Drawing.Size(176, 20);
            this.c31.TabIndex = 11;
            this.c31.Text = "Lọc ngày trong xuất ngoại trú";
            this.c31.Visible = false;
            this.c31.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c02_KeyDown);
            // 
            // c32
            // 
            this.c32.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c32.Location = new System.Drawing.Point(587, 128);
            this.c32.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c32.Name = "c32";
            this.c32.Size = new System.Drawing.Size(171, 21);
            this.c32.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(483, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 23);
            this.label13.TabIndex = 38;
            this.label13.Text = "Phụ trách  kế toán :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // butHinh
            // 
            this.butHinh.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butHinh.Location = new System.Drawing.Point(760, 8);
            this.butHinh.Name = "butHinh";
            this.butHinh.Size = new System.Drawing.Size(22, 21);
            this.butHinh.TabIndex = 35;
            this.butHinh.Text = "...";
            this.butHinh.Click += new System.EventHandler(this.butHinh_Click);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(-4, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 23);
            this.label14.TabIndex = 40;
            this.label14.Text = "Tiêu đề :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(302, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 23);
            this.label15.TabIndex = 41;
            this.label15.Text = "Hình :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // kho
            // 
            this.kho.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kho.Location = new System.Drawing.Point(56, 8);
            this.kho.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.kho.Name = "kho";
            this.kho.Size = new System.Drawing.Size(251, 21);
            this.kho.TabIndex = 0;
            // 
            // hinh
            // 
            this.hinh.BackColor = System.Drawing.SystemColors.HighlightText;
            this.hinh.Enabled = false;
            this.hinh.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hinh.Location = new System.Drawing.Point(342, 8);
            this.hinh.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.hinh.Name = "hinh";
            this.hinh.Size = new System.Drawing.Size(416, 21);
            this.hinh.TabIndex = 1;
            // 
            // c34
            // 
            this.c34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c34.Location = new System.Drawing.Point(19, 155);
            this.c34.Name = "c34";
            this.c34.Size = new System.Drawing.Size(197, 21);
            this.c34.TabIndex = 24;
            this.c34.Text = "Nhập phòng khám trong bảo hiểm";
            this.c34.Visible = false;
            this.c34.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c02_KeyDown);
            // 
            // c36
            // 
            this.c36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c36.Location = new System.Drawing.Point(19, 173);
            this.c36.Name = "c36";
            this.c36.Size = new System.Drawing.Size(197, 20);
            this.c36.TabIndex = 25;
            this.c36.Text = "Nhập chẩn đoán trong bảo hiểm";
            this.c36.Visible = false;
            this.c36.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c02_KeyDown);
            // 
            // c35
            // 
            this.c35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c35.Location = new System.Drawing.Point(19, 190);
            this.c35.Name = "c35";
            this.c35.Size = new System.Drawing.Size(166, 21);
            this.c35.TabIndex = 34;
            this.c35.Text = "Nhập bác sĩ trong bảo hiểm";
            this.c35.Visible = false;
            this.c35.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c02_KeyDown);
            // 
            // c37
            // 
            this.c37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c37.Location = new System.Drawing.Point(276, 83);
            this.c37.Name = "c37";
            this.c37.Size = new System.Drawing.Size(168, 21);
            this.c37.TabIndex = 12;
            this.c37.Text = "Lọc ngày trong xuất tủ trực";
            this.c37.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c02_KeyDown);
            // 
            // c38
            // 
            this.c38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c38.Location = new System.Drawing.Point(19, 300);
            this.c38.Name = "c38";
            this.c38.Size = new System.Drawing.Size(198, 21);
            this.c38.TabIndex = 35;
            this.c38.Text = "Nhập khoa/phòng xuất ngoại trú";
            this.c38.Visible = false;
            this.c38.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c02_KeyDown);
            // 
            // c39
            // 
            this.c39.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c39.Location = new System.Drawing.Point(19, 261);
            this.c39.Name = "c39";
            this.c39.Size = new System.Drawing.Size(198, 21);
            this.c39.TabIndex = 36;
            this.c39.Text = "Nhập bác sỹ trong xuất ngoại trú";
            this.c39.Visible = false;
            this.c39.CheckedChanged += new System.EventHandler(this.c39_CheckedChanged);
            this.c39.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c02_KeyDown);
            // 
            // c40
            // 
            this.c40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c40.Location = new System.Drawing.Point(19, 207);
            this.c40.Name = "c40";
            this.c40.Size = new System.Drawing.Size(234, 21);
            this.c40.TabIndex = 26;
            this.c40.Text = "Nhập mã người bệnh trong xuất ngoại trú";
            this.c40.Visible = false;
            // 
            // c41
            // 
            this.c41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c41.Location = new System.Drawing.Point(276, 136);
            this.c41.Name = "c41";
            this.c41.Size = new System.Drawing.Size(200, 20);
            this.c41.TabIndex = 37;
            this.c41.Text = "Lọc theo người dùng trong duyệt";
            this.c41.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c02_KeyDown);
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(572, 8);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 23);
            this.label19.TabIndex = 52;
            this.label19.Text = "Ngoại trú chi trả";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Visible = false;
            // 
            // c48
            // 
            this.c48.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.c48.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c48.Location = new System.Drawing.Point(570, 32);
            this.c48.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c48.Name = "c48";
            this.c48.Size = new System.Drawing.Size(94, 21);
            this.c48.TabIndex = 49;
            this.c48.Visible = false;
            // 
            // c49
            // 
            this.c49.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.c49.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c49.Location = new System.Drawing.Point(570, 56);
            this.c49.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c49.Name = "c49";
            this.c49.Size = new System.Drawing.Size(94, 21);
            this.c49.TabIndex = 53;
            this.c49.Visible = false;
            // 
            // c50
            // 
            this.c50.BackColor = System.Drawing.SystemColors.HighlightText;
            this.c50.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c50.Location = new System.Drawing.Point(682, 32);
            this.c50.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c50.Name = "c50";
            this.c50.Size = new System.Drawing.Size(57, 21);
            this.c50.TabIndex = 50;
            this.c50.Text = "20000";
            this.c50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.c50.Visible = false;
            // 
            // c51
            // 
            this.c51.BackColor = System.Drawing.SystemColors.HighlightText;
            this.c51.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c51.Location = new System.Drawing.Point(682, 56);
            this.c51.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c51.Name = "c51";
            this.c51.Size = new System.Drawing.Size(57, 21);
            this.c51.TabIndex = 54;
            this.c51.Text = "20000";
            this.c51.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.c51.Visible = false;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(680, 8);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 23);
            this.label20.TabIndex = 57;
            this.label20.Text = "Số tiền";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label20.Visible = false;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(666, 31);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(16, 23);
            this.label21.TabIndex = 58;
            this.label21.Text = ">";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label21.Visible = false;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(666, 55);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(16, 23);
            this.label22.TabIndex = 59;
            this.label22.Text = ">";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label22.Visible = false;
            // 
            // c52
            // 
            this.c52.BackColor = System.Drawing.SystemColors.HighlightText;
            this.c52.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c52.Location = new System.Drawing.Point(741, 32);
            this.c52.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c52.Name = "c52";
            this.c52.Size = new System.Drawing.Size(39, 21);
            this.c52.TabIndex = 51;
            this.c52.Text = "5,1";
            this.c52.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.c52.Visible = false;
            this.c52.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c02_KeyDown);
            // 
            // c53
            // 
            this.c53.BackColor = System.Drawing.SystemColors.HighlightText;
            this.c53.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c53.Location = new System.Drawing.Point(741, 56);
            this.c53.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c53.Name = "c53";
            this.c53.Size = new System.Drawing.Size(39, 21);
            this.c53.TabIndex = 55;
            this.c53.Text = "5,2";
            this.c53.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.c53.Visible = false;
            this.c53.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c02_KeyDown);
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(744, 8);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 23);
            this.label23.TabIndex = 62;
            this.label23.Text = "Vị trí";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label23.Visible = false;
            // 
            // label28
            // 
            this.label28.Location = new System.Drawing.Point(150, 105);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(34, 17);
            this.label28.TabIndex = 80;
            this.label28.Text = "số lẻ";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(48, 169);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(64, 17);
            this.label27.TabIndex = 79;
            this.label27.Text = "Thành tiền :";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(56, 103);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(56, 17);
            this.label25.TabIndex = 76;
            this.label25.Text = "Số lượng :";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(48, 125);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(64, 17);
            this.label26.TabIndex = 78;
            this.label26.Text = "Đơn giá :";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // c57
            // 
            this.c57.Location = new System.Drawing.Point(112, 103);
            this.c57.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.c57.Name = "c57";
            this.c57.Size = new System.Drawing.Size(32, 20);
            this.c57.TabIndex = 83;
            // 
            // c58
            // 
            this.c58.Location = new System.Drawing.Point(112, 125);
            this.c58.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.c58.Name = "c58";
            this.c58.Size = new System.Drawing.Size(32, 20);
            this.c58.TabIndex = 84;
            // 
            // c59
            // 
            this.c59.Location = new System.Drawing.Point(112, 169);
            this.c59.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.c59.Name = "c59";
            this.c59.Size = new System.Drawing.Size(32, 20);
            this.c59.TabIndex = 85;
            // 
            // label29
            // 
            this.label29.Location = new System.Drawing.Point(150, 127);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(34, 17);
            this.label29.TabIndex = 89;
            this.label29.Text = "số lẻ";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label30
            // 
            this.label30.Location = new System.Drawing.Point(150, 169);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(34, 17);
            this.label30.TabIndex = 90;
            this.label30.Text = "số lẻ";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Controls.Add(this.tabPage3);
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(792, 392);
            this.tab.TabIndex = 92;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label37);
            this.tabPage1.Controls.Add(this.c105);
            this.tabPage1.Controls.Add(this.c10);
            this.tabPage1.Controls.Add(this.c22);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label36);
            this.tabPage1.Controls.Add(this.c28);
            this.tabPage1.Controls.Add(this.c45);
            this.tabPage1.Controls.Add(this.c04);
            this.tabPage1.Controls.Add(this.c13);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.c37);
            this.tabPage1.Controls.Add(this.c116);
            this.tabPage1.Controls.Add(this.c106);
            this.tabPage1.Controls.Add(this.c29);
            this.tabPage1.Controls.Add(this.c97);
            this.tabPage1.Controls.Add(this.c96);
            this.tabPage1.Controls.Add(this.c95);
            this.tabPage1.Controls.Add(this.c94);
            this.tabPage1.Controls.Add(this.c70);
            this.tabPage1.Controls.Add(this.c62);
            this.tabPage1.Controls.Add(this.hinh);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.kho);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.butHinh);
            this.tabPage1.Controls.Add(this.c02);
            this.tabPage1.Controls.Add(this.c23);
            this.tabPage1.Controls.Add(this.c05);
            this.tabPage1.Controls.Add(this.c11);
            this.tabPage1.Controls.Add(this.c12);
            this.tabPage1.Controls.Add(this.c30);
            this.tabPage1.Controls.Add(this.c31);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.c07);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.c32);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.c08);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.c09);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.c15);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.c16);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.c26);
            this.tabPage1.Controls.Add(this.c27);
            this.tabPage1.Controls.Add(this.c34);
            this.tabPage1.Controls.Add(this.c36);
            this.tabPage1.Controls.Add(this.c40);
            this.tabPage1.Controls.Add(this.c24);
            this.tabPage1.Controls.Add(this.c25);
            this.tabPage1.Controls.Add(this.c41);
            this.tabPage1.Controls.Add(this.c35);
            this.tabPage1.Controls.Add(this.c38);
            this.tabPage1.Controls.Add(this.c39);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(784, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1";
            // 
            // label37
            // 
            this.label37.Location = new System.Drawing.Point(736, 224);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(32, 19);
            this.label37.TabIndex = 126;
            this.label37.Text = "ngày";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // c105
            // 
            this.c105.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c105.Location = new System.Drawing.Point(688, 224);
            this.c105.Name = "c105";
            this.c105.Size = new System.Drawing.Size(48, 21);
            this.c105.TabIndex = 125;
            this.c105.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label36
            // 
            this.label36.Location = new System.Drawing.Point(544, 224);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(152, 17);
            this.label36.TabIndex = 124;
            this.label36.Text = "Khoảng cách ngày kiểm kê :";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // c45
            // 
            this.c45.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c45.Location = new System.Drawing.Point(276, 256);
            this.c45.Name = "c45";
            this.c45.Size = new System.Drawing.Size(240, 20);
            this.c45.TabIndex = 123;
            this.c45.Text = "Nhập số lượng qui đổi trong phiếu nhập";
            // 
            // c04
            // 
            this.c04.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c04.Location = new System.Drawing.Point(276, 239);
            this.c04.Name = "c04";
            this.c04.Size = new System.Drawing.Size(136, 20);
            this.c04.TabIndex = 122;
            this.c04.Text = "Nhập đơn giá";
            // 
            // c13
            // 
            this.c13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c13.Location = new System.Drawing.Point(276, 32);
            this.c13.Name = "c13";
            this.c13.Size = new System.Drawing.Size(224, 20);
            this.c13.TabIndex = 121;
            this.c13.Text = "Đã khóa số liệu";
            // 
            // c116
            // 
            this.c116.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c116.Location = new System.Drawing.Point(19, 51);
            this.c116.Name = "c116";
            this.c116.Size = new System.Drawing.Size(237, 16);
            this.c116.TabIndex = 120;
            this.c116.Text = "Nhập nhà cung cấp trong danh mục";
            // 
            // c106
            // 
            this.c106.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c106.Location = new System.Drawing.Point(19, 280);
            this.c106.Name = "c106";
            this.c106.Size = new System.Drawing.Size(198, 21);
            this.c106.TabIndex = 119;
            this.c106.Text = "Bắt buộc phải nhập bác sỹ";
            this.c106.Visible = false;
            this.c106.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c02_KeyDown);
            // 
            // c97
            // 
            this.c97.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c97.Location = new System.Drawing.Point(276, 223);
            this.c97.Name = "c97";
            this.c97.Size = new System.Drawing.Size(232, 21);
            this.c97.TabIndex = 116;
            this.c97.Text = "Nhập định khoản trong phiếu nhập";
            // 
            // c96
            // 
            this.c96.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c96.Location = new System.Drawing.Point(276, 207);
            this.c96.Name = "c96";
            this.c96.Size = new System.Drawing.Size(232, 21);
            this.c96.TabIndex = 115;
            this.c96.Text = "Nhập người giao hàng trong phiếu nhập";
            // 
            // c95
            // 
            this.c95.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c95.Location = new System.Drawing.Point(276, 189);
            this.c95.Name = "c95";
            this.c95.Size = new System.Drawing.Size(232, 21);
            this.c95.TabIndex = 114;
            this.c95.Text = "Nhập biên bản kê trong phiếu nhập";
            // 
            // c94
            // 
            this.c94.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c94.Location = new System.Drawing.Point(19, 317);
            this.c94.Name = "c94";
            this.c94.Size = new System.Drawing.Size(229, 21);
            this.c94.TabIndex = 113;
            this.c94.Text = "Nhập chẩn đoán trong xuất ngoại trú";
            this.c94.Visible = false;
            this.c94.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c02_KeyDown);
            // 
            // c70
            // 
            this.c70.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c70.Location = new System.Drawing.Point(276, 171);
            this.c70.Name = "c70";
            this.c70.Size = new System.Drawing.Size(248, 20);
            this.c70.TabIndex = 94;
            this.c70.Text = "Lọc theo người nhập trong phiếu bảo hiểm";
            this.c70.Visible = false;
            this.c70.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c02_KeyDown);
            // 
            // c62
            // 
            this.c62.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c62.Location = new System.Drawing.Point(19, 122);
            this.c62.Name = "c62";
            this.c62.Size = new System.Drawing.Size(216, 16);
            this.c62.TabIndex = 89;
            this.c62.Text = "Nhập mã người bệnh  trong bảo hiểm";
            this.c62.Visible = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label43);
            this.tabPage3.Controls.Add(this.label42);
            this.tabPage3.Controls.Add(this.c121);
            this.tabPage3.Controls.Add(this.c120);
            this.tabPage3.Controls.Add(this.label41);
            this.tabPage3.Controls.Add(this.label28);
            this.tabPage3.Controls.Add(this.c56);
            this.tabPage3.Controls.Add(this.c47);
            this.tabPage3.Controls.Add(this.c112);
            this.tabPage3.Controls.Add(this.label40);
            this.tabPage3.Controls.Add(this.c84);
            this.tabPage3.Controls.Add(this.c83);
            this.tabPage3.Controls.Add(this.label33);
            this.tabPage3.Controls.Add(this.label31);
            this.tabPage3.Controls.Add(this.c79);
            this.tabPage3.Controls.Add(this.label32);
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label25);
            this.tabPage3.Controls.Add(this.c57);
            this.tabPage3.Controls.Add(this.label26);
            this.tabPage3.Controls.Add(this.c58);
            this.tabPage3.Controls.Add(this.label29);
            this.tabPage3.Controls.Add(this.label27);
            this.tabPage3.Controls.Add(this.c59);
            this.tabPage3.Controls.Add(this.label30);
            this.tabPage3.Controls.Add(this.ma13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.ma16);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.c48);
            this.tabPage3.Controls.Add(this.c49);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.c50);
            this.tabPage3.Controls.Add(this.c52);
            this.tabPage3.Controls.Add(this.c51);
            this.tabPage3.Controls.Add(this.c53);
            this.tabPage3.Controls.Add(this.dataGrid1);
            this.tabPage3.Controls.Add(this.dataGrid2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(784, 366);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "2";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(24, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 23);
            this.label9.TabIndex = 139;
            this.label9.Text = "Số thẻ 13 ký tự :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Visible = false;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(8, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 23);
            this.label8.TabIndex = 138;
            this.label8.Text = "Bảo hiểm cùng chi trả";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Visible = false;
            // 
            // label43
            // 
            this.label43.Location = new System.Drawing.Point(176, 131);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(96, 17);
            this.label43.TabIndex = 137;
            this.label43.Text = "Tự nguyện :";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label43.Visible = false;
            // 
            // label42
            // 
            this.label42.Location = new System.Drawing.Point(408, 128);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(32, 23);
            this.label42.TabIndex = 136;
            this.label42.Text = "Vị trí";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label42.Visible = false;
            // 
            // c121
            // 
            this.c121.BackColor = System.Drawing.SystemColors.HighlightText;
            this.c121.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c121.Location = new System.Drawing.Point(440, 128);
            this.c121.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c121.Name = "c121";
            this.c121.Size = new System.Drawing.Size(39, 21);
            this.c121.TabIndex = 135;
            this.c121.Text = "5,2";
            this.c121.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.c121.Visible = false;
            this.c121.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c02_KeyDown);
            // 
            // c120
            // 
            this.c120.BackColor = System.Drawing.SystemColors.HighlightText;
            this.c120.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.c120.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c120.Location = new System.Drawing.Point(272, 128);
            this.c120.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c120.Name = "c120";
            this.c120.Size = new System.Drawing.Size(112, 21);
            this.c120.TabIndex = 134;
            this.c120.Text = "SS,TT,RR";
            this.c120.Visible = false;
            this.c120.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c02_KeyDown);
            // 
            // label41
            // 
            this.label41.Location = new System.Drawing.Point(408, 105);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(32, 23);
            this.label41.TabIndex = 133;
            this.label41.Text = "Vị trí";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label41.Visible = false;
            // 
            // c56
            // 
            this.c56.BackColor = System.Drawing.SystemColors.HighlightText;
            this.c56.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c56.Location = new System.Drawing.Point(272, 80);
            this.c56.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c56.Name = "c56";
            this.c56.Size = new System.Drawing.Size(112, 21);
            this.c56.TabIndex = 94;
            this.c56.Text = "report";
            // 
            // c47
            // 
            this.c47.BackColor = System.Drawing.SystemColors.HighlightText;
            this.c47.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c47.Location = new System.Drawing.Point(112, 80);
            this.c47.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c47.Name = "c47";
            this.c47.Size = new System.Drawing.Size(56, 21);
            this.c47.TabIndex = 92;
            this.c47.Text = "3000";
            this.c47.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.c47.Visible = false;
            // 
            // c112
            // 
            this.c112.BackColor = System.Drawing.SystemColors.HighlightText;
            this.c112.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.c112.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c112.Location = new System.Drawing.Point(440, 80);
            this.c112.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c112.Name = "c112";
            this.c112.Size = new System.Drawing.Size(112, 21);
            this.c112.TabIndex = 102;
            // 
            // label40
            // 
            this.label40.Location = new System.Drawing.Point(384, 83);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(56, 16);
            this.label40.TabIndex = 101;
            this.label40.Text = "Domain :";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // c84
            // 
            this.c84.BackColor = System.Drawing.SystemColors.HighlightText;
            this.c84.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c84.Location = new System.Drawing.Point(440, 104);
            this.c84.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c84.Name = "c84";
            this.c84.Size = new System.Drawing.Size(39, 21);
            this.c84.TabIndex = 100;
            this.c84.Text = "3,2";
            this.c84.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.c84.Visible = false;
            this.c84.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c02_KeyDown);
            // 
            // c83
            // 
            this.c83.BackColor = System.Drawing.SystemColors.HighlightText;
            this.c83.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.c83.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c83.Location = new System.Drawing.Point(272, 104);
            this.c83.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c83.Name = "c83";
            this.c83.Size = new System.Drawing.Size(112, 21);
            this.c83.TabIndex = 99;
            this.c83.Text = "50";
            this.c83.Visible = false;
            this.c83.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c02_KeyDown);
            // 
            // label33
            // 
            this.label33.Location = new System.Drawing.Point(176, 105);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(96, 17);
            this.label33.TabIndex = 98;
            this.label33.Text = "Số thẻ trong tỉnh :";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label33.Visible = false;
            // 
            // label31
            // 
            this.label31.Location = new System.Drawing.Point(56, 147);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(56, 17);
            this.label31.TabIndex = 95;
            this.label31.Text = "Giá bán :";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // c79
            // 
            this.c79.Location = new System.Drawing.Point(112, 147);
            this.c79.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.c79.Name = "c79";
            this.c79.Size = new System.Drawing.Size(32, 20);
            this.c79.TabIndex = 96;
            // 
            // label32
            // 
            this.label32.Location = new System.Drawing.Point(150, 147);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(34, 17);
            this.label32.TabIndex = 97;
            this.label32.Text = "số lẻ";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(168, 83);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(104, 17);
            this.label24.TabIndex = 93;
            this.label24.Text = "Thư mục báo cáo :";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(-8, 83);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(120, 17);
            this.label18.TabIndex = 91;
            this.label18.Text = "Công khám bảo hiểm :";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label18.Visible = false;
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
            this.dataGrid1.CaptionText = "Thứ tự phiếu lĩnh";
            this.dataGrid1.DataMember = "";
            this.dataGrid1.FlatMode = true;
            this.dataGrid1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid1.GridLineColor = System.Drawing.Color.Gainsboro;
            this.dataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dataGrid1.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dataGrid1.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid1.LinkColor = System.Drawing.Color.Teal;
            this.dataGrid1.Location = new System.Drawing.Point(560, 82);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro;
            this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.RowHeaderWidth = 10;
            this.dataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue;
            this.dataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid1.Size = new System.Drawing.Size(220, 142);
            this.dataGrid1.TabIndex = 109;
            // 
            // dataGrid2
            // 
            this.dataGrid2.AlternatingBackColor = System.Drawing.Color.Lavender;
            this.dataGrid2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid2.CaptionBackColor = System.Drawing.SystemColors.Control;
            this.dataGrid2.CaptionFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid2.CaptionForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid2.CaptionText = "Thứ tự dự trù mua";
            this.dataGrid2.DataMember = "";
            this.dataGrid2.FlatMode = true;
            this.dataGrid2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid2.GridLineColor = System.Drawing.Color.Gainsboro;
            this.dataGrid2.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dataGrid2.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dataGrid2.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid2.LinkColor = System.Drawing.Color.Teal;
            this.dataGrid2.Location = new System.Drawing.Point(560, 219);
            this.dataGrid2.Name = "dataGrid2";
            this.dataGrid2.ParentRowsBackColor = System.Drawing.Color.Gainsboro;
            this.dataGrid2.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid2.ReadOnly = true;
            this.dataGrid2.RowHeaderWidth = 10;
            this.dataGrid2.SelectionBackColor = System.Drawing.Color.CadetBlue;
            this.dataGrid2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid2.Size = new System.Drawing.Size(220, 144);
            this.dataGrid2.TabIndex = 132;
            // 
            // frmThongso
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(794, 463);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.butKetthuc);
            this.Controls.Add(this.butOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThongso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khai báo thông số hệ thống";
            this.Load += new System.EventHandler(this.frmThongso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c57)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c58)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c59)).EndInit();
            this.tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c105)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c79)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void frmThongso_Load(object sender, System.EventArgs e)
		{
            user = ttb.user; xxx = user + s_mmyy;
			ttb.ins_thongso(i_nhom,123);
			ds.ReadXml("..\\..\\..\\xml\\ttb_thongso.xml");
			dstt.ReadXml("..\\..\\..\\xml\\ttb_sttphieulinh.xml");
			dsmua.ReadXml("..\\..\\..\\xml\\ttb_sttmua.xml");
			dataGrid1.DataSource=dstt.Tables[0];
			AddGridTableStyle();
			dataGrid1.ReadOnly=false;
			CurrencyManager cm = (CurrencyManager)BindingContext[dataGrid1.DataSource,dataGrid1.DataMember];  
			DataView dv = (DataView) cm.List; 
			dv.AllowNew = false; 

			dataGrid2.DataSource=dsmua.Tables[0];
			AddGridTableStyle2();
			dataGrid2.ReadOnly=false;
			CurrencyManager cm2 = (CurrencyManager)BindingContext[dataGrid1.DataSource,dataGrid2.DataMember];  
			DataView dv2 = (DataView) cm2.List; 
			dv2.AllowNew = false; 
			foreach(DataRow r in ttb.get_data("select * from "+user+".ttb_thongso where nhom="+i_nhom+" order by id").Tables[0].Rows)
			{
				switch (int.Parse(r["id"].ToString()))
				{
					case 2: c02.Checked=(ttb.Thongso("c02")=="1")?true:false;
						break;
					case 4: c04.Checked=r["ten"].ToString().Trim()=="1";
						break;
					case 5: c05.Checked=(ttb.Thongso("c05")=="1")?true:false;
						break;
					case 7: c07.Text=r["ten"].ToString();
						break;
					case 8: c08.Text=r["ten"].ToString();
						break;
					case 9: c09.Text=r["ten"].ToString();
						break;
					case 10: c10.Value=decimal.Parse(ttb.Thongso("c10"));
						break;
					case 11: c11.Checked=(ttb.Thongso("c11")=="1")?true:false;
						break;
					case 12: c12.Checked=(ttb.Thongso("c12")=="1")?true:false;
						break;
					case 15: c15.Text=r["ten"].ToString();
						break;
					case 16: c16.Text=r["ten"].ToString();
						break;
					case 22: c22.Value=decimal.Parse(ttb.Thongso("c22"));
						break;
					case 23: c23.Checked=(ttb.Thongso("c23")=="1")?true:false;
						break;
					case 24: c24.Checked=(ttb.Thongso("c24")=="1")?true:false;
						break;
					case 25: c25.Checked=(ttb.Thongso("c25")=="1")?true:false;
						break;
					case 26: c26.Checked=(ttb.Thongso("c26")=="1")?true:false;
						break;
					case 27: c27.Checked=(ttb.Thongso("c27")=="1")?true:false;
						break;
					case 28: c28.Checked=(ttb.Thongso("c28")=="1")?true:false;
						break;
					case 29: c29.Checked=(ttb.Thongso("c29")=="1")?true:false;
						break;
					case 30: c30.Checked=(ttb.Thongso("c30")=="1")?true:false;
						break;
					case 31: c31.Checked=(ttb.Thongso("c31")=="1")?true:false;
						break;
					case 32: c32.Text=r["ten"].ToString();
						break;
					case 34: c34.Checked=(ttb.Thongso("c34")=="1")?true:false;
						break;
					case 35: c35.Checked=(ttb.Thongso("c35")=="1")?true:false;
						break;
					case 36: c36.Checked=(ttb.Thongso("c36")=="1")?true:false;
						break;
					case 37: c37.Checked=(ttb.Thongso("c37")=="1")?true:false;
						break;
					case 38: c38.Checked=(ttb.Thongso("c38")=="1")?true:false;
						break;
					case 39: c39.Checked=(ttb.Thongso("c39")=="1")?true:false;
						break;
					case 40: c40.Checked=(ttb.Thongso("c40")=="1")?true:false;
						break;
					case 41: c41.Checked=(ttb.Thongso("c41")=="1")?true:false;
						break;
					case 45: c45.Checked=(r["ten"].ToString().Trim()=="1");
						break;
					case 47: c47.Text=r["ten"].ToString();
						break;
					case 48: c48.Text=r["ten"].ToString();
						break;
					case 49: c49.Text=r["ten"].ToString();
						break;
					case 50: c50.Text=r["ten"].ToString();
						break;
					case 51: c51.Text=r["ten"].ToString();
						break;
					case 52: c52.Text=r["ten"].ToString();
						break;
					case 53: c53.Text=r["ten"].ToString();
						break;
					case 56: c56.Text=r["ten"].ToString();//ten thu muc report
						break;
					case 57: c57.Text=r["ten"].ToString();//ten thu muc report
						break;
					case 58: c58.Text=r["ten"].ToString();//ten thu muc report
						break;
					case 59: c59.Text=r["ten"].ToString();//ten thu muc report
						break;
					case 62: c62.Checked=(r["ten"].ToString().Trim()=="1");
						break;
					case 70: c70.Checked=(r["ten"].ToString().Trim()=="1");
						break;
					case 79: c79.Text=r["ten"].ToString();
						break;
					case 83: c83.Text=r["ten"].ToString();
						break;
					case 84: c84.Text=r["ten"].ToString();
						break;
					case 94: c94.Checked=(r["ten"].ToString().Trim()=="1");
						break;
					case 95: c95.Checked=ttb.Thongso("c95")=="1";
						break;
					case 96: c96.Checked=ttb.Thongso("c96")=="1";
						break;
					case 97: c97.Checked=ttb.Thongso("c97")=="1";
						break;
					case 105: c105.Value=decimal.Parse(r["ten"].ToString());
						break;
					case 106: c106.Checked=(r["ten"].ToString().Trim()=="1");
						break;
					case 116: c116.Checked=(r["ten"].ToString().Trim()=="1");
						break;
					case 120: c120.Text=r["ten"].ToString();
						break;
					case 121: c121.Text=r["ten"].ToString();
						break;
				}
			}
			if (c105.Value==0) c105.Value=7;
			if (c52.Text=="0") c52.Text=ttb.ma13_vitri.ToString();
			if (c53.Text=="0") c53.Text=ttb.ma16_vitri.ToString();
			c13.Checked=ttb.bKhoaso(i_nhom,s_mmyy);
			if (c13.Checked) c13.ForeColor=Color.Red;
            ma13.Text = ttb.get_data("select ten from " + user + ".thongso where id=49").Tables[0].Rows[0][0].ToString();
            ma16.Text = ttb.get_data("select ten from " + user + ".thongso where id=50").Tables[0].Rows[0][0].ToString();
			kho.Text=ttb.Thongso("kho").Trim();
			hinh.Text=ttb.Thongso("hinh").Trim();
			butHinh.Enabled=hinh.Text.ToString()=="";
			if (c83.Text=="0") c83.Text="50";
			if (c84.Text=="0") c84.Text="3,2";
            foreach (System.Windows.Forms.Control t in this.tab.Controls)
            {
                foreach (System.Windows.Forms.Control c in t.Controls)
                {
                    try
                    {
                        CheckBox chk = (CheckBox)c;
                        if (chk.Checked) chk.ForeColor = Color.Red;
                    }
                    catch { }
                }
            }
		}

		private void butOK_Click(object sender, System.EventArgs e)
		{
			//if (!c40.Checked) c24.Checked=true;
			int itable = ttb.tableid("","ttb_thongso");
            foreach (DataRow r in ttb.get_data("select * from " + user + ".ttb_thongso where nhom=" + i_nhom + " order by id").Tables[0].Rows)
			{
				ttb.upd_eve_tables(itable, i_userid, "upd");
				ttb.upd_eve_upd_del(itable, i_userid, "upd",ttb.fields(user+".ttb_thongso","nhom="+i_nhom+" and id="+decimal.Parse(r["id"].ToString())));
			}
			dstt.WriteXml("..\\..\\..\\xml\\ttb_sttphieulinh.xml",XmlWriteMode.WriteSchema);
			dsmua.WriteXml("..\\..\\..\\xml\\ttb_sttmua.xml",XmlWriteMode.WriteSchema);
			ttb.upd_thongso(49,"ten",ma13.Text);
			ttb.upd_thongso(50,"ten",ma16.Text);
			ttb.upd_thongso(i_nhom,4,"don gia",(c04.Checked)?"1":"0");
			ttb.upd_thongso(i_nhom,45,"qui doi",(c45.Checked)?"1":"0");
			ttb.upd_thongso(i_nhom,47,"cong kham",c47.Text.ToString());
			ttb.upd_thongso(i_nhom,48,"ma 13-ngtru",c48.Text.ToString());
			ttb.upd_thongso(i_nhom,49,"ma 16-ngtru",c49.Text.ToString());
			ttb.upd_thongso(i_nhom,50,"ma 13-sotien",c50.Text.ToString());
			ttb.upd_thongso(i_nhom,51,"ma 16-sotien",c51.Text.ToString());
			ttb.upd_thongso(i_nhom,52,"ma 16-vitri",c52.Text.ToString());
			ttb.upd_thongso(i_nhom,53,"ma 16-vitri",c53.Text.ToString());
			ttb.upd_thongso(i_nhom,62,"mabn->bhyt",(c62.Checked)?"1":"0");
			ttb.upd_thongso(i_nhom,70,"bhyt",(c70.Checked)?"1":"0");
			ttb.upd_thongso(i_nhom,94,"chan doan trong xuat ban",(c94.Checked)?"1":"0");
            foreach (DataRow r in ttb.get_data("select id from " + user + ".ttb_dmnhomkho order by id").Tables[0].Rows)
			{
				ttb.upd_thongso(int.Parse(r["id"].ToString()),105,"ngay kiem ke",c105.Value.ToString());
				ttb.upd_thongso(int.Parse(r["id"].ToString()),83,"the trong tinh",c83.Text.ToString());
				ttb.upd_thongso(int.Parse(r["id"].ToString()),84,"vitri the tinh",c84.Text.ToString());
				ttb.upd_thongso(int.Parse(r["id"].ToString()),120,"tu nguyen",c120.Text.ToString());
				ttb.upd_thongso(int.Parse(r["id"].ToString()),121,"vitri the tinh",c121.Text.ToString());
			}
			ttb.upd_thongso(i_nhom,106,"bb bac sy xuat ban",(c106.Checked)?"1":"0");
			ttb.upd_thongso(i_nhom,112,"domain",c112.Text);
			ttb.upd_thongso(i_nhom,116,"nha cung cap",(c116.Checked)?"1":"0");
            ttb.execute_data("update " + user + ".ttb_thongso set ten='" + c52.Text.ToString() + "' where id=52");
            ttb.execute_data("update " + user + ".ttb_thongso set ten='" + c53.Text.ToString() + "' where id=53");
			ttb.upd_thongso(i_nhom,79,"So le - Don gia",(c79.Text=="")?"2":c79.Text);//Lay so le trong gia ban
			ttb.upd_thongso(i_nhom,7,"",c07.Text.Trim());
			ttb.upd_thongso(i_nhom,8,"",c08.Text.Trim());
			ttb.upd_thongso(i_nhom,9,"",c09.Text.Trim());
			ttb.upd_thongso(i_nhom,15,"",c15.Text.Trim());
			ttb.upd_thongso(i_nhom,16,"",c16.Text.Trim());
			ttb.upd_thongso(i_nhom,32,"",c32.Text.Trim());
			ds.Tables[0].Rows[0]["c02"]=(c02.Checked)?"1":"0";
			ds.Tables[0].Rows[0]["c05"]=(c05.Checked)?"1":"0";
			ds.Tables[0].Rows[0]["c10"]=c10.Value.ToString();
			ds.Tables[0].Rows[0]["c11"]=(c11.Checked)?"1":"0";
			ds.Tables[0].Rows[0]["c12"]=(c12.Checked)?"1":"0";
			ds.Tables[0].Rows[0]["c22"]=c22.Value.ToString();
			ds.Tables[0].Rows[0]["c23"]=(c23.Checked)?"1":"0";
			ds.Tables[0].Rows[0]["c24"]=(c24.Checked)?"1":"0";
			ds.Tables[0].Rows[0]["c25"]=(c25.Checked)?"1":"0";
			ds.Tables[0].Rows[0]["c26"]=(c26.Checked)?"1":"0";
			ds.Tables[0].Rows[0]["c27"]=(c27.Checked)?"1":"0";
			ds.Tables[0].Rows[0]["c28"]=(c28.Checked)?"1":"0";
			ds.Tables[0].Rows[0]["c29"]=(c29.Checked)?"1":"0";
			ds.Tables[0].Rows[0]["c30"]=(c30.Checked)?"1":"0";
			ds.Tables[0].Rows[0]["c31"]=(c31.Checked)?"1":"0";
			ds.Tables[0].Rows[0]["c07"]=c07.Text.Trim();
			ds.Tables[0].Rows[0]["c08"]=c08.Text.Trim();
			ds.Tables[0].Rows[0]["c09"]=c09.Text.Trim();
			ds.Tables[0].Rows[0]["c15"]=c15.Text.Trim();
			ds.Tables[0].Rows[0]["c16"]=c16.Text.Trim();
			ds.Tables[0].Rows[0]["c32"]=c32.Text.Trim();
			ds.Tables[0].Rows[0]["c34"]=(c34.Checked)?"1":"0";
			ds.Tables[0].Rows[0]["c35"]=(c35.Checked)?"1":"0";
			ds.Tables[0].Rows[0]["c36"]=(c36.Checked)?"1":"0";
			ds.Tables[0].Rows[0]["c37"]=(c37.Checked)?"1":"0";
			ds.Tables[0].Rows[0]["c38"]=(c38.Checked)?"1":"0";
			ds.Tables[0].Rows[0]["c39"]=(c39.Checked)?"1":"0";
			ds.Tables[0].Rows[0]["c40"]=(c40.Checked)?"1":"0";
			ds.Tables[0].Rows[0]["c41"]=(c41.Checked)?"1":"0";
			ds.Tables[0].Rows[0]["c95"]=(c95.Checked)?"1":"0";
			ds.Tables[0].Rows[0]["c96"]=(c96.Checked)?"1":"0";
			ds.Tables[0].Rows[0]["c97"]=(c97.Checked)?"1":"0";
			ds.Tables[0].Rows[0]["kho"]=kho.Text.Trim();
			ds.Tables[0].Rows[0]["hinh"]=hinh.Text.Trim();
			//binh
			ttb.upd_thongso(i_nhom,56,"Thu muc report",(c56.Text=="")?"report":c56.Text);//phan biet thuoc noi, ngoai theo hang san xuat
			ttb.upd_thongso(i_nhom,57,"So le - So luong",(c57.Text=="")?"2":c57.Text);//Lay so le trong so luong
			ttb.upd_thongso(i_nhom,58,"So le - Don gia",(c58.Text=="")?"2":c58.Text);//Lay so le trong don gia
			ttb.upd_thongso(i_nhom,59,"So le - T.Tien",(c59.Text=="")?"2":c59.Text);//lay so lr trong thanh tien
			//
			ds.WriteXml("..\\..\\..\\xml\\ttb_thongso.xml");
			if (c13.Checked) ttb.upd_khoaso(i_nhom,s_mmyy,i_userid);
            else if (ttb.bKhoaso(i_nhom, s_mmyy)) ttb.execute_data("delete from " + user + ".ttb_khoaso where nhom=" + i_nhom + " and mmyy='" + s_mmyy + "'");
			butKetthuc.Focus();
		}

		private void butKetthuc_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void c02_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");
		}

		private void butHinh_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog of = new OpenFileDialog();
			of.Title = "Chọn hình hệ thống";
			of.Filter = "Files (*.jpg)|*.jpg|All Files (*.*)|*.*";
			of.RestoreDirectory=true;
			of.InitialDirectory = "..\\..\\..\\Picture";
			if (of.ShowDialog() == DialogResult.OK)	 hinh.Text=of.FileName;
		}

		private void AddGridTableStyle()
		{
			DataGridColoredTextBoxColumn TextCol1;
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
			ts.MappingName = dstt.Tables[0].TableName;
			ts.AllowSorting=false;
			
			TextCol1=new DataGridColoredTextBoxColumn(de, 0);
			TextCol1.MappingName = "stt";
			TextCol1.HeaderText = "Thứ tự";
			TextCol1.Width = 40;
			ts.GridColumnStyles.Add(TextCol1);
			dataGrid1.TableStyles.Add(ts);

			TextCol1=new DataGridColoredTextBoxColumn(de, 1);
			TextCol1.MappingName = "ten";
			TextCol1.HeaderText = "Nội dung";
			TextCol1.Width = 145;
			TextCol1.ReadOnly=true;
			ts.GridColumnStyles.Add(TextCol1);
			dataGrid1.TableStyles.Add(ts);
		}

		public Color MyGetColorRowCol(int row, int col)
		{
			return Color.Black;
		}

		private void c39_CheckedChanged(object sender, System.EventArgs e)
		{
			c106.Enabled=c39.Checked;
			if (!c39.Checked) c106.Checked=false;
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
				}
			
				catch{}
				finally
				{
					base.Paint(g, bounds, source, rowNum, backBrush, foreBrush, alignToRight);
				}
			}
		}

		private void AddGridTableStyle2()
		{
			DataGridColoredTextBoxColumn TextCol1;
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
			ts.MappingName = dsmua.Tables[0].TableName;
			ts.AllowSorting=false;
			
			TextCol1=new DataGridColoredTextBoxColumn(de, 0);
			TextCol1.MappingName = "stt";
			TextCol1.HeaderText = "Thứ tự";
			TextCol1.Width = 40;
			ts.GridColumnStyles.Add(TextCol1);
			dataGrid2.TableStyles.Add(ts);

			TextCol1=new DataGridColoredTextBoxColumn(de, 1);
			TextCol1.MappingName = "ten";
			TextCol1.HeaderText = "Nội dung";
			TextCol1.Width = 145;
			TextCol1.ReadOnly=true;
			ts.GridColumnStyles.Add(TextCol1);
			dataGrid2.TableStyles.Add(ts);
		}
	}
}
