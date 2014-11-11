using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using LibTTB;
using doiso;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace TTB
{
	/// <summary>
	/// Summary description for frmPhieuxuat.
	/// </summary>
	public class frmPhieuxuat : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker tu;
		private System.Windows.Forms.DateTimePicker den;
		private System.Windows.Forms.ComboBox phieu;
		private System.Windows.Forms.ComboBox makp;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.DataGrid dataGrid2;
		private System.Windows.Forms.Button butLietke;
		private System.Windows.Forms.Button butMoi;
		private System.Windows.Forms.Button butLuu;
		private System.Windows.Forms.Button butBoqua;
		private System.Windows.Forms.Button butHuy;
		private System.Windows.Forms.Button butIn;
		private System.Windows.Forms.Button butKetthuc;
		private DataSet dsll=new DataSet();
		private DataSet dsct=new DataSet();
		private DataSet dsphieu=new DataSet();
		private DataTable dtkt=new DataTable();
		private DataTable dtsophieu=new DataTable();
        private LibTTB.AccessData ttb;
		private Doisototext doiso=new Doisototext();
		private string s_mmyy,sql,s_ngay,s_tenkp,s_tenkho;
		private decimal l_idxuat;
		private int i_nhom,i_userid,i_makp,i_makho;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox kho;
		private System.Windows.Forms.CheckBox mmyy;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmPhieuxuat(AccessData acc,string mmyy,int nhom,int userid)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			ttb=acc;s_mmyy=mmyy;i_nhom=nhom;i_userid=userid;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmPhieuxuat));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tu = new System.Windows.Forms.DateTimePicker();
			this.den = new System.Windows.Forms.DateTimePicker();
			this.phieu = new System.Windows.Forms.ComboBox();
			this.makp = new System.Windows.Forms.ComboBox();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGrid2 = new System.Windows.Forms.DataGrid();
			this.butLietke = new System.Windows.Forms.Button();
			this.butMoi = new System.Windows.Forms.Button();
			this.butLuu = new System.Windows.Forms.Button();
			this.butBoqua = new System.Windows.Forms.Button();
			this.butHuy = new System.Windows.Forms.Button();
			this.butIn = new System.Windows.Forms.Button();
			this.butKetthuc = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.kho = new System.Windows.Forms.ComboBox();
			this.mmyy = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Từ ngày :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(144, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "đến :";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(416, 4);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Phiếu :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(608, 4);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Khoa :";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tu
			// 
			this.tu.CustomFormat = "dd/MM/yyyy";
			this.tu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.tu.Location = new System.Drawing.Point(64, 4);
			this.tu.Name = "tu";
			this.tu.Size = new System.Drawing.Size(80, 21);
			this.tu.TabIndex = 1;
			this.tu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
			// 
			// den
			// 
			this.den.CustomFormat = "dd/MM/yyyy";
			this.den.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.den.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.den.Location = new System.Drawing.Point(176, 4);
			this.den.Name = "den";
			this.den.Size = new System.Drawing.Size(80, 21);
			this.den.TabIndex = 3;
			this.den.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
			// 
			// phieu
			// 
			this.phieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.phieu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.phieu.Location = new System.Drawing.Point(456, 4);
			this.phieu.Name = "phieu";
			this.phieu.Size = new System.Drawing.Size(160, 21);
			this.phieu.TabIndex = 5;
			this.phieu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
			this.phieu.SelectedIndexChanged += new System.EventHandler(this.phieu_SelectedIndexChanged);
			// 
			// makp
			// 
			this.makp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.makp.Location = new System.Drawing.Point(648, 4);
			this.makp.Name = "makp";
			this.makp.Size = new System.Drawing.Size(136, 21);
			this.makp.TabIndex = 6;
			this.makp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
			this.makp.SelectedIndexChanged += new System.EventHandler(this.makp_SelectedIndexChanged);
			// 
			// dataGrid1
			// 
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGrid1.CaptionBackColor = System.Drawing.SystemColors.Control;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.FlatMode = true;
			this.dataGrid1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(8, 12);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.RowHeaderWidth = 3;
			this.dataGrid1.Size = new System.Drawing.Size(336, 476);
			this.dataGrid1.TabIndex = 14;
			this.dataGrid1.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
			// 
			// dataGrid2
			// 
			this.dataGrid2.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGrid2.CaptionBackColor = System.Drawing.SystemColors.Control;
			this.dataGrid2.DataMember = "";
			this.dataGrid2.FlatMode = true;
			this.dataGrid2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid2.Location = new System.Drawing.Point(352, 12);
			this.dataGrid2.Name = "dataGrid2";
			this.dataGrid2.RowHeaderWidth = 3;
			this.dataGrid2.Size = new System.Drawing.Size(432, 476);
			this.dataGrid2.TabIndex = 15;
			// 
			// butLietke
			// 
			this.butLietke.Image = ((System.Drawing.Bitmap)(resources.GetObject("butLietke.Image")));
			this.butLietke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butLietke.Location = new System.Drawing.Point(131, 496);
			this.butLietke.Name = "butLietke";
			this.butLietke.Size = new System.Drawing.Size(75, 28);
			this.butLietke.TabIndex = 9;
			this.butLietke.Text = "       Liệt &kê";
			this.butLietke.Click += new System.EventHandler(this.butLietke_Click);
			// 
			// butMoi
			// 
			this.butMoi.Image = ((System.Drawing.Bitmap)(resources.GetObject("butMoi.Image")));
			this.butMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butMoi.Location = new System.Drawing.Point(207, 496);
			this.butMoi.Name = "butMoi";
			this.butMoi.Size = new System.Drawing.Size(75, 28);
			this.butMoi.TabIndex = 10;
			this.butMoi.Text = "      &Mới";
			this.butMoi.Click += new System.EventHandler(this.butMoi_Click);
			// 
			// butLuu
			// 
			this.butLuu.Enabled = false;
			this.butLuu.Image = ((System.Drawing.Bitmap)(resources.GetObject("butLuu.Image")));
			this.butLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butLuu.Location = new System.Drawing.Point(283, 496);
			this.butLuu.Name = "butLuu";
			this.butLuu.Size = new System.Drawing.Size(75, 28);
			this.butLuu.TabIndex = 7;
			this.butLuu.Text = "       &Lưu";
			this.butLuu.Click += new System.EventHandler(this.butLuu_Click);
			// 
			// butBoqua
			// 
			this.butBoqua.Enabled = false;
			this.butBoqua.Image = ((System.Drawing.Bitmap)(resources.GetObject("butBoqua.Image")));
			this.butBoqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butBoqua.Location = new System.Drawing.Point(359, 496);
			this.butBoqua.Name = "butBoqua";
			this.butBoqua.Size = new System.Drawing.Size(75, 28);
			this.butBoqua.TabIndex = 8;
			this.butBoqua.Text = "     &Bỏ qua";
			this.butBoqua.Click += new System.EventHandler(this.butBoqua_Click);
			// 
			// butHuy
			// 
			this.butHuy.Image = ((System.Drawing.Bitmap)(resources.GetObject("butHuy.Image")));
			this.butHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butHuy.Location = new System.Drawing.Point(435, 496);
			this.butHuy.Name = "butHuy";
			this.butHuy.Size = new System.Drawing.Size(75, 28);
			this.butHuy.TabIndex = 11;
			this.butHuy.Text = "     &Hủy";
			this.butHuy.Click += new System.EventHandler(this.butHuy_Click);
			// 
			// butIn
			// 
			this.butIn.Image = ((System.Drawing.Bitmap)(resources.GetObject("butIn.Image")));
			this.butIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butIn.Location = new System.Drawing.Point(511, 496);
			this.butIn.Name = "butIn";
			this.butIn.Size = new System.Drawing.Size(75, 28);
			this.butIn.TabIndex = 12;
			this.butIn.Text = "     &In";
			this.butIn.Click += new System.EventHandler(this.butIn_Click);
			// 
			// butKetthuc
			// 
			this.butKetthuc.Image = ((System.Drawing.Bitmap)(resources.GetObject("butKetthuc.Image")));
			this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butKetthuc.Location = new System.Drawing.Point(587, 496);
			this.butKetthuc.Name = "butKetthuc";
			this.butKetthuc.Size = new System.Drawing.Size(75, 28);
			this.butKetthuc.TabIndex = 13;
			this.butKetthuc.Text = "Kết &thúc";
			this.butKetthuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(256, 4);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 23);
			this.label5.TabIndex = 17;
			this.label5.Text = "Kho :";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// kho
			// 
			this.kho.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.kho.Location = new System.Drawing.Point(288, 4);
			this.kho.Name = "kho";
			this.kho.Size = new System.Drawing.Size(128, 21);
			this.kho.TabIndex = 4;
			this.kho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
			this.kho.SelectedIndexChanged += new System.EventHandler(this.kho_SelectedIndexChanged);
			// 
			// mmyy
			// 
			this.mmyy.Location = new System.Drawing.Point(8, 496);
			this.mmyy.Name = "mmyy";
			this.mmyy.Size = new System.Drawing.Size(112, 24);
			this.mmyy.TabIndex = 18;
			this.mmyy.Text = "checkBox1";
			// 
			// frmPhieuxuat
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(792, 573);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.mmyy,
																		  this.kho,
																		  this.label3,
																		  this.label5,
																		  this.butKetthuc,
																		  this.butIn,
																		  this.butHuy,
																		  this.butBoqua,
																		  this.butLuu,
																		  this.butMoi,
																		  this.butLietke,
																		  this.phieu,
																		  this.makp,
																		  this.label4,
																		  this.dataGrid2,
																		  this.den,
																		  this.tu,
																		  this.label2,
																		  this.label1,
																		  this.dataGrid1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmPhieuxuat";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Phiếu xuất kho";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmPhieuxuat_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmPhieuxuat_Load(object sender, System.EventArgs e)
		{
			mmyy.Text="Tháng "+s_mmyy.Substring(0,2)+"/20"+s_mmyy.Substring(2,2);
			dtkt=ttb.get_data("select a.ma,b.ma sotk from ttb_dmbd a,ttb_dmnhomkt b where a.sotk=b.id and a.nhom="+i_nhom).Tables[0];
			kho.DisplayMember="TEN";
			kho.ValueMember="ID";
			kho.DataSource=ttb.get_data("select * from ttb_dmkho where nhom="+i_nhom+" order by stt").Tables[0];
			dsphieu.ReadXml("..\\..\\..\\xml\\ttb_phieuxuat.xml");
			phieu.DisplayMember="TEN";
			phieu.ValueMember="ID";
			phieu.DataSource=dsphieu.Tables[0];
			makp.DisplayMember="TEN";
			makp.ValueMember="ID";
			makp.DataSource=ttb.get_data("select * from d_duockp where nhom like '%"+i_nhom.ToString()+"%' order by stt").Tables[0];
			dsll.ReadXml("..\\..\\..\\xml\\ttb_phieuxuatll.xml");
			dsct.ReadXml("..\\..\\..\\xml\\ttb_phieuxuatct.xml");
			dataGrid1.DataSource=dsll.Tables[0];
			dataGrid2.DataSource=dsct.Tables[0];
			if (phieu.Items.Count>0) makp.Enabled=phieu.SelectedIndex<4;
			AddGridTableStyle();
			AddGridTableStyle1();
		}

		private void butKetthuc_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void tu_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");
		}

		private void AddGridTableStyle()
		{
			DataGridTableStyle ts =new DataGridTableStyle();
			ts.MappingName = dsll.Tables[0].TableName;
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
			TextCol.ReadOnly=true;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "soct";
			TextCol.HeaderText = "Số phiếu";
			TextCol.Width = 100;
			TextCol.ReadOnly=false;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "ngay";
			TextCol.HeaderText = "Ngày";
			TextCol.Width = 70;
			TextCol.ReadOnly=true;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "no";
			TextCol.HeaderText = "Nợ";
			TextCol.Width = 70;
			TextCol.ReadOnly=false;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "co";
			TextCol.HeaderText = "Có";
			TextCol.Width = 70;
			TextCol.ReadOnly=false;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "diengiai";
			TextCol.HeaderText = "Diễn giải";
			TextCol.Width = 100;
			TextCol.ReadOnly=false;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "idxuat";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			TextCol.ReadOnly=true;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "makp";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			TextCol.ReadOnly=true;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tenkp";
			TextCol.HeaderText = "Khoa/phòng";
			TextCol.Width = 100;
			TextCol.ReadOnly=true;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "makho";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			TextCol.ReadOnly=true;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tenkho";
			TextCol.HeaderText = "Kho";
			TextCol.Width = 100;
			TextCol.ReadOnly=true;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);
		}

		private void AddGridTableStyle1()
		{
			DataGridTableStyle ts =new DataGridTableStyle();
			ts.MappingName = dsct.Tables[0].TableName;
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
			TextCol.MappingName = "ten";
			TextCol.HeaderText = "Tên-hàm lượng";
			TextCol.Width = 200;
			TextCol.ReadOnly=true;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid2.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "dang";
			TextCol.HeaderText = "ĐVT";
			TextCol.Width =40;
			TextCol.ReadOnly=true;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid2.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "handung";
			TextCol.HeaderText = "Date";
			TextCol.Width = 40;
			TextCol.ReadOnly=true;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid2.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "losx";
			TextCol.HeaderText = "Lô";
			TextCol.Width = 60;
			TextCol.ReadOnly=true;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid2.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "soluong";
			TextCol.HeaderText = "Số lượng";
			TextCol.Width = 70;
			TextCol.ReadOnly=true;
			TextCol.Format=ttb.format_soluong(i_nhom);
			TextCol.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid2.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "dongia";
			TextCol.HeaderText = "Đơn giá";
			TextCol.Width = 80;
			TextCol.Format=ttb.format_dongia(i_nhom);
			TextCol.Alignment=HorizontalAlignment.Right;
			TextCol.ReadOnly=true;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid2.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "sotien";
			TextCol.HeaderText = "Số tiền";
			TextCol.Width = 80;
			TextCol.Format=ttb.format_sotien(i_nhom);
			TextCol.Alignment=HorizontalAlignment.Right;
			TextCol.ReadOnly=true;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid2.TableStyles.Add(ts);
		}

		private void load_ll()
		{
			Cursor=Cursors.WaitCursor;
			int i=phieu.SelectedIndex;
			//
			sql="select soct,to_char(ngay,'dd/mm/yyyy') as ngay,no,co,makp,loai,diengiai,kho from ttb_phieuxuat where nhom="+i_nhom;
			if (!mmyy.Checked) sql+=" and to_date(ngay,'dd/mm/yy') between to_date('"+tu.Text+"','dd/mm/yy') and to_date('"+den.Text+"','dd/mm/yy')";
			if (makp.Enabled && makp.SelectedIndex!=-1) sql+=" and makp="+int.Parse(makp.SelectedValue.ToString());
			sql+=" and loai='"+dsphieu.Tables[0].Rows[phieu.SelectedIndex]["stt"].ToString()+"'";
			DataTable tmp=ttb.get_data(sql).Tables[0];//s_mmyy
			//
			sql="select distinct 0 id,";
			if (dsphieu.Tables[0].Rows[i]["sophieu"].ToString()!="") sql+="a.sophieu as soct,a.id as idxuat,";
			else sql+="' ' as soct,0 as idxuat,";
			if (dsphieu.Tables[0].Rows[i]["sophieu"].ToString()=="" && dsphieu.Tables[0].Rows[i]["dk"].ToString()!="")
				sql+="a.makp,d.ten tenkp,";
			else sql+="0 makp,' ' tenkp,";
			if (dsphieu.Tables[0].Rows[i]["sophieu"].ToString()!="") sql+="a.khox makho,";
			else sql+="b.makho,";
			sql+="c.ten tenkho,to_char(a.ngay,'dd/mm/yyyy') as ngay,' ' as no,' ' as co,' ' as diengiai ";
			sql+="from "+dsphieu.Tables[0].Rows[i]["t1"].ToString()+" a,"+dsphieu.Tables[0].Rows[i]["t2"].ToString()+" b,"+ttb.user+".ttb_dmkho c ";
			if (dsphieu.Tables[0].Rows[i]["sophieu"].ToString()=="" && dsphieu.Tables[0].Rows[i]["dk"].ToString()!="") sql+=","+ttb.user+".d_duockp d ";
			sql+="where a.id=b.id ";
			if (dsphieu.Tables[0].Rows[i]["sophieu"].ToString()!="") sql+=" and a.khox=c.id";
			else sql+="and b.makho=c.id";
			if (dsphieu.Tables[0].Rows[i]["sophieu"].ToString()=="" && dsphieu.Tables[0].Rows[i]["dk"].ToString()!="") sql+=" and a.makp=d.id";
			sql+=" and a.nhom="+i_nhom;
			if (!mmyy.Checked) sql+=" and to_date(a.ngay,'dd/mm/yy') between to_date('"+tu.Text+"','dd/mm/yy') and to_date('"+den.Text+"','dd/mm/yy')";
			if (makp.Enabled && makp.SelectedIndex!=-1) sql+=" and a.makp="+int.Parse(makp.SelectedValue.ToString());
			if (dsphieu.Tables[0].Rows[i]["dk"].ToString()!="") sql+=" and "+dsphieu.Tables[0].Rows[i]["dk"].ToString();
			sql+=" and b.soluong>0";
			if (kho.SelectedIndex!=-1) 
			{
				if (dsphieu.Tables[0].Rows[i]["sophieu"].ToString()!="")
					sql+=" and a.khox="+int.Parse(kho.SelectedValue.ToString());
				else
					sql+=" and b.makho="+int.Parse(kho.SelectedValue.ToString());
			}
			if (dsphieu.Tables[0].Rows[i]["t1"].ToString().ToLower()=="ttb_xuatsdll")
			{
				sql+=" and a.maql<>0";
				sql+=" union ";
				sql+="select distinct 0 id,";
				sql+="a.mabn as soct,a.id as idxuat,";
				if (dsphieu.Tables[0].Rows[i]["sophieu"].ToString()=="" && dsphieu.Tables[0].Rows[i]["dk"].ToString()!="")
					sql+="a.makp,d.ten tenkp,";
				else sql+="0 makp,' ' tenkp,";
				if (dsphieu.Tables[0].Rows[i]["sophieu"].ToString()!="") sql+="a.khox makho,";
				else sql+="b.makho,";
				sql+="c.ten tenkho,to_char(a.ngay,'dd/mm/yyyy') as ngay,' ' as no,' ' as co,' ' as diengiai ";
				sql+="from "+dsphieu.Tables[0].Rows[i]["t1"].ToString()+" a,"+dsphieu.Tables[0].Rows[i]["t2"].ToString()+" b,"+ttb.user+".ttb_dmkho c ";
				if (dsphieu.Tables[0].Rows[i]["sophieu"].ToString()=="" && dsphieu.Tables[0].Rows[i]["dk"].ToString()!="") sql+=","+ttb.user+".d_duockp d ";
				sql+="where a.id=b.id ";
				if (dsphieu.Tables[0].Rows[i]["sophieu"].ToString()!="") sql+=" and a.khox=c.id";
				else sql+="and b.makho=c.id";
				if (dsphieu.Tables[0].Rows[i]["sophieu"].ToString()=="" && dsphieu.Tables[0].Rows[i]["dk"].ToString()!="") sql+=" and a.makp=d.id";
				sql+=" and a.nhom="+i_nhom;
				if (!mmyy.Checked) sql+=" and to_date(a.ngay,'dd/mm/yy') between to_date('"+tu.Text+"','dd/mm/yy') and to_date('"+den.Text+"','dd/mm/yy')";
				if (makp.Enabled && makp.SelectedIndex!=-1) sql+=" and a.makp="+int.Parse(makp.SelectedValue.ToString());
				if (dsphieu.Tables[0].Rows[i]["dk"].ToString()!="") sql+=" and "+dsphieu.Tables[0].Rows[i]["dk"].ToString();
				sql+=" and b.soluong>0";
				if (kho.SelectedIndex!=-1) 
				{
					if (dsphieu.Tables[0].Rows[i]["sophieu"].ToString()!="")
						sql+=" and a.khox="+int.Parse(kho.SelectedValue.ToString());
					else
						sql+=" and b.makho="+int.Parse(kho.SelectedValue.ToString());
				}
				sql+=" and a.maql=0";
			}
            DataTable tmp1 = ttb.get_data(sql).Tables[0];//s_mmyy
			dsll.Clear();
			DataRow r1,r2;
			foreach(DataRow r in tmp1.Select("true","ngay,makp"))
			{
				r2=dsll.Tables[0].NewRow();
				r2["id"]=r["id"].ToString();
				r2["soct"]=r["soct"].ToString();
				r2["ngay"]=r["ngay"].ToString();
				r2["no"]=r["no"].ToString();
				r2["co"]=r["co"].ToString();
				r2["diengiai"]=r["diengiai"].ToString();
				r2["idxuat"]=r["idxuat"].ToString();
				r2["makp"]=r["makp"].ToString();
				r2["tenkp"]=r["tenkp"].ToString();
				r2["makho"]=r["makho"].ToString();
				r2["tenkho"]=r["tenkho"].ToString();
				sql="ngay='"+r["ngay"].ToString()+"' and loai='"+dsphieu.Tables[0].Rows[phieu.SelectedIndex]["stt"].ToString()+"'";
				sql+=" and makp="+int.Parse(r["makp"].ToString());
				sql+=" and kho='"+r["makho"].ToString()+"'";
				r1=ttb.getrowbyid(tmp,sql);
				if (r1!=null) 
				{
					r2["no"]=r1["no"].ToString();
					r2["co"]=r1["co"].ToString();
					r2["soct"]=r1["soct"].ToString();
					r2["diengiai"]=r1["diengiai"].ToString();
				}
				dsll.Tables[0].Rows.Add(r2);
			}
			dataGrid1.DataSource=dsll.Tables[0];
			CurrencyManager cm = (CurrencyManager)BindingContext[dataGrid1.DataSource,dataGrid1.DataMember]; 
			DataView dv = (DataView) cm.List; 
			dv.AllowNew = false; 
			Cursor=Cursors.Default;
		}

		private void load_ct()
		{
			Cursor=Cursors.WaitCursor;
			int i=phieu.SelectedIndex;
			sql="select c.ma,trim(c.ten)||' '||c.hamluong as ten,c.dang,sum(b.soluong) as soluong,sum(round(b.sotien/b.soluong,3)) as dongia,sum(b.soluong*b.giamua) as sotien ";
			sql+="from "+dsphieu.Tables[0].Rows[i]["t1"].ToString()+" a,"+dsphieu.Tables[0].Rows[i]["t2"].ToString()+" b,";
			sql+=ttb.user+".ttb_dmbd c ";
			sql+="where a.id=b.id and b.mabd=c.id and b.soluong>0 and a.nhom="+i_nhom;
			sql+=" and b.makho="+i_makho;
			if (l_idxuat!=0) sql+=" and a.id="+l_idxuat;
			else
			{
				sql+=" and to_char(a.ngay,'dd/mm/yyyy')='"+s_ngay+"'";
				if (i_makp!=0) sql+=" and a.makp="+i_makp;
				if (dsphieu.Tables[0].Rows[i]["dk"].ToString()!="") sql+=" and "+dsphieu.Tables[0].Rows[i]["dk"].ToString();
			}
			sql+="group by c.ma,trim(c.ten)||' '||c.hamluong,c.dang";
            dsct = ttb.get_data(sql);//s_mmyy
			dataGrid2.DataSource=dsct.Tables[0];
			CurrencyManager cm = (CurrencyManager)BindingContext[dataGrid2.DataSource,dataGrid2.DataMember];
			DataView dv = (DataView) cm.List; 
			dv.AllowNew = false; 
			Cursor=Cursors.Default;
		}

		private void ref_text()
		{
			try
			{
				int i_row=dataGrid1.CurrentCell.RowNumber;
				l_idxuat=decimal.Parse(dataGrid1[i_row,6].ToString());
				i_makp=int.Parse(dataGrid1[i_row,7].ToString());
				s_tenkp=dataGrid1[i_row,8].ToString();
				i_makho=int.Parse(dataGrid1[i_row,9].ToString());
				s_tenkho=dataGrid1[i_row,10].ToString();
				s_ngay=dataGrid1[i_row,2].ToString();
				load_ct();
				if (dataGrid1[i_row,4].ToString()==" ")
				{
					string sotk="";
					DataRow r1;
					foreach(DataRow r in dsct.Tables[0].Rows)
					{
						r1=ttb.getrowbyid(dtkt,"ma='"+r["ma"].ToString()+"'");
						if (r1!=null)
						{
							if (sotk.IndexOf(r1["sotk"].ToString())==-1)
							{
								sotk+=(sotk!="")?",":"";
								sotk+=r1["sotk"].ToString().Trim();
							}
						}
					}
					dataGrid1[i_row,4]=sotk;
				}
				if (dataGrid1[i_row,5].ToString()==" ")
				{
					string sp="",sophieu="";
					sql="ngay='"+s_ngay+"' and loai="+int.Parse(dsphieu.Tables[0].Rows[phieu.SelectedIndex]["stt"].ToString());
					if (i_makp!=0) sql+=" and makp="+i_makp;
					sql+=" and makho="+i_makho;
					foreach(DataRow r in dtsophieu.Select(sql,"so"))
					{
						if (sp.IndexOf(r["so"].ToString().PadLeft(10,'0'))==-1)
						{
							sp+=(sp!="")?",":"";
							sp+=r["so"].ToString().PadLeft(10,'0');
							sophieu+=(sophieu!="")?",":"";
							sophieu+=r["so"].ToString().Trim();
						}
					}
					dataGrid1[i_row,5]=sophieu;
				}
			}
			catch{l_idxuat=0;s_ngay="";}
		}

		private void dataGrid1_CurrentCellChanged(object sender, System.EventArgs e)
		{
			ref_text();
		}

		private void phieu_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (this.ActiveControl==phieu)
			{
				makp.Enabled=phieu.SelectedIndex<4;
				dataGrid1.DataSource=null;
				dataGrid2.DataSource=null;
			}
		}

		private void butLietke_Click(object sender, System.EventArgs e)
		{
            dtsophieu = ttb.get_data("select to_char(ngay,'dd/mm/yyyy') ngay,makp,loai,phieu,makho,manguon,so,madoituong from ttb_sophieu where nhom=" + i_nhom).Tables[0];//s_mmyy
			load_ll();
			ref_text();
		}

		private void ena_object(bool ena)
		{
			butMoi.Enabled=!ena;
			butLuu.Enabled=ena;
			butBoqua.Enabled=ena;
			butHuy.Enabled=!ena;
			butIn.Enabled=!ena;
			butKetthuc.Enabled=!ena;
			dataGrid1.ReadOnly=!ena;
		}

		private void butMoi_Click(object sender, System.EventArgs e)
		{
			ena_object(true);
			dataGrid1.Focus();
		}

		private decimal get_sotien(decimal idxuat,string ngay,int makho)
		{
			decimal tc=0;
			int i=phieu.SelectedIndex;
			sql="select sum(b.soluong*b.giamua) as sotien ";
			sql+="from "+dsphieu.Tables[0].Rows[i]["t1"].ToString()+" a,"+dsphieu.Tables[0].Rows[i]["t2"].ToString()+" b,";
			sql+=ttb.user+".ttb_dmbd c ";
			sql+="where a.id=b.id and b.mabd=c.id and b.soluong>0 and a.nhom="+i_nhom;
			sql+=" and b.makho="+makho;
			if (idxuat!=0) sql+=" and a.id="+idxuat;
			else
			{
				sql+=" and to_char(a.ngay,'dd/mm/yyyy')='"+ngay+"'";
				if (makp.Enabled && makp.SelectedIndex!=-1) sql+=" and a.makp="+int.Parse(makp.SelectedValue.ToString());
				if (dsphieu.Tables[0].Rows[i]["dk"].ToString()!="") sql+=" and "+dsphieu.Tables[0].Rows[i]["dk"].ToString();
			}
            DataTable tmp = ttb.get_data(sql).Tables[0];//s_mmyy
			if (tmp.Rows[0]["sotien"].ToString()!="") tc=decimal.Parse(tmp.Rows[0]["sotien"].ToString());
			return tc;
		}

		private void butLuu_Click(object sender, System.EventArgs e)
		{
			Cursor=Cursors.WaitCursor;
			decimal id;
			dsll.AcceptChanges();
			foreach(DataRow r in dsll.Tables[0].Rows)
			{
				id=ttb.get_id_phieuxuat(r["ngay"].ToString(),(r["makp"].ToString()!="0")?int.Parse(r["makp"].ToString()):0,i_nhom,dsphieu.Tables[0].Rows[phieu.SelectedIndex]["stt"].ToString(),"",r["makho"].ToString(),s_mmyy);
				if (id==0) id=ttb.get_id_phieuxuat();
				ttb.upd_phieuxuat(s_mmyy,id,r["soct"].ToString(),r["ngay"].ToString(),(r["makp"].ToString()!="0")?int.Parse(r["makp"].ToString()):0,i_nhom,dsphieu.Tables[0].Rows[phieu.SelectedIndex]["stt"].ToString(),"",r["makho"].ToString(),get_sotien(decimal.Parse(r["idxuat"].ToString()),r["ngay"].ToString(),int.Parse(r["makho"].ToString())),r["no"].ToString(),r["co"].ToString(),r["diengiai"].ToString(),i_userid);
			}
			Cursor=Cursors.Default;
			ena_object(false);
		}

		private void butBoqua_Click(object sender, System.EventArgs e)
		{
			ena_object(false);
		}

		private void butHuy_Click(object sender, System.EventArgs e)
		{
			if (dsll.Tables[0].Rows.Count==0) return;
			if (MessageBox.Show("Đồng ý hủy ?",ttb.Msg,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
			{
				sql="delete from ttb_phieuxuat where to_char(ngay,'dd/mm/yyyy')='"+s_ngay+"' and nhom="+i_nhom;
				if (i_makp!=0) sql+=" and makp="+i_makp;
				sql+=" and kho='"+i_makho.ToString()+"'";
				sql+=" and loai='"+dsphieu.Tables[0].Rows[phieu.SelectedIndex]["stt"].ToString()+"'";
				ttb.execute_data(sql);//s_mmyy
				load_ll();
			}
		}

		private decimal tongcong(DataTable dt)
		{
			decimal tc=0;
			foreach(DataRow r1 in dt.Rows) tc+=decimal.Parse(r1["sotien"].ToString());
			return tc;
		}

		private void butIn_Click(object sender, System.EventArgs e)
		{
			if (dsct.Tables[0].Rows.Count==0 || dsll.Tables[0].Rows.Count==0) return;
			sql="select * from ttb_phieuxuat where to_char(ngay,'dd/mm/yyyy')='"+s_ngay+"' and nhom="+i_nhom;
			if (i_makp!=0) sql+=" and makp="+i_makp;
			sql+=" and kho='"+i_makho.ToString()+"'";
			sql+=" and loai='"+dsphieu.Tables[0].Rows[phieu.SelectedIndex]["stt"].ToString()+"'";
			if (ttb.get_data(sql).Tables[0].Rows.Count==0)//s_mmyy
			{
				MessageBox.Show("Chưa cập nhật không thể in !",ttb.Msg);
				return;
			}
			int i_row=dataGrid1.CurrentCell.RowNumber;
			string tenfile="d_phieuxuat.rpt",slydo=dsphieu.Tables[0].Rows[phieu.SelectedIndex]["lydo"].ToString();
			if (dataGrid1[i_row,5].ToString().Trim().Length>0) slydo+=" (Số phiếu lĩnh : "+dataGrid1[i_row,5].ToString().Trim()+")";
			decimal d_tongcong=tongcong(dsct.Tables[0]);
			if (ttb.bPreview)
			{
				frmReport f=new frmReport(ttb,dsct.Tables[0],tenfile,dataGrid1[i_row,1].ToString(),dataGrid1[i_row,2].ToString(),dataGrid1[i_row,3].ToString(),dataGrid1[i_row,4].ToString(),s_tenkp,slydo,s_tenkho,doiso.Doiso_Unicode(Convert.ToInt64(d_tongcong).ToString()),"","");
				f.ShowDialog();
			}
			else
			{
				ReportDocument oRpt=new ReportDocument();
				oRpt.Load("..\\..\\..\\report\\"+tenfile,OpenReportMethod.OpenReportByTempCopy);
				oRpt.SetDataSource(dsct.Tables[0]);
				oRpt.DataDefinition.FormulaFields["soyte"].Text="'"+ttb.Syte+"'";
				oRpt.DataDefinition.FormulaFields["benhvien"].Text="'"+ttb.Tenbv+"'";
				oRpt.DataDefinition.FormulaFields["c1"].Text="'"+dataGrid1[i_row,1].ToString()+"'";
				oRpt.DataDefinition.FormulaFields["c2"].Text="'"+dataGrid1[i_row,2].ToString()+"'";
				oRpt.DataDefinition.FormulaFields["c3"].Text="'"+dataGrid1[i_row,3].ToString()+"'";
				oRpt.DataDefinition.FormulaFields["c4"].Text="'"+dataGrid1[i_row,4].ToString()+"'";
				oRpt.DataDefinition.FormulaFields["c5"].Text="'"+s_tenkp+"'";
				oRpt.DataDefinition.FormulaFields["c6"].Text="'"+slydo+"'";
				oRpt.DataDefinition.FormulaFields["c7"].Text="'"+s_tenkho+"'";
				oRpt.DataDefinition.FormulaFields["c8"].Text="'"+doiso.Doiso_Unicode(Convert.ToInt64(d_tongcong).ToString())+"'";
				oRpt.DataDefinition.FormulaFields["c9"].Text="";
				oRpt.DataDefinition.FormulaFields["c10"].Text="";
				oRpt.DataDefinition.FormulaFields["giamdoc"].Text="'"+ttb.Giamdoc(i_nhom)+"'";
				oRpt.DataDefinition.FormulaFields["phutrach"].Text="'"+ttb.Phutrach(i_nhom)+"'";
				oRpt.DataDefinition.FormulaFields["thongke"].Text="'"+ttb.Thongke(i_nhom)+"'";
				oRpt.DataDefinition.FormulaFields["ketoan"].Text="'"+ttb.Ketoan(i_nhom)+"'";
				oRpt.DataDefinition.FormulaFields["thukho"].Text="'"+ttb.Thukho(i_nhom)+"'";
				//oRpt.PrintOptions.PaperSize=PaperSize.PaperA4;
				oRpt.PrintOptions.PaperSize=PaperSize.DefaultPaperSize;
				oRpt.PrintOptions.PaperOrientation=PaperOrientation.Portrait;
				oRpt.PrintToPrinter(1,false,0,0);
                oRpt.Close(); oRpt.Dispose();
			}
			
		}

		private void makp_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (this.ActiveControl==makp)
			{
				dataGrid1.DataSource=null;
				dataGrid2.DataSource=null;
			}
		}

		private void kho_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (this.ActiveControl==kho)
			{
				dataGrid1.DataSource=null;
				dataGrid2.DataSource=null;
			}
		}
	}
}
