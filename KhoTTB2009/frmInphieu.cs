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
	/// Summary description for frmThuhoi.
	/// </summary>
	public class frmInphieu : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ComboBox phieu;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox makp;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button butOk;
		private System.Windows.Forms.Button butCancel;
		private DataTable dtphieu=new DataTable();
		private DataTable dtkp=new DataTable();
		private DataSet ds=new DataSet();
		private DataSet dsxml=new DataSet();
		private DataTable dt=new DataTable();
		private DataTable dtkho=new DataTable();
		private DataTable dtnguon=new DataTable();
		private DataTable dtdt=new DataTable();
		private string user,xxx,s_ngay,s_mmyy,sql,s_kho,s_makho,s_madt,s_tendt,s_tenkho,s_title,file1,file2,tenfile,s_idduyet,tieude,s_manguon,s_tennguon,s_doc,f_ngay,link;
		private int i_nhom,i_loai,i_makp,i_phieu,i_songay;
		private bool bBuhaophi,bNhomin_mabd,bInngang,bDoituong_phieulinh;
        private LibTTB.AccessData ttb;
        private LibDuoc.AccessData d=new LibDuoc.AccessData();
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker tu;
		private System.Windows.Forms.DateTimePicker den;
		private System.Windows.Forms.CheckedListBox madoituong;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private Print prn=new Print();
		private System.Windows.Forms.CheckBox xuatcstt;
		private System.Windows.Forms.CheckedListBox manguon;
		private System.Windows.Forms.CheckBox xem;
		private System.Windows.Forms.TextBox nguoilinh;
		private System.Windows.Forms.Label label11;
		private DataColumn dc;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown banin;
		private System.Windows.Forms.CheckedListBox kho;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmInphieu(AccessData acc,DataTable kp,DataTable phieu,int imakp,int iphieu,string ngay,string mmyy,int nhom,int loai,string kho,string title,bool buhaophi)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			ttb=acc;dtphieu=phieu;dtkp=kp;bBuhaophi=buhaophi;
			i_makp=imakp;i_phieu=iphieu;s_kho=kho;s_title=title;
			s_ngay=ngay;s_mmyy=mmyy;i_nhom=nhom;i_loai=loai;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInphieu));
            this.phieu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.makp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butOk = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tu = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.den = new System.Windows.Forms.DateTimePicker();
            this.madoituong = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.xuatcstt = new System.Windows.Forms.CheckBox();
            this.manguon = new System.Windows.Forms.CheckedListBox();
            this.xem = new System.Windows.Forms.CheckBox();
            this.nguoilinh = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.banin = new System.Windows.Forms.NumericUpDown();
            this.kho = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.banin)).BeginInit();
            this.SuspendLayout();
            // 
            // phieu
            // 
            this.phieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.phieu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phieu.Location = new System.Drawing.Point(66, 54);
            this.phieu.Name = "phieu";
            this.phieu.Size = new System.Drawing.Size(198, 21);
            this.phieu.TabIndex = 7;
            this.phieu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phieu_KeyDown);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phiếu :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // makp
            // 
            this.makp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.makp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makp.Location = new System.Drawing.Point(66, 31);
            this.makp.Name = "makp";
            this.makp.Size = new System.Drawing.Size(198, 21);
            this.makp.TabIndex = 5;
            this.makp.SelectedIndexChanged += new System.EventHandler(this.makp_SelectedIndexChanged);
            this.makp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.makp_KeyDown);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Khoa :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // butOk
            // 
            this.butOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butOk.Location = new System.Drawing.Point(176, 229);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(60, 25);
            this.butOk.TabIndex = 12;
            this.butOk.Text = "&In";
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // butCancel
            // 
            this.butCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butCancel.Location = new System.Drawing.Point(238, 229);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(60, 25);
            this.butCancel.TabIndex = 13;
            this.butCancel.Text = "&Kết thúc";
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Từ ngày :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tu
            // 
            this.tu.CustomFormat = "dd/MM/yyyy";
            this.tu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tu.Location = new System.Drawing.Point(66, 8);
            this.tu.Name = "tu";
            this.tu.Size = new System.Drawing.Size(80, 21);
            this.tu.TabIndex = 1;
            this.tu.Validated += new System.EventHandler(this.tu_Validated);
            this.tu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ngay_KeyDown);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(152, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "đến :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // den
            // 
            this.den.CustomFormat = "dd/MM/yyyy";
            this.den.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.den.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.den.Location = new System.Drawing.Point(184, 8);
            this.den.Name = "den";
            this.den.Size = new System.Drawing.Size(80, 21);
            this.den.TabIndex = 3;
            this.den.Validated += new System.EventHandler(this.den_Validated);
            this.den.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ngay_KeyDown);
            // 
            // madoituong
            // 
            this.madoituong.CheckOnClick = true;
            this.madoituong.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.madoituong.Location = new System.Drawing.Point(66, 149);
            this.madoituong.Name = "madoituong";
            this.madoituong.Size = new System.Drawing.Size(198, 68);
            this.madoituong.TabIndex = 11;
            this.madoituong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ngay_KeyDown);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(24, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kho :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Đối tượng :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // xuatcstt
            // 
            this.xuatcstt.Location = new System.Drawing.Point(267, 200);
            this.xuatcstt.Name = "xuatcstt";
            this.xuatcstt.Size = new System.Drawing.Size(134, 16);
            this.xuatcstt.TabIndex = 17;
            this.xuatcstt.Text = "Phiếu xuất tủ trực";
            this.xuatcstt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ngay_KeyDown);
            // 
            // manguon
            // 
            this.manguon.CheckOnClick = true;
            this.manguon.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manguon.Location = new System.Drawing.Point(267, 8);
            this.manguon.Name = "manguon";
            this.manguon.Size = new System.Drawing.Size(198, 164);
            this.manguon.TabIndex = 14;
            this.manguon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ngay_KeyDown);
            // 
            // xem
            // 
            this.xem.Location = new System.Drawing.Point(375, 200);
            this.xem.Name = "xem";
            this.xem.Size = new System.Drawing.Size(104, 16);
            this.xem.TabIndex = 18;
            this.xem.Text = "Xem trước khi in";
            this.xem.CheckedChanged += new System.EventHandler(this.xem_CheckedChanged);
            // 
            // nguoilinh
            // 
            this.nguoilinh.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nguoilinh.Location = new System.Drawing.Point(328, 174);
            this.nguoilinh.Name = "nguoilinh";
            this.nguoilinh.Size = new System.Drawing.Size(136, 21);
            this.nguoilinh.TabIndex = 16;
            this.nguoilinh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ngay_KeyDown);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(264, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 23);
            this.label11.TabIndex = 15;
            this.label11.Text = "Người lĩnh :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(360, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Số bản in :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // banin
            // 
            this.banin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banin.Location = new System.Drawing.Point(425, 217);
            this.banin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.banin.Name = "banin";
            this.banin.Size = new System.Drawing.Size(40, 21);
            this.banin.TabIndex = 20;
            this.banin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // kho
            // 
            this.kho.CheckOnClick = true;
            this.kho.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kho.Location = new System.Drawing.Point(66, 78);
            this.kho.Name = "kho";
            this.kho.Size = new System.Drawing.Size(198, 68);
            this.kho.TabIndex = 9;
            // 
            // frmInphieu
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(474, 271);
            this.Controls.Add(this.kho);
            this.Controls.Add(this.banin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nguoilinh);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.xem);
            this.Controls.Add(this.manguon);
            this.Controls.Add(this.xuatcstt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.madoituong);
            this.Controls.Add(this.den);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butOk);
            this.Controls.Add(this.phieu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.makp);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInphieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In phiếu";
            this.Load += new System.EventHandler(this.frmInphieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void frmInphieu_Load(object sender, System.EventArgs e)
		{
            link = ttb.dbLink;
            user = ttb.user; xxx = user;// +s_mmyy;
            f_ngay = ttb.f_ngay;
			bInngang=ttb.bPhieulinh_ngang(i_nhom);
			bDoituong_phieulinh=ttb.bDoituong_Phieulinh(i_nhom);
			xem.Checked=ttb.bPreview;
			banin.Enabled=!xem.Checked;
			s_doc="";
			if (ttb.bHoten_docGN(i_nhom)!=0) s_doc+=ttb.bHoten_docGN(i_nhom).ToString()+",";
			if (ttb.bHoten_docHTT(i_nhom)!=0) s_doc+=ttb.bHoten_docHTT(i_nhom).ToString()+",";
			if (ttb.bHoten_docAB(i_nhom)!=0) s_doc+=ttb.bHoten_docAB(i_nhom).ToString()+",";
            s_doc=(s_doc!="")?s_doc.Substring(0,s_doc.Length-1):"";
			bNhomin_mabd=ttb.bNhomin_mabd(i_nhom);
			xuatcstt.Enabled=i_loai==2 || bBuhaophi;
			i_songay=ttb.Ngay_in_phieu(i_nhom);
			ds.ReadXml("..\\..\\..\\xml\\ttb_inphieu.xml");
			dsxml.ReadXml("..\\..\\..\\xml\\ttb_inphieu.xml");
            sql = "select a.id,a.ma,trim(a.ten)||' '||a.hamluong as ten,a.dang,a.tenhc,c.ten as tennhom,c.stt as manhom,c.stt,d.ten as tenhang from " + user + ".ttb_dmbd a," + user + ".ttb_dmnhom b," + user + ".ttb_nhomin c," + user + ".ttb_dmhang d";
			sql+=" where a.manhom=b.id ";
			if (bNhomin_mabd) sql+=" and a.nhomin=c.id ";
			else sql+=" and b.nhomin=c.id ";
			sql+=" and a.mahang=d.id and a.nhom="+i_nhom;
			dt=ttb.get_data(sql).Tables[0];
			tu.Value=new DateTime(int.Parse(s_ngay.Substring(6,4)),int.Parse(s_ngay.Substring(3,2)),int.Parse(s_ngay.Substring(0,2)),0,0,0);
			den.Value=tu.Value;
			phieu.DisplayMember="TEN";
			phieu.ValueMember="ID";
			phieu.DataSource=dtphieu;
			if (i_phieu!=-1) phieu.SelectedValue=i_phieu.ToString();
			else phieu.SelectedIndex=0;

			makp.DisplayMember="TEN";
			makp.ValueMember="ID";
			makp.DataSource=dtkp;
			if (i_makp!=-1) makp.SelectedValue=i_makp.ToString();
			else makp.SelectedIndex=0;

			if (ttb.bQuanlynguon(i_nhom))
                dtnguon = ttb.get_data("select * from " + user + ".ttb_dmnguon where nhom=" + i_nhom + " order by id").Tables[0];
			else
                dtnguon = ttb.get_data("select * from " + user + ".ttb_dmnguon where id=0 or nhom=" + i_nhom + " order by id").Tables[0];
			manguon.DataSource=dtnguon;
            manguon.DisplayMember = "TEN";
            manguon.ValueMember = "ID";

            dtdt = d.get_data("select * from " + d.user + ".d_doituong order by madoituong").Tables[0];
			madoituong.DataSource=dtdt;
            madoituong.DisplayMember = "DOITUONG";
            madoituong.ValueMember = "MADOITUONG";

			if (bDoituong_phieulinh)
			{
				foreach(DataRow r in dtdt.Rows)
				{
					dc=new DataColumn();
					dc.ColumnName="c_"+r["madoituong"].ToString().Trim();
					dc.DataType=Type.GetType("System.Decimal");
					ds.Tables[0].Columns.Add(dc);
					dc=new DataColumn();
					dc.ColumnName="c_"+r["madoituong"].ToString().Trim();
					dc.DataType=Type.GetType("System.Decimal");
					dsxml.Tables[0].Columns.Add(dc);
				}
			}
			load_makho();
            kho.DisplayMember = "TEN";
            kho.ValueMember = "ID";

			if (bBuhaophi)
			{
                file1 = "ttb_haophill"; file2 = "ttb_haophict";
			}
			else
			{
				switch (i_loai)
				{
                    case 1: file1 = "ttb_dutrull"; file2 = "ttb_dutruct";
						break;
                    case 2: file1 = "ttb_xtutrucll"; file2 = "ttb_xtutrucct";
						break;
                    case 3: file1 = "ttb_hoantrall"; file2 = "ttb_hoantract";
						break;
                    default: file1 = "ttb_haophill"; file2 = "ttb_haophict";
						break;
				}
			}
		}

		private void load_makho()
		{
			s_makho="";
			sql="select * from "+user+".ttb_dmkho where nhom="+i_nhom;
			if (s_kho!="")
			{
				sql+=" and id in ("+s_kho.Substring(0,s_kho.Length-1)+")";
				DataRow r=ttb.getrowbyid(dtkp,"id="+int.Parse(makp.SelectedValue.ToString()));
				if (r!=null) nguoilinh.Text=r["nguoilinh"].ToString();
			}
			else
			{
				DataRow r=ttb.getrowbyid(dtkp,"id="+int.Parse(makp.SelectedValue.ToString()));
				if (r!=null) s_makho=r["makho"].ToString();
				if (s_makho=="") 
				{
                    string sql1 = "select kho from " + user + ".ttb_dmphieu where nhom=" + i_nhom;
					if (bBuhaophi) sql1+=" and id=4";
					else sql1+=" and id="+i_loai;
					DataTable tmp=ttb.get_data(sql1).Tables[0];
					if (tmp.Rows.Count>0) s_makho=tmp.Rows[0][0].ToString();
				}
				if (s_makho!="") sql+=" and id in ("+s_makho.Substring(0,s_makho.Length-1)+")";
				if (r!=null) nguoilinh.Text=r["nguoilinh"].ToString();
			}
			sql+=" order by stt";
			dtkho=ttb.get_data(sql).Tables[0];
			kho.DataSource=dtkho;
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
				SendKeys.Send("{Tab}{F4}");
			}
		}

		private void butOk_Click(object sender, System.EventArgs e)
		{
			if (ttb.songay(ttb.StringToDate(den.Text),ttb.StringToDate(tu.Text),1)>i_songay)
			{
				MessageBox.Show("Số ngày in phiếu ("+i_songay.ToString()+")",ttb.Msg);
				tu.Focus();
				return;
			}
			if (makp.SelectedIndex==-1 || phieu.SelectedIndex==-1)
			{
				if (makp.SelectedIndex==-1) makp.Focus();
				else phieu.Focus();
				return;
			}
			i_makp=int.Parse(makp.SelectedValue.ToString());
			i_phieu=int.Parse(phieu.SelectedValue.ToString());
			s_makho="";s_tenkho="";
			s_madt="";s_tendt="";
			s_manguon="";s_tennguon="";
			if (madoituong.CheckedItems.Count==0)
				for(int i=0;i<madoituong.Items.Count;i++) s_madt+=dtdt.Rows[i]["madoituong"].ToString()+",";
			else
			{
				for(int i=0;i<madoituong.Items.Count;i++)
				{
					if (madoituong.GetItemChecked(i))
					{
						s_madt+=dtdt.Rows[i]["madoituong"].ToString()+",";
						s_tendt+=dtdt.Rows[i]["doituong"].ToString()+";";
					}
				}
			}
			if (manguon.CheckedItems.Count==0)
				for(int i=0;i<manguon.Items.Count;i++) s_manguon+=dtnguon.Rows[i]["id"].ToString().Trim()+",";
			else
			{
				for(int i=0;i<manguon.Items.Count;i++)
				{
					if (manguon.GetItemChecked(i))
					{
						s_manguon+=dtnguon.Rows[i]["id"].ToString().Trim()+",";
						s_tennguon+=dtnguon.Rows[i]["ten"].ToString()+";";
					}
				}
			}
			if (kho.CheckedItems.Count==0)
				for(int i=0;i<kho.Items.Count;i++) s_makho+=dtkho.Rows[i]["id"].ToString().Trim()+",";
			else
			{
				for(int i=0;i<kho.Items.Count;i++)
				{
					if (kho.GetItemChecked(i))
					{
						s_makho+=dtkho.Rows[i]["id"].ToString().Trim()+",";
						s_tenkho+=dtkho.Rows[i]["ten"].ToString()+";";
					}
				}
			}
			ds.Clear();
			s_idduyet="";
			string s_idstt="";
			foreach(DataRow r in ttb.get_data("select idduyet,sttduyet from "+xxx+".ttb_ngayduyet where nhom="+i_nhom+" and loai="+i_loai+" and makp="+i_makp+" and ngay between to_date('"+tu.Text+"','"+f_ngay+"') and to_date('"+den.Text+"','"+f_ngay+"') and phieu="+i_phieu).Tables[0].Rows)
			{
				s_idduyet+="(a.id="+decimal.Parse(r["idduyet"].ToString());
				if (r["sttduyet"].ToString()!="")
					s_idduyet+=" and b.sttduyet in ("+r["sttduyet"].ToString().Trim().Substring(0,r["sttduyet"].ToString().Trim().Length-1)+")";
				s_idduyet+=") or ";

				s_idstt+="(a.id="+decimal.Parse(r["idduyet"].ToString());
				if (r["sttduyet"].ToString()!="")
					s_idstt+=" and b.stt in ("+r["sttduyet"].ToString().Trim().Substring(0,r["sttduyet"].ToString().Trim().Length-1)+")";
				s_idstt+=") or ";
			}
			if (s_idduyet=="")
			{
				MessageBox.Show("Không có số liệu !",ttb.Msg);
				tu.Focus();
				return;
			}

			if (s_idstt!="") s_idstt=s_idstt.Substring(0,s_idstt.Length-4);
			if (s_idduyet!="") s_idduyet=s_idduyet.Substring(0,s_idduyet.Length-4);
            if (ttb.bSLYeucau(i_nhom)) ds = ttb.get_slyeucau(s_mmyy, ds, dt, dtkho, i_loai, file1, file2, s_idstt, s_madt, s_makho, s_manguon, bBuhaophi, dtdt, bDoituong_phieulinh, bNhomin_mabd, s_doc, tu.Text,tu.Text);
			if (xuatcstt.Checked)
			{
				tieude="PHIẾU XUẤT TỦ TRỰC";
				if (ttb.bPhieulinh_dongia(i_nhom))
					ds=ttb.get_xuatcstt_dongia(s_mmyy,ds,dt,dtkho,s_idduyet,s_madt,s_makho,s_manguon,bBuhaophi,s_doc,bNhomin_mabd,dtdt,bDoituong_phieulinh,i_nhom);
				else
					ds=ttb.get_xuatcstt(s_mmyy,ds,dt,dtkho,s_idduyet,s_madt,s_makho,s_manguon,bBuhaophi,s_doc,bNhomin_mabd,dtdt,bDoituong_phieulinh);
			}
			else
			{
				if (ttb.bPhieulinh_dongia(i_nhom))
					ds=ttb.get_slxuat_dongia(ds,dt,dtkho,tu.Text,den.Text,s_mmyy,i_nhom,i_loai,i_phieu,i_makp,s_madt,s_makho,s_manguon,bBuhaophi,s_doc,bNhomin_mabd,dtdt,bDoituong_phieulinh,"");
				else
					ds=ttb.get_slxuat(ds,dt,dtkho,tu.Text,den.Text,s_mmyy,i_nhom,i_loai,i_phieu,i_makp,s_madt,s_makho,s_manguon,bBuhaophi,s_doc,bNhomin_mabd,dtdt,bDoituong_phieulinh,"");
				if (bBuhaophi) tieude="PHIẾU BÙ";
				else tieude=s_title;
			}
			if (ds.Tables[0].Rows.Count==0 && s_doc=="")
			{
				MessageBox.Show("Không có số liệu !",ttb.Msg);
				tu.Focus();
				return;
			}
			if (ttb.bPhieulinh_dongia(i_nhom))
				ttb.sort_inphieu_dongia(dsxml,ds,ttb.bSLYeucau(i_nhom),s_mmyy,tu.Text,i_nhom,i_makp,i_loai,i_phieu,s_makho,s_madt,s_manguon,nguoilinh.Text,dtdt,bDoituong_phieulinh,(xuatcstt.Checked)?false:(i_loai==2)?true:bBuhaophi);
			else
				ttb.sort_inphieu(dsxml,ds,ttb.bSLYeucau(i_nhom),s_mmyy,tu.Text,i_nhom,i_makp,i_loai,i_phieu,s_makho,s_madt,s_manguon,nguoilinh.Text,dtdt,bDoituong_phieulinh,(xuatcstt.Checked)?false:(i_loai==2)?true:bBuhaophi);
			if (bDoituong_phieulinh) 
			{
				tenfile=(ttb.bPhieulinh_dongia(i_nhom))?"ttb_phieulanh_yc_dt_dg":"ttb_phieulanh_yc_dt";
				tenfile=(ttb.Mabv_so==701424)?"ttb_phieulanh_dt_dg":tenfile;
			}
			else if (bInngang) tenfile="ttb_phieulanh_ng";
			else
			{
				tenfile=(ttb.bSLYeucau(i_nhom))?"ttb_phieulanh_yc":"ttb_phieulanh";
				tenfile+=(ttb.bPhieulinh_dongia(i_nhom))?"_dg":"";
			}
			if (xem.Checked)
			{
				frmReport f=new frmReport(ttb,dsxml.Tables[0],tenfile+".rpt",makp.Text,tieude,(tu.Text==den.Text)?"Ngày "+tu.Text:"Từ ngày "+tu.Text+" đến "+den.Text,phieu.Text,s_tendt,s_tenkho,s_tennguon,s_mmyy,"","");
				f.ShowDialog(this);
			}
			else 
			{
				prn.Printer(ttb,dsxml,tenfile+".rpt",makp.Text,tieude,(tu.Text==den.Text)?"Ngày "+tu.Text:"Từ ngày "+tu.Text+" đến "+den.Text,phieu.Text,s_tendt,s_tenkho,s_tennguon,s_mmyy,"","",(bInngang || bDoituong_phieulinh)?2:1,Convert.ToInt16(banin.Value));
				MessageBox.Show("Đang in "+tieude,"In phiếu",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}

			if (s_doc!="")
			{
				dsxml=ttb.get_slxuat_doc(dsxml,tu.Text,den.Text,s_mmyy,i_nhom,i_loai,i_phieu,i_makp,s_madt,s_makho,s_manguon,bBuhaophi,s_doc,bNhomin_mabd,nguoilinh.Text,"",null);
				if(dsxml.Tables[0].Rows.Count<=0)return;
				tenfile="ttb_pldoc.rpt";
				if (xem.Checked)
				{
					frmReport f=new frmReport(ttb,dsxml.Tables[0],tenfile,makp.Text,tieude,(tu.Text==den.Text)?"Ngày "+tu.Text:"Từ ngày "+tu.Text+" đến "+den.Text,phieu.Text,s_tendt,s_tenkho,s_tennguon,s_mmyy,"","");
					f.ShowDialog(this);
				}
				else 
				{
					prn.Printer(ttb,dsxml,tenfile,makp.Text,tieude,(tu.Text==den.Text)?"Ngày "+tu.Text:"Từ ngày "+tu.Text+" đến "+den.Text,phieu.Text,s_tendt,s_tenkho,s_tennguon,s_mmyy,"","",1,Convert.ToInt16(banin.Value));
					MessageBox.Show("Đang in "+tieude,"In phiếu",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				}
			}
		}

		private void butCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void ngay_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter)	SendKeys.Send("{Tab}");
		}

		private void makp_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (this.ActiveControl==makp) load_makho();
		}

		private void kho_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter || e.KeyCode==Keys.Tab)
			{
				if (kho.SelectedIndex==-1 && kho.Items.Count>0) kho.SelectedIndex=0;
				SendKeys.Send("{Tab}");
			}
		}

		private void tu_Validated(object sender, System.EventArgs e)
		{
			if (i_songay==1) den.Value=tu.Value;
		}

		private void den_Validated(object sender, System.EventArgs e)
		{
			if (i_songay==1) tu.Value=den.Value;
		}

		private void xem_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.ActiveControl==xem) banin.Enabled=!xem.Checked;
		}
	}
}
