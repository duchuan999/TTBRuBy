using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using LibTTB;

namespace TTB
{
	/// <summary>
	/// Summary description for frmTscdlc.
	/// </summary>
	public class frmTscdlc : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox ten;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker ngay;
		private System.Windows.Forms.ComboBox makp;
		private System.Windows.Forms.TextBox diengiai;
		private System.Windows.Forms.Button butLuu;
		private System.Windows.Forms.Button butKetthuc;
		private DataTable dt=new DataTable();
        private DataTable dth = new DataTable();
		public bool Ok=false;
        private LibTTB.AccessData ttb;
        private LibDuoc.AccessData d=new LibDuoc.AccessData();
		private decimal l_id;
		private int i_makp,i_nhom,i_stt,i_tt=0;
		private string sql,user;
        private byte[] image;
        private System.IO.MemoryStream memo;
        private System.IO.FileStream fstr;
        private Bitmap map;
        private Button butChon;
        private Panel panel1;
        private PictureBox pic;
        private ComboBox vanban;
        private Button butXoa;
        private Button butUpdate;
        private Button butMoi;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTscdlc(AccessData acc,decimal id,string tents,int makp,int nhom,int stt)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			ttb=acc;l_id=id;i_makp=makp;i_nhom=nhom;i_stt=stt;
			ten.Text=tents;
			this.Text="Luân chuyển tài sản "+tents;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTscdlc));
            this.label1 = new System.Windows.Forms.Label();
            this.ten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ngay = new System.Windows.Forms.DateTimePicker();
            this.makp = new System.Windows.Forms.ComboBox();
            this.diengiai = new System.Windows.Forms.TextBox();
            this.butLuu = new System.Windows.Forms.Button();
            this.butKetthuc = new System.Windows.Forms.Button();
            this.butChon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.vanban = new System.Windows.Forms.ComboBox();
            this.butXoa = new System.Windows.Forms.Button();
            this.butUpdate = new System.Windows.Forms.Button();
            this.butMoi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài sản :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ten
            // 
            this.ten.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ten.Enabled = false;
            this.ten.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ten.Location = new System.Drawing.Point(80, 3);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(360, 21);
            this.ten.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(152, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khoa :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ghi chú :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ngay
            // 
            this.ngay.CustomFormat = "dd/MM/yyyy";
            this.ngay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngay.Location = new System.Drawing.Point(80, 27);
            this.ngay.Name = "ngay";
            this.ngay.Size = new System.Drawing.Size(80, 21);
            this.ngay.TabIndex = 3;
            this.ngay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ngay_KeyDown);
            // 
            // makp
            // 
            this.makp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.makp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makp.Location = new System.Drawing.Point(200, 27);
            this.makp.Name = "makp";
            this.makp.Size = new System.Drawing.Size(240, 21);
            this.makp.TabIndex = 5;
            this.makp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ngay_KeyDown);
            // 
            // diengiai
            // 
            this.diengiai.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diengiai.Location = new System.Drawing.Point(80, 51);
            this.diengiai.Name = "diengiai";
            this.diengiai.Size = new System.Drawing.Size(360, 21);
            this.diengiai.TabIndex = 7;
            this.diengiai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ngay_KeyDown);
            // 
            // butLuu
            // 
            this.butLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butLuu.Location = new System.Drawing.Point(163, 341);
            this.butLuu.Name = "butLuu";
            this.butLuu.Size = new System.Drawing.Size(60, 25);
            this.butLuu.TabIndex = 8;
            this.butLuu.Text = "&Lưu";
            this.butLuu.Click += new System.EventHandler(this.butLuu_Click);
            // 
            // butKetthuc
            // 
            this.butKetthuc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butKetthuc.Location = new System.Drawing.Point(225, 341);
            this.butKetthuc.Name = "butKetthuc";
            this.butKetthuc.Size = new System.Drawing.Size(60, 25);
            this.butKetthuc.TabIndex = 9;
            this.butKetthuc.Text = "Kết thúc";
            this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
            // 
            // butChon
            // 
            this.butChon.Location = new System.Drawing.Point(344, 98);
            this.butChon.Name = "butChon";
            this.butChon.Size = new System.Drawing.Size(93, 23);
            this.butChon.TabIndex = 256;
            this.butChon.Text = "Chọn văn bản";
            this.butChon.UseVisualStyleBackColor = true;
            this.butChon.Click += new System.EventHandler(this.butChon_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.pic);
            this.panel1.Location = new System.Drawing.Point(80, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 208);
            this.panel1.TabIndex = 257;
            // 
            // pic
            // 
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(360, 208);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic.TabIndex = 254;
            this.pic.TabStop = false;
            // 
            // vanban
            // 
            this.vanban.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vanban.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vanban.FormattingEnabled = true;
            this.vanban.Location = new System.Drawing.Point(80, 73);
            this.vanban.Name = "vanban";
            this.vanban.Size = new System.Drawing.Size(360, 21);
            this.vanban.TabIndex = 258;
            this.vanban.SelectedIndexChanged += new System.EventHandler(this.vanban_SelectedIndexChanged);
            // 
            // butXoa
            // 
            this.butXoa.Location = new System.Drawing.Point(299, 98);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(44, 23);
            this.butXoa.TabIndex = 263;
            this.butXoa.Text = "Xóa";
            this.butXoa.UseVisualStyleBackColor = true;
            this.butXoa.Click += new System.EventHandler(this.butXoa_Click);
            // 
            // butUpdate
            // 
            this.butUpdate.Location = new System.Drawing.Point(254, 98);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(44, 23);
            this.butUpdate.TabIndex = 262;
            this.butUpdate.Text = "Lưu";
            this.butUpdate.UseVisualStyleBackColor = true;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // butMoi
            // 
            this.butMoi.Location = new System.Drawing.Point(209, 98);
            this.butMoi.Name = "butMoi";
            this.butMoi.Size = new System.Drawing.Size(44, 23);
            this.butMoi.TabIndex = 261;
            this.butMoi.Text = "Mới";
            this.butMoi.UseVisualStyleBackColor = true;
            this.butMoi.Click += new System.EventHandler(this.butMoi_Click);
            // 
            // frmTscdlc
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.butKetthuc;
            this.ClientSize = new System.Drawing.Size(454, 371);
            this.Controls.Add(this.butXoa);
            this.Controls.Add(this.butUpdate);
            this.Controls.Add(this.butMoi);
            this.Controls.Add(this.vanban);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.butChon);
            this.Controls.Add(this.butKetthuc);
            this.Controls.Add(this.butLuu);
            this.Controls.Add(this.diengiai);
            this.Controls.Add(this.makp);
            this.Controls.Add(this.ngay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ten);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTscdlc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTscdlc";
            this.Load += new System.EventHandler(this.frmTscdlc_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void butKetthuc_Click(object sender, System.EventArgs e)
		{
			Ok=false;
			this.Close();
		}

		private void ngay_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");
	}

		private void frmTscdlc_Load(object sender, System.EventArgs e)
		{
            user = ttb.user;
            pic.Tag = "0000.bmp";
            fstr = new System.IO.FileStream(pic.Tag.ToString(), System.IO.FileMode.Open, System.IO.FileAccess.Read);
            map = new Bitmap(Image.FromStream(fstr));
            pic.Image = (Bitmap)map;
            image = new byte[fstr.Length];
            fstr.Read(image, 0, System.Convert.ToInt32(fstr.Length));
            fstr.Close();
            pic.Tag = image;
			sql="select * from "+d.user+".d_duockp where nhom like '%"+i_nhom.ToString().Trim()+",%'";
			if (i_stt==0) sql+=" and id<>"+i_makp;
			sql+=" order by stt";
			makp.DisplayMember="TEN";
			makp.ValueMember="ID";
			makp.DataSource=d.get_data(sql).Tables[0];
			if (i_stt!=0)
			{
				foreach(DataRow r in ttb.get_data("select makp,to_char(ngay,'dd/mm/yyyy') as ngay,diengiai,image from "+user+".ttb_tscdlc where id="+l_id+" and stt="+i_stt).Tables[0].Rows)
				{
					makp.SelectedValue=r["makp"].ToString();
					ngay.Value=new DateTime(int.Parse(r["ngay"].ToString().Substring(6)),int.Parse(r["ngay"].ToString().Substring(3,2)),int.Parse(r["ngay"].ToString().Substring(0,2)),0,0,0);
					diengiai.Text=r["diengiai"].ToString();
				}
			}
            vanban.DisplayMember = "TT";
            vanban.ValueMember = "TT";
            load_vanban();
		}

        private void load_vanban()
        {
            dth = ttb.get_data("select * from " + user + ".ttb_tscdimage where id=" + l_id + " and stt=" + i_stt + " and loai=1 order by tt").Tables[0];
            vanban.DataSource = dth;
            load_hinh((vanban.SelectedIndex != -1) ? int.Parse(vanban.SelectedValue.ToString()) : 0);
        }

        private void load_hinh(int tt)
        {
            bool bFound = false;
            i_tt = tt;
            DataRow r = ttb.getrowbyid(dth, "tt=" + tt);
            if (r != null)
            {
                try
                {
                    image = new byte[0];
                    image = (byte[])(r["image"]);
                    memo = new MemoryStream(image);
                    map = new Bitmap(Image.FromStream(memo));
                    pic.Image = (Bitmap)map;
                    pic.Tag = image;
                    bFound = true;
                }
                catch { }
            }
            if (!bFound)
            {
                pic.Tag = "0000.bmp";
                fstr = new System.IO.FileStream(pic.Tag.ToString(), System.IO.FileMode.Open, System.IO.FileAccess.Read);
                map = new Bitmap(Image.FromStream(fstr));
                pic.Image = (Bitmap)map;
                image = new byte[fstr.Length];
                fstr.Read(image, 0, System.Convert.ToInt32(fstr.Length));
                fstr.Close();
                pic.Tag = image;
                i_tt = 1;
            }
        }

		private void butLuu_Click(object sender, System.EventArgs e)
		{
			if (makp.SelectedIndex==-1)
			{
				makp.Focus();
				return;
			}
			i_stt=(i_stt==0)?ttb.get_stt_tscd(l_id,"ttb_tscdlc"):i_stt;
			ttb.upd_tscdlc(l_id,i_stt,int.Parse(makp.SelectedValue.ToString()),ngay.Text,diengiai.Text);
            ttb.execute_data("update " + user + ".ttb_tscdkhoa set makp=" + int.Parse(makp.SelectedValue.ToString()) + " where id=" + l_id);
			Ok=true;
			this.Close();
		}

        private void butChon_Click(object sender, EventArgs e)
        {
            string sDir = System.Environment.CurrentDirectory.ToString();
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "Chọn văn bản";
            of.Filter = "Files (*.jpg)|*.jpg|All Files (*.*)|*.*";
            of.RestoreDirectory = true;
            if (of.ShowDialog() == DialogResult.OK)
            {
                pic.Tag = of.FileName;
                fstr = new System.IO.FileStream(pic.Tag.ToString(), System.IO.FileMode.Open, System.IO.FileAccess.Read);
                image = new byte[fstr.Length];
                fstr.Read(image, 0, System.Convert.ToInt32(fstr.Length));
                pic.Tag = image;
                map = new Bitmap(Image.FromStream(fstr));
                pic.Image = (Bitmap)map;
                fstr.Close();
            }
            System.Environment.CurrentDirectory = sDir;
            butLuu.Focus();
        }

        private void butMoi_Click(object sender, EventArgs e)
        {
            i_tt = (dth.Rows.Count == 0) ? 1 : int.Parse(dth.Rows[dth.Rows.Count - 1]["tt"].ToString()) + 1;
            pic.Tag = "0000.bmp";
            fstr = new System.IO.FileStream(pic.Tag.ToString(), System.IO.FileMode.Open, System.IO.FileAccess.Read);
            map = new Bitmap(Image.FromStream(fstr));
            pic.Image = (Bitmap)map;
            image = new byte[fstr.Length];
            fstr.Read(image, 0, System.Convert.ToInt32(fstr.Length));
            fstr.Close();
            pic.Tag = image;
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            ttb.upd_tscdimage(l_id, i_stt, 1, i_tt, (byte[])(pic.Tag));
            load_vanban();
        }

        private void vanban_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ActiveControl == vanban) load_hinh((vanban.SelectedIndex != -1) ? int.Parse(vanban.SelectedValue.ToString()) : 0);
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            if (dth.Rows.Count == 0) return;
            if (MessageBox.Show("Đồng ý hủy văn bản số : " + vanban.Text + " ?", ttb.Msg, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ttb.execute_data("delete from " + user + ".ttb_tscdimage where id=" + l_id + " and stt=" + i_stt + " and loai=1 and tt=" + int.Parse(vanban.SelectedValue.ToString()));
                load_vanban();
            }
        }
	}
}
