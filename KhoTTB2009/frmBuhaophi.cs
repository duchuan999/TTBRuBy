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
	/// Summary description for frmHaophi.
	/// </summary>
	public class frmBuhaophi : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox mabn;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox ngay;
		private System.Windows.Forms.ComboBox phieu;
		private System.Windows.Forms.ComboBox makp;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Button butKetthuc;
		private System.Windows.Forms.DataGrid dataGrid1;
        private LibTTB.AccessData ttb;
		private int i_nhom,i_loai,i_userid,i_makp;
		private string s_ngay,sql,s_makp,s_mmyy,s_kho;
		private DataTable dtdmbd=new DataTable();
		private DataTable dtkp=new DataTable();
		private DataTable dtll=new DataTable();
		private DataTable dtct=new DataTable();
		private DataTable dtphieu=new DataTable();
		private bool bKhoaso,bGiaban;
		private decimal l_id=0;
		private DataRow r;
		private System.Windows.Forms.Button butChoduyet;
		private System.Windows.Forms.Button butDuyet;
		private System.Windows.Forms.Button butThuhoi;
		private System.Windows.Forms.Button butHuy;
		private System.Windows.Forms.Button butIn;
		private System.Windows.Forms.Button butTim;
		private frmMain parent=null;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmBuhaophi(AccessData acc,int nhom,string ngay,int loai,int userid,string users,string makp,string mmyy,string kho,bool giaban)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			ttb=acc;
			i_nhom=nhom;
			i_loai=loai;
			i_userid=userid;
			s_ngay=ngay;
			s_makp=makp;
			s_mmyy=mmyy;
			s_kho=kho;
			bGiaban=giaban;
			this.Text="Duyệt dù trù hao phí thuốc, vật tư y tế theo khoa/phòng ("+users.Trim()+")";
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmBuhaophi));
			this.label1 = new System.Windows.Forms.Label();
			this.mabn = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.ngay = new System.Windows.Forms.TextBox();
			this.phieu = new System.Windows.Forms.ComboBox();
			this.makp = new System.Windows.Forms.ComboBox();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.butKetthuc = new System.Windows.Forms.Button();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.butChoduyet = new System.Windows.Forms.Button();
			this.butDuyet = new System.Windows.Forms.Button();
			this.butThuhoi = new System.Windows.Forms.Button();
			this.butHuy = new System.Windows.Forms.Button();
			this.butIn = new System.Windows.Forms.Button();
			this.butTim = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Số phiếu :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// mabn
			// 
			this.mabn.BackColor = System.Drawing.SystemColors.HighlightText;
			this.mabn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.mabn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mabn.Location = new System.Drawing.Point(64, 8);
			this.mabn.Name = "mabn";
			this.mabn.Size = new System.Drawing.Size(88, 21);
			this.mabn.TabIndex = 1;
			this.mabn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mabn_KeyDown);
			this.mabn.SelectedIndexChanged += new System.EventHandler(this.mabn_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(160, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Ngày :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(272, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Phiếu :";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(484, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 23);
			this.label5.TabIndex = 6;
			this.label5.Text = "Khoa :";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ngay
			// 
			this.ngay.BackColor = System.Drawing.SystemColors.HighlightText;
			this.ngay.Enabled = false;
			this.ngay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ngay.Location = new System.Drawing.Point(200, 8);
			this.ngay.Name = "ngay";
			this.ngay.Size = new System.Drawing.Size(68, 21);
			this.ngay.TabIndex = 7;
			this.ngay.Text = "";
			// 
			// phieu
			// 
			this.phieu.BackColor = System.Drawing.SystemColors.HighlightText;
			this.phieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.phieu.Enabled = false;
			this.phieu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.phieu.Location = new System.Drawing.Point(312, 8);
			this.phieu.Name = "phieu";
			this.phieu.Size = new System.Drawing.Size(168, 21);
			this.phieu.TabIndex = 8;
			// 
			// makp
			// 
			this.makp.BackColor = System.Drawing.SystemColors.HighlightText;
			this.makp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.makp.Enabled = false;
			this.makp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.makp.Location = new System.Drawing.Point(528, 8);
			this.makp.Name = "makp";
			this.makp.Size = new System.Drawing.Size(256, 21);
			this.makp.TabIndex = 9;
			// 
			// treeView1
			// 
			this.treeView1.ImageIndex = -1;
			this.treeView1.Location = new System.Drawing.Point(640, 32);
			this.treeView1.Name = "treeView1";
			this.treeView1.SelectedImageIndex = -1;
			this.treeView1.Size = new System.Drawing.Size(144, 448);
			this.treeView1.TabIndex = 10;
			// 
			// butKetthuc
			// 
			this.butKetthuc.Image = ((System.Drawing.Bitmap)(resources.GetObject("butKetthuc.Image")));
			this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butKetthuc.Location = new System.Drawing.Point(454, 486);
			this.butKetthuc.Name = "butKetthuc";
			this.butKetthuc.Size = new System.Drawing.Size(74, 28);
			this.butKetthuc.TabIndex = 27;
			this.butKetthuc.Text = "&Kết thúc";
			this.butKetthuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
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
			this.dataGrid1.Location = new System.Drawing.Point(8, 16);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro;
			this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.RowHeaderWidth = 5;
			this.dataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue;
			this.dataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
			this.dataGrid1.Size = new System.Drawing.Size(624, 464);
			this.dataGrid1.TabIndex = 101;
			// 
			// butChoduyet
			// 
			this.butChoduyet.Image = ((System.Drawing.Bitmap)(resources.GetObject("butChoduyet.Image")));
			this.butChoduyet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butChoduyet.Location = new System.Drawing.Point(640, 486);
			this.butChoduyet.Name = "butChoduyet";
			this.butChoduyet.Size = new System.Drawing.Size(144, 28);
			this.butChoduyet.TabIndex = 102;
			this.butChoduyet.Text = "      Danh sách chờ duyệt";
			this.butChoduyet.Click += new System.EventHandler(this.butChoduyet_Click);
			// 
			// butDuyet
			// 
			this.butDuyet.Image = ((System.Drawing.Bitmap)(resources.GetObject("butDuyet.Image")));
			this.butDuyet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butDuyet.Location = new System.Drawing.Point(154, 486);
			this.butDuyet.Name = "butDuyet";
			this.butDuyet.Size = new System.Drawing.Size(74, 28);
			this.butDuyet.TabIndex = 103;
			this.butDuyet.Text = "       &Duyệt";
			this.butDuyet.Click += new System.EventHandler(this.butDuyet_Click);
			// 
			// butThuhoi
			// 
			this.butThuhoi.Image = ((System.Drawing.Bitmap)(resources.GetObject("butThuhoi.Image")));
			this.butThuhoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butThuhoi.Location = new System.Drawing.Point(229, 486);
			this.butThuhoi.Name = "butThuhoi";
			this.butThuhoi.Size = new System.Drawing.Size(74, 28);
			this.butThuhoi.TabIndex = 104;
			this.butThuhoi.Text = "     &Thu hồi";
			this.butThuhoi.Click += new System.EventHandler(this.butThuhoi_Click);
			// 
			// butHuy
			// 
			this.butHuy.Image = ((System.Drawing.Bitmap)(resources.GetObject("butHuy.Image")));
			this.butHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butHuy.Location = new System.Drawing.Point(0, 544);
			this.butHuy.Name = "butHuy";
			this.butHuy.Size = new System.Drawing.Size(74, 28);
			this.butHuy.TabIndex = 105;
			this.butHuy.Text = "       &Hủy";
			this.butHuy.Visible = false;
			this.butHuy.Click += new System.EventHandler(this.butHuy_Click);
			// 
			// butIn
			// 
			this.butIn.Image = ((System.Drawing.Bitmap)(resources.GetObject("butIn.Image")));
			this.butIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butIn.Location = new System.Drawing.Point(304, 486);
			this.butIn.Name = "butIn";
			this.butIn.Size = new System.Drawing.Size(74, 28);
			this.butIn.TabIndex = 106;
			this.butIn.Text = "      &In";
			this.butIn.Click += new System.EventHandler(this.butIn_Click);
			// 
			// butTim
			// 
			this.butTim.Image = ((System.Drawing.Bitmap)(resources.GetObject("butTim.Image")));
			this.butTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butTim.Location = new System.Drawing.Point(379, 486);
			this.butTim.Name = "butTim";
			this.butTim.Size = new System.Drawing.Size(74, 28);
			this.butTim.TabIndex = 108;
			this.butTim.Text = "      Tìm";
			this.butTim.Click += new System.EventHandler(this.butTim_Click);
			// 
			// frmBuhaophi
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(792, 573);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.butTim,
																		  this.butIn,
																		  this.butHuy,
																		  this.butThuhoi,
																		  this.butDuyet,
																		  this.butChoduyet,
																		  this.makp,
																		  this.phieu,
																		  this.ngay,
																		  this.label5,
																		  this.label4,
																		  this.label3,
																		  this.mabn,
																		  this.label1,
																		  this.dataGrid1,
																		  this.butKetthuc,
																		  this.treeView1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmBuhaophi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmBuhaophi";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmBuhaophi_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmBuhaophi_Load(object sender, System.EventArgs e)
		{
			bKhoaso=ttb.bKhoaso(i_nhom,s_mmyy);
			dtdmbd=ttb.get_data("select * from ttb_dmbd where nhom="+i_nhom+" order by id").Tables[0];
			dtphieu=ttb.get_data("select * from ttb_loaiphieu where nhom="+i_nhom+" and loai=4 order by stt").Tables[0];
			phieu.DisplayMember="TEN";
			phieu.ValueMember="ID";
			phieu.DataSource=dtphieu;

			sql="select * from d_duockp where nhom like '%"+i_nhom.ToString()+",%'";
			if (s_makp!="") sql+=" and id in ("+s_makp.Substring(0,s_makp.Length-1)+")";
			sql+=" order by stt";
			dtkp=ttb.get_data(sql).Tables[0];	
			makp.DisplayMember="TEN";
			makp.ValueMember="ID";
			makp.DataSource=dtkp;
			butChoduyet_Click(null,null);

			sql="select a.id,a.mabn,b.ten hoten,to_char(a.ngay,'dd/mm/yyyy') ngay,a.phieu,a.makp,a.idduyet,a.makhoa from ttb_xuatsdll a,"+ttb.user+".d_duockp b,"+ttb.user+".ttb_loaiphieu c ";
			sql+="where a.makp=b.id and a.phieu=c.id and a.maql=0 and c.loai=4 and a.nhom="+i_nhom+" and a.mmyy='"+s_mmyy+"'";
			if (ttb.bUserid) sql+=" and a.userid="+i_userid;
			if (ttb.bLoclinh) sql+=" and to_char(a.ngay,'dd/mm/yyyy')='"+s_ngay+"'";
			if (s_makp!="") sql+=" and a.makp in ("+s_makp.Substring(0,s_makp.Length-1)+")";
			sql+=" order by a.id";
            dtll = ttb.get_data(sql).Tables[0];//s_mmyy
			mabn.DisplayMember="MABN";
			mabn.ValueMember="ID";
			mabn.DataSource=dtll;
			if (dtll.Rows.Count>0) l_id=decimal.Parse(mabn.SelectedValue.ToString());
			load_head();
			AddGridTableStyle();
		}

		private void load_grid()
		{
			sql="select a.stt,a.sttt,'' doituong,a.mabd,b.ma,trim(b.ten)||' '||b.hamluong ten,b.tenhc,b.dang,f.ten tenkho,c.ten tennguon,d.ten tennhomcc,a.handung,nvl(a.losx,' ') losx,a.soluong,a.giamua dongia,round(a.soluong*a.giamua,3) sotien,a.giaban,a.giamua,3 madoituong,a.makho,a.manguon,a.nhomcc,'xx/xx/xxxx' ngay ";
			sql+=" from ttb_bucstt a,"+ttb.user+".ttb_dmbd b,"+ttb.user+".ttb_dmnguon c,"+ttb.user+".ttb_nhomcc d,"+ttb.user+".ttb_dmkho f ";
			sql+="where a.mabd=b.id and a.manguon=c.id and a.nhomcc=d.id and a.makho=f.id and a.id="+l_id;
			if (s_kho!="") sql+=" and a.makho in ("+s_kho.Substring(0,s_kho.Length-1)+")";
			sql+=" order by a.stt";
            dtct = ttb.get_data(sql).Tables[0];//s_mmyy
			dataGrid1.DataSource=dtct;
		}

		private void AddGridTableStyle()
		{
			DataGridTableStyle ts =new DataGridTableStyle();
			ts.MappingName = dtct.TableName;
			ts.AlternatingBackColor = Color.Beige;
			ts.BackColor = Color.GhostWhite;
			ts.ForeColor = Color.MidnightBlue;
			ts.GridLineColor = Color.RoyalBlue;
			ts.HeaderBackColor = Color.MidnightBlue;
			ts.HeaderForeColor = Color.Lavender;
			ts.SelectionBackColor = Color.Teal;
			ts.SelectionForeColor = Color.PaleGreen;
			ts.ReadOnly=false;
			ts.RowHeaderWidth=5;
						
			DataGridTextBoxColumn TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "stt";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "doituong";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "ma";
			TextCol.HeaderText = "Mã số";
			TextCol.Width = 50;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "ten";
			TextCol.HeaderText = "Tên";
			TextCol.Width = (bGiaban)?200:230;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tenhc";
			TextCol.HeaderText = "Hoạt chất";
			TextCol.Width = (ttb.bHoatchat)?200:0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "dang";
			TextCol.HeaderText = "ĐVT";
			TextCol.Width = 50;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tenkho";
			TextCol.HeaderText = "Kho xuất";
			TextCol.Width = 70;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tennguon";
			TextCol.HeaderText = "Nguồn";
			TextCol.Width = (ttb.bQuanlynguon(i_nhom))?80:0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tennhomcc";
			TextCol.HeaderText = "Nhóm cung cấp";
			TextCol.Width = (ttb.bQuanlynhomcc(i_nhom))?90:0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "handung";
			TextCol.HeaderText = "Date";
			TextCol.Width = (ttb.bQuanlyhandung(i_nhom))?30:0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "losx";
			TextCol.HeaderText = "Lô SX";
			TextCol.Width = (ttb.bQuanlylosx(i_nhom))?50:0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "soluong";
			TextCol.HeaderText = "Số lượng";
			TextCol.Width = 70;
			TextCol.Format="#,###,##0.00";
			TextCol.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "dongia";
			TextCol.HeaderText = "Đơn giá";
			TextCol.Width = 80;
			TextCol.Format="###,###,###,##0.000";
			TextCol.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "sotien";
			TextCol.HeaderText = "Số tiền";
			TextCol.Width = 100;
			TextCol.Format="###,###,###,##0.000";
			TextCol.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "giaban";
			TextCol.HeaderText = (bGiaban)?"Giá bán":"";
			TextCol.Width = (bGiaban)?80:0;
			TextCol.Format="###,###,###,##0";
			TextCol.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);
		}

		private void butKetthuc_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void load_treeview()
		{
			sql="select c.makp,b.mabd,sum(b.slyeucau-b.slthuc) soluong ";
			sql+=" from ttb_haophill a,ttb_haophict b,ttb_duyet c,ttb_dmbd d ";
			sql+=" where a.id=b.id and a.idduyet=c.id and b.mabd=d.id ";
			sql+=" and c.nhom="+i_nhom+" and c.loai=4";
			sql+=" and to_char(c.ngay,'dd/mm/yyyy')='"+s_ngay+"'";
			if (s_kho!="") sql+=" and b.makho in ("+s_kho.Substring(0,s_kho.Length-1)+")";
			sql+=" and c.done<>0 and b.slyeucau>b.slthuc and b.tutruc=1 group by c.makp,b.mabd order by c.makp,b.mabd";
			treeView1.Nodes.Clear();
			TreeNode node;
			DataTable dtngay=ttb.get_data(sql).Tables[0];
			DataRow [] dr;
			i_makp=0;
			foreach(DataRow r1 in dtngay.Rows)
			{
				if (i_makp!=int.Parse(r1["makp"].ToString()))
				{
					i_makp=int.Parse(r1["makp"].ToString());
					r=ttb.getrowbyid(dtkp,"id="+i_makp);
					if (r!=null)
					{
						node=treeView1.Nodes.Add(r["ten"].ToString());
						dr=dtngay.Select("makp="+i_makp);
						for(int i=0;i<dr.Length;i++)
						{
							r=ttb.getrowbyid(dtdmbd,"id="+int.Parse(dr[i]["mabd"].ToString()));
							if (r!=null) node.Nodes.Add(r["ten"].ToString().Trim()+"/"+r["tenhc"].ToString().Trim()+" "+r["dang"].ToString().Trim()+" ("+dr[i]["soluong"].ToString().Trim()+")");
						}
					}
				}
			}
		}

		private void butChoduyet_Click(object sender, System.EventArgs e)
		{
			load_treeview();
		}

		private void butDuyet_Click(object sender, System.EventArgs e)
		{
			if (bKhoaso)
			{
				MessageBox.Show("Số liệu tháng "+s_mmyy.Substring(0,2)+" năm "+s_mmyy.Substring(2,2)+" đã khóa !\nNếu cần thay đổi thì vào mục khai báo hệ thống",ttb.Msg);
				return;
			}
			frmDuyet f=new frmDuyet(ttb,dtll,i_nhom,i_loai,s_makp,s_mmyy,s_kho,this.Text,s_ngay,i_userid,true,false,1,false);
			f.ShowDialog(this);
			if (f.bOk)
			{
				dtll=f.dtll;
				dtll.AcceptChanges();
				mabn.Refresh();
				if (dtll.Rows.Count>0) l_id=decimal.Parse(mabn.SelectedValue.ToString());
				else l_id=0;
				load_head();
				butChoduyet_Click(null,null);
			}
		}

		private void mabn_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (this.ActiveControl==mabn)
			{
				try
				{
					l_id=decimal.Parse(mabn.SelectedValue.ToString());
				}
				catch{l_id=0;}
				load_head();
			}
		}

		private void load_head()
		{
			r=ttb.getrowbyid(dtll,"id="+l_id);
			if (r!=null)
			{
				ngay.Text=r["ngay"].ToString();
				makp.SelectedValue=r["makp"].ToString();
				phieu.SelectedValue=r["phieu"].ToString();
			}
			load_grid();
		}

		private void mabn_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) butDuyet.Focus();
		}

		private void butHuy_Click(object sender, System.EventArgs e)
		{
//			if (dtll.Rows.Count==0) return;
//			if (bKhoaso)
//			{
//				MessageBox.Show("Số liệu tháng "+s_mmyy.Substring(0,2)+" năm "+s_mmyy.Substring(2,2)+" đã khóa !\nNếu cần thay đổi thì vào mục khai báo hệ thống",d.Msg);
//				return;
//			}
//			if (MessageBox.Show("Đồng ý hủy số phiếu "+mabn.Text,d.Msg,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
//			{
//				d.upd_duyet(int.Parse(makp.SelectedValue.ToString()),i_nhom,i_loai,int.Parse(phieu.SelectedValue.ToString()),s_ngay);
//				d.del(decimal.Parse(mabn.SelectedValue.ToString()),dtll,i_loai);
//				dtll.AcceptChanges();
//				mabn.Refresh();
//				if (dtll.Rows.Count>0) l_id=decimal.Parse(mabn.SelectedValue.ToString());
//				load_head();
//				butChoduyet_Click(null,null);
//			}
		}

		private void butThuhoi_Click(object sender, System.EventArgs e)
		{
			if (dtll.Rows.Count==0) return;
			if (bKhoaso)
			{
				MessageBox.Show("Số liệu tháng "+s_mmyy.Substring(0,2)+" năm "+s_mmyy.Substring(2,2)+" đã khóa !\nNếu cần thay đổi thì vào mục khai báo hệ thống",ttb.Msg);
				return;
			}
			frmThuhoi f=new frmThuhoi(ttb,dtll,dtct,dtkp,dtphieu,int.Parse(makp.SelectedValue.ToString()),int.Parse(phieu.SelectedValue.ToString()),s_ngay,s_mmyy,i_nhom,i_loai,true,false,1,s_kho,i_userid);
			f.ShowDialog(this);
			if (f.bOk)
			{
				dtll.AcceptChanges();
				mabn.Refresh();
				if (dtll.Rows.Count>0) l_id=decimal.Parse(mabn.SelectedValue.ToString());
				load_head();
				butChoduyet_Click(null,null);
			}
		}

		private void butIn_Click(object sender, System.EventArgs e)
		{
			frmInphieu f=new frmInphieu(ttb,dtkp,dtphieu,(makp.SelectedIndex==-1)?-1:int.Parse(makp.SelectedValue.ToString()),(phieu.SelectedIndex==-1)?-1:int.Parse(phieu.SelectedValue.ToString()),s_ngay,s_mmyy,i_nhom,i_loai,s_kho,"PHIẾU LĨNH",true);
			f.ShowDialog(this);
		}

		private void butTim_Click(object sender, System.EventArgs e)
		{
			l_id=0;
			frmTimbuhaophi f=new frmTimbuhaophi(this);
			f.MdiParent=parent;
			f.RefreshText("");
			f.Show();
		}

		public void RefreshChildren(string text)
		{
			try
			{
				CurrencyManager cm= (CurrencyManager)BindingContext[mabn.DataSource];
				DataView dv=(DataView)cm.List;
				dv.RowFilter="hoten like '%"+text.Trim()+"%'"+" or mabn like '%"+text.Trim()+"%'";
				l_id=decimal.Parse(mabn.SelectedValue.ToString());
				load_head();
			}
			catch{}
		}
	}
}
