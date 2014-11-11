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
	/// Summary description for frmSuastt.
	/// </summary>
	public class frmSuastt : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Label label1;
		private LibTTB.AccessData ttb;
		private DataTable dt=new DataTable();
		private int i_nhom;
		private System.Windows.Forms.Button butSua;
		private System.Windows.Forms.Button butKetthuc;
		private System.Windows.Forms.NumericUpDown tu;
		private System.Windows.Forms.NumericUpDown den;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown tt;
		private System.Windows.Forms.Label label3;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmSuastt(AccessData acc,int nhom)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			ttb=acc;i_nhom=nhom;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmSuastt));
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.tu = new System.Windows.Forms.NumericUpDown();
			this.butSua = new System.Windows.Forms.Button();
			this.butKetthuc = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.den = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.tt = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.den)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tt)).BeginInit();
			this.SuspendLayout();
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
			this.dataGrid1.Location = new System.Drawing.Point(10, -13);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro;
			this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.RowHeaderWidth = 10;
			this.dataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue;
			this.dataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
			this.dataGrid1.Size = new System.Drawing.Size(684, 305);
			this.dataGrid1.TabIndex = 20;
			// 
			// tu
			// 
			this.tu.Location = new System.Drawing.Point(82, 304);
			this.tu.Maximum = new System.Decimal(new int[] {
															   9999999,
															   0,
															   0,
															   0});
			this.tu.Name = "tu";
			this.tu.Size = new System.Drawing.Size(64, 20);
			this.tu.TabIndex = 1;
			this.tu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
			// 
			// butSua
			// 
			this.butSua.Image = ((System.Drawing.Bitmap)(resources.GetObject("butSua.Image")));
			this.butSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butSua.Location = new System.Drawing.Point(275, 332);
			this.butSua.Name = "butSua";
			this.butSua.Size = new System.Drawing.Size(75, 28);
			this.butSua.TabIndex = 6;
			this.butSua.Text = "    &Sửa";
			this.butSua.Click += new System.EventHandler(this.butSua_Click);
			// 
			// butKetthuc
			// 
			this.butKetthuc.Image = ((System.Drawing.Bitmap)(resources.GetObject("butKetthuc.Image")));
			this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butKetthuc.Location = new System.Drawing.Point(353, 332);
			this.butKetthuc.Name = "butKetthuc";
			this.butKetthuc.Size = new System.Drawing.Size(77, 28);
			this.butKetthuc.TabIndex = 7;
			this.butKetthuc.Text = "     &Kết thúc";
			this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 302);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Từ số thứ tự :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// den
			// 
			this.den.Location = new System.Drawing.Point(184, 304);
			this.den.Maximum = new System.Decimal(new int[] {
																9999999,
																0,
																0,
																0});
			this.den.Name = "den";
			this.den.Size = new System.Drawing.Size(64, 20);
			this.den.TabIndex = 3;
			this.den.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(149, 302);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "đến :";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tt
			// 
			this.tt.Location = new System.Drawing.Point(312, 304);
			this.tt.Maximum = new System.Decimal(new int[] {
															   9999999,
															   0,
															   0,
															   0});
			this.tt.Name = "tt";
			this.tt.Size = new System.Drawing.Size(64, 20);
			this.tt.TabIndex = 5;
			this.tt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(240, 304);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Số bắt đầu :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// frmSuastt
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(704, 373);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.den,
																		  this.label3,
																		  this.tt,
																		  this.label2,
																		  this.label1,
																		  this.butKetthuc,
																		  this.butSua,
																		  this.tu,
																		  this.dataGrid1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmSuastt";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sửa số thứ tự";
			this.Load += new System.EventHandler(this.frmSuastt_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.den)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tt)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmSuastt_Load(object sender, System.EventArgs e)
		{
			string sql="select a.*,trim(a.ten)||' '||a.hamluong tenbd,b.ten tennhom,c.ten tenloai,d.ten tenhang,e.ten tennuoc,f.ten tenbo,g.ten nhomkt ";
            sql += " from " + ttb.user + ".ttb_dmbd a," + ttb.user + ".ttb_dmnhom b," + ttb.user + ".ttb_dmloai c," + ttb.user + ".ttb_dmhang d," + ttb.user + ".ttb_dmnuoc e," + ttb.user + ".ttb_nhombo f," + ttb.user + ".ttb_dmnhomkt g ";
			sql+=" where a.manhom=b.id and a.maloai=c.id and a.mahang=d.id and a.manuoc=e.id and a.nhombo=f.id(+) and a.sotk=g.id(+) and a.nhom="+i_nhom+" order by a.stt";
			dt=ttb.get_data(sql).Tables[0];
			dataGrid1.DataSource=dt;
			AddGridTableStyle();
		}

		private void AddGridTableStyle()
		{
			DataGridTableStyle ts =new DataGridTableStyle();
			ts.MappingName = dt.TableName;
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
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "stt";
			TextCol.HeaderText = "Stt";
			TextCol.Width = 40;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tenhc";
			TextCol.HeaderText = "Hoạt chất";
			TextCol.Width = (ttb.bHoatchat)?200:0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "ma";
			TextCol.HeaderText = "Mã";
			TextCol.Width = 53;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tenbd";
			TextCol.HeaderText = "Tên";
			TextCol.Width = 205;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "dang";
			TextCol.HeaderText = "ĐVT";
			TextCol.Width = 50;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tennhom";
			TextCol.HeaderText = "Nhóm";
			TextCol.Width = 100;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tenloai";
			TextCol.HeaderText = "Loại";
			TextCol.Width = 100;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tenhang";
			TextCol.HeaderText = "Hãng";
			TextCol.Width = 100;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);
		}

		private void butSua_Click(object sender, System.EventArgs e)
		{
			Cursor=Cursors.WaitCursor;
            int i=Convert.ToInt16(tu.Value),j=Convert.ToInt16(den.Value),stt=Convert.ToInt16(tt.Value);
			if (i>j && j!=0)
			{
				tu.Focus();
				return;
			}
			string sql="true";
			if (i+j>0) 
			{
				if (j==0)
					sql="stt>="+i;
				else
					sql="stt>="+i+" and stt<="+j;
			}
			foreach(DataRow r in dt.Select(sql))
			{
				r["stt"]=stt;
				ttb.execute_data("update ttb_dmbd set stt="+stt+" where id="+int.Parse(r["id"].ToString()));
				stt++;
			}
			Cursor=Cursors.Default;
		}

		private void butKetthuc_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void tu_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");		
		}
	}
}
