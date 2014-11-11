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
	/// Summary description for rptNxt_tonghop.
	/// </summary>
	public class rptXuatkho : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button butIn;
		private System.Windows.Forms.Button butKetthuc;
        private LibTTB.AccessData ttb;
		private int i_nhom;
		private bool bClear=true;
		private string sql,s_mmyy,s_tu,s_den,s_yy,s_kho,tenfile,s_manhom,tenreport,exp;
		private DataRow r1,r2,r3;
		private DataSet ds=new DataSet();
		private DataSet dsxml=new DataSet();
		private DataTable dt=new DataTable();
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox nhomcc;
		private System.Windows.Forms.ComboBox manguon;
		private System.Windows.Forms.NumericUpDown yyyy;
		private System.Windows.Forms.NumericUpDown tu;
		private System.Windows.Forms.NumericUpDown den;
		private System.Windows.Forms.Label label3;
		private DataTable dtdmkho=new DataTable();
		private DataTable dtdmnhom=new DataTable();
		private System.Windows.Forms.CheckedListBox manhom;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckedListBox kho;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public rptXuatkho(AccessData acc,int nhom,string kho,string mmyy,string file)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			ttb=acc;
			i_nhom=nhom;
			s_kho=kho;
			tenfile=file;
			tu.Value=decimal.Parse(mmyy.Substring(0,2));
			den.Value=tu.Value;
			yyyy.Value=decimal.Parse("20"+mmyy.Substring(2,2));
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(rptXuatkho));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.butIn = new System.Windows.Forms.Button();
			this.butKetthuc = new System.Windows.Forms.Button();
			this.manguon = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.nhomcc = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tu = new System.Windows.Forms.NumericUpDown();
			this.yyyy = new System.Windows.Forms.NumericUpDown();
			this.den = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.manhom = new System.Windows.Forms.CheckedListBox();
			this.label6 = new System.Windows.Forms.Label();
			this.kho = new System.Windows.Forms.CheckedListBox();
			((System.ComponentModel.ISupportInitialize)(this.tu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.yyyy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.den)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(-5, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Từ tháng";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(168, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "năm";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// butIn
			// 
			this.butIn.Image = ((System.Drawing.Bitmap)(resources.GetObject("butIn.Image")));
			this.butIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butIn.Location = new System.Drawing.Point(156, 200);
			this.butIn.Name = "butIn";
			this.butIn.Size = new System.Drawing.Size(75, 28);
			this.butIn.TabIndex = 13;
			this.butIn.Text = "      &In";
			this.butIn.Click += new System.EventHandler(this.butIn_Click);
			// 
			// butKetthuc
			// 
			this.butKetthuc.Image = ((System.Drawing.Bitmap)(resources.GetObject("butKetthuc.Image")));
			this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butKetthuc.Location = new System.Drawing.Point(236, 200);
			this.butKetthuc.Name = "butKetthuc";
			this.butKetthuc.Size = new System.Drawing.Size(75, 28);
			this.butKetthuc.TabIndex = 14;
			this.butKetthuc.Text = "&Kết thúc";
			this.butKetthuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
			// 
			// manguon
			// 
			this.manguon.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.manguon.Location = new System.Drawing.Point(56, 38);
			this.manguon.Name = "manguon";
			this.manguon.Size = new System.Drawing.Size(200, 21);
			this.manguon.TabIndex = 7;
			this.manguon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(-5, 38);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Nguồn";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nhomcc
			// 
			this.nhomcc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nhomcc.Location = new System.Drawing.Point(56, 62);
			this.nhomcc.Name = "nhomcc";
			this.nhomcc.Size = new System.Drawing.Size(200, 21);
			this.nhomcc.TabIndex = 9;
			this.nhomcc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(-13, 62);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Nhóm CC";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tu
			// 
			this.tu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tu.Location = new System.Drawing.Point(56, 14);
			this.tu.Maximum = new System.Decimal(new int[] {
															   12,
															   0,
															   0,
															   0});
			this.tu.Minimum = new System.Decimal(new int[] {
															   1,
															   0,
															   0,
															   0});
			this.tu.Name = "tu";
			this.tu.Size = new System.Drawing.Size(40, 21);
			this.tu.TabIndex = 1;
			this.tu.Value = new System.Decimal(new int[] {
															 1,
															 0,
															 0,
															 0});
			this.tu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
			// 
			// yyyy
			// 
			this.yyyy.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.yyyy.Location = new System.Drawing.Point(208, 14);
			this.yyyy.Maximum = new System.Decimal(new int[] {
																 3004,
																 0,
																 0,
																 0});
			this.yyyy.Minimum = new System.Decimal(new int[] {
																 2004,
																 0,
																 0,
																 0});
			this.yyyy.Name = "yyyy";
			this.yyyy.Size = new System.Drawing.Size(48, 21);
			this.yyyy.TabIndex = 5;
			this.yyyy.Value = new System.Decimal(new int[] {
															   2004,
															   0,
															   0,
															   0});
			this.yyyy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
			// 
			// den
			// 
			this.den.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.den.Location = new System.Drawing.Point(128, 14);
			this.den.Maximum = new System.Decimal(new int[] {
																12,
																0,
																0,
																0});
			this.den.Minimum = new System.Decimal(new int[] {
																1,
																0,
																0,
																0});
			this.den.Name = "den";
			this.den.Size = new System.Drawing.Size(40, 21);
			this.den.TabIndex = 3;
			this.den.Value = new System.Decimal(new int[] {
															  1,
															  0,
															  0,
															  0});
			this.den.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(96, 14);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "đến :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// manhom
			// 
			this.manhom.CheckOnClick = true;
			this.manhom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.manhom.Location = new System.Drawing.Point(258, 10);
			this.manhom.Name = "manhom";
			this.manhom.Size = new System.Drawing.Size(200, 180);
			this.manhom.TabIndex = 12;
			this.manhom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(-13, 84);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "Kho ";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// kho
			// 
			this.kho.CheckOnClick = true;
			this.kho.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.kho.Location = new System.Drawing.Point(56, 85);
			this.kho.Name = "kho";
			this.kho.Size = new System.Drawing.Size(200, 100);
			this.kho.TabIndex = 11;
			this.kho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
			// 
			// rptXuatkho
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(466, 247);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.kho,
																		  this.label6,
																		  this.manhom,
																		  this.label3,
																		  this.den,
																		  this.yyyy,
																		  this.tu,
																		  this.nhomcc,
																		  this.label5,
																		  this.manguon,
																		  this.label4,
																		  this.butKetthuc,
																		  this.butIn,
																		  this.label2,
																		  this.label1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "rptXuatkho";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Xuất kho từ tháng ... đến tháng";
			this.Load += new System.EventHandler(this.rptXuatkho_Load);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rptXuatkho_MouseMove);
			((System.ComponentModel.ISupportInitialize)(this.tu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.yyyy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.den)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void rptXuatkho_Load(object sender, System.EventArgs e)
		{
			kho.DisplayMember="TEN";
			kho.ValueMember="ID";
			sql="select * from ttb_dmkho where nhom="+i_nhom;
			if (s_kho!="") sql+=" and id in ("+s_kho.Substring(0,s_kho.Length-1)+")";
			sql+=" order by stt";
			dtdmkho=ttb.get_data(sql).Tables[0];
			kho.DataSource=dtdmkho;

			dtdmnhom=ttb.get_data("select * from ttb_dmnhom where stt<>0 and nhom="+i_nhom+" order by stt").Tables[0];
			manhom.DisplayMember="TEN";
			manhom.ValueMember="ID";
			manhom.DataSource=dtdmnhom;

			manguon.DisplayMember="TEN";
			manguon.ValueMember="ID";
			if (ttb.bQuanlynguon(i_nhom))
				manguon.DataSource=ttb.get_data("select * from ttb_dmnguon where nhom="+i_nhom+" order by stt").Tables[0];
			else
				manguon.DataSource=ttb.get_data("select * from ttb_dmnguon where id=0 or nhom="+i_nhom+" order by stt").Tables[0];
			nhomcc.DisplayMember="TEN";
			nhomcc.ValueMember="ID";
			if (ttb.bQuanlynhomcc(i_nhom))
				nhomcc.DataSource=ttb.get_data("select * from ttb_nhomcc where nhom="+i_nhom+" order by stt").Tables[0];
			else
				nhomcc.DataSource=ttb.get_data("select * from ttb_nhomcc where id=0 or nhom="+i_nhom+" order by stt").Tables[0];
			sql="select a.*, b.stt tt, b.ten nhombd, a.maloai idnn, f.ten noingoai from ttb_dmbd a, ttb_dmnhom b, ttb_dmhang e, ttb_dmloai f";
			sql+=" where a.manhom=b.id and a.mahang=e.id and a.maloai=f.id and a.nhom="+i_nhom+" order by a.id";
			dt=ttb.get_data(sql).Tables[0];			
			ds.ReadXml("..\\..\\..\\xml\\ttb_dasudung.xml");
			dsxml.ReadXml("..\\..\\..\\xml\\ttb_dasudung.xml");
		}

		private void butIn_Click(object sender, System.EventArgs e)
		{
			get_data();
		}

		private void get_sort()
		{
			dsxml.Clear();
			sql=(s_manhom!="")?"ten":"ten";
			tenreport=tenfile;
			DataRow []dr=ds.Tables[0].Select("ma<>''",sql);
			for(int i=0;i<dr.Length;i++)
			{
				r2 = dsxml.Tables[0].NewRow();
				r2["mabd"]=dr[i]["mabd"].ToString();
				r2["ma"]=dr[i]["ma"].ToString();
				r2["ten"]=dr[i]["ten"].ToString().Trim();
				r2["tenhc"]=dr[i]["tenhc"].ToString();
				r2["dang"]=dr[i]["dang"].ToString();
				r2["soluong"]=dr[i]["soluong"].ToString();
				r2["sotien"]=dr[i]["sotien"].ToString();
				r2["dongia"]=dr[i]["dongia"].ToString();
				//Nhombd
				r2["stt"]=dr[i]["stt"].ToString();
				r2["nhombd"]=dr[i]["nhombd"].ToString();
				r2["idnn"]=dr[i]["idnn"].ToString();
				r2["noingoai"]=dr[i]["noingoai"].ToString();
				//
				dsxml.Tables[0].Rows.Add(r2);
			}
		}

		private void get_xuat(string d_mmyy)
		{
			sql="select b.makho,b.mabd,sum(b.soluong) soluong,sum(b.soluong*b.giamua) sotien, b.giamua dongia, b.manguon from ttb_xuatsdll a,ttb_thucxuat b,"+ttb.user+".ttb_dmbd c where a.id=b.id and b.mabd=c.id and a.loai in(1,4) and a.nhom="+i_nhom+" and a.mmyy='"+d_mmyy+"'";
			if (s_kho!="") sql+=" and b.makho in ("+s_kho.Substring(0,s_kho.Length-1)+")";
			if (s_manhom!="") sql+=" and c.manhom in ("+s_manhom.Substring(0,s_manhom.Length-1)+")";
			if (manguon.SelectedIndex!=-1) sql+=" and b.manguon="+int.Parse(manguon.SelectedValue.ToString());
			if (nhomcc.SelectedIndex!=-1) sql+=" and b.nhomcc="+int.Parse(nhomcc.SelectedValue.ToString());
			sql+=" and b.soluong>0";
			sql+=" group by b.makho,b.mabd, b.giamua, b.manguon";
			//xu ly tren d_thucbucstt: bu tu truc
			sql+=" union all ";
			sql+="select b.makho,b.mabd,sum(b.soluong) soluong,sum(b.soluong*b.giamua) sotien, b.giamua dongia, b.manguon from ttb_xuatsdll a,ttb_thucbucstt b,"+ttb.user+".ttb_dmbd c where a.id=b.id and b.mabd=c.id and a.loai in(2) and a.nhom="+i_nhom+" and a.mmyy='"+d_mmyy+"'";
			if (s_kho!="") sql+=" and b.makho in ("+s_kho.Substring(0,s_kho.Length-1)+")";
			if (s_manhom!="") sql+=" and c.manhom in ("+s_manhom.Substring(0,s_manhom.Length-1)+")";
			if (manguon.SelectedIndex!=-1) sql+=" and b.manguon="+int.Parse(manguon.SelectedValue.ToString());
			if (nhomcc.SelectedIndex!=-1) sql+=" and b.nhomcc="+int.Parse(nhomcc.SelectedValue.ToString());
			sql+=" and b.soluong>0";
			sql+=" group by b.makho,b.mabd, b.giamua, b.manguon  ";
			//xuat CK, BS, XK
			sql+=" union all ";
			sql+="select a.khox makho,b.mabd,sum(b.soluong) soluong,sum(b.soluong*b.giamua) sotien, b.giamua dongia, b.manguon from ttb_xuatll a,ttb_xuatct b,"+ttb.user+".ttb_dmbd c where a.id=b.id and b.mabd=c.id and a.nhom="+i_nhom+" and a.loai in ('BS','XK') and a.mmyy='"+d_mmyy+"'";
			if (s_kho!="") sql+=" and a.khox in ("+s_kho.Substring(0,s_kho.Length-1)+")";
			if (s_manhom!="") sql+=" and c.manhom in ("+s_manhom.Substring(0,s_manhom.Length-1)+")";
			if (manguon.SelectedIndex!=-1) sql+=" and b.manguon="+int.Parse(manguon.SelectedValue.ToString());
			if (nhomcc.SelectedIndex!=-1) sql+=" and b.nhomcc="+int.Parse(nhomcc.SelectedValue.ToString());
			sql+=" and b.soluong>0";
			sql+=" group by a.khox,b.mabd, b.giamua, b.manguon ";
			//BHYT
			sql+=" union all ";
			sql+="select b.makho,b.mabd,sum(b.soluong) soluong,sum(b.soluong*b.giamua) sotien, b.giamua dongia, b.manguon from bhytkb a,bhytthuoc b,"+ttb.user+".ttb_dmbd c where a.id=b.id and b.mabd=c.id and a.nhom="+i_nhom+" and a.mmyy='"+d_mmyy+"'";
			if (s_kho!="") sql+=" and b.makho in ("+s_kho.Substring(0,s_kho.Length-1)+")";
			if (s_manhom!="") sql+=" and c.manhom in ("+s_manhom.Substring(0,s_manhom.Length-1)+")";
			if (manguon.SelectedIndex!=-1) sql+=" and b.manguon="+int.Parse(manguon.SelectedValue.ToString());
			if (nhomcc.SelectedIndex!=-1) sql+=" and b.nhomcc="+int.Parse(nhomcc.SelectedValue.ToString());
			sql+=" and b.soluong>0";
			sql+=" group by b.makho,b.mabd, b.giamua, b.manguon ";
			//ngoaitru
			//BHYT
			sql+=" union all ";
			sql+="select b.makho,b.mabd,sum(b.soluong) soluong,sum(b.soluong*b.giamua) sotien, b.giamua dongia, b.manguon from ttb_ngtrull a,ttb_ngtruct b,"+ttb.user+".ttb_dmbd c where a.id=b.id and b.mabd=c.id and a.nhom="+i_nhom+" and a.mmyy='"+d_mmyy+"'";
			if (s_kho!="") sql+=" and b.makho in ("+s_kho.Substring(0,s_kho.Length-1)+")";
			if (s_manhom!="") sql+=" and c.manhom in ("+s_manhom.Substring(0,s_manhom.Length-1)+")";
			if (manguon.SelectedIndex!=-1) sql+=" and b.manguon="+int.Parse(manguon.SelectedValue.ToString());
			if (nhomcc.SelectedIndex!=-1) sql+=" and b.nhomcc="+int.Parse(nhomcc.SelectedValue.ToString());
			sql+=" and b.soluong>0";
			sql+=" group by b.makho,b.mabd, b.giamua, b.manguon ";
			foreach(DataRow r in ttb.get_data(sql).Tables[0].Rows)//d_mmyy
			{				
				exp="mabd="+int.Parse(r["mabd"].ToString())+" and dongia="+decimal.Parse(r["dongia"].ToString());
				if (manguon.SelectedIndex!=-1) exp+=" and manguon="+int.Parse(manguon.SelectedValue.ToString());
				r1=ttb.getrowbyid(ds.Tables[0],exp);
				if ( r1 == null )
				{
					r3=ttb.getrowbyid(dt,"id="+int.Parse(r["mabd"].ToString()));
					if (r3!=null)
					{
						r2 = ds.Tables[0].NewRow();
						r2["mabd"]=r["mabd"].ToString();
						r2["ma"]=r3["ma"].ToString();
						r2["ten"]=r3["ten"].ToString().Trim()+" "+r3["hamluong"].ToString();
						r2["tenhc"]=r3["tenhc"].ToString();
						r2["dang"]=r3["dang"].ToString();
						r2["soluong"]=r["soluong"].ToString();
						r2["sotien"]=r["sotien"].ToString();
						r2["dongia"]=r["dongia"].ToString();
						//nhombd
						r2["stt"]=r3["tt"].ToString();
						r2["nhombd"]=r3["nhombd"].ToString();
						r2["idnn"]=r3["idnn"].ToString();
						r2["noingoai"]=r3["noingoai"].ToString();
						//
						ds.Tables[0].Rows.Add(r2);
					}
				}
				else
				{
					DataRow[] dr = ds.Tables[0].Select(exp);
					dr[0]["soluong"]=decimal.Parse(dr[0]["soluong"].ToString())+decimal.Parse(r["soluong"].ToString());
					dr[0]["sotien"]=decimal.Parse(dr[0]["sotien"].ToString())+decimal.Parse(r["sotien"].ToString());
				}
			}
			ds.AcceptChanges();
		}

		private void get_hoantra(string d_mmyy)
		{
			sql="select b.makho,b.mabd,sum(b.soluong) soluong,sum(b.soluong*b.giamua) sotien, b.giamua dongia, b.manguon from ttb_xuatsdll a,ttb_thucxuat b,"+ttb.user+".ttb_dmbd c where a.id=b.id and b.mabd=c.id and a.loai=3 and a.nhom="+i_nhom+" and a.mmyy='"+d_mmyy+"'";
			if (s_kho!="") sql+=" and b.makho in ("+s_kho.Substring(0,s_kho.Length-1)+")";
			if (s_manhom!="") sql+=" and c.manhom in ("+s_manhom.Substring(0,s_manhom.Length-1)+")";
			if (manguon.SelectedIndex!=-1) sql+=" and b.manguon="+int.Parse(manguon.SelectedValue.ToString());
			if (nhomcc.SelectedIndex!=-1) sql+=" and b.nhomcc="+int.Parse(nhomcc.SelectedValue.ToString());
			sql+=" and b.soluong>0";
			sql+=" group by b.makho,b.mabd, b.giamua, b.manguon ";
            foreach (DataRow r in ttb.get_data(sql).Tables[0].Rows)//d_mmyy
			{
				exp="mabd="+int.Parse(r["mabd"].ToString())+" and dongia="+decimal.Parse(r["dongia"].ToString());
				if (manguon.SelectedIndex!=-1) exp+=" and manguon="+int.Parse(manguon.SelectedValue.ToString());
				r1=ttb.getrowbyid(ds.Tables[0],exp);
				if ( r1 == null )
				{
					r3=ttb.getrowbyid(dt,"id="+int.Parse(r["mabd"].ToString()));
					if (r3!=null)
					{
						r2 = ds.Tables[0].NewRow();
						r2["mabd"]=r["mabd"].ToString();
						r2["ma"]=r3["ma"].ToString();
						r2["ten"]=r3["ten"].ToString().Trim()+" "+r3["hamluong"].ToString();
						r2["tenhc"]=r3["tenhc"].ToString();
						r2["dang"]=r3["dang"].ToString();
						r2["soluong"]=-decimal.Parse(r["soluong"].ToString());
						r2["sotien"]=-decimal.Parse(r["sotien"].ToString());
						r2["dongia"]=r["dongia"].ToString();
						//nhombd
						r2["stt"]=r3["tt"].ToString();
						r2["nhombd"]=r3["nhombd"].ToString();
						r2["idnn"]=r3["idnn"].ToString();
						r2["noingoai"]=r3["noingoai"].ToString();
						//
						ds.Tables[0].Rows.Add(r2);
					}
				}
				else
				{
					DataRow[] dr = ds.Tables[0].Select(exp);
					dr[0]["soluong"]=decimal.Parse(dr[0]["soluong"].ToString())-decimal.Parse(r["soluong"].ToString());
					dr[0]["sotien"]=decimal.Parse(dr[0]["sotien"].ToString())-decimal.Parse(r["sotien"].ToString());
				}
			}
			ds.AcceptChanges();
		}

		private void butKetthuc_Click(object sender, System.EventArgs e)
		{
			this.Close();		
		}

		private void tu_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");
		}


		private void rptXuatkho_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (bClear)
			{
				manguon.SelectedIndex=-1;
				nhomcc.SelectedIndex=-1;
				bClear=false;
			}
		}

		private void get_data()
		{
			if (tu.Value>den.Value)
			{
				MessageBox.Show("Tháng không hợp lệ !",ttb.Msg);
				tu.Focus();
				return;
			}
			s_manhom="";
			for(int i=0;i<manhom.Items.Count;i++) 
				if (manhom.GetItemChecked(i)) s_manhom+=dtdmnhom.Rows[i]["id"].ToString()+",";
			s_kho="";
			string s_tenkho="";
			for(int i=0;i<kho.Items.Count;i++) 
			{
				if (kho.GetItemChecked(i))
				{
					s_kho+=dtdmkho.Rows[i]["id"].ToString()+",";
					s_tenkho+=dtdmkho.Rows[i]["ten"].ToString()+",";
				}
			}
			ds.Clear();
			dsxml.Clear();
			s_mmyy=tu.Value.ToString().PadLeft(2,'0')+yyyy.Value.ToString().PadLeft(4,'0').Substring(2,2);
			s_tu=tu.Value.ToString().PadLeft(2,'0');
			s_den=den.Value.ToString().PadLeft(2,'0');
			s_yy=yyyy.Value.ToString().PadLeft(4,'0').Substring(2,2);
			int y1=int.Parse(yyyy.Value.ToString()),m1=int.Parse(tu.Value.ToString());
			int y2=int.Parse(yyyy.Value.ToString()),m2=int.Parse(den.Value.ToString());
			int itu,iden;
			string mmyy=m1.ToString().PadLeft(2,'0')+y1.ToString().Substring(2,2);
			for(int i=y1;i<=y2;i++)
			{
				itu=(i==y1)?m1:1;
				iden=(i==y2)?m2:12;
				for(int j=itu;j<=iden;j++)
				{
					mmyy=j.ToString().PadLeft(2,'0')+i.ToString().Substring(2,2);
					if (ttb.bMmyy(mmyy))
					{						
						get_xuat(mmyy);
						get_hoantra(mmyy);
					}
				}
			}			
			if (ds.Tables[0].Rows.Count==0)
			{
				MessageBox.Show("Không có số liệu !",ttb.Msg);
				return;
			}
			get_sort();
			string s_thoigian=ttb.title(tu.Value.ToString(),den.Value.ToString())+" Năm "+yyyy.Value.ToString();
			frmReport f=new frmReport(ttb,dsxml.Tables[0],"d_dasudung.rpt",s_thoigian,"",(manguon.SelectedIndex==-1)?"":"Nguồn :"+manguon.Text,(nhomcc.SelectedIndex==-1)?"":" Nhóm nhà cung cấp :"+nhomcc.Text,"PHIẾU XUẤT KHO","","","","","");
			f.ShowDialog();
		}
	}
}
