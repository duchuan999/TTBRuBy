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
	/// Summary description for frmTuden.
	/// </summary>
	public class frmTuden : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker tu;
		private System.Windows.Forms.DateTimePicker den;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button butChon;
		private System.Windows.Forms.Button butKetthuc;
        private LibTTB.AccessData ttb;
		private bool bCongdon,bThua;
		private string s_makho,s_mmyy,user,xxx;
		public int i_makp,i_phieu,i_nhom,i_loai;
		public string s_tu,s_den,s_ngay,s_tenkp,s_phieu;
		private DataTable dtphieu=new DataTable();
		private DataTable dtkp=new DataTable();
		private DataTable dtph=new DataTable();
		private System.Windows.Forms.ComboBox makp;
		private System.Windows.Forms.ComboBox phieu;
		private System.Windows.Forms.CheckedListBox phieudutru;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox chkNgay;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTuden(AccessData acc,DataTable tkp,DataTable tphieu,int iNhom,int iMakp,int iLoai,int iPhieu,string ngay,bool congdon,bool thua,string makho,string mmyy)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            ttb = acc; i_nhom = iNhom; i_makp = iMakp;
            i_loai = iLoai; i_phieu = iPhieu; dtphieu = tphieu;
            dtkp = tkp; bThua = thua; s_makho = makho;
            s_ngay = ngay; bCongdon = congdon; s_mmyy = mmyy;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTuden));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tu = new System.Windows.Forms.DateTimePicker();
            this.den = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.butChon = new System.Windows.Forms.Button();
            this.butKetthuc = new System.Windows.Forms.Button();
            this.makp = new System.Windows.Forms.ComboBox();
            this.phieu = new System.Windows.Forms.ComboBox();
            this.phieudutru = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkNgay = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(134, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "đến :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tu
            // 
            this.tu.CustomFormat = "dd/MM/yyyy";
            this.tu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tu.Location = new System.Drawing.Point(57, 26);
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
            this.den.Location = new System.Drawing.Point(169, 26);
            this.den.Name = "den";
            this.den.Size = new System.Drawing.Size(80, 21);
            this.den.TabIndex = 1;
            this.den.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khoa :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phiếu :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // butChon
            // 
            this.butChon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butChon.Location = new System.Drawing.Point(68, 226);
            this.butChon.Name = "butChon";
            this.butChon.Size = new System.Drawing.Size(60, 25);
            this.butChon.TabIndex = 5;
            this.butChon.Text = "&Chọn";
            this.butChon.Click += new System.EventHandler(this.butChon_Click);
            // 
            // butKetthuc
            // 
            this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butKetthuc.Location = new System.Drawing.Point(130, 226);
            this.butKetthuc.Name = "butKetthuc";
            this.butKetthuc.Size = new System.Drawing.Size(60, 25);
            this.butKetthuc.TabIndex = 6;
            this.butKetthuc.Text = "&Kết thúc";
            this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
            // 
            // makp
            // 
            this.makp.BackColor = System.Drawing.SystemColors.HighlightText;
            this.makp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.makp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makp.Location = new System.Drawing.Point(57, 50);
            this.makp.Name = "makp";
            this.makp.Size = new System.Drawing.Size(191, 21);
            this.makp.TabIndex = 2;
            this.makp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.makp_KeyDown);
            // 
            // phieu
            // 
            this.phieu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.phieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.phieu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phieu.Location = new System.Drawing.Point(57, 74);
            this.phieu.Name = "phieu";
            this.phieu.Size = new System.Drawing.Size(191, 21);
            this.phieu.TabIndex = 3;
            this.phieu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phieu_KeyDown);
            // 
            // phieudutru
            // 
            this.phieudutru.CheckOnClick = true;
            this.phieudutru.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phieudutru.Location = new System.Drawing.Point(57, 98);
            this.phieudutru.Name = "phieudutru";
            this.phieudutru.Size = new System.Drawing.Size(190, 116);
            this.phieudutru.TabIndex = 4;
            this.phieudutru.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu_KeyDown);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Lọc :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkNgay
            // 
            this.chkNgay.Location = new System.Drawing.Point(57, 7);
            this.chkNgay.Name = "chkNgay";
            this.chkNgay.Size = new System.Drawing.Size(192, 16);
            this.chkNgay.TabIndex = 8;
            this.chkNgay.Text = "Lấy ngày chưa duyệt";
            this.chkNgay.Click += new System.EventHandler(this.chkNgay_Click);
            // 
            // frmTuden
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(258, 271);
            this.Controls.Add(this.chkNgay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phieudutru);
            this.Controls.Add(this.phieu);
            this.Controls.Add(this.makp);
            this.Controls.Add(this.butKetthuc);
            this.Controls.Add(this.butChon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.den);
            this.Controls.Add(this.tu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTuden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Từ ngày ... đến ngày";
            this.Load += new System.EventHandler(this.frmTuden_Load);
            this.ResumeLayout(false);

		}
		#endregion

		private void tu_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");
		}

		private void butChon_Click(object sender, System.EventArgs e)
		{
			if (makp.SelectedIndex==-1)
			{
				makp.Focus();return;
			}
			if (phieu.SelectedIndex==-1)
			{
				phieu.Focus();return;
			}
			s_phieu="";
			if (phieudutru.CheckedItems.Count>0)
				for(int i=0;i<phieudutru.Items.Count;i++) 
					if (phieudutru.GetItemChecked(i)) s_phieu+=dtph.Rows[i]["id"].ToString().Trim()+",";
			s_tu=tu.Text;s_den=den.Text;i_phieu=int.Parse(phieu.SelectedValue.ToString());i_makp=int.Parse(makp.SelectedValue.ToString());
			s_tenkp=makp.Text;
			if (ttb.get_duyet(s_mmyy,i_makp,i_nhom,i_loai,i_phieu,s_ngay,s_makho))
			{
				MessageBox.Show("Ngày "+s_ngay+"\nKhoa "+makp.Text+"\nPhiếu "+phieu.Text+"\nĐã duyệt !",ttb.Msg);
				return;
			}
			this.Close();
		}

		private void butKetthuc_Click(object sender, System.EventArgs e)
		{
			s_tu="";s_den="";
			this.Close();
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
				if (makp.SelectedIndex==-1) makp.SelectedIndex=0;
				SendKeys.Send("{Tab}");
			}
		}

		private void frmTuden_Load(object sender, System.EventArgs e)
		{
            user = ttb.user; xxx = user;// +s_mmyy;
			load_ngay_duyet();
            phieu.DisplayMember="TEN";
			phieu.ValueMember="ID";
			phieu.DataSource=dtphieu;
			phieu.SelectedValue=i_phieu.ToString();

			makp.DisplayMember="TEN";
			makp.ValueMember="ID";
			makp.DataSource=dtkp;
			makp.SelectedValue=i_makp.ToString();
			string sql="select * from "+user+".ttb_loaiphieu where nhom="+i_nhom+" and loai="+i_loai;
			if (bThua) sql+=" and id=0";
			else sql+=" and id<>0";
			sql+=" order by stt";
			dtph=ttb.get_data(sql).Tables[0];
            phieudutru.DataSource = dtph;
			phieudutru.DisplayMember="TEN";
			phieudutru.ValueMember="ID";
			
			if (!ttb.bLocphieu_duyet(i_nhom) && !bCongdon && i_loai!=2) Check_phieu_default();
		}

		private void Check_phieu_default()
		{
			for(int i=0;i<phieudutru.Items.Count;i++)
			{
				if(dtphieu.Rows[i]["id"].ToString()==i_phieu.ToString())
				{
					phieudutru.SetItemCheckState(i,CheckState.Checked);
					break;
				}				
			}
			phieudutru.Enabled=false;
		}

		private void chkNgay_Click(object sender, System.EventArgs e)
		{
			load_ngay_duyet();
		}
		private void load_ngay_duyet()
		{
			if(chkNgay.Checked==true)
			{
				DataTable dt=ttb.get_data("select to_char(ngay,'yyyymmdd') as ngay from "+xxx+".ttb_theodoiduyet where nhom="+i_nhom+" and loai="+i_loai+" and makp="+i_makp+" order by ngay ").Tables[0];
				if (dt.Rows.Count>0)
				{
					string s_tu=dt.Rows[0]["ngay"].ToString(),s_den=dt.Rows[dt.Rows.Count-1]["ngay"].ToString();
					tu.Value=new DateTime(int.Parse(s_tu.Substring(0,4)),int.Parse(s_tu.Substring(4,2)),int.Parse(s_tu.Substring(6,2)),0,0,0);
					den.Value=new DateTime(int.Parse(s_den.Substring(0,4)),int.Parse(s_den.Substring(4,2)),int.Parse(s_den.Substring(6,2)),0,0,0);
				}
				else
				{
					tu.Value=new DateTime(int.Parse(s_ngay.Substring(6,4)),int.Parse(s_ngay.Substring(3,2)),int.Parse(s_ngay.Substring(0,2)),0,0,0);
					den.Value=tu.Value;
				}
			}
			else
			{
				tu.Value=new DateTime(int.Parse(s_ngay.Substring(6,4)),int.Parse(s_ngay.Substring(3,2)),int.Parse(s_ngay.Substring(0,2)),0,0,0);
				den.Value=tu.Value;
			}
		}

	}
}
