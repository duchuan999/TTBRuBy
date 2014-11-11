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
	public class frmThuhoi : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ComboBox phieu;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox makp;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button butOk;
		private System.Windows.Forms.Button butCancel;
		private DataTable dtphieu=new DataTable();
		private DataTable dtkp=new DataTable();
		private DataTable dtll=new DataTable();
		private DataTable dtct=new DataTable();
		private string xxx,user,s_ngay,s_mmyy,sql,s_makho,s_noidung;
		private int i_nhom,i_loai,i_makp,i_phieu,i_thuoc,i_userid;
		public bool bOk=false;
		private bool bBuhaophi,bThua,bKiemtra;
        private LibTTB.AccessData ttb;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmThuhoi(AccessData acc,DataTable dtl,DataTable dtc,DataTable kp,DataTable phieu,int imakp,int iphieu,string ngay,string mmyy,int nhom,int loai,bool buhaophi,bool thua,int thuoc,string makho,int userid)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			ttb=acc;
			dtphieu=phieu;dtkp=kp;dtll=dtl;dtct=dtc;
            i_makp = imakp; i_phieu = iphieu; bBuhaophi = buhaophi; bThua = thua; i_userid = userid;
			s_ngay=ngay;s_mmyy=mmyy;i_nhom=nhom;i_loai=loai;i_thuoc=thuoc;s_makho=makho;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThuhoi));
            this.phieu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.makp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butOk = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // phieu
            // 
            this.phieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.phieu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phieu.Location = new System.Drawing.Point(48, 34);
            this.phieu.Name = "phieu";
            this.phieu.Size = new System.Drawing.Size(128, 21);
            this.phieu.TabIndex = 3;
            this.phieu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phieu_KeyDown);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phiếu :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // makp
            // 
            this.makp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.makp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makp.Location = new System.Drawing.Point(48, 10);
            this.makp.Name = "makp";
            this.makp.Size = new System.Drawing.Size(128, 21);
            this.makp.TabIndex = 1;
            this.makp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.makp_KeyDown);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khoa :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // butOk
            // 
            this.butOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butOk.Location = new System.Drawing.Point(32, 72);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(60, 25);
            this.butOk.TabIndex = 4;
            this.butOk.Text = "Đồng ý";
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // butCancel
            // 
            this.butCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butCancel.Location = new System.Drawing.Point(94, 72);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(60, 25);
            this.butCancel.TabIndex = 5;
            this.butCancel.Text = "&Kết thúc";
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // frmThuhoi
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(186, 119);
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
            this.Name = "frmThuhoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thu hồi";
            this.Load += new System.EventHandler(this.frmThuhoi_Load);
            this.ResumeLayout(false);

		}
		#endregion

		private void frmThuhoi_Load(object sender, System.EventArgs e)
		{
            user = ttb.user; xxx = user;// +s_mmyy;
			if (bBuhaophi) s_noidung="PHIEU HAO PHI";
			else
			{
				switch (i_loai)
				{
					case 1: s_noidung="PHIEU LINH";
						break;
					case 2: s_noidung="PHIEU TU TRUC";
						break;
					case 3: s_noidung="PHIEU HOAN TRA";
						break;
					default: s_noidung="PHIEU HAO PHI";
						break;
				}
			}
			bKiemtra=ttb.bKiemtra_phat_thuhoi(i_nhom);
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

		private void butOk_Click(object sender, System.EventArgs e)
		{
			bOk=true;
			bool bChieu_sang=ttb.bChieu_sang;
			if (bChieu_sang)
			{
				DataRow r1,r2;
				r2=ttb.getrowbyid(dtphieu,"id="+int.Parse(phieu.SelectedValue.ToString()));
				if (r2!=null)
				{
					if (r2["buoi"].ToString()=="0")
					{
						r1=ttb.getrowbyid(dtkp,"id="+int.Parse(makp.SelectedValue.ToString()));
						if (r1!=null)
						{
							if (ttb.get_ttngay(s_ngay,r1["makp"].ToString()))
							{
								MessageBox.Show("Ngày "+s_ngay+" viện phí đã in danh sách thu tiền\nYêu cầu chọn phiếu buổi chiều !",ttb.Msg);
								return;
							}
						}
					}
				}
			}
			if (makp.SelectedIndex==-1 || phieu.SelectedIndex==-1)
			{
				if (makp.SelectedIndex==-1) makp.Focus();
				else phieu.Focus();
				return;
			}
			i_makp=int.Parse(makp.SelectedValue.ToString());
			i_phieu=int.Parse(phieu.SelectedValue.ToString());
			string tenfile=(i_loai==2 || bBuhaophi)?"ttb_bucstt":"ttb_xuatsdct";
			sql="select distinct a.mabn,a.maql from "+xxx+".ttb_xuatsdll a,"+xxx+"."+tenfile+" b where a.id=b.id and to_char(a.ngay,'dd/mm/yyyy')='"+s_ngay+"'";
			sql+=" and a.nhom="+i_nhom+" and a.loai="+i_loai+" and a.phieu="+i_phieu+" and a.makhoa="+i_makp;
			sql+=" and a.thuoc="+i_thuoc;
			if (bBuhaophi || i_loai==4 || bThua || i_thuoc==2) sql+=" and a.maql=0";
			else sql+=" and a.maql<>0";
			DataTable tmp=ttb.get_data(sql).Tables[0];
			if (tmp.Rows.Count==0)
			{
				MessageBox.Show("Không có số liệu !",ttb.Msg);
				makp.Focus();
				return;
			}
			if (bKiemtra)
			{
				if (i_loai==1 || (i_loai==3 && i_thuoc==1 && !bThua))
				{
					bool bFound=false;
					DataRow r2;
					DataTable dthoten=new DataTable();
					string s_ravien="";
					r2=ttb.getrowbyid(dtkp,"id="+int.Parse(makp.SelectedValue.ToString()));
					if (r2!=null)
					{
						sql="select maql from "+user+".xuatvien where makp='"+r2["makp"].ToString()+"'";
						dthoten=ttb.get_data(sql).Tables[0];
						bFound=true;
					}
					if (bFound)
					{
						foreach(DataRow r in tmp.Rows)
						{	
							r2=ttb.getrowbyid(dthoten,"maql="+decimal.Parse(r["maql"].ToString()));
							if (r2!=null)
								s_ravien+=r["mabn"].ToString()+"\n";
						}
					}
					if (s_ravien!="")
					{
						MessageBox.Show("Người bệnh đã ra viện\n"+s_ravien+"không được thu hồi !",ttb.Msg);
						return;
					}
				}
			}
			Cursor=Cursors.WaitCursor;
			if (i_loai==2 && ttb.bBucstt_tronso(i_nhom))
			{
				sql="select idduyet from "+xxx+".ttb_ngayduyet where nhom="+i_nhom+" and loai="+i_loai+" and phieu="+i_phieu+" and makp="+i_makp+" and to_char(ngay,'dd/mm/yyyy')='"+s_ngay+"'";
				if (s_makho!="") sql+=" and makho='"+s_makho+"'";
				foreach(DataRow r in ttb.get_data(sql).Tables[0].Rows)
				{
					sql="select b.* from "+xxx+".ttb_xtutrucll a,"+user+".ttb_treoduyet b where a.id=b.id and a.idduyet="+decimal.Parse(r["idduyet"].ToString());
					foreach(DataRow r1 in ttb.get_data(sql).Tables[0].Rows)
						if (ttb.get_data("select a.* from "+xxx+".ttb_xuatsdll a,"+xxx+".ttb_bucstt b where a.id=b.id and a.idduyet="+decimal.Parse(r1["id"].ToString())+" and b.sttduyet="+int.Parse(r1["stt"].ToString())).Tables[0].Rows.Count==0)
							ttb.execute_data("update "+user+".ttb_treoduyet set slthuc=0 where id="+decimal.Parse(r1["id"].ToString())+" and stt="+int.Parse(r1["stt"].ToString()));
				}
			}
			ttb.upd_duyet(s_mmyy,i_makp,i_nhom,i_loai,i_phieu,s_ngay,s_makho);
			ttb.upd_theodoiduyet(s_mmyy,s_ngay,i_nhom,i_loai,i_makp,1);
			sql="select distinct a.id from "+xxx+".ttb_xuatsdll a,"+xxx+"."+tenfile+" b where a.id=b.id and to_char(a.ngay,'dd/mm/yyyy')='"+s_ngay+"'";
			sql+=" and a.nhom="+i_nhom+" and a.loai="+i_loai+" and a.phieu="+i_phieu+" and a.makhoa="+i_makp;
			sql+=" and a.thuoc="+i_thuoc;
			if (bBuhaophi || i_loai==4 || bThua || i_thuoc==2) sql+=" and a.maql=0";
			else sql+=" and a.maql<>0";
            foreach (DataRow r in ttb.get_data(sql).Tables[0].Rows)               
                ttb.del(s_mmyy, tenfile, decimal.Parse(r["id"].ToString()), dtll, i_loai, bBuhaophi, i_nhom, i_phieu, s_ngay,i_userid,false,s_ngay);
			dtct.Clear();
			sql="select * from "+user+".ttb_dmkho where nhom="+i_nhom;
			if (s_makho!="") sql+=" and id in ("+s_makho.Substring(0,s_makho.Length-1)+")";
			foreach(DataRow r in ttb.get_data(sql).Tables[0].Rows)
				ttb.execute_data("delete from "+xxx+".ttb_daduyet where nhom="+i_nhom+" and to_char(ngay,'dd/mm/yyyy')='"+s_ngay+"' and makp="+i_makp+" and loai="+i_loai+" and phieu="+i_phieu+" and makho="+int.Parse(r["id"].ToString()));
			ttb.upd_tonkho(s_mmyy,i_nhom,0);
			Cursor=Cursors.Default;
			if (ttb.bTinnhan(i_nhom))
			{
				DataRow r=ttb.getrowbyid(dtkp,"id="+int.Parse(makp.SelectedValue.ToString()));
				if (r!=null)
				{
					if (r["computer"].ToString()!="")
						ttb.netsend(ttb.sDomain(i_nhom),r["computer"].ToString().Trim(),s_noidung+" KHOA "+ttb.khongdau(makp.Text)+" PHIEU "+ttb.khongdau(phieu.Text)+" DA THU HOI !");
				}
			}
			//
			MessageBox.Show("Đã thu hồi xong.","Thu hồi",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			this.Close();
		}

		private void butCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
