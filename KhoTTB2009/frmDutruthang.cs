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
	/// Summary description for frmDutruthang.
	/// </summary>
	public class frmDutruthang : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button butIn;
		private System.Windows.Forms.Button butKetthuc;
		private System.Windows.Forms.Button butBoqua;
		private System.Windows.Forms.Button butLuu;
		private System.Windows.Forms.Button butMoi;
        private LibTTB.AccessData ttb;
		private int i_nhom,i_khotoithieu,i_manguon,i_lanthu;
        private bool bDutrumua_thangtruoc,bNam;
        private string s_mmyy, user, xxx, sql, makho, format_soluong, s_manhom, s_mmyyt, xxxt, s_tennguon, s_dutrunam, format_dongia;
		private DataSet ds=new DataSet();
		private DataSet dsxml=new DataSet();
		private DataTable dt=new DataTable();
        private DataTable dtkho = new DataTable();
		private DataSet dstt=new DataSet();
        private DataColumn dc;
		private DataRow r1,r2,r3;
		private DataRow [] dr;
        private CheckBox chkXem;
        private CheckBox chkXML;
        private Print print = new Print();
        private Button butHuy;
        private CheckBox chkAll;
        private dichso.numbertotext doiso = new dichso.numbertotext();
        private TextBox tieude;
        private Label label1;
        private TextBox tim;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmDutruthang(AccessData acc,int nhom,string mmyy,string _manhom,int _manguon,string _tennguon,int lanthu)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            ttb = acc; i_nhom = nhom; s_mmyy = mmyy; s_manhom = _manhom; i_lanthu = lanthu;
            i_manguon = _manguon; s_tennguon = _tennguon;
            if (s_mmyy.Substring(0,2)=="20")
    			this.Text="Bảng dự trù lần thứ "+i_lanthu.ToString()+" năm "+s_mmyy+((s_tennguon!="")?" ( "+s_tennguon.Trim()+" )":"");
            else
                this.Text = "Bảng dự trù lần thứ "+i_lanthu.ToString()+" tháng " + s_mmyy.Substring(0, 2) + " năm 20" + s_mmyy.Substring(2) + ((s_tennguon != "") ? " ( " + s_tennguon.Trim() + " )" : "");
            
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDutruthang));
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.butIn = new System.Windows.Forms.Button();
            this.butKetthuc = new System.Windows.Forms.Button();
            this.butBoqua = new System.Windows.Forms.Button();
            this.butLuu = new System.Windows.Forms.Button();
            this.butMoi = new System.Windows.Forms.Button();
            this.chkXem = new System.Windows.Forms.CheckBox();
            this.chkXML = new System.Windows.Forms.CheckBox();
            this.butHuy = new System.Windows.Forms.Button();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.tieude = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tim = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid1
            // 
            this.dataGrid1.AlternatingBackColor = System.Drawing.Color.Lavender;
            this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid1.CaptionBackColor = System.Drawing.SystemColors.Control;
            this.dataGrid1.CaptionFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid1.CaptionForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid1.DataMember = "";
            this.dataGrid1.FlatMode = true;
            this.dataGrid1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid1.GridLineColor = System.Drawing.Color.Gainsboro;
            this.dataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dataGrid1.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dataGrid1.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid1.LinkColor = System.Drawing.Color.Teal;
            this.dataGrid1.Location = new System.Drawing.Point(8, 8);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro;
            this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.RowHeaderWidth = 10;
            this.dataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue;
            this.dataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid1.Size = new System.Drawing.Size(776, 481);
            this.dataGrid1.TabIndex = 5;
            // 
            // butIn
            // 
            this.butIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butIn.Location = new System.Drawing.Point(459, 493);
            this.butIn.Name = "butIn";
            this.butIn.Size = new System.Drawing.Size(60, 25);
            this.butIn.TabIndex = 3;
            this.butIn.Text = "&In";
            this.butIn.Click += new System.EventHandler(this.butIn_Click);
            // 
            // butKetthuc
            // 
            this.butKetthuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butKetthuc.Location = new System.Drawing.Point(521, 493);
            this.butKetthuc.Name = "butKetthuc";
            this.butKetthuc.Size = new System.Drawing.Size(60, 25);
            this.butKetthuc.TabIndex = 4;
            this.butKetthuc.Text = "&Kết thúc";
            this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
            // 
            // butBoqua
            // 
            this.butBoqua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butBoqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butBoqua.Location = new System.Drawing.Point(397, 493);
            this.butBoqua.Name = "butBoqua";
            this.butBoqua.Size = new System.Drawing.Size(60, 25);
            this.butBoqua.TabIndex = 2;
            this.butBoqua.Text = "&Bỏ qua";
            // 
            // butLuu
            // 
            this.butLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butLuu.Location = new System.Drawing.Point(273, 493);
            this.butLuu.Name = "butLuu";
            this.butLuu.Size = new System.Drawing.Size(60, 25);
            this.butLuu.TabIndex = 1;
            this.butLuu.Text = "&Lưu";
            this.butLuu.Click += new System.EventHandler(this.butLuu_Click);
            // 
            // butMoi
            // 
            this.butMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butMoi.Location = new System.Drawing.Point(211, 493);
            this.butMoi.Name = "butMoi";
            this.butMoi.Size = new System.Drawing.Size(60, 25);
            this.butMoi.TabIndex = 0;
            this.butMoi.Text = "&Mới";
            this.butMoi.Click += new System.EventHandler(this.butMoi_Click);
            // 
            // chkXem
            // 
            this.chkXem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkXem.AutoSize = true;
            this.chkXem.Location = new System.Drawing.Point(601, 498);
            this.chkXem.Name = "chkXem";
            this.chkXem.Size = new System.Drawing.Size(102, 17);
            this.chkXem.TabIndex = 6;
            this.chkXem.Text = "Xem trước khi in";
            this.chkXem.UseVisualStyleBackColor = true;
            // 
            // chkXML
            // 
            this.chkXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkXML.AutoSize = true;
            this.chkXML.Location = new System.Drawing.Point(706, 498);
            this.chkXML.Name = "chkXML";
            this.chkXML.Size = new System.Drawing.Size(85, 17);
            this.chkXML.TabIndex = 7;
            this.chkXML.Text = "Xuất ra XML";
            this.chkXML.UseVisualStyleBackColor = true;
            // 
            // butHuy
            // 
            this.butHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butHuy.Location = new System.Drawing.Point(335, 493);
            this.butHuy.Name = "butHuy";
            this.butHuy.Size = new System.Drawing.Size(60, 25);
            this.butHuy.TabIndex = 8;
            this.butHuy.Text = "&Hủy";
            this.butHuy.Click += new System.EventHandler(this.butHuy_Click);
            // 
            // chkAll
            // 
            this.chkAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(8, 495);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(65, 17);
            this.chkAll.TabIndex = 9;
            this.chkAll.Text = "In tất cả";
            this.chkAll.UseVisualStyleBackColor = true;
            // 
            // tieude
            // 
            this.tieude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tieude.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tieude.Location = new System.Drawing.Point(56, 3);
            this.tieude.Name = "tieude";
            this.tieude.Size = new System.Drawing.Size(561, 21);
            this.tieude.TabIndex = 10;
            this.tieude.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tieude_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tiêu đề :";
            // 
            // tim
            // 
            this.tim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tim.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tim.ForeColor = System.Drawing.Color.Red;
            this.tim.Location = new System.Drawing.Point(620, 3);
            this.tim.Name = "tim";
            this.tim.Size = new System.Drawing.Size(164, 21);
            this.tim.TabIndex = 12;
            this.tim.Text = "Tìm kiếm";
            this.tim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tim.TextChanged += new System.EventHandler(this.tim_TextChanged);
            this.tim.Enter += new System.EventHandler(this.tim_Enter);
            // 
            // frmDutruthang
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.tim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tieude);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.butHuy);
            this.Controls.Add(this.chkXML);
            this.Controls.Add(this.chkXem);
            this.Controls.Add(this.butIn);
            this.Controls.Add(this.butKetthuc);
            this.Controls.Add(this.butBoqua);
            this.Controls.Add(this.butLuu);
            this.Controls.Add(this.butMoi);
            this.Controls.Add(this.dataGrid1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDutruthang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng dự trù thuốc tháng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDutruthang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void frmDutruthang_Load(object sender, System.EventArgs e)
		{
            //if (Screen.PrimaryScreen.WorkingArea.Width > 800) this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            tieude.Text = this.Text.ToUpper();
            chkXem.Checked = ttb.bPreview;
            bDutrumua_thangtruoc = ttb.bDutrumua_thangtruoc(i_nhom);
			Cursor=Cursors.WaitCursor;
            user = ttb.user; xxx = user;// +s_mmyy;
            bNam = s_mmyy.Substring(0, 2) == "20";
            s_dutrunam = (bNam)?ttb.dutrunam_nhomin(i_nhom):"";
            if (bNam)
            {
                foreach (DataRow r in ttb.get_data("select * from " + user + ".table where substr(mmyy,3,2)='" + s_mmyy.Substring(2) + "' order by mmyy").Tables[0].Rows)
                {
                    s_mmyyt = r["mmyy"].ToString();
                    xxxt = user;// +s_mmyyt;
                    break;
                }
            }
            else
            {
                if (bDutrumua_thangtruoc)
                {
                    s_mmyyt = ttb.Mmyy_truoc(s_mmyy); xxxt = user;// +s_mmyyt;
                }
                else
                {
                    s_mmyyt = s_mmyy; xxxt = xxx;
                }
            }
			format_soluong=ttb.format_soluong(i_nhom);
            format_dongia = ttb.format_dongia(i_nhom);
			i_khotoithieu=ttb.iKhotoithieu(i_nhom);
			dstt.ReadXml("..\\..\\..\\xml\\ttb_sttmua.xml");
            dtkho = ttb.get_data("select * from " + user + ".ttb_dmkho where nhom=" + i_nhom + " and dutru=1 order by stt").Tables[0];
            foreach (DataRow r in dtkho.Rows)
                makho += r["id"].ToString().Trim() + ",";
            makho = (makho != "") ? makho.Substring(0, makho.Length - 1) : makho;
			
            sql="select a.*,b.stt as sttnhom,b.ten as tennhom,c.ten as tenhang,d.ten as nhacc ";
			sql+=" from "+user+".ttb_dmbd a inner join ";
            if (i_nhom == 1) sql += " " + user + ".ttb_dmnhom b on a.manhom=b.id ";
            else sql += " " + user + ".ttb_dmloai b on a.maloai=b.id ";
            sql += " inner join " + user + ".ttb_dmhang c on a.mahang=c.id left join " + user + ".ttb_dmnx d on a.madv=d.id ";            
            sql+=" where  a.nhom="+i_nhom;
            if (s_dutrunam != "") sql += " and b.nhomin in (" + s_dutrunam + ")";
			dt=ttb.get_data(sql).Tables[0];
			load();
			dataGrid1.ReadOnly=false;
			CurrencyManager cm = (CurrencyManager)BindingContext[dataGrid1.DataSource,dataGrid1.DataMember];  
			DataView dv = (DataView) cm.List; 
			dv.AllowNew = false; 
			AddGridTableStyle();
			Cursor=Cursors.Default;
		}

		private void load()
		{
            sql = "update " + user + ".ttb_dutruthang set k1=0,xuat=0,tc=0 where nhom=" + i_nhom + " and mmyy='" + s_mmyy + "' and lan=" + i_lanthu;
            if (i_manguon != -1) sql += " and manguon=" + i_manguon;
            ttb.execute_data(sql);
			sql="select a.*,b.ma,trim(b.ten)||' '||b.hamluong as ten,b.dang,c.stt as sttnhom,c.ten as tennhom,d.ten as tenhang,";
            sql+="b.sltoithieu,b.dongia from "+user+".ttb_dutruthang a,"+user+".ttb_dmbd b,"+user+".ttb_dmnhom c,"+user+".ttb_dmhang d";
			sql+=" where a.mabd=b.id and b.manhom=c.id and b.mahang=d.id and a.nhom="+i_nhom+" and a.mmyy='"+s_mmyy+"' and a.lan="+i_lanthu;
            if (s_dutrunam != "") sql += " and c.nhomin in (" + s_dutrunam + ")";
            if (i_manguon != -1) sql += " and a.manguon=" + i_manguon;
			sql+=" order by c.stt,b.ma";
			ds=ttb.get_data(sql);
            foreach (DataRow r in dtkho.Rows)
            {
                dc = new DataColumn();
                dc.ColumnName = "c" + r["id"].ToString().Trim();
                dc.DataType = Type.GetType("System.Decimal");
                ds.Tables[0].Columns.Add(dc);
            }
			foreach(DataRow r in ds.Tables[0].Rows)
			{
                foreach (DataRow r2 in dtkho.Rows) r["c" + r2["id"].ToString().Trim()] = 0; 
				r1=ttb.getrowbyid(dt,"nhacc is not null and id="+int.Parse(r["mabd"].ToString()));
				if (r1!=null) 
				{
					r["nhacc"]=r1["nhacc"].ToString();
					r["donvi"]=r1["donvi"].ToString();
				}
			}
			get_tonkho();
            if (bNam)
                for (int i = int.Parse(s_mmyyt.Substring(0, 2)); i < 13; i++) get_xuat(i.ToString().PadLeft(2, '0') + s_mmyy.Substring(0, 2));
            else
                get_xuat(s_mmyyt);
            if (bNam)
                for(int i=int.Parse(s_mmyyt.Substring(0,2));i<13;i++) get_nhap(i.ToString().PadLeft(2,'0')+s_mmyy.Substring(0,2));
			else 
                get_nhap(s_mmyyt);
			dsxml=ds.Copy();
			dsxml.Clear();
			string stt="";
			foreach(DataRow r1 in dstt.Tables[0].Select("stt<>0","stt")) stt+=r1["ma"].ToString().Trim()+",";
			stt+="ten,";
			stt=stt.Substring(0,stt.Length-1);
            decimal tondau = 0;
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                tondau = 0;
                foreach (DataRow r4 in dtkho.Rows) tondau += decimal.Parse(r["c" + r4["id"].ToString().Trim()].ToString());
                //r["tc"] = tondau + decimal.Parse(r["k1"].ToString()) - decimal.Parse(r["xuat"].ToString());
                r["tc"] = tondau;// -decimal.Parse(r["xuat"].ToString());
            }
			dsxml.Merge(ds.Tables[0].Select("true",stt));
			dsxml.AcceptChanges();
			dataGrid1.DataSource=dsxml.Tables[0];
		}

		private string index(string kho)
		{
            return "c" + kho.Trim();
		}

		private void get_tonkho()
		{
            if (!ttb.bMmyy(s_mmyyt)) return;
            sql = "select a.makho,a.mabd,sum(a.tondau+a.slnhap-a.slxuat) as ton from " + xxxt + ".ttb_tonkhoth a," + user + ".ttb_dmbd b," + user + ".ttb_dmnhom c";
			sql+=" where a.mmyy='"+s_mmyyt+"' and a.mabd=b.id and b.manhom=c.id and a.makho in ("+makho+")";
            if (i_manguon != -1) sql += " and a.manguon=" + i_manguon;
            if (s_dutrunam != "") sql += " and c.nhomin in (" + s_dutrunam + ")";
			sql+=" group by a.makho,a.mabd";
			string kho="k1";
			foreach(DataRow r in ttb.get_data(sql).Tables[0].Rows)
			{
				kho=index(r["makho"].ToString());
				sql="mabd="+int.Parse(r["mabd"].ToString());
				r1=ttb.getrowbyid(ds.Tables[0],sql);
				if (r1==null)
				{
					r2=ttb.getrowbyid(dt,"id="+int.Parse(r["mabd"].ToString()));
					if (r2!=null)
					{
						r3=ds.Tables[0].NewRow();
						r3["mabd"]=r["mabd"].ToString();
						r3["sttnhom"]=r2["sttnhom"].ToString();
						r3["ma"]=r2["ma"].ToString();
						r3["ten"]=r2["ten"].ToString().Trim()+" "+r2["hamluong"].ToString();
						r3["dang"]=r2["dang"].ToString();
						r3["tennhom"]=r2["tennhom"].ToString();
						r3["tenhang"]=r2["tenhang"].ToString();
                        r3["k1"] = 0;
                        foreach (DataRow r4 in dtkho.Rows) r3["c" + r4["id"].ToString().Trim()] = 0;
						r3["xuat"]=0;
						r3["l1"]=0;
						r3["d1"]=0;
						r3["l2"]=0;
						r3["d2"]=0;
						r3[kho]=r["ton"].ToString();
						r3["tc"]=decimal.Parse(r["ton"].ToString());
						r3["nhacc"]=r2["nhacc"].ToString();
						r3["donvi"]=r2["donvi"].ToString();
						r3["sltoithieu"]=r2["sltoithieu"].ToString();
                        r3["dongia"] = r2["dongia"].ToString();
						ds.Tables[0].Rows.Add(r3);
					}
				}
				else
				{
					dr=ds.Tables[0].Select(sql);
					if (dr.Length>0) 
					{
						dr[0][kho]=decimal.Parse(dr[0][kho].ToString())+decimal.Parse(r["ton"].ToString());
						dr[0]["tc"]=decimal.Parse(dr[0]["tc"].ToString())+decimal.Parse(r["ton"].ToString());
						r2=ttb.getrowbyid(dt,"id="+int.Parse(r["mabd"].ToString()));
						if (r2!=null)
						{
							if (r2["nhacc"].ToString()!="") dr[0]["nhacc"]=r2["nhacc"].ToString();
							if (r2["donvi"].ToString()!="") dr[0]["donvi"]=r2["donvi"].ToString();
						}
					}
				}
			}
		}
		private void get_nhap(string s_mmyyt)
		{
            if (!ttb.bMmyy(s_mmyyt)) return;
            string xxxt = user;// +s_mmyyt;
			sql="select a.makho,b.mabd,sum(b.soluong) as soluong from "+xxxt+".ttb_nhapll a,"+xxxt+".ttb_nhapct b,"+user+".ttb_dmbd c,"+user+".ttb_dmnhom d";
            sql += " where a.mmyy='" + s_mmyyt + "' and a.id=b.id and b.mabd=c.id and c.manhom=d.id and a.loai='M' and a.makho in (" + makho + ") ";
            if (s_dutrunam != "") sql += " and d.nhomin in (" + s_dutrunam + ")";
            if (i_manguon != -1) sql += " and a.manguon=" + i_manguon;
            sql+=" group by a.makho,b.mabd";
			foreach(DataRow r in ttb.get_data(sql).Tables[0].Rows)
			{
				sql="mabd="+int.Parse(r["mabd"].ToString());
				r1=ttb.getrowbyid(ds.Tables[0],sql);
				if (r1==null)
				{
					r2=ttb.getrowbyid(dt,"id="+int.Parse(r["mabd"].ToString()));
					if (r2!=null)
					{
						r3=ds.Tables[0].NewRow();
						r3["mabd"]=r["mabd"].ToString();
						r3["sttnhom"]=r2["sttnhom"].ToString();
						r3["ma"]=r2["ma"].ToString();
						r3["ten"]=r2["ten"].ToString().Trim()+" "+r2["hamluong"].ToString();
						r3["dang"]=r2["dang"].ToString();
						r3["tennhom"]=r2["tennhom"].ToString();
						r3["tenhang"]=r2["tenhang"].ToString();
						r3["k1"]=r["soluong"].ToString();
                        foreach (DataRow r4 in dtkho.Rows) r3["c" + r4["id"].ToString().Trim()] = 0;
						r3["xuat"]=0;
						r3["l1"]=0;
						r3["d1"]=0;
						r3["l2"]=0;
						r3["d2"]=0;
						r3["tc"]=0;
						r3["nhacc"]=r2["nhacc"].ToString();
						r3["donvi"]=r2["donvi"].ToString();
						r3["sltoithieu"]=r2["sltoithieu"].ToString();
                        r3["dongia"] = r2["dongia"].ToString();
						ds.Tables[0].Rows.Add(r3);
					}
				}
				else
				{
					dr=ds.Tables[0].Select(sql);
					if (dr.Length>0) dr[0]["k1"]=decimal.Parse(dr[0]["k1"].ToString())+decimal.Parse(r["soluong"].ToString());
					r2=ttb.getrowbyid(dt,"id="+int.Parse(r["mabd"].ToString()));
					if (r2!=null)
					{
						if (r2["nhacc"].ToString()!="") dr[0]["nhacc"]=r2["nhacc"].ToString();
						if (r2["donvi"].ToString()!="") dr[0]["donvi"]=r2["donvi"].ToString();
					}
				}
			}
		}

		private void get_xuat(string s_mmyyt)
		{
            if (!ttb.bMmyy(s_mmyyt)) return;
            string xxxt = user;// +s_mmyyt;
			sql="select a.khox as makho,b.mabd,sum(b.soluong) as soluong from "+xxxt+".ttb_xuatll a,"+xxxt+".ttb_xuatct b,"+xxxt+".ttb_theodoi t";
            sql+= " ," + user + ".ttb_dmbd c," + user + ".ttb_dmnhom d ";
            sql += " where a.mmyy='" + s_mmyyt + "' and a.id=b.id and a.loai='XK' and b.sttt=t.id and a.khox in (" + makho + ") ";
            sql += " and b.mabd=c.id and c.manhom=d.id ";
            if (s_dutrunam != "") sql += " and d.nhomin in (" + s_dutrunam + ")";
            if (i_manguon != -1) sql += " and t.manguon=" + i_manguon;
            sql+=" group by a.khox,b.mabd";
			sql+=" union all ";
            sql += "select b.makho,b.mabd,sum(b.soluong) as soluong from " + xxxt + ".ttb_ngtrull a," + xxxt + ".ttb_ngtruct b," + xxxt + ".ttb_theodoi t";
            sql += " ," + user + ".ttb_dmbd c," + user + ".ttb_dmnhom d ";
            sql += " where a.mmyy='" + s_mmyyt + "' and a.id=b.id and b.sttt=t.id and b.makho in (" + makho + ") ";
            sql += " and b.mabd=c.id and c.manhom=d.id ";
            if (s_dutrunam != "") sql += " and d.nhomin in (" + s_dutrunam + ")";
            if (i_manguon != -1) sql += " and t.manguon=" + i_manguon;
            sql+=" group by b.makho,b.mabd";
            //sql+=" union all ";
            //sql += "select b.makho,b.mabd,sum(b.soluong) as soluong from " + xxxt + ".bhytkb a," + xxxt + ".bhytthuoc b," + xxxt + ".ttb_theodoi t";
            //sql += " ," + user + ".ttb_dmbd c," + user + ".ttb_dmnhom d ";
            //sql += " where a.id=b.id and b.sttt=t.id and b.makho in (" + makho + ") ";
            //sql += " and b.mabd=c.id and c.manhom=d.id ";
            //if (s_dutrunam != "") sql += " and d.nhomin in (" + s_dutrunam + ")";
            //if (i_manguon != -1) sql += " and t.manguon=" + i_manguon;
            //sql+=" group by b.makho,b.mabd";
			sql+=" union all ";
            sql += "select b.makho,b.mabd,sum(b.soluong) as soluong from " + xxxt + ".ttb_xuatsdll a," + xxxt + ".ttb_thucxuat b," + xxxt + ".ttb_theodoi t";
            sql += " ," + user + ".ttb_dmbd c," + user + ".ttb_dmnhom d ";
            sql += " where a.mmyy='" + s_mmyyt + "' and  a.id=b.id and a.loai in (1,4) and b.sttt=t.id and b.makho in (" + makho + ") ";
            sql += " and b.mabd=c.id and c.manhom=d.id ";
            if (s_dutrunam != "") sql += " and d.nhomin in (" + s_dutrunam + ")";
            if (i_manguon != -1) sql += " and t.manguon=" + i_manguon;
            sql+=" group by b.makho,b.mabd";
			sql+=" union all ";
            sql += "select b.makho,b.mabd,-sum(b.soluong) as soluong from " + xxxt + ".ttb_xuatsdll a," + xxxt + ".ttb_thucxuat b," + xxxt + ".ttb_theodoi t";
            sql += " ," + user + ".ttb_dmbd c," + user + ".ttb_dmnhom d ";
            sql += " where a.mmyy='" + s_mmyyt + "' and a.id=b.id and a.loai in (3) and b.sttt=t.id and b.makho in (" + makho + ") ";
            sql += " and b.mabd=c.id and c.manhom=d.id ";
            if (s_dutrunam != "") sql += " and d.nhomin in (" + s_dutrunam + ")";
            if (i_manguon != -1) sql += " and t.manguon=" + i_manguon;
            sql+=" group by b.makho,b.mabd";
			sql+=" union all ";
            sql += "select b.makho,b.mabd,sum(b.soluong) as soluong from " + xxxt + ".ttb_xuatsdll a," + xxxt + ".ttb_thucbucstt b," + xxxt + ".ttb_theodoi t";
            sql += " ," + user + ".ttb_dmbd c," + user + ".ttb_dmnhom d ";
            sql += " where a.mmyy='" + s_mmyyt + "' and a.id=b.id and a.loai in (2) and b.sttt=t.id and b.makho in (" + makho + ") ";
            sql += " and b.mabd=c.id and c.manhom=d.id ";
            if (s_dutrunam != "") sql += " and d.nhomin in (" + s_dutrunam + ")";
            if (i_manguon != -1) sql += " and t.manguon=" + i_manguon;
            sql+=" group by b.makho,b.mabd";
			foreach(DataRow r in ttb.get_data(sql).Tables[0].Rows)
			{
				sql="mabd="+int.Parse(r["mabd"].ToString());
				r1=ttb.getrowbyid(ds.Tables[0],sql);
				if (r1==null)
				{
					r2=ttb.getrowbyid(dt,"id="+int.Parse(r["mabd"].ToString()));
					if (r2!=null)
					{
						r3=ds.Tables[0].NewRow();
						r3["mabd"]=r["mabd"].ToString();
						r3["sttnhom"]=r2["sttnhom"].ToString();
						r3["ma"]=r2["ma"].ToString();
						r3["ten"]=r2["ten"].ToString().Trim()+" "+r2["hamluong"].ToString();
						r3["dang"]=r2["dang"].ToString();
						r3["tennhom"]=r2["tennhom"].ToString();
						r3["tenhang"]=r2["tenhang"].ToString();
						r3["k1"]=0;
                        foreach (DataRow r4 in dtkho.Rows) r3["c" + r4["id"].ToString().Trim()] = 0;
						r3["xuat"]=r["soluong"].ToString();
						r3["l1"]=0;
						r3["d1"]=0;
						r3["l2"]=0;
						r3["d2"]=0;
						r3["tc"]=0;
						r3["nhacc"]=r2["nhacc"].ToString();
						r3["donvi"]=r2["donvi"].ToString();
						r3["sltoithieu"]=r2["sltoithieu"].ToString();
                        r3["dongia"] = r2["dongia"].ToString();
						ds.Tables[0].Rows.Add(r3);
					}
				}
				else
				{
					dr=ds.Tables[0].Select(sql);
					if (dr.Length>0) dr[0]["xuat"]=decimal.Parse(dr[0]["xuat"].ToString())+decimal.Parse(r["soluong"].ToString());
					r2=ttb.getrowbyid(dt,"id="+int.Parse(r["mabd"].ToString()));
					if (r2!=null)
					{
						if (r2["nhacc"].ToString()!="") dr[0]["nhacc"]=r2["nhacc"].ToString();
						if (r2["donvi"].ToString()!="") dr[0]["donvi"]=r2["donvi"].ToString();
					}
				}
			}
		}

		private void AddGridTableStyle()
		{
			DataGridColoredTextBoxColumn TextCol1;
			delegateGetColorRowCol de = new delegateGetColorRowCol(MyGetColorRowCol);
			DataGridTableStyle ts =new DataGridTableStyle();
			ts.AlternatingBackColor = Color.Beige;
			ts.BackColor = Color.GhostWhite;
			ts.ForeColor = Color.MidnightBlue;
			ts.GridLineColor = Color.RoyalBlue;
			ts.HeaderBackColor = Color.MidnightBlue;
			ts.HeaderForeColor = Color.Lavender;
			ts.SelectionBackColor = Color.Teal;
			ts.SelectionForeColor = Color.PaleGreen;
			ts.RowHeaderWidth=10;
			ts.MappingName = dsxml.Tables[0].TableName;

            TextCol1 = new DataGridColoredTextBoxColumn(de, 0);
            TextCol1.MappingName = "mabd";
            TextCol1.HeaderText = "";
            TextCol1.Width = 0;
            ts.GridColumnStyles.Add(TextCol1);
            dataGrid1.TableStyles.Add(ts);

			TextCol1=new DataGridColoredTextBoxColumn(de, 1);
			TextCol1.MappingName = "ten";
			TextCol1.HeaderText = "Tên vật tư";
			TextCol1.Width = 200;
			ts.GridColumnStyles.Add(TextCol1);
			dataGrid1.TableStyles.Add(ts);

			TextCol1=new DataGridColoredTextBoxColumn(de, 2);
			TextCol1.MappingName = "donvi";
			TextCol1.HeaderText = "Đóng gói";
			TextCol1.Width = 60;
			ts.GridColumnStyles.Add(TextCol1);
			dataGrid1.TableStyles.Add(ts);

			TextCol1=new DataGridColoredTextBoxColumn(de, 3);
			TextCol1.MappingName = "dang";
			TextCol1.HeaderText = "ĐVT";
			TextCol1.Width = 40;
			TextCol1.ReadOnly=true;
			ts.GridColumnStyles.Add(TextCol1);
			dataGrid1.TableStyles.Add(ts);

			TextCol1=new DataGridColoredTextBoxColumn(de, 4);
			TextCol1.MappingName = "tenhang";
			TextCol1.HeaderText = "Hãng SX";
			TextCol1.Width = 100;
			TextCol1.ReadOnly=true;
			ts.GridColumnStyles.Add(TextCol1);
			dataGrid1.TableStyles.Add(ts);

            TextCol1 = new DataGridColoredTextBoxColumn(de, 5);
            TextCol1.MappingName = "k1";
            TextCol1.HeaderText = "Nhập mới";
            TextCol1.Width = 60;
            TextCol1.ReadOnly = true;
            TextCol1.Format = format_soluong;
            TextCol1.Alignment = HorizontalAlignment.Right;
            ts.GridColumnStyles.Add(TextCol1);
            dataGrid1.TableStyles.Add(ts);

            int j=6;
            string fie="k1";
            foreach(DataRow r in dtkho.Rows)
            {
                fie = "c" + r["id"].ToString().Trim();
    			TextCol1=new DataGridColoredTextBoxColumn(de,j);
                TextCol1.MappingName = fie;
                TextCol1.HeaderText = r["ten"].ToString().Trim();
    			TextCol1.Width = 60;
	    		TextCol1.ReadOnly=true;
		    	TextCol1.Format=format_soluong;
			    TextCol1.Alignment=HorizontalAlignment.Right;
    			ts.GridColumnStyles.Add(TextCol1);
	    		dataGrid1.TableStyles.Add(ts);
                j++;
            }

			TextCol1=new DataGridColoredTextBoxColumn(de,j+1);
			TextCol1.MappingName = "xuat";
			TextCol1.HeaderText = "Sử dụng";
			TextCol1.Width = 60;
			TextCol1.ReadOnly=true;
			TextCol1.Format=format_soluong;
			TextCol1.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol1);
			dataGrid1.TableStyles.Add(ts);
	
			TextCol1=new DataGridColoredTextBoxColumn(de,j+2);
			TextCol1.MappingName = "tc";
			TextCol1.HeaderText = "Tổng số";
			TextCol1.Width = 60;
			TextCol1.ReadOnly=true;
			TextCol1.Format=format_soluong;
			TextCol1.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol1);
			dataGrid1.TableStyles.Add(ts);

			TextCol1=new DataGridColoredTextBoxColumn(de,j+3);
			TextCol1.MappingName = "l1";
			TextCol1.HeaderText = "Dự trù "+i_lanthu.ToString();
			TextCol1.Width = 60;
			TextCol1.Format=format_soluong;
			TextCol1.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol1);
			dataGrid1.TableStyles.Add(ts);

			TextCol1=new DataGridColoredTextBoxColumn(de,j+4);
			TextCol1.MappingName = "d1";
			TextCol1.HeaderText = "Duyệt "+i_lanthu.ToString();
			TextCol1.Width = 60;
			TextCol1.Format=format_soluong;
			TextCol1.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol1);
			dataGrid1.TableStyles.Add(ts);

			TextCol1=new DataGridColoredTextBoxColumn(de,j+5);
			TextCol1.MappingName = "nhacc";
			TextCol1.HeaderText = "Nhà cung cấp";
			TextCol1.Width = 200;
			ts.GridColumnStyles.Add(TextCol1);
			dataGrid1.TableStyles.Add(ts);

            TextCol1 = new DataGridColoredTextBoxColumn(de, j + 6);
            TextCol1.MappingName = "dongia";
            TextCol1.HeaderText = "Đơn giá";
            TextCol1.Width = 80;
            TextCol1.Format = format_dongia;
            TextCol1.Alignment = HorizontalAlignment.Right;
            ts.GridColumnStyles.Add(TextCol1);
            dataGrid1.TableStyles.Add(ts);
		}

		public Color MyGetColorRowCol(int row, int col)
		{
			return Color.Black;
		}

		private void butKetthuc_Click(object sender, System.EventArgs e)
		{
			if (dsxml.HasChanges())
				if (MessageBox.Show("Bạn có muốn cập nhật thay đổi ?",ttb.Msg,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes) butLuu_Click(sender,e);
			this.Close();
		}

		private void butMoi_Click(object sender, System.EventArgs e)
		{
			frmChonmabd f=new frmChonmabd(ttb,i_nhom,s_manhom,(bNam)?s_dutrunam:"");
			f.ShowDialog(this);
			if (f.bOk)
			{
				if (f.dsdm.Tables[0].Select("chon=true").Length>0)
					foreach(DataRow r in f.dsdm.Tables[0].Select("chon=true"))
					{
						sql="mabd="+int.Parse(r["id"].ToString());
						r1=ttb.getrowbyid(ds.Tables[0],sql);
						if (r1==null)
						{
							r2=ttb.getrowbyid(dt,"id="+int.Parse(r["id"].ToString()));
							if (r2!=null)
							{
								r3=dsxml.Tables[0].NewRow();
								r3["mabd"]=r["id"].ToString();
								r3["sttnhom"]=r2["sttnhom"].ToString();
								r3["ma"]=r2["ma"].ToString();
								r3["ten"]=r2["ten"].ToString().Trim()+" "+r2["hamluong"].ToString();
								r3["dang"]=r2["dang"].ToString();
								r3["tennhom"]=r2["tennhom"].ToString();
								r3["tenhang"]=r2["tenhang"].ToString();
								r3["k1"]=0;
                                foreach (DataRow r4 in dtkho.Rows) r3["c" + r4["id"].ToString().Trim()] = 0;
								r3["xuat"]=0;
								r3["l1"]=0;
								r3["d1"]=0;
								r3["l2"]=0;
								r3["d2"]=0;
								r3["tc"]=0;
								r3["nhacc"]=r2["nhacc"].ToString();
								r3["donvi"]=r2["donvi"].ToString();
								r3["sltoithieu"]=r2["sltoithieu"].ToString();
                                r3["dongia"] = r2["dongia"].ToString();
								dsxml.Tables[0].Rows.Add(r3);
							}
						}
					}
			}
		}

		private void butLuu_Click(object sender, System.EventArgs e)
		{
            Cursor = Cursors.WaitCursor;
			foreach(DataRow r in dsxml.Tables[0].Rows)
				ttb.upd_dutruthang(i_manguon,i_nhom,s_mmyy,int.Parse(r["mabd"].ToString()),decimal.Parse(r["k1"].ToString()),0,
					0,0,0,decimal.Parse(r["tc"].ToString()),decimal.Parse(r["xuat"].ToString()),decimal.Parse(r["l1"].ToString()),
					decimal.Parse(r["d1"].ToString()),decimal.Parse(r["l2"].ToString()),decimal.Parse(r["d2"].ToString()),r["nhacc"].ToString(),r["donvi"].ToString(),i_lanthu);
            Cursor = Cursors.Default;
		}

		private void butIn_Click(object sender, System.EventArgs e)
		{
			if (dsxml.HasChanges()) butLuu_Click(sender,e);
            DataSet dst = new DataSet();
            dst = dsxml.Copy();
            dst.Tables[0].Columns.Add("chul1");
            //dst.Tables[0].Columns.Add("chul2");
            dst.Tables[0].Columns.Add("chud1");
            //dst.Tables[0].Columns.Add("chud2");
            if (!chkAll.Checked)
            {
                dst.Clear();
                dst.Merge(dsxml.Tables[0].Select("l1+l2+d1+d2>0"));
            }
            foreach (DataRow r in dst.Tables[0].Select("l1+l2+d1+d2>0"))
            {
                r["chul1"] = doiso.doithapphan(r["l1"].ToString());
                //r["chul2"] = doiso.doithapphan(r["l2"].ToString());
                r["chud1"] = doiso.doithapphan(r["d1"].ToString());
                //r["chud2"] = doiso.doithapphan(r["d2"].ToString());
            }
            if (chkXML.Checked)
            {
                if (!System.IO.Directory.Exists("..\\xml")) System.IO.Directory.CreateDirectory("..\\xml");
                dst.WriteXml("..\\xml\\dutrumua.xml", XmlWriteMode.WriteSchema);
            }
            string tenfile = (i_nhom==1)? "ttb_dutruthang.rpt" : "ttb_dutruthang_nt.rpt";
            if (dst.Tables[0].Rows.Count > 0)
            {
                if (chkXem.Checked)
                {
                    frmReport f1 = new frmReport(ttb, dst.Tables[0],tenfile, tieude.Text, s_tennguon, "", "", "", "", "", "", "",s_mmyy);
                    f1.ShowDialog(this);
                }
                else print.Printer(ttb, dst,tenfile, tieude.Text, s_tennguon, "", "", "", "", "", "", "", s_mmyy, 1, 1);
            }
            else MessageBox.Show("Không có số liệu !", ttb.Msg);
		}
	
		public delegate Color delegateGetColorRowCol(int row, int col);
		public class DataGridColoredTextBoxColumn : DataGridTextBoxColumn
		{
			private delegateGetColorRowCol _getColorRowCol;
			private int _column;
			public DataGridColoredTextBoxColumn(delegateGetColorRowCol getcolorRowCol, int column)
			{
				_getColorRowCol = getcolorRowCol;
				_column = column;
			}
			protected override void Paint(System.Drawing.Graphics g, System.Drawing.Rectangle bounds, System.Windows.Forms.CurrencyManager source, int rowNum, System.Drawing.Brush backBrush, System.Drawing.Brush foreBrush, bool alignToRight)
			{
				try
				{
					foreBrush = new SolidBrush(_getColorRowCol(rowNum, this._column));
					//backBrush = new SolidBrush(Color.GhostWhite);
				}
			
				catch{}
				finally
				{
					base.Paint(g, bounds, source, rowNum, backBrush, foreBrush, alignToRight);
				}
			}
		}

        private void butHuy_Click(object sender, EventArgs e)
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (MessageBox.Show("Đồng ý hủy ?", ttb.Msg, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int i_mabd = int.Parse(dataGrid1[dataGrid1.CurrentCell.RowNumber, 0].ToString());
                        ttb.execute_data("delete from " + user + ".ttb_dutruthang where mmyy='" + s_mmyy + "' and nhom=" + i_nhom + " and mabd=" + i_mabd+" and manguon="+i_manguon+" and lan="+i_lanthu);
                        ttb.delrec(dsxml.Tables[0], "mabd=" + i_mabd);
                        dsxml.AcceptChanges();
                    }
                    catch { }
                }
            }
        }

        private void tieude_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode==Keys.Tab) butIn.Focus();
        }

        private void tim_Enter(object sender, EventArgs e)
        {
            tim.Text = "";
        }

        private void tim_TextChanged(object sender, EventArgs e)
        {
            if (this.ActiveControl == tim) RefreshChildren(tim.Text);
        }

        private void RefreshChildren(string text)
        {
            try
            {
                CurrencyManager cm = (CurrencyManager)BindingContext[dataGrid1.DataSource];
                DataView dv = (DataView)cm.List;
                dv.RowFilter = "ten like '%" + text.Trim() + "%' or ma like '%" + text.Trim() + "%'";
            }
            catch { }
        }
	}
}
