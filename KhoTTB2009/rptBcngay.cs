using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Data;
using LibTTB;
using Excel;
namespace TTB
{
	/// <summary>
	/// Summary description for rptBcngay.
	/// </summary>
	public class rptBcngay : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button butIn;
		private System.Windows.Forms.Button butKetthuc;
		private DataColumn dc;
        private LibTTB.AccessData ttb;
		private int i_nhom;
		private bool bClear=true;
		private string sql,tenfile,s_kho,s_makho;
		private DataRow r1,r2,r3;
		private DataRow[] dr;
		private DataSet ds;
		private System.Data.DataTable dt=new System.Data.DataTable();
		private System.Data.DataTable dtkho=new System.Data.DataTable();
		private System.Data.DataTable dtdmkho=new System.Data.DataTable();
		private DataSet dsngay=new DataSet();
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox nhomcc;
		private System.Windows.Forms.ComboBox manguon;
		Excel.Application oxl;
		Excel._Workbook owb;
		Excel._Worksheet osheet;
		Excel.Range orange;
		private System.Windows.Forms.CheckedListBox kho;
		private System.Windows.Forms.Button butXem;
		private System.Windows.Forms.DateTimePicker tu;
		private System.Windows.Forms.DateTimePicker den;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public rptBcngay(AccessData acc,int nhom,string kho)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			ttb=acc;
			i_nhom=nhom;
			s_makho=kho;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(rptBcngay));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.butIn = new System.Windows.Forms.Button();
			this.butKetthuc = new System.Windows.Forms.Button();
			this.manguon = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.nhomcc = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.kho = new System.Windows.Forms.CheckedListBox();
			this.butXem = new System.Windows.Forms.Button();
			this.tu = new System.Windows.Forms.DateTimePicker();
			this.den = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(4, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Từ ngày :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(136, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "đến :";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// butIn
			// 
			this.butIn.Image = ((System.Drawing.Bitmap)(resources.GetObject("butIn.Image")));
			this.butIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butIn.Location = new System.Drawing.Point(96, 197);
			this.butIn.Name = "butIn";
			this.butIn.Size = new System.Drawing.Size(59, 28);
			this.butIn.TabIndex = 6;
			this.butIn.Text = "      &In";
			this.butIn.Click += new System.EventHandler(this.butIn_Click);
			// 
			// butKetthuc
			// 
			this.butKetthuc.Image = ((System.Drawing.Bitmap)(resources.GetObject("butKetthuc.Image")));
			this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butKetthuc.Location = new System.Drawing.Point(156, 197);
			this.butKetthuc.Name = "butKetthuc";
			this.butKetthuc.Size = new System.Drawing.Size(75, 28);
			this.butKetthuc.TabIndex = 7;
			this.butKetthuc.Text = "&Kết thúc";
			this.butKetthuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
			// 
			// manguon
			// 
			this.manguon.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.manguon.Location = new System.Drawing.Point(59, 40);
			this.manguon.Name = "manguon";
			this.manguon.Size = new System.Drawing.Size(192, 21);
			this.manguon.TabIndex = 2;
			this.manguon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(4, 37);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Nguồn :";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nhomcc
			// 
			this.nhomcc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nhomcc.Location = new System.Drawing.Point(59, 64);
			this.nhomcc.Name = "nhomcc";
			this.nhomcc.Size = new System.Drawing.Size(192, 21);
			this.nhomcc.TabIndex = 3;
			this.nhomcc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(-1, 63);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Nhóm CC :";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// kho
			// 
			this.kho.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.kho.Location = new System.Drawing.Point(59, 88);
			this.kho.Name = "kho";
			this.kho.Size = new System.Drawing.Size(192, 100);
			this.kho.TabIndex = 4;
			// 
			// butXem
			// 
			this.butXem.Image = ((System.Drawing.Bitmap)(resources.GetObject("butXem.Image")));
			this.butXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butXem.Location = new System.Drawing.Point(35, 197);
			this.butXem.Name = "butXem";
			this.butXem.Size = new System.Drawing.Size(60, 28);
			this.butXem.TabIndex = 5;
			this.butXem.Text = "     &Xem";
			this.butXem.Click += new System.EventHandler(this.butXem_Click);
			// 
			// tu
			// 
			this.tu.CustomFormat = "dd/MM/yyyy";
			this.tu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.tu.Location = new System.Drawing.Point(59, 16);
			this.tu.Name = "tu";
			this.tu.Size = new System.Drawing.Size(80, 21);
			this.tu.TabIndex = 0;
			this.tu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
			// 
			// den
			// 
			this.den.CustomFormat = "dd/MM/yyyy";
			this.den.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.den.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.den.Location = new System.Drawing.Point(171, 16);
			this.den.Name = "den";
			this.den.Size = new System.Drawing.Size(80, 21);
			this.den.TabIndex = 1;
			this.den.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
			// 
			// rptBcngay
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(266, 239);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.den,
																		  this.tu,
																		  this.butXem,
																		  this.kho,
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
			this.Name = "rptBcngay";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Báo cáo sử dụng theo ngày";
			this.Load += new System.EventHandler(this.rptBcngay_Load);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rptBcngay_MouseMove);
			this.ResumeLayout(false);

		}
		#endregion

		private void rptBcngay_Load(object sender, System.EventArgs e)
		{
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
			dt=ttb.get_data("select * from ttb_dmbd where nhom="+i_nhom+" order by id").Tables[0];
			sql="select * from ttb_dmkho where nhom="+i_nhom;
			if (s_makho!="") sql+=" and id in ("+s_makho.Substring(0,s_makho.Length-1)+")";
			sql+=" order by stt";
			dtdmkho=ttb.get_data(sql).Tables[0];
			kho.DisplayMember="TEN";
			kho.ValueMember="ID";
			kho.DataSource=dtdmkho;
			dsngay.ReadXml("..\\..\\..\\xml\\ttb_tsngay.xml");
		}

		private void Tao_dataset()
		{
			ds=new DataSet();
			ds.ReadXml("..\\..\\..\\xml\\ttb_bcngay.xml");
			dsngay.Clear();
			DateTime dt1=ttb.StringToDate(tu.Text);
			DateTime dt2=ttb.StringToDate(den.Text);
			int y1=dt1.Year,m1=dt1.Month;
			int y2=dt2.Year,m2=dt2.Month;
			int itu,iden;
			string mmyy="";					
			for(int i=y1;i<=y2;i++)
			{
				itu=(i==y1)?m1:1;
				iden=(i==y2)?m2:12;
				for(int j=itu;j<=iden;j++)
				{
					mmyy=j.ToString().PadLeft(2,'0')+i.ToString().Substring(2,2);
					sql="select distinct to_char(ngay,'yymmdd') ngay,to_char(ngay,'dd/mm') ten from ttb_xuatsdll where nhom="+i_nhom+" and to_date(ngay,'dd/mm/yy') between to_date('"+tu.Text+"','dd/mm/yy') and to_date('"+den.Text+"','dd/mm/yy')";
					sql+="union all select distinct to_char(ngay,'yymmdd') ngay,to_char(ngay,'dd/mm') ten from ttb_xuatll where nhom="+i_nhom+" and loai='XK' and to_date(ngay,'dd/mm/yy') between to_date('"+tu.Text+"','dd/mm/yy') and to_date('"+den.Text+"','dd/mm/yy')";
					sql+="union all select distinct to_char(ngay,'yymmdd') ngay,to_char(ngay,'dd/mm') ten from ttb_ngtrull where nhom="+i_nhom+" and to_date(ngay,'dd/mm/yy') between to_date('"+tu.Text+"','dd/mm/yy') and to_date('"+den.Text+"','dd/mm/yy')";
					sql+="union all select distinct to_char(a.ngay,'yymmdd') ngay,to_char(a.ngay,'dd/mm') ten from bhytkb a,bhytthuoc b where a.id=b.id and a.nhom="+i_nhom+" and to_date(a.ngay,'dd/mm/yy') between to_date('"+tu.Text+"','dd/mm/yy') and to_date('"+den.Text+"','dd/mm/yy')";
                    dr = ttb.get_data(sql).Tables[0].Select("ngay<>''", "ngay");//mmyy
					for(int k=0;k<dr.Length;k++)
					{
						r1=ttb.getrowbyid(dsngay.Tables[0],"ngay='"+dr[k]["ngay"].ToString()+"'");
						if ( r1 == null )
						{
							r2 = dsngay.Tables[0].NewRow();
							r2["ngay"]=dr[k]["ngay"].ToString();
							r2["ten"]=dr[k]["ten"].ToString();
							dsngay.Tables[0].Rows.Add(r2);
							dc=new DataColumn();
							dc.ColumnName="SL_"+dr[k]["ngay"].ToString().Trim();
							dc.DataType=Type.GetType("System.Decimal");
							ds.Tables[0].Columns.Add(dc);
						}
					}
				}
			}
			dc=new DataColumn();
			dc.ColumnName="TONGCONG";
			dc.DataType=Type.GetType("System.Decimal");
			ds.Tables[0].Columns.Add(dc);
		}

		private void get_xuat(string d_mmyy)
		{
			sql="select to_char(a.ngay,'yymmdd') ngay,b.mabd,c.ten,sum(b.soluong) soluong from ttb_xuatsdll a,ttb_thucxuat b,"+ttb.user+".ttb_dmbd c ";
			sql+="where a.id=b.id and b.mabd=c.id and a.loai<>3 and a.nhom="+i_nhom+" and to_date(a.ngay,'dd/mm/yy') between to_date('"+tu.Text+"','dd/mm/yy') and to_date('"+den.Text+"','dd/mm/yy')";
			if (s_kho!="") sql+=" and b.makho in ("+s_kho.Substring(0,s_kho.Length-1)+")";
			if (manguon.SelectedIndex!=-1) sql+=" and b.manguon="+int.Parse(manguon.SelectedValue.ToString());
			if (nhomcc.SelectedIndex!=-1) sql+=" and b.nhomcc="+int.Parse(nhomcc.SelectedValue.ToString());
			sql+=" group by a.ngay,b.mabd,c.ten order by c.ten";
			ins_items(d_mmyy);
			
			sql="select to_char(a.ngay,'yymmdd') ngay,b.mabd,c.ten,sum(b.soluong) soluong from ttb_xuatll a,ttb_xuatct b,"+ttb.user+".ttb_dmbd c ";
			sql+="where a.id=b.id and b.mabd=c.id and a.loai='XK' and a.nhom="+i_nhom+" and to_date(a.ngay,'dd/mm/yy') between to_date('"+tu.Text+"','dd/mm/yy') and to_date('"+den.Text+"','dd/mm/yy')";
			if (s_kho!="") sql+=" and a.khox in ("+s_kho.Substring(0,s_kho.Length-1)+")";
			if (manguon.SelectedIndex!=-1) sql+=" and b.manguon="+int.Parse(manguon.SelectedValue.ToString());
			if (nhomcc.SelectedIndex!=-1) sql+=" and b.nhomcc="+int.Parse(nhomcc.SelectedValue.ToString());
			sql+=" group by a.ngay,b.mabd,c.ten order by c.ten";
			ins_items(d_mmyy);

			sql="select to_char(a.ngay,'yymmdd') ngay,b.mabd,c.ten,sum(b.soluong) soluong from ttb_ngtrull a,ttb_ngtruct b,"+ttb.user+".ttb_dmbd c ";
			sql+="where a.id=b.id and b.mabd=c.id and a.nhom="+i_nhom+" and to_date(a.ngay,'dd/mm/yy') between to_date('"+tu.Text+"','dd/mm/yy') and to_date('"+den.Text+"','dd/mm/yy')";
			if (s_kho!="") sql+=" and b.makho in ("+s_kho.Substring(0,s_kho.Length-1)+")";
			if (manguon.SelectedIndex!=-1) sql+=" and b.manguon="+int.Parse(manguon.SelectedValue.ToString());
			if (nhomcc.SelectedIndex!=-1) sql+=" and b.nhomcc="+int.Parse(nhomcc.SelectedValue.ToString());
			sql+=" group by a.ngay,b.mabd,c.ten order by c.ten";
			ins_items(d_mmyy);

			sql="select to_char(a.ngay,'yymmdd') ngay,b.mabd,c.ten,sum(b.soluong) soluong from bhytkb a,bhytthuoc b,"+ttb.user+".ttb_dmbd c ";
			sql+="where a.id=b.id and b.mabd=c.id and a.nhom="+i_nhom+" and to_date(a.ngay,'dd/mm/yy') between to_date('"+tu.Text+"','dd/mm/yy') and to_date('"+den.Text+"','dd/mm/yy')";
			if (s_kho!="") sql+=" and b.makho in ("+s_kho.Substring(0,s_kho.Length-1)+")";
			if (manguon.SelectedIndex!=-1) sql+=" and b.manguon="+int.Parse(manguon.SelectedValue.ToString());
			if (nhomcc.SelectedIndex!=-1) sql+=" and b.nhomcc="+int.Parse(nhomcc.SelectedValue.ToString());
			sql+=" group by a.ngay,b.mabd,c.ten order by c.ten";
			ins_items(d_mmyy);
		}

		private void ins_items(string d_mmyy)
		{
            foreach (DataRow r in ttb.get_data(sql).Tables[0].Rows)//d_mmyy
			{
				r1=ttb.getrowbyid(ds.Tables[0],"mabd="+int.Parse(r["mabd"].ToString()));
				if ( r1 == null )
				{
					r3=ttb.getrowbyid(dt,"id="+int.Parse(r["mabd"].ToString()));
					if (r3!=null)
					{
						r2 = ds.Tables[0].NewRow();
						r2["mabd"]=r["mabd"].ToString();
						r2["stt"]=ttb.get_stt(ds.Tables[0]);
						r2["ma"]=r3["ma"].ToString();
						r2["ten"]=r3["ten"].ToString().Trim()+" "+r3["hamluong"].ToString();
						r2["dang"]=r3["dang"].ToString();
						foreach(DataRow r4 in dsngay.Tables[0].Rows) r2["sl_"+r4["ngay"].ToString().Trim()]=0;
						r2["sl_"+r["ngay"].ToString().Trim()]=r["soluong"].ToString();
						r2["tongcong"]=r["soluong"].ToString();
						ds.Tables[0].Rows.Add(r2);
					}
				}
				else
				{
					dr = ds.Tables[0].Select("mabd="+int.Parse(r["mabd"].ToString()));
					dr[0]["sl_"+r["ngay"].ToString().Trim()]=decimal.Parse(dr[0]["sl_"+r["ngay"].ToString().Trim()].ToString())+decimal.Parse(r["soluong"].ToString());
					dr[0]["tongcong"]=decimal.Parse(dr[0]["tongcong"].ToString())+decimal.Parse(r["soluong"].ToString());
				}
			}
			ds.AcceptChanges();
		}

		private void get_hoantra(string d_mmyy)
		{
			sql="select to_char(a.ngay,'yymmdd') ngay,b.mabd,c.ten,sum(b.soluong) soluong from ttb_xuatsdll a,ttb_thucxuat b,"+ttb.user+".ttb_dmbd c ";
			sql+="where a.id=b.id and b.mabd=c.id and a.loai=3 and a.nhom="+i_nhom+" and to_date(a.ngay,'dd/mm/yy') between to_date('"+tu.Text+"','dd/mm/yy') and to_date('"+den.Text+"','dd/mm/yy')";
			if (s_kho!="") sql+=" and b.makho in ("+s_kho.Substring(0,s_kho.Length-1)+")";
			if (manguon.SelectedIndex!=-1) sql+=" and b.manguon="+int.Parse(manguon.SelectedValue.ToString());
			if (nhomcc.SelectedIndex!=-1) sql+=" and b.nhomcc="+int.Parse(nhomcc.SelectedValue.ToString());
			sql+=" group by a.ngay,b.mabd,c.ten";
            foreach (DataRow r in ttb.get_data(sql).Tables[0].Rows)//d_mmyy
			{
				r1=ttb.getrowbyid(ds.Tables[0],"mabd="+int.Parse(r["mabd"].ToString()));
				if ( r1 == null )
				{
					r3=ttb.getrowbyid(dt,"id="+int.Parse(r["mabd"].ToString()));
					if (r3!=null)
					{
						r2 = ds.Tables[0].NewRow();
						r2["mabd"]=r["mabd"].ToString();
						r2["stt"]=ttb.get_stt(ds.Tables[0]);
						r2["ma"]=r3["ma"].ToString();
						r2["ten"]=r3["ten"].ToString().Trim()+" "+r3["hamluong"].ToString();
						r2["dang"]=r3["dang"].ToString();
						foreach(DataRow r4 in dsngay.Tables[0].Rows) r2["sl_"+r4["ngay"].ToString().Trim()]=0;
						r2["sl_"+r["ngay"].ToString().Trim()]=-decimal.Parse(r["soluong"].ToString());
						r2["tongcong"]=-decimal.Parse(r["soluong"].ToString());
						ds.Tables[0].Rows.Add(r2);
					}
				}
				else
				{
					dr = ds.Tables[0].Select("mabd="+int.Parse(r["mabd"].ToString()));
					dr[0]["sl_"+r["ngay"].ToString().Trim()]=decimal.Parse(dr[0]["sl_"+r["ngay"].ToString().Trim()].ToString())-decimal.Parse(r["soluong"].ToString());
					dr[0]["tongcong"]=decimal.Parse(dr[0]["tongcong"].ToString())-decimal.Parse(r["soluong"].ToString());
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


		private void rptBcngay_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (bClear)
			{
				manguon.SelectedIndex=-1;
				nhomcc.SelectedIndex=-1;
				bClear=false;
			}
		}

		private void exp_excel(bool print)
		{
			try
			{
				int be=3,dong=5,sodong=ds.Tables[0].Rows.Count+5,socot=ds.Tables[0].Columns.Count-2,dongke=sodong-1;
				tenfile=ttb.Export_Excel(ds,"bcngay");
				oxl=new Excel.Application();
				owb=(Excel._Workbook)(oxl.Workbooks.Open(tenfile,Missing.Value,Missing.Value,Missing.Value,Missing.Value,Missing.Value,Missing.Value,Missing.Value,Missing.Value,Missing.Value,Missing.Value,Missing.Value,Missing.Value));
				osheet=(Excel._Worksheet)owb.ActiveSheet;
				oxl.ActiveWindow.DisplayGridlines=true;
				osheet.get_Range(ttb.getIndex(0)+"1",ttb.getIndex(0)+"1").EntireColumn.Delete(Missing.Value);
				for(int i=0;i<be;i++) osheet.get_Range(ttb.getIndex(i)+"1",ttb.getIndex(i)+"1").EntireRow.Insert(Missing.Value);
				osheet.get_Range(ttb.getIndex(be)+dong.ToString(),ttb.getIndex(socot+1)+sodong.ToString()).NumberFormat="#,##0.00";
				osheet.get_Range(ttb.getIndex(0)+"4",ttb.getIndex(socot)+dongke.ToString()).Borders.LineStyle=XlBorderWeight.xlHairline;
				for(int i=1;i<dong;i++) osheet.Cells[dong-1,i]=get_ten(i-1);
				orange=osheet.get_Range(ttb.getIndex(0)+"1",ttb.getIndex(socot)+sodong.ToString());
				osheet.Cells[dong-1,dsngay.Tables[0].Rows.Count+5]="Cộng";
				for(int i=0;i<dsngay.Tables[0].Rows.Count;i++)
					osheet.Cells[dong-1,i+5]=" "+dsngay.Tables[0].Rows[i]["ten"].ToString();
				osheet.get_Range(ttb.getIndex(4)+"4",ttb.getIndex(dsngay.Tables[0].Rows.Count+5)+"4").Orientation=90;
				osheet.get_Range(ttb.getIndex(0)+"4",ttb.getIndex(dsngay.Tables[0].Rows.Count+5)+"4").RowHeight=30;
				orange.Font.Name="Arial";
				orange.Font.Size=8;
				orange.EntireColumn.AutoFit();
				oxl.ActiveWindow.DisplayZeros=false;
				osheet.PageSetup.Orientation=XlPageOrientation.xlLandscape;
				osheet.PageSetup.PaperSize=XlPaperSize.xlPaperA4;
				osheet.PageSetup.LeftMargin=20;
				osheet.PageSetup.RightMargin=20;
				osheet.PageSetup.TopMargin=30;
				osheet.PageSetup.CenterFooter="Trang : &P/&N";
				osheet.Cells[1,2]=ttb.Syte;osheet.Cells[2,2]=ttb.Tenbv;
				osheet.Cells[1,4]="BÁO CÁO SỬ DỤNG";
				osheet.Cells[2,4]=(tu.Text==den.Text)?"Ngày : "+tu.Text:"Từ ngày : "+tu.Text+" đến : "+den.Text;
				orange=osheet.get_Range(ttb.getIndex(3)+"1",ttb.getIndex(socot-1)+"2");
				orange.HorizontalAlignment=XlHAlign.xlHAlignCenterAcrossSelection;
				orange.Font.Size=12;
				orange.Font.Bold=true;
				if (print) osheet.PrintOut(Missing.Value,Missing.Value,Missing.Value,Missing.Value,Missing.Value,Missing.Value,Missing.Value,Missing.Value);
				else oxl.Visible=true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private string get_ten(int i)
		{
			string []map={"TT","Mã số","Tên","ĐVT"};
			return map[i];
		}

		private void butXem_Click(object sender, System.EventArgs e)
		{
			if (!kiemtra()) return;
			exp_excel(false);
		}

		private void butIn_Click(object sender, System.EventArgs e)
		{
			if (!kiemtra()) return;
			exp_excel(true);
		}

		private bool kiemtra()
		{
			s_kho="";
			if (kho.CheckedItems.Count==0) for(int i=0;i<kho.Items.Count;i++) kho.SetItemCheckState(i,CheckState.Checked);
			for(int i=0;i<kho.Items.Count;i++) if (kho.GetItemChecked(i)) s_kho+=dtdmkho.Rows[i]["id"].ToString()+",";
			sql="select * from ttb_dmkho where nhom="+i_nhom;
			if (s_kho!="") sql+=" and id in ("+s_kho.Substring(0,s_kho.Length-1)+")";
			if (s_makho!="") sql+=" and id in ("+s_makho.Substring(0,s_makho.Length-1)+")";
			sql+=" order by stt";
			dtkho=ttb.get_data(sql).Tables[0];
			Tao_dataset();
			//
			//
			DateTime dt1=ttb.StringToDate(tu.Text).AddDays(-ttb.iNgaykiemke);
			DateTime dt2=ttb.StringToDate(den.Text).AddDays(ttb.iNgaykiemke);
			int y1=dt1.Year,m1=dt1.Month;
			int y2=dt2.Year,m2=dt2.Month;
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
			if (ds.Tables[0].Rows.Count==0)
			{
				MessageBox.Show("Không có số liệu !",ttb.Msg);
				return false;
			}
			return true;
		}

	}
}
