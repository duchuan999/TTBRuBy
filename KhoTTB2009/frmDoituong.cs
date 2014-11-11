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
	public class frmDoituong : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button butKetthuc;
        private LibTTB.AccessData ttb;
		private DataTable dt=new DataTable();
		private DataTable dtnguon=new DataTable();
		private DataTable dtnhom=new DataTable();
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button butMoi;
		private System.Windows.Forms.Button butSua;
		private System.Windows.Forms.Button butLuu;
		private System.Windows.Forms.Button butBoqua;
		private System.Windows.Forms.Button butHuy;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown stt;
		private string table,s_nguon,s_nhom;
		private int i_nhom;
		private System.Windows.Forms.TextBox ten;
		private System.Windows.Forms.CheckedListBox nguon;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox loai;
		private System.Windows.Forms.CheckedListBox manhom;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmDoituong(AccessData acc,string tab,int nhom)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			ttb=acc;
			table=tab;
			i_nhom=nhom;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmDoituong));
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.butKetthuc = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.ten = new System.Windows.Forms.TextBox();
			this.butMoi = new System.Windows.Forms.Button();
			this.butSua = new System.Windows.Forms.Button();
			this.butLuu = new System.Windows.Forms.Button();
			this.butBoqua = new System.Windows.Forms.Button();
			this.butHuy = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.stt = new System.Windows.Forms.NumericUpDown();
			this.nguon = new System.Windows.Forms.CheckedListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.loai = new System.Windows.Forms.ComboBox();
			this.manhom = new System.Windows.Forms.CheckedListBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.stt)).BeginInit();
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
			this.dataGrid1.Location = new System.Drawing.Point(8, -13);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro;
			this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.RowHeaderWidth = 10;
			this.dataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue;
			this.dataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
			this.dataGrid1.Size = new System.Drawing.Size(568, 469);
			this.dataGrid1.TabIndex = 19;
			this.dataGrid1.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
			// 
			// butKetthuc
			// 
			this.butKetthuc.Image = ((System.Drawing.Bitmap)(resources.GetObject("butKetthuc.Image")));
			this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butKetthuc.Location = new System.Drawing.Point(549, 490);
			this.butKetthuc.Name = "butKetthuc";
			this.butKetthuc.Size = new System.Drawing.Size(75, 28);
			this.butKetthuc.TabIndex = 8;
			this.butKetthuc.Text = "&Kết thúc";
			this.butKetthuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(88, 462);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 23);
			this.label2.TabIndex = 23;
			this.label2.Text = "Tên :";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ten
			// 
			this.ten.BackColor = System.Drawing.SystemColors.HighlightText;
			this.ten.Enabled = false;
			this.ten.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ten.Location = new System.Drawing.Point(120, 462);
			this.ten.Name = "ten";
			this.ten.Size = new System.Drawing.Size(376, 21);
			this.ten.TabIndex = 1;
			this.ten.Text = "";
			this.ten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ten_KeyDown);
			// 
			// butMoi
			// 
			this.butMoi.Image = ((System.Drawing.Bitmap)(resources.GetObject("butMoi.Image")));
			this.butMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butMoi.Location = new System.Drawing.Point(169, 490);
			this.butMoi.Name = "butMoi";
			this.butMoi.Size = new System.Drawing.Size(75, 28);
			this.butMoi.TabIndex = 5;
			this.butMoi.Text = "          &Mới";
			this.butMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butMoi.Click += new System.EventHandler(this.butMoi_Click);
			// 
			// butSua
			// 
			this.butSua.Image = ((System.Drawing.Bitmap)(resources.GetObject("butSua.Image")));
			this.butSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butSua.Location = new System.Drawing.Point(245, 490);
			this.butSua.Name = "butSua";
			this.butSua.Size = new System.Drawing.Size(75, 28);
			this.butSua.TabIndex = 6;
			this.butSua.Text = "         &Sửa";
			this.butSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butSua.Click += new System.EventHandler(this.butSua_Click);
			// 
			// butLuu
			// 
			this.butLuu.Enabled = false;
			this.butLuu.Image = ((System.Drawing.Bitmap)(resources.GetObject("butLuu.Image")));
			this.butLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butLuu.Location = new System.Drawing.Point(321, 490);
			this.butLuu.Name = "butLuu";
			this.butLuu.Size = new System.Drawing.Size(75, 28);
			this.butLuu.TabIndex = 3;
			this.butLuu.Text = "           &Lưu";
			this.butLuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butLuu.Click += new System.EventHandler(this.butLuu_Click);
			// 
			// butBoqua
			// 
			this.butBoqua.Enabled = false;
			this.butBoqua.Image = ((System.Drawing.Bitmap)(resources.GetObject("butBoqua.Image")));
			this.butBoqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butBoqua.Location = new System.Drawing.Point(397, 490);
			this.butBoqua.Name = "butBoqua";
			this.butBoqua.Size = new System.Drawing.Size(75, 28);
			this.butBoqua.TabIndex = 4;
			this.butBoqua.Text = "&Bỏ qua";
			this.butBoqua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.butBoqua.Click += new System.EventHandler(this.butBoqua_Click);
			// 
			// butHuy
			// 
			this.butHuy.Image = ((System.Drawing.Bitmap)(resources.GetObject("butHuy.Image")));
			this.butHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butHuy.Location = new System.Drawing.Point(473, 490);
			this.butHuy.Name = "butHuy";
			this.butHuy.Size = new System.Drawing.Size(75, 28);
			this.butHuy.TabIndex = 7;
			this.butHuy.Text = "          &Hủy";
			this.butHuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butHuy.Click += new System.EventHandler(this.butHuy_Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 462);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 23);
			this.label3.TabIndex = 24;
			this.label3.Text = "Mã :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// stt
			// 
			this.stt.Enabled = false;
			this.stt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.stt.Location = new System.Drawing.Point(40, 462);
			this.stt.Name = "stt";
			this.stt.Size = new System.Drawing.Size(40, 21);
			this.stt.TabIndex = 0;
			this.stt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stt_KeyDown);
			// 
			// nguon
			// 
			this.nguon.CheckOnClick = true;
			this.nguon.Enabled = false;
			this.nguon.Location = new System.Drawing.Point(585, 5);
			this.nguon.Name = "nguon";
			this.nguon.Size = new System.Drawing.Size(200, 229);
			this.nguon.TabIndex = 31;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(496, 462);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 23);
			this.label1.TabIndex = 32;
			this.label1.Text = "Thanh toán theo :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// loai
			// 
			this.loai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.loai.Enabled = false;
			this.loai.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.loai.Items.AddRange(new object[] {
													  "Giá mua",
													  "Giá bán"});
			this.loai.Location = new System.Drawing.Point(584, 462);
			this.loai.Name = "loai";
			this.loai.Size = new System.Drawing.Size(200, 21);
			this.loai.TabIndex = 2;
			this.loai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loai_KeyDown);
			// 
			// manhom
			// 
			this.manhom.CheckOnClick = true;
			this.manhom.Enabled = false;
			this.manhom.Location = new System.Drawing.Point(585, 236);
			this.manhom.Name = "manhom";
			this.manhom.Size = new System.Drawing.Size(200, 214);
			this.manhom.TabIndex = 33;
			// 
			// frmDoituong
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(792, 573);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.manhom,
																		  this.loai,
																		  this.label1,
																		  this.nguon,
																		  this.stt,
																		  this.label3,
																		  this.ten,
																		  this.butHuy,
																		  this.butBoqua,
																		  this.butLuu,
																		  this.butSua,
																		  this.butMoi,
																		  this.label2,
																		  this.butKetthuc,
																		  this.dataGrid1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmDoituong";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đối tượng";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDoituong_KeyDown);
			this.Load += new System.EventHandler(this.frmDoituong_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.stt)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmDoituong_Load(object sender, System.EventArgs e)
		{
			dtnguon=ttb.get_data("select * from ttb_dmnguon where nhom="+i_nhom+" order by stt").Tables[0];
			nguon.DisplayMember="TEN";
			nguon.ValueMember="ID";
			nguon.DataSource=dtnguon;
			dtnhom=ttb.get_data("select * from ttb_dmnhom where nhom="+i_nhom+" order by stt").Tables[0];
			manhom.DisplayMember="TEN";
			manhom.ValueMember="ID";
			manhom.DataSource=dtnhom;
			load_grid();
			AddGridTableStyle();
			ref_text();
		}

		private void load_grid()
		{
			dt=ttb.get_data("select madoituong,doituong,nguon,loai,decode(loai,0,'Giá mua','Giá bán') tenloai,manhom from "+table+" order by madoituong").Tables[0];
			dataGrid1.DataSource=dt;
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
			TextCol.MappingName = "madoituong";
			TextCol.HeaderText = "Mã";
			TextCol.Width = 30;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "doituong";
			TextCol.HeaderText = "Tên";
			TextCol.Width = 420;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "nguon";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "loai";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tenloai";
			TextCol.HeaderText = "Thanh toán theo";
			TextCol.Width = 100;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "manhom";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);
		}

		private void butKetthuc_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void ten_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");
		}

		private void ena_object(bool ena)
		{
			dataGrid1.Enabled=!ena;
			//stt.Enabled=ena;
			nguon.Enabled=ena;
			manhom.Enabled=ena;
			ten.Enabled=ena;
			loai.Enabled=ena;
			butMoi.Enabled=!ena;
			butSua.Enabled=!ena;
			butLuu.Enabled=ena;
			butBoqua.Enabled=ena;
			butHuy.Enabled=!ena;
			butKetthuc.Enabled=!ena;
		}

		private void butMoi_Click(object sender, System.EventArgs e)
		{
			try
			{
				stt.Value=decimal.Parse(ttb.get_data("select max(madoituong) from "+table).Tables[0].Rows[0][0].ToString())+1;
			}
			catch{stt.Value=1;}
			for(int k=0;k<nguon.Items.Count;k++) nguon.SetItemCheckState(k,CheckState.Unchecked);
			for(int k=0;k<manhom.Items.Count;k++) manhom.SetItemCheckState(k,CheckState.Unchecked);
			ten.Text="";
			loai.SelectedIndex=0;
			ena_object(true);
			ten.Focus();
		}

		private void butSua_Click(object sender, System.EventArgs e)
		{
			if (dt.Rows.Count==0) return;
			ena_object(true);
			ten.Focus();
		}

		private bool kiemtra()
		{
			if (ten.Text=="")
			{
				ten.Focus();
				return false;
			}
			if (loai.SelectedIndex==-1)
			{
				loai.Focus();
				return false;
			}
			s_nguon="";
			for(int i=0;i<nguon.Items.Count;i++)
				if (nguon.GetItemChecked(i)) s_nguon+=dtnguon.Rows[i]["id"].ToString().Trim()+",";
			s_nhom="";
			for(int i=0;i<manhom.Items.Count;i++)
				if (manhom.GetItemChecked(i)) s_nhom+=dtnhom.Rows[i]["id"].ToString().Trim()+",";
			return true;
		}

		private void butLuu_Click(object sender, System.EventArgs e)
		{
			if (!kiemtra()) return ;
			if (!ttb.upd_doituong(table,int.Parse(stt.Value.ToString()),ten.Text.Trim(),s_nguon,loai.SelectedIndex,s_nhom,""))
			{
				MessageBox.Show("Không cập nhật thông tin "+this.Text.Trim()+" !",ttb.Msg);
				return;
			}
            load_grid();
			ena_object(false);
		}

		private void butBoqua_Click(object sender, System.EventArgs e)
		{
			ref_text();
			ena_object(false);
		}

		private void butHuy_Click(object sender, System.EventArgs e)
		{
			if (dt.Rows.Count==1)
			{
				MessageBox.Show("Không cho phép hủy ?",ttb.Msg);
				return;
			}	
			try
			{
				if (ttb.get_data("select * from ttb_xuatsdct where madoituong="+int.Parse(dataGrid1[dataGrid1.CurrentCell.RowNumber,0].ToString())).Tables[0].Rows.Count!=0)
				{
					MessageBox.Show("Nội dung đang sử dụng không cho phép hủy !",ttb.Msg);
					return;
				}
			}
			catch{}
			if (MessageBox.Show("Đồng ý hủy thông tin này !",ttb.Msg,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
			{
				ttb.execute_data("delete from "+table+" where madoituong="+int.Parse(dataGrid1[dataGrid1.CurrentCell.RowNumber,0].ToString()));
				load_grid();
			}
		}

		private void ref_text()
		{
			try
			{
				int i=dataGrid1.CurrentCell.RowNumber;
				stt.Value=decimal.Parse(dataGrid1[i,0].ToString());
				ten.Text=dataGrid1[i,1].ToString();
				s_nguon=","+dataGrid1[i,2].ToString();
				for(int j=0;j<dtnguon.Rows.Count;j++)
					if (s_nguon.IndexOf(","+dtnguon.Rows[j]["id"].ToString().Trim()+",")!=-1) nguon.SetItemCheckState(j,CheckState.Checked);
					else nguon.SetItemCheckState(j,CheckState.Unchecked);
				loai.SelectedIndex=int.Parse(dataGrid1[i,3].ToString());
				s_nhom=","+dataGrid1[i,5].ToString();
				for(int j=0;j<dtnhom.Rows.Count;j++)
					if (s_nhom.IndexOf(","+dtnhom.Rows[j]["id"].ToString().Trim()+",")!=-1) manhom.SetItemCheckState(j,CheckState.Checked);
					else manhom.SetItemCheckState(j,CheckState.Unchecked);
			}
			catch{}
		}

		private void dataGrid1_CurrentCellChanged(object sender, System.EventArgs e)
		{
			ref_text();
		}

		private void frmDoituong_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.F10) butKetthuc_Click(sender,e);
		}

		private void stt_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");		
		}

		private void loai_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Tab || e.KeyCode==Keys.Enter)
			{
				if (loai.SelectedIndex==-1 && loai.Items.Count>0) loai.SelectedIndex=0;
				SendKeys.Send("{Tab}");
			}
		}
	}
}
