﻿using System;
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
	/// Summary description for rptThekho.
	/// </summary>
	public class frmDmbdkem : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button butKetthuc;
        private LibTTB.AccessData ttb;
		private int i_nhom,i_mabd,i_makp;
		private decimal i_id;
		private string s_mmyy,ngay,user;
		private DataSet dsdm=new DataSet();
		private DataTable dt=new DataTable();
		private System.Windows.Forms.DataGrid dataGrid1;
		private Brush disabledBackBrush;
		private Brush disabledTextBrush;
		private Brush alertBackBrush;
		private Font alertFont;
		private Brush alertTextBrush;
		private Font currentRowFont;
		private Brush currentRowBackBrush;
		bool afterCurrentCellChanged;
		int checkCol=0;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tim;
		private System.Windows.Forms.Button butLuu;
		private System.Windows.Forms.DataGrid dataGrid2;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmDmbdkem(AccessData acc,int nhom,decimal id,string title,string mmyy,string _ngay,int mabd,int makp)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			ttb=acc;s_mmyy=mmyy;ngay=_ngay;
			i_nhom=nhom;i_id=id;i_mabd=mabd;i_makp=makp;
			this.Text=title;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDmbdkem));
            this.butKetthuc = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.label4 = new System.Windows.Forms.Label();
            this.tim = new System.Windows.Forms.TextBox();
            this.butLuu = new System.Windows.Forms.Button();
            this.dataGrid2 = new System.Windows.Forms.DataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // butKetthuc
            // 
            this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butKetthuc.Location = new System.Drawing.Point(322, 380);
            this.butKetthuc.Name = "butKetthuc";
            this.butKetthuc.Size = new System.Drawing.Size(60, 25);
            this.butKetthuc.TabIndex = 4;
            this.butKetthuc.Text = "&Kết thúc";
            this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
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
            this.dataGrid1.Location = new System.Drawing.Point(5, 176);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.RowHeaderWidth = 5;
            this.dataGrid1.Size = new System.Drawing.Size(632, 168);
            this.dataGrid1.TabIndex = 23;
            this.dataGrid1.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
            this.dataGrid1.Click += new System.EventHandler(this.dataGrid1_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "&Tên mặt hàng :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tim
            // 
            this.tim.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tim.Location = new System.Drawing.Point(80, 348);
            this.tim.Name = "tim";
            this.tim.Size = new System.Drawing.Size(552, 21);
            this.tim.TabIndex = 1;
            this.tim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tim.TextChanged += new System.EventHandler(this.tim_TextChanged);
            this.tim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tim_KeyDown);
            // 
            // butLuu
            // 
            this.butLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butLuu.Location = new System.Drawing.Point(261, 380);
            this.butLuu.Name = "butLuu";
            this.butLuu.Size = new System.Drawing.Size(60, 25);
            this.butLuu.TabIndex = 2;
            this.butLuu.Text = "&Lưu";
            this.butLuu.Click += new System.EventHandler(this.butLuu_Click);
            // 
            // dataGrid2
            // 
            this.dataGrid2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid2.CaptionBackColor = System.Drawing.SystemColors.Control;
            this.dataGrid2.DataMember = "";
            this.dataGrid2.FlatMode = true;
            this.dataGrid2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid2.Location = new System.Drawing.Point(5, -12);
            this.dataGrid2.Name = "dataGrid2";
            this.dataGrid2.RowHeaderWidth = 3;
            this.dataGrid2.Size = new System.Drawing.Size(632, 190);
            this.dataGrid2.TabIndex = 27;
            // 
            // frmDmbdkem
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(642, 423);
            this.Controls.Add(this.dataGrid2);
            this.Controls.Add(this.butLuu);
            this.Controls.Add(this.tim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.butKetthuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDmbdkem";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Những mặt hàng tương đương";
            this.Load += new System.EventHandler(this.frmDmbdkem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void frmDmbdkem_Load(object sender, System.EventArgs e)
		{
            user = ttb.user;
            dsdm = ttb.create_dmkemtheo();
			load_grid();
			AddGridTableStyle();

			this.disabledBackBrush = new SolidBrush(Color.FromArgb(255,255,192));
			this.disabledTextBrush = new SolidBrush(Color.FromArgb(255,0,0));

			this.alertBackBrush = new SolidBrush(SystemColors.HotTrack);
			this.alertFont = new Font(this.dataGrid1.Font.Name, this.dataGrid1.Font.Size, FontStyle.Bold);
			this.alertTextBrush = new SolidBrush(Color.White);
			
			this.currentRowFont = new Font(this.dataGrid1.Font.Name, this.dataGrid1.Font.Size, FontStyle.Regular);
			this.currentRowBackBrush = new SolidBrush(Color.FromArgb(0,255, 255));

			load_kem();
			AddGridTableStyle1();
		}
        
		private void load_kem()
		{
			string sql="select a.stt,to_char(a.ngay,'dd/mm/yyyy') as ngay,a.mabd,a.diengiai,trim(b.ten)||' '||b.hamluong as ten,b.dang,c.ten as tenhang,d.ten as tennuoc";
            sql += " from " + user + ".ttb_tscdkem a," + user + ".ttb_dmbd b," + user + ".ttb_dmhang c," + user + ".ttb_dmnuoc d";
			sql+=" where a.mabd=b.id and b.mahang=c.id and b.manuoc=d.id";
			sql+=" and a.id="+i_id+" order by a.stt desc";
			dt=ttb.get_data(sql).Tables[0];
			dataGrid2.DataSource=dt;
		}

		private void AddGridTableStyle1()
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
			TextCol.HeaderText = "stt";
			TextCol.Width = 20;
			TextCol.ReadOnly=true;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid2.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "ngay";
			TextCol.HeaderText = "Ngày";
			TextCol.Width = 65;
			TextCol.ReadOnly=true;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid2.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "ten";
			TextCol.HeaderText = "Tên";
			TextCol.Width = 150;
			TextCol.ReadOnly=true;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid2.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tenhang";
			TextCol.HeaderText = "Hãng";
			TextCol.Width = 100;
			TextCol.ReadOnly=true;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid2.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "diengiai";
			TextCol.HeaderText = "Ghi chú";
			TextCol.Width = 265;
			TextCol.ReadOnly=false;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid2.TableStyles.Add(ts);
		}

		private void butKetthuc_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void AddGridTableStyle()
		{
			DataGridTableStyle ts =new DataGridTableStyle();
			ts.MappingName = dsdm.Tables[0].TableName;
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
			TextCol.MappingName = "ma";
			TextCol.HeaderText = "Mã số";
			TextCol.Width =50;
			TextCol.ReadOnly=true;
			TextCol.SetCellFormat += new FormatCellEventHandler(SetCellFormat);
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new FormattableTextBoxColumn();
			TextCol.MappingName = "ten";
			TextCol.HeaderText = "Tên";
			TextCol.Width = 255;
			TextCol.ReadOnly=true;
			TextCol.SetCellFormat += new FormatCellEventHandler(SetCellFormat);
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new FormattableTextBoxColumn();
			TextCol.MappingName = "dang";
			TextCol.HeaderText = "ĐVT";
			TextCol.Width = 50;
			TextCol.ReadOnly=true;
			TextCol.SetCellFormat += new FormatCellEventHandler(SetCellFormat);
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

            TextCol = new FormattableTextBoxColumn();
            TextCol.MappingName = "tennhom";
            TextCol.HeaderText = "Số hiệu";
            TextCol.Width = 55;
            TextCol.ReadOnly = true;
            TextCol.SetCellFormat += new FormatCellEventHandler(SetCellFormat);
            ts.GridColumnStyles.Add(TextCol);
            dataGrid1.TableStyles.Add(ts);

			TextCol=new FormattableTextBoxColumn();
			TextCol.MappingName = "tenhang";
			TextCol.HeaderText = "Hãng";
			TextCol.Width = 100;
			TextCol.ReadOnly=true;
			TextCol.SetCellFormat += new FormatCellEventHandler(SetCellFormat);
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new FormattableTextBoxColumn();
			TextCol.MappingName = "soluong";
			TextCol.HeaderText = "Số lượng";
			TextCol.Width = 60;
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
					//e.BackBrush = this.disabledBackBrush;
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

		private void load_grid()
		{
			dsdm.Clear();
            dsdm = ttb.get_data("select to_number(a.id) id,a.ma,trim(a.ten)||' '||a.hamluong as ten,a.dang,a.tenhc,t.losx as tennhom,b.ten as tenhang,c.tondau+c.slnhap-c.slxuat as soluong from " + user + ".ttb_dmbd a," + user + ".ttb_dmhang b," + user + ".ttb_tutrucct c," + user + ".ttb_theodoi t where c.mmyy='" + s_mmyy + "' and a.id=c.mabd and a.mahang=b.id and a.nhom=" + i_nhom + " and a.id<>" + i_mabd + " and c.makp=" + i_makp + " and c.stt=t.id order by a.ten");
            dsdm.Tables[0].Columns.Add("chon", typeof(bool));
			dataGrid1.DataSource=dsdm.Tables[0];
			CurrencyManager cm = (CurrencyManager)BindingContext[dataGrid1.DataSource,dataGrid1.DataMember]; 
			DataView dv = (DataView) cm.List; 
			dv.AllowNew = false;
            foreach (DataRow row in dsdm.Tables[0].Rows) { row["chon"] = false; }
		}

		private void tim_TextChanged(object sender, System.EventArgs e)
		{
			if (this.ActiveControl==tim)
			{
				CurrencyManager cm= (CurrencyManager)BindingContext[dataGrid1.DataSource];
				DataView dv=(DataView)cm.List;
				if (tim.Text!="")
					dv.RowFilter="ten like '%"+tim.Text.Trim()+"%' or ma like '%"+tim.Text.Trim()+"%' or tennhom like '%"+tim.Text.Trim()+"%'";
				else
					dv.RowFilter="";
			}
		}

		private void tim_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter || e.KeyCode==Keys.Tab) dataGrid1.Focus();
		}

		private void butLuu_Click(object sender, System.EventArgs e)
		{
			dsdm.AcceptChanges();
			if (dsdm.Tables[0].Select("chon=true").Length>0)
			{
				foreach(DataRow r in dsdm.Tables[0].Select("chon=true")) 
				{
					ttb.upd_tscdkem(i_id,ttb.get_stt_tscd(i_id,"ttb_tscdkem"),ngay,int.Parse(r["id"].ToString()),"");
					load_kem();
				}
				foreach (DataRow row in dsdm.Tables[0].Rows) row["chon"]=false;
			}
			else 
				foreach(DataRow r in dt.Rows) ttb.upd_tscdkem(i_id,int.Parse(r["stt"].ToString()),r["ngay"].ToString(),int.Parse(r["mabd"].ToString()),r["diengiai"].ToString());
		}
	}
}
