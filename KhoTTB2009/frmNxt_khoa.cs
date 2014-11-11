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
	public class frmNxt_khoa : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button butKetthuc;
        private LibTTB.AccessData ttb;
		private int i_nhom;
		private string sql,mmyy,s_makho,s_manhom,user,xxx,stime;
		private DataTable dt=new DataTable();
		private DataSet ds=new DataSet();
		private DataSet dsxml=new DataSet();
		private DataSet dssort=new DataSet();
		private DataTable dtkho=new DataTable();
		private DataTable dtnhom=new DataTable();
		private DataRow [] dr;
		private DataRow r1,r2,r3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button butXem;
		private System.Windows.Forms.DateTimePicker tu;
		private System.Windows.Forms.DateTimePicker den;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox sort;
		private System.Windows.Forms.ComboBox makp;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckedListBox kho;
		private System.Windows.Forms.CheckedListBox manhom;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmNxt_khoa(AccessData acc,int nhom,string s_mmyy,string makho)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			ttb=acc;
			i_nhom=nhom;mmyy=s_mmyy;s_makho=makho;
			this.Text+=" tháng "+s_mmyy.Substring(0,2)+" năm 20"+s_mmyy.Substring(2);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNxt_khoa));
            this.label1 = new System.Windows.Forms.Label();
            this.butKetthuc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.butXem = new System.Windows.Forms.Button();
            this.tu = new System.Windows.Forms.DateTimePicker();
            this.den = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.makp = new System.Windows.Forms.ComboBox();
            this.sort = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.kho = new System.Windows.Forms.CheckedListBox();
            this.manhom = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // butKetthuc
            // 
            this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butKetthuc.Location = new System.Drawing.Point(145, 173);
            this.butKetthuc.Name = "butKetthuc";
            this.butKetthuc.Size = new System.Drawing.Size(60, 25);
            this.butKetthuc.TabIndex = 11;
            this.butKetthuc.Text = "&Kết thúc";
            this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(126, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "đến :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // butXem
            // 
            this.butXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butXem.Location = new System.Drawing.Point(83, 173);
            this.butXem.Name = "butXem";
            this.butXem.Size = new System.Drawing.Size(60, 25);
            this.butXem.TabIndex = 10;
            this.butXem.Text = "&In";
            this.butXem.Click += new System.EventHandler(this.butXem_Click);
            // 
            // tu
            // 
            this.tu.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tu.CustomFormat = "dd/MM/yyyy";
            this.tu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tu.Location = new System.Drawing.Point(56, 10);
            this.tu.Name = "tu";
            this.tu.Size = new System.Drawing.Size(80, 21);
            this.tu.TabIndex = 1;
            this.tu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // den
            // 
            this.den.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.den.CustomFormat = "dd/MM/yyyy";
            this.den.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.den.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.den.Location = new System.Drawing.Point(168, 10);
            this.den.Name = "den";
            this.den.Size = new System.Drawing.Size(80, 21);
            this.den.TabIndex = 3;
            this.den.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Khoa :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(1, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Thứ tự :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // makp
            // 
            this.makp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.makp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makp.Location = new System.Drawing.Point(56, 33);
            this.makp.Name = "makp";
            this.makp.Size = new System.Drawing.Size(192, 21);
            this.makp.TabIndex = 5;
            this.makp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // sort
            // 
            this.sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sort.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sort.Location = new System.Drawing.Point(56, 143);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(192, 21);
            this.sort.TabIndex = 9;
            this.sort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 56);
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
            this.kho.Location = new System.Drawing.Point(56, 56);
            this.kho.Name = "kho";
            this.kho.Size = new System.Drawing.Size(192, 84);
            this.kho.TabIndex = 7;
            this.kho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // manhom
            // 
            this.manhom.CheckOnClick = true;
            this.manhom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manhom.Location = new System.Drawing.Point(256, 8);
            this.manhom.Name = "manhom";
            this.manhom.Size = new System.Drawing.Size(192, 196);
            this.manhom.TabIndex = 12;
            this.manhom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // frmNxt_khoa
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(458, 215);
            this.Controls.Add(this.manhom);
            this.Controls.Add(this.kho);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.makp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.den);
            this.Controls.Add(this.tu);
            this.Controls.Add(this.butXem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butKetthuc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNxt_khoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo nhập xuất tồn";
            this.Load += new System.EventHandler(this.frmNxt_khoa_Load);
            this.ResumeLayout(false);

		}
		#endregion

		private void frmNxt_khoa_Load(object sender, System.EventArgs e)
		{
            user = ttb.user; stime = "'" + ttb.f_ngay + "'";
            dt = ttb.get_data("select a.*,b.ten as tenhang,c.stt as sttnhom,c.ten as tennhom from " + user + ".ttb_dmbd a," + user + ".ttb_dmhang b," + user + ".ttb_dmnhom c where a.mahang=b.id and a.manhom=c.id and a.nhom=" + i_nhom).Tables[0];
			dssort.ReadXml("..\\..\\..\\xml\\ttb_sortnxt.xml");
			ds.ReadXml("..\\..\\..\\xml\\ttb_nxtnhathuoc.xml");
			dsxml.ReadXml("..\\..\\..\\xml\\ttb_nxtnhathuoc.xml");
            sql = "select * from " + user + ".ttb_dmkho where nhom=" + i_nhom;
			if (s_makho!="") sql+=" and id in ("+s_makho.Substring(0,s_makho.Length-1)+")";
			sql+=" order by stt";
			dtkho=ttb.get_data(sql).Tables[0];
            kho.DataSource = dtkho;
			kho.DisplayMember="TEN";
			kho.ValueMember="ID";
			

			makp.DisplayMember="TEN";
			makp.ValueMember="ID";
            makp.DataSource = ttb.get_data("select * from " + user + ".d_duockp where nhom like '%" + i_nhom.ToString().Trim() + ",%' order by stt").Tables[0];

            dtnhom = ttb.get_data("select * from " + user + ".ttb_dmnhom where nhom=" + i_nhom + " order by stt").Tables[0];
            manhom.DataSource = dtnhom;
			manhom.DisplayMember="TEN";
			manhom.ValueMember="ID";

			sort.DisplayMember="TEN";
			sort.ValueMember="FIELD";
			sort.DataSource=dssort.Tables[0];
		}

		private void butKetthuc_Click(object sender, System.EventArgs e)
		{
			this.Close();		
		}

		private void tu_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");
		}

		private void items_tondau()
		{
			foreach(DataRow r in get_tondau().Tables[0].Rows)
			{
				r1=ttb.getrowbyid(ds.Tables[0],"mabd="+int.Parse(r["mabd"].ToString()));
				if (r1==null)
				{
					r2=ttb.getrowbyid(dt,"id="+int.Parse(r["mabd"].ToString()));
					if (r2!=null)
					{
						r3=ds.Tables[0].NewRow();
						r3["manhom"]=r2["sttnhom"].ToString();
						r3["tennhom"]=r2["tennhom"].ToString();
						r3["mabd"]=r["mabd"].ToString();
						r3["ma"]=r2["ma"].ToString();
						r3["ten"]=r2["ten"].ToString().Trim()+" "+r2["hamluong"].ToString();
						r3["tenhc"]=r2["tenhc"].ToString();
						r3["dang"]=r2["dang"].ToString();
						r3["tenhang"]=r2["tenhang"].ToString();
						r3["tondau"]=r["soluong"].ToString();
						r3["slnhap"]=0;
						r3["slxuat"]=0;
						ds.Tables[0].Rows.Add(r3);
					}
				}
				else 
				{
					dr=ds.Tables[0].Select("mabd="+int.Parse(r["mabd"].ToString()));
					if (dr.Length>0) dr[0]["tondau"]=decimal.Parse(dr[0]["tondau"].ToString())+decimal.Parse(r["soluong"].ToString());
				}
			}
			//nhap
			foreach(DataRow r in get_nhap(" and a.ngay>to_date('"+tu.Text+"',"+stime+")"," and a.ngay<to_date('"+den.Text+"',"+stime+")").Tables[0].Rows)
			{
				r1=ttb.getrowbyid(ds.Tables[0],"mabd="+int.Parse(r["mabd"].ToString()));
				if (r1==null)
				{
					r2=ttb.getrowbyid(dt,"id="+int.Parse(r["mabd"].ToString()));
					if (r2!=null)
					{
						r3=ds.Tables[0].NewRow();
						r3["manhom"]=r2["sttnhom"].ToString();
						r3["tennhom"]=r2["tennhom"].ToString();
						r3["mabd"]=r["mabd"].ToString();
						r3["ma"]=r2["ma"].ToString();
						r3["ten"]=r2["ten"].ToString().Trim()+" "+r2["hamluong"].ToString();
						r3["tenhc"]=r2["tenhc"].ToString();
						r3["dang"]=r2["dang"].ToString();
						r3["tenhang"]=r2["tenhang"].ToString();
						r3["tondau"]=0;
						r3["slnhap"]=r["soluong"].ToString();
						r3["slxuat"]=0;
						ds.Tables[0].Rows.Add(r3);
					}
				}
				else 
				{
					dr=ds.Tables[0].Select("mabd="+int.Parse(r["mabd"].ToString()));
					if (dr.Length>0) dr[0]["tondau"]=decimal.Parse(dr[0]["tondau"].ToString())+decimal.Parse(r["soluong"].ToString());
				}
			}
			//xuat
			foreach(DataRow r in get_xuat(" and a.ngay<to_date('"+tu.Text+"',"+stime+")").Tables[0].Rows)
			{
				r1=ttb.getrowbyid(ds.Tables[0],"mabd="+int.Parse(r["mabd"].ToString()));
				if (r1==null)
				{
					r2=ttb.getrowbyid(dt,"id="+int.Parse(r["mabd"].ToString()));
					if (r2!=null)
					{
						r3=ds.Tables[0].NewRow();
						r3["manhom"]=r2["sttnhom"].ToString();
						r3["tennhom"]=r2["tennhom"].ToString();
						r3["mabd"]=r["mabd"].ToString();
						r3["ma"]=r2["ma"].ToString();
						r3["ten"]=r2["ten"].ToString().Trim()+" "+r2["hamluong"].ToString();
						r3["tenhc"]=r2["tenhc"].ToString();
						r3["dang"]=r2["dang"].ToString();
						r3["tenhang"]=r2["tenhang"].ToString();
						r3["tondau"]=0;
						r3["slnhap"]=0;
						r3["slxuat"]=r["soluong"].ToString();
						ds.Tables[0].Rows.Add(r3);
					}
				}
				else 
				{
					dr=ds.Tables[0].Select("mabd="+int.Parse(r["mabd"].ToString()));
					if (dr.Length>0) dr[0]["tondau"]=decimal.Parse(dr[0]["tondau"].ToString())-decimal.Parse(r["soluong"].ToString());
				}
			}
		}

		private DataSet get_tondau()
		{
            xxx = user;// + mmyy;
			sql=" select a.mabd,sum(a.tondau) as soluong from "+xxx+".ttb_tutrucct a,"+user+".ttb_dmbd b ";
			sql+=" where a.mabd=b.id and a.makp="+int.Parse(makp.SelectedValue.ToString());
			if (s_makho!="") sql+=" and a.makho in ("+s_makho.Substring(0,s_makho.Length-1)+")";
			if (s_manhom!="") sql+=" and b.manhom in ("+s_manhom.Substring(0,s_manhom.Length-1)+")";
			sql+=" and a.mmyy='"+mmyy+"' group by a.mabd";
			return ttb.get_data(sql);
		}

		private void items_xuat()
		{
			foreach(DataRow r in get_xuat(" and a.ngay between to_date('"+tu.Text+"',"+stime+") and to_date('"+den.Text+"',"+stime+")").Tables[0].Rows)
			{
				r1=ttb.getrowbyid(ds.Tables[0],"mabd="+int.Parse(r["mabd"].ToString()));
				if (r1==null)
				{
					r2=ttb.getrowbyid(dt,"id="+int.Parse(r["mabd"].ToString()));
					if (r2!=null)
					{
						r3=ds.Tables[0].NewRow();
						r3["manhom"]=r2["sttnhom"].ToString();
						r3["tennhom"]=r2["tennhom"].ToString();
						r3["mabd"]=r["mabd"].ToString();
						r3["ma"]=r2["ma"].ToString();
						r3["ten"]=r2["ten"].ToString().Trim()+" "+r2["hamluong"].ToString();
						r3["tenhc"]=r2["tenhc"].ToString();
						r3["dang"]=r2["dang"].ToString();
						r3["tenhang"]=r2["tenhang"].ToString();
						r3["tondau"]=0;
						r3["slnhap"]=0;
						r3["slxuat"]=r["soluong"].ToString();
						ds.Tables[0].Rows.Add(r3);
					}
				}
				else 
				{
					dr=ds.Tables[0].Select("mabd="+int.Parse(r["mabd"].ToString()));
					if (dr.Length>0) dr[0]["slxuat"]=decimal.Parse(dr[0]["slxuat"].ToString())+decimal.Parse(r["soluong"].ToString());
				}
			}
		}

		private void items_nhap()
		{
			foreach(DataRow r in get_nhap(" and a.ngay between to_date('"+tu.Text+"',"+stime+") and to_date('"+den.Text+"',"+stime+")"," and a.ngay between to_date('"+tu.Text+"',"+stime+") and to_date('"+den.Text+"',"+stime+")").Tables[0].Rows)
			{
				r1=ttb.getrowbyid(ds.Tables[0],"mabd="+int.Parse(r["mabd"].ToString()));
				if (r1==null)
				{
					r2=ttb.getrowbyid(dt,"id="+int.Parse(r["mabd"].ToString()));
					if (r2!=null)
					{
						r3=ds.Tables[0].NewRow();
						r3["manhom"]=r2["sttnhom"].ToString();
						r3["tennhom"]=r2["tennhom"].ToString();
						r3["mabd"]=r["mabd"].ToString();
						r3["ma"]=r2["ma"].ToString();
						r3["ten"]=r2["ten"].ToString().Trim()+" "+r2["hamluong"].ToString();
						r3["tenhc"]=r2["tenhc"].ToString();
						r3["dang"]=r2["dang"].ToString();
						r3["tenhang"]=r2["tenhang"].ToString();
						r3["tondau"]=0;
						r3["slnhap"]=r["soluong"].ToString();
						r3["slxuat"]=0;
						ds.Tables[0].Rows.Add(r3);
					}
				}
				else 
				{
					dr=ds.Tables[0].Select("mabd="+int.Parse(r["mabd"].ToString()));
					if (dr.Length>0) dr[0]["slnhap"]=decimal.Parse(dr[0]["slnhap"].ToString())+decimal.Parse(r["soluong"].ToString());
				}
			}
		}
		private DataSet get_nhap(string cont1,string cont2)
		{
            xxx = user; // +mmyy;
			sql=" select b.mabd,sum(b.soluong) as soluong from "+xxx+".ttb_xuatsdll a,"+xxx+".ttb_thucbucstt b,"+user+".ttb_dmbd c";
			sql+=" where a.id=b.id and b.mabd=c.id  and a.makp="+int.Parse(makp.SelectedValue.ToString());
			if (s_makho!="") sql+=" and b.makho in ("+s_makho.Substring(0,s_makho.Length-1)+")";
			if (s_manhom!="") sql+=" and c.manhom in ("+s_manhom.Substring(0,s_manhom.Length-1)+")";
			sql+=cont1;
            sql += " and a.mmyy= '" + mmyy + "' group by b.mabd";
			sql+=" union all ";
			sql+=" select b.mabd,sum(b.soluong) as soluong from "+xxx+".ttb_xuatll a,"+xxx+".ttb_xuatct b,"+user+".ttb_dmbd c";
			sql+=" where a.id=b.id and b.mabd=c.id and a.loai in ('BS') and a.khon="+int.Parse(makp.SelectedValue.ToString());
			if (s_makho!="") sql+=" and a.khox in ("+s_makho.Substring(0,s_makho.Length-1)+")";
			if (s_manhom!="") sql+=" and c.manhom in ("+s_manhom.Substring(0,s_manhom.Length-1)+")";
			sql+=cont2;
			sql+=" and a.mmyy= '"+mmyy+"' group by b.mabd";
			return ttb.get_data(sql);
		}

		private DataSet get_xuat(string cont)
		{
            xxx = user;// +mmyy;
			sql=" select b.mabd,sum(b.soluong) as soluong from "+xxx+".ttb_xuatsdll a,"+xxx+".ttb_thucxuat b,"+user+".ttb_dmbd c";
			sql+=" where a.id=b.id and b.mabd=c.id and a.loai=2   and a.makp="+int.Parse(makp.SelectedValue.ToString());
			if (s_makho!="") sql+=" and b.makho in ("+s_makho.Substring(0,s_makho.Length-1)+")";
			if (s_manhom!="") sql+=" and c.manhom in ("+s_manhom.Substring(0,s_manhom.Length-1)+")";
			sql+=cont;
            sql += " and a.mmyy= '" + mmyy + "' group by b.mabd";
			sql+=" union all ";
			sql+=" select b.mabd,sum(b.soluong) as soluong from "+xxx+".ttb_xuatll a,"+xxx+".ttb_xuatct b,"+user+".ttb_dmbd c";
			sql+=" where a.id=b.id and b.mabd=c.id and a.loai in ('TH','HT') and a.khox="+int.Parse(makp.SelectedValue.ToString());
			if (s_makho!="") sql+=" and a.khon in ("+s_makho.Substring(0,s_makho.Length-1)+")";
			if (s_manhom!="") sql+=" and c.manhom in ("+s_manhom.Substring(0,s_manhom.Length-1)+")";
			sql+=cont;
            sql += " and a.mmyy= '" + mmyy + "' group by b.mabd";
			return ttb.get_data(sql);
		}

		private void butXem_Click(object sender, System.EventArgs e)
		{			
			print();
		}	

		private void print()
		{
			string s_title="Từ ngày "+tu.Text+" đến ngày "+den.Text;
			if(tu.Text==den.Text)s_title="Ngày "+tu.Text;
			s_makho="";s_manhom="";
			if (kho.SelectedItems.Count>0)
				for(int i=0;i<kho.Items.Count;i++) if (kho.GetItemChecked(i)) s_makho+=dtkho.Rows[i]["id"].ToString()+",";
			if (manhom.SelectedItems.Count>0)
				for(int i=0;i<manhom.Items.Count;i++) if (manhom.GetItemChecked(i)) s_manhom+=dtkho.Rows[i]["id"].ToString()+",";
			ds.Clear();
			items_tondau();
			items_nhap();
			items_xuat();
			if (ds.Tables[0].Rows.Count==0) MessageBox.Show("Không có số liệu !",ttb.Msg);
			else
			{
				dsxml.Clear();
				foreach(DataRow r in ds.Tables[0].Select("true",sort.SelectedValue.ToString()+",ten"))
				{
					r3=dsxml.Tables[0].NewRow();
					r3["manhom"]=r["manhom"].ToString();
					r3["tennhom"]=r["tennhom"].ToString();
					r3["mabd"]=r["mabd"].ToString();
					r3["ma"]=r["ma"].ToString();
					r3["ten"]=r["ten"].ToString();
					r3["tenhc"]=r["tenhc"].ToString();
					r3["dang"]=r["dang"].ToString();
					r3["tenhang"]=r["tenhang"].ToString();
					r3["tondau"]=r["tondau"].ToString();
					r3["slnhap"]=r["slnhap"].ToString();
					r3["slxuat"]=r["slxuat"].ToString();
					dsxml.Tables[0].Rows.Add(r3);
				}
                if (System.IO.Directory.Exists("..\\..\\dataxml") == false) System.IO.Directory.CreateDirectory("..\\..\\dataxml");
                dsxml.WriteXml("..\\..\\dataxml\\ttb_nxt_khoa.xml",XmlWriteMode.WriteSchema);
				frmReport f1=new frmReport(ttb,dsxml.Tables[0],"d_nxt_khoa.rpt",makp.Text,s_title,"","","","","","","","");
				f1.ShowDialog(this);
			}
		}	
	}
}
