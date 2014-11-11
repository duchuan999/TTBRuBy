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
	/// Summary description for frmDuyet.
	/// </summary>
	public class frmDuyet : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox makp;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox phieu;
		private System.Windows.Forms.Button butLay;
		private System.Windows.Forms.Button butLuu;
		private System.Windows.Forms.Button butBoqua;
		private System.Windows.Forms.DataGrid dataGrid1;
		private Brush disabledBackBrush;
		private Brush disabledTextBrush;
		private Brush alertBackBrush;
		private Font alertFont;
		private Brush alertTextBrush;
		private Font currentRowFont;
		private Brush currentRowBackBrush;
		private bool afterCurrentCellChanged,bSkip=false,bBuhaophi,bThua,bPhattron,bBucstt_nguon,bCongdon,bSlthuc_yeucau,bKiemtra;
		private int checkCol=0,i_userid,i_row=0,i_thuoc;
        private LibTTB.AccessData ttb;
        private LibDuoc.AccessData d=new LibDuoc.AccessData();
		private int i_nhom,i_loai,i_mabd,i_makho,o_makp,o_phieu,i_manguon,o_makhoa;
		private decimal d_soluongcu,d_soluongton,d_soluong;
		private string s_makp,sql,s_mmyy,s_kho,s_ngay,o_tu,o_den,file1,file2,s_min,s_max,s_tenkp,s_phieu,s_ravien,s_noidung,s_sttduyet,user,xxx,f_ngay,link;
		private DataTable dtct=new DataTable();
		private DataTable dt=new DataTable();
		private DataTable dtphieu=new DataTable();
		private DataTable dtkp=new DataTable();
		private DataTable dtton=new DataTable();
		private DataTable dtcstt=new DataTable();
		private DataTable dthoten=new DataTable();
		public DataTable dtll=new DataTable();
		public bool bOk=false;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tim;
		private System.Windows.Forms.CheckBox phatsau;
		private System.Windows.Forms.Button butIn;
		private System.Windows.Forms.Button butKetthuc;
		private System.Windows.Forms.TextBox kp;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmDuyet(AccessData acc,DataTable dt,int nhom,int loai,string makp,string mmyy,string kho,string title,string ngay,int userid,bool buhaophi,bool thua,int thuoc,bool congdon)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			ttb=acc;dtll=dt;i_nhom=nhom;i_loai=loai;
			i_userid=userid;i_thuoc=thuoc;
			s_makp=makp;s_mmyy=mmyy;
			s_kho=kho;s_ngay=ngay;bCongdon=congdon; 
			bBuhaophi=buhaophi;bThua=thua;this.Text=title;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDuyet));
            this.label1 = new System.Windows.Forms.Label();
            this.makp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phieu = new System.Windows.Forms.ComboBox();
            this.butLay = new System.Windows.Forms.Button();
            this.butLuu = new System.Windows.Forms.Button();
            this.butBoqua = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.tim = new System.Windows.Forms.TextBox();
            this.phatsau = new System.Windows.Forms.CheckBox();
            this.butIn = new System.Windows.Forms.Button();
            this.butKetthuc = new System.Windows.Forms.Button();
            this.kp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khoa ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // makp
            // 
            this.makp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.makp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makp.Location = new System.Drawing.Point(67, 6);
            this.makp.Name = "makp";
            this.makp.Size = new System.Drawing.Size(125, 21);
            this.makp.TabIndex = 1;
            this.makp.SelectedIndexChanged += new System.EventHandler(this.makp_SelectedIndexChanged);
            this.makp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.makp_KeyDown);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(189, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phiếu ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // phieu
            // 
            this.phieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.phieu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phieu.Location = new System.Drawing.Point(224, 6);
            this.phieu.Name = "phieu";
            this.phieu.Size = new System.Drawing.Size(224, 21);
            this.phieu.TabIndex = 2;
            this.phieu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phieu_KeyDown);
            // 
            // butLay
            // 
            this.butLay.Image = ((System.Drawing.Image)(resources.GetObject("butLay.Image")));
            this.butLay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butLay.Location = new System.Drawing.Point(218, 477);
            this.butLay.Name = "butLay";
            this.butLay.Size = new System.Drawing.Size(84, 25);
            this.butLay.TabIndex = 5;
            this.butLay.Text = "      Lấy &số liệu";
            this.butLay.Click += new System.EventHandler(this.butLay_Click);
            // 
            // butLuu
            // 
            this.butLuu.Enabled = false;
            this.butLuu.Image = ((System.Drawing.Image)(resources.GetObject("butLuu.Image")));
            this.butLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butLuu.Location = new System.Drawing.Point(303, 477);
            this.butLuu.Name = "butLuu";
            this.butLuu.Size = new System.Drawing.Size(60, 25);
            this.butLuu.TabIndex = 6;
            this.butLuu.Text = "      &Lưu";
            this.butLuu.Click += new System.EventHandler(this.butLuu_Click);
            // 
            // butBoqua
            // 
            this.butBoqua.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butBoqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butBoqua.Location = new System.Drawing.Point(517, 477);
            this.butBoqua.Name = "butBoqua";
            this.butBoqua.Size = new System.Drawing.Size(60, 25);
            this.butBoqua.TabIndex = 10;
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
            this.dataGrid1.Location = new System.Drawing.Point(6, 14);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.RowHeaderWidth = 3;
            this.dataGrid1.Size = new System.Drawing.Size(783, 458);
            this.dataGrid1.TabIndex = 24;
            this.dataGrid1.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
            this.dataGrid1.Click += new System.EventHandler(this.dataGrid1_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(438, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "&Tìm kiếm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tim
            // 
            this.tim.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tim.Location = new System.Drawing.Point(496, 6);
            this.tim.Name = "tim";
            this.tim.Size = new System.Drawing.Size(296, 21);
            this.tim.TabIndex = 4;
            this.tim.TextChanged += new System.EventHandler(this.tim_TextChanged);
            this.tim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tim_KeyDown);
            // 
            // phatsau
            // 
            this.phatsau.Location = new System.Drawing.Point(664, 480);
            this.phatsau.Name = "phatsau";
            this.phatsau.Size = new System.Drawing.Size(136, 24);
            this.phatsau.TabIndex = 26;
            this.phatsau.Text = "Không duyệt lĩnh dồn";
            this.phatsau.Visible = false;
            this.phatsau.CheckedChanged += new System.EventHandler(this.phatsau_CheckedChanged);
            this.phatsau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tim_KeyDown);
            // 
            // butIn
            // 
            this.butIn.Image = ((System.Drawing.Image)(resources.GetObject("butIn.Image")));
            this.butIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butIn.Location = new System.Drawing.Point(364, 477);
            this.butIn.Name = "butIn";
            this.butIn.Size = new System.Drawing.Size(60, 25);
            this.butIn.TabIndex = 8;
            this.butIn.Text = "     &In";
            this.butIn.Click += new System.EventHandler(this.butIn_Click);
            // 
            // butKetthuc
            // 
            this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butKetthuc.Location = new System.Drawing.Point(425, 477);
            this.butKetthuc.Name = "butKetthuc";
            this.butKetthuc.Size = new System.Drawing.Size(91, 25);
            this.butKetthuc.TabIndex = 9;
            this.butKetthuc.Text = "&DS dự trù-duyệt";
            this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
            // 
            // kp
            // 
            this.kp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kp.Location = new System.Drawing.Point(40, 6);
            this.kp.Name = "kp";
            this.kp.Size = new System.Drawing.Size(26, 21);
            this.kp.TabIndex = 0;
            this.kp.Validated += new System.EventHandler(this.kp_Validated);
            this.kp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kp_KeyDown);
            // 
            // frmDuyet
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.butBoqua;
            this.ClientSize = new System.Drawing.Size(794, 519);
            this.Controls.Add(this.kp);
            this.Controls.Add(this.butKetthuc);
            this.Controls.Add(this.butIn);
            this.Controls.Add(this.makp);
            this.Controls.Add(this.phatsau);
            this.Controls.Add(this.phieu);
            this.Controls.Add(this.tim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.butBoqua);
            this.Controls.Add(this.butLuu);
            this.Controls.Add(this.butLay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 38);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDuyet";            
            //this.StartPosition = (Screen.PrimaryScreen.WorkingArea.Width > 800)?System.Windows.Forms.FormStartPosition.CenterScreen:System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmDuyet";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDuyet_KeyDown);
            this.Load += new System.EventHandler(this.frmDuyet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void frmDuyet_Load(object sender, System.EventArgs e)
		{
            link = ttb.dbLink;
            user = ttb.user; xxx = user;// +s_mmyy;
            f_ngay = ttb.f_ngay;
			bKiemtra=ttb.bKiemtra_phat_thuhoi(i_nhom);
            if (bBuhaophi)
            {
                file1 = xxx + ".ttb_haophill"; file2 = xxx + ".ttb_haophict";
                s_noidung = "PHIEU HAO PHI";
            }
            else
            {
                switch (i_loai)
                {
                    case 1: file1 = xxx + ".ttb_dutrull"; file2 = xxx + ".ttb_dutruct"; s_noidung = "PHIEU LINH";
                        break;
                    case 2: file1 = xxx + ".ttb_xtutrucll"; file2 = xxx + ".ttb_xtutrucct"; s_noidung = "PHIEU TU TRUC";
                        break;
                    case 3: file1 = xxx + ".ttb_hoantrall"; file2 = xxx + ".ttb_hoantract"; s_noidung = "PHIEU HOAN TRA";
                        break;
                    default: file1 = xxx + ".ttb_haophill"; file2 = xxx + ".ttb_haophict"; s_noidung = "PHIEU HAO PHI";
                        break;
                }
            }
			bSlthuc_yeucau=ttb.bSLDuyet_nho_yeucau(i_nhom);
			bPhattron=ttb.bPhattron(i_nhom);
			bBucstt_nguon=ttb.bBucstt_nguon(i_nhom);
			if (i_loai==2 || bBuhaophi) dtcstt=ttb.get_data("select * from "+user+".ttb_cosotutruc where nhom="+i_nhom+" and mmyy='"+s_mmyy+"'").Tables[0];
			sql="select * from "+user+".ttb_loaiphieu where nhom="+i_nhom;
			if (bBuhaophi) sql+=" and loai=4";
			else sql+=" and loai="+i_loai;
			if (bThua) sql+=" and id=0";
			else sql+=" and id<>0";
			sql+=" order by stt";
			dtphieu=ttb.get_data(sql).Tables[0];
			phieu.DisplayMember="TEN";
			phieu.ValueMember="ID";
			phieu.DataSource=dtphieu;

            sql = "select * from " + d.user + ".d_duockp where nhom like '%" + i_nhom.ToString() + ",%'";
			if (s_makp!="") sql+=" and id in ("+s_makp.Substring(0,s_makp.Length-1)+")";
			sql+=" order by stt";
			dtkp=d.get_data(sql).Tables[0];
			makp.DisplayMember="TEN";
			makp.ValueMember="ID";
			makp.DataSource=dtkp;
			if (makp.Items.Count>0)	kp.Text=dtkp.Rows[makp.SelectedIndex]["ma"].ToString();
			
			this.disabledBackBrush = new SolidBrush(Color.FromArgb(255,255,192));
			this.disabledTextBrush = new SolidBrush(Color.FromArgb(255,0,0));

			this.alertBackBrush = new SolidBrush(SystemColors.HotTrack);
			this.alertFont = new Font(this.dataGrid1.Font.Name, this.dataGrid1.Font.Size, FontStyle.Bold);
			this.alertTextBrush = new SolidBrush(Color.White);
			
			this.currentRowFont = new Font(this.dataGrid1.Font.Name, this.dataGrid1.Font.Size, FontStyle.Regular);
			this.currentRowBackBrush = new SolidBrush(Color.FromArgb(0,255, 255));
		}

		private void makp_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{	
			if (e.KeyCode==Keys.Enter || e.KeyCode==Keys.Tab)
			{
				if (makp.SelectedIndex==-1) makp.SelectedIndex=0;
				SendKeys.Send("{Tab}{F4}");
			}
		}

		private void phieu_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter || e.KeyCode==Keys.Tab)
			{
				if (phieu.SelectedIndex==-1) phieu.SelectedIndex=0;
				SendKeys.Send("{Tab}");
			}
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
			ts.SelectionBackColor = Color.FromArgb(0,255,255);
			ts.SelectionForeColor = Color.PaleGreen;
			ts.RowHeaderWidth=3;
			ts.AllowSorting=false;

			FormattableBooleanColumn discontinuedCol = new FormattableBooleanColumn();
			discontinuedCol.MappingName = "chon";
			discontinuedCol.HeaderText = "Bỏ";
			discontinuedCol.Width = 20;
			discontinuedCol.AllowNull = false;

			discontinuedCol.SetCellFormat += new FormatCellEventHandler(SetCellFormat);
			discontinuedCol.BoolValueChanged += new BoolValueChangedEventHandler(BoolValueChanged);
			ts.GridColumnStyles.Add(discontinuedCol);
			dataGrid1.TableStyles.Add(ts);

			FormattableTextBoxColumn TextCol = new FormattableTextBoxColumn();
			TextCol.MappingName = "mabn";
			TextCol.HeaderText = (bCongdon)?"":(i_loai==4 || bBuhaophi || bThua || i_thuoc==2)?"Số phiếu":"Mã BN";
			TextCol.Width =(bCongdon)?0:60;
			TextCol.ReadOnly=true;
			TextCol.SetCellFormat += new FormatCellEventHandler(SetCellFormat);
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new FormattableTextBoxColumn();
			TextCol.MappingName = "hoten";
			TextCol.HeaderText = (bCongdon)?"":"Họ tên";
			TextCol.Width = (bCongdon || i_loai==4 || bBuhaophi || bThua || i_thuoc==2)?0:150;
			TextCol.ReadOnly=true;
			TextCol.SetCellFormat += new FormatCellEventHandler(SetCellFormat);
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new FormattableTextBoxColumn();
			TextCol.MappingName = "doituong";
			TextCol.HeaderText = "Đối tượng";
			TextCol.Width = (bCongdon || i_loai==4 || bBuhaophi || bThua || i_thuoc==2)?0:60;
			TextCol.ReadOnly=true;
			TextCol.SetCellFormat += new FormatCellEventHandler(SetCellFormat);
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new FormattableTextBoxColumn();
			TextCol.MappingName = "tennguon";
			TextCol.HeaderText = "Nguồn";
			TextCol.Width = (bThua || i_thuoc==2)?90:60;
			TextCol.ReadOnly=true;
			TextCol.SetCellFormat += new FormatCellEventHandler(SetCellFormat);
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new FormattableTextBoxColumn();
			TextCol.MappingName = "tenkho";
			TextCol.HeaderText = (i_loai==3)?"Kho nhập":(i_loai==2 || bBuhaophi)?"Kho bù":"Kho xuất";
			TextCol.Width = (bCongdon || bThua || i_thuoc==2)?90:50;
			TextCol.ReadOnly=true;
			TextCol.SetCellFormat += new FormatCellEventHandler(SetCellFormat);
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new FormattableTextBoxColumn();
			TextCol.MappingName = "ten";
			TextCol.HeaderText = "Tên";
			TextCol.Width = (bCongdon)?360:(bBuhaophi || bThua || i_thuoc==2)?310:(i_loai==4)?380:(i_loai==2)?135:170;
			TextCol.ReadOnly=true;
			TextCol.SetCellFormat += new FormatCellEventHandler(SetCellFormat);
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new FormattableTextBoxColumn();
			TextCol.MappingName = "dang";
			TextCol.HeaderText = "ĐVT";
			TextCol.Width = 40;
			TextCol.ReadOnly=true;
			TextCol.SetCellFormat += new FormatCellEventHandler(SetCellFormat);
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new FormattableTextBoxColumn();
			TextCol.MappingName = "soluongyc";
			TextCol.HeaderText = "Yêu cầu";
			TextCol.Width = 50;
			TextCol.ReadOnly=true;
			TextCol.SetCellFormat += new FormatCellEventHandler(SetCellFormat);
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new FormattableTextBoxColumn();
			TextCol.MappingName = "soluong";
			TextCol.HeaderText = (i_loai==2 || bBuhaophi)?"Thực bù":(i_loai==3)?"Thực trả":"Thực xuất";
			TextCol.Width = 55;
			if (i_loai==3 && i_thuoc==1) TextCol.ReadOnly=true;
			else TextCol.ReadOnly=!ttb.bSLDuyet(i_nhom);
			TextCol.SetCellFormat += new FormatCellEventHandler(SetCellFormat);
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new FormattableTextBoxColumn();
			TextCol.MappingName = "mabd";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			TextCol.ReadOnly=true;
			TextCol.SetCellFormat += new FormatCellEventHandler(SetCellFormat);
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new FormattableTextBoxColumn();
			TextCol.MappingName = "makho";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			TextCol.ReadOnly=true;
			TextCol.SetCellFormat += new FormatCellEventHandler(SetCellFormat);
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new FormattableTextBoxColumn();
			TextCol.MappingName = "manguon";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			TextCol.ReadOnly=true;
			TextCol.SetCellFormat += new FormatCellEventHandler(SetCellFormat);
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			if (i_loai==2 || bBuhaophi)
			{
				TextCol=new FormattableTextBoxColumn();
				TextCol.MappingName = "coso";
				TextCol.HeaderText = "Cơ số";
				TextCol.Width = 35;
				TextCol.ReadOnly=true;
				TextCol.SetCellFormat += new FormatCellEventHandler(SetCellFormat);
				ts.GridColumnStyles.Add(TextCol);
				dataGrid1.TableStyles.Add(ts);
			}
			TextCol=new FormattableTextBoxColumn();
			TextCol.MappingName = "ton";
			TextCol.HeaderText = (i_loai==3 && i_thuoc==1)?"":"Tồn";
			TextCol.Width = (i_loai==3 && i_thuoc==1)?0:35;
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
			Rectangle rect = this.dataGrid1.GetCellBounds(row,0);
			rect = new Rectangle(rect.Right, rect.Top, this.dataGrid1.Width, rect.Height);
			this.dataGrid1.Invalidate(rect);
		}

		private void dataGrid1_CurrentCellChanged(object sender, System.EventArgs e)
		{
			if((bool)this.dataGrid1[this.dataGrid1.CurrentRowIndex, checkCol]) this.dataGrid1.CurrentCell = new DataGridCell(this.dataGrid1.CurrentRowIndex, checkCol);
			afterCurrentCellChanged = true;
			try
			{
				if (i_loai==3 && i_thuoc==1) return;
				if (dataGrid1.CurrentCell.ColumnNumber==9 && ttb.bSLDuyet(i_nhom))
				{
					i_mabd=int.Parse(dataGrid1[i_row,10].ToString());
					i_makho=int.Parse(dataGrid1[i_row,11].ToString());
					i_manguon=int.Parse(dataGrid1[i_row,12].ToString());
					d_soluongcu=decimal.Parse(dt.Rows[i_row]["soluongcu"].ToString());
					d_soluong=decimal.Parse(dataGrid1[i_row,9].ToString());
					if (bSlthuc_yeucau)
					{
						if (d_soluong>decimal.Parse(dt.Rows[i_row]["soluongyc"].ToString()))
						{
							MessageBox.Show("Số lượng phát không được lớn hơn số lượng yêu cầu !("+dt.Rows[i_row]["soluongyc"].ToString()+")",ttb.Msg);
							dataGrid1[i_row,9]=decimal.Parse(dt.Rows[i_row]["soluongyc"].ToString());
						}
					}
					d_soluongton=ttb.get_slton_nguon(dtton,i_makho,i_mabd,i_manguon,d_soluongcu);
					if (d_soluong>d_soluongton)
					{
						MessageBox.Show("Số lượng xuất lớn hơn số lượng tồn !("+d_soluongton.ToString()+")",ttb.Msg);
						dataGrid1[i_row,9]=d_soluongcu;
					}
					else
					{
						ttb.updrec_tonkho_nguon(dtton,i_makho,i_mabd,i_manguon,d_soluong-d_soluongcu,"-");
						dt.Rows[i_row]["soluongcu"]=d_soluong.ToString();
						dtton.AcceptChanges();
						dt.AcceptChanges();
					}
					DataRow r=ttb.getrowbyid(dtton,"makho="+i_makho+" and manguon="+i_manguon+" and id="+i_mabd);
					if (r!=null) dt.Rows[i_row]["ton"]=r["soluong"].ToString();
					if (d_soluong==0) dt.Rows[i_row]["chon"]=true;
					i_row=dataGrid1.CurrentRowIndex;
				}
			}
			catch{}
		}

		private void dataGrid1_Click(object sender, System.EventArgs e)
		{
			try
			{
				Point pt = this.dataGrid1.PointToClient(Control.MousePosition);
				DataGrid.HitTestInfo hti = this.dataGrid1.HitTest(pt);
				BindingManagerBase bmb = this.BindingContext[this.dataGrid1.DataSource, this.dataGrid1.DataMember];
				if(afterCurrentCellChanged && hti.Row < bmb.Count && hti.Type == DataGrid.HitTestType.Cell &&  hti.Column == checkCol )
				{	
					this.dataGrid1[hti.Row, checkCol] = !(bool)this.dataGrid1[hti.Row, checkCol];
					RefreshRow(hti.Row);
				}
				afterCurrentCellChanged = false;
			}
			catch{}
		}

		private void load_grid(string tu,string den,int iMakp)
		{
			if (i_loai==4 || bBuhaophi) //hao phi
			{
				sql="select a.id,trim(a.sophieu)||'/'||trim(c.makp) as mabn,'"+s_tenkp+"' as hoten,0 as mavaovien,0 as maql,0 as idkhoa,f.doituong,g.ten as tenkho,d.ma,";
                sql += "trim(d.ten)||' '||d.hamluong as ten,d.tenhc,d.dang,b.slyeucau-b.slthuc as soluong,b.slyeucau-b.slthuc as soluongcu,b.slyeucau-b.slthuc as soluongyc,0001.00 as sltd,";
                sql += " b.madoituong,b.makho,b.mabd,c.makp,c.makhoa,c.phieu,b.stt,a.idduyet,b.manguon,h.ten as tennguon,b.tutruc,'xx/xx/xxxx' as ngay,0000000.00 as coso,0000000.00 as ton,d.phatsau,d.hamluong,0 as sttt,to_char(c.ngay,'dd/mm/yyyy') as ngayylenh,0 as treo, 0 as traituyen ";
                sql += " from " + file1 + " a," + file2 + " b," + xxx + ".ttb_duyet c," + user + ".ttb_dmbd d," + d.user + ".d_doituong"+link+" f," + user + ".ttb_dmkho g," + user + ".ttb_dmnguon h";
                sql += " where a.id=b.id and a.idduyet=c.id and b.mabd=d.id and b.madoituong=f.madoituong and b.makho=g.id and b.manguon=h.id ";
				sql+=" and c.done<>0 and b.slyeucau>b.slthuc and c.nhom="+i_nhom+" and c.loai=4 and c.makp="+iMakp;
                sql += " and c.ngay between to_date('" + tu + "','" + f_ngay + "') and to_date('" + den + "','" + f_ngay + "')";
				if (s_kho!="") sql+=" and b.makho in ("+s_kho.Substring(0,s_kho.Length-1)+")";
				if (bBuhaophi) sql+=" and b.tutruc=1";
				else sql+=" and b.tutruc=0";
				if (s_phieu!="") sql+=" and c.phieu in ("+s_phieu.Substring(0,s_phieu.Length-1)+")";
				sql+=" order by c.makp,a.id,b.stt";
			}
			else
			{
				sql="select a.id,";
				if (bThua || i_thuoc==2) sql+=" trim(a.mabn)||'/'||trim(c.makp) as mabn,'"+s_tenkp+"' as hoten,";
				else sql+=" a.mabn,e.hoten as hoten,";
				sql+="a.mavaovien,a.maql,a.idkhoa,f.doituong,g.ten as tenkho,d.ma,";
				sql+="trim(d.ten)||' '||d.hamluong as ten,d.tenhc,d.dang,b.slyeucau-b.slthuc as soluong,b.slyeucau-b.slthuc as soluongcu,b.slyeucau-b.slthuc as soluongyc,0001.00 as sltd,";
				sql+="b.madoituong,b.makho,b.mabd,c.makp,c.makhoa,c.phieu,b.stt,a.idduyet,b.manguon,h.ten as tennguon,0 as tutruc,";
				if (i_loai==3) sql+="to_char(b.ngay,'dd/mm/yyyy') as ngay ";
				else sql+="'xx/xx/xxxx' as ngay ";
				sql+=",0000000.00 as coso,0000000.00 as ton,d.phatsau,d.hamluong";
				if (i_loai==3) sql+=",b.sttt";
				else sql+=",0 as sttt";
                sql += ",to_char(c.ngay,'dd/mm/yyyy') as ngayylenh,0 as treo";
                sql += (i_loai != 4) ? ", a.traituyen " : ", 0 as traituyen ";
                sql += " from " + file1 + " a inner join " + file2 + " b on a.id=b.id ";
                sql+=" inner join " + xxx + ".ttb_duyet c on a.idduyet=c.id ";
                sql+=" inner join " + user + ".ttb_dmbd d on b.mabd=d.id ";
                sql+=" left join " + d.user + ".btdbn"+link+" e on a.mabn=e.mabn ";
                sql+=" inner join " + d.user + ".d_doituong"+link+" f on b.madoituong=f.madoituong ";
                sql+=" inner join " + user + ".ttb_dmkho g on b.makho=g.id ";
                sql+=" inner join " + user + ".ttb_dmnguon h on b.manguon=h.id ";
				sql+=" where c.done<>0 ";
				if (bThua || i_thuoc==2) sql+=" and a.maql=0";
				sql+=" and b.slyeucau>b.slthuc and c.nhom="+i_nhom+" and c.loai="+i_loai+" and c.makhoa="+iMakp;
                sql += " and c.ngay between to_date('" + tu + "','" + f_ngay + "') and to_date('" + den + "','" + f_ngay + "')";
				if (s_kho!="") sql+=" and b.makho in ("+s_kho.Substring(0,s_kho.Length-1)+")";
				if (i_loai==1) sql+=" and b.tutruc=0";
				if (s_phieu!="") sql+=" and c.phieu in ("+s_phieu.Substring(0,s_phieu.Length-1)+")";
				if (i_loai!=2) sql+=" order by a.mabn,a.id,b.stt";
				if (i_loai==2) //lay tutruc -> du tru
				{
					sql+=" and b.idvpkhoa=0";
					sql+=" union all select a.id,a.mabn,e.hoten,a.mavaovien,a.maql,a.idkhoa,f.doituong,g.ten as tenkho,d.ma,";
					sql+=" trim(d.ten)||' '||d.hamluong as ten,d.tenhc,d.dang,b.slyeucau-b.slthuc as soluong,b.slyeucau-b.slthuc as soluongcu,b.slyeucau-b.slthuc as soluongyc,0001.00 as sltd,";
                    sql += " b.madoituong,b.makho,b.mabd,c.makp,c.makhoa,c.phieu,b.stt,a.idduyet,b.manguon,h.ten as tennguon,b.tutruc,'xx/xx/xxxx' as ngay,0000000.00 as coso,0000000.00 as ton,d.phatsau,d.hamluong,0 as sttt,to_char(c.ngay,'dd/mm/yyyy') as ngayylenh,0 as treo, a.traituyen";
					sql+=" from "+xxx+".ttb_dutrull a,"+xxx+".ttb_dutruct b,"+xxx+".ttb_duyet c,"+user+".ttb_dmbd d,"+d.user+".btdbn"+link+" e,"+d.user+".d_doituong"+link+" f,"+user+".ttb_dmkho g,"+user+".ttb_dmnguon h";
					sql+=" where a.id=b.id and a.idduyet=c.id and b.mabd=d.id and a.mabn=e.mabn and b.madoituong=f.madoituong and b.makho=g.id and b.manguon=h.id";
					sql+=" and c.done<>0 and b.slyeucau>b.slthuc and b.tutruc=1 and c.nhom="+i_nhom+" and c.loai=1 and c.makp="+iMakp;
                    sql+= " and c.ngay between to_date('" + tu + "','" + f_ngay + "') and to_date('" + den + "','" + f_ngay + "')";
					if (s_kho!="") sql+=" and b.makho in ("+s_kho.Substring(0,s_kho.Length-1)+")";
					if (s_phieu!="") sql+=" and c.phieu in ("+s_phieu.Substring(0,s_phieu.Length-1)+")";
				}
			}
			dt=ttb.get_data(sql).Tables[0];
			if (bCongdon)
			{
				dtct=dt.Copy();
				dt.Clear();
				DataRow r2,r3;
				DataRow [] dr;
				foreach(DataRow r4 in dtct.Rows)
				{
					sql="makho="+int.Parse(r4["makho"].ToString())+" and mabd="+int.Parse(r4["mabd"].ToString());
					if (bBucstt_nguon) sql+=" and manguon="+int.Parse(r4["manguon"].ToString());
					if (!ttb.bPhattron_congdondoituong(i_nhom)) sql+=" and madoituong="+int.Parse(r4["madoituong"].ToString());
					r2=ttb.getrowbyid(dt,sql);
					if (r2==null)
					{
						r3=dt.NewRow();
						r3["makho"]=r4["makho"].ToString();
						r3["tenkho"]=r4["tenkho"].ToString();
						r3["makp"]=r4["makp"].ToString();
						r3["makhoa"]=r4["makhoa"].ToString();
						r3["manguon"]=r4["manguon"].ToString();
						r3["tennguon"]=r4["tennguon"].ToString();
						r3["mabd"]=r4["mabd"].ToString();
						r3["ma"]=r4["ma"].ToString();
						r3["ten"]=r4["ten"].ToString();
						r3["tenhc"]=r4["tenhc"].ToString();
						r3["dang"]=r4["dang"].ToString();
						r3["madoituong"]=r4["madoituong"].ToString();
						r3["tutruc"]=r4["tutruc"].ToString();
						r3["coso"]=r4["coso"].ToString();
						r3["ton"]=r4["ton"].ToString();
						r3["phatsau"]=r4["phatsau"].ToString();
						r3["soluong"]=r4["soluong"].ToString();
						r3["ngay"]=r4["ngay"].ToString();
						r3["sltd"]=r4["sltd"].ToString();
						r3["soluongcu"]=r4["soluongcu"].ToString();
						r3["soluongyc"]=r4["soluongyc"].ToString();
                        r3["treo"] = 0;
                        r3["traituyen"] = r4["traituyen"].ToString();
						dt.Rows.Add(r3);
					}
					else
					{
						dr=dt.Select(sql);
						if (dr.Length>0)
						{
							dr[0]["soluong"]=decimal.Parse(dr[0]["soluong"].ToString())+decimal.Parse(r4["soluong"].ToString());
							dr[0]["soluongcu"]=decimal.Parse(dr[0]["soluongcu"].ToString())+decimal.Parse(r4["soluongcu"].ToString());
							dr[0]["soluongyc"]=decimal.Parse(dr[0]["soluongyc"].ToString())+decimal.Parse(r4["soluongyc"].ToString());
						}
					}
				}
			}
			dataGrid1.DataSource=dt;
			if (!bSkip) AddGridTableStyle();
			bSkip=true;
			CurrencyManager cm = (CurrencyManager)BindingContext[dataGrid1.DataSource,dataGrid1.DataMember]; 
			DataView dv = (DataView) cm.List; 
			dv.AllowNew = false; 
			dt.Columns.Add("Chon",typeof(bool));
			DataRow r,r1;
			foreach (DataRow row in dt.Rows)
			{
				if (row["phatsau"].ToString()=="1") row["chon"]=true;
				else row["chon"]=false;
				if (i_loai==2 || bBuhaophi)
				{
					r=ttb.getrowbyid(dtcstt,"makp="+iMakp+" and mabd="+int.Parse(row["mabd"].ToString()));
					if (r!=null) row["coso"]=r["soluong"].ToString();
				}
				#region kiem tra ton kho
				if ((i_loai==3 && i_thuoc==1)==false)
				{
					d_soluong=decimal.Parse(row["soluong"].ToString());
					i_mabd=int.Parse(row["mabd"].ToString());
					i_makho=int.Parse(row["makho"].ToString());
					i_manguon=int.Parse(row["manguon"].ToString());
					if (i_loai==1 || i_loai==2 || bBuhaophi)
					{
						sql="soluong>"+d_soluong+" and makho="+i_makho+" and id="+i_mabd;
						sql+=" and manguon="+i_manguon;
						r=ttb.getrowbyid(dtton,sql);
						if (r==null)
						{
							sql="soluong>="+d_soluong+" and makho="+i_makho+" and ten='"+row["ten"].ToString()+"'"+" and dang='"+row["dang"].ToString()+"'";
							if (bBucstt_nguon) sql+=" and manguon="+i_manguon;
							r1=ttb.getrowbyid(dtton,sql);
							if (r1!=null)
							{
								row["mabd"]=r1["id"].ToString();
								row["ten"]=r1["ten"].ToString();
								row["dang"]=r1["dang"].ToString();
								row["manguon"]=r1["manguon"].ToString();
								i_mabd=int.Parse(row["mabd"].ToString());
								i_manguon=int.Parse(row["manguon"].ToString());
							}
							else //tuong duong
							{
								bool bFound=false;
								foreach(DataRow r2 in ttb.get_data("select mabd,soluong from "+user+".d_dmbdtd where id="+int.Parse(row["mabd"].ToString())).Tables[0].Rows)
								{
									d_soluong=decimal.Parse(row["soluong"].ToString())*decimal.Parse(r2["soluong"].ToString());
									sql="makho="+i_makho+" and id="+int.Parse(r2["mabd"].ToString())+" and soluong>="+d_soluong;
									if (bBucstt_nguon) sql+=" and manguon="+i_manguon;
									r1=ttb.getrowbyid(dtton,sql);
									if (r1!=null)
									{
										row["mabd"]=r1["id"].ToString();
										row["ten"]=r1["ten"].ToString();
										row["dang"]=r1["dang"].ToString();
										row["manguon"]=r1["manguon"].ToString();
										row["soluong"]=d_soluong;
										row["sltd"]=r2["soluong"].ToString();
										i_mabd=int.Parse(row["mabd"].ToString());
										i_manguon=int.Parse(row["manguon"].ToString());
										bFound=true;
										break;
									}
								}
								//hoatchat - hamluong - dvt 
								if (!bFound && row["tenhc"].ToString()!="")
								{
									d_soluong=decimal.Parse(row["soluong"].ToString());
									sql="soluong>="+d_soluong+" and makho="+i_makho+" and tenhc='"+row["tenhc"].ToString()+"'"+" and dang='"+row["dang"].ToString()+"' and hamluong='"+row["hamluong"].ToString()+"'";
									if (bBucstt_nguon) sql+=" and manguon="+i_manguon;
									r1=ttb.getrowbyid(dtton,sql);
									if (r1!=null)
									{
										row["mabd"]=r1["id"].ToString();
										row["ten"]=r1["ten"].ToString();
										row["dang"]=r1["dang"].ToString();
										row["manguon"]=r1["manguon"].ToString();
										i_mabd=int.Parse(row["mabd"].ToString());
										i_manguon=int.Parse(row["manguon"].ToString());
									}
								}
							}
						}
					}
					d_soluongcu=0;//decimal.Parse(row["soluongcu"].ToString());
					d_soluongton=ttb.get_slton_nguon(dtton,i_makho,i_mabd,i_manguon,d_soluongcu);
					if (d_soluong>d_soluongton) row["soluong"]=Math.Max(d_soluongton,0);
					//else
					//{
						ttb.updrec_tonkho_nguon(dtton,i_makho,i_mabd,i_manguon,d_soluong-d_soluongcu,"-");
						dtton.AcceptChanges();
					//}
					if (row["soluong"].ToString().Trim()=="0") row["chon"]=true;
					r=ttb.getrowbyid(dtton,"makho="+i_makho+" and manguon="+i_manguon+" and id="+i_mabd);
					if (r!=null) row["ton"]=r["soluong"].ToString();
				}
				#endregion
			}
			butLuu.Enabled=dt.Rows.Count!=0;
			dataGrid1.Focus();
			i_row=dataGrid1.CurrentRowIndex;
		}

		private void butLay_Click(object sender, System.EventArgs e)
		{
            frmTuden f=new frmTuden(ttb,dtkp,dtphieu,i_nhom,int.Parse(makp.SelectedValue.ToString()),i_loai,int.Parse(phieu.SelectedValue.ToString()),s_ngay,bCongdon,bThua,s_kho,s_mmyy);
			f.ShowDialog(this);
			if (f.s_tu!="")
			{
				Cursor=Cursors.WaitCursor;
				if (i_loai!=3) ttb.upd_tonkho(s_mmyy,i_nhom,0);
				o_tu=f.s_tu;o_den=f.s_den;o_makp=f.i_makp;o_phieu=f.i_phieu;s_tenkp=f.s_tenkp;s_phieu=f.s_phieu;o_makhoa=o_makp;
				if (i_loai==3 && i_thuoc==2) dtton=ttb.get_tutructh_duyet(s_mmyy,s_kho,o_makp);
				else if (i_loai!=3)	dtton=ttb.get_tonkhoth_duyet(s_mmyy,s_kho);
				if (i_loai==2 && !bBuhaophi)
				{
					sql="select makp,count(*) from "+xxx+".ttb_duyet ";
					sql+=" where done<>0 and nhom="+i_nhom+" and loai="+i_loai+" and makhoa="+o_makp;
                    sql+=" and ngay between to_date('" + o_tu + "','" + f_ngay + "') and to_date('" + o_den + "','" + f_ngay + "')";
					if (s_phieu!="") sql+=" and phieu in ("+s_phieu.Substring(0,s_phieu.Length-1)+")";
					sql+=" group by makp";
					if (ttb.get_data(sql).Tables[0].Rows.Count>1)
					{
						Cursor=Cursors.Default;
						MessageBox.Show("Không duyệt được vì có nhiều khoa !",ttb.Msg);
						return;
					}
				}
				load_grid(o_tu,o_den,o_makp);
				makp.SelectedValue=o_makp;
				phieu.SelectedValue=o_phieu;
				Cursor=Cursors.Default;
			}
		}

		private void butBoqua_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void butLuu_Click(object sender, System.EventArgs e)
		{
			Cursor=Cursors.WaitCursor;
			CurrencyManager cm= (CurrencyManager)BindingContext[dataGrid1.DataSource];
			DataView dv=(DataView)cm.List;
			dv.RowFilter="";s_ravien="";
			if (bBuhaophi) phieu_butruc();
			else
			{
				switch (i_loai)
				{
					case 1: phieu_dutru();
						break;
					case 2: phieu_butruc();
						break;
					case 3: phieu_hoantra();
						break;
					default: phieu_dutru();
						break;
				}
			}
			if (bPhattron)
			{
                if (i_loai == 2 || bBuhaophi) ttb.upd_thucbucstt(s_ngay, i_nhom, i_loai, o_phieu, o_makp, o_makhoa, s_mmyy, 0);
                else
                {
                    if (i_loai != 3)
                    {
                        sql = "select b.*,c.handung,c.losx,c.manguon,c.nhomcc,c.giamua ";
                        sql += " from " + user + ".ttb_xuatsdll a," + user + ".ttb_xuatsdct b," + user + ".ttb_theodoi c ";
                        sql += " where a.id=b.id and b.sttt=c.id and a.nhom=" + i_nhom + " and a.loai=" + i_loai;
                        sql += " and a.phieu=" + o_phieu + " and to_char(a.ngay,'dd/mm/yyyy')='" + s_ngay + "' and a.makp=" + o_makp;
                        foreach (DataRow r in ttb.get_data(sql).Tables[0].Rows)
                            ttb.upd_tonkhoct_thucbucstt(ttb.delete, s_mmyy, o_makp, decimal.Parse(r["sttt"].ToString()), int.Parse(r["makho"].ToString()), int.Parse(r["manguon"].ToString()), int.Parse(r["nhomcc"].ToString()), int.Parse(r["mabd"].ToString()), r["handung"].ToString(), r["losx"].ToString(), decimal.Parse(r["soluong"].ToString()), decimal.Parse(r["soluong"].ToString()) * decimal.Parse(r["giamua"].ToString()), decimal.Parse(r["giaban"].ToString()), decimal.Parse(r["giamua"].ToString()));
                    }
                    ttb.upd_thucxuat(s_ngay, i_nhom, i_loai, o_phieu, o_makp, o_makhoa, s_mmyy, i_thuoc, 0);
                }
			}
			if (i_loai==3 && i_thuoc==2) dtton=ttb.get_tutructh_duyet(s_mmyy,s_kho,o_makp);
			else if (i_loai!=3)	dtton=ttb.get_tonkhoth_duyet(s_mmyy,s_kho);
			ttb.upd_theodoiduyet(s_mmyy,s_ngay,i_nhom,i_loai,o_makp,2);
			sql="select * from "+user+".ttb_dmkho where nhom="+i_nhom;
			if (s_kho!="") sql+=" and id in ("+s_kho.Substring(0,s_kho.Length-1)+")";
			foreach(DataRow r in ttb.get_data(sql).Tables[0].Rows)
				ttb.upd_daduyet(s_mmyy,i_nhom,s_ngay,o_makhoa,i_loai,o_phieu,int.Parse(r["id"].ToString()));
			load_grid(o_tu,o_den,o_makp);
			bOk=true;
			Cursor=Cursors.Default;
			butLuu.Enabled=false;
			if (s_ravien!="")
				MessageBox.Show("Người bệnh đã ra viện\n"+s_ravien+"\nkhông thực hiện được !",ttb.Msg);
			if (ttb.bTinnhan(i_nhom))
			{
				DataRow r=ttb.getrowbyid(dtkp,"id="+int.Parse(makp.SelectedValue.ToString()));
				if (r!=null)
				{
					if (r["computer"].ToString()!="")
						ttb.netsend(ttb.sDomain(i_nhom),r["computer"].ToString().Trim(),s_noidung+" KHOA "+ttb.khongdau(makp.Text)+" PHIEU "+ttb.khongdau(phieu.Text)+" DA DUYET XONG !");
				}
			}
		}

		private void phieu_dutru()
		{
			DataRow r2;
			bool bFound=false,bRavien=false;
			if (i_loai==1 && bKiemtra)
			{
				r2=ttb.getrowbyid(dtkp,"id="+int.Parse(makp.SelectedValue.ToString()));
				if (r2!=null)
				{
					sql="select maql from "+user+".xuatvien where makp='"+r2["makp"].ToString()+"'";
					dthoten=ttb.get_data(sql).Tables[0];
					bFound=true;
				}
			}
			decimal id=0,idduyet=0;
			DataRow [] dr=dt.Select("chon=false and soluong>0","id,stt");
			for(int i=0;i<dr.Length;i++)
			{
				if (idduyet!=decimal.Parse(dr[i]["id"].ToString()))
				{
					if (bFound)
					{
						r2=ttb.getrowbyid(dthoten,"maql="+decimal.Parse(dr[i]["maql"].ToString()));
						if (r2!=null)
						{
							if (s_ravien.IndexOf(dr[i]["mabn"].ToString())==-1) s_ravien+=dr[i]["mabn"].ToString()+";";
							bRavien=true;
						}
						else bRavien=false;
					}
					if (!bRavien)
					{
						idduyet=decimal.Parse(dr[i]["id"].ToString());
						id=ttb.get_id_xuatsd;
                        ttb.upd_xuatsdll(s_mmyy, id, i_nhom, dr[i]["mabn"].ToString(), decimal.Parse(dr[i]["mavaovien"].ToString()), decimal.Parse(dr[i]["maql"].ToString()), decimal.Parse(dr[i]["idkhoa"].ToString()), s_ngay, i_loai, o_phieu, int.Parse(dr[i]["makp"].ToString()), i_userid, idduyet, i_thuoc, int.Parse(dr[i]["makhoa"].ToString()), 0, (bPhattron) ? 1 : 0, "", dr[i]["ngayylenh"].ToString());
                        sql = "select a.*,t.manguon,t.nhomcc,t.handung,t.losx,t.giamua,t.giaban,b.ten as tennguon,c.ten as tennhomcc from " + xxx + ".ttb_tonkhoct a," + xxx + ".ttb_theodoi t," + user + ".ttb_dmnguon b," + user + ".ttb_dmnx c where a.stt=t.id and t.manguon=b.id and t.nhomcc=c.id";
                        dtct = ttb.get_xuatsdct(s_mmyy, dt.Select("chon=false and id=" + idduyet, "stt"), sql, id, idduyet, bPhattron, i_thuoc, i_loai, file2, int.Parse(dr[i]["makp"].ToString()), int.Parse(dr[i]["makhoa"].ToString()), dr[i]["mabn"].ToString(), decimal.Parse(dr[i]["mavaovien"].ToString()), decimal.Parse(dr[i]["maql"].ToString()), decimal.Parse(dr[i]["idkhoa"].ToString()), s_ngay, decimal.Parse(dr[i]["sltd"].ToString()), bBuhaophi, dr[i]["ngayylenh"].ToString(),false, int.Parse(dr[i]["traituyen"].ToString()));
						s_sttduyet="";
						foreach(DataRow r4 in dtct.Rows) s_sttduyet+=r4["sttduyet"].ToString().Trim()+",";
						ttb.updrec_xuatsdll(dtll,id,dr[i]["mabn"].ToString(),dr[i]["hoten"].ToString(),s_ngay,o_phieu,int.Parse(dr[i]["makp"].ToString()),idduyet,int.Parse(dr[i]["makhoa"].ToString()));
						ttb.upd_ngayduyet(s_mmyy,i_nhom,i_loai,o_phieu,int.Parse(dr[i]["makhoa"].ToString()),s_ngay,idduyet,s_kho,s_sttduyet);
						ttb.execute_data("update "+xxx+".ttb_duyet set done=2 where id="+decimal.Parse(dr[i]["idduyet"].ToString()));
                        ttb.execute_data("update " + xxx + ".ttb_duyetkho set done=2 where idduyet=" + decimal.Parse(dr[i]["idduyet"].ToString())+"and makho="+decimal.Parse(dr[i]["makho"].ToString()));//sua ngay 16/10/2014
					}
				}
			}
		}

		private void butruc_congdon()
		{
			DataRow [] dr1,dr=dt.Select("chon=false and soluong>0","makho,manguon,madoituong,mabd");
			dt=dtct.Copy();
			dt.Columns.Add("Chon",typeof(bool));
			foreach(DataRow r in dt.Rows) r["chon"]=true;
			bool congdondoituong=ttb.bPhattron_congdondoituong(i_nhom);
			foreach(DataRow r in dr)
			{
				sql="makho="+int.Parse(r["makho"].ToString())+" and mabd="+int.Parse(r["mabd"].ToString());
				if (bBucstt_nguon) sql+=" and manguon="+int.Parse(r["manguon"].ToString());
				if (!congdondoituong) sql+=" and madoituong="+int.Parse(r["madoituong"].ToString());
				d_soluong=decimal.Parse(r["soluong"].ToString());
				foreach(DataRow r1 in dt.Select(sql,"id"))
				{
					d_soluongcu=Math.Min(decimal.Parse(r1["soluong"].ToString()),d_soluong);
					if (d_soluongcu>0)
					{
						r1["soluong"]=d_soluongcu.ToString();
						r1["chon"]=false;
						d_soluong-=d_soluongcu; 
					}
				}
				if (d_soluong>0)
				{
					sql+=" and chon=false";
					dr1=dt.Select(sql,"id");
					if (dr1.Length>0) dr1[0]["soluong"]=decimal.Parse(dr1[0]["soluong"].ToString())+d_soluong;
				}
			}
			dt.AcceptChanges();
		}

		private void phieu_butruc()
		{
			if (bCongdon) butruc_congdon();
			decimal id=0,idduyet=0;
			DataRow [] dr=dt.Select("chon=false and soluong>0","id,stt");
			for(int i=0;i<dr.Length;i++)
			{
				if (idduyet!=decimal.Parse(dr[i]["id"].ToString()))
				{
					idduyet=decimal.Parse(dr[i]["id"].ToString());
					id=ttb.get_id_xuatsd;
                    ttb.upd_xuatsdll(s_mmyy, id, i_nhom, dr[i]["mabn"].ToString(), decimal.Parse(dr[i]["mavaovien"].ToString()), decimal.Parse(dr[i]["maql"].ToString()), decimal.Parse(dr[i]["idkhoa"].ToString()), s_ngay, i_loai, o_phieu, int.Parse(dr[i]["makp"].ToString()), i_userid, idduyet, i_thuoc, int.Parse(dr[i]["makhoa"].ToString()), 0, (bPhattron) ? 1 : 0, "", dr[i]["ngayylenh"].ToString());
                    sql = "select a.*,t.manguon,t.nhomcc,t.handung,t.losx,t.giamua,t.giaban,b.ten as tennguon,c.ten as tennhomcc from " + xxx + ".ttb_tonkhoct a," + xxx + ".ttb_theodoi t," + user + ".ttb_dmnguon b," + user + ".ttb_dmnx c where a.stt=t.id and t.manguon=b.id and t.nhomcc=c.id ";
                    dtct = ttb.get_xuatsdct(s_mmyy, dt.Select("chon=false and id=" + idduyet, "stt"), sql, id, idduyet, bPhattron, i_thuoc, i_loai, file2, int.Parse(dr[i]["makp"].ToString()), int.Parse(dr[i]["makhoa"].ToString()), dr[i]["mabn"].ToString(), decimal.Parse(dr[i]["mavaovien"].ToString()), decimal.Parse(dr[i]["maql"].ToString()), decimal.Parse(dr[i]["idkhoa"].ToString()), s_ngay, decimal.Parse(dr[i]["sltd"].ToString()), bBuhaophi, dr[i]["ngayylenh"].ToString(),false,int.Parse(dr[i]["traituyen"].ToString()));
					s_sttduyet="";
					foreach(DataRow r4 in dtct.Rows) s_sttduyet+=r4["sttduyet"].ToString().Trim()+",";
					ttb.updrec_xuatsdll(dtll,id,dr[i]["mabn"].ToString(),dr[i]["hoten"].ToString(),s_ngay,o_phieu,int.Parse(dr[i]["makp"].ToString()),idduyet,int.Parse(dr[i]["makhoa"].ToString()));
					ttb.upd_ngayduyet(s_mmyy,i_nhom,i_loai,o_phieu,int.Parse(dr[i]["makhoa"].ToString()),s_ngay,idduyet,s_kho,s_sttduyet);
					ttb.execute_data("update "+xxx+".ttb_duyet set done=2 where id="+decimal.Parse(dr[i]["idduyet"].ToString()));
					o_makhoa=int.Parse(dr[i]["makhoa"].ToString());
					o_makp=int.Parse(dr[i]["makp"].ToString());
				}
			}
		}

		private void phieu_hoantra()
		{
			if (i_thuoc==2) phieu_hoantrataisan();
			else if (bThua) phieu_hoantrathua();
			else
			{
				DataRow r2;
				bool bFound=false,bRavien=false;
				if (bKiemtra)
				{
					r2=ttb.getrowbyid(dtkp,"id="+int.Parse(makp.SelectedValue.ToString()));
					if (r2!=null)
					{
						sql="select maql from "+user+".xuatvien where makp='"+r2["makp"].ToString()+"'";
						dthoten=ttb.get_data(sql).Tables[0];
						bFound=true;
					}
				}
				DataSet dstonct=new DataSet();
				s_min="";s_max="";
				foreach(DataRow r in dt.Rows)
				{
					s_min=(s_min=="")?r["ngay"].ToString():ttb.MinNgay(s_min,r["ngay"].ToString());
					s_max=(s_max=="")?r["ngay"].ToString():ttb.MaxNgay(s_max,r["ngay"].ToString());
				}
				DateTime dt1=ttb.StringToDate(s_min).AddDays(-ttb.iNgaykiemke);
				DateTime dt2=ttb.StringToDate(s_max).AddDays(ttb.iNgaykiemke);
				int y1=dt1.Year,m1=dt1.Month;
				int y2=dt2.Year,m2=dt2.Month;
				int tu,den,be=0;
				string mmyy="";
				for(int i=y1;i<=y2;i++)
				{
					tu=(i==y1)?m1:1;
					den=(i==y2)?m2:12;
					for(int j=tu;j<=den;j++)
					{
						mmyy=j.ToString().PadLeft(2,'0')+i.ToString().Substring(2,2);
						if (ttb.bMmyy(mmyy))
						{
                            sql = "select a.mabn,a.mavaovien,a.maql,to_char(a.ngay,'dd/mm/yyyy') as ngay,b.*,t.manguon,t.nhomcc,t.handung,t.losx,t.giamua,t.gianovat,t.giaban,c.ten as tennguon,d.ten as tennhomcc,' ' as doituong from " + user + mmyy + ".ttb_xuatsdll a," + user + mmyy + ".ttb_xuatsdct b," + user + ".ttb_dmnguon c," + user + ".ttb_dmnx d," + user + mmyy + ".ttb_theodoi t where a.id=b.id and b.sttt=t.id and a.loai in (1,2) and t.manguon=c.id and t.nhomcc=d.id and a.makp=" + o_makp + " and a.ngay between to_date('" + s_min + "','" + f_ngay + "') and to_date('" + s_max + "','" + f_ngay + "')";
                            if (s_kho != "") sql += " and b.makho in (" + s_kho.Substring(0, s_kho.Length - 1) + ")";
                            sql += " order by b.sttt";
                            if (be == 0) dstonct = ttb.get_data(sql);
                            else dstonct.Merge(ttb.get_data(sql));
                            be++;
						}
					}
				}
				DataTable tonct=dstonct.Tables[0];
				decimal id=0,idduyet=0;
				DataRow [] dr=dt.Select("chon=false and soluong>0","id,stt");
				for(int i=0;i<dr.Length;i++)
				{
					if (idduyet!=decimal.Parse(dr[i]["id"].ToString()))
					{
						if (bFound)
						{
							r2=ttb.getrowbyid(dthoten,"maql="+decimal.Parse(dr[i]["maql"].ToString()));
							if (r2!=null)
							{
								if (s_ravien.IndexOf(dr[i]["mabn"].ToString())==-1) s_ravien+=dr[i]["mabn"].ToString()+";";
								bRavien=true;
							}
							else bRavien=false;
						}
						if (!bRavien)
						{
							idduyet=decimal.Parse(dr[i]["id"].ToString());
							id=ttb.get_id_xuatsd;
                            ttb.upd_xuatsdll(s_mmyy, id, i_nhom, dr[i]["mabn"].ToString(), decimal.Parse(dr[i]["mavaovien"].ToString()), decimal.Parse(dr[i]["maql"].ToString()), decimal.Parse(dr[i]["idkhoa"].ToString()), s_ngay, i_loai, o_phieu, int.Parse(dr[i]["makp"].ToString()), i_userid, idduyet, i_thuoc, int.Parse(dr[i]["makhoa"].ToString()), 0, (bPhattron) ? 1 : 0, "", dr[i]["ngayylenh"].ToString());
							s_sttduyet="";
							foreach(DataRow r1 in ttb.get_xuatsdctht(dt.Select("chon=false and id="+idduyet,"stt"),tonct,id,i_nhom,s_ngay).Rows)
							{
                                ttb.upd_xuatsdct(s_mmyy, id, int.Parse(r1["stt"].ToString()), decimal.Parse(r1["sttt"].ToString()), int.Parse(r1["madoituong"].ToString()), int.Parse(r1["makho"].ToString()), int.Parse(r1["mabd"].ToString()), decimal.Parse(r1["soluong"].ToString()), int.Parse(r1["sttduyet"].ToString()), decimal.Parse(r1["giaban"].ToString()), r1["ngay"].ToString());
								if (!bPhattron)
								{
                                    ttb.upd_thucxuat_stt(s_mmyy, id, decimal.Parse(r1["sttt"].ToString()), int.Parse(r1["madoituong"].ToString()), int.Parse(r1["makho"].ToString()), int.Parse(r1["mabd"].ToString()), decimal.Parse(r1["soluong"].ToString()), int.Parse(r1["stt"].ToString()), decimal.Parse(r1["giaban"].ToString()));
									ttb.upd_tonkhoct_thucxuat(ttb.insert,s_mmyy,int.Parse(dr[i]["makp"].ToString()),i_loai,i_thuoc,decimal.Parse(r1["sttt"].ToString()),int.Parse(r1["makho"].ToString()),int.Parse(r1["manguon"].ToString()),int.Parse(r1["mabd"].ToString()),decimal.Parse(r1["soluong"].ToString()));
								}
								if (i_thuoc==1)
								{
                                    ttb.upd_tienthuoc(ttb.insert, s_mmyy, id, dr[i]["mabn"].ToString(), decimal.Parse(dr[i]["mavaovien"].ToString()), decimal.Parse(dr[i]["maql"].ToString()), decimal.Parse(dr[i]["idkhoa"].ToString()), s_ngay, int.Parse(dr[i]["makp"].ToString()), i_loai, int.Parse(r1["madoituong"].ToString()), int.Parse(r1["mabd"].ToString()), decimal.Parse(r1["soluong"].ToString()), decimal.Parse(r1["giaban"].ToString()), decimal.Parse(r1["giamua"].ToString()), decimal.Parse(r1["gianovat"].ToString()), int.Parse(dr[i]["traituyen"].ToString()));
									ttb.upd_theodoicongno(ttb.delete,dr[i]["mabn"].ToString(),decimal.Parse(dr[i]["mavaovien"].ToString()),decimal.Parse(dr[i]["maql"].ToString()),decimal.Parse(dr[i]["idkhoa"].ToString()),int.Parse(r1["madoituong"].ToString()),decimal.Parse(r1["sotien"].ToString()),"thuoc");
								}
								ttb.execute_data("update "+file2+" set slthuc=slthuc+"+decimal.Parse(r1["soluong"].ToString())+" where id="+idduyet+" and stt="+int.Parse(r1["sttduyet"].ToString()));
								s_sttduyet+=r1["sttduyet"].ToString().Trim()+",";
							}
							ttb.updrec_xuatsdll(dtll,id,dr[i]["mabn"].ToString(),dr[i]["hoten"].ToString(),s_ngay,o_phieu,int.Parse(dr[i]["makp"].ToString()),idduyet,int.Parse(dr[i]["makhoa"].ToString()));
							ttb.upd_ngayduyet(s_mmyy,i_nhom,i_loai,o_phieu,int.Parse(dr[i]["makp"].ToString()),s_ngay,idduyet,s_kho,s_sttduyet);
							ttb.execute_data("update "+xxx+".ttb_duyet set done=2 where id="+decimal.Parse(dr[i]["idduyet"].ToString()));
						}
					}
				}
			}
		}

		private void phieu_hoantrathua()
		{
			DataTable tmp;
			int i_nhomcc=0;
			if (ttb.bQuanlynhomcc(i_nhom))
			{
				tmp=ttb.get_data("select * from "+user+".ttb_dmnx where nhom="+i_nhom+" order by stt").Tables[0];
				i_nhomcc=(tmp.Rows.Count>0)?int.Parse(tmp.Rows[0]["id"].ToString()):0;
			}
			decimal id=0,idduyet=0,sttt;
			decimal d_sotien;
			DataRow [] dr1,dr=dt.Select("chon=false and soluong>0","id,stt");
			for(int i=0;i<dr.Length;i++)
			{
				if (idduyet!=decimal.Parse(dr[i]["id"].ToString()))
				{
					idduyet=decimal.Parse(dr[i]["id"].ToString());
					id=ttb.get_id_xuatsd;
                    ttb.upd_xuatsdll(s_mmyy, id, i_nhom, dr[i]["mabn"].ToString(), decimal.Parse(dr[i]["mavaovien"].ToString()), decimal.Parse(dr[i]["maql"].ToString()), decimal.Parse(dr[i]["idkhoa"].ToString()), s_ngay, i_loai, o_phieu, int.Parse(dr[i]["makp"].ToString()), i_userid, idduyet, i_thuoc, int.Parse(dr[i]["makhoa"].ToString()), 0, (bPhattron) ? 1 : 0, "", dr[i]["ngayylenh"].ToString());
					dr1=dt.Select("chon=false and soluong>0 and id="+idduyet,"stt");
					s_sttduyet="";
					for(int j=0;j<dr1.Length;j++)
					{
						d_sotien=decimal.Parse(dr1[j]["soluong"].ToString())*decimal.Parse(dr1[j]["giamua"].ToString());
						sttt=ttb.get_id_tonkho;
                        ttb.upd_xuatsdct(s_mmyy, id, int.Parse(dr1[j]["stt"].ToString()), sttt, int.Parse(dr1[j]["madoituong"].ToString()), int.Parse(dr1[j]["makho"].ToString()), int.Parse(dr1[j]["mabd"].ToString()), decimal.Parse(dr1[j]["soluong"].ToString()), int.Parse(dr1[j]["stt"].ToString()), decimal.Parse(dr1[j]["giaban"].ToString()), dr[i]["ngayylenh"].ToString());
						if (!bPhattron)
						{
                            ttb.upd_thucxuat_stt(s_mmyy, id, sttt, int.Parse(dr1[j]["madoituong"].ToString()), int.Parse(dr1[j]["makho"].ToString()), int.Parse(dr1[j]["mabd"].ToString()), decimal.Parse(dr1[j]["soluong"].ToString()), int.Parse(dr1[j]["stt"].ToString()), decimal.Parse(dr1[j]["giaban"].ToString()));
							ttb.upd_tonkhoct_thucxuat(ttb.insert,s_mmyy,int.Parse(dr[i]["makp"].ToString()),i_loai,i_thuoc,sttt,int.Parse(dr1[j]["makho"].ToString()),int.Parse(dr1[j]["manguon"].ToString()),int.Parse(dr1[j]["mabd"].ToString()),decimal.Parse(dr1[j]["soluong"].ToString()));
						}
						s_sttduyet+=dr1[j]["stt"].ToString().Trim()+",";
						ttb.execute_data("update "+file2+" set slthuc=slthuc+"+decimal.Parse(dr1[j]["soluong"].ToString())+" where id="+idduyet+" and stt="+int.Parse(dr1[j]["stt"].ToString()));
                        ttb.upd_theodoi(s_mmyy, sttt, int.Parse(dr1[j]["mabd"].ToString()), int.Parse(dr1[j]["manguon"].ToString()), i_nhomcc, dr1[j]["handung"].ToString(), dr1[j]["losx"].ToString(), "", "", "", 0, 0, 0, decimal.Parse(dr1[j]["giamua"].ToString()), decimal.Parse(dr1[j]["giaban"].ToString()), decimal.Parse(dr1[j]["giamua"].ToString()),0,0);
					}
					ttb.updrec_xuatsdll(dtll,id,dr[i]["mabn"].ToString(),dr[i]["hoten"].ToString(),s_ngay,o_phieu,int.Parse(dr[i]["makp"].ToString()),idduyet,int.Parse(dr[i]["makhoa"].ToString()));
					ttb.upd_ngayduyet(s_mmyy,i_nhom,i_loai,o_phieu,int.Parse(dr[i]["makp"].ToString()),s_ngay,idduyet,s_kho,s_sttduyet);
					ttb.execute_data("update "+xxx+".ttb_duyet set done=2 where id="+decimal.Parse(dr[i]["idduyet"].ToString()));
				}
			}
		}

		private void phieu_hoantrataisan()
		{
			decimal id=0,idduyet=0;
			DataRow [] dr=dt.Select("chon=false and soluong>0","id,stt");
			for(int i=0;i<dr.Length;i++)
			{
				if (idduyet!=decimal.Parse(dr[i]["id"].ToString()))
				{
					idduyet=decimal.Parse(dr[i]["id"].ToString());
					id=ttb.get_id_xuatsd;
                    ttb.upd_xuatsdll(s_mmyy, id, i_nhom, dr[i]["mabn"].ToString(), decimal.Parse(dr[i]["mavaovien"].ToString()), decimal.Parse(dr[i]["maql"].ToString()), decimal.Parse(dr[i]["idkhoa"].ToString()), s_ngay, i_loai, o_phieu, int.Parse(dr[i]["makp"].ToString()), i_userid, idduyet, i_thuoc, int.Parse(dr[i]["makhoa"].ToString()), 0, (bPhattron) ? 1 : 0, "", dr[i]["ngayylenh"].ToString());
                    sql = "select a.*,t.manguon,t.nhomcc,t.handung,t.losx,t.giamua,t.giaban,t.gianovat,b.ten as tennguon,c.ten as tennhomcc from " + xxx + ".ttb_tutrucct a," + xxx + ".ttb_theodoi t," + user + ".ttb_dmnguon b," + user + ".ttb_dmnx c where a.mmyy='"+s_mmyy+"' and a.stt=t.id and t.manguon=b.id and t.nhomcc=c.id and a.makp=" + o_makp;
                    dtct = ttb.get_hoantra_taisan(s_mmyy, dt.Select("chon=false and id=" + idduyet, "stt"), sql, id, idduyet, bPhattron, i_thuoc, i_loai, file2, int.Parse(dr[i]["makp"].ToString()), int.Parse(dr[i]["makhoa"].ToString()), dr[i]["mabn"].ToString(), decimal.Parse(dr[i]["mavaovien"].ToString()), decimal.Parse(dr[i]["maql"].ToString()), decimal.Parse(dr[i]["idkhoa"].ToString()), s_ngay, decimal.Parse(dr[i]["sltd"].ToString()), bBuhaophi, dr[i]["ngayylenh"].ToString());
					s_sttduyet="";
					foreach(DataRow r4 in dtct.Rows) s_sttduyet+=r4["sttduyet"].ToString().Trim()+",";
					ttb.updrec_xuatsdll(dtll,id,dr[i]["mabn"].ToString(),dr[i]["hoten"].ToString(),s_ngay,o_phieu,int.Parse(dr[i]["makp"].ToString()),idduyet,int.Parse(dr[i]["makhoa"].ToString()));
					ttb.upd_ngayduyet(s_mmyy,i_nhom,i_loai,o_phieu,int.Parse(dr[i]["makp"].ToString()),s_ngay,idduyet,s_kho,s_sttduyet);
					ttb.execute_data("update "+xxx+".ttb_duyet set done=2 where id="+decimal.Parse(dr[i]["idduyet"].ToString()));
				}
			}
		}

		private void tim_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");
		}

		private void tim_TextChanged(object sender, System.EventArgs e)
		{
			if (this.ActiveControl==tim)
			{
				CurrencyManager cm= (CurrencyManager)BindingContext[dataGrid1.DataSource];
				DataView dv=(DataView)cm.List;
				if (tim.Text!="")
					dv.RowFilter="hoten like '%"+tim.Text.Trim()+"%' or ten like '%"+tim.Text.Trim()+"%'";
				else
					dv.RowFilter="";
			}
		}

		private void phatsau_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.ActiveControl==phatsau && dt.Rows.Count>0)
			{
				if (dt.Select("phatsau=1").Length>0)
				{
					DataRow [] dr=dt.Select("phatsau=1 and soluong>0");
					for(int i=0;i<dr.Length;i++) dr[i]["chon"]=phatsau.Checked;
				}
			}
		}

		private void butIn_Click(object sender, System.EventArgs e)
		{
			string s_title="";
			s_title=(i_loai==2)?"PHIẾU BÙ":((i_loai==3)?"PHIẾU TRẢ":(i_loai==4)?"PHIẾU LĨNH":"PHIẾU LĨNH");
			frmInphieu f=new frmInphieu(ttb,dtkp,dtphieu,(makp.SelectedIndex==-1)?-1:int.Parse(makp.SelectedValue.ToString()),(phieu.SelectedIndex==-1)?-1:int.Parse(phieu.SelectedValue.ToString()),s_ngay,s_mmyy,i_nhom,i_loai,s_kho,s_title,false);
			f.ShowDialog(this);
		}

		private void butKetthuc_Click(object sender, System.EventArgs e)
		{
			frmDSdutru_duyet f=new frmDSdutru_duyet(ttb,"",i_nhom,s_mmyy);
			f.ShowDialog(this);
		}

		private void kp_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");
		}

		private void kp_Validated(object sender, System.EventArgs e)
		{
			try
			{
				DataRow r=ttb.getrowbyid(dtkp,"ma='"+kp.Text+"'");
				if (r!=null) makp.SelectedValue=r["id"].ToString();
			}
			catch{}
		}

		private void makp_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (this.ActiveControl==makp && makp.Items.Count>0) kp.Text=dtkp.Rows[makp.SelectedIndex]["ma"].ToString();
		}
		private void frmDuyet_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.F3:
					butLay_Click(sender,e);
					break;
				case Keys.F5:
					butLuu_Click(sender,e);
					break;
				case Keys.F9:
					butIn_Click(sender,e);
					break;
				case Keys.F10:
					butBoqua_Click(sender,e);
					break;
			}
		}
	}
}
