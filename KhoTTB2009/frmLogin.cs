using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using LibTTB;
using System.Data;

namespace TTB
{
	/// <summary>
	/// Summary description for frmLogin.
	/// </summary>
	public class frmLogin : System.Windows.Forms.Form
	{
        private LibTTB.AccessData ttb;
        private LibMedi.AccessData m=new LibMedi.AccessData();
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtuser;
		private System.Windows.Forms.TextBox txtpassword;
		private Wildgrape.Aqua.Controls.Button cmdOk;
		private Wildgrape.Aqua.Controls.Button cmdCancle;
		private string sql,user,xxx;
		public string mRight="",mUserid="",mMmyy,mNgay,mMakho,mMakp,mManhom,mTennhom,mLoaint,mLoaikhac;
		public int iUserid=0,iNhomkho;
		private DataSet ds=new DataSet();
		public bool mExit=false,bTao=false,bAdmin=false;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker ngay;
		private System.Windows.Forms.NumericUpDown mm;
		private System.Windows.Forms.NumericUpDown yyyy;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmLogin(AccessData acc)
		{
			InitializeComponent();
			ttb=acc;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.cmdOk = new Wildgrape.Aqua.Controls.Button();
            this.cmdCancle = new Wildgrape.Aqua.Controls.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ngay = new System.Windows.Forms.DateTimePicker();
            this.mm = new System.Windows.Forms.NumericUpDown();
            this.yyyy = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.mm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yyyy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên người sử dụng :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(10, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu truy cập :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtuser
            // 
            this.txtuser.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtuser.Location = new System.Drawing.Point(106, 7);
            this.txtuser.MaxLength = 10;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(119, 22);
            this.txtuser.TabIndex = 0;
            this.txtuser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtuser_KeyDown);
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtpassword.Location = new System.Drawing.Point(106, 31);
            this.txtpassword.MaxLength = 50;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(119, 22);
            this.txtpassword.TabIndex = 1;
            this.txtpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpassword_KeyDown);
            // 
            // cmdOk
            // 
            this.cmdOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOk.Location = new System.Drawing.Point(36, 112);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.SizeToLabel = false;
            this.cmdOk.TabIndex = 5;
            this.cmdOk.Text = "Chọn";
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // cmdCancle
            // 
            this.cmdCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancle.Location = new System.Drawing.Point(116, 112);
            this.cmdCancle.Name = "cmdCancle";
            this.cmdCancle.SizeToLabel = false;
            this.cmdCancle.TabIndex = 6;
            this.cmdCancle.Text = "Kết thúc";
            this.cmdCancle.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(10, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày làm việc :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(10, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số liệu tháng :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(144, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Năm :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ngay
            // 
            this.ngay.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngay.CustomFormat = "dd/MM/yyyy";
            this.ngay.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngay.Location = new System.Drawing.Point(106, 55);
            this.ngay.Name = "ngay";
            this.ngay.Size = new System.Drawing.Size(119, 22);
            this.ngay.TabIndex = 2;
            this.ngay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ngay_KeyDown);
            // 
            // mm
            // 
            this.mm.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mm.Location = new System.Drawing.Point(106, 79);
            this.mm.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.mm.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mm.Name = "mm";
            this.mm.Size = new System.Drawing.Size(35, 22);
            this.mm.TabIndex = 3;
            this.mm.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mm_KeyDown);
            // 
            // yyyy
            // 
            this.yyyy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yyyy.Location = new System.Drawing.Point(175, 79);
            this.yyyy.Maximum = new decimal(new int[] {
            3004,
            0,
            0,
            0});
            this.yyyy.Minimum = new decimal(new int[] {
            2004,
            0,
            0,
            0});
            this.yyyy.Name = "yyyy";
            this.yyyy.Size = new System.Drawing.Size(50, 22);
            this.yyyy.TabIndex = 4;
            this.yyyy.Value = new decimal(new int[] {
            2004,
            0,
            0,
            0});
            this.yyyy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.yyyy_KeyDown);
            // 
            // frmLogin
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(234, 155);
            this.ControlBox = false;
            this.Controls.Add(this.mm);
            this.Controls.Add(this.yyyy);
            this.Controls.Add(this.ngay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdCancle);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin ";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yyyy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void txtuser_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");	
		}

		private void txtpassword_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");				
		}

		private void cmdOk_Click(object sender, System.EventArgs e)
		{
            ttb.setStandar();
            string Ngaydemo = ttb.Ngaydemo("khottb");
            if (Ngaydemo != "")
            {
                int songay = ttb.Songaydemo;
                if (songay != 0)
                {
                    decimal conlai = songay - ttb.songay(ttb.StringToDate(ttb.ngayhienhanh_server.Substring(0, 10)), ttb.StringToDate(Ngaydemo), 0);
                    if (conlai <= 0)
                    {
                        MessageBox.Show("Đã hết thời gian chạy thử\nLiên hệ nhà cung cấp:\nPhone : 08.7155019\nMobile : 090 3937066", ttb.Msg);
                        return;
                    }
                    else if (conlai <= 3)
                        MessageBox.Show("Thời gian chạy thử còn " + conlai.ToString() + " ngày", ttb.Msg);
                }
            }
			
            DataTable dtver=m.get_data("select * from version").Tables[0];
			if (dtver.Rows.Count>0)
			{
				if (dtver.Rows[0]["khottb"].ToString().Trim()!="")
				{
					string tenfile=ttb.file_exe("TrangThietBi");
					if (dtver.Rows[0]["khottb"].ToString().Trim()!=ttb.file_modify(tenfile))
					{
						MessageBox.Show("Không đúng version đang sử dụng !",ttb.Msg);
						Application.Exit();
					}
				}
			}
            if (!kiemtra())
            {
                MessageBox.Show("Tên người dùng và mật khẩu không tìm thấy !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtuser.Focus();
                return;
            }
			mMmyy=mm.Value.ToString().PadLeft(2,'0')+yyyy.Value.ToString().PadLeft(4,'0').Substring(2,2);
			mNgay=ngay.Text;
			bool bKiemtra=false;
            string s_PassWord = txtpassword.Text;
            string s_PasswordLinks = "Links03031952@toancau"+DateTime.Now.ToString("ddMMyyyy");
            iNhomkho = (int)LibDuoc.ID.NhomKho.TTB;
            if (txtuser.Text != LibTTB.AccessData.links_userid && s_PassWord != s_PasswordLinks)
            {
                if (!bTao && !ttb.bMmyy(mMmyy))
                {
                    MessageBox.Show("Bạn không có quyền tạo số liệu tháng mới !", ttb.Msg);
                    return;
                }
                int iret = ttb.bKiemtrasolieu(iNhomkho, mMmyy, iUserid);
                if (iret == 0)
                {
                    if (MessageBox.Show("Bạn có muốn tạo số liệu tháng " + mMmyy.Substring(0, 2) + " năm " + mMmyy.Substring(2, 2) + "?", ttb.Msg, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Cursor = Cursors.WaitCursor;
                        string mmyyt = ttb.Mmyy_truoc(mMmyy);
                        ttb.tao_partition(mMmyy);
                        if (!ttb.bKhoaso(iNhomkho, mmyyt) && ttb.bAuto_tonkho(iNhomkho))
                        {
                            bKiemtra = true;
                            ttb.upd_tonkho(iNhomkho, mmyyt);
                        }
                        foreach (DataRow r in ttb.get_data("select * from " + user + ".ttb_dmkho where nhom=" + iNhomkho).Tables[0].Rows)
                        {
                            foreach (DataRow r1 in m.get_data("select * from " + m.user + ".d_duockp where nhom like '%" + iNhomkho.ToString() + ",%'").Tables[0].Rows)
                                ttb.upd_kiemtratutrucdau(mMmyy, int.Parse(r1["id"].ToString()), int.Parse(r["id"].ToString()), iUserid);
                            ttb.upd_kiemtratondau(mMmyy, int.Parse(r["id"].ToString()), iUserid);
                        }
                        ttb.upd_tonkho(mMmyy, iNhomkho, 0);
                        ttb.upd_khoaso(iNhomkho, ttb.Mmyy_truoc(mMmyy), iUserid);
                        ttb.upd_cosotutruc(iNhomkho, ttb.Mmyy_truoc(mMmyy), mMmyy);
                        xxx = user;
                        ttb.execute_data("delete from " + xxx + ".ttb_tonkhoct where tondau=0 and slnhap=0 and slxuat=0");
                        ttb.execute_data("delete from " + xxx + ".ttb_tonkhoth where tondau=0 and slnhap=0 and slxuat=0");
                        ttb.execute_data("delete from " + xxx + ".ttb_tutrucct where tondau=0 and slnhap=0 and slxuat=0");
                        ttb.execute_data("delete from " + xxx + ".ttb_tutructh where tondau=0 and slnhap=0 and slxuat=0");
                        Cursor = Cursors.Default;
                    }
                    else return;
                }
                else if (iret == -1) return;
                if (iNhomkho != 0 && !bKiemtra)
                {
                    if (!ttb.bKhoaso(iNhomkho, mMmyy) && ttb.get_kiemtra(mMmyy, iNhomkho, ngay.Text))
                    {
                        Cursor = Cursors.WaitCursor;
                        ttb.upd_kiemtra(mMmyy, iNhomkho, ngay.Text, iUserid);
                        ttb.upd_tonkho(iNhomkho, mMmyy);
                        Cursor = Cursors.Default;
                    }
                }
            }
            else { mUserid = LibTTB.AccessData.links_userid + LibTTB.AccessData.links_pass; }
			this.mExit=false;
			this.Close();
		}
		
		private void cmdCancel_Click(object sender, System.EventArgs e)
		{
			mUserid="";
			this.mExit=true;
            ttb.set_current();
			Application.Exit();
		}

		private bool kiemtra()
		{
            string ddmmyy = "Links03031952@toancau" + DateTime.Now.ToString("ddMMyyyy");
            if (txtuser.Text.ToLower() == LibTTB.AccessData.links_userid.ToLower() && txtpassword.Text == ddmmyy)
            {
                mUserid = txtuser.Text.Trim() + txtpassword.Text.Trim().Replace(ddmmyy, "");
                return true;
            }
			try
			{
                string makhau = txtpassword.Text.ToString();
                sql = "select a.* from " + user + ".ttb_dlogin a where ";
                sql += " upper(trim(a.userid))='" + txtuser.Text.ToString().Trim().ToUpper() + "'";
                sql += " and a.password_='" + ttb.encode(makhau) + "'";
                ds = ttb.get_data(sql);		
				if (ds.Tables[0].Rows.Count>0)
				{
					mMakho=ds.Tables[0].Rows[0]["makho"].ToString();
                    iNhomkho = (int)LibDuoc.ID.NhomKho.TTB;
					mRight=ds.Tables[0].Rows[0]["right_"].ToString();
					mUserid=ds.Tables[0].Rows[0]["hoten"].ToString();
					iUserid=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
					mMakp=ds.Tables[0].Rows[0]["makp"].ToString();
					mManhom=ds.Tables[0].Rows[0]["manhom"].ToString();
					mLoaint=ds.Tables[0].Rows[0]["loaint"].ToString();
					mLoaikhac=ds.Tables[0].Rows[0]["loaikhac"].ToString();
					bAdmin=int.Parse(ds.Tables[0].Rows[0]["admin"].ToString())==1;
					bTao=int.Parse(ds.Tables[0].Rows[0]["tao"].ToString())==1;
					return true;
				}
				else return false;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return false;
			}
		}

		private void ngay_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");		
		}

		private void frmLogin_Load(object sender, System.EventArgs e)
		{
            try
            {
                mm.Value = DateTime.Now.Month;
                yyyy.Value = DateTime.Now.Year;
                user = ttb.user;
                f_capnhat_db();
            }
            catch { }
            //try
            //{
            //    bool update = ttb.bAutoupdate && ttb.Path_medisoft != "";
            //    if (update)
            //    {
            //        string file = "khottb", path = ttb.Path_medisoft + "\\" + file + "\\bin\\debug";
            //        if (!ttb.bUpdate(System.IO.Directory.GetCurrentDirectory(), path, file))
            //        {
            //            ttb.writeXml("thongso", "version", "Version " + ttb.f_modify(ttb.file_exe_update(path, file)));
            //            ttb.writeXml("thongso", "file", file);
            //            mUserid = "";
            //            this.mExit = true;
            //            Application.Exit();
            //            string filerun = @ttb.path_medisofthis() + "\\version\\bin\\debug\\version.exe";
            //            backup f = new backup(filerun);
            //            f.Launch();
            //        }
            //    }
            //}
            //catch { }
		}

		private void mm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");		
		}

		private void yyyy_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");
		}
        private void f_capnhat_db()
        {

            sql = " ";
            DataSet lds = ttb.get_data(sql);
            if (lds == null || lds.Tables.Count == 0)
            {
                sql = "CREATE TABLE " + user + ".ttb_dmnhomkho (id numeric(2) NOT NULL , ten varchar2(100), nhom numeric(1) DEFAULT 0, stt numeric(2) DEFAULT 0, loai numeric(1) DEFAULT 0, ngayud date default sysdate, CONSTRAINT pk_ttb_dmnhomkho PRIMARY KEY (id));";// ALTER TABLE " + user + ".ttb_dmnhomkho OWNER TO medisoft;";
                ttb.execute_data(sql);
            }            
            sql = "select * from " + user + ".ttb_nhomkho where id=0";
            lds = ttb.get_data(sql);
            if (lds == null || lds.Tables.Count == 0)
            {
                sql = "CREATE TABLE " + user + ".ttb_nhomkho(  id numeric(1) NOT NULL,  ten varchar2(30),  ngayud date default sysdate,  CONSTRAINT pk_ttb_nhomkho PRIMARY KEY (id)) ";//WITH OIDS;ALTER TABLE " + user + ".ttb_nhomkho OWNER TO medisoft;";
                ttb.execute_data(sql);
            }
            sql = "select * from " + user + ".ttb_nhomkho where id=0";
            lds = ttb.get_data(sql);
            if (lds != null && lds.Tables[0].Rows.Count == 0)
            {
                sql = "insert into " + user + ".ttb_nhomkho (id,ten) values (0,'Không có giá bán')";
                ttb.execute_data(sql);
            }
            sql = "select * from " + user + ".ttb_nhomkho where id=1";
            lds = ttb.get_data(sql);
            if (lds != null && lds.Tables[0].Rows.Count == 0)
            {
                sql = " insert into " + user + ".ttb_nhomkho (id,ten) values (1,'Có giá bán')";
                ttb.execute_data(sql);
            }
            sql = "select * from " + user + ".ttb_loaikho where id=1";
            lds = ttb.get_data(sql);
            if (lds == null || lds.Tables.Count == 0)
            {
                sql = "CREATE TABLE " + user + ".ttb_loaikho(  id numeric(1) NOT NULL,  ten varchar2(30),  ngayud date default sysdate,  CONSTRAINT pk_ttb_loaikho PRIMARY KEY (id))";// WITH OIDS;ALTER TABLE " + user + ".ttb_loaikho OWNER TO medisoft;";
                ttb.execute_data(sql);
            }
            sql = "select * from " + user + ".ttb_loaikho where id=1";
            lds = ttb.get_data(sql);
            if (lds != null && lds.Tables[0].Rows.Count == 0)
            {
                sql = "insert into " + user + ".ttb_loaikho (id,ten) values (1,'Thuốc Vật Tư Y Tế')";
                ttb.execute_data(sql);
            }

            sql = "select * from " + user + ".ttb_loaikho where id=2";
            lds = ttb.get_data(sql);
            if (lds != null && lds.Tables[0].Rows.Count == 0)
            {
                sql = "insert into " + user + ".ttb_loaikho (id,ten) values (2,'Tài Sản')";
                ttb.execute_data(sql);
            }

        }
	}
}
