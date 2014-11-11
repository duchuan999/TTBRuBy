using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using LibTTB;
using System.Data;

namespace TTB
{
	/// <summary>
	/// Summary description for frmLogin.
	/// </summary>
	public class frmDoingay : System.Windows.Forms.Form
	{
        private LibTTB.AccessData ttb;
		private Wildgrape.Aqua.Controls.Button cmdOk;
		private Wildgrape.Aqua.Controls.Button cmdCancle;
        private string user;
		public string mMmyy,mNgay;
		private int i_nhom,i_userid;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker ngay;
		private System.Windows.Forms.NumericUpDown mm;
		private System.Windows.Forms.NumericUpDown yyyy;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmDoingay(AccessData acc,string mmyy,int nhom,int userid)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			ttb=acc;
			i_nhom=nhom;
			i_userid=userid;
			mm.Value=decimal.Parse(mmyy.Substring(0,2));
			yyyy.Value=decimal.Parse("20"+mmyy.Substring(2,2));
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmDoingay));
			this.cmdOk = new Wildgrape.Aqua.Controls.Button();
			this.cmdCancle = new Wildgrape.Aqua.Controls.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.ngay = new System.Windows.Forms.DateTimePicker();
			this.mm = new System.Windows.Forms.NumericUpDown();
			this.yyyy = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.mm)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.yyyy)).BeginInit();
			this.SuspendLayout();
			// 
			// cmdOk
			// 
			this.cmdOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmdOk.Location = new System.Drawing.Point(22, 70);
			this.cmdOk.Name = "cmdOk";
			this.cmdOk.SizeToLabel = false;
			this.cmdOk.TabIndex = 5;
			this.cmdOk.Text = "Chọn";
			this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
			// 
			// cmdCancle
			// 
			this.cmdCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmdCancle.Location = new System.Drawing.Point(102, 70);
			this.cmdCancle.Name = "cmdCancle";
			this.cmdCancle.SizeToLabel = false;
			this.cmdCancle.TabIndex = 6;
			this.cmdCancle.Text = "Kết thúc";
			this.cmdCancle.Click += new System.EventHandler(this.cmdCancel_Click);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(3, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Ngày làm việc :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(3, 34);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Số liệu tháng :";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label5.Location = new System.Drawing.Point(118, 34);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 20);
			this.label5.TabIndex = 8;
			this.label5.Text = "Năm :";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ngay
			// 
			this.ngay.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ngay.CustomFormat = "dd/MM/yyyy";
			this.ngay.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.ngay.Location = new System.Drawing.Point(84, 10);
			this.ngay.Name = "ngay";
			this.ngay.Size = new System.Drawing.Size(119, 22);
			this.ngay.TabIndex = 2;
			this.ngay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ngay_KeyDown);
			// 
			// mm
			// 
			this.mm.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mm.Location = new System.Drawing.Point(84, 34);
			this.mm.Maximum = new System.Decimal(new int[] {
															   12,
															   0,
															   0,
															   0});
			this.mm.Minimum = new System.Decimal(new int[] {
															   1,
															   0,
															   0,
															   0});
			this.mm.Name = "mm";
			this.mm.Size = new System.Drawing.Size(35, 22);
			this.mm.TabIndex = 3;
			this.mm.Value = new System.Decimal(new int[] {
															 1,
															 0,
															 0,
															 0});
			this.mm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mm_KeyDown);
			// 
			// yyyy
			// 
			this.yyyy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.yyyy.Location = new System.Drawing.Point(153, 34);
			this.yyyy.Maximum = new System.Decimal(new int[] {
																 3004,
																 0,
																 0,
																 0});
			this.yyyy.Minimum = new System.Decimal(new int[] {
																 2004,
																 0,
																 0,
																 0});
			this.yyyy.Name = "yyyy";
			this.yyyy.Size = new System.Drawing.Size(50, 22);
			this.yyyy.TabIndex = 4;
			this.yyyy.Value = new System.Decimal(new int[] {
															   2004,
															   0,
															   0,
															   0});
			this.yyyy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.yyyy_KeyDown);
			// 
			// frmDoingay
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(214, 115);
			this.ControlBox = false;
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.mm,
																		  this.yyyy,
																		  this.ngay,
																		  this.label5,
																		  this.label4,
																		  this.label3,
																		  this.cmdCancle,
																		  this.cmdOk});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmDoingay";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đổi ngày";
			((System.ComponentModel.ISupportInitialize)(this.mm)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.yyyy)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void cmdOk_Click(object sender, System.EventArgs e)
		{
            user = ttb.user;
			mMmyy=mm.Value.ToString().PadLeft(2,'0')+yyyy.Value.ToString().PadLeft(4,'0').Substring(2,2);
			mNgay=ngay.Text;
            string sql = "select a.*,b.ten as tennhom from " + user + ".ttb_dlogin a," + user + ".ttb_dmnhomkho b where a.nhomkho=b.id and a.id=" + i_userid;
			DataTable dt=ttb.get_data(sql).Tables[0];
			if (dt.Rows.Count>0)
			{
				if (int.Parse(dt.Rows[0]["tao"].ToString())==0 && !ttb.bMmyy(mMmyy))
				{
					MessageBox.Show("Bạn không có quyền tạo số liệu tháng mới !",ttb.Msg);
					return;
				}
			}
			if (!ttb.bMmyy(mMmyy))
			{
				MessageBox.Show("Số liệu tháng "+mMmyy.Substring(0,2)+" năm 20"+mMmyy.Substring(2,2)+" chưa tạo !",ttb.Msg);
				return;
			}
			this.Close();
		}
		
		private void cmdCancel_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void ngay_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");		
		}

		private void mm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");		
		}

		private void yyyy_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");
		}
	}
}
