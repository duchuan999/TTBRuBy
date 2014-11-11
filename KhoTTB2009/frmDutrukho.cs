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
	/// Summary description for frmDutrukho.
	/// </summary>
	public class frmDutrukho : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button butIn;
		private System.Windows.Forms.Button butKetthuc;
		private System.Windows.Forms.Button butBoqua;
		private System.Windows.Forms.Button butLuu;
		private System.Windows.Forms.Button butMoi;
        private LibTTB.AccessData ttb;
        private bool bFound = false, bNam;
		private int i_makho,i_nhom,i_manguon,i_lanthu;
        private string s_mmyy, sql, format_soluong, s_tenkho, user, xxx, xxxt, s_mmyyt, s_manhom, format_dongia, s_tennguon, s_dutrunam;
		private DataSet ds=new DataSet();
		private DataSet dsxml=new DataSet();
		private DataTable dt=new DataTable();
		private DataSet dstt=new DataSet();
        private DataTable tmp = new DataTable();
		private DataRow r1,r2,r3;
		private DataRow [] dr,dr1;
        private CheckBox chkXML;
        private Button butHuy;
        private CheckBox chkNcc;
        private CheckBox chkAll;
        private dichso.numbertotext doiso = new dichso.numbertotext();
        private Label label1;
        private TextBox tieude;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmDutrukho(AccessData acc,int makho,string mmyy,string tenkho,int nhom,string _manhom,int _manguon,string _tennguon,int lanthu)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            ttb = acc; i_makho = makho; s_mmyy = mmyy; s_tenkho = tenkho; i_nhom = nhom; s_manhom = _manhom;
            i_manguon = _manguon; s_tennguon = _tennguon; i_lanthu = lanthu;
            if (s_mmyy.Substring(0, 2) == "20")
                this.Text = "Bảng dự trù "+tenkho+" lần thứ " + i_lanthu.ToString() + " năm " + s_mmyy + ((s_tennguon != "") ? " ( " + s_tennguon.Trim() + " )" : "");
            else
                this.Text = "Bảng dự trù "+tenkho+" lần thứ " + i_lanthu.ToString() + " tháng " + s_mmyy.Substring(0, 2) + " năm 20" + s_mmyy.Substring(2) + ((s_tennguon != "") ? " ( " + s_tennguon.Trim() + " )" : "");

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDutrukho));
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.butIn = new System.Windows.Forms.Button();
            this.butKetthuc = new System.Windows.Forms.Button();
            this.butBoqua = new System.Windows.Forms.Button();
            this.butLuu = new System.Windows.Forms.Button();
            this.butMoi = new System.Windows.Forms.Button();
            this.chkXML = new System.Windows.Forms.CheckBox();
            this.butHuy = new System.Windows.Forms.Button();
            this.chkNcc = new System.Windows.Forms.CheckBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tieude = new System.Windows.Forms.TextBox();
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
            this.dataGrid1.Size = new System.Drawing.Size(776, 482);
            this.dataGrid1.TabIndex = 5;
            // 
            // butIn
            // 
            this.butIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butIn.Location = new System.Drawing.Point(457, 495);
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
            this.butKetthuc.Location = new System.Drawing.Point(518, 495);
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
            this.butBoqua.Location = new System.Drawing.Point(396, 495);
            this.butBoqua.Name = "butBoqua";
            this.butBoqua.Size = new System.Drawing.Size(60, 25);
            this.butBoqua.TabIndex = 2;
            this.butBoqua.Text = "&Bỏ qua";
            // 
            // butLuu
            // 
            this.butLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butLuu.Location = new System.Drawing.Point(275, 495);
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
            this.butMoi.Location = new System.Drawing.Point(214, 495);
            this.butMoi.Name = "butMoi";
            this.butMoi.Size = new System.Drawing.Size(60, 25);
            this.butMoi.TabIndex = 0;
            this.butMoi.Text = "&Mới";
            this.butMoi.Click += new System.EventHandler(this.butMoi_Click);
            // 
            // chkXML
            // 
            this.chkXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkXML.AutoSize = true;
            this.chkXML.Location = new System.Drawing.Point(79, 498);
            this.chkXML.Name = "chkXML";
            this.chkXML.Size = new System.Drawing.Size(85, 17);
            this.chkXML.TabIndex = 6;
            this.chkXML.Text = "Xuất ra XML";
            this.chkXML.UseVisualStyleBackColor = true;
            // 
            // butHuy
            // 
            this.butHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butHuy.Location = new System.Drawing.Point(336, 495);
            this.butHuy.Name = "butHuy";
            this.butHuy.Size = new System.Drawing.Size(60, 25);
            this.butHuy.TabIndex = 7;
            this.butHuy.Text = "&Hủy";
            this.butHuy.Click += new System.EventHandler(this.butHuy_Click);
            // 
            // chkNcc
            // 
            this.chkNcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkNcc.AutoSize = true;
            this.chkNcc.Location = new System.Drawing.Point(639, 498);
            this.chkNcc.Name = "chkNcc";
            this.chkNcc.Size = new System.Drawing.Size(145, 17);
            this.chkNcc.TabIndex = 8;
            this.chkNcc.Text = "Kèm nhóm nhà cung cấp";
            this.chkNcc.UseVisualStyleBackColor = true;
            // 
            // chkAll
            // 
            this.chkAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(8, 498);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(65, 17);
            this.chkAll.TabIndex = 10;
            this.chkAll.Text = "In tất cả";
            this.chkAll.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tiêu đề :";
            // 
            // tieude
            // 
            this.tieude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tieude.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tieude.Location = new System.Drawing.Point(57, 3);
            this.tieude.Name = "tieude";
            this.tieude.Size = new System.Drawing.Size(729, 21);
            this.tieude.TabIndex = 12;
            this.tieude.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tieude_KeyDown);
            // 
            // frmDutrukho
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tieude);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.chkNcc);
            this.Controls.Add(this.butHuy);
            this.Controls.Add(this.chkXML);
            this.Controls.Add(this.butIn);
            this.Controls.Add(this.butKetthuc);
            this.Controls.Add(this.butBoqua);
            this.Controls.Add(this.butLuu);
            this.Controls.Add(this.butMoi);
            this.Controls.Add(this.dataGrid1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDutrukho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng dự trù";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDutrukho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void frmDutrukho_Load(object sender, System.EventArgs e)
		{
			//if (Screen.PrimaryScreen.WorkingArea.Width > 800) this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            tieude.Text = this.Text.ToUpper();
			Cursor=Cursors.WaitCursor;
            user = ttb.user; xxx = user;// +s_mmyy;
            bNam = s_mmyy.Substring(0, 2) == "20";
            s_dutrunam = (bNam) ? ttb.dutrunam_nhomin(i_nhom) : "";
            if (bNam)
            {
                foreach (DataRow r in ttb.get_data("select * from " + user + ".ttb_tables where substr(mmyy,3,2)='" + s_mmyy.Substring(2) + "' order by mmyy").Tables[0].Rows)
                {
                    s_mmyyt = r["mmyy"].ToString();
                    xxxt = user;// +s_mmyyt;
                    break;
                }
            }
            else
            {
                if (ttb.bDutrumua_thangtruoc(i_nhom))
                {
                    s_mmyyt = ttb.Mmyy_truoc(s_mmyy); xxxt = user;// +s_mmyyt;
                }
                else
                {
                    s_mmyyt = s_mmyy; xxxt = xxx;
                }
            }
            bFound = ttb.bMmyy(s_mmyyt);
            if (bFound) tmp = ttb.get_data("select * from " + xxxt + ".ttb_theodoi order by id desc").Tables[0];
			format_soluong=ttb.format_soluong(i_nhom);
            format_dongia = ttb.format_dongia(i_nhom);
			dstt.ReadXml("..\\..\\..\\xml\\ttb_sttmua.xml");

			sql="select a.*,b.stt as sttnhom,b.ten as tennhom,c.ten as tenhang,d.ten as nhacc ";
			sql+=" from "+user+".ttb_dmbd a inner join ";
			if (i_nhom==1) sql+=user+".ttb_dmnhom b ";
			else sql+=user+".ttb_dmloai b ";
			if (i_nhom==1) sql+=" on a.manhom=b.id ";
			else sql+="on a.maloai=b.id ";
            sql += " inner join " + user + ".ttb_dmhang c on a.mahang=c.id ";
            sql += " left join " + user + ".ttb_dmnx d on a.madv=d.id ";
            sql+=" where a.nhom="+i_nhom;
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
			sql="update "+user+".ttb_dutrukho set dau=0,nhap=0,xuat=0,ton=0,tc=0,tutruc=0 where makho="+i_makho+" and mmyy='"+s_mmyy+"' and lan="+i_lanthu;
            if (i_manguon != -1) sql += " and manguon=" + i_manguon;
			ttb.execute_data(sql);
            sql = "select a.*,b.ma,trim(b.ten)||' '||b.hamluong as ten,b.dang,c.stt as sttnhom,c.ten as tennhom,";
            sql+=" d.ten as tenhang from " + user + ".ttb_dutrukho a," + user + ".ttb_dmbd b," + user + ".ttb_dmnhom c," + user + ".ttb_dmhang d";
			sql+=" where a.mabd=b.id and b.manhom=c.id and b.mahang=d.id and a.makho="+i_makho+" and a.mmyy='"+s_mmyy+"' and a.lan="+i_lanthu;
            if (i_manguon != -1) sql += " and a.manguon=" + i_manguon;
            if (s_dutrunam != "") sql += " and c.nhomin in (" + s_dutrunam + ")";
			sql+=" order by c.stt,b.ma";
			ds=ttb.get_data(sql);
			DataColumn dc=new DataColumn();
			dc.ColumnName="xuatmax";
			dc.DataType=Type.GetType("System.Decimal");
			ds.Tables[0].Columns.Add(dc);
			dc=new DataColumn();
			dc.ColumnName="ghichu";
			dc.DataType=Type.GetType("System.String");
			ds.Tables[0].Columns.Add(dc);
			foreach(DataRow r in ds.Tables[0].Rows)
			{
				if (r["nhacc"].ToString().Trim()=="")
				{
					r1=ttb.getrowbyid(dt,"id="+int.Parse(r["mabd"].ToString()));
					if (r1!=null) 
					{
						r["nhacc"]=r1["nhacc"].ToString();
						r["donvi"]=r1["donvi"].ToString();
					}
				}
				r["xuatmax"]=0;
				r["ghichu"]="";
			}
            if (bNam)
                for (int i = int.Parse(s_mmyyt.Substring(0, 2)); i < 13; i++) get_tonkho(i.ToString().PadLeft(2, '0') + s_mmyy.Substring(2));
            else
                get_tonkho(s_mmyyt);
            if (bNam) xuat_n("12" + s_mmyy.Substring(0, 2));
            else xuat_n(s_mmyyt);
			decimal sl;
			foreach(DataRow r in ds.Tables[0].Rows)
			{
				if (decimal.Parse(r["xuat"].ToString())>decimal.Parse(r["xuatmax"].ToString()))
				{
					sl=decimal.Parse(r["xuat"].ToString());
					r["xuatmax"]=sl;
					r["ghichu"]=sl.ToString(format_soluong).Trim()+" T"+((bNam)?"12":s_mmyy.Substring(0,2));
				}																			   
			}
			dsxml=ds.Copy();
			dsxml.Clear();
			string stt="";
			foreach(DataRow r1 in dstt.Tables[0].Select("stt<>0","stt")) stt+=r1["ma"].ToString().Trim()+",";
			stt+="ten,";
			stt=stt.Substring(0,stt.Length-1);
			dsxml.Merge(ds.Tables[0].Select("true",stt));
			dsxml.AcceptChanges();
			dataGrid1.DataSource=dsxml.Tables[0];
		}

		private void get_tonkho(string mmyyt)
		{
            if (!ttb.bMmyy(mmyyt)) return;
            string xxxt = user;// +mmyyt;
			sql="select '0' as loai,a.mabd,sum(a.tondau) as tondau,sum(a.slnhap) as nhap,sum(a.slxuat) as xuat,";
            sql+=" sum(a.tondau+a.slnhap-a.slxuat) as ton from "+xxxt+".ttb_tonkhoth a,"+user+".ttb_dmbd b,"+user+".ttb_dmnhom c";
			sql+=" where a.mmyy='"+mmyyt+"' and a.mabd=b.id and b.manhom=c.id and a.makho="+i_makho;
            if (i_manguon != -1) sql += " and a.manguon=" + i_manguon;
            if (s_dutrunam != "") sql += " and c.nhomin in (" + s_dutrunam + ")";
			sql+=" group by a.mabd";
			sql+=" union all ";
            sql += " select '1' as loai,a.mabd,sum(a.tondau) as tondau,sum(0) as nhap,sum(0) as xuat,";
            sql+="sum(a.tondau+a.slnhap-a.slxuat) as ton from " + xxxt + ".ttb_tutructh a,"+user+".ttb_dmbd b,"+user+".ttb_dmnhom c";
            sql += " where a.mmyy='" + mmyyt + "' and a.mabd=b.id and b.manhom=c.id and a.makho=" + i_makho;
            if (s_dutrunam != "") sql += " and c.nhomin in (" + s_dutrunam + ")";
            if (i_manguon != -1) sql += " and a.manguon=" + i_manguon;
			sql+=" group by a.mabd";
			string fie="";
			foreach(DataRow r in ttb.get_data(sql).Tables[0].Rows)
			{
				fie=(r["loai"].ToString()=="0")?"ton":"tutruc";
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
                        r3["dau"] = r["tondau"].ToString();
						r3["nhap"]=r["nhap"].ToString();
						r3["xuat"]=r["xuat"].ToString();
						r3["ton"]=0;
						r3["tutruc"]=0;
						r3["xuatmax"]=0;
						r3["ghichu"]="";
						r3["l1"]=0;
						r3["d1"]=0;
						r3["l2"]=0;
						r3["d2"]=0;
						r3[fie]=(r["ton"].ToString());
                        r3["tc"] = (r["ton"].ToString());
						r3["nhacc"]=r2["nhacc"].ToString();
						r3["donvi"]=r2["donvi"].ToString();
                        dr1 = tmp.Select("mabd=" + int.Parse(r["mabd"].ToString()), "id desc");
                        r3["dongia"] = (dr1.Length > 0) ? decimal.Parse(dr1[0]["giamua"].ToString()) : 0;
						ds.Tables[0].Rows.Add(r3);
					}
				}
				else
				{
					dr=ds.Tables[0].Select(sql);
					if (dr.Length>0) 
					{
						dr[0][fie]=decimal.Parse(dr[0][fie].ToString())+decimal.Parse(r["ton"].ToString());
                        if (s_mmyyt==mmyyt)
                            dr[0]["dau"] = decimal.Parse(dr[0]["dau"].ToString()) + decimal.Parse(r["tondau"].ToString());						
						dr[0]["nhap"]=decimal.Parse(dr[0]["nhap"].ToString())+decimal.Parse(r["nhap"].ToString());
						dr[0]["xuat"]=decimal.Parse(dr[0]["xuat"].ToString())+decimal.Parse(r["xuat"].ToString());
                        if (fie == "ton") dr[0][fie] = decimal.Parse(dr[0]["dau"].ToString()) + decimal.Parse(dr[0]["nhap"].ToString()) - decimal.Parse(dr[0]["xuat"].ToString());
                        dr[0]["tc"] = decimal.Parse(dr[0]["ton"].ToString()) + decimal.Parse(dr[0]["tutruc"].ToString());
						r2=ttb.getrowbyid(dt,"id="+int.Parse(r["mabd"].ToString()));
						if (r2!=null)
						{
							if (r2["nhacc"].ToString()!="") dr[0]["nhacc"]=r2["nhacc"].ToString();
							if (r2["donvi"].ToString()!="") dr[0]["donvi"]=r2["donvi"].ToString();
						}
                        if (decimal.Parse(dr[0]["dongia"].ToString()) == 0)
                        {
                            dr1 = tmp.Select("mabd=" + int.Parse(r["mabd"].ToString()), "id desc");
                            dr[0]["dongia"] = (dr1.Length > 0) ? decimal.Parse(dr1[0]["giamua"].ToString()) : 0;
                        }
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
			
			TextCol1=new DataGridColoredTextBoxColumn(de, 0);
			TextCol1.MappingName = "ten";
			TextCol1.HeaderText = "Tên vật tư";
			TextCol1.Width = 200;
			ts.GridColumnStyles.Add(TextCol1);
			dataGrid1.TableStyles.Add(ts);

			TextCol1=new DataGridColoredTextBoxColumn(de, 1);
			TextCol1.MappingName = "donvi";
			TextCol1.HeaderText = "Đóng gói";
			TextCol1.Width = 60;
			ts.GridColumnStyles.Add(TextCol1);
			dataGrid1.TableStyles.Add(ts);

			TextCol1=new DataGridColoredTextBoxColumn(de, 2);
			TextCol1.MappingName = "dang";
			TextCol1.HeaderText = "ĐVT";
			TextCol1.Width = 40;
			TextCol1.ReadOnly=true;
			ts.GridColumnStyles.Add(TextCol1);
			dataGrid1.TableStyles.Add(ts);

			TextCol1=new DataGridColoredTextBoxColumn(de, 3);
			TextCol1.MappingName = "tenhang";
			TextCol1.HeaderText = "Hãng SX";
			TextCol1.Width = 150;
			TextCol1.ReadOnly=true;
			ts.GridColumnStyles.Add(TextCol1);
			dataGrid1.TableStyles.Add(ts);

            TextCol1 = new DataGridColoredTextBoxColumn(de, 4);
            TextCol1.MappingName = "dau";
            TextCol1.HeaderText = "Tồn đầu";
            TextCol1.Width = 60;
            TextCol1.ReadOnly = true;
            TextCol1.Format = format_soluong;
            TextCol1.Alignment = HorizontalAlignment.Right;
            ts.GridColumnStyles.Add(TextCol1);
            dataGrid1.TableStyles.Add(ts);

			TextCol1=new DataGridColoredTextBoxColumn(de, 5);
			TextCol1.MappingName = "nhap";
			TextCol1.HeaderText = "Nhập";
			TextCol1.Width = 60;
			TextCol1.ReadOnly=true;
			TextCol1.Format=format_soluong;
			TextCol1.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol1);
			dataGrid1.TableStyles.Add(ts);

			TextCol1=new DataGridColoredTextBoxColumn(de, 6);
			TextCol1.MappingName = "xuat";
			TextCol1.HeaderText = "Xuất";
			TextCol1.Width = 60;
			TextCol1.ReadOnly=true;
			TextCol1.Format=format_soluong;
			TextCol1.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol1);
			dataGrid1.TableStyles.Add(ts);

			TextCol1=new DataGridColoredTextBoxColumn(de, 7);
			TextCol1.MappingName = "ton";
			TextCol1.HeaderText = "Tồn kho";
			TextCol1.Width = 60;
			TextCol1.ReadOnly=true;
			TextCol1.Format=format_soluong;
			TextCol1.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol1);
			dataGrid1.TableStyles.Add(ts);
	
			TextCol1=new DataGridColoredTextBoxColumn(de, 8);
			TextCol1.MappingName = "tutruc";
			TextCol1.HeaderText = "Tủ trực";
			TextCol1.Width = 60;
			TextCol1.ReadOnly=true;
			TextCol1.Format=format_soluong;
			TextCol1.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol1);
			dataGrid1.TableStyles.Add(ts);

			TextCol1=new DataGridColoredTextBoxColumn(de, 9);
			TextCol1.MappingName = "tc";
			TextCol1.HeaderText = "Tổng tồn";
			TextCol1.Width = 60;
			TextCol1.ReadOnly=true;
			TextCol1.Format=format_soluong;
			TextCol1.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol1);
			dataGrid1.TableStyles.Add(ts);

            TextCol1 = new DataGridColoredTextBoxColumn(de,10);
            TextCol1.MappingName = "dongia";
            TextCol1.HeaderText = "Đơn giá";
            TextCol1.Width = 80;            
            TextCol1.Format = format_dongia;
            TextCol1.Alignment = HorizontalAlignment.Right;
            ts.GridColumnStyles.Add(TextCol1);
            dataGrid1.TableStyles.Add(ts);

			TextCol1=new DataGridColoredTextBoxColumn(de,11);
			TextCol1.MappingName = "ghichu";
			TextCol1.HeaderText = "Xuất nhiều nhất";
			TextCol1.Width = 100;
			TextCol1.ReadOnly=true;
			ts.GridColumnStyles.Add(TextCol1);
			dataGrid1.TableStyles.Add(ts);

			TextCol1=new DataGridColoredTextBoxColumn(de, 12);
			TextCol1.MappingName = "l1";
			TextCol1.HeaderText = "Dự trù "+i_lanthu.ToString();
			TextCol1.Width = 60;
			TextCol1.Format=format_soluong;
			TextCol1.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol1);
			dataGrid1.TableStyles.Add(ts);

			TextCol1=new DataGridColoredTextBoxColumn(de, 13);
			TextCol1.MappingName = "d1";
			TextCol1.HeaderText = "Duyệt "+i_lanthu.ToString();
			TextCol1.Width = 60;
			TextCol1.Format=format_soluong;
			TextCol1.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol1);
			dataGrid1.TableStyles.Add(ts);

    		TextCol1=new DataGridColoredTextBoxColumn(de, 14);
			TextCol1.MappingName = "nhacc";
			TextCol1.HeaderText = "Nhà cung cấp";
			TextCol1.Width = 200;
			ts.GridColumnStyles.Add(TextCol1);
			dataGrid1.TableStyles.Add(ts);

            TextCol1 = new DataGridColoredTextBoxColumn(de, 15);
            TextCol1.MappingName = "mabd";
            TextCol1.HeaderText = "";
            TextCol1.Width = 0;
            ts.GridColumnStyles.Add(TextCol1);
            dataGrid1.TableStyles.Add(ts);
		}

		public Color MyGetColorRowCol(int row, int col)
		{
			if (col==11) return Color.Blue;
			else return Color.Black;
		}

		private void butKetthuc_Click(object sender, System.EventArgs e)
		{
			if (dsxml.HasChanges())
				if (MessageBox.Show("Bạn có muốn cập nhật thay đổi ?",ttb.Msg,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes) butLuu_Click(sender,e);
			this.Close();
		}

		private void butMoi_Click(object sender, System.EventArgs e)
		{
			frmChonmabd f=new frmChonmabd(ttb,i_nhom,s_manhom,s_dutrunam);
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
                                r3["dau"] = 0;
								r3["nhap"]=0;
								r3["xuat"]=0;
								r3["ton"]=0;
								r3["tutruc"]=0;
								r3["tc"]=0;
								r3["xuatmax"]=0;
								r3["ghichu"]="";
								r3["l1"]=0;
								r3["d1"]=0;
								r3["l2"]=0;
								r3["d2"]=0;
								r3["tc"]=0;
                                if (bFound)
                                {
                                    dr1 = tmp.Select("mabd=" + int.Parse(r["id"].ToString()), "id desc");
                                    r3["dongia"] = (dr1.Length > 0) ? decimal.Parse(dr1[0]["giamua"].ToString()) : 0;
                                }
                                else r3["dongia"] = 0;
								r3["nhacc"]=r2["nhacc"].ToString();
								r3["donvi"]=r2["donvi"].ToString();
								dsxml.Tables[0].Rows.Add(r3);
							}
						}
					}
			}
		}

		private void butLuu_Click(object sender, System.EventArgs e)
		{
            Cursor = Cursors.WaitCursor;
            dsxml.AcceptChanges();
			foreach(DataRow r in dsxml.Tables[0].Rows)
				ttb.upd_dutrukho(i_manguon,i_makho,s_mmyy,int.Parse(r["mabd"].ToString()),decimal.Parse(r["dau"].ToString()),decimal.Parse(r["nhap"].ToString()),decimal.Parse(r["xuat"].ToString()),
					decimal.Parse(r["ton"].ToString()),decimal.Parse(r["tutruc"].ToString()),decimal.Parse(r["tc"].ToString()),decimal.Parse(r["dongia"].ToString()),
					decimal.Parse(r["l1"].ToString()),decimal.Parse(r["d1"].ToString()),decimal.Parse(r["l2"].ToString()),decimal.Parse(r["d2"].ToString()),r["nhacc"].ToString(),r["donvi"].ToString(),i_lanthu);
            Cursor = Cursors.Default;
            butIn.Focus();
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
                dst.WriteXml("..\\xml\\dutrukho.xml", XmlWriteMode.WriteSchema);
            }
            if (dst.Tables[0].Rows.Count > 0)
            {
                frmReport f1 = new frmReport(ttb, dst.Tables[0], (bNam) ? "ttb_dutrukho_nam.rpt" : "ttb_dutrukho.rpt", tieude.Text, s_tennguon, "", "", "", "", "", "", "", "");
                f1.ShowDialog(this);
                f1.Close();
                f1.Dispose();
                if (chkNcc.Checked)
                {
                    frmReport f2 = new frmReport(ttb, dst.Tables[0], (bNam)?"ttb_dutrukho_ncc_nam.rpt":"ttb_dutrukho_ncc.rpt", tieude.Text, s_tennguon, "", "", "", "", "", "", "", "");
                    f2.ShowDialog(this);
                    f2.Close();
                    f2.Dispose();
                }
            }
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

		private void xuat_n(string s_mmyyt)
		{
            if (!ttb.bMmyy(s_mmyyt)) return;
			string mmyy="",str="";
			decimal sl=0;
			for(int i=1;i<int.Parse(s_mmyyt.Substring(0,2));i++)
			{
				mmyy=i.ToString().PadLeft(2,'0')+s_mmyy.Substring(2,2);
                if (ttb.bMmyy(mmyy))
                {                    
                    sql = "select a.mabd,sum(a.slxuat) as soluong from " + user +  ".ttb_tonkhoth a,"+user+".ttb_dmbd b,"+user+".ttb_dmnhom c";
                    sql += " where a.mmyy='"+mmyy+"' and a.mabd=b.id and b.manhom=c.id and a.makho=" + i_makho;
                    if (i_manguon != -1) sql += " and a.manguon=" + i_manguon;
                    if (s_dutrunam != "") sql += " and c.nhomin in (" + s_dutrunam + ")";
                    sql+=" group by a.mabd";
                    foreach (DataRow r in ttb.get_data(sql).Tables[0].Rows)
                    {
                        str = "mabd=" + int.Parse(r["mabd"].ToString());
                        r1 = ttb.getrowbyid(ds.Tables[0], str);
                        if (r1 != null)
                        {
                            if (decimal.Parse(r["soluong"].ToString()) > decimal.Parse(r1["xuatmax"].ToString()))
                            {
                                sl = decimal.Parse(r["soluong"].ToString());
                                r1["xuatmax"] = r["soluong"].ToString();
                                r1["ghichu"] = sl.ToString(format_soluong).Trim() + " T" + i.ToString().PadLeft(2, '0');
                            }
                        }
                    }
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
                        int i_mabd = int.Parse(dataGrid1[dataGrid1.CurrentCell.RowNumber, 15].ToString());
                        ttb.execute_data("delete from " + user + ".ttb_dutrukho where mmyy='" + s_mmyy + "' and makho=" + i_makho + " and mabd=" + i_mabd+" and manguon="+i_manguon+" and lan="+i_lanthu);
                        ttb.delrec(dsxml.Tables[0], "mabd=" + i_mabd);
                        dsxml.AcceptChanges();
                    }
                    catch { }
                }
            }
        }

        private void tieude_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab) butIn.Focus();
        }
	}
}
