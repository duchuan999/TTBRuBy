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
	/// Summary description for rptBctheoloai.
	/// </summary>
	public class rptBctheoloai : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button butIn;
		private System.Windows.Forms.Button butKetthuc;
        private LibTTB.AccessData ttb;
		private int i_nhom;
		private bool bClear=true;
		private string sql,s_mmyy,s_tu,s_den,s_yy,s_kho,s_maloai,s_makho;
		private DataRow r1,r2,r3;
		private DataRow[] dr;
		private DataSet ds=new DataSet();
		private DataTable dt=new DataTable();
		private DataTable dtkho=new DataTable();
		private DataTable dtdmkho=new DataTable();
		private DataTable dtkp=new DataTable();
		private DataTable dtdmloai=new DataTable();
		private DataSet dsxml=new DataSet();
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox nhomcc;
		private System.Windows.Forms.ComboBox manguon;
		private System.Windows.Forms.NumericUpDown yyyy;
		private System.Windows.Forms.NumericUpDown tu;
		private System.Windows.Forms.NumericUpDown den;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckedListBox kho;
		private System.Windows.Forms.CheckedListBox maloai;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public rptBctheoloai(AccessData acc,int nhom,string kho,string mmyy)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			ttb=acc;
			i_nhom=nhom;
			s_makho=kho;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(rptBctheoloai));
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
			this.kho = new System.Windows.Forms.CheckedListBox();
			this.maloai = new System.Windows.Forms.CheckedListBox();
			((System.ComponentModel.ISupportInitialize)(this.tu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.yyyy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.den)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(1, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Từ tháng :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(168, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "năm :";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// butIn
			// 
			this.butIn.Image = ((System.Drawing.Bitmap)(resources.GetObject("butIn.Image")));
			this.butIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butIn.Location = new System.Drawing.Point(185, 229);
			this.butIn.Name = "butIn";
			this.butIn.Size = new System.Drawing.Size(75, 28);
			this.butIn.TabIndex = 7;
			this.butIn.Text = "      &In";
			this.butIn.Click += new System.EventHandler(this.butIn_Click);
			// 
			// butKetthuc
			// 
			this.butKetthuc.Image = ((System.Drawing.Bitmap)(resources.GetObject("butKetthuc.Image")));
			this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butKetthuc.Location = new System.Drawing.Point(262, 229);
			this.butKetthuc.Name = "butKetthuc";
			this.butKetthuc.Size = new System.Drawing.Size(75, 28);
			this.butKetthuc.TabIndex = 8;
			this.butKetthuc.Text = "&Kết thúc";
			this.butKetthuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
			// 
			// manguon
			// 
			this.manguon.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.manguon.Location = new System.Drawing.Point(56, 40);
			this.manguon.Name = "manguon";
			this.manguon.Size = new System.Drawing.Size(192, 21);
			this.manguon.TabIndex = 3;
			this.manguon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(1, 37);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Nguồn :";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nhomcc
			// 
			this.nhomcc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nhomcc.Location = new System.Drawing.Point(56, 64);
			this.nhomcc.Name = "nhomcc";
			this.nhomcc.Size = new System.Drawing.Size(192, 21);
			this.nhomcc.TabIndex = 4;
			this.nhomcc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(-4, 63);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Nhóm CC :";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tu
			// 
			this.tu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tu.Location = new System.Drawing.Point(56, 16);
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
			this.tu.TabIndex = 0;
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
			this.yyyy.Location = new System.Drawing.Point(200, 16);
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
			this.yyyy.TabIndex = 2;
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
			this.den.Location = new System.Drawing.Point(128, 16);
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
			this.den.TabIndex = 1;
			this.den.Value = new System.Decimal(new int[] {
															  1,
															  0,
															  0,
															  0});
			this.den.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(96, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 23);
			this.label3.TabIndex = 12;
			this.label3.Text = "đến :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// kho
			// 
			this.kho.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.kho.Location = new System.Drawing.Point(56, 87);
			this.kho.Name = "kho";
			this.kho.Size = new System.Drawing.Size(192, 132);
			this.kho.TabIndex = 5;
			// 
			// maloai
			// 
			this.maloai.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.maloai.Location = new System.Drawing.Point(253, 7);
			this.maloai.Name = "maloai";
			this.maloai.Size = new System.Drawing.Size(264, 212);
			this.maloai.TabIndex = 13;
			// 
			// rptBctheoloai
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(522, 271);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.maloai,
																		  this.kho,
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
			this.Name = "rptBctheoloai";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Báo cáo sử dụng theo phân loại";
			this.Load += new System.EventHandler(this.rptBctheoloai_Load);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rptBctheoloai_MouseMove);
			((System.ComponentModel.ISupportInitialize)(this.tu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.yyyy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.den)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void rptBctheoloai_Load(object sender, System.EventArgs e)
		{
			ds.ReadXml("..\\..\\..\\xml\\ttb_bctheoloai.xml");
			dsxml.ReadXml("..\\..\\..\\xml\\ttb_bctheoloai.xml");
			dtdmloai=ttb.get_data("select * from ttb_dmloai where stt>0 and nhom="+i_nhom+" order by stt").Tables[0];
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
			dt=ttb.get_data("select a.*,b.ten tenloai from ttb_dmbd a,ttb_dmloai b where a.maloai=b.id and a.nhom="+i_nhom+" order by a.id").Tables[0];
			sql="select * from ttb_dmkho where nhom="+i_nhom;
			if (s_makho!="") sql+=" and id in ("+s_makho.Substring(0,s_makho.Length-1)+")";
			sql+=" order by stt";
			dtdmkho=ttb.get_data(sql).Tables[0];
			kho.DisplayMember="TEN";
			kho.ValueMember="ID";
			kho.DataSource=dtdmkho;
			maloai.DisplayMember="TEN";
			maloai.ValueMember="ID";
			maloai.DataSource=dtdmloai;
			s_maloai=ttb.Thongso("maloai").Trim();
		}

		private void get_xuat(string d_mmyy)
		{
			sql="select b.mabd,sum(b.soluong) soluong,sum(b.soluong*b.giamua) sotien from ttb_xuatsdll a,ttb_thucxuat b,"+ttb.user+".ttb_dmbd c ";
			sql+="where a.id=b.id and b.mabd=c.id and a.loai<>3 and a.nhom="+i_nhom+" and substr(a.mmyy,3,2)='"+s_yy+"'"+" and substr(a.mmyy,1,2) between '"+s_tu+"'"+" and '"+s_den+"'";
			if (s_kho!="") sql+=" and b.makho in ("+s_kho.Substring(0,s_kho.Length-1)+")";
			if (s_maloai!="") sql+=" and c.maloai in ("+s_maloai.Substring(0,s_maloai.Length-1)+")";
			if (manguon.SelectedIndex!=-1) sql+=" and b.manguon="+int.Parse(manguon.SelectedValue.ToString());
			if (nhomcc.SelectedIndex!=-1) sql+=" and b.nhomcc="+int.Parse(nhomcc.SelectedValue.ToString());
			sql+=" group by b.mabd";
			sql+=" union all select b.mabd,sum(b.soluong) soluong,sum(b.soluong*b.giamua) sotien from ttb_ngtrull a,ttb_ngtruct b,"+ttb.user+".ttb_dmbd c where a.id=b.id and b.mabd=c.id and a.nhom="+i_nhom+" and substr(a.mmyy,3,2)='"+s_yy+"'"+" and substr(a.mmyy,1,2) between '"+s_tu+"'"+" and '"+s_den+"'";
			if (s_kho!="") sql+=" and b.makho in ("+s_kho.Substring(0,s_kho.Length-1)+")";
			if (s_maloai!="") sql+=" and c.maloai in ("+s_maloai.Substring(0,s_maloai.Length-1)+")";
			if (manguon.SelectedIndex!=-1) sql+=" and b.manguon="+int.Parse(manguon.SelectedValue.ToString());
			if (nhomcc.SelectedIndex!=-1) sql+=" and b.nhomcc="+int.Parse(nhomcc.SelectedValue.ToString());
			sql+=" group by b.mabd";
			sql+=" union all select b.mabd,sum(b.soluong) soluong,sum(b.soluong*b.giamua) sotien from ttb_xuatll a,ttb_xuatct b,"+ttb.user+".ttb_dmbd c where a.id=b.id and b.mabd=c.id and a.nhom="+i_nhom+" and a.loai='XK'"+" and substr(a.mmyy,3,2)='"+s_yy+"'"+" and substr(a.mmyy,1,2) between '"+s_tu+"'"+" and '"+s_den+"'";
			if (s_kho!="") sql+=" and a.khox in ("+s_kho.Substring(0,s_kho.Length-1)+")";
			if (s_maloai!="") sql+=" and c.maloai in ("+s_maloai.Substring(0,s_maloai.Length-1)+")";
			if (manguon.SelectedIndex!=-1) sql+=" and b.manguon="+int.Parse(manguon.SelectedValue.ToString());
			if (nhomcc.SelectedIndex!=-1) sql+=" and b.nhomcc="+int.Parse(nhomcc.SelectedValue.ToString());
			sql+=" group by b.mabd";
			sql+=" union all select b.mabd,sum(b.soluong) soluong,sum(b.soluong*b.giamua) sotien from bhytkb a,bhytthuoc b,"+ttb.user+".ttb_dmbd c where a.id=b.id and b.mabd=c.id and a.nhom="+i_nhom+" and substr(a.mmyy,3,2)='"+s_yy+"'"+" and substr(a.mmyy,1,2) between '"+s_tu+"'"+" and '"+s_den+"'";
			if (s_kho!="") sql+=" and b.makho in ("+s_kho.Substring(0,s_kho.Length-1)+")";
			if (s_maloai!="") sql+=" and c.maloai in ("+s_maloai.Substring(0,s_maloai.Length-1)+")";
			if (manguon.SelectedIndex!=-1) sql+=" and b.manguon="+int.Parse(manguon.SelectedValue.ToString());
			if (nhomcc.SelectedIndex!=-1) sql+=" and b.nhomcc="+int.Parse(nhomcc.SelectedValue.ToString());
			sql+=" group by b.mabd";

			ins_items(d_mmyy);

		}

		private void ins_items(string d_mmyy)
		{
			foreach(DataRow r in ttb.get_data(sql).Tables[0].Rows)//d_mmyy
			{
				r1=ttb.getrowbyid(ds.Tables[0],"mabd="+int.Parse(r["mabd"].ToString()));
				if ( r1 == null )
				{
					r3=ttb.getrowbyid(dt,"id="+int.Parse(r["mabd"].ToString()));
					if (r3!=null)
					{
						r2 = ds.Tables[0].NewRow();
						r2["maloai"]=r3["maloai"].ToString();
						r2["tenloai"]=r3["tenloai"].ToString();
						r2["mabd"]=r["mabd"].ToString();
						r2["ma"]=r3["ma"].ToString();
						r2["ten"]=r3["ten"].ToString().Trim()+" "+r3["hamluong"].ToString();
						r2["dang"]=r3["dang"].ToString();
						r2["soluong"]=r["soluong"].ToString();
						r2["sotien"]=r["sotien"].ToString();
						ds.Tables[0].Rows.Add(r2);
					}
				}
				else
				{
					dr = ds.Tables[0].Select("mabd="+int.Parse(r["mabd"].ToString()));
					dr[0]["soluong"]=decimal.Parse(dr[0]["soluong"].ToString())+decimal.Parse(r["soluong"].ToString());
					dr[0]["sotien"]=decimal.Parse(dr[0]["sotien"].ToString())+decimal.Parse(r["sotien"].ToString());
				}
			}
			ds.AcceptChanges();
		}
		private void get_hoantra(string d_mmyy)
		{
			sql="select b.mabd,sum(b.soluong) soluong,sum(b.soluong*b.giamua) sotien from ttb_xuatsdll a,ttb_thucxuat b,"+ttb.user+".ttb_dmbd c ";
			sql+="where a.id=b.id and b.mabd=c.id and a.loai=3 and a.nhom="+i_nhom+" and substr(a.mmyy,3,2)='"+s_yy+"'"+" and substr(a.mmyy,1,2) between '"+s_tu+"'"+" and '"+s_den+"'";
			if (s_kho!="") sql+=" and b.makho in ("+s_kho.Substring(0,s_kho.Length-1)+")";
			if (s_maloai!="") sql+=" and c.maloai in ("+s_maloai.Substring(0,s_maloai.Length-1)+")";
			if (manguon.SelectedIndex!=-1) sql+=" and b.manguon="+int.Parse(manguon.SelectedValue.ToString());
			if (nhomcc.SelectedIndex!=-1) sql+=" and b.nhomcc="+int.Parse(nhomcc.SelectedValue.ToString());
			sql+=" group by b.mabd";
			foreach(DataRow r in ttb.get_data(sql).Tables[0].Rows)//d_mmyy
			{
				r1=ttb.getrowbyid(ds.Tables[0],"mabd="+int.Parse(r["mabd"].ToString()));
				if ( r1 == null )
				{
					r3=ttb.getrowbyid(dt,"id="+int.Parse(r["mabd"].ToString()));
					if (r3!=null)
					{
						r2 = ds.Tables[0].NewRow();
						r2["maloai"]=r3["maloai"].ToString();
						r2["tenloai"]=r3["tenloai"].ToString();
						r2["mabd"]=r["mabd"].ToString();
						r2["ma"]=r3["ma"].ToString();
						r2["ten"]=r3["ten"].ToString().Trim()+" "+r3["hamluong"].ToString();
						r2["dang"]=r3["dang"].ToString();
						r2["soluong"]=-decimal.Parse(r["soluong"].ToString());
						r2["sotien"]=-decimal.Parse(r["sotien"].ToString());
						ds.Tables[0].Rows.Add(r2);
					}
				}
				else
				{
					dr = ds.Tables[0].Select("mabd="+int.Parse(r["mabd"].ToString()));
					dr[0]["soluong"]=decimal.Parse(dr[0]["soluong"].ToString())-decimal.Parse(r["soluong"].ToString());
					dr[0]["sotien"]=decimal.Parse(dr[0]["sotien"].ToString())-decimal.Parse(r["sotien"].ToString());
				}
			}
			ds.AcceptChanges();
		}

		private void get_sort()
		{
			dsxml.Clear();
			DataRow []dr=ds.Tables[0].Select("ma<>''","tenloai,ten");
			for(int i=0;i<dr.Length;i++)
			{
				r2 = dsxml.Tables[0].NewRow();
				r2["mabd"]=dr[i]["mabd"].ToString();
				r2["ma"]=dr[i]["ma"].ToString();
				r2["ten"]=dr[i]["ten"].ToString();
				r2["maloai"]=dr[i]["maloai"].ToString();
				r2["tenloai"]=dr[i]["tenloai"].ToString();
				r2["dang"]=dr[i]["dang"].ToString();
				r2["soluong"]=dr[i]["soluong"].ToString();
				r2["sotien"]=dr[i]["sotien"].ToString();
				dsxml.Tables[0].Rows.Add(r2);
			}
		}
		private void butKetthuc_Click(object sender, System.EventArgs e)
		{
			ttb.writeXml("ttb_thongso","maloai",s_maloai);
			this.Close();		
		}

		private void tu_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");
		}

		private void rptBctheoloai_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (bClear)
			{
				manguon.SelectedIndex=-1;
				nhomcc.SelectedIndex=-1;
				string sloai=","+s_maloai;
				for(int i=0;i<dtdmloai.Rows.Count;i++)
					if (sloai.IndexOf(","+dtdmloai.Rows[i]["id"].ToString().Trim()+",")!=-1) maloai.SetItemCheckState(i,CheckState.Checked);
					else maloai.SetItemCheckState(i,CheckState.Unchecked);
				bClear=false;
			}
		}

		private void butIn_Click(object sender, System.EventArgs e)
		{
			if (!kiemtra()) return;
			frmReport f=new frmReport(ttb,dsxml.Tables[0],"d_bctheoloai.rpt",(s_tu==s_den)?"Tháng "+s_tu+" năm "+yyyy.Value.ToString():"Từ tháng "+s_tu+" đến "+s_den+" năm "+yyyy.Value.ToString(),"","","","","","","","","");
			f.ShowDialog();
		}

		private bool kiemtra()
		{
			if (tu.Value>den.Value)
			{
				MessageBox.Show("Tháng không hợp lệ !",ttb.Msg);
				tu.Focus();
				return false;
			}
			s_maloai="";
			for(int i=0;i<maloai.Items.Count;i++) 
				if (maloai.GetItemChecked(i)) s_maloai+=dtdmloai.Rows[i]["id"].ToString()+",";
			s_kho="";
			if (kho.CheckedItems.Count==0) for(int i=0;i<kho.Items.Count;i++) kho.SetItemCheckState(i,CheckState.Checked);
			for(int i=0;i<kho.Items.Count;i++)
				if (kho.GetItemChecked(i)) s_kho+=dtdmkho.Rows[i]["id"].ToString()+",";
			s_mmyy=tu.Value.ToString().PadLeft(2,'0')+yyyy.Value.ToString().PadLeft(4,'0').Substring(2,2);
			s_tu=tu.Value.ToString().PadLeft(2,'0');
			s_den=den.Value.ToString().PadLeft(2,'0');
			s_yy=yyyy.Value.ToString().PadLeft(4,'0').Substring(2,2);			
			ds.Clear();
			//
			//			
			int y1=int.Parse(yyyy.Value.ToString()),m1=int.Parse(tu.Value.ToString());
			int y2=int.Parse(yyyy.Value.ToString()),m2=int.Parse(den.Value.ToString());
			int itu,iden;
			string mmyy="";					
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
			get_sort();
			if (ds.Tables[0].Rows.Count==0)
			{
				MessageBox.Show("Không có số liệu !",ttb.Msg);
				return false;
			}
			return true;
		}

	}
}
