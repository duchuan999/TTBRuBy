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
	/// Summary description for frmUser.
	/// </summary>
	public class frmUser : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox hoten;
		private System.Windows.Forms.TextBox userid;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button butOk;
		private System.Windows.Forms.Button butCancel;
		private DataTable dtdmkho=new DataTable();
		private DataTable dtmakp=new DataTable();
		private DataTable dtdmnhom=new DataTable();
		private DataTable dtnt=new DataTable();
		private DataTable dtkhac=new DataTable();
        private LibTTB.AccessData ttb;
        private LibDuoc.AccessData d=new LibDuoc.AccessData();
		private DataSet	ds=new DataSet();
		private DataSet dsr=new DataSet();
		private string d_user="",d_psw="",d_right="",s_makho="",s_makp="",s_manhom="",s_userid,s_loaint="",s_loaikhac="",user;
		private int i_nhomkho;
        private decimal m_id;
		private System.Windows.Forms.CheckedListBox makho;
		private System.Windows.Forms.CheckedListBox makp;
		private System.Windows.Forms.CheckBox tao;
		private System.Windows.Forms.CheckBox admin;
		private System.Windows.Forms.CheckedListBox manhom;
		private System.Windows.Forms.CheckedListBox loaint;
		private System.Windows.Forms.CheckedListBox loaikhac;
        private bool bMahoa;
        private Label label4;
        private Label label5;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

        public frmUser(AccessData acc, DataSet dset, decimal id, string user, string psw, string right, int nhomkho, string _makho, string _makp, bool change, string _manhom, string _userid, string _loaint, string _loaikhac)
        {
            InitializeComponent();
            ttb = acc;
            dsr = dset;
            m_id = id;
            d_user = user; d_psw = psw; d_right = right;
            i_nhomkho = (int)LibDuoc.ID.NhomKho.TTB;
            s_makho = _makho;
            s_makp = _makp; s_manhom = _manhom; s_loaint = _loaint; s_loaikhac = _loaikhac;
            makho.Enabled = change; makp.Enabled = change;
            manhom.Enabled = change; s_userid = _userid;
            tao.Enabled = change; admin.Enabled = change;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.label1 = new System.Windows.Forms.Label();
            this.hoten = new System.Windows.Forms.TextBox();
            this.userid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.butOk = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.makho = new System.Windows.Forms.CheckedListBox();
            this.makp = new System.Windows.Forms.CheckedListBox();
            this.tao = new System.Windows.Forms.CheckBox();
            this.admin = new System.Windows.Forms.CheckBox();
            this.manhom = new System.Windows.Forms.CheckedListBox();
            this.loaint = new System.Windows.Forms.CheckedListBox();
            this.loaikhac = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hoten
            // 
            this.hoten.BackColor = System.Drawing.SystemColors.HighlightText;
            this.hoten.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoten.Location = new System.Drawing.Point(57, 9);
            this.hoten.MaxLength = 50;
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(160, 21);
            this.hoten.TabIndex = 1;
            this.hoten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hoten_KeyDown);
            // 
            // userid
            // 
            this.userid.BackColor = System.Drawing.SystemColors.HighlightText;
            this.userid.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userid.Location = new System.Drawing.Point(57, 34);
            this.userid.MaxLength = 10;
            this.userid.Name = "userid";
            this.userid.Size = new System.Drawing.Size(160, 21);
            this.userid.TabIndex = 3;
            this.userid.Validated += new System.EventHandler(this.userid_Validated);
            this.userid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userid_KeyDown);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(-7, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Login :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.HighlightText;
            this.password.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(57, 59);
            this.password.MaxLength = 10;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(160, 21);
            this.password.TabIndex = 5;
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_KeyDown);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(-7, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // butOk
            // 
            this.butOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butOk.Image = ((System.Drawing.Image)(resources.GetObject("butOk.Image")));
            this.butOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butOk.Location = new System.Drawing.Point(276, 307);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(60, 25);
            this.butOk.TabIndex = 12;
            this.butOk.Text = "&Ok";
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // butCancel
            // 
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Image = ((System.Drawing.Image)(resources.GetObject("butCancel.Image")));
            this.butCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butCancel.Location = new System.Drawing.Point(338, 307);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(60, 25);
            this.butCancel.TabIndex = 13;
            this.butCancel.Text = "    &Cancel";
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // makho
            // 
            this.makho.CheckOnClick = true;
            this.makho.Location = new System.Drawing.Point(57, 105);
            this.makho.Name = "makho";
            this.makho.Size = new System.Drawing.Size(160, 169);
            this.makho.TabIndex = 8;
            this.makho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.makho_KeyDown);
            // 
            // makp
            // 
            this.makp.CheckOnClick = true;
            this.makp.Location = new System.Drawing.Point(220, 30);
            this.makp.Name = "makp";
            this.makp.Size = new System.Drawing.Size(178, 244);
            this.makp.TabIndex = 11;
            this.makp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hoten_KeyDown);
            // 
            // tao
            // 
            this.tao.Location = new System.Drawing.Point(57, 276);
            this.tao.Name = "tao";
            this.tao.Size = new System.Drawing.Size(136, 24);
            this.tao.TabIndex = 9;
            this.tao.Text = "Tạo số liệu tháng mới";
            this.tao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hoten_KeyDown);
            // 
            // admin
            // 
            this.admin.Location = new System.Drawing.Point(220, 276);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(176, 24);
            this.admin.TabIndex = 10;
            this.admin.Text = "Chỉnh sửa số liệu";
            this.admin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hoten_KeyDown);
            // 
            // manhom
            // 
            this.manhom.CheckOnClick = true;
            this.manhom.Location = new System.Drawing.Point(400, 9);
            this.manhom.Name = "manhom";
            this.manhom.Size = new System.Drawing.Size(272, 169);
            this.manhom.TabIndex = 14;
            this.manhom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hoten_KeyDown);
            // 
            // loaint
            // 
            this.loaint.CheckOnClick = true;
            this.loaint.Location = new System.Drawing.Point(400, 180);
            this.loaint.Name = "loaint";
            this.loaint.Size = new System.Drawing.Size(144, 94);
            this.loaint.TabIndex = 15;
            // 
            // loaikhac
            // 
            this.loaikhac.CheckOnClick = true;
            this.loaikhac.Location = new System.Drawing.Point(544, 180);
            this.loaikhac.Name = "loaikhac";
            this.loaikhac.Size = new System.Drawing.Size(128, 94);
            this.loaikhac.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(57, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Kho:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(223, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Khoa phòng:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmUser
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(674, 351);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loaikhac);
            this.Controls.Add(this.loaint);
            this.Controls.Add(this.manhom);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.tao);
            this.Controls.Add(this.makp);
            this.Controls.Add(this.makho);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butOk);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hoten);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm người dùng";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void butOk_Click(object sender, System.EventArgs e)
		{
			if (hoten.Text=="")
			{
				MessageBox.Show("Yều cầu nhập họ tên !",ttb.Msg);
				hoten.Focus();
				return;
			}

			if (userid.Text=="")
			{
				MessageBox.Show("Yều cầu nhập tên login !",ttb.Msg);
				userid.Focus();
				return;
			}
			s_makho="";
			for(int i=0;i<makho.Items.Count;i++) if (makho.GetItemChecked(i)) s_makho+=dtdmkho.Rows[i]["id"].ToString()+",";
			s_makp="";
			for(int i=0;i<makp.Items.Count;i++)	if (makp.GetItemChecked(i)) s_makp+=dtmakp.Rows[i]["id"].ToString()+",";
			s_manhom="";
			for(int i=0;i<manhom.Items.Count;i++)	if (manhom.GetItemChecked(i)) s_manhom+=dtdmnhom.Rows[i]["id"].ToString()+",";
			s_loaint="";
			for(int i=0;i<loaint.Items.Count;i++)	if (loaint.GetItemChecked(i)) s_loaint+=dtnt.Rows[i]["id"].ToString()+",";
			s_loaikhac="";
			for(int i=0;i<loaikhac.Items.Count;i++)	if (loaikhac.GetItemChecked(i)) s_loaikhac+=dtkhac.Rows[i]["id"].ToString()+",";
            string mahoa = ttb.encode(password.Text);
			ttb.upd_dlogin(m_id,hoten.Text,userid.Text,mahoa,d_right,i_nhomkho,s_makho.Trim(),s_makp.Trim(),(tao.Checked)?1:0,(admin.Checked)?1:0,s_manhom,s_loaint,s_loaikhac);
			ttb.updrec(dsr.Tables[0],m_id,userid.Text,mahoa,d_right,i_nhomkho,s_makho.Trim(),s_makp.Trim());
			this.Close();
		}

		private void butCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private bool test()
		{
			if (hoten.Text=="")
			{
				MessageBox.Show("Yều cầu nhập họ tên !",ttb.Msg);
				hoten.Focus();
				return false;
			}

			if (userid.Text=="")
			{
				MessageBox.Show("Yều cầu nhập tên login !",ttb.Msg);
				userid.Focus();
				return false;
			}

			return true;
		}

		private void frmUser_Load(object sender, System.EventArgs e)
		{
            user = ttb.user; bMahoa = ttb.bMahoamatkhau;
            //nhomkho.DataSource = ttb.get_data("select * from " + user + ".ttb_dmnhomkho order by stt").Tables[0];
            //nhomkho.DisplayMember = "TEN";
            //nhomkho.ValueMember = "ID";
            //nhomkho.SelectedValue=i_nhomkho.ToString();
            //nhomkho.Enabled=s_userid==LibTTB.AccessData.links_userid+LibTTB.AccessData.links_pass;
			
			manhom.DisplayMember="TEN";
			manhom.ValueMember="ID";

			loaint.DisplayMember="TEN";
			loaint.ValueMember="ID";

			loaikhac.DisplayMember="TEN";
			loaikhac.ValueMember="ID";

			makp.DisplayMember="TEN";
			makp.ValueMember="ID";
			
			load_dmkho();

			if (m_id!=0)
			{
				this.Text="Sửa Password";
                foreach (DataRow r in ttb.get_data("select * from " + user + ".ttb_dlogin where id=" + m_id).Tables[0].Rows)
				{
					hoten.Text=r["hoten"].ToString();
					s_makho=r["makho"].ToString();
					s_makp=r["makp"].ToString();
					s_manhom=r["manhom"].ToString();
					s_loaint=r["loaint"].ToString();
					s_loaikhac=r["loaikhac"].ToString();
					tao.Checked=int.Parse(r["tao"].ToString())==1;
					admin.Checked=int.Parse(r["admin"].ToString())==1;
					break;
				}
				if (hoten.Text=="") hoten.Text=d_user;
				userid.Text=d_user;
                password.Text = ttb.decode(d_psw);
				userid.Enabled=false;
				s_makho=","+s_makho;
				for(int i=0;i<dtdmkho.Rows.Count;i++)
					if (s_makho.IndexOf(","+dtdmkho.Rows[i]["id"].ToString().Trim()+",")!=-1) makho.SetItemCheckState(i,CheckState.Checked);
					else makho.SetItemCheckState(i,CheckState.Unchecked);

				s_makp=","+s_makp;
				for(int i=0;i<dtmakp.Rows.Count;i++)
					if (s_makp.IndexOf(","+dtmakp.Rows[i]["id"].ToString().Trim()+",")!=-1) makp.SetItemCheckState(i,CheckState.Checked);
					else makp.SetItemCheckState(i,CheckState.Unchecked);

				s_manhom=","+s_manhom;
				for(int i=0;i<dtdmnhom.Rows.Count;i++)
					if (s_manhom.IndexOf(","+dtdmnhom.Rows[i]["id"].ToString().Trim()+",")!=-1) manhom.SetItemCheckState(i,CheckState.Checked);
					else manhom.SetItemCheckState(i,CheckState.Unchecked);

				s_loaint=","+s_loaint;
				for(int i=0;i<dtnt.Rows.Count;i++)
					if (s_loaint.IndexOf(","+dtnt.Rows[i]["id"].ToString().Trim()+",")!=-1) loaint.SetItemCheckState(i,CheckState.Checked);
					else loaint.SetItemCheckState(i,CheckState.Unchecked);

				s_loaikhac=","+s_loaikhac;
				for(int i=0;i<dtkhac.Rows.Count;i++)
					if (s_loaikhac.IndexOf(","+dtkhac.Rows[i]["id"].ToString().Trim()+",")!=-1) loaikhac.SetItemCheckState(i,CheckState.Checked);
					else loaikhac.SetItemCheckState(i,CheckState.Unchecked);
			}
			else m_id=ttb.get_id_dlogin;
		}

		private void hoten_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");
		}

		private void userid_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");
		}

		private void password_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}{F4}");
		}

		private void userid_Validated(object sender, System.EventArgs e)
		{
			if (userid.Text!="")
			{
				DataRow r=ttb.getrowbyid(dsr.Tables[0],"userid='"+userid.Text+"'");
				if (r!=null)
				{
					MessageBox.Show("Tên login đã có !",ttb.Msg);
					userid.Focus();
					return;
				}
			}
		}

		private void makho_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter || e.KeyCode==Keys.Tab) SendKeys.Send("{Tab}");
		}

		private void load_dmkho()
		{
			try
			{
                dtdmkho = ttb.get_data("select * from " + user + ".ttb_dmkho where nhom=" + i_nhomkho.ToString() + " order by stt").Tables[0];
				makho.DataSource=dtdmkho;
                makho.DisplayMember = "TEN";
                makho.ValueMember = "ID";
                dtmakp = d.get_data("select * from " + d.user + ".d_duockp where nhom like '%" + i_nhomkho.ToString() + ",%' order by stt").Tables[0];
				makp.DataSource=dtmakp;
                dtdmnhom = ttb.get_data("select * from " + user + ".ttb_dmnhom where nhom=" + i_nhomkho.ToString() + " order by stt").Tables[0];
				manhom.DataSource=dtdmnhom;
                dtnt = ttb.get_data("select * from " + user + ".ttb_dmloaint where nhom=" + i_nhomkho.ToString() + " order by stt").Tables[0];
				loaint.DataSource=dtnt;
                dtkhac = ttb.get_data("select * from " + user + ".ttb_dmkhac where nhom in(0," + i_nhomkho.ToString() + ") order by stt").Tables[0];
				loaikhac.DataSource=dtkhac;

                manhom.DisplayMember = "TEN";
                manhom.ValueMember = "ID";

                loaint.DisplayMember = "TEN";
                loaint.ValueMember = "ID";

                loaikhac.DisplayMember = "TEN";
                loaikhac.ValueMember = "ID";

                makp.DisplayMember = "TEN";
                makp.ValueMember = "ID";

                makho.DisplayMember = "TEN";
                makho.ValueMember = "ID";
			}
			catch{}
		}

		public DataSet dsright
		{
			get
			{
				return dsr;
			}
        }
	}
}
