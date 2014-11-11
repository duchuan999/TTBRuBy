using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using LibTTB;

namespace Duoc
{
	/// <summary>
	/// Summary description for frmDm.
	/// </summary>
	public class frmDuockp : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button butKetthuc;
        private LibTTB.AccessData ttb;
        private LibMedi.AccessData m=new LibMedi.AccessData();
        private LibDuoc.AccessData d = new LibDuoc.AccessData();
		private DataTable dt=new DataTable();
		private DataSet dsxml=new DataSet();
		private DataRow r;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button butMoi;
		private System.Windows.Forms.Button butSua;
		private System.Windows.Forms.Button butLuu;
		private System.Windows.Forms.Button butBoqua;
		private System.Windows.Forms.Button butHuy;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown stt;
		private int i_id,i_matutruc,i_nhom,i_userid,itable,i_makp;
		private string table,s_makho,s_nhomkho,sql,user,d_mmyy;
		private System.Windows.Forms.TextBox ten;
		private System.Windows.Forms.TextBox ma;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox makp;
		private System.Windows.Forms.CheckedListBox makho;
		private DataTable dtkho=new DataTable();
		private DataTable dtnhom=new DataTable();
		private System.Windows.Forms.CheckedListBox nhomkho;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox matutruc;
		private System.Windows.Forms.TextBox nguoilinh;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.CheckBox chkAll;
		private System.Windows.Forms.ComboBox computer;
		private System.Windows.Forms.Label label6;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmDuockp(AccessData acc,string tab,string title,int nhom,int userid,string mmyy)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            ttb = acc; this.Text = title; table = tab; i_nhom = nhom; i_userid = userid; d_mmyy = mmyy;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDuockp));
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
            this.ma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.makp = new System.Windows.Forms.ComboBox();
            this.makho = new System.Windows.Forms.CheckedListBox();
            this.nhomkho = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.matutruc = new System.Windows.Forms.ComboBox();
            this.nguoilinh = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.computer = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.dataGrid1.CaptionFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid1.CaptionForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid1.DataMember = "";
            this.dataGrid1.FlatMode = true;
            this.dataGrid1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dataGrid1.Size = new System.Drawing.Size(624, 445);
            this.dataGrid1.TabIndex = 19;
            this.dataGrid1.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
            // 
            // butKetthuc
            // 
            this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butKetthuc.Location = new System.Drawing.Point(521, 490);
            this.butKetthuc.Name = "butKetthuc";
            this.butKetthuc.Size = new System.Drawing.Size(60, 25);
            this.butKetthuc.TabIndex = 12;
            this.butKetthuc.Text = "&Kết thúc";
            this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(208, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tên :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ten
            // 
            this.ten.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ten.Enabled = false;
            this.ten.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ten.Location = new System.Drawing.Point(240, 438);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(256, 21);
            this.ten.TabIndex = 2;
            this.ten.Validated += new System.EventHandler(this.ten_Validated);
            this.ten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ten_KeyDown);
            // 
            // butMoi
            // 
            this.butMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butMoi.Location = new System.Drawing.Point(211, 490);
            this.butMoi.Name = "butMoi";
            this.butMoi.Size = new System.Drawing.Size(60, 25);
            this.butMoi.TabIndex = 9;
            this.butMoi.Text = "&Mới";
            this.butMoi.Click += new System.EventHandler(this.butMoi_Click);
            // 
            // butSua
            // 
            this.butSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butSua.Location = new System.Drawing.Point(273, 490);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(60, 25);
            this.butSua.TabIndex = 10;
            this.butSua.Text = "&Sửa";
            this.butSua.Click += new System.EventHandler(this.butSua_Click);
            // 
            // butLuu
            // 
            this.butLuu.Enabled = false;
            this.butLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butLuu.Location = new System.Drawing.Point(335, 490);
            this.butLuu.Name = "butLuu";
            this.butLuu.Size = new System.Drawing.Size(60, 25);
            this.butLuu.TabIndex = 7;
            this.butLuu.Text = "&Lưu";
            this.butLuu.Click += new System.EventHandler(this.butLuu_Click);
            // 
            // butBoqua
            // 
            this.butBoqua.Enabled = false;
            this.butBoqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butBoqua.Location = new System.Drawing.Point(397, 490);
            this.butBoqua.Name = "butBoqua";
            this.butBoqua.Size = new System.Drawing.Size(60, 25);
            this.butBoqua.TabIndex = 8;
            this.butBoqua.Text = "&Bỏ qua";
            this.butBoqua.Click += new System.EventHandler(this.butBoqua_Click);
            // 
            // butHuy
            // 
            this.butHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butHuy.Location = new System.Drawing.Point(459, 490);
            this.butHuy.Name = "butHuy";
            this.butHuy.Size = new System.Drawing.Size(60, 25);
            this.butHuy.TabIndex = 11;
            this.butHuy.Text = "&Hủy";
            this.butHuy.Click += new System.EventHandler(this.butHuy_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "STT :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stt
            // 
            this.stt.Enabled = false;
            this.stt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stt.Location = new System.Drawing.Point(32, 438);
            this.stt.Name = "stt";
            this.stt.Size = new System.Drawing.Size(40, 21);
            this.stt.TabIndex = 0;
            this.stt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stt_KeyDown);
            // 
            // ma
            // 
            this.ma.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ma.Enabled = false;
            this.ma.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ma.Location = new System.Drawing.Point(96, 438);
            this.ma.MaxLength = 50;
            this.ma.Name = "ma";
            this.ma.Size = new System.Drawing.Size(112, 21);
            this.ma.TabIndex = 1;
            this.ma.Validated += new System.EventHandler(this.ma_Validated);
            this.ma.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ma_KeyDown);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(64, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(488, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Khoa lâm sàng :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // makp
            // 
            this.makp.BackColor = System.Drawing.SystemColors.HighlightText;
            this.makp.Enabled = false;
            this.makp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makp.Location = new System.Drawing.Point(576, 438);
            this.makp.Name = "makp";
            this.makp.Size = new System.Drawing.Size(208, 21);
            this.makp.TabIndex = 3;
            this.makp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.makp_KeyDown);
            // 
            // makho
            // 
            this.makho.BackColor = System.Drawing.SystemColors.HighlightText;
            this.makho.CheckOnClick = true;
            this.makho.Enabled = false;
            this.makho.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makho.Location = new System.Drawing.Point(637, 141);
            this.makho.Name = "makho";
            this.makho.Size = new System.Drawing.Size(147, 292);
            this.makho.TabIndex = 28;
            // 
            // nhomkho
            // 
            this.nhomkho.BackColor = System.Drawing.SystemColors.HighlightText;
            this.nhomkho.CheckOnClick = true;
            this.nhomkho.Enabled = false;
            this.nhomkho.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhomkho.Location = new System.Drawing.Point(637, 5);
            this.nhomkho.Name = "nhomkho";
            this.nhomkho.Size = new System.Drawing.Size(147, 132);
            this.nhomkho.TabIndex = 29;
            this.nhomkho.SelectedIndexChanged += new System.EventHandler(this.nhomkho_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(-8, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "Sử dụng thêm tủ trực :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // matutruc
            // 
            this.matutruc.BackColor = System.Drawing.SystemColors.HighlightText;
            this.matutruc.Enabled = false;
            this.matutruc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matutruc.Location = new System.Drawing.Point(112, 461);
            this.matutruc.Name = "matutruc";
            this.matutruc.Size = new System.Drawing.Size(208, 21);
            this.matutruc.TabIndex = 4;
            this.matutruc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.matutruc_KeyDown);
            // 
            // nguoilinh
            // 
            this.nguoilinh.Enabled = false;
            this.nguoilinh.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nguoilinh.Location = new System.Drawing.Point(384, 461);
            this.nguoilinh.Name = "nguoilinh";
            this.nguoilinh.Size = new System.Drawing.Size(224, 21);
            this.nguoilinh.TabIndex = 5;
            this.nguoilinh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ma_KeyDown);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(320, 461);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 23);
            this.label11.TabIndex = 31;
            this.label11.Text = "Người lĩnh :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkAll
            // 
            this.chkAll.Checked = true;
            this.chkAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAll.Location = new System.Drawing.Point(680, 490);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(104, 22);
            this.chkAll.TabIndex = 32;
            this.chkAll.Text = "Xem tất cả";
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // computer
            // 
            this.computer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.computer.Enabled = false;
            this.computer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computer.Location = new System.Drawing.Point(664, 461);
            this.computer.Name = "computer";
            this.computer.Size = new System.Drawing.Size(120, 21);
            this.computer.TabIndex = 6;
            this.computer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stt_KeyDown);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(608, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 23);
            this.label6.TabIndex = 34;
            this.label6.Text = "Tên máy :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmDuockp
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.computer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.nguoilinh);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.matutruc);
            this.Controls.Add(this.makp);
            this.Controls.Add(this.ten);
            this.Controls.Add(this.stt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nhomkho);
            this.Controls.Add(this.makho);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butHuy);
            this.Controls.Add(this.butBoqua);
            this.Controls.Add(this.butLuu);
            this.Controls.Add(this.butSua);
            this.Controls.Add(this.butMoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butKetthuc);
            this.Controls.Add(this.dataGrid1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDuockp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục khoa/phòng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDuockp_KeyDown);
            this.Load += new System.EventHandler(this.frmDuockp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void frmDuockp_Load(object sender, System.EventArgs e)
		{
            if (Screen.PrimaryScreen.WorkingArea.Width > 800) this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            user = ttb.user; itable = ttb.tableid("", "d_duockp");
			dsxml.ReadXml("..\\..\\..\\xml\\ttb_danhmuc.xml");
			r=ttb.getrowbyid(dsxml.Tables[0],"table='"+table+"'");

            dtkho = ttb.get_data("select * from " + user + ".ttb_dmkho order by stt").Tables[0];
            makho.DataSource = dtkho;
            makho.DisplayMember="TEN";
			makho.ValueMember="ID";

			computer.DisplayMember="COMPUTER";
			computer.ValueMember="COMPUTER";
			computer.DataSource=m.get_data("select distinct computer from "+m.user+".dmcomputer").Tables[0];

			dtnhom=ttb.get_data("select * from "+user+".ttb_dmnhomkho order by stt").Tables[0];
			nhomkho.DataSource=dtnhom;
            nhomkho.DisplayMember = "TEN";
            nhomkho.ValueMember = "ID";

			matutruc.DisplayMember="TEN";
			matutruc.ValueMember="ID";

			makp.DisplayMember="TENKP";
			makp.ValueMember="MAKP";
			makp.DataSource=m.get_data("select * from "+m.user+".btdkp_bv order by loai,makp").Tables[0];
			load_grid(chkAll.Checked);

            sql = "select * from ttb_dmkho ";
            dtkho = ttb.get_data(sql).Tables[0];
            makho.DataSource = dtkho;
            makho.DisplayMember = "TEN";
            makho.ValueMember = "ID";

			AddGridTableStyle();
			ref_text();
		}

		private void load_grid(bool all)
		{
            try
            {
                sql = "select a.*,b.tenkp,c.ten as tentutruc from " + user + "." + table + " a left join " + m.user + ".btdkp_bv" + frmMain.link + " b on a.makp=b.makp left join " + m.user + ".d_duockp" + frmMain.link + " c on a.matutruc=c.id ";
                if (!all) sql += " where a.nhom like '%" + i_nhom.ToString().Trim() + "%'";
                sql += " order by a.stt";
                dt = ttb.get_data(sql).Tables[0];
            }
            catch {
                sql = "select a.*,b.tenkp,c.ten as tentutruc from " + m.user + "." + table + "" + frmMain.link + " a left join " + m.user + ".btdkp_bv" + frmMain.link + " b on a.makp=b.makp left join " + m.user + ".d_duockp" + frmMain.link + " c on a.matutruc=c.id ";
                if (!all) sql += " where a.nhom like '%" + i_nhom.ToString().Trim() + "%'";
                sql += " order by a.stt";
                dt = ttb.get_data(sql).Tables[0];
            }
			dataGrid1.DataSource=dt;
			sql="select * from "+m.user+".d_duockp ";
			if (!all) sql+=" where nhom like '%"+i_nhom.ToString().Trim()+"%'";
			sql+=" order by stt";
			matutruc.DataSource=m.get_data(sql).Tables[0];
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
			TextCol.Width = 30;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "ma";
			TextCol.HeaderText = "Mã";
			TextCol.Width = 60;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "ten";
			TextCol.HeaderText = "Nội dung";
			TextCol.Width = 150;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tenkp";
			TextCol.HeaderText = "Khoa lâm sàng";
			TextCol.Width = 150;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "id";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "makp";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "makho";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "nhom";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "matutruc";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tentutruc";
			TextCol.HeaderText = "Sử dụng thêm tủ trực";
			TextCol.Width = 150;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "nguoilinh";
			TextCol.HeaderText = "Người lĩnh";
			TextCol.Width = 150;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "computer";
			TextCol.HeaderText = "Tên máy";
			TextCol.Width = 100;
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
			makho.Enabled=ena;
			nhomkho.Enabled=ena;
			stt.Enabled=ena;
			ma.Enabled=ena;
			ten.Enabled=ena;
			makp.Enabled=ena;
			nguoilinh.Enabled=ena;
			matutruc.Enabled=ena;
			computer.Enabled=ena;
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
				stt.Value=decimal.Parse(ttb.get_data("select max(stt) from "+user+"."+table).Tables[0].Rows[0][0].ToString())+1;
			}
			catch{stt.Value=1;}
			i_id=0;
			ma.Text="";
			ten.Text="";
			nguoilinh.Text="";
			makp.SelectedIndex=-1;
			for(int k=0;k<makho.Items.Count;k++) makho.SetItemCheckState(k,CheckState.Unchecked);
			for(int k=0;k<nhomkho.Items.Count;k++) nhomkho.SetItemCheckState(k,CheckState.Unchecked);
			ena_object(true);
			matutruc.Enabled=false;
			stt.Focus();
		}

		private void butSua_Click(object sender, System.EventArgs e)
		{
			if (dt.Rows.Count==0) return;
			i_id=int.Parse(dataGrid1[dataGrid1.CurrentCell.RowNumber,4].ToString());
			ena_object(true);
			stt.Focus();
		}

		private bool kiemtra()
		{
			if (ma.Text=="")
			{
				ma.Focus();
				return false;
			}
			if (ten.Text=="")
			{
				ten.Focus();
				return false;
			}
			if (computer.SelectedIndex==-1)
			{
				computer.Focus();
				return false;
			}
			s_nhomkho="";
			for(int i=0;i<nhomkho.Items.Count;i++)
				if (nhomkho.GetItemChecked(i)) s_nhomkho+=dtnhom.Rows[i]["id"].ToString().Trim()+",";
			s_makho="";
			for(int i=0;i<makho.Items.Count;i++)
				if (makho.GetItemChecked(i)) s_makho+=dtkho.Rows[i]["id"].ToString().Trim()+",";
			return true;
		}

		private void butLuu_Click(object sender, System.EventArgs e)
		{
			if (!kiemtra()) return;
            if (i_id == 0)
            {
                try
                {
                    i_id = int.Parse(ttb.get_data("select max(id) from " + user + "." + table).Tables[0].Rows[0][0].ToString()) + 1;
                }
                catch { i_id = 1; }
                ttb.upd_eve_tables(itable, i_userid, "ins");
            }
            else
            {
                ttb.upd_eve_tables(itable, i_userid, "upd");
                ttb.upd_eve_upd_del(itable, i_userid, "upd", ttb.fields(m.user + ".d_duockp"+frmMain.link, "id=" + i_id));
            }
			if (matutruc.SelectedIndex!=-1) i_matutruc=int.Parse(matutruc.SelectedValue.ToString()); 
			else i_matutruc=0;
			if (!d.upd_duockp(i_id,ma.Text,ten.Text,s_nhomkho,int.Parse(stt.Value.ToString()),(makp.SelectedIndex==-1)?"":makp.SelectedValue.ToString(),s_makho,i_matutruc,nguoilinh.Text,computer.SelectedValue.ToString(),0))
			{
				MessageBox.Show("Không cập nhật thông tin "+this.Text.Trim()+" !",ttb.Msg);
				return;
			}
			load_grid(chkAll.Checked);
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
				if (r!=null)
				{
                    string sql = r["sql"].ToString();
                    if (sql.IndexOf("xxx") != -1) sql = sql.Replace("xxx", user + d_mmyy);
                    else sql = sql.Replace("yyy", user);
					if (ttb.get_data(sql+long.Parse(dataGrid1[dataGrid1.CurrentCell.RowNumber,4].ToString())).Tables[0].Rows.Count!=0)
					{
						MessageBox.Show("Nội dung đang sử dụng không cho phép hủy !",ttb.Msg);
						return;
					}
				}
			}
			catch{}
			if (MessageBox.Show("Đồng ý hủy thông tin này !",ttb.Msg,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
			{
                i_id = int.Parse(dataGrid1[dataGrid1.CurrentCell.RowNumber, 4].ToString());
                ttb.upd_eve_tables(itable, i_userid, "del");
                ttb.upd_eve_upd_del(itable, i_userid, "del", ttb.fields(user + ".d_duockp", "id=" + i_id));
				ttb.execute_data("delete from "+user+"."+table+" where id="+i_id);
				load_grid(chkAll.Checked);
			}
		}

		private void ref_text()
		{
			try
			{
                
				int i=dataGrid1.CurrentCell.RowNumber;
                i_makp = int.Parse(dataGrid1[i, 4].ToString());
				stt.Value=decimal.Parse(dataGrid1[i,0].ToString());
				ma.Text=dataGrid1[i,1].ToString();
				ten.Text=dataGrid1[i,2].ToString();
				makp.SelectedValue=dataGrid1[i,5].ToString();
				s_makho=","+dataGrid1[i,6].ToString();
				s_nhomkho=","+dataGrid1[i,7].ToString();
				for(int j=0;j<dtnhom.Rows.Count;j++)
					if (s_nhomkho.IndexOf(","+dtnhom.Rows[j]["id"].ToString().Trim()+",")!=-1) nhomkho.SetItemCheckState(j,CheckState.Checked);
					else nhomkho.SetItemCheckState(j,CheckState.Unchecked);
				load_dmkho(dataGrid1[i,7].ToString());
				for(int j=0;j<dtkho.Rows.Count;j++)
					if (s_makho.IndexOf(","+dtkho.Rows[j]["id"].ToString().Trim()+",")!=-1) makho.SetItemCheckState(j,CheckState.Checked);
					else makho.SetItemCheckState(j,CheckState.Unchecked);
				if (dataGrid1[i,8].ToString()!="0") matutruc.SelectedValue=dataGrid1[i,8].ToString();
				else matutruc.SelectedIndex=-1;
				nguoilinh.Text=dataGrid1[i,10].ToString();
				computer.SelectedValue=dataGrid1[i,11].ToString();
			}
			catch{}
		}

		private void dataGrid1_CurrentCellChanged(object sender, System.EventArgs e)
		{
			ref_text();
		}

		private void frmDuockp_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.F10) butKetthuc_Click(sender,e);
		}

		private void stt_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");		
		}

		private void ma_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");	
		}

		private void ma_Validated(object sender, System.EventArgs e)
		{
			if (ma.Text!="" && i_id==0)
			{
				DataRow r1=ttb.getrowbyid(dt,"ma='"+ma.Text+"'");
				if (r1!=null)
				{
					MessageBox.Show("Mã này đã nhập !",ttb.Msg);
					ma.Focus();
					return;
				}
				if (ten.Text=="") ten.Text=ma.Text;
			}
		}

		private void ten_Validated(object sender, System.EventArgs e)
		{
			if (i_id==0 && ten.Text!="")
			{
				DataRow r1=ttb.getrowbyid(dt,"ten='"+ten.Text+"'");
				if (r1!=null)
				{
					MessageBox.Show("Nội dung đã nhập !",ttb.Msg);
					ten.Focus();
				}
			}
		}

		private void makp_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");
		}

		private void nhomkho_SelectedIndexChanged(object sender, System.EventArgs e)
		{
            if (this.ActiveControl == nhomkho)
            {
                //load_dmkho("");
                //
                
                int i = dataGrid1.CurrentCell.RowNumber;
                long id = long.Parse(dataGrid1[i, 4].ToString());
                DataRow r = ttb.getrowbyid(dt, "id=" + id);
                if (r != null)
                {
                    s_makho = "," + r["makho"].ToString();                    
                    for (int j = 0; j < dtkho.Rows.Count; j++)
                        if (s_makho.IndexOf("," + dtkho.Rows[j]["id"].ToString().Trim() + ",") != -1) makho.SetItemCheckState(j, CheckState.Checked);                   
                }
            }
		}

		private void load_dmkho(string nhom)
		{
			s_nhomkho=nhom;
			if (s_nhomkho=="") for(int i=0;i<nhomkho.Items.Count;i++) if (nhomkho.GetItemChecked(i)) s_nhomkho+=dtnhom.Rows[i]["id"].ToString().Trim()+",";
			sql="select * from "+user+".ttb_dmkho";
			if (s_nhomkho!="") sql+=" where nhom in ("+s_nhomkho.Substring(0,s_nhomkho.Length-1)+",0)";
			sql+=" order by nhom,stt";
			dtkho=ttb.get_data(sql).Tables[0];
			makho.DataSource=dtkho;
            makho.DisplayMember = "TEN";
            makho.ValueMember = "ID";
		}

		private void matutruc_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter)
			{
				if (matutruc.SelectedIndex==-1 && matutruc.Items.Count>0) matutruc.SelectedIndex=0;
				SendKeys.Send("{Tab}");
			}
		}

		private void chkAll_CheckedChanged(object sender, System.EventArgs e)
		{
			load_grid(chkAll.Checked);
		}
	}
}
