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
	/// Summary description for frmChonindmbd.
	/// </summary>
	public class frmChonindmbd : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox manhom;
		private System.Windows.Forms.ComboBox maloai;
		private System.Windows.Forms.Button butIn;
		private System.Windows.Forms.Button butKetthuc;
		private DataTable dtnhom=new DataTable();
		private DataTable dtloai=new DataTable();
		private int i_nhom,i_loai,i_tonkho,i_tt,i_nhomkho;
		private System.Windows.Forms.CheckBox tonkho;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox stt;
		private string sql,s_mmyy;
        private LibTTB.AccessData ttb;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmChonindmbd(AccessData acc,DataTable nhom,DataTable loai,string mmyy,int nhomkho)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			dtnhom=nhom;dtloai=loai;ttb=acc;s_mmyy=mmyy;i_nhomkho=nhomkho;
			tonkho.Text="Còn tồn kho tháng "+mmyy.Substring(0,2)+"/20"+mmyy.Substring(2,2);
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmChonindmbd));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.manhom = new System.Windows.Forms.ComboBox();
			this.maloai = new System.Windows.Forms.ComboBox();
			this.butIn = new System.Windows.Forms.Button();
			this.butKetthuc = new System.Windows.Forms.Button();
			this.tonkho = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.stt = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(-8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nhóm :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(-8, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Loại :";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// manhom
			// 
			this.manhom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.manhom.Location = new System.Drawing.Point(48, 16);
			this.manhom.Name = "manhom";
			this.manhom.Size = new System.Drawing.Size(288, 21);
			this.manhom.TabIndex = 1;
			this.manhom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.manhom_KeyDown);
			// 
			// maloai
			// 
			this.maloai.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.maloai.Location = new System.Drawing.Point(48, 40);
			this.maloai.Name = "maloai";
			this.maloai.Size = new System.Drawing.Size(288, 21);
			this.maloai.TabIndex = 3;
			this.maloai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.manhom_KeyDown);
			// 
			// butIn
			// 
			this.butIn.Image = ((System.Drawing.Bitmap)(resources.GetObject("butIn.Image")));
			this.butIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butIn.Location = new System.Drawing.Point(96, 122);
			this.butIn.Name = "butIn";
			this.butIn.Size = new System.Drawing.Size(75, 28);
			this.butIn.TabIndex = 10;
			this.butIn.Text = "      &In";
			this.butIn.Click += new System.EventHandler(this.butIn_Click);
			// 
			// butKetthuc
			// 
			this.butKetthuc.Image = ((System.Drawing.Bitmap)(resources.GetObject("butKetthuc.Image")));
			this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butKetthuc.Location = new System.Drawing.Point(174, 122);
			this.butKetthuc.Name = "butKetthuc";
			this.butKetthuc.Size = new System.Drawing.Size(75, 28);
			this.butKetthuc.TabIndex = 11;
			this.butKetthuc.Text = "&Kết thúc";
			this.butKetthuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
			// 
			// tonkho
			// 
			this.tonkho.Location = new System.Drawing.Point(48, 87);
			this.tonkho.Name = "tonkho";
			this.tonkho.Size = new System.Drawing.Size(280, 24);
			this.tonkho.TabIndex = 8;
			this.tonkho.Text = "Còn tồn kho";
			this.tonkho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.manhom_KeyDown);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(-8, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Thứ tự :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// stt
			// 
			this.stt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.stt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.stt.Items.AddRange(new object[] {
													 "Tên",
													 "Nhóm,phân loại,tên"});
			this.stt.Location = new System.Drawing.Point(48, 64);
			this.stt.Name = "stt";
			this.stt.Size = new System.Drawing.Size(288, 21);
			this.stt.TabIndex = 5;
			this.stt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.manhom_KeyDown);
			// 
			// frmChonindmbd
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(344, 167);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.stt,
																		  this.label3,
																		  this.tonkho,
																		  this.butKetthuc,
																		  this.butIn,
																		  this.maloai,
																		  this.manhom,
																		  this.label2,
																		  this.label1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmChonindmbd";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "In danh mục";
			this.Load += new System.EventHandler(this.frmChonindmbd_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void manhom_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");
		}

		private void butIn_Click(object sender, System.EventArgs e)
		{
			i_nhom=(manhom.SelectedIndex!=-1)?int.Parse(manhom.SelectedValue.ToString()):0;
			i_loai=(maloai.SelectedIndex!=-1)?int.Parse(maloai.SelectedValue.ToString()):0;
			i_tt=stt.SelectedIndex;
			i_tonkho=(tonkho.Checked)?1:0;
			string tenfile="d_dmbd_ten.rpt";
			sql="select a.*,trim(a.ten)||' '||a.hamluong tenbd,b.ten tennhom,c.ten tenloai,d.ten tenhang,e.ten tennuoc,f.ten tenbo,g.ten nhomkt,b.stt ttnhom,c.stt ttloai";
			sql+=" from "+ttb.user+".ttb_dmbd a,"+ttb.user+".ttb_dmnhom b,"+ttb.user+".ttb_dmloai c,"+ttb.user+".ttb_dmhang d,"+ttb.user+".ttb_dmnuoc e,"+ttb.user+".ttb_nhombo f,"+ttb.user+".ttb_dmnhomkt g ";
			sql+=" where a.manhom=b.id and a.maloai=c.id and a.mahang=d.id and a.manuoc=e.id and a.nhombo=f.id(+) and a.sotk=g.id(+) and a.nhom="+i_nhomkho;
			if (i_nhom!=0) sql+=" and a.manhom="+i_nhom;
			if (i_loai!=0) sql+=" and a.maloai="+i_loai;
            if (i_tonkho != 0) sql += " and a.id in (select mabd from " + ttb.user + s_mmyy + ".ttb_tonkhoth where tondau+slnhap>0)";
			if (i_tt==0) sql+=" order by a.ten";
			else
			{
				sql+=" order by b.stt,c.stt";
				if (i_tt==1) sql+=",a.ten";
				else sql+=",a.tenhc,a.ten";
				tenfile="d_dmbd_nhom.rpt";
			}
			string tit="DANH MỤC TRANG THIẾT BỊ ";
			tit+=" SỬ DỤNG TRONG BỆNH VIỆN";
			DataSet ds=ttb.get_data(sql);//s_mmyy
			if (ds.Tables[0].Rows.Count>0)
			{
				frmReport f=new frmReport(ttb,ds.Tables[0],tenfile,tit,"","","","","","","","","");
				f.ShowDialog();
			}
		}

		private void butKetthuc_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void frmChonindmbd_Load(object sender, System.EventArgs e)
		{
			manhom.DisplayMember="TEN";
			manhom.ValueMember="ID";
			manhom.DataSource=dtnhom;

			maloai.DisplayMember="TEN";
			maloai.ValueMember="ID";
			maloai.DataSource=dtloai;
			stt.SelectedIndex=0;
		}
	}
}
