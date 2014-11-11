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
	/// Summary description for rptBhyt.
	/// </summary>
	public class frmNxt_kho : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button butKetthuc;
        private LibTTB.AccessData ttb;
		private int i_nhom,tt,i_dongiale,i_thanhtien_le,i_loai=0;
		private string sql,mmyy,s_makho,s_manhom,s_khott,s_tenkho,s_khokhongin,user,xxx;
		private DataTable dt=new DataTable();
		private DataSet ds=new DataSet();
		private DataSet dsxml=new DataSet();
		private DataTable dtkho=new DataTable();
		private DataTable dtnhom=new DataTable();
		private DataTable dtnguon=new DataTable();
		private bool bNguon=false;
		private DataRow [] dr;
		private DataRow r1,r2,r3,r4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button butXem;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckedListBox kho;
		private System.Windows.Forms.CheckedListBox manhom;
		private System.Windows.Forms.NumericUpDown tu;
		private System.Windows.Forms.NumericUpDown den;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown nam;
		private System.Windows.Forms.ComboBox theo;
		private System.Windows.Forms.CheckBox nguon;
		private System.Windows.Forms.CheckBox chkDongia;
		private System.Windows.Forms.ComboBox manguon;
		private System.Windows.Forms.Label label6;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmNxt_kho(AccessData acc,int nhom,string s_mmyy,string makho)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			ttb=acc;
			i_nhom=nhom;mmyy=s_mmyy;s_makho=makho;
			tu.Value=decimal.Parse(s_mmyy.Substring(0,2));
			den.Value=tu.Value;
			nam.Value=decimal.Parse("20"+s_mmyy.Substring(2));
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNxt_kho));
            this.label1 = new System.Windows.Forms.Label();
            this.butKetthuc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.butXem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.theo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.kho = new System.Windows.Forms.CheckedListBox();
            this.manhom = new System.Windows.Forms.CheckedListBox();
            this.tu = new System.Windows.Forms.NumericUpDown();
            this.den = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nam = new System.Windows.Forms.NumericUpDown();
            this.nguon = new System.Windows.Forms.CheckBox();
            this.chkDongia = new System.Windows.Forms.CheckBox();
            this.manguon = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.den)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-1, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ tháng :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // butKetthuc
            // 
            this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butKetthuc.Location = new System.Drawing.Point(147, 175);
            this.butKetthuc.Name = "butKetthuc";
            this.butKetthuc.Size = new System.Drawing.Size(60, 25);
            this.butKetthuc.TabIndex = 6;
            this.butKetthuc.Text = "&Kết thúc";
            this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(82, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "đến :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // butXem
            // 
            this.butXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butXem.Location = new System.Drawing.Point(86, 175);
            this.butXem.Name = "butXem";
            this.butXem.Size = new System.Drawing.Size(60, 25);
            this.butXem.TabIndex = 5;
            this.butXem.Text = "&In";
            this.butXem.Click += new System.EventHandler(this.butXem_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(-1, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Theo :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // theo
            // 
            this.theo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.theo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theo.Items.AddRange(new object[] {
            "Số lượng",
            "Đơn giá,Hạn dùng",
            "Số tiền,Hạng dùng",
            "Hạn dùng,lô sản xuất",
            "Tổng hợp",
            "Kế toán",
            "Nhóm"});
            this.theo.Location = new System.Drawing.Point(56, 145);
            this.theo.Name = "theo";
            this.theo.Size = new System.Drawing.Size(192, 21);
            this.theo.TabIndex = 9;
            this.theo.SelectedIndexChanged += new System.EventHandler(this.theo_SelectedIndexChanged);
            this.theo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kho :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // kho
            // 
            this.kho.CheckOnClick = true;
            this.kho.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kho.Location = new System.Drawing.Point(56, 58);
            this.kho.Name = "kho";
            this.kho.Size = new System.Drawing.Size(192, 84);
            this.kho.TabIndex = 4;
            this.kho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // manhom
            // 
            this.manhom.CheckOnClick = true;
            this.manhom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manhom.Location = new System.Drawing.Point(251, 5);
            this.manhom.Name = "manhom";
            this.manhom.Size = new System.Drawing.Size(192, 164);
            this.manhom.TabIndex = 12;
            this.manhom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // tu
            // 
            this.tu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tu.Location = new System.Drawing.Point(56, 12);
            this.tu.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.tu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tu.Name = "tu";
            this.tu.Size = new System.Drawing.Size(36, 21);
            this.tu.TabIndex = 0;
            this.tu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // den
            // 
            this.den.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.den.Location = new System.Drawing.Point(122, 12);
            this.den.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.den.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.den.Name = "den";
            this.den.Size = new System.Drawing.Size(36, 21);
            this.den.TabIndex = 1;
            this.den.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.den.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(155, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "năm :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nam
            // 
            this.nam.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nam.Location = new System.Drawing.Point(192, 12);
            this.nam.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nam.Minimum = new decimal(new int[] {
            2005,
            0,
            0,
            0});
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(56, 21);
            this.nam.TabIndex = 2;
            this.nam.Value = new decimal(new int[] {
            2006,
            0,
            0,
            0});
            this.nam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // nguon
            // 
            this.nguon.Location = new System.Drawing.Point(251, 176);
            this.nguon.Name = "nguon";
            this.nguon.Size = new System.Drawing.Size(104, 24);
            this.nguon.TabIndex = 16;
            this.nguon.Text = "Theo nguồn";
            // 
            // chkDongia
            // 
            this.chkDongia.Checked = true;
            this.chkDongia.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDongia.Enabled = false;
            this.chkDongia.Location = new System.Drawing.Point(332, 176);
            this.chkDongia.Name = "chkDongia";
            this.chkDongia.Size = new System.Drawing.Size(128, 24);
            this.chkDongia.TabIndex = 17;
            this.chkDongia.Text = "Chi tiết theo đơn giá";
            // 
            // manguon
            // 
            this.manguon.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manguon.Location = new System.Drawing.Point(56, 35);
            this.manguon.Name = "manguon";
            this.manguon.Size = new System.Drawing.Size(192, 21);
            this.manguon.TabIndex = 3;
            this.manguon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(-1, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Nguồn :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmNxt_kho
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(450, 215);
            this.Controls.Add(this.manguon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkDongia);
            this.Controls.Add(this.nguon);
            this.Controls.Add(this.nam);
            this.Controls.Add(this.den);
            this.Controls.Add(this.tu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.manhom);
            this.Controls.Add(this.kho);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.theo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butXem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butKetthuc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNxt_kho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo nhập xuất tồn";
            this.Load += new System.EventHandler(this.frmNxt_kho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.den)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nam)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void frmNxt_kho_Load(object sender, System.EventArgs e)
		{
            user = ttb.user;
			if (ttb.bQuanlynguon(i_nhom))
			{
				nguon.Visible=true;nguon.Checked=true;
			}
			i_loai=(ttb.Mabv_so==701424)?28:0;
			i_thanhtien_le=ttb.d_thanhtien_le(i_nhom);
			i_dongiale=ttb.d_dongia_le(i_nhom);
			sql="select a.*,b.ten tenhang,e.ten as tennuoc,c.stt as sttnhom,c.ten as tennhom,d.stt as sttkt,d.ten as nhomkt ";
            sql += " from " + user + ".ttb_dmbd a inner join " + user + ".ttb_dmhang b on a.mahang=b.id ";
            sql+=" inner join " + user + ".ttb_dmnhom c on a.manhom=c.id ";
            sql+=" left join " + user + ".ttb_dmnhomkt d on a.sotk=d.id ";
            sql+=" inner join " + user + ".ttb_dmnuoc e on a.manuoc=e.id ";
			sql+=" where a.nhom="+i_nhom;
			dt=ttb.get_data(sql).Tables[0];
            foreach(DataRow r in dt.Select("sttkt is null")) r["sttkt"]=0;
			ds.ReadXml("..\\..\\..\\xml\\ttb_nxtnhathuoc.xml");
			dsxml.ReadXml("..\\..\\..\\xml\\ttb_nxtnhathuoc.xml");
			sql="select * from "+user+".ttb_dmkho where nhom="+i_nhom;
			if (s_makho!="") sql+=" and id in ("+s_makho.Substring(0,s_makho.Length-1)+")";
			sql+=" order by stt";
			dtkho=ttb.get_data(sql).Tables[0];
            kho.DataSource = dtkho;
			kho.DisplayMember="TEN";
			kho.ValueMember="ID";			
			s_khokhongin="";
            foreach (DataRow r in ttb.get_data("select * from " + user + ".ttb_dmkho where nhom=" + i_nhom + " and ketoan=1").Tables[0].Rows)
				s_khokhongin+=r["id"].ToString().Trim()+",";
            dtnguon = ttb.get_data("select * from " + user + ".ttb_dmnguon where nhom=" + i_nhom + " order by stt").Tables[0];
            dtnhom = ttb.get_data("select * from " + user + ".ttb_dmnhom where nhom=" + i_nhom + " order by stt").Tables[0];
			manhom.DataSource=dtnhom;
            manhom.DisplayMember = "TEN";
            manhom.ValueMember = "ID";

			manguon.DisplayMember="TEN";
			manguon.ValueMember="ID";
			if (ttb.bQuanlynguon(i_nhom))
                manguon.DataSource = ttb.get_data("select * from " + user + ".ttb_dmnguon where nhom=" + i_nhom + " order by stt").Tables[0];
			else
                manguon.DataSource = ttb.get_data("select * from " + user + ".ttb_dmnguon where id=0 or nhom=" + i_nhom + " order by stt").Tables[0];
			theo.SelectedIndex=0;
		}

		private void butKetthuc_Click(object sender, System.EventArgs e)
		{
			this.Close();		
		}

		private void tu_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");
		}

		private void butXem_Click(object sender, System.EventArgs e)
		{			
			print();
		}	
		
		private void ins_items(string fie1,string fie2)
		{
			foreach(DataRow r in ttb.get_data(sql).Tables[0].Rows)
			{
				sql="id="+int.Parse(r["mabd"].ToString());
				if (tt==5 && i_loai!=0) sql+=" and maloai<>"+i_loai;
				r1=ttb.getrowbyid(dt,sql);
				if (r1!=null)
				{
					sql="mabd="+int.Parse(r["mabd"].ToString())+" and dongia="+decimal.Parse(r["dongia"].ToString())+" and handung='"+r["handung"].ToString()+"' and losx='"+r["losx"].ToString()+"'";
					if (bNguon) sql+=" and manhom="+int.Parse(r["manhom"].ToString());
					r2=ttb.getrowbyid(ds.Tables[0],sql);
					if (r2==null)
					{
						r3=ds.Tables[0].NewRow();
						r3["mabd"]=r["mabd"].ToString();
						r3["ma"]=r1["ma"].ToString();
						r3["ten"]=r1["ten"].ToString().Trim()+" "+r1["hamluong"].ToString();
						r3["tenhc"]=r1["tenhc"].ToString();
						r3["dang"]=r1["dang"].ToString();
						r3["manhom"]=r["manhom"].ToString();
						if (tt==5)
						{
							if (bNguon)
							{
								r4=ttb.getrowbyid(dtnguon,"id="+int.Parse(r["manhom"].ToString()));
								if (r4!=null)
								{
									r3["stt"]=r4["stt"].ToString();
									r3["tennhom"]=r4["ten"].ToString();
								}
							}
							else
							{
								r3["stt"]=r1["sttkt"].ToString();
								r3["tennhom"]=r1["nhomkt"].ToString();
							}
						}
						else
						{
							r3["stt"]=r1["sttnhom"].ToString();
							r3["tennhom"]=r1["tennhom"].ToString();
						}
						r3["tenhang"]=r1["tenhang"].ToString();
						r3["tennuoc"]=r1["tennuoc"].ToString();
						r3["nhomduoc"]=r1["tennhom"].ToString();
						r3["handung"]=r["handung"].ToString();
						r3["losx"]=r["losx"].ToString();
						r3["dongia"]=r["dongia"].ToString();
						r3["tondau"]=0;
						r3["sttondau"]=0;
						r3["slnhap"]=0;
						r3["stnhap"]=0;
						r3["slxuat"]=0;
						r3["stxuat"]=0;
						r3["slnhap_ck"]=0;
						r3["stnhap_ck"]=0;
						r3["slxuat_ck"]=0;
						r3["stxuat_ck"]=0;
						r3[fie1]=r["soluong"].ToString();
						r3[fie2]=r["sotien"].ToString();
						ds.Tables[0].Rows.Add(r3);
					}
					else 
					{
						dr=ds.Tables[0].Select(sql);
						if (dr.Length>0)
						{
							dr[0][fie1]=decimal.Parse(dr[0][fie1].ToString())+decimal.Parse(r["soluong"].ToString());
							dr[0][fie2]=decimal.Parse(dr[0][fie2].ToString())+decimal.Parse(r["sotien"].ToString());
						}
					}
				}
			}
		}

		private void get_tondau(string mmyy)
		{
            xxx = user;// +mmyy;
			sql="select b.mabd";
			if (bNguon) sql+=",d.manguon as manhom";
			else sql+=",0 as manhom";
			if (tt==0 || (chkDongia.Enabled && chkDongia.Checked)) sql+=",round(d.giamua,"+i_dongiale+") as dongia,'' as handung,'' as losx";
			else if (tt<3) sql+=",round(d.giamua,"+i_dongiale+") as dongia,d.handung,'' as losx";
			else if (tt==3) sql+=",round(d.giamua,"+i_dongiale+") as dongia,d.handung,d.losx";
			else if (tt==4) sql+=",round(d.giamua,"+i_dongiale+") as dongia,'' as handung,'' as losx";
			else sql+=",0 as dongia,'' as handung,'' as losx";
            sql += ",sum(b.tondau) as soluong,sum(b.tondau*round(d.giamua," + i_dongiale + ")) as sotien ";
			sql+=" from "+xxx+".ttb_tonkhoct b,"+user+".ttb_dmbd c,"+xxx+".ttb_theodoi d where b.mabd=c.id and b.stt=d.id";
			sql+=" and c.nhom="+i_nhom;
			if (s_makho!="") sql+=" and b.makho in ("+s_makho.Substring(0,s_makho.Length-1)+")";
			if (tt>4 && s_khokhongin!="") sql+=" and b.makho not in ("+s_khokhongin.Substring(0,s_khokhongin.Length-1)+")";
			if (s_manhom!="") sql+=" and c.manhom in ("+s_manhom.Substring(0,s_manhom.Length-1)+")";
			if (manguon.SelectedIndex!=-1) sql+=" and d.manguon="+int.Parse(manguon.SelectedValue.ToString());
            sql += " and b.mmyy='" + mmyy + "' group by b.mabd";
			if (bNguon) sql+=",d.manguon";
			if (tt==0 || (chkDongia.Enabled && chkDongia.Checked)) sql+=",round(d.giamua,"+i_dongiale+")";
			else if (tt<3) sql+=",round(d.giamua,"+i_dongiale+"),d.handung";
			else if (tt==3) sql+=",round(d.giamua,"+i_dongiale+"),d.handung,d.losx";
			else if (tt==4) sql+=",round(d.giamua,"+i_dongiale+")";
			ins_items("tondau","sttondau");
		}

		private void get_nhap(string mmyy)
		{
            xxx = user; // +mmyy;
			sql="select b.mabd";
			if (bNguon) sql+=",a.manguon as manhom";
			else sql+=",0 as manhom";
			if (tt==0 || (chkDongia.Enabled && chkDongia.Checked)) sql+=",round(b.giamua,"+i_dongiale+") as dongia,'' as handung,'' as losx";
			else if (tt<3) sql+=",round(b.giamua,"+i_dongiale+") as dongia,b.handung,'' as losx";
			else if (tt==3) sql+=",round(b.giamua,"+i_dongiale+") as dongia,b.handung,b.losx";
			else if (tt==4) sql+=",round(b.giamua,"+i_dongiale+") as dongia,'' as handung,'' as losx";
			else sql+=",0 as dongia,'' as handung,'' as losx";
            sql += ",sum(b.soluong) soluong,sum((b.soluong*round(b.giamua,0))) sotien ";
			sql+=" from "+xxx+".ttb_nhapll a,"+xxx+".ttb_nhapct b,"+user+".ttb_dmbd c where a.id=b.id and b.mabd=c.id";
			sql+=" and a.nhom="+i_nhom;
			if (s_makho!="") sql+=" and a.makho in ("+s_makho.Substring(0,s_makho.Length-1)+")";
			if (tt>4 && s_khokhongin!="") sql+=" and a.makho not in ("+s_khokhongin.Substring(0,s_khokhongin.Length-1)+")";
			if (s_manhom!="") sql+=" and c.manhom in ("+s_manhom.Substring(0,s_manhom.Length-1)+")";
			if (manguon.SelectedIndex!=-1) sql+=" and a.manguon="+int.Parse(manguon.SelectedValue.ToString());
            sql += " and a.mmyy='" + mmyy + "' group by b.mabd";
			if (bNguon) sql+=",a.manguon";
			if (tt==0 || (chkDongia.Enabled && chkDongia.Checked)) sql+=",round(b.giamua,"+i_dongiale+")";
			else if (tt<3) sql+=",round(b.giamua,"+i_dongiale+"),b.handung";
			else if (tt==3) sql+=",round(b.giamua,"+i_dongiale+"),b.handung,b.losx";
			else if (tt==4) sql+=",round(b.giamua,"+i_dongiale+")";
			ins_items("slnhap","stnhap");
			if (tt<4 || s_khott=="")
			{
				sql="select b.mabd";
				if (bNguon) sql+=",d.manguon as manhom";
				else sql+=",0 as manhom";
				if (tt==0 || (chkDongia.Enabled && chkDongia.Checked)) sql+=",round(d.giamua,"+i_dongiale+") as dongia,'' as handung,'' as losx";
				else if (tt<3) sql+=",round(d.giamua,"+i_dongiale+") as dongia,d.handung,'' as losx";
				else if (tt==3) sql+=",round(d.giamua,"+i_dongiale+") as dongia,d.handung,d.losx";
				else if (tt==4) sql+=",round(d.giamua,"+i_dongiale+") as dongia,'' as handung,'' as losx";
				else sql+=",0 as dongia,'' as handung,'' as losx";
                sql += ",sum(b.soluong) as soluong,sum(b.soluong*round(d.giamua," + i_dongiale + ")) as sotien ";
				sql+=" from "+xxx+".ttb_xuatll a,"+xxx+".ttb_xuatct b,"+user+".ttb_dmbd c,"+xxx+".ttb_theodoi d where a.id=b.id and b.mabd=c.id and b.sttt=d.id";
				sql+=" and a.nhom="+i_nhom+" and a.loai in ('CK','HT','TH')";
				if (s_makho!="") sql+=" and a.khon in ("+s_makho.Substring(0,s_makho.Length-1)+")";
				if (tt>4 && s_khokhongin!="") sql+=" and a.khon not in ("+s_khokhongin.Substring(0,s_khokhongin.Length-1)+")";
				if (s_manhom!="") sql+=" and c.manhom in ("+s_manhom.Substring(0,s_manhom.Length-1)+")";
				if (manguon.SelectedIndex!=-1) sql+=" and d.manguon="+int.Parse(manguon.SelectedValue.ToString());
                sql += " and a.mmyy='" + mmyy + "' group by b.mabd";
				if (bNguon) sql+=",d.manguon";
				if (tt==0 || (chkDongia.Enabled && chkDongia.Checked)) sql+=",round(d.giamua,"+i_dongiale+")";
				else if (tt<3) sql+=",round(d.giamua,"+i_dongiale+"),d.handung";
				else if (tt==3) sql+=",round(d.giamua,"+i_dongiale+"),d.handung,d.losx";
				else if (tt==4) sql+=",round(d.giamua,"+i_dongiale+")";
				if (s_khott=="") ins_items("slnhap","stnhap");
				else ins_items("slnhap_ck","stnhap_ck");
			}

		}

		private void get_xuat(string mmyy)
		{
            xxx = user;// +mmyy;
			string tenfile=(tt<4)?"d_thucbucstt":"d_thucxuat";
			sql="select b.mabd";
			if (bNguon) sql+=",d.manguon as manhom";
			else sql+=",0 as manhom";
			if (tt==0 || (chkDongia.Enabled && chkDongia.Checked)) sql+=",round(d.giamua,"+i_dongiale+") as dongia,'' as handung,'' as losx";
			else if (tt<3) sql+=",round(d.giamua,"+i_dongiale+") as dongia,d.handung,'' as losx";
			else if (tt==3) sql+=",round(d.giamua,"+i_dongiale+") as dongia,d.handung,d.losx";
			else if (tt==4) sql+=",round(d.giamua,"+i_dongiale+") as dongia,'' as handung,'' as losx";
			else sql+=",0 as dongia,'' as handung,'' as losx";
            sql += ",sum(b.soluong) as soluong,sum(b.soluong*round(d.giamua," + i_dongiale + ")) as sotien ";
			sql+=" from "+xxx+".ttb_xuatsdll a,"+xxx+".ttb_thucxuat b,"+user+".ttb_dmbd c,"+xxx+".ttb_theodoi d where a.id=b.id and b.mabd=c.id and b.sttt=d.id";
			sql+=" and a.nhom="+i_nhom+" and a.loai in (1,4)";
			if (s_makho!="") sql+=" and b.makho in ("+s_makho.Substring(0,s_makho.Length-1)+")";
			if (tt>4 && s_khokhongin!="") sql+=" and b.makho not in ("+s_khokhongin.Substring(0,s_khokhongin.Length-1)+")";
			if (s_manhom!="") sql+=" and c.manhom in ("+s_manhom.Substring(0,s_manhom.Length-1)+")";
			if (manguon.SelectedIndex!=-1) sql+=" and d.manguon="+int.Parse(manguon.SelectedValue.ToString());
            sql += " and a.mmyy='" + mmyy + "' group by b.mabd";
			if (bNguon) sql+=",d.manguon";
			if (tt==0 || (chkDongia.Enabled && chkDongia.Checked)) sql+=",round(d.giamua,"+i_dongiale+")";
			else if (tt<3) sql+=",round(d.giamua,"+i_dongiale+"),d.handung";
			else if (tt==3) sql+=",round(d.giamua,"+i_dongiale+"),d.handung,d.losx";
			else if (tt==4) sql+=",round(d.giamua,"+i_dongiale+")";
			ins_items("slxuat","stxuat");

            //sql="select b.mabd";
            //if (bNguon) sql+=",d.manguon as manhom";
            //else sql+=",0 as manhom";
            //if (tt==0 || (chkDongia.Enabled && chkDongia.Checked)) sql+=",round(d.giamua,"+i_dongiale+") as dongia,'' as handung,'' as losx";
            //else if (tt<3) sql+=",round(d.giamua,"+i_dongiale+") as dongia,d.handung,'' as losx";
            //else if (tt==3) sql+=",round(d.giamua,"+i_dongiale+") as dongia,d.handung,d.losx";
            //else if (tt==4) sql+=",round(d.giamua,"+i_dongiale+") as dongia,'' as handung,'' as losx";
            //else sql+=",0 as dongia,'' as handung,'' as losx";
            //sql+=",sum(b.soluong) as soluong,sum(b.soluong*d.giamua) as sotien ";
            //sql+=" from "+xxx+".ttb_xuatsdll a,"+xxx+"."+tenfile+" b,"+user+".ttb_dmbd c,"+xxx+".ttb_theodoi d where a.id=b.id and b.mabd=c.id and b.sttt=d.id";
            //sql+=" and a.nhom="+i_nhom+" and a.loai in (2)";
            //if (s_makho!="") sql+=" and b.makho in ("+s_makho.Substring(0,s_makho.Length-1)+")";
            //if (tt>4 && s_khokhongin!="") sql+=" and b.makho not in ("+s_khokhongin.Substring(0,s_khokhongin.Length-1)+")";
            //if (s_manhom!="") sql+=" and c.manhom in ("+s_manhom.Substring(0,s_manhom.Length-1)+")";
            //if (manguon.SelectedIndex!=-1) sql+=" and d.manguon="+int.Parse(manguon.SelectedValue.ToString());
            //sql += " and a.mmyy='" + mmyy + "' group by b.mabd";
            //if (bNguon) sql+=",d.manguon";
            //if (tt==0 || (chkDongia.Enabled && chkDongia.Checked)) sql+=",round(d.giamua,"+i_dongiale+")";
            //else if (tt<3) sql+=",round(d.giamua,"+i_dongiale+"),d.handung";
            //else if (tt==3) sql+=",round(d.giamua,"+i_dongiale+"),d.handung,d.losx";
            //else if (tt==4) sql+=",round(d.giamua,"+i_dongiale+")";
            //ins_items("slxuat","stxuat");

			sql="select b.mabd";
			if (bNguon) sql+=",d.manguon as manhom";
			else sql+=",0 as manhom";
			if (tt==0 || (chkDongia.Enabled && chkDongia.Checked)) sql+=",round(d.giamua,"+i_dongiale+") as dongia,'' as handung,'' as losx";
			else if (tt<3) sql+=",round(d.giamua,"+i_dongiale+") as dongia,d.handung,'' as losx";
			else if (tt==3) sql+=",round(d.giamua,"+i_dongiale+") as dongia,d.handung,d.losx";
			else if (tt==4) sql+=",round(d.giamua,"+i_dongiale+") as dongia,'' as handung,'' as losx";
			else sql+=",0 as dongia,'' as handung,'' as losx";
            sql += ",sum(b.soluong) as soluong,sum(b.soluong*round(d.giamua," + i_dongiale + ")) as sotien ";
			sql+=" from "+xxx+".ttb_xuatsdll a,"+xxx+".ttb_thucxuat b,"+user+".ttb_dmbd c,"+xxx+".ttb_theodoi d where a.id=b.id and b.mabd=c.id and b.sttt=d.id";
			sql+=" and a.nhom="+i_nhom+" and a.loai in (3)";
			if (s_makho!="") sql+=" and b.makho in ("+s_makho.Substring(0,s_makho.Length-1)+")";
			if (tt>4 && s_khokhongin!="") sql+=" and b.makho not in ("+s_khokhongin.Substring(0,s_khokhongin.Length-1)+")";
			if (s_manhom!="") sql+=" and c.manhom in ("+s_manhom.Substring(0,s_manhom.Length-1)+")";
			if (manguon.SelectedIndex!=-1) sql+=" and d.manguon="+int.Parse(manguon.SelectedValue.ToString());
            sql += " and a.mmyy='" + mmyy + "' group by b.mabd";
			if (bNguon) sql+=",d.manguon";
			if (tt==0 || (chkDongia.Enabled && chkDongia.Checked)) sql+=",round(d.giamua,"+i_dongiale+")";
			else if (tt<3) sql+=",round(d.giamua,"+i_dongiale+"),d.handung";
			else if (tt==3) sql+=",round(d.giamua,"+i_dongiale+"),d.handung,d.losx";
			else if (tt==4) sql+=",round(d.giamua,"+i_dongiale+")";
			ins_items("slxuat","stxuat");

            //sql="select b.mabd";
            //if (bNguon) sql+=",d.manguon as manhom";
            //else sql+=",0 as manhom";
            //if (tt==0 || (chkDongia.Enabled && chkDongia.Checked)) sql+=",round(d.giamua,"+i_dongiale+") as dongia,'' as handung,'' as losx";
            //else if (tt<3) sql+=",round(d.giamua,"+i_dongiale+") as dongia,d.handung,'' as losx";
            //else if (tt==3) sql+=",round(d.giamua,"+i_dongiale+") as dongia,d.handung,d.losx";
            //else if (tt==4) sql+=",round(d.giamua,"+i_dongiale+") as dongia,'' as handung,'' as losx";
            //else sql+=",0 as dongia,'' as handung,'' as losx";
            //sql+=",sum(b.soluong) as soluong,sum(b.soluong*d.giamua) as sotien ";
            //sql+=" from "+xxx+".ttb_ngtrull a,"+xxx+".ttb_ngtruct b,"+user+".ttb_dmbd c,"+xxx+".ttb_theodoi d where a.id=b.id and b.mabd=c.id and b.sttt=d.id";
            //sql+=" and a.nhom="+i_nhom;
            //if (s_makho!="") sql+=" and b.makho in ("+s_makho.Substring(0,s_makho.Length-1)+")";
            //if (tt>4 && s_khokhongin!="") sql+=" and b.makho not in ("+s_khokhongin.Substring(0,s_khokhongin.Length-1)+")";
            //if (s_manhom!="") sql+=" and c.manhom in ("+s_manhom.Substring(0,s_manhom.Length-1)+")";
            //if (manguon.SelectedIndex!=-1) sql+=" and d.manguon="+int.Parse(manguon.SelectedValue.ToString());
            //sql+=" group by b.mabd";
            //if (bNguon) sql+=",d.manguon";
            //if (tt==0 || (chkDongia.Enabled && chkDongia.Checked)) sql+=",round(d.giamua,"+i_dongiale+")";
            //else if (tt<3) sql+=",round(d.giamua,"+i_dongiale+"),d.handung";
            //else if (tt==3) sql+=",round(d.giamua,"+i_dongiale+"),d.handung,d.losx";
            //else if (tt==4) sql+=",round(d.giamua,"+i_dongiale+")";
            //ins_items("slxuat","stxuat");

            //sql="select b.mabd";
            //if (bNguon) sql+=",d.manguon as manhom";
            //else sql+=",0 as manhom";
            //if (tt==0 || (chkDongia.Enabled && chkDongia.Checked)) sql+=",round(d.giamua,"+i_dongiale+") as dongia,'' as handung,'' as losx";
            //else if (tt<3) sql+=",round(d.giamua,"+i_dongiale+") as dongia,d.handung,'' as losx";
            //else if (tt==3) sql+=",round(d.giamua,"+i_dongiale+") as dongia,d.handung,d.losx";
            //else if (tt==4) sql+=",round(d.giamua,"+i_dongiale+") as dongia,'' as handung,'' as losx";
            //else sql+=",0 as dongia,'' as handung,'' as losx";
            //sql+=",sum(b.soluong) as soluong,sum(b.soluong*d.giamua) as sotien ";
            //sql+=" from "+xxx+".bhytkb a,"+xxx+".bhytthuoc b,"+user+".ttb_dmbd c,"+xxx+".ttb_theodoi d where a.id=b.id and b.mabd=c.id and b.sttt=d.id";
            //sql+=" and a.nhom="+i_nhom;
            //if (s_makho!="") sql+=" and b.makho in ("+s_makho.Substring(0,s_makho.Length-1)+")";
            //if (tt>4 && s_khokhongin!="") sql+=" and b.makho not in ("+s_khokhongin.Substring(0,s_khokhongin.Length-1)+")";
            //if (s_manhom!="") sql+=" and c.manhom in ("+s_manhom.Substring(0,s_manhom.Length-1)+")";
            //if (manguon.SelectedIndex!=-1) sql+=" and d.manguon="+int.Parse(manguon.SelectedValue.ToString());
            //sql+=" group by b.mabd";
            //if (bNguon) sql+=",d.manguon";
            //if (tt==0 || (chkDongia.Enabled && chkDongia.Checked)) sql+=",round(d.giamua,"+i_dongiale+")";
            //else if (tt<3) sql+=",round(d.giamua,"+i_dongiale+"),d.handung";
            //else if (tt==3) sql+=",round(d.giamua,"+i_dongiale+"),d.handung,d.losx";
            //else if (tt==4) sql+=",round(d.giamua,"+i_dongiale+")";
            //ins_items("slxuat","stxuat");

			sql="select b.mabd";
			if (bNguon) sql+=",d.manguon as manhom";
			else sql+=",0 as manhom";
			if (tt==0 || (chkDongia.Enabled && chkDongia.Checked)) sql+=",round(d.giamua,"+i_dongiale+") as dongia,'' as handung,'' as losx";
			else if (tt<3) sql+=",round(d.giamua,"+i_dongiale+") as dongia,d.handung,'' as losx";
			else if (tt==3) sql+=",round(d.giamua,"+i_dongiale+") as dongia,d.handung,d.losx";
			else if (tt==4) sql+=",round(d.giamua,"+i_dongiale+") as dongia,'' as handung,'' as losx";
			else sql+=",0 as dongia,'' as handung,'' as losx";
            sql += ",sum(b.soluong) as soluong,sum(b.soluong*round(d.giamua," + i_dongiale + ")) as sotien ";
			sql+=" from "+xxx+".ttb_xuatll a,"+xxx+".ttb_xuatct b,"+user+".ttb_dmbd c,"+xxx+".ttb_theodoi d where a.id=b.id and b.mabd=c.id and b.sttt=d.id";
			sql+=" and a.nhom="+i_nhom+" and a.loai='XK'";
			if (s_makho!="") sql+=" and a.khox in ("+s_makho.Substring(0,s_makho.Length-1)+")";
			if (tt>4 && s_khokhongin!="") sql+=" and a.khox not in ("+s_khokhongin.Substring(0,s_khokhongin.Length-1)+")";
			if (s_manhom!="") sql+=" and c.manhom in ("+s_manhom.Substring(0,s_manhom.Length-1)+")";
			if (manguon.SelectedIndex!=-1) sql+=" and d.manguon="+int.Parse(manguon.SelectedValue.ToString());
            sql += " and a.mmyy='" + mmyy + "' group by b.mabd";
			if (bNguon) sql+=",d.manguon";
			if (tt==0 || (chkDongia.Enabled && chkDongia.Checked)) sql+=",round(d.giamua,"+i_dongiale+")";
			else if (tt<3) sql+=",round(d.giamua,"+i_dongiale+"),d.handung";
			else if (tt==3) sql+=",round(d.giamua,"+i_dongiale+"),d.handung,d.losx";
			else if (tt==4) sql+=",round(d.giamua,"+i_dongiale+")";
			ins_items("slxuat","stxuat");
			if(tt<4)
			{
				sql="select b.mabd";
				if (bNguon) sql+=",d.manguon as manhom";
				else sql+=",0 as manhom";
				if (tt==0 || (chkDongia.Enabled && chkDongia.Checked)) sql+=",round(d.giamua,"+i_dongiale+") as dongia,'' as handung,'' as losx";
				else if (tt<3) sql+=",round(d.giamua,"+i_dongiale+") as dongia,d.handung,'' as losx";
				else if (tt==3) sql+=",round(d.giamua,"+i_dongiale+") as dongia,d.handung,d.losx";
				else if (tt==4) sql+=",round(d.giamua,"+i_dongiale+") as dongia,'' as handung,'' as losx";
				else sql+=",0 as dongia,'' as handung,'' as losx";
                sql += ",sum(b.soluong) as soluong,sum(b.soluong*round(d.giamua," + i_dongiale + ")) as sotien ";
				sql+=" from "+xxx+".ttb_xuatll a,"+xxx+".ttb_xuatct b,"+user+".ttb_dmbd c,"+xxx+".ttb_theodoi d where a.id=b.id and b.mabd=c.id and b.sttt=d.id";
				sql+=" and a.nhom="+i_nhom+" and a.loai in ('CK','BS')";
				if (s_makho!="") sql+=" and a.khox in ("+s_makho.Substring(0,s_makho.Length-1)+")";
				if (tt>4 && s_khokhongin!="") sql+=" and a.khox not in ("+s_khokhongin.Substring(0,s_khokhongin.Length-1)+")";
				if (s_manhom!="") sql+=" and c.manhom in ("+s_manhom.Substring(0,s_manhom.Length-1)+")";
				if (manguon.SelectedIndex!=-1) sql+=" and d.manguon="+int.Parse(manguon.SelectedValue.ToString());
                sql += " and a.mmyy='" + mmyy + "' group by b.mabd";
				if (bNguon) sql+=",d.manguon";
				if (tt==0 || (chkDongia.Enabled && chkDongia.Checked)) sql+=",round(d.giamua,"+i_dongiale+")";
				else if (tt<3) sql+=",round(d.giamua,"+i_dongiale+"),d.handung";
				else if (tt==3) sql+=",round(d.giamua,"+i_dongiale+"),d.handung,d.losx";
				else if (tt==4) sql+=",round(d.giamua,"+i_dongiale+")";
				ins_items("slxuat_ck","stxuat_ck");
			}
			else if (s_khokhongin!="")
			{
				sql="select b.mabd";
				if (bNguon) sql+=",d.manguon as manhom";
				else sql+=",0 as manhom";
				if (tt==0 || (chkDongia.Enabled && chkDongia.Checked)) sql+=",round(d.giamua,"+i_dongiale+") as dongia,'' as handung,'' as losx";
				else if (tt<3) sql+=",round(d.giamua,"+i_dongiale+") as dongia,d.handung,'' as losx";
				else if (tt==3) sql+=",round(d.giamua,"+i_dongiale+") as dongia,d.handung,d.losx";
				else if (tt==4) sql+=",round(d.giamua,"+i_dongiale+") as dongia,'' as handung,'' as losx";
				else sql+=",0 as dongia,'' as handung,'' as losx";
                sql += ",sum(b.soluong) as soluong,sum(b.soluong*round(d.giamua," + i_dongiale + ")) as sotien ";
				sql+=" from "+xxx+".ttb_xuatll a,"+xxx+".ttb_xuatct b,"+user+".ttb_dmbd c,"+xxx+".ttb_theodoi d where a.id=b.id and b.mabd=c.id and b.sttt=d.id";
				sql+=" and a.nhom="+i_nhom+" and a.loai in ('CK')";
				if (s_makho!="") sql+=" and a.khox in ("+s_makho.Substring(0,s_makho.Length-1)+")";
				if (tt>4 && s_khokhongin!="") 
				{
					sql+=" and a.khox not in ("+s_khokhongin.Substring(0,s_khokhongin.Length-1)+")";
					sql+=" and a.khon in ("+s_khokhongin.Substring(0,s_khokhongin.Length-1)+")";
				}
				if (s_manhom!="") sql+=" and c.manhom in ("+s_manhom.Substring(0,s_manhom.Length-1)+")";
				if (manguon.SelectedIndex!=-1) sql+=" and d.manguon="+int.Parse(manguon.SelectedValue.ToString());
                sql += " and a.mmyy='" + mmyy + "' group by b.mabd";
				if (bNguon) sql+=",d.manguon";
				if (tt==0 || (chkDongia.Enabled && chkDongia.Checked)) sql+=",round(d.giamua,"+i_dongiale+")";
				else if (tt<3) sql+=",round(d.giamua,"+i_dongiale+"),d.handung";
				else if (tt==3) sql+=",round(d.giamua,"+i_dongiale+"),d.handung,d.losx";
				else if (tt==4) sql+=",round(d.giamua,"+i_dongiale+")";
				ins_items("slxuat","stxuat");
			}
		}

		private void print()
		{
			Cursor=Cursors.WaitCursor;
			bNguon=nguon.Checked;
			tt=theo.SelectedIndex;
			string s_title="Từ tháng "+tu.Value.ToString()+" đến "+den.Value.ToString()+" năm "+nam.Value.ToString();
			if(tu.Text==den.Text)s_title="Tháng "+tu.Value.ToString()+" năm "+nam.Value.ToString();
			s_makho="";s_manhom="";s_khott="";s_tenkho="";
			if (kho.SelectedItems.Count>0)
			{
				for(int i=0;i<kho.Items.Count;i++) 
					if (kho.GetItemChecked(i))
					{
						s_makho+=dtkho.Rows[i]["id"].ToString()+",";
						s_tenkho+=dtkho.Rows[i]["ten"].ToString()+",";
						if (dtkho.Rows[i]["khott"].ToString()=="1") s_khott+=dtkho.Rows[i]["id"].ToString()+",";
					}
			}
			if (manhom.SelectedItems.Count>0)
				for(int i=0;i<manhom.Items.Count;i++) if (manhom.GetItemChecked(i)) s_manhom+=dtnhom.Rows[i]["id"].ToString()+",";
			ds.Clear();
			int y1=int.Parse(nam.Value.ToString()),m1=int.Parse(tu.Value.ToString());
			int y2=int.Parse(nam.Value.ToString()),m2=int.Parse(den.Value.ToString());
			int itu,iden;
			string mmyy=m1.ToString().PadLeft(2,'0')+y1.ToString().Substring(2,2);
			if (ttb.bMmyy(mmyy))get_tondau(mmyy);
			for(int i=y1;i<=y2;i++)
			{
				itu=(i==y1)?m1:1;
				iden=(i==y2)?m2:12;
				for(int j=itu;j<=iden;j++)
				{
					mmyy=j.ToString().PadLeft(2,'0')+i.ToString().Substring(2,2);
					if (ttb.bMmyy(mmyy))
					{						
						get_nhap(mmyy);
						get_xuat(mmyy);
					}
				}
			}
			dsxml.Clear();
			dsxml.Merge(ds.Tables[0].Select("true","stt,tennhom,ten"));
			Cursor=Cursors.Default;
			string tenfile="d_nxt_kho"+tt.ToString().Trim()+".rpt";
			if (dsxml.Tables[0].Rows.Count==0) MessageBox.Show("Không có số liệu !",ttb.Msg);
			else
			{

                frmReport f1=new frmReport(ttb,dsxml.Tables[0],tenfile,s_tenkho,s_title,"","","","","","","","");
				f1.ShowDialog(this);
			}
		}

		private void theo_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (this.ActiveControl==theo) chkDongia.Enabled=theo.SelectedIndex==5 || theo.SelectedIndex==7;
		}	
	}
}
