using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Data;
using LibTTB;

namespace TTB
{
	/// <summary>
	/// Summary description for rptBcngay.
	/// </summary>
	public class frmThkhoa : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button butIn;
		private System.Windows.Forms.Button butKetthuc;
        private LibTTB.AccessData ttb;
		private int i_nhom,i_dongiale;
		private string sql,s_kho,s_makho,s_makp,user,stime,xxx;
		private DataRow r1,r2,r3;
		private DataRow[] dr;
		private bool bChitiet;
		private DataSet ds=new DataSet();
		private DataSet dsxml=new DataSet();
		private DataTable dt=new DataTable();
		private DataTable dtdmkho=new DataTable();
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckedListBox kho;
		private System.Windows.Forms.DateTimePicker tu;
		private System.Windows.Forms.DateTimePicker den;
		private System.Windows.Forms.ComboBox makp;
		private System.Windows.Forms.CheckBox chkChitiet;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmThkhoa(AccessData acc,int nhom,string kho,string kp)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			ttb=acc;i_nhom=nhom;
			s_makho=kho;s_makp=kp;
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
		//s_mmyy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThkhoa));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butIn = new System.Windows.Forms.Button();
            this.butKetthuc = new System.Windows.Forms.Button();
            this.makp = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kho = new System.Windows.Forms.CheckedListBox();
            this.tu = new System.Windows.Forms.DateTimePicker();
            this.den = new System.Windows.Forms.DateTimePicker();
            this.chkChitiet = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(136, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "đến :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // butIn
            // 
            this.butIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butIn.Location = new System.Drawing.Point(72, 186);
            this.butIn.Name = "butIn";
            this.butIn.Size = new System.Drawing.Size(60, 25);
            this.butIn.TabIndex = 4;
            this.butIn.Text = "&In";
            this.butIn.Click += new System.EventHandler(this.butIn_Click);
            // 
            // butKetthuc
            // 
            this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butKetthuc.Location = new System.Drawing.Point(134, 186);
            this.butKetthuc.Name = "butKetthuc";
            this.butKetthuc.Size = new System.Drawing.Size(60, 25);
            this.butKetthuc.TabIndex = 5;
            this.butKetthuc.Text = "&Kết thúc";
            this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
            // 
            // makp
            // 
            this.makp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.makp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makp.Location = new System.Drawing.Point(59, 30);
            this.makp.Name = "makp";
            this.makp.Size = new System.Drawing.Size(192, 21);
            this.makp.TabIndex = 2;
            this.makp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Khoa :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // kho
            // 
            this.kho.CheckOnClick = true;
            this.kho.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kho.Location = new System.Drawing.Point(59, 53);
            this.kho.Name = "kho";
            this.kho.Size = new System.Drawing.Size(192, 100);
            this.kho.TabIndex = 3;
            this.kho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // tu
            // 
            this.tu.CustomFormat = "dd/MM/yyyy";
            this.tu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tu.Location = new System.Drawing.Point(59, 6);
            this.tu.Name = "tu";
            this.tu.Size = new System.Drawing.Size(80, 21);
            this.tu.TabIndex = 0;
            this.tu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // den
            // 
            this.den.CustomFormat = "dd/MM/yyyy";
            this.den.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.den.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.den.Location = new System.Drawing.Point(171, 6);
            this.den.Name = "den";
            this.den.Size = new System.Drawing.Size(80, 21);
            this.den.TabIndex = 1;
            this.den.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // chkChitiet
            // 
            this.chkChitiet.Location = new System.Drawing.Point(61, 157);
            this.chkChitiet.Name = "chkChitiet";
            this.chkChitiet.Size = new System.Drawing.Size(155, 24);
            this.chkChitiet.TabIndex = 9;
            this.chkChitiet.Text = "Số lượng && đơn giá";
            // 
            // frmThkhoa
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(266, 223);
            this.Controls.Add(this.chkChitiet);
            this.Controls.Add(this.den);
            this.Controls.Add(this.tu);
            this.Controls.Add(this.kho);
            this.Controls.Add(this.makp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butKetthuc);
            this.Controls.Add(this.butIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThkhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tổng hợp phiếu xuất theo khoa";
            this.Load += new System.EventHandler(this.frmThkhoa_Load);
            this.ResumeLayout(false);

		}
		#endregion

		private void frmThkhoa_Load(object sender, System.EventArgs e)
		{
            user = ttb.user; stime = "'" + ttb.f_ngay + "'";
			i_dongiale=ttb.d_dongia_le(i_nhom);
			sql="select * from "+user+".d_duockp ";
			sql+=" where nhom like '%"+i_nhom.ToString()+",%'";
			if (s_makp!="")  sql+=" and id in ("+s_makp.Substring(0,s_makp.Length-1)+")";
			sql+=" order by stt";
			makp.DisplayMember="TEN";
			makp.ValueMember="ID";
			makp.DataSource=ttb.get_data(sql).Tables[0];
			sql="select a.*,b.stt as sttnhom,b.ten as tennhom,c.ten as tenhang ";
			sql+=" from "+user+".ttb_dmbd a,"+user+".ttb_dmnhom b,"+user+".ttb_dmhang c where a.manhom=b.id and a.mahang=c.id and a.nhom="+i_nhom;
			dt=ttb.get_data(sql).Tables[0];
			sql="select * from "+user+".ttb_dmkho where nhom="+i_nhom;
			if (s_makho!="") sql+=" and id in ("+s_makho.Substring(0,s_makho.Length-1)+")";
			sql+=" order by stt";
			dtdmkho=ttb.get_data(sql).Tables[0];
            kho.DataSource = dtdmkho;
			kho.DisplayMember="TEN";
			kho.ValueMember="ID";
			
			ds.ReadXml("..\\..\\..\\xml\\ttb_thkhoa.xml");
			dsxml.ReadXml("..\\..\\..\\xml\\ttb_thkhoa.xml");
		}

		private void get_xuat(string s_mmyy)
		{
            xxx = user;// +s_mmyy;
			sql="select b.mabd,";
			if (bChitiet) sql+="round(t.giamua,"+i_dongiale+") as dongia,";
			else sql+="0 as dongia,";
			sql+="sum(b.soluong) as soluong from "+xxx+".ttb_xuatsdll a,"+xxx+".ttb_thucxuat b,"+xxx+".ttb_theodoi t,"+user+".ttb_dmbd c";
            sql += " where a.id=b.id and b.sttt=t.id and b.mabd=c.id and a.loai in(1,4) and a.nhom=" + i_nhom;
            sql+=" and a.ngay between to_date('" + tu.Text + "',"+stime+") and to_date('" + den.Text + "',"+stime+")";
			sql+=" and a.makp="+int.Parse(makp.SelectedValue.ToString());
			if (s_kho!="") sql+=" and b.makho in ("+s_kho.Substring(0,s_kho.Length-1)+")";
			sql+=" and a.mmyy='"+s_mmyy+"' group by b.mabd";
			if (bChitiet) sql+=",round(t.giamua,"+i_dongiale+")";
			ins_items();
			//bu tu truc
			sql="select b.mabd,";
			if (bChitiet) sql+="round(t.giamua,"+i_dongiale+") as dongia,";
			else sql+="0 as dongia,";
			sql+="sum(b.soluong) as soluong from "+xxx+".ttb_xuatsdll a,"+xxx+".ttb_thucbucstt b,"+user+".ttb_dmbd c,"+xxx+".ttb_theodoi t ";
            sql += " where a.id=b.id and b.sttt=t.id and b.mabd=c.id and a.loai in (2) and a.nhom=" + i_nhom;
            sql += " and a.ngay between to_date('" + tu.Text + "'," + stime + ") and to_date('" + den.Text + "'," + stime + ")";
			sql+=" and a.makp="+int.Parse(makp.SelectedValue.ToString());
			if (s_kho!="") sql+=" and b.makho in ("+s_kho.Substring(0,s_kho.Length-1)+")";
            sql += " and a.mmyy='" + s_mmyy + "' group by b.mabd";
			if (bChitiet) sql+=",round(t.giamua,"+i_dongiale+")";
			ins_items();
			//hoantra
			sql="select b.mabd,";
			if (bChitiet) sql+="round(t.giamua,"+i_dongiale+") as dongia,";
			else sql+="0 as dongia,";
			sql+="-sum(b.soluong) as soluong from "+xxx+".ttb_xuatsdll a,"+xxx+".ttb_thucxuat b,"+user+".ttb_dmbd c,"+xxx+".ttb_theodoi t ";
            sql += " where a.id=b.id and b.sttt=t.id and b.mabd=c.id and a.loai in (3) and a.nhom=" + i_nhom;
            sql += " and a.ngay between to_date('" + tu.Text + "'," + stime + ") and to_date('" + den.Text + "'," + stime + ")";
			sql+=" and a.makp="+int.Parse(makp.SelectedValue.ToString());
			if (s_kho!="") sql+=" and b.makho in ("+s_kho.Substring(0,s_kho.Length-1)+")";
            sql += " and a.mmyy='" + s_mmyy + "' group by b.mabd";
			if (bChitiet) sql+=",round(t.giamua,"+i_dongiale+")";
			ins_items();
		}

		private void ins_items()
		{
			foreach(DataRow r in ttb.get_data(sql).Tables[0].Rows)
			{
				r3=ttb.getrowbyid(dt,"id="+int.Parse(r["mabd"].ToString()));
				if (r3!=null)
				{
					sql="mabd="+int.Parse(r["mabd"].ToString())+" and dongia="+decimal.Parse(r["dongia"].ToString());
					r1=ttb.getrowbyid(ds.Tables[0],sql);
					if ( r1 == null )
					{
						r2 = ds.Tables[0].NewRow();
						r2["stt"]=r3["sttnhom"].ToString();
						r2["tennhom"]=r3["tennhom"].ToString();
						r2["mabd"]=r["mabd"].ToString();
						r2["ma"]=r3["ma"].ToString();
						r2["ten"]=r3["ten"].ToString().Trim()+" "+r3["hamluong"].ToString();
						r2["dang"]=r3["dang"].ToString();
						r2["tenhang"]=r3["tenhang"].ToString();
						r2["soluong"]=r["soluong"].ToString();
						r2["dongia"]=r["dongia"].ToString();
						r2["sotien"]=decimal.Parse(r["soluong"].ToString())*decimal.Parse(r["dongia"].ToString());
						ds.Tables[0].Rows.Add(r2);
					}
					else
					{
						dr = ds.Tables[0].Select(sql);
						dr[0]["soluong"]=decimal.Parse(dr[0]["soluong"].ToString())+decimal.Parse(r["soluong"].ToString());
						dr[0]["sotien"]=decimal.Parse(dr[0]["sotien"].ToString())+decimal.Parse(r["soluong"].ToString())*decimal.Parse(r["dongia"].ToString());
					}
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


		private void butIn_Click(object sender, System.EventArgs e)
		{
			bChitiet=chkChitiet.Checked;
			if (!kiemtra()) return;
			dsxml.Clear();
			dsxml.Merge(ds.Tables[0].Select("true","stt,ma"));
			string title=(tu.Text==den.Text)?"Ngày "+tu.Text:"Từ ngày "+tu.Text+" đến "+den.Text;
			frmReport f1=new frmReport(ttb,dsxml.Tables[0],(bChitiet)?"d_thkhoa_ct.rpt":"d_thkhoa.rpt","KHOA :"+makp.Text.Trim(),title,"","","","","","","","");
			f1.ShowDialog(this);
		}

		private bool kiemtra()
		{
			s_kho="";
			if (kho.CheckedItems.Count==0) for(int i=0;i<kho.Items.Count;i++) kho.SetItemCheckState(i,CheckState.Checked);
			for(int i=0;i<kho.Items.Count;i++) if (kho.GetItemChecked(i)) s_kho+=dtdmkho.Rows[i]["id"].ToString()+",";
			DateTime dt1=ttb.StringToDate(tu.Text).AddDays(-ttb.iNgaykiemke);
			DateTime dt2=ttb.StringToDate(den.Text).AddDays(ttb.iNgaykiemke);
			int y1=dt1.Year,m1=dt1.Month;
			int y2=dt2.Year,m2=dt2.Month;
			int itu,iden;
			string mmyy="";		
			ds.Clear();
			for(int i=y1;i<=y2;i++)
			{
				itu=(i==y1)?m1:1;
				iden=(i==y2)?m2:12;
				for(int j=itu;j<=iden;j++)
				{
					mmyy=j.ToString().PadLeft(2,'0')+i.ToString().Substring(2,2);
					if (ttb.bMmyy(mmyy)) get_xuat(mmyy);
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
