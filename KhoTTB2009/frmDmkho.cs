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
	public class frmDmkho : System.Windows.Forms.Form
	{
        string dbLink = "";
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button butKetthuc;
        private LibTTB.AccessData ttb;
        private LibMedi.AccessData m=new LibMedi.AccessData();
		private DataTable dt=new DataTable();
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button butMoi;
		private System.Windows.Forms.Button butSua;
		private System.Windows.Forms.Button butLuu;
		private System.Windows.Forms.Button butBoqua;
		private System.Windows.Forms.Button butHuy;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown stt;
		private decimal l_id;
		private int i_nhom,itable,i_userid,stt_medi;
		private string s_mmyy,user;
		private System.Windows.Forms.TextBox ten;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox nhomcc;
		private System.Windows.Forms.CheckBox khott;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox computer;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox matat;
		private System.Windows.Forms.CheckBox ketoan;
		private System.Windows.Forms.CheckBox thua;
        private CheckBox dutru;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmDmkho(AccessData acc,int nhom,string mmyy,int userid)
		{
			InitializeComponent();
            ttb = acc; i_nhom = nhom; s_mmyy = mmyy; i_userid = userid;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDmkho));
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
            this.label4 = new System.Windows.Forms.Label();
            this.nhomcc = new System.Windows.Forms.ComboBox();
            this.khott = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.computer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.matat = new System.Windows.Forms.TextBox();
            this.ketoan = new System.Windows.Forms.CheckBox();
            this.thua = new System.Windows.Forms.CheckBox();
            this.dutru = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stt)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid1
            // 
            this.dataGrid1.AlternatingBackColor = System.Drawing.Color.Lavender;
            this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dataGrid1.Size = new System.Drawing.Size(752, 355);
            this.dataGrid1.TabIndex = 19;
            this.dataGrid1.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
            // 
            // butKetthuc
            // 
            this.butKetthuc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butKetthuc.Image = ((System.Drawing.Image)(resources.GetObject("butKetthuc.Image")));
            this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butKetthuc.Location = new System.Drawing.Point(506, 401);
            this.butKetthuc.Name = "butKetthuc";
            this.butKetthuc.Size = new System.Drawing.Size(78, 25);
            this.butKetthuc.TabIndex = 14;
            this.butKetthuc.Text = "     &Kết thúc";
            this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Location = new System.Drawing.Point(171, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tên :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ten
            // 
            this.ten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ten.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ten.Enabled = false;
            this.ten.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ten.Location = new System.Drawing.Point(201, 348);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(559, 21);
            this.ten.TabIndex = 2;
            this.ten.Validated += new System.EventHandler(this.ten_Validated);
            this.ten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ten_KeyDown);
            // 
            // butMoi
            // 
            this.butMoi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butMoi.Image = ((System.Drawing.Image)(resources.GetObject("butMoi.Image")));
            this.butMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butMoi.Location = new System.Drawing.Point(192, 401);
            this.butMoi.Name = "butMoi";
            this.butMoi.Size = new System.Drawing.Size(60, 25);
            this.butMoi.TabIndex = 11;
            this.butMoi.Text = "     &Mới";
            this.butMoi.Click += new System.EventHandler(this.butMoi_Click);
            // 
            // butSua
            // 
            this.butSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butSua.Image = ((System.Drawing.Image)(resources.GetObject("butSua.Image")));
            this.butSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butSua.Location = new System.Drawing.Point(254, 401);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(60, 25);
            this.butSua.TabIndex = 12;
            this.butSua.Text = "    &Sửa";
            this.butSua.Click += new System.EventHandler(this.butSua_Click);
            // 
            // butLuu
            // 
            this.butLuu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butLuu.Enabled = false;
            this.butLuu.Image = ((System.Drawing.Image)(resources.GetObject("butLuu.Image")));
            this.butLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butLuu.Location = new System.Drawing.Point(316, 401);
            this.butLuu.Name = "butLuu";
            this.butLuu.Size = new System.Drawing.Size(60, 25);
            this.butLuu.TabIndex = 9;
            this.butLuu.Text = "    &Lưu";
            this.butLuu.Click += new System.EventHandler(this.butLuu_Click);
            // 
            // butBoqua
            // 
            this.butBoqua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butBoqua.Enabled = false;
            this.butBoqua.Image = ((System.Drawing.Image)(resources.GetObject("butBoqua.Image")));
            this.butBoqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butBoqua.Location = new System.Drawing.Point(378, 401);
            this.butBoqua.Name = "butBoqua";
            this.butBoqua.Size = new System.Drawing.Size(64, 25);
            this.butBoqua.TabIndex = 10;
            this.butBoqua.Text = "     &Bỏ qua";
            this.butBoqua.Click += new System.EventHandler(this.butBoqua_Click);
            // 
            // butHuy
            // 
            this.butHuy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butHuy.Image = ((System.Drawing.Image)(resources.GetObject("butHuy.Image")));
            this.butHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butHuy.Location = new System.Drawing.Point(444, 401);
            this.butHuy.Name = "butHuy";
            this.butHuy.Size = new System.Drawing.Size(60, 25);
            this.butHuy.TabIndex = 13;
            this.butHuy.Text = "    &Hủy";
            this.butHuy.Click += new System.EventHandler(this.butHuy_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Location = new System.Drawing.Point(-9, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "STT :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stt
            // 
            this.stt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stt.Enabled = false;
            this.stt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stt.Location = new System.Drawing.Point(43, 348);
            this.stt.Name = "stt";
            this.stt.Size = new System.Drawing.Size(40, 21);
            this.stt.TabIndex = 0;
            this.stt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stt_KeyDown);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(-6, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Nhóm :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nhomcc
            // 
            this.nhomcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nhomcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nhomcc.Enabled = false;
            this.nhomcc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhomcc.Location = new System.Drawing.Point(42, 376);
            this.nhomcc.Name = "nhomcc";
            this.nhomcc.Size = new System.Drawing.Size(210, 21);
            this.nhomcc.TabIndex = 3;
            this.nhomcc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nhomcc_KeyDown);
            // 
            // khott
            // 
            this.khott.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.khott.Enabled = false;
            this.khott.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khott.Location = new System.Drawing.Point(260, 374);
            this.khott.Name = "khott";
            this.khott.Size = new System.Drawing.Size(96, 24);
            this.khott.TabIndex = 5;
            this.khott.Text = "Kho trung tâm";
            this.khott.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stt_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Location = new System.Drawing.Point(-3, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Máy :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Visible = false;
            // 
            // computer
            // 
            this.computer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.computer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.computer.Enabled = false;
            this.computer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computer.Location = new System.Drawing.Point(36, 438);
            this.computer.Name = "computer";
            this.computer.Size = new System.Drawing.Size(218, 21);
            this.computer.TabIndex = 4;
            this.computer.Visible = false;
            this.computer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nhomcc_KeyDown);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.Location = new System.Drawing.Point(70, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "Mã số :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // matat
            // 
            this.matat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.matat.BackColor = System.Drawing.SystemColors.HighlightText;
            this.matat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.matat.Enabled = false;
            this.matat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matat.Location = new System.Drawing.Point(123, 348);
            this.matat.Name = "matat";
            this.matat.Size = new System.Drawing.Size(48, 21);
            this.matat.TabIndex = 1;
            this.matat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stt_KeyDown);
            // 
            // ketoan
            // 
            this.ketoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ketoan.Enabled = false;
            this.ketoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ketoan.Location = new System.Drawing.Point(482, 374);
            this.ketoan.Name = "ketoan";
            this.ketoan.Size = new System.Drawing.Size(160, 24);
            this.ketoan.TabIndex = 7;
            this.ketoan.Text = "Kế toán không theo dõi";
            this.ketoan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stt_KeyDown);
            // 
            // thua
            // 
            this.thua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.thua.Enabled = false;
            this.thua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thua.Location = new System.Drawing.Point(362, 374);
            this.thua.Name = "thua";
            this.thua.Size = new System.Drawing.Size(118, 24);
            this.thua.TabIndex = 6;
            this.thua.Text = "Kho hoàn trả thừa";
            this.thua.CheckedChanged += new System.EventHandler(this.thua_CheckedChanged);
            this.thua.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stt_KeyDown);
            // 
            // dutru
            // 
            this.dutru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dutru.Enabled = false;
            this.dutru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dutru.Location = new System.Drawing.Point(624, 374);
            this.dutru.Name = "dutru";
            this.dutru.Size = new System.Drawing.Size(160, 24);
            this.dutru.TabIndex = 8;
            this.dutru.Text = "Hiện thị trong dự trù mua";
            this.dutru.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stt_KeyDown);
            // 
            // frmDmkho
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(768, 438);
            this.Controls.Add(this.dutru);
            this.Controls.Add(this.thua);
            this.Controls.Add(this.ketoan);
            this.Controls.Add(this.stt);
            this.Controls.Add(this.matat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.computer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.khott);
            this.Controls.Add(this.ten);
            this.Controls.Add(this.nhomcc);
            this.Controls.Add(this.label4);
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
            this.Name = "frmDmkho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục kho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDmkho_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDmkho_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void frmDmkho_Load(object sender, System.EventArgs e)
		{
            if (Screen.PrimaryScreen.WorkingArea.Width > 800) this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            user = ttb.user; itable = ttb.tableid("", "ttb_dmkho");
            dbLink = ttb.dbLink;
            //computer.DisplayMember="COMPUTER";
            //computer.ValueMember="COMPUTER";
            //computer.DataSource=m.get_data("select distinct computer from "+m.user+".dmcomputer").Tables[0];
			nhomcc.DisplayMember="TEN";
			nhomcc.ValueMember="ID";
			nhomcc.DataSource=ttb.get_data("select * from "+user+".ttb_loaikho order by id").Tables[0];
			load_grid();
			AddGridTableStyle();
            ref_text();
            nhomcc.SelectedIndex = 1;
		}

		private void load_grid()
		{
            dt = ttb.get_data("select a.*,b.ten as tennhom from " + user + ".ttb_dmkho a left join " + user + ".ttb_loaikho b on a.loai=b.id order by a.ten").Tables[0];
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
			TextCol.MappingName = "stt";
			TextCol.HeaderText = "STT";
			TextCol.Width = 30;
			ts.GridColumnStyles.Add(TextCol);
			

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "matat";
			TextCol.HeaderText = "Mã số";
			TextCol.Width = 60;
			ts.GridColumnStyles.Add(TextCol);
			

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "ten";
			TextCol.HeaderText = "Nội dung";
			TextCol.Width = 275;
			ts.GridColumnStyles.Add(TextCol);
			

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tennhom";
			TextCol.HeaderText = "Nhóm";
			TextCol.Width = 280;
			ts.GridColumnStyles.Add(TextCol);
			

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "id";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "loai";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "khott";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "computer";
			TextCol.HeaderText = "Tên máy";
			TextCol.Width = 100;
			ts.GridColumnStyles.Add(TextCol);
			

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "ketoan";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "thua";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			

            TextCol = new DataGridTextBoxColumn();
            TextCol.MappingName = "dutru";
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
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}{F4}");
		}

		private void ena_object(bool ena)
		{
			dataGrid1.Enabled=!ena;
			stt.Enabled=ena;
			ten.Enabled=ena;
			matat.Enabled=ena;
			computer.Enabled=ena;
			khott.Enabled=ena;
			thua.Enabled=ena;
            dutru.Enabled = ena;
			ketoan.Enabled=ena;
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
				stt.Value=decimal.Parse(ttb.get_data("select max(stt) from "+user+".ttb_dmkho where nhom="+i_nhom).Tables[0].Rows[0][0].ToString())+1;
			}
			catch{stt.Value=1;}
            try
            {
                stt_medi = int.Parse(ttb.get_data("select max(stt) from " + ttb.UserMedi + ".d_dmkho"+dbLink+" where nhom=" + i_nhom).Tables[0].Rows[0][0].ToString()) + 1;
            }
            catch { stt_medi = 1; }
			l_id=0;
			ten.Text="";
			matat.Text="";
			thua.Checked=false;
            dutru.Checked = true;
			ketoan.Checked=false;
			ena_object(true);
			stt.Focus();
            nhomcc.SelectedIndex = 1;
		}

		private void butSua_Click(object sender, System.EventArgs e)
		{
			if (dt.Rows.Count==0) return;
			l_id=decimal.Parse(dataGrid1[dataGrid1.CurrentCell.RowNumber,4].ToString());
            try
            {
                stt_medi = int.Parse(ttb.get_data("select max(stt) from " + ttb.UserMedi + ".d_dmkho"+dbLink+" where id=" + l_id).Tables[0].Rows[0][0].ToString());
            }
            catch { }
			ena_object(true);
			stt.Focus();
		}

		private bool kiemtra()
		{
			if (ten.Text=="")
			{
				ten.Focus();
				return false;
			}
			if (nhomcc.SelectedIndex==-1)
			{
				nhomcc.Focus();
				return false;
			}
			if (matat.Text=="")
			{
				matat.Focus();
				return false;
			}
			return true;
		}

		private void butLuu_Click(object sender, System.EventArgs e)
		{
			if (!kiemtra()) return ;
            if (l_id == 0)
            {
                try
                {
                    decimal d_ID = decimal.Parse(ttb.get_data("select abs(max(id)) from " + ttb.user + ".ttb_dmkho").Tables[0].Rows[0][0].ToString());
                    d_ID = decimal.Parse(d_ID.ToString().Substring(1));
                    d_ID++;
                    l_id = -1*decimal.Parse(((decimal)LibDuoc.ID.NhomKho.TTB).ToString() + d_ID.ToString().PadLeft(2,'0')); 
                }
                catch { l_id = -decimal.Parse(((decimal)LibDuoc.ID.NhomKho.TTB).ToString() + "01"); }
                ttb.upd_eve_tables(itable, i_userid, "ins");
            }
            else
            {
                ttb.upd_eve_tables(itable, i_userid, "upd");
                ttb.upd_eve_upd_del(itable, i_userid, "upd", ttb.fields(user + ".ttb_dmkho", "id=" + l_id));
            }
			if (!ttb.upd_dmkho(l_id,ten.Text,i_nhom,int.Parse(nhomcc.SelectedValue.ToString()),
                int.Parse(stt.Value.ToString()), (khott.Checked) ? 1 : 0, System.Environment.MachineName.ToUpper(), matat.Text,
                0, 0, dutru.Checked ? 1 : 0))
			{
				MessageBox.Show("Không cập nhật thông tin "+this.Text.Trim()+" !",ttb.Msg);
				return;
			}
			load_grid();
			ena_object(false);
            dataGrid1_CurrentCellChanged(null, null);
		}

		private void butBoqua_Click(object sender, System.EventArgs e)
		{
			ref_text();
			ena_object(false);
		}

        private void butHuy_Click(object sender, System.EventArgs e)
        {
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Không cho phép hủy !", ttb.Msg);
                return;
            }
            try
            {
                if (ttb.get_data("select * from " + user + ".ttb_tonkhoth where makho=" + decimal.Parse(dataGrid1[dataGrid1.CurrentCell.RowNumber, 4].ToString())).Tables[0].Rows.Count != 0)
                {
                    MessageBox.Show("Nội dung đang sử dụng không cho phép hủy !", ttb.Msg);
                    return;
                }
            }
            catch { }
            if (MessageBox.Show("Đồng ý hủy thông tin này !", ttb.Msg, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                l_id = decimal.Parse(dataGrid1[dataGrid1.CurrentCell.RowNumber, 4].ToString());
                ttb.upd_eve_tables(itable, i_userid, "del");
                ttb.upd_eve_upd_del(itable, i_userid, "del", ttb.fields(user + ".ttb_dmkho", "id=" + l_id));
                ttb.execute_data("delete from " + user + ".ttb_dmkho where id=" + l_id);
                ttb.execute_data("delete from " + ttb.UserMedi + ".d_dmkho" + dbLink + " where id=" + l_id);
                load_grid();
                dataGrid1_CurrentCellChanged(null, null);
            }
        }

		private void ref_text()
		{
			try
			{
				int i=dataGrid1.CurrentCell.RowNumber;
				stt.Value=decimal.Parse(dataGrid1[i,0].ToString());
				matat.Text=dataGrid1[i,1].ToString();
				ten.Text=dataGrid1[i,2].ToString();
                l_id = Convert.ToDecimal(dataGrid1[i, 4]);
				nhomcc.SelectedValue=dataGrid1[i,5].ToString();
				khott.Checked=dataGrid1[i,6].ToString().Trim()=="1";
				computer.SelectedValue=dataGrid1[i,7].ToString();
				ketoan.Checked=dataGrid1[i,8].ToString().Trim()=="1";
				thua.Checked=dataGrid1[i,9].ToString().Trim()=="1";
                dutru.Checked = dataGrid1[i, 10].ToString().Trim() == "1";
			}
			catch{}
		}

		private void dataGrid1_CurrentCellChanged(object sender, System.EventArgs e)
		{
			ref_text();
		}

		private void frmDmkho_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
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

		private void nhomcc_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter || e.KeyCode==Keys.Tab)
			{
				if (nhomcc.SelectedIndex==-1) nhomcc.SelectedIndex=0;
				SendKeys.Send("{Tab}");
			}
		}

		private void ten_Validated(object sender, System.EventArgs e)
		{
			if (l_id==0 && ten.Text!="")
			{
				DataRow r1=ttb.getrowbyid(dt,"ten='"+ten.Text+"'");
				if (r1!=null)
				{
					MessageBox.Show("Nội dung đã nhập !",ttb.Msg);
					ten.Focus();
				}
			}
		}

		private void thua_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.ActiveControl==thua && !ketoan.Checked) ketoan.Checked=true;
		}
	}
}
