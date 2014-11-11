using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Reflection;
using System.Runtime.InteropServices;
using LibTTB;
using doiso;
using Excel;

namespace TTB
{
	/// <summary>
	/// Summary description for rptBbthanhly.
	/// </summary>
	public class rptBbthanhly : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker tu;
		private System.Windows.Forms.Button butIn;
		private System.Windows.Forms.Button butKetthuc;
		private System.Windows.Forms.DateTimePicker den;
		private decimal tongcong;
        private LibTTB.AccessData ttb;
		private int i_nhom,i_rec;
		private string sql,ngay,tenfile,s_kho,user,stime,xxx;
		private DataRow r1,r2,r3;
		private DataRow []dr;
		private DataSet ds;
		private Doisototext doiso=new Doisototext();
		private DataSet dsxml=new DataSet();
		private System.Data.DataTable dt=new System.Data.DataTable();
		private System.Data.DataTable dtkho=new System.Data.DataTable();
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
		private Medisoft2009.Usercontrol.MaskedTextBox c108;
		private Medisoft2009.Usercontrol.MaskedTextBox c107;
		private Medisoft2009.Usercontrol.MaskedTextBox c106;
		private Medisoft2009.Usercontrol.MaskedTextBox c105;
		private Medisoft2009.Usercontrol.MaskedTextBox c104;
		private Medisoft2009.Usercontrol.MaskedTextBox c103;
		private Medisoft2009.Usercontrol.MaskedTextBox c102;
		private Medisoft2009.Usercontrol.MaskedTextBox c101;
		private Medisoft2009.Usercontrol.MaskedTextBox c109;
		private Medisoft2009.Usercontrol.MaskedTextBox c9;
		private System.Windows.Forms.Label label3;
		private Medisoft2009.Usercontrol.MaskedTextBox c110;
		private Medisoft2009.Usercontrol.MaskedTextBox c10;
		private System.Windows.Forms.Label label12;
		private Medisoft2009.Usercontrol.MaskedTextBox c111;
		private Medisoft2009.Usercontrol.MaskedTextBox c11;
		private System.Windows.Forms.Label label13;
		private Medisoft2009.Usercontrol.MaskedTextBox c112;
		private Medisoft2009.Usercontrol.MaskedTextBox c12;
		private System.Windows.Forms.Label label14;
		private DataColumn dc;
		Excel.Application oxl;
		Excel._Workbook owb;
		Excel._Worksheet osheet;
		Excel.Range orange;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public rptBbthanhly(AccessData acc,int nhom,string kho)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			ttb=acc;
			i_nhom=nhom;
			s_kho=kho;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptBbthanhly));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tu = new System.Windows.Forms.DateTimePicker();
            this.den = new System.Windows.Forms.DateTimePicker();
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
            this.c108 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c107 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c106 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c105 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c104 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c103 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c102 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c101 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c109 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c9 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.c110 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c10 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.c111 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c11 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.c112 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.c12 = new Medisoft2009.Usercontrol.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
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
            this.label2.TabIndex = 1;
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
            this.tu.TabIndex = 0;
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
            this.den.TabIndex = 1;
            this.den.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // butIn
            // 
            this.butIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butIn.Location = new System.Drawing.Point(188, 330);
            this.butIn.Name = "butIn";
            this.butIn.Size = new System.Drawing.Size(60, 25);
            this.butIn.TabIndex = 26;
            this.butIn.Text = "&In";
            this.butIn.Click += new System.EventHandler(this.butIn_Click);
            // 
            // butKetthuc
            // 
            this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butKetthuc.Location = new System.Drawing.Point(250, 330);
            this.butKetthuc.Name = "butKetthuc";
            this.butKetthuc.Size = new System.Drawing.Size(60, 25);
            this.butKetthuc.TabIndex = 27;
            this.butKetthuc.Text = "&Kết thúc";
            this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
            // 
            // c1
            // 
            this.c1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1.Location = new System.Drawing.Point(52, 35);
            this.c1.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(192, 21);
            this.c1.TabIndex = 2;
            // 
            // c2
            // 
            this.c2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c2.Location = new System.Drawing.Point(52, 59);
            this.c2.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(192, 21);
            this.c2.TabIndex = 4;
            // 
            // c3
            // 
            this.c3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c3.Location = new System.Drawing.Point(52, 83);
            this.c3.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(192, 21);
            this.c3.TabIndex = 6;
            // 
            // c4
            // 
            this.c4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c4.Location = new System.Drawing.Point(52, 107);
            this.c4.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(192, 21);
            this.c4.TabIndex = 8;
            // 
            // c5
            // 
            this.c5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c5.Location = new System.Drawing.Point(52, 131);
            this.c5.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c5.Name = "c5";
            this.c5.Size = new System.Drawing.Size(192, 21);
            this.c5.TabIndex = 10;
            // 
            // c6
            // 
            this.c6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c6.Location = new System.Drawing.Point(52, 155);
            this.c6.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c6.Name = "c6";
            this.c6.Size = new System.Drawing.Size(192, 21);
            this.c6.TabIndex = 12;
            // 
            // c7
            // 
            this.c7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c7.Location = new System.Drawing.Point(52, 179);
            this.c7.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c7.Name = "c7";
            this.c7.Size = new System.Drawing.Size(192, 21);
            this.c7.TabIndex = 14;
            // 
            // c8
            // 
            this.c8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c8.Location = new System.Drawing.Point(52, 203);
            this.c8.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c8.Name = "c8";
            this.c8.Size = new System.Drawing.Size(192, 21);
            this.c8.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(-4, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "1. ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(-4, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "2. ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(-4, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "3. ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(-4, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "4. ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(-4, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "5. ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(-4, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "6. ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(-4, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "7. ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(-4, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 23);
            this.label11.TabIndex = 20;
            this.label11.Text = "8. ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // c108
            // 
            this.c108.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c108.Location = new System.Drawing.Point(246, 202);
            this.c108.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c108.Name = "c108";
            this.c108.Size = new System.Drawing.Size(234, 21);
            this.c108.TabIndex = 17;
            this.c108.Text = "Thủ kho - Ủy viên";
            // 
            // c107
            // 
            this.c107.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c107.Location = new System.Drawing.Point(246, 178);
            this.c107.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c107.Name = "c107";
            this.c107.Size = new System.Drawing.Size(234, 21);
            this.c107.TabIndex = 15;
            this.c107.Text = "Thủ kho - Ủy viên";
            // 
            // c106
            // 
            this.c106.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c106.Location = new System.Drawing.Point(246, 154);
            this.c106.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c106.Name = "c106";
            this.c106.Size = new System.Drawing.Size(234, 21);
            this.c106.TabIndex = 13;
            this.c106.Text = "Kế toán - Ủy viên";
            // 
            // c105
            // 
            this.c105.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c105.Location = new System.Drawing.Point(246, 130);
            this.c105.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c105.Name = "c105";
            this.c105.Size = new System.Drawing.Size(234, 21);
            this.c105.TabIndex = 11;
            this.c105.Text = "Phụ trách phỏng TCKT - Ủy viên";
            // 
            // c104
            // 
            this.c104.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c104.Location = new System.Drawing.Point(246, 106);
            this.c104.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c104.Name = "c104";
            this.c104.Size = new System.Drawing.Size(234, 21);
            this.c104.TabIndex = 9;
            this.c104.Text = "Phụ trách khoa dược - Ủy viên";
            // 
            // c103
            // 
            this.c103.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c103.Location = new System.Drawing.Point(246, 82);
            this.c103.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c103.Name = "c103";
            this.c103.Size = new System.Drawing.Size(234, 21);
            this.c103.TabIndex = 7;
            this.c103.Text = "Phó CN kho - Phụ trách kho - Ủy viên";
            // 
            // c102
            // 
            this.c102.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c102.Location = new System.Drawing.Point(246, 58);
            this.c102.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c102.Name = "c102";
            this.c102.Size = new System.Drawing.Size(234, 21);
            this.c102.TabIndex = 5;
            this.c102.Text = "Trưởng phòng KHTH - Ủy viên";
            // 
            // c101
            // 
            this.c101.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c101.Location = new System.Drawing.Point(246, 34);
            this.c101.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c101.Name = "c101";
            this.c101.Size = new System.Drawing.Size(234, 21);
            this.c101.TabIndex = 3;
            this.c101.Text = "Chủ tịch hội đồng";
            // 
            // c109
            // 
            this.c109.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c109.Location = new System.Drawing.Point(246, 226);
            this.c109.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c109.Name = "c109";
            this.c109.Size = new System.Drawing.Size(234, 21);
            this.c109.TabIndex = 19;
            this.c109.Text = "Thủ kho - Ủy viên";
            // 
            // c9
            // 
            this.c9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c9.Location = new System.Drawing.Point(52, 227);
            this.c9.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c9.Name = "c9";
            this.c9.Size = new System.Drawing.Size(192, 21);
            this.c9.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(-4, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "9. ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // c110
            // 
            this.c110.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c110.Location = new System.Drawing.Point(246, 250);
            this.c110.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c110.Name = "c110";
            this.c110.Size = new System.Drawing.Size(234, 21);
            this.c110.TabIndex = 21;
            this.c110.Text = "Thủ kho - Ủy viên";
            // 
            // c10
            // 
            this.c10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c10.Location = new System.Drawing.Point(52, 251);
            this.c10.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c10.Name = "c10";
            this.c10.Size = new System.Drawing.Size(192, 21);
            this.c10.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(-4, 249);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 23);
            this.label12.TabIndex = 27;
            this.label12.Text = "10. ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // c111
            // 
            this.c111.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c111.Location = new System.Drawing.Point(246, 274);
            this.c111.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c111.Name = "c111";
            this.c111.Size = new System.Drawing.Size(234, 21);
            this.c111.TabIndex = 23;
            this.c111.Text = "Thủ kho - Ủy viên";
            // 
            // c11
            // 
            this.c11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c11.Location = new System.Drawing.Point(52, 275);
            this.c11.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c11.Name = "c11";
            this.c11.Size = new System.Drawing.Size(192, 21);
            this.c11.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(-4, 273);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 23);
            this.label13.TabIndex = 30;
            this.label13.Text = "11. ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // c112
            // 
            this.c112.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c112.Location = new System.Drawing.Point(246, 298);
            this.c112.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c112.Name = "c112";
            this.c112.Size = new System.Drawing.Size(234, 21);
            this.c112.TabIndex = 25;
            this.c112.Text = "Thủ kho - Ủy viên";
            // 
            // c12
            // 
            this.c12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c12.Location = new System.Drawing.Point(52, 299);
            this.c12.Masked = Medisoft2009.Usercontrol.MaskedTextBox.Mask.None;
            this.c12.Name = "c12";
            this.c12.Size = new System.Drawing.Size(192, 21);
            this.c12.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(-4, 297);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 23);
            this.label14.TabIndex = 33;
            this.label14.Text = "12. ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rptBbthanhly
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(498, 375);
            this.Controls.Add(this.c112);
            this.Controls.Add(this.c12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.c111);
            this.Controls.Add(this.c11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.c110);
            this.Controls.Add(this.c10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.c109);
            this.Controls.Add(this.c9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.c108);
            this.Controls.Add(this.c107);
            this.Controls.Add(this.c106);
            this.Controls.Add(this.c105);
            this.Controls.Add(this.c104);
            this.Controls.Add(this.c103);
            this.Controls.Add(this.c102);
            this.Controls.Add(this.c101);
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
            this.Controls.Add(this.den);
            this.Controls.Add(this.tu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rptBbthanhly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biên bản thanh lý";
            this.Load += new System.EventHandler(this.rptBbthanhly_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void rptBbthanhly_Load(object sender, System.EventArgs e)
		{
            user = ttb.user; stime = "'" + ttb.f_ngay + "'";
			sql="select * from "+user+".ttb_dmkho where nhom="+i_nhom;
			if (s_kho!="") sql+=" and id in ("+s_kho.Substring(0,s_kho.Length-1)+")";
			sql+=" order by stt";
			dtkho=ttb.get_data(sql).Tables[0];
            dt = ttb.get_data("select a.*,b.ten as tennuoc from " + user + ".ttb_dmbd a," + user + ".ttb_dmnuoc b where a.manuoc=b.id and a.nhom=" + i_nhom + " order by a.id").Tables[0];
			dsxml.ReadXml("..\\..\\..\\xml\\ttb_tsthanhly.xml");
			c1.Text=dsxml.Tables[0].Rows[0]["c01"].ToString();
			c2.Text=dsxml.Tables[0].Rows[0]["c02"].ToString();
			c3.Text=dsxml.Tables[0].Rows[0]["c03"].ToString();
			c4.Text=dsxml.Tables[0].Rows[0]["c04"].ToString();
			c5.Text=dsxml.Tables[0].Rows[0]["c05"].ToString();
			c6.Text=dsxml.Tables[0].Rows[0]["c06"].ToString();
			c7.Text=dsxml.Tables[0].Rows[0]["c07"].ToString();
			c8.Text=dsxml.Tables[0].Rows[0]["c08"].ToString();
			c9.Text=dsxml.Tables[0].Rows[0]["c09"].ToString();
			c10.Text=dsxml.Tables[0].Rows[0]["c10"].ToString();
			c11.Text=dsxml.Tables[0].Rows[0]["c11"].ToString();
			c12.Text=dsxml.Tables[0].Rows[0]["c12"].ToString();
			c101.Text=dsxml.Tables[0].Rows[0]["c101"].ToString();
			c102.Text=dsxml.Tables[0].Rows[0]["c102"].ToString();
			c103.Text=dsxml.Tables[0].Rows[0]["c103"].ToString();
			c104.Text=dsxml.Tables[0].Rows[0]["c104"].ToString();
			c105.Text=dsxml.Tables[0].Rows[0]["c105"].ToString();
			c106.Text=dsxml.Tables[0].Rows[0]["c106"].ToString();
			c107.Text=dsxml.Tables[0].Rows[0]["c107"].ToString();
			c108.Text=dsxml.Tables[0].Rows[0]["c108"].ToString();
			c109.Text=dsxml.Tables[0].Rows[0]["c109"].ToString();
			c110.Text=dsxml.Tables[0].Rows[0]["c110"].ToString();
			c111.Text=dsxml.Tables[0].Rows[0]["c111"].ToString();
			c112.Text=dsxml.Tables[0].Rows[0]["c112"].ToString();
		}

		private void butIn_Click(object sender, System.EventArgs e)
		{
			Tao_dataset();
			tongcong=0;
			DateTime dt1=ttb.StringToDate(tu.Text).AddDays(-ttb.iNgaykiemke);
			DateTime dt2=ttb.StringToDate(den.Text).AddDays(ttb.iNgaykiemke);
			int y1=dt1.Year,m1=dt1.Month;
			int y2=dt2.Year,m2=dt2.Month;
			int itu,iden;
			string mmyy="";					
			for(int i=y1;i<=y2;i++)
			{
				itu=(i==y1)?m1:1;
				iden=(i==y2)?m2:12;
				for(int j=itu;j<=iden;j++)
				{
					mmyy=j.ToString().PadLeft(2,'0')+i.ToString().Substring(2,2);
					if (ttb.bMmyy(mmyy))
					{
						get_data(mmyy);
					}
				}
			}
			if (ds.Tables[0].Rows.Count==0)
			{
				MessageBox.Show("Không có số liệu !",ttb.Msg);
				return;
			}
			ngay=(tu.Text==den.Text)?"Ngày "+tu.Text:"Từ ngày "+tu.Text+" đến "+den.Text;
			exp_excel();
		}

		private void butKetthuc_Click(object sender, System.EventArgs e)
		{
			ttb.writeXml("ttb_tsthanhly","c01",c1.Text);
			ttb.writeXml("ttb_tsthanhly","c02",c2.Text);
			ttb.writeXml("ttb_tsthanhly","c03",c3.Text);
			ttb.writeXml("ttb_tsthanhly","c04",c4.Text);
			ttb.writeXml("ttb_tsthanhly","c05",c5.Text);
			ttb.writeXml("ttb_tsthanhly","c06",c6.Text);
			ttb.writeXml("ttb_tsthanhly","c07",c7.Text);
			ttb.writeXml("ttb_tsthanhly","c08",c8.Text);
			ttb.writeXml("ttb_tsthanhly","c09",c9.Text);
			ttb.writeXml("ttb_tsthanhly","c10",c10.Text);
			ttb.writeXml("ttb_tsthanhly","c11",c11.Text);
			ttb.writeXml("ttb_tsthanhly","c12",c12.Text);
			ttb.writeXml("ttb_tsthanhly","c101",c101.Text);
			ttb.writeXml("ttb_tsthanhly","c102",c102.Text);
			ttb.writeXml("ttb_tsthanhly","c103",c103.Text);
			ttb.writeXml("ttb_tsthanhly","c104",c104.Text);
			ttb.writeXml("ttb_tsthanhly","c105",c105.Text);
			ttb.writeXml("ttb_tsthanhly","c106",c106.Text);
			ttb.writeXml("ttb_tsthanhly","c107",c107.Text);
			ttb.writeXml("ttb_tsthanhly","c108",c108.Text);
			ttb.writeXml("ttb_tsthanhly","c109",c109.Text);
			ttb.writeXml("ttb_tsthanhly","c110",c110.Text);
			ttb.writeXml("ttb_tsthanhly","c111",c111.Text);
			ttb.writeXml("ttb_tsthanhly","c112",c112.Text);
			this.Close();
		}

		private void tu_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");
		}

		private void Tao_dataset()
		{
			ds=new DataSet();
			ds.ReadXml("..\\..\\..\\xml\\ttb_Bbthanhly.xml");
			foreach(DataRow r in dtkho.Rows)
			{
				dc=new DataColumn();
				dc.ColumnName="SOLUONG_"+r["id"].ToString().Trim();
				dc.DataType=Type.GetType("System.Decimal");
				ds.Tables[0].Columns.Add(dc);
			}
			dc=new DataColumn();
			dc.ColumnName="TONGCONG";
			dc.DataType=Type.GetType("System.Decimal");
			ds.Tables[0].Columns.Add(dc);
			dc=new DataColumn();
			dc=new DataColumn();
			dc.ColumnName="DONGIA";
			dc.DataType=Type.GetType("System.Decimal");
			ds.Tables[0].Columns.Add(dc);
			dc=new DataColumn();
			dc.ColumnName="SOTIEN";
			dc.DataType=Type.GetType("System.Decimal");
			ds.Tables[0].Columns.Add(dc);
			dc=new DataColumn();
			dc.ColumnName="LYDO";
			dc.DataType=Type.GetType("System.String");
			ds.Tables[0].Columns.Add(dc);
		}

		private void get_data(string d_mmyy)
		{
            xxx = user;// +d_mmyy;
			sql="select a.khox,b.mabd,b.soluong,b.soluong*t.giamua as sotien,t.handung,a.lydo,t.giamua as dongia from "+xxx+".ttb_xuatll a,"+xxx+".ttb_xuatct b,"+user+".ttb_dmbd c,"+xxx+".ttb_theodoi t ";
			sql+="where a.id=b.id and b.sttt=t.id and b.mabd=c.id and a.loai='XK' and a.khon in (1,2) and a.ngay between to_date('"+tu.Text+"',"+stime+") and to_date('"+den.Text+"',"+stime+")";
			if (s_kho!="") sql+=" and a.khox in ("+s_kho.Substring(0,s_kho.Length-1)+")";
            sql += " and a.mmyy='" + d_mmyy + "' order by c.ten";
			foreach(DataRow r in ttb.get_data(sql).Tables[0].Rows)
			{
				r1=ttb.getrowbyid(ds.Tables[0],"mabd="+int.Parse(r["mabd"].ToString())+" and handung='"+r["handung"].ToString()+"' and dongia="+decimal.Parse(r["dongia"].ToString()));
				if ( r1 == null )
				{
					r3=ttb.getrowbyid(dt,"id="+int.Parse(r["mabd"].ToString()));
					if (r3!=null)
					{
						r2 = ds.Tables[0].NewRow();
						r2["mabd"]=r["mabd"].ToString();
						r2["ma"]=r3["ma"].ToString();
						r2["stt"]=ttb.get_stt(ds.Tables[0]);
						r2["ten"]=r3["ten"].ToString().Trim()+" "+r3["hamluong"].ToString();
						r2["tennuoc"]=r3["tennuoc"].ToString();
						r2["dang"]=r3["dang"].ToString();
						r2["handung"]=r["handung"].ToString();
                        r2["dongia"]=r["dongia"].ToString();
						foreach(DataRow r4 in dtkho.Rows) r2["soluong_"+r4["id"].ToString().Trim()]=0;
						r2["soluong_"+r["khox"].ToString().Trim()]=r["soluong"].ToString();
						r2["tongcong"]=r["soluong"].ToString();
						r2["sotien"]=r["sotien"].ToString();
						if (r["lydo"].ToString()!="") r2["lydo"]=r["lydo"].ToString();
						ds.Tables[0].Rows.Add(r2);
					}
				}
				else
				{
                    dr = ds.Tables[0].Select("mabd=" + int.Parse(r["mabd"].ToString()) + " and handung='" + r["handung"].ToString() + "' and dongia=" + decimal.Parse(r["dongia"].ToString()));
                    if (dr.Length > 0)
                    {
                        dr[0]["soluong_" + r["khox"].ToString().Trim()] = decimal.Parse(dr[0]["soluong_" + r["khox"].ToString().Trim()].ToString()) + decimal.Parse(r["soluong"].ToString());
                        dr[0]["tongcong"] = decimal.Parse(dr[0]["tongcong"].ToString()) + decimal.Parse(r["soluong"].ToString());
                        dr[0]["sotien"] = decimal.Parse(dr[0]["sotien"].ToString()) + decimal.Parse(r["sotien"].ToString());
                    }
				}
				tongcong+=decimal.Parse(r["sotien"].ToString());
			}
		}

		private void exp_excel()
		{
			try
			{
				int be=21,dong=23,sodong=ds.Tables[0].Rows.Count+24,socot=ds.Tables[0].Columns.Count-2,dongke=sodong-1;
				tenfile=ttb.Export_Excel(ds,"bbthanhly");
				oxl=new Excel.Application();
				owb=(Excel._Workbook)(oxl.Workbooks.Open(tenfile,Missing.Value,Missing.Value,Missing.Value,Missing.Value,Missing.Value,Missing.Value,Missing.Value,Missing.Value,Missing.Value,Missing.Value,Missing.Value,Missing.Value));
				osheet=(Excel._Worksheet)owb.ActiveSheet;
				oxl.ActiveWindow.DisplayGridlines=true;
				osheet.get_Range(ttb.getIndex(0)+"1",ttb.getIndex(1)+"1").EntireColumn.Delete(Missing.Value);
				for(int i=0;i<be;i++) osheet.get_Range(ttb.getIndex(i)+"1",ttb.getIndex(i)+"1").EntireRow.Insert(Missing.Value);
				osheet.get_Range(ttb.getIndex(5)+dong.ToString(),ttb.getIndex(socot)+sodong.ToString()).NumberFormat="#,##0.00";
				osheet.get_Range(ttb.getIndex(0)+"21",ttb.getIndex(socot-1)+dongke.ToString()).Borders.LineStyle=XlBorderWeight.xlHairline;
				for(int i=1;i<6;i++)
				{
					osheet.Cells[dong-1,i]=get_title(i-1);
					orange=osheet.get_Range(ttb.getIndex(i-1)+"21",ttb.getIndex(i-1)+"22");
					orange.MergeCells=true;
				}
				for(int i=0;i<dtkho.Rows.Count;i++)	osheet.Cells[dong-1,i+6]=dtkho.Rows[i]["ten"].ToString();
				i_rec=dtkho.Rows.Count;
				for(int i=5;i<9;i++) osheet.Cells[dong-1,i+i_rec+1]=get_title(i);
				for(int i=6+i_rec;i<6+i_rec+3;i++)
				{
					orange=osheet.get_Range(ttb.getIndex(i)+"21",ttb.getIndex(i)+"22");
					orange.MergeCells=true;
				}
				osheet.Cells[dong-2,6]="Số lượng";
				orange=osheet.get_Range(ttb.getIndex(5)+"21",ttb.getIndex(i_rec+5)+"21");
				orange.HorizontalAlignment=XlHAlign.xlHAlignCenterAcrossSelection;
				orange.Font.Bold=true;
				orange=osheet.get_Range(ttb.getIndex(0)+dong.ToString(),ttb.getIndex(socot)+sodong.ToString());
				orange.Font.Name="Arial";
				orange.Font.Size=8;
				orange.EntireColumn.AutoFit();
				oxl.ActiveWindow.DisplayZeros=false;
				osheet.PageSetup.Orientation=XlPageOrientation.xlLandscape;
				osheet.PageSetup.PaperSize=XlPaperSize.xlPaperA4;
				osheet.PageSetup.LeftMargin=20;
				osheet.PageSetup.RightMargin=20;
				osheet.PageSetup.TopMargin=30;
				osheet.PageSetup.CenterFooter="Trang : &P/&N";
				osheet.Cells[1,1]=ttb.Syte;osheet.Cells[2,1]=ttb.Tenbv;
				osheet.Cells[1,3]="BIÊN BẢN THANH LÝ,HỦY";
				osheet.Cells[2,3]=ngay;
				for(int i=0;i<16;i++) osheet.Cells[i+4,2]=get_ten(i);
				for(int i=0;i<12;i++) osheet.Cells[i+6,7]=get_chucdanh(i);
				orange=osheet.get_Range(ttb.getIndex(2)+"1",ttb.getIndex(socot-1)+"2");
				orange.HorizontalAlignment=XlHAlign.xlHAlignCenterAcrossSelection;
                orange.Font.Size=12;
				orange.Font.Bold=true;
				osheet.Cells[sodong-1,2]="Tổng số tiền :";
				osheet.Cells[sodong-1,5+i_rec+3]=tongcong;
				string s=doiso.Doiso_Unicode(ds.Tables[0].Rows.Count.ToString()).Trim();
				osheet.Cells[sodong+1,2]="Tổng số :"+s.Substring(0,s.Length-4)+" khoản";
				osheet.Cells[sodong+2,2]="Số tiền :"+doiso.Doiso_Unicode(Convert.ToInt64(tongcong).ToString());
				int so1=sodong+4,so2=sodong+5;
				osheet.Cells[sodong+4,3]="HỘI ĐỒNG THANH LÝ";
				osheet.Cells[sodong+5,3]="(Ký)";
				orange=osheet.get_Range(ttb.getIndex(2)+so1.ToString(),ttb.getIndex(7)+so2.ToString());
				orange.HorizontalAlignment=XlHAlign.xlHAlignCenterAcrossSelection;
				so1=sodong-1;
				orange=osheet.get_Range(ttb.getIndex(1)+so1.ToString(),ttb.getIndex(socot)+so2.ToString());
				orange.Font.Bold=true;
				for(int i=sodong+6;i<sodong+6+12;i++) osheet.Cells[i,2]=get_ten(i-sodong-4);
				for(int i=sodong+6;i<sodong+6+12;i++) osheet.Cells[i,7]=get_chucdanh(i-sodong-6);
				oxl.Visible=true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private string get_ten(int i)
		{
			string []map={"Căn cứ quyết định số 03 QĐ/GĐ ngày . . . . . . . về việc thành lập hội đồng thanh lý thuốc quá hạn sử dụng tại các quầy phát lẻ.","Gồm các thành viên có tên sau đây :","1."+c1.Text,"2."+c2.Text,"3."+c3.Text,"4."+c4.Text,"5."+c5.Text,"6."+c6.Text,"7."+c7.Text,"8."+c8.Text,"9."+c9.Text,"10."+c10.Text,"11."+c11.Text,"12."+c12.Text,"    Đã tiến hành xem xét kiểm tra đề nghị thanh lý,hủy bỏ vào hồi      ngày     tháng    năm","Kết quả như sau :"};
			return map[i];
		}

		private string get_chucdanh(int i)
		{
			string [] map={c101.Text,c102.Text,c103.Text,c104.Text,c105.Text,c106.Text,c107.Text,c108.Text,c109.Text,c110.Text,c111.Text,c112.Text};
			return map[i];
		}

		private string get_title(int i)
		{
			string [] map={"TT","Tên","ĐVT","Nước SX","Hạn dùng","Tổng","Đơn giá","Số tiền","Lý do hủy"};
			return map[i];
		}
	}
}
