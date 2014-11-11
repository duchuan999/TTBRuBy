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
	/// Summary description for frmCongno.
	/// </summary>
	public class frmCongno : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker tu;
		private System.Windows.Forms.DateTimePicker den;
		private System.Windows.Forms.TextBox sophieu;
		private System.Windows.Forms.TextBox sohd;
		private System.Windows.Forms.TextBox madv;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button butLuu;
		private System.Windows.Forms.Button butIn;
		private System.Windows.Forms.Button butKetthuc;
		private System.Windows.Forms.Button butTonghop;
		private int i_nhom,i_userd;
		private string user,xxx,s_mmyy,sql,s_ngay,format_sotien,stime;
        private LibTTB.AccessData ttb;
		private DataSet ds=new DataSet();
		private DataSet dsxml=new DataSet();
		private Brush disabledBackBrush;
		private Brush disabledTextBrush;
		private Brush alertBackBrush;
		private Font alertFont;
		private Brush alertTextBrush;
		private Font currentRowFont;
		private Brush currentRowBackBrush;
		bool afterCurrentCellChanged;
		int checkCol=0;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tongcong;
		private System.Windows.Forms.TextBox datra;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox conlai;
		private System.Windows.Forms.Label label8;
		private decimal d_tongcong,d_datra;
		private System.Windows.Forms.Button butKiemtra;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmCongno(AccessData acc,string mmyy,int nhom,int userid,string ngay)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			ttb=acc;s_mmyy=mmyy;i_nhom=nhom;i_userd=userid;s_ngay=ngay;
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
					if(disabledBackBrush != null)
					{
						disabledBackBrush.Dispose();
						disabledTextBrush.Dispose();
						alertBackBrush.Dispose();
						alertFont.Dispose();
						alertTextBrush.Dispose();
						currentRowFont.Dispose();
						currentRowBackBrush.Dispose();
					}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCongno));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tu = new System.Windows.Forms.DateTimePicker();
            this.den = new System.Windows.Forms.DateTimePicker();
            this.sophieu = new System.Windows.Forms.TextBox();
            this.sohd = new System.Windows.Forms.TextBox();
            this.madv = new System.Windows.Forms.TextBox();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.butLuu = new System.Windows.Forms.Button();
            this.butIn = new System.Windows.Forms.Button();
            this.butKetthuc = new System.Windows.Forms.Button();
            this.butTonghop = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tongcong = new System.Windows.Forms.TextBox();
            this.datra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.conlai = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.butKiemtra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tử ngày :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(134, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "đến :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(226, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số phiếu :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(374, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số hóa đơn :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(539, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nhà cung cấp :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tu
            // 
            this.tu.CustomFormat = "dd/MM/yyyy";
            this.tu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tu.Location = new System.Drawing.Point(56, 8);
            this.tu.Name = "tu";
            this.tu.Size = new System.Drawing.Size(80, 21);
            this.tu.TabIndex = 1;
            this.tu.Value = new System.DateTime(2005, 5, 26, 11, 8, 30, 30);
            this.tu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // den
            // 
            this.den.CustomFormat = "dd/MM/yyyy";
            this.den.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.den.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.den.Location = new System.Drawing.Point(166, 8);
            this.den.Name = "den";
            this.den.Size = new System.Drawing.Size(80, 21);
            this.den.TabIndex = 3;
            this.den.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // sophieu
            // 
            this.sophieu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sophieu.Location = new System.Drawing.Point(299, 8);
            this.sophieu.Name = "sophieu";
            this.sophieu.Size = new System.Drawing.Size(80, 21);
            this.sophieu.TabIndex = 4;
            this.sophieu.TextChanged += new System.EventHandler(this.sophieu_TextChanged);
            this.sophieu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // sohd
            // 
            this.sohd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sohd.Location = new System.Drawing.Point(446, 8);
            this.sohd.Name = "sohd";
            this.sohd.Size = new System.Drawing.Size(100, 21);
            this.sohd.TabIndex = 5;
            this.sohd.TextChanged += new System.EventHandler(this.sohd_TextChanged);
            this.sohd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // madv
            // 
            this.madv.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.madv.Location = new System.Drawing.Point(624, 8);
            this.madv.Name = "madv";
            this.madv.Size = new System.Drawing.Size(160, 21);
            this.madv.TabIndex = 6;
            this.madv.TextChanged += new System.EventHandler(this.madv_TextChanged);
            this.madv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid1.CaptionBackColor = System.Drawing.SystemColors.Control;
            this.dataGrid1.DataMember = "";
            this.dataGrid1.FlatMode = true;
            this.dataGrid1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(8, 16);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.RowHeaderWidth = 5;
            this.dataGrid1.Size = new System.Drawing.Size(776, 440);
            this.dataGrid1.TabIndex = 24;
            this.dataGrid1.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
            this.dataGrid1.Click += new System.EventHandler(this.dataGrid1_Click);
            // 
            // butLuu
            // 
            this.butLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butLuu.Location = new System.Drawing.Point(366, 490);
            this.butLuu.Name = "butLuu";
            this.butLuu.Size = new System.Drawing.Size(60, 25);
            this.butLuu.TabIndex = 8;
            this.butLuu.Text = "&Cập nhật";
            this.butLuu.Click += new System.EventHandler(this.butLuu_Click);
            // 
            // butIn
            // 
            this.butIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butIn.Location = new System.Drawing.Point(429, 490);
            this.butIn.Name = "butIn";
            this.butIn.Size = new System.Drawing.Size(60, 25);
            this.butIn.TabIndex = 9;
            this.butIn.Text = "&In";
            this.butIn.Click += new System.EventHandler(this.butIn_Click);
            // 
            // butKetthuc
            // 
            this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butKetthuc.Location = new System.Drawing.Point(492, 490);
            this.butKetthuc.Name = "butKetthuc";
            this.butKetthuc.Size = new System.Drawing.Size(60, 25);
            this.butKetthuc.TabIndex = 10;
            this.butKetthuc.Text = "&Kết thúc";
            this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
            // 
            // butTonghop
            // 
            this.butTonghop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butTonghop.Location = new System.Drawing.Point(303, 490);
            this.butTonghop.Name = "butTonghop";
            this.butTonghop.Size = new System.Drawing.Size(60, 25);
            this.butTonghop.TabIndex = 7;
            this.butTonghop.Text = "&Xem";
            this.butTonghop.Click += new System.EventHandler(this.butTonghop_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(-7, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 23);
            this.label6.TabIndex = 25;
            this.label6.Text = "Tổng cộng :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tongcong
            // 
            this.tongcong.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tongcong.Enabled = false;
            this.tongcong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tongcong.Location = new System.Drawing.Point(64, 461);
            this.tongcong.Name = "tongcong";
            this.tongcong.Size = new System.Drawing.Size(176, 23);
            this.tongcong.TabIndex = 26;
            this.tongcong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // datra
            // 
            this.datra.BackColor = System.Drawing.SystemColors.HighlightText;
            this.datra.Enabled = false;
            this.datra.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datra.Location = new System.Drawing.Point(328, 461);
            this.datra.Name = "datra";
            this.datra.Size = new System.Drawing.Size(176, 23);
            this.datra.TabIndex = 28;
            this.datra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(240, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 23);
            this.label7.TabIndex = 27;
            this.label7.Text = "Đã thanh toán :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // conlai
            // 
            this.conlai.BackColor = System.Drawing.SystemColors.HighlightText;
            this.conlai.Enabled = false;
            this.conlai.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conlai.Location = new System.Drawing.Point(600, 461);
            this.conlai.Name = "conlai";
            this.conlai.Size = new System.Drawing.Size(184, 23);
            this.conlai.TabIndex = 30;
            this.conlai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(504, 461);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 23);
            this.label8.TabIndex = 29;
            this.label8.Text = "Chưa thanh toán :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // butKiemtra
            // 
            this.butKiemtra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butKiemtra.Location = new System.Drawing.Point(240, 490);
            this.butKiemtra.Name = "butKiemtra";
            this.butKiemtra.Size = new System.Drawing.Size(60, 25);
            this.butKiemtra.TabIndex = 31;
            this.butKiemtra.Text = "&Kiểm tra";
            this.butKiemtra.Click += new System.EventHandler(this.butKiemtra_Click);
            // 
            // frmCongno
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.butKiemtra);
            this.Controls.Add(this.conlai);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.datra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tongcong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.butTonghop);
            this.Controls.Add(this.butKetthuc);
            this.Controls.Add(this.butIn);
            this.Controls.Add(this.butLuu);
            this.Controls.Add(this.madv);
            this.Controls.Add(this.sohd);
            this.Controls.Add(this.sophieu);
            this.Controls.Add(this.den);
            this.Controls.Add(this.tu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCongno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Công nợ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCongno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void frmCongno_Load(object sender, System.EventArgs e)
		{
            if (Screen.PrimaryScreen.WorkingArea.Width > 800) this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            user = ttb.user; format_sotien = ttb.format_sotien(i_nhom); stime = "'" + ttb.f_ngay + "'";
			tu.Value=new DateTime(2000+int.Parse(s_mmyy.Substring(2,2)),int.Parse(s_mmyy.Substring(0,2)),1,0,0,0);
			den.Value=new DateTime(int.Parse(s_ngay.Substring(6,4)),int.Parse(s_ngay.Substring(3,2)),int.Parse(s_ngay.Substring(0,2)),0,0,0);
			butKiemtra_Click(sender,e);
			ds.ReadXml("..\\..\\..\\xml\\ttb_thanhtoan.xml");
			ds.Tables[0].Columns.Add("Chon",typeof(bool));
			load_grid();
			AddGridTableStyle();
			
			this.disabledBackBrush = new SolidBrush(Color.FromArgb(255,255,192));
			this.disabledTextBrush = new SolidBrush(Color.FromArgb(255,0,0));

			this.alertBackBrush = new SolidBrush(SystemColors.HotTrack);
			this.alertFont = new Font(this.dataGrid1.Font.Name, this.dataGrid1.Font.Size, FontStyle.Bold);
			this.alertTextBrush = new SolidBrush(Color.White);
			
			this.currentRowFont = new Font(this.dataGrid1.Font.Name, this.dataGrid1.Font.Size, FontStyle.Regular);
			this.currentRowBackBrush = new SolidBrush(Color.FromArgb(0,255, 255));		
		}

		private void load_grid()
		{
			ds.Clear();
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
                        xxx = user + mmyy;
						sql="select a.id,a.sophieu,to_char(a.ngaysp,'dd/mm/yyyy') as ngaysp,a.sohd,to_char(a.ngayhd,'dd/mm/yyyy') as ngayhd,";
						sql+="c.ten as madv,nullif(b.no,a.no) as no,nullif(b.co,a.co) as co,b.sotien,b.datra";
						sql+=" from ttb_nhapll a,ttb_thanhtoan b,"+user+".ttb_dmnx c";
						sql+=" where a.mmyy='"+mmyy+"' and a.id=b.id and a.madv=c.id and a.loai='M' and b.sotien<>0 and a.nhom="+i_nhom;
                        sql+=" and " + ttb.for_ngay("a.ngaysp", stime) + " between to_date('" + tu.Text + "'," + stime + ") and to_date('" + den.Text + "'," + stime + ")";
						foreach(DataRow r in ttb.get_data(sql).Tables[0].Rows) ttb.updrec_congno(ds.Tables[0],mmyy,decimal.Parse(r["id"].ToString()),r["sophieu"].ToString(),r["ngaysp"].ToString(),r["sohd"].ToString(),r["ngayhd"].ToString(),r["madv"].ToString(),r["no"].ToString(),r["co"].ToString(),decimal.Parse(r["sotien"].ToString()),decimal.Parse(r["datra"].ToString()));
					}
				}
			}
			dataGrid1.DataSource=ds.Tables[0];
			CurrencyManager cm = (CurrencyManager)BindingContext[dataGrid1.DataSource,dataGrid1.DataMember]; 
			DataView dv = (DataView) cm.List; 
			dv.AllowNew = false; 
			tinh_giatri("true");
		}

		private void tinh_giatri(string sql)
		{
			dsxml.Clear();
			d_tongcong=0;d_datra=0;
			foreach(DataRow r in ds.Tables[0].Select(sql))
			{
				d_tongcong+=decimal.Parse(r["sotien"].ToString());
				d_datra+=decimal.Parse(r["datra"].ToString());
			}
			decimal d_conlai=d_tongcong-d_datra;
			tongcong.Text=d_tongcong.ToString(format_sotien);
			datra.Text=d_datra.ToString(format_sotien);
			conlai.Text=d_conlai.ToString(format_sotien);
			if (sql!="") sql+=" and ";
			sql+=" datra=0";
			dsxml.Merge(ds.Tables[0].Select(sql));
		}

		private void AddGridTableStyle()
		{
			DataGridTableStyle ts =new DataGridTableStyle();
			ts.MappingName = ds.Tables[0].TableName;
			ts.AlternatingBackColor = Color.Beige;
			ts.BackColor = Color.GhostWhite;
			ts.ForeColor = Color.MidnightBlue;
			ts.GridLineColor = Color.RoyalBlue;
			ts.HeaderBackColor = Color.MidnightBlue;
			ts.HeaderForeColor = Color.Lavender;
			ts.SelectionBackColor = Color.FromArgb(0,255,255);
			ts.SelectionForeColor = Color.PaleGreen;
			ts.RowHeaderWidth=5;
					
			FormattableBooleanColumn discontinuedCol = new FormattableBooleanColumn();
			discontinuedCol.MappingName = "chon";
			discontinuedCol.HeaderText = "Chọn";
			discontinuedCol.Width = 30;
			discontinuedCol.AllowNull = false;

			discontinuedCol.SetCellFormat += new FormatCellEventHandler(SetCellFormat);
			discontinuedCol.BoolValueChanged += new BoolValueChangedEventHandler(BoolValueChanged);
			ts.GridColumnStyles.Add(discontinuedCol);
			dataGrid1.TableStyles.Add(ts);

			FormattableTextBoxColumn TextCol = new FormattableTextBoxColumn();
			TextCol.MappingName = "sophieu";
			TextCol.HeaderText = "Số phiếu";
			TextCol.Width =60;
			TextCol.ReadOnly=true;
			TextCol.SetCellFormat += new FormatCellEventHandler(SetCellFormat);
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new FormattableTextBoxColumn();
			TextCol.MappingName = "ngaysp";
			TextCol.HeaderText = "Ngày";
			TextCol.Width = 65;
			TextCol.ReadOnly=true;
			TextCol.SetCellFormat += new FormatCellEventHandler(SetCellFormat);
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new FormattableTextBoxColumn();
			TextCol.MappingName = "sohd";
			TextCol.HeaderText = "Số hóa đơn";
			TextCol.Width = 100;
			TextCol.ReadOnly=true;
			TextCol.SetCellFormat += new FormatCellEventHandler(SetCellFormat);
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new FormattableTextBoxColumn();
			TextCol.MappingName = "ngayhd";
			TextCol.HeaderText = "Ngày";
			TextCol.Width = 65;
			TextCol.ReadOnly=true;
			TextCol.SetCellFormat += new FormatCellEventHandler(SetCellFormat);
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new FormattableTextBoxColumn();
			TextCol.MappingName = "madv";
			TextCol.HeaderText = "Nhà cung cấp";
			TextCol.Width =180;
			TextCol.ReadOnly=true;
			TextCol.SetCellFormat += new FormatCellEventHandler(SetCellFormat);
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new FormattableTextBoxColumn();
			TextCol.MappingName = "no";
			TextCol.HeaderText = "Nợ";
			TextCol.Width =50;
			TextCol.ReadOnly=false;
			TextCol.SetCellFormat += new FormatCellEventHandler(SetCellFormat);
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new FormattableTextBoxColumn();
			TextCol.MappingName = "co";
			TextCol.HeaderText = "Có";
			TextCol.Width =50;
			TextCol.ReadOnly=false;
			TextCol.SetCellFormat += new FormatCellEventHandler(SetCellFormat);
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new FormattableTextBoxColumn();
			TextCol.MappingName = "sotien";
			TextCol.HeaderText = "Số tiền";
			TextCol.Width =70;
			TextCol.ReadOnly=true;
			TextCol.SetCellFormat += new FormatCellEventHandler(SetCellFormat);
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new FormattableTextBoxColumn();
			TextCol.MappingName = "datra";
			TextCol.HeaderText = "Đã trả";
			TextCol.Width =70;
			TextCol.ReadOnly=true;
			TextCol.SetCellFormat += new FormatCellEventHandler(SetCellFormat);
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);
		}
	
		private void SetCellFormat(object sender, DataGridFormatCellEventArgs e)
		{
			try
			{
				bool discontinued = (bool) ((e.Column != 0) ? this.dataGrid1[e.Row, 0] : e.CurrentCellValue);
				if(e.Column > 0 && (bool)(this.dataGrid1[e.Row, 0]))//discontinued)
				{
					//				e.BackBrush = this.disabledBackBrush;
					e.ForeBrush = this.disabledTextBrush;
				}
				else if(e.Column > 0 && e.Row == this.dataGrid1.CurrentRowIndex)//discontinued)
				{
					e.BackBrush = this.currentRowBackBrush;
					e.TextFont = this.currentRowFont;
				}
			}
			catch{}
		}

		private void BoolValueChanged(object sender, BoolValueChangedEventArgs e)
		{
			this.dataGrid1.EndEdit(this.dataGrid1.TableStyles[0].GridColumnStyles["Discontinued"],e.Row, false);
			RefreshRow(e.Row);
			this.dataGrid1.BeginEdit(this.dataGrid1.TableStyles[0].GridColumnStyles["Discontinued"],e.Row);
		}
		private void RefreshRow(int row)
		{
			Rectangle rect = this.dataGrid1.GetCellBounds(row, 0);
			rect = new Rectangle(rect.Right, rect.Top, this.dataGrid1.Width, rect.Height);
			this.dataGrid1.Invalidate(rect);
		}

		private void dataGrid1_CurrentCellChanged(object sender, System.EventArgs e)
		{
			if((bool)this.dataGrid1[this.dataGrid1.CurrentRowIndex, checkCol])
				this.dataGrid1.CurrentCell = new DataGridCell(this.dataGrid1.CurrentRowIndex, checkCol);
			afterCurrentCellChanged = true;
		}

		private void dataGrid1_Click(object sender, System.EventArgs e)
		{
			Point pt = this.dataGrid1.PointToClient(Control.MousePosition);
			DataGrid.HitTestInfo hti = this.dataGrid1.HitTest(pt);
			BindingManagerBase bmb = this.BindingContext[this.dataGrid1.DataSource, this.dataGrid1.DataMember];
			if(afterCurrentCellChanged && hti.Row < bmb.Count 
				&& hti.Type == DataGrid.HitTestType.Cell 
				&&  hti.Column == checkCol )
			{	
				this.dataGrid1[hti.Row, checkCol] = !(bool)this.dataGrid1[hti.Row, checkCol];
				RefreshRow(hti.Row);
			}
			afterCurrentCellChanged = false;
		}

		private void tu_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");
		}

		private void sophieu_TextChanged(object sender, System.EventArgs e)
		{
			if (this.ActiveControl==sophieu) ref_grid();
		}

		private void sohd_TextChanged(object sender, System.EventArgs e)
		{
			if (this.ActiveControl==sohd) ref_grid();
		}

		private void madv_TextChanged(object sender, System.EventArgs e)
		{
			if (this.ActiveControl==madv) ref_grid();
		}

		private void ref_grid()
		{
			CurrencyManager cm= (CurrencyManager)BindingContext[dataGrid1.DataSource];
			DataView dv=(DataView)cm.List;
			sql="";
			if (sophieu.Text!="")
			{
				if (sql!="") sql+=" and ";
				sql+=" sophieu like '%"+sophieu.Text+"%'";
			}
			if (sohd.Text!="")
			{
				if (sql!="") sql+=" and ";
				sql+=" sohd like '%"+sohd.Text+"%'";
			}
			if (madv.Text!="")
			{
				if (sql!="") sql+=" and ";
				sql+=" madv like '%"+madv.Text+"%'";
			}
			dv.RowFilter=sql;
			tinh_giatri(sql);
		}

		private void butTonghop_Click(object sender, System.EventArgs e)
		{
			butKiemtra_Click(sender,e);
			load_grid();
		}

		private void butLuu_Click(object sender, System.EventArgs e)
		{
			CurrencyManager cm= (CurrencyManager)BindingContext[dataGrid1.DataSource];
			DataView dv=(DataView)cm.List;
			dv.RowFilter="";
			foreach(DataRow r in ds.Tables[0].Rows)
			{
                xxx = user;// +r["mmyy"].ToString();
				if (r["chon"].ToString().Trim().ToLower()=="true")
				{
					ttb.upd_thanhtoan(r["mmyy"].ToString(),decimal.Parse(r["id"].ToString()),s_ngay,r["no"].ToString(),r["co"].ToString(),decimal.Parse(r["sotien"].ToString()),i_userd);
					ttb.execute_data("update "+xxx+".ttb_nhapll set paid=1 where id="+decimal.Parse(r["id"].ToString()));
				}
				else 
				{
					ttb.execute_data("update "+xxx+".ttb_thanhtoan set datra=0 where id="+decimal.Parse(r["id"].ToString()));
					ttb.execute_data("update "+xxx+".ttb_nhapll set paid=0 where id="+decimal.Parse(r["id"].ToString()));
				}
			}
			load_grid();
		}

		private void butIn_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (dsxml.Tables[0].Rows.Count==0)
				{
					MessageBox.Show("Không có số liệu !",ttb.Msg);
					return;
				}
				frmReport f=new frmReport(ttb,dsxml.Tables[0],"ttb_congno.rpt","CÔNG NỢ",(tu.Text==den.Text)?"Ngày "+tu.Text:"Từ ngày "+tu.Text+" đến "+den.Text,"","","","","","","","");
				f.ShowDialog(this);
			}
			catch{}
		}

		private void butKetthuc_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void butKiemtra_Click(object sender, System.EventArgs e)
		{
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
                        xxx = user + mmyy;
						sql="select a.id,sum(b.sotien+b.sotien*b.vat/100+b.cuocvc+b.chaythu) as sotien from ";
						sql+="ttb_nhapll a,ttb_nhapct b where a.id=b.id and a.nhom="+i_nhom+" and a.loai='M'";
						sql+=" group by a.id";
						foreach(DataRow r in ttb.get_data(sql).Tables[0].Rows)
						{
							ttb.execute_data("update ttb_thanhtoan set sotien=0 where id="+decimal.Parse(r["id"].ToString()));
							ttb.upd_thanhtoan(mmyy,decimal.Parse(r["id"].ToString()),decimal.Parse(r["sotien"].ToString()));
						}
					}
				}
			}
		}
	}
}
