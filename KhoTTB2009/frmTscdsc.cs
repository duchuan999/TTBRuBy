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
	public class frmTscdsc : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox ten;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker ngay;
		private System.Windows.Forms.TextBox diengiai;
		private System.Windows.Forms.Button butLuu;
		private System.Windows.Forms.Button butKetthuc;
		private DataTable dt=new DataTable();
        private DataTable dth = new DataTable();
		public bool Ok=false;
        private LibTTB.AccessData ttb;
		private decimal l_id;
		private int i_nhomcc,i_nhom,i_stt,i_tt=0;
		private string sql,user;
		private System.Windows.Forms.ComboBox noisc;
		private System.Windows.Forms.TextBox nguoidenghi;
		private System.Windows.Forms.Label label5;
        private Label label6;
        private NumericUpDown sogio;
        private TextBox nguoichungkien;
        private Label label7;
        private Label label8;
        private TextBox tyle;
        private PictureBox pic;
        private Button butChon;
        private byte[] image;
        private System.IO.MemoryStream memo;
        private System.IO.FileStream fstr;
        private Bitmap map;
        private Panel panel1;
        private TextBox nguoisuachua;
        private Label label9;
        private TextBox nguoigiamsat;
        private Label label10;
        private ComboBox vanban;
        private Button butMoi;
        private Button butUpdate;
        private Button butXoa;
        private TextBox sausc;
        private Label label11;
        private Label label12;
        private System.Windows.Forms.MaskedTextBox txtngaynhanve;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTscdsc(AccessData acc,decimal id,string tents,int nhomcc,int nhom,int stt)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			ttb=acc;l_id=id;i_nhomcc=nhomcc;i_nhom=nhom;i_stt=stt;
			ten.Text=tents;
			this.Text="Sửa chữa tài sản "+tents;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTscdsc));
            this.label1 = new System.Windows.Forms.Label();
            this.ten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ngay = new System.Windows.Forms.DateTimePicker();
            this.noisc = new System.Windows.Forms.ComboBox();
            this.diengiai = new System.Windows.Forms.TextBox();
            this.butLuu = new System.Windows.Forms.Button();
            this.butKetthuc = new System.Windows.Forms.Button();
            this.nguoidenghi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sogio = new System.Windows.Forms.NumericUpDown();
            this.nguoichungkien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tyle = new System.Windows.Forms.TextBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.butChon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nguoisuachua = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nguoigiamsat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.vanban = new System.Windows.Forms.ComboBox();
            this.butMoi = new System.Windows.Forms.Button();
            this.butUpdate = new System.Windows.Forms.Button();
            this.butXoa = new System.Windows.Forms.Button();
            this.sausc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtngaynhanve = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sogio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(43, 5);
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
            this.ten.Location = new System.Drawing.Point(121, 5);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(236, 21);
            this.ten.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(43, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(43, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nơi sửa chữa :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(22, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tình hình thiết bị :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ngay
            // 
            this.ngay.CustomFormat = "dd/MM/yyyy";
            this.ngay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngay.Location = new System.Drawing.Point(122, 28);
            this.ngay.Name = "ngay";
            this.ngay.Size = new System.Drawing.Size(80, 21);
            this.ngay.TabIndex = 3;
            this.ngay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ngay_KeyDown);
            // 
            // noisc
            // 
            this.noisc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.noisc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noisc.Location = new System.Drawing.Point(121, 117);
            this.noisc.Name = "noisc";
            this.noisc.Size = new System.Drawing.Size(236, 21);
            this.noisc.TabIndex = 11;
            this.noisc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ngay_KeyDown);
            // 
            // diengiai
            // 
            this.diengiai.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diengiai.Location = new System.Drawing.Point(121, 52);
            this.diengiai.Multiline = true;
            this.diengiai.Name = "diengiai";
            this.diengiai.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.diengiai.Size = new System.Drawing.Size(236, 39);
            this.diengiai.TabIndex = 7;
            // 
            // butLuu
            // 
            this.butLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butLuu.Location = new System.Drawing.Point(144, 306);
            this.butLuu.Name = "butLuu";
            this.butLuu.Size = new System.Drawing.Size(60, 25);
            this.butLuu.TabIndex = 22;
            this.butLuu.Text = "&Lưu";
            this.butLuu.Click += new System.EventHandler(this.butLuu_Click);
            // 
            // butKetthuc
            // 
            this.butKetthuc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butKetthuc.Location = new System.Drawing.Point(206, 306);
            this.butKetthuc.Name = "butKetthuc";
            this.butKetthuc.Size = new System.Drawing.Size(60, 25);
            this.butKetthuc.TabIndex = 23;
            this.butKetthuc.Text = "Kết thúc";
            this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
            // 
            // nguoidenghi
            // 
            this.nguoidenghi.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nguoidenghi.Location = new System.Drawing.Point(121, 94);
            this.nguoidenghi.Name = "nguoidenghi";
            this.nguoidenghi.Size = new System.Drawing.Size(236, 21);
            this.nguoidenghi.TabIndex = 9;
            this.nguoidenghi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ngay_KeyDown);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(19, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nơi đề nghị sửa :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(206, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số giờ đã sử dụng :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sogio
            // 
            this.sogio.BackColor = System.Drawing.SystemColors.HighlightText;
            this.sogio.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sogio.Location = new System.Drawing.Point(310, 28);
            this.sogio.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.sogio.Name = "sogio";
            this.sogio.Size = new System.Drawing.Size(47, 21);
            this.sogio.TabIndex = 5;
            this.sogio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ngay_KeyDown);
            // 
            // nguoichungkien
            // 
            this.nguoichungkien.BackColor = System.Drawing.SystemColors.HighlightText;
            this.nguoichungkien.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nguoichungkien.Location = new System.Drawing.Point(121, 186);
            this.nguoichungkien.Name = "nguoichungkien";
            this.nguoichungkien.Size = new System.Drawing.Size(236, 21);
            this.nguoichungkien.TabIndex = 17;
            this.nguoichungkien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ngay_KeyDown);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(19, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Người chứng kiến :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(19, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tỉ lệ % chất lượng :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tyle
            // 
            this.tyle.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tyle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tyle.Location = new System.Drawing.Point(121, 209);
            this.tyle.Name = "tyle";
            this.tyle.Size = new System.Drawing.Size(61, 21);
            this.tyle.TabIndex = 19;
            this.tyle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tyle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ngay_KeyDown);
            this.tyle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tyle_KeyPress);
            // 
            // pic
            // 
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(74, 74);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic.TabIndex = 254;
            this.pic.TabStop = false;
            // 
            // butChon
            // 
            this.butChon.Location = new System.Drawing.Point(557, 310);
            this.butChon.Name = "butChon";
            this.butChon.Size = new System.Drawing.Size(93, 23);
            this.butChon.TabIndex = 255;
            this.butChon.Text = "Chọn văn bản";
            this.butChon.UseVisualStyleBackColor = true;
            this.butChon.Click += new System.EventHandler(this.butChon_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pic);
            this.panel1.Location = new System.Drawing.Point(361, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 277);
            this.panel1.TabIndex = 256;
            // 
            // nguoisuachua
            // 
            this.nguoisuachua.BackColor = System.Drawing.SystemColors.HighlightText;
            this.nguoisuachua.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nguoisuachua.Location = new System.Drawing.Point(121, 140);
            this.nguoisuachua.Name = "nguoisuachua";
            this.nguoisuachua.Size = new System.Drawing.Size(236, 21);
            this.nguoisuachua.TabIndex = 13;
            this.nguoisuachua.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ngay_KeyDown);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(19, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "Người sửa chữa :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nguoigiamsat
            // 
            this.nguoigiamsat.BackColor = System.Drawing.SystemColors.HighlightText;
            this.nguoigiamsat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nguoigiamsat.Location = new System.Drawing.Point(121, 163);
            this.nguoigiamsat.Name = "nguoigiamsat";
            this.nguoigiamsat.Size = new System.Drawing.Size(236, 21);
            this.nguoigiamsat.TabIndex = 15;
            this.nguoigiamsat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ngay_KeyDown);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(19, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 23);
            this.label10.TabIndex = 14;
            this.label10.Text = "Người giám sát :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // vanban
            // 
            this.vanban.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vanban.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vanban.FormattingEnabled = true;
            this.vanban.Location = new System.Drawing.Point(361, 5);
            this.vanban.Name = "vanban";
            this.vanban.Size = new System.Drawing.Size(352, 21);
            this.vanban.TabIndex = 257;
            this.vanban.SelectedIndexChanged += new System.EventHandler(this.vanban_SelectedIndexChanged);
            // 
            // butMoi
            // 
            this.butMoi.Location = new System.Drawing.Point(422, 310);
            this.butMoi.Name = "butMoi";
            this.butMoi.Size = new System.Drawing.Size(44, 23);
            this.butMoi.TabIndex = 258;
            this.butMoi.Text = "Mới";
            this.butMoi.UseVisualStyleBackColor = true;
            this.butMoi.Click += new System.EventHandler(this.butMoi_Click);
            // 
            // butUpdate
            // 
            this.butUpdate.Location = new System.Drawing.Point(467, 310);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(44, 23);
            this.butUpdate.TabIndex = 259;
            this.butUpdate.Text = "Lưu";
            this.butUpdate.UseVisualStyleBackColor = true;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // butXoa
            // 
            this.butXoa.Location = new System.Drawing.Point(512, 310);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(44, 23);
            this.butXoa.TabIndex = 260;
            this.butXoa.Text = "Xóa";
            this.butXoa.UseVisualStyleBackColor = true;
            this.butXoa.Click += new System.EventHandler(this.butXoa_Click);
            // 
            // sausc
            // 
            this.sausc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sausc.Location = new System.Drawing.Point(121, 233);
            this.sausc.Multiline = true;
            this.sausc.Name = "sausc";
            this.sausc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.sausc.Size = new System.Drawing.Size(236, 70);
            this.sausc.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(-3, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 23);
            this.label11.TabIndex = 20;
            this.label11.Text = "Tình hình sau sửa chữa :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(188, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 23);
            this.label12.TabIndex = 261;
            this.label12.Text = "Ngày  nhận về :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtngaynhanve
            // 
            this.txtngaynhanve.Location = new System.Drawing.Point(277, 209);
            this.txtngaynhanve.Mask = "00/00/0000";
            this.txtngaynhanve.Name = "txtngaynhanve";
            this.txtngaynhanve.Size = new System.Drawing.Size(80, 20);
            this.txtngaynhanve.TabIndex = 264;
            this.txtngaynhanve.ValidatingType = typeof(System.DateTime);
            // 
            // frmTscdsc
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.butKetthuc;
            this.ClientSize = new System.Drawing.Size(716, 345);
            this.Controls.Add(this.txtngaynhanve);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.sausc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.butXoa);
            this.Controls.Add(this.butUpdate);
            this.Controls.Add(this.butMoi);
            this.Controls.Add(this.vanban);
            this.Controls.Add(this.nguoigiamsat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nguoisuachua);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.butChon);
            this.Controls.Add(this.tyle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nguoichungkien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sogio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nguoidenghi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.butKetthuc);
            this.Controls.Add(this.butLuu);
            this.Controls.Add(this.diengiai);
            this.Controls.Add(this.noisc);
            this.Controls.Add(this.ngay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ten);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTscdsc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTscdlc";
            this.Load += new System.EventHandler(this.frmTscdsc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sogio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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

		private void frmTscdsc_Load(object sender, System.EventArgs e)
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
            sql = "select * from " + user + ".ttb_dmnoisc where nhom=" + i_nhom + " order by stt";
			noisc.DisplayMember="TEN";
			noisc.ValueMember="ID";
			noisc.DataSource=ttb.get_data(sql).Tables[0];
			try
			{
				noisc.SelectedValue=i_nhomcc.ToString();
			}
			catch{}
            if (i_stt != 0)
            {
                foreach (DataRow r in ttb.get_data("select noisc,to_char(ngay,'dd/mm/yyyy') as ngay,nguoidenghi,diengiai,sogio,nguoichungkien,tyle,image,nguoisuachua,nguoigiamsat,sausc,to_char(ngaynhanve,'dd/mm/yyyy') as ngaynhanve from " + user + ".ttb_tscdsc where id=" + l_id + " and stt=" + i_stt).Tables[0].Rows)
                {
                    noisc.SelectedValue = r["noisc"].ToString();
                    ngay.Value = new DateTime(int.Parse(r["ngay"].ToString().Substring(6)), int.Parse(r["ngay"].ToString().Substring(3, 2)), int.Parse(r["ngay"].ToString().Substring(0, 2)), 0, 0, 0);
                    nguoidenghi.Text = r["nguoidenghi"].ToString();
                    nguoisuachua.Text = r["nguoisuachua"].ToString();
                    nguoigiamsat.Text = r["nguoigiamsat"].ToString();
                    diengiai.Text = r["diengiai"].ToString();
                    sogio.Value = decimal.Parse(r["sogio"].ToString());
                    nguoichungkien.Text = r["nguoichungkien"].ToString();
                    tyle.Text = r["tyle"].ToString();
                    sausc.Text = r["sausc"].ToString();
                    txtngaynhanve.Text = r["ngaynhanve"].ToString();
                }
            }
            vanban.DisplayMember = "TT";
            vanban.ValueMember = "TT";
            load_vanban();
		}

        private void load_vanban()
        {
            dth = ttb.get_data("select * from " + user + ".ttb_tscdimage where id=" + l_id + " and stt=" + i_stt + " and loai=0 order by tt").Tables[0];
            vanban.DataSource = dth;
            load_hinh((vanban.SelectedIndex!=-1)?int.Parse(vanban.SelectedValue.ToString()):0);
        }

        private void load_hinh(int tt)
        {
            bool bFound = false;
            i_tt = tt;
            DataRow r=ttb.getrowbyid(dth,"tt="+tt);
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
			if (noisc.SelectedIndex==-1)
			{
				noisc.Focus();
				return;
			}
			i_stt=(i_stt==0)?ttb.get_stt_tscd(l_id,"ttb_tscdsc"):i_stt;
			ttb.upd_tscdsc(l_id,i_stt,ngay.Text,diengiai.Text,nguoidenghi.Text,int.Parse(noisc.SelectedValue.ToString()),sogio.Value,nguoichungkien.Text,(tyle.Text!="")?decimal.Parse(tyle.Text):0);
            string ngayve = "";
            if (txtngaynhanve.Text.Trim().Trim('/').Trim() != "")
            {
                ngayve = txtngaynhanve.Text;
            }
            ttb.upd_tscdsc(l_id, i_stt, nguoisuachua.Text, nguoigiamsat.Text, sausc.Text,ngayve);
			Ok=true;
			this.Close();
		}

        private void tyle_KeyPress(object sender, KeyPressEventArgs e)
        {
            ttb.MaskDecimal(e);
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
            i_tt = (dth.Rows.Count == 0) ? 1 : int.Parse(dth.Rows[dth.Rows.Count - 1]["tt"].ToString())+1;
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
            ttb.upd_tscdimage(l_id, i_stt,0,i_tt,(byte[])(pic.Tag));
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
                ttb.execute_data("delete from "+user+".ttb_tscdimage where id="+l_id+" and stt="+i_stt+" and loai=0 and tt="+int.Parse(vanban.SelectedValue.ToString()));
                load_vanban();
            }
        }
	}
}
