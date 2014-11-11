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
	/// Summary description for frmDm.
	/// </summary>
	public class frmKinhphi : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button butKetthuc;
        private LibTTB.AccessData ttb;
		private DataTable dt=new DataTable();
		private System.Windows.Forms.Button butLuu;
		private System.Windows.Forms.Button butBoqua;
		private int i_nhom;
		private string s_yy,user;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox sotien;
		private System.Windows.Forms.TextBox dasudung;
		private System.Windows.Forms.TextBox conlai;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmKinhphi(AccessData acc,int nhom,string yy)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			ttb=acc;i_nhom=nhom;s_yy=yy;
			this.Text+=" 20"+s_yy;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKinhphi));
            this.butKetthuc = new System.Windows.Forms.Button();
            this.butLuu = new System.Windows.Forms.Button();
            this.butBoqua = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.sotien = new System.Windows.Forms.TextBox();
            this.dasudung = new System.Windows.Forms.TextBox();
            this.conlai = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // butKetthuc
            // 
            this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butKetthuc.Location = new System.Drawing.Point(427, 490);
            this.butKetthuc.Name = "butKetthuc";
            this.butKetthuc.Size = new System.Drawing.Size(60, 25);
            this.butKetthuc.TabIndex = 10;
            this.butKetthuc.Text = "&Kết thúc";
            this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
            // 
            // butLuu
            // 
            this.butLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butLuu.Location = new System.Drawing.Point(305, 490);
            this.butLuu.Name = "butLuu";
            this.butLuu.Size = new System.Drawing.Size(60, 25);
            this.butLuu.TabIndex = 5;
            this.butLuu.Text = "&Lưu";
            this.butLuu.Click += new System.EventHandler(this.butLuu_Click);
            // 
            // butBoqua
            // 
            this.butBoqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butBoqua.Location = new System.Drawing.Point(366, 490);
            this.butBoqua.Name = "butBoqua";
            this.butBoqua.Size = new System.Drawing.Size(60, 25);
            this.butBoqua.TabIndex = 6;
            this.butBoqua.Text = "&Bỏ qua";
            this.butBoqua.Click += new System.EventHandler(this.butBoqua_Click);
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
            this.dataGrid1.Location = new System.Drawing.Point(5, -16);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.RowHeaderWidth = 3;
            this.dataGrid1.Size = new System.Drawing.Size(783, 472);
            this.dataGrid1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(120, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "TỔNG CỘNG :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sotien
            // 
            this.sotien.Enabled = false;
            this.sotien.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sotien.Location = new System.Drawing.Point(376, 463);
            this.sotien.Name = "sotien";
            this.sotien.Size = new System.Drawing.Size(130, 21);
            this.sotien.TabIndex = 27;
            this.sotien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dasudung
            // 
            this.dasudung.Enabled = false;
            this.dasudung.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dasudung.Location = new System.Drawing.Point(508, 463);
            this.dasudung.Name = "dasudung";
            this.dasudung.Size = new System.Drawing.Size(130, 21);
            this.dasudung.TabIndex = 28;
            this.dasudung.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // conlai
            // 
            this.conlai.Enabled = false;
            this.conlai.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conlai.Location = new System.Drawing.Point(640, 463);
            this.conlai.Name = "conlai";
            this.conlai.Size = new System.Drawing.Size(130, 21);
            this.conlai.TabIndex = 29;
            this.conlai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmKinhphi
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.conlai);
            this.Controls.Add(this.dasudung);
            this.Controls.Add(this.sotien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.butBoqua);
            this.Controls.Add(this.butLuu);
            this.Controls.Add(this.butKetthuc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmKinhphi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kinh phí mua sắm trong năm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmKinhphi_KeyDown);
            this.Load += new System.EventHandler(this.frmKinhphi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void frmKinhphi_Load(object sender, System.EventArgs e)
		{
            if (Screen.PrimaryScreen.WorkingArea.Width > 800) this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            user = ttb.user;
			load_grid();
			AddGridTableStyle();
		}

		private void load_grid()
		{
			dt=ttb.get_data("select a.*,0000000000 as sotien,0000000000.000 as dasudung,0000000000.000 as conlai from "+user+".ttb_dmnhom a where a.nhom="+i_nhom+" order by a.stt").Tables[0];
			DataRow r1;
			foreach(DataRow r in ttb.get_data("select * from "+user+".ttb_kinhphi where nhom="+i_nhom+" and yy='"+s_yy+"'").Tables[0].Rows)
			{
				r1=ttb.getrowbyid(dt,"id="+int.Parse(r["id_nhom"].ToString()));
				if (r1!=null)
				{
					r1["sotien"]=r["sotien"].ToString();
					r1["dasudung"]=r["dasudung"].ToString();
					r1["conlai"]=decimal.Parse(r["sotien"].ToString())-decimal.Parse(r["dasudung"].ToString());
				}
			}
			dataGrid1.DataSource=dt;
			CurrencyManager cm = (CurrencyManager)BindingContext[dataGrid1.DataSource,dataGrid1.DataMember]; 
			DataView dv = (DataView) cm.List; 
			dv.AllowNew = false; 
			sum();
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
			TextCol.MappingName = "stt";
			TextCol.HeaderText = "STT";
			TextCol.Width = 50;
			TextCol.ReadOnly=true;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "ten";
			TextCol.HeaderText = "Nội dung";
			TextCol.Width = 310;
			TextCol.ReadOnly=true;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "sotien";
			TextCol.HeaderText = "Kinh phí";
			TextCol.Width = 130;
			TextCol.Format="###,###,###,##0";
			TextCol.Alignment=HorizontalAlignment.Right;
			TextCol.ReadOnly=false;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "dasudung";
			TextCol.HeaderText = "Đã sử dụng";
			TextCol.Width = 130;
			TextCol.Format="###,###,###,##0.000";
			TextCol.Alignment=HorizontalAlignment.Right;
			TextCol.ReadOnly=true;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "conlai";
			TextCol.HeaderText = "Còn lại";
			TextCol.Width = 130;
			TextCol.Format="###,###,###,##0.000";
			TextCol.Alignment=HorizontalAlignment.Right;
			TextCol.ReadOnly=true;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);
		}

		private void butKetthuc_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void butLuu_Click(object sender, System.EventArgs e)
		{
			dt.AcceptChanges();
			ttb.execute_data("update "+user+".ttb_kinhphi set sotien=0 where yy='"+s_yy+"'");
			foreach(DataRow r in dt.Select("sotien<>0 or dasudung<>0","id"))
				ttb.upd_kinhphi(i_nhom,s_yy,int.Parse(r["id"].ToString()),decimal.Parse(r["sotien"].ToString()));
			load_grid();
		}

		private void frmKinhphi_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.F10) butKetthuc_Click(sender,e);
		}

		private void butBoqua_Click(object sender, System.EventArgs e)
		{
			load_grid();
		}

		private void sum()
		{
			decimal d1=0,d2=0,d3=0;
			foreach(DataRow r in dt.Select("sotien<>0 or dasudung<>0"))
			{
				d1+=decimal.Parse(r["sotien"].ToString());
				d2+=decimal.Parse(r["dasudung"].ToString());
				d3+=decimal.Parse(r["conlai"].ToString());
			}
			sotien.Text=d1.ToString("###,###,###,##0");
			dasudung.Text=d2.ToString("###,###,###,##0.000");
			conlai.Text=d3.ToString("###,###,###,##0.000");
		}
	}
}
