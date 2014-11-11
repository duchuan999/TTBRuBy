using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using LibMedi;

namespace Duoc
{
	/// <summary>
	/// Summary description for frmChonchidinh.
	/// </summary>
	public class frmChonchidinh : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button butOK;
		private System.Windows.Forms.Button butCancel;
		public DataTable dt=new DataTable();
		private DataSet dsgia=new DataSet();
		private string s_mabn,s_loaivp,s_mucvp,sql;
		private DataColumn dc;
		private AccessData m;
		private CheckBox chkbox;
		private	TabPage tab;
		private ToolTip tooltip;
		private int i_madoituong;
		private System.Windows.Forms.TabControl tabControl;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmChonchidinh(AccessData acc,string mabn,int madoituong,string loaivp,string mucvp)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			m=acc;
			i_madoituong=madoituong;
			s_loaivp=loaivp;s_mucvp=mucvp;s_mabn=mabn;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmChonchidinh));
			this.tabControl = new System.Windows.Forms.TabControl();
			this.butOK = new System.Windows.Forms.Button();
			this.butCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tabControl.Location = new System.Drawing.Point(4, 2);
			this.tabControl.Multiline = true;
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.ShowToolTips = true;
			this.tabControl.Size = new System.Drawing.Size(787, 414);
			this.tabControl.TabIndex = 0;
			// 
			// butOK
			// 
			this.butOK.Image = ((System.Drawing.Bitmap)(resources.GetObject("butOK.Image")));
			this.butOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butOK.Location = new System.Drawing.Point(321, 424);
			this.butOK.Name = "butOK";
			this.butOK.Size = new System.Drawing.Size(75, 28);
			this.butOK.TabIndex = 1;
			this.butOK.Text = "    Đồng ý";
			this.butOK.Click += new System.EventHandler(this.butOK_Click);
			// 
			// butCancel
			// 
			this.butCancel.Image = ((System.Drawing.Bitmap)(resources.GetObject("butCancel.Image")));
			this.butCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butCancel.Location = new System.Drawing.Point(398, 424);
			this.butCancel.Name = "butCancel";
			this.butCancel.Size = new System.Drawing.Size(75, 28);
			this.butCancel.TabIndex = 2;
			this.butCancel.Text = "      Bỏ qua";
			this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
			// 
			// frmChonchidinh
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(794, 463);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.butCancel,
																		  this.butOK,
																		  this.tabControl});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmChonchidinh";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chọn dịch vụ";
			this.Load += new System.EventHandler(this.frmChonchidinh_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmChonchidinh_Load(object sender, System.EventArgs e)
		{
			dsgia=m.get_data("select * from v_giavp");
			taotable();
			load();
		}

		private void taotable()
		{
			dc=new DataColumn();
			dc.DataType=System.Type.GetType("System.Decimal");
			dc.ColumnName="mavp";
			dt.Columns.Add(dc);
			dc=new DataColumn();
			dc.DataType=System.Type.GetType("System.String");
			dc.ColumnName="ten";
			dt.Columns.Add(dc);
			dc=new DataColumn();
			dc.DataType=System.Type.GetType("System.String");
			dc.ColumnName="dvt";
			dt.Columns.Add(dc);
			dc=new DataColumn();
			dc.DataType=System.Type.GetType("System.Decimal");
			dc.ColumnName="dongia";
			dt.Columns.Add(dc);
			dc=new DataColumn();
			dc.DataType=System.Type.GetType("System.Decimal");
			dc.ColumnName="vattu";
			dt.Columns.Add(dc);
		}

		private void butOK_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void butCancel_Click(object sender, System.EventArgs e)
		{
			dt.Clear();
			this.Close();
		}

		private void load()
		{
			sql="select * from v_loaivp ";
			if (s_loaivp!="") sql+=" where id in ("+s_loaivp+")";
			sql+=" order by stt";
			foreach(DataRow r in m.get_data(sql).Tables[0].Rows)
			{
				tab=new TabPage();
				int t=0,l=0,j=0;
				tab.Text=r["ten"].ToString().Trim();
				tabControl.TabPages.Add(tab);
				sql="select * from v_giavp where id_loai="+int.Parse(r["id"].ToString());
				if (s_mucvp!="") sql+=" and id not in ("+s_mucvp+")";
				if (i_madoituong==1) sql+=" and bhyt<>0";
				sql+=" order by stt";
				foreach(DataRow r1 in m.get_data(sql).Tables[0].Rows)
				{
					if (j%17==0 && j!=0)
					{
						t=0;
						l+=405;
					}
					Addchkbox(r1["ten"].ToString(),r1["id"].ToString(),t,l,r1["gia_th"].ToString(),r1["gia_bh"].ToString(),new EventHandler(chkEvent));
					t+=20;
					j++;
				}
				tab.AutoScroll=true;
			}
		}

		public void chkEvent(object sender, EventArgs e)
		{
			Control ctrl=(Control)sender;
			chk c=ctrl.Tag as chk;
			DataRow r=m.getrowbyid(dsgia.Tables[0],"id="+int.Parse(c.index.ToString()));
			if (r!=null)
			{
				decimal d_dongia,d_vattu;
				if (m.bNuocngoai(s_mabn))
				{
					d_dongia=decimal.Parse(r["gia_nn"].ToString())*m.dTygia;
					d_vattu=decimal.Parse(r["vattu_nn"].ToString())*m.dTygia;
				}
				else
				{
					string gia=(i_madoituong==1)?"gia_bh":"gia_th";
					string giavt=(i_madoituong==1)?"vattu_bh":"vattu_th";
					d_dongia=decimal.Parse(r[gia].ToString());
					d_vattu=decimal.Parse(r[giavt].ToString());
				}
				m.reprec(dt,"mavp="+int.Parse(r["id"].ToString()),int.Parse(r["id"].ToString()),r["ten"].ToString(),r["dvt"].ToString(),d_dongia,d_vattu);
			}
		}

		public void Addchkbox(string text,string name,int t,int l,string gia_th,string gia_bh,EventHandler onClickEvent)
		{
			chk chkClick=new chk(name,onClickEvent);
			chkbox=new CheckBox();
			tooltip=new ToolTip();
			chkbox.Text=text;
			chkbox.Name=name;
			chkbox.Top=t;
			chkbox.Left=l;
			chkbox.Width=400;
			chkbox.Click+=onClickEvent;
			chkbox.Tag=chkClick;
			tab.Controls.Add(chkbox);
			tooltip.SetToolTip(chkbox,(gia_th==gia_bh)?gia_th:gia_th+"\n"+gia_bh);
		}

		public class chk : CheckBox
		{
			public string index;
			public string Index
			{
				get
				{
					return index;
				}
			}
			public chk(string index,EventHandler onClickEvent)
			{
				this.index=index;
				Click+=onClickEvent;
			}
		}
	}
}
