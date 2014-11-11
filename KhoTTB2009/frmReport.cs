using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Reflection;
using System.Runtime.InteropServices;
using Excel;
using LibTTB;
using System.IO;

namespace TTB
{
	/// <summary>
	/// Summary description for Freport.
	/// </summary>
	public class frmReport : System.Windows.Forms.Form
	{
		string s_dirreport="report";
		int i_soluong_le=0,i_dongia_le=0,i_thanhtien_le=0;
		int i_nhom=1;
		Excel.Application oxl;
		Excel._Workbook owb;
		Excel._Worksheet osheet;
		ReportDocument oRpt;
        private LibTTB.AccessData ttb;
		private string ReportFile;
        private System.Data.DataTable dt = null;
        private System.Data.DataSet ds = null;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer Report;
		private string c1,c2,c3,c4,c5,c6,c7,c8,c9,c10,c11,c12,msg="";
		private bool b_bienlai=false;
		public bool bPrinter;
		private System.Windows.Forms.NumericUpDown banin;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button butKetthuc;
		private System.Windows.Forms.Button butIn;
		private System.Windows.Forms.Button butExcel;
        private System.Windows.Forms.Button butPdf;
        private string ExportPath;
        ExportOptions crExportOptions;
        DiskFileDestinationOptions crDiskFileDestinationOptions;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmReport(AccessData acc,System.Data.DataTable ta,string mMsg,string report)
		{
			InitializeComponent();
			dt=ta;ttb=acc;
			msg=mMsg;
			ReportFile=report;
			this.Text=report;
		}

		public frmReport(AccessData acc,System.Data.DataTable ta,string report,string s1,string s2,string s3,string s4,string s5,string s6,string s7,string s8,string s9,string s10)
		{
			InitializeComponent();
			ttb=acc;dt=ta;
			c1=s1;c2=s2;c3=s3;c4=s4;c5=s5;
			c6=s6;c7=s7;c8=s8;c9=s9;c10=s10;
			ReportFile=report;this.Text=report;
			
		}

        public frmReport(AccessData acc, System.Data.DataTable ta, string report, string s1, string s2, string s3, string s4, string s5, string s6, string s7, string s8, string s9, string s10, string s11, string s12)
        {
            InitializeComponent();
            ttb = acc; dt = ta;
            c1 = s1; c2 = s2; c3 = s3; c4 = s4; c5 = s5; c6 = s6;
            c7 = s7; c8 = s8; c9 = s9; c10 = s10; c11 = s11; c12 = s12;
            ReportFile = report; this.Text = report;
        }

        public frmReport(AccessData acc, System.Data.DataSet ta, string report, string s1, string s2, string s3, string s4, string s5, string s6, string s7, string s8, string s9, string s10, string s11, string s12)
        {
            InitializeComponent();
            ttb = acc; ds = ta;
            c1 = s1; c2 = s2; c3 = s3; c4 = s4; c5 = s5; c6 = s6;
            c7 = s7; c8 = s8; c9 = s9; c10 = s10; c11 = s11; c12 = s12;
            ReportFile = report; this.Text = report;
        }

		public frmReport(AccessData acc,System.Data.DataTable ta,string s1,string s2,string report)
		{
			InitializeComponent();
			ttb=acc;
			dt=ta;
			c1=s1;c2=s2;
			b_bienlai=true;
			ReportFile=report;
			this.Text=report;			
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.Report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.banin = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.butKetthuc = new System.Windows.Forms.Button();
            this.butIn = new System.Windows.Forms.Button();
            this.butExcel = new System.Windows.Forms.Button();
            this.butPdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.banin)).BeginInit();
            this.SuspendLayout();
            // 
            // Report
            // 
            this.Report.ActiveViewIndex = -1;
            this.Report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Report.DisplayGroupTree = false;
            this.Report.Location = new System.Drawing.Point(-1, 0);
            this.Report.Name = "Report";
            this.Report.SelectionFormula = "";
            this.Report.Size = new System.Drawing.Size(308, 150);
            this.Report.TabIndex = 0;
            this.Report.ViewTimeSelectionFormula = "";
            // 
            // banin
            // 
            this.banin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banin.Location = new System.Drawing.Point(373, 5);
            this.banin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.banin.Name = "banin";
            this.banin.Size = new System.Drawing.Size(40, 21);
            this.banin.TabIndex = 2;
            this.banin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.banin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.banin_KeyDown);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(305, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Số bản in :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // butKetthuc
            // 
            this.butKetthuc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butKetthuc.Image = ((System.Drawing.Image)(resources.GetObject("butKetthuc.Image")));
            this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butKetthuc.Location = new System.Drawing.Point(585, 4);
            this.butKetthuc.Name = "butKetthuc";
            this.butKetthuc.Size = new System.Drawing.Size(74, 22);
            this.butKetthuc.TabIndex = 5;
            this.butKetthuc.Text = "Kết thúc";
            this.butKetthuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
            // 
            // butIn
            // 
            this.butIn.Image = ((System.Drawing.Image)(resources.GetObject("butIn.Image")));
            this.butIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butIn.Location = new System.Drawing.Point(416, 4);
            this.butIn.Name = "butIn";
            this.butIn.Size = new System.Drawing.Size(51, 22);
            this.butIn.TabIndex = 3;
            this.butIn.Text = "      In";
            this.butIn.Click += new System.EventHandler(this.butIn_Click);
            // 
            // butExcel
            // 
            this.butExcel.Image = ((System.Drawing.Image)(resources.GetObject("butExcel.Image")));
            this.butExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butExcel.Location = new System.Drawing.Point(468, 4);
            this.butExcel.Name = "butExcel";
            this.butExcel.Size = new System.Drawing.Size(60, 22);
            this.butExcel.TabIndex = 4;
            this.butExcel.Text = "      Excel";
            this.butExcel.Click += new System.EventHandler(this.butExcel_Click);
            // 
            // butPdf
            // 
            this.butPdf.Image = ((System.Drawing.Image)(resources.GetObject("butPdf.Image")));
            this.butPdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butPdf.Location = new System.Drawing.Point(529, 4);
            this.butPdf.Name = "butPdf";
            this.butPdf.Size = new System.Drawing.Size(55, 22);
            this.butPdf.TabIndex = 12;
            this.butPdf.Text = "PDF";
            this.butPdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butPdf.UseVisualStyleBackColor = true;
            this.butPdf.Click += new System.EventHandler(this.butPdf_Click);
            // 
            // frmReport
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.butKetthuc;
            this.ClientSize = new System.Drawing.Size(1016, 713);
            this.Controls.Add(this.butPdf);
            this.Controls.Add(this.butExcel);
            this.Controls.Add(this.banin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butKetthuc);
            this.Controls.Add(this.butIn);
            this.Controls.Add(this.Report);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viện phí .NET";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmReport_KeyDown);
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banin)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private void frmReport_Load(object sender, System.EventArgs e)
        {
            this.Report.Size = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            this.Size = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            i_nhom = get_nhomkho();
            i_soluong_le = ttb.d_soluong_le(i_nhom);
            i_dongia_le = ttb.d_dongia_le(i_nhom);
            i_thanhtien_le = ttb.d_thanhtien_le(i_nhom);
            string dir = System.IO.Directory.GetCurrentDirectory();
            ExportPath = "";
            int j = 0;
            for (int i = 0; i < dir.Length; i++)
            {
                if (dir.Substring(i, 1) == "\\") j++;
                if (j == 2) break;
                ExportPath += dir.Substring(i, 1);
            }
            ExportPath += "\\pdf\\";
            if (!System.IO.Directory.Exists(ExportPath)) System.IO.Directory.CreateDirectory(ExportPath);
            PreviewReport();
        }

		private void PreviewReport()
		{
            string s_error="";
			try
			{
                
				oRpt=new ReportDocument();
				if(Directory.Exists("..\\..\\..\\"+s_dirreport)==false)s_dirreport="report";
				oRpt.Load("..\\..\\..\\"+s_dirreport+"\\"+ReportFile,OpenReportMethod.OpenReportByTempCopy);
                if (dt != null)
                {
                    oRpt.SetDataSource(dt);
                }
                else if (ds != null)
                {
                    oRpt.SetDataSource(ds);
                }
                else return;
                s_error = "soyte";
				oRpt.DataDefinition.FormulaFields["soyte"].Text="'"+ttb.Syte+"'";
                s_error = "benhvien";
				oRpt.DataDefinition.FormulaFields["benhvien"].Text="'"+ttb.Tenbv+"'";
                s_error = "c1";
                oRpt.DataDefinition.FormulaFields["c1"].Text = "'" + c1 + "'";
                s_error = "c2";
                oRpt.DataDefinition.FormulaFields["c2"].Text = "'" + c2 + "'";
                s_error = "c3";
                oRpt.DataDefinition.FormulaFields["c3"].Text = "'" + c3 + "'";
                s_error = "c4";
                oRpt.DataDefinition.FormulaFields["c4"].Text = "'" + c4 + "'";
                s_error = "c5";
                oRpt.DataDefinition.FormulaFields["c5"].Text = "'" + c5 + "'";
                s_error = "c6";
                oRpt.DataDefinition.FormulaFields["c6"].Text = "'" + c6 + "'";
                s_error = "c7";
                oRpt.DataDefinition.FormulaFields["c7"].Text = "'" + c7 + "'";
                s_error = "c8";
                oRpt.DataDefinition.FormulaFields["c8"].Text = "'" + c8 + "'";
                s_error = "c9";
                oRpt.DataDefinition.FormulaFields["c9"].Text = "'" + c9 + "'";
                s_error = "c10";
                oRpt.DataDefinition.FormulaFields["c10"].Text = "'" + c10 + "'";
                s_error = "giamdoc";
                oRpt.DataDefinition.FormulaFields["giamdoc"].Text = "'" + ttb.Giamdoc(-2) + "'";
                s_error = "phutrach";
                oRpt.DataDefinition.FormulaFields["phutrach"].Text = "'" + ttb.Phutrach(i_nhom) + "'";
                s_error = "thongke";
                oRpt.DataDefinition.FormulaFields["thongke"].Text = "'" + ttb.Thongke(i_nhom) + "'";
                s_error = "ketoan";
                oRpt.DataDefinition.FormulaFields["ketoan"].Text = "'" + ttb.Ketoan(i_nhom) + "'";
                s_error = "thukho";
                oRpt.DataDefinition.FormulaFields["thukho"].Text = "'" + ttb.Thukho(i_nhom) + "'";
                s_error = "l_soluong";
                oRpt.DataDefinition.FormulaFields["l_soluong"].Text = i_soluong_le.ToString();
                s_error = "l_dongia";
                oRpt.DataDefinition.FormulaFields["l_dongia"].Text = i_dongia_le.ToString();
                s_error = "l_thanhtien";
                oRpt.DataDefinition.FormulaFields["l_thanhtien"].Text = i_thanhtien_le.ToString();				
				Report.ReportSource=oRpt;
			}
			catch (Exception e)
			{
				MessageBox.Show (((s_error.Trim()=="")?"Thiếu fomular: "+s_error:"")+"\n The following error was discovered: '"+e.Message+"'. It was occured in '"+e.StackTrace+"'", "Report Viewer",MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
		}

		private void butKetthuc_Click(object sender, System.EventArgs e)
		{
			bPrinter=false;
            oRpt.Close(); oRpt.Dispose();
			this.Close();
		}

		private void butIn_Click(object sender, System.EventArgs e)
		{
			Cursor=Cursors.WaitCursor;
			bPrinter=true;
			try
			{
				oRpt.PrintToPrinter(Convert.ToInt16(banin.Value),false,0,0);
			}
			catch(Exception ex){MessageBox.Show(ex.Message);}
			Cursor=Cursors.Default;
            oRpt.Close(); oRpt.Dispose();
			this.Close();
		}

		private void frmReport_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
                case Keys.F5: butPdf_Click(sender, e); break;
				case Keys.F9: butIn_Click(sender,e);break;
				case Keys.F7: butExcel_Click(sender,e);break;
				case Keys.F10: butKetthuc_Click(sender,e);break;
			}
		}		
		//binh
		
		private int get_nhomkho()
		{
			DataSet lds=new DataSet();
			lds.ReadXml("..\\..\\..\\xml\\ttb_nhomkholog.xml");
			int i_nhomkho=1;
			foreach(DataRow r in lds.Tables[0].Rows)
			{
				i_nhomkho=int.Parse(r["nhomkho"].ToString());
				break;
			}
			lds.Dispose();
			return i_nhomkho;
		}

		private void butExcel_Click(object sender, System.EventArgs e)
		{
			ttb.check_process_Excel();
            string tenfile = "";
            if (dt == null)
            {
                if (ds != null)
                {
                    tenfile=ttb.Export_Excel(ds, ReportFile.Substring(0, ReportFile.Length - 4));
                }
                else return;
            }
            else
            {
                tenfile = ttb.Export_Excel(dt, ReportFile.Substring(0, ReportFile.Length - 4));
            }
            if (tenfile == "") { return; }
			oxl=new Excel.Application();
			owb=(Excel._Workbook)(oxl.Workbooks.Open(tenfile,Missing.Value,Missing.Value,Missing.Value,Missing.Value,Missing.Value,Missing.Value,Missing.Value,Missing.Value,Missing.Value,Missing.Value,Missing.Value,Missing.Value));
			osheet=(Excel._Worksheet)owb.ActiveSheet;
			oxl.ActiveWindow.DisplayGridlines=true;
			oxl.ActiveWindow.DisplayZeros=false;
			osheet.PageSetup.Orientation=XlPageOrientation.xlLandscape;
			osheet.PageSetup.PaperSize=XlPaperSize.xlPaperA4;
			osheet.PageSetup.LeftMargin=20;
			osheet.PageSetup.RightMargin=20;
			osheet.PageSetup.TopMargin=30;
			osheet.PageSetup.CenterFooter="Trang : &P/&N";
			oxl.Visible=true;
		}

		private void banin_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");
		}
		#region binh_writemenubar
		//copy theo Tan
		private void f_WriteMenu(MainMenu v_m)
		{
			try
			{
				DataSet ads = new DataSet();
				ads.Tables.Add();
				ads.Tables[0].Columns.Add("TEN");
				string t="";
				for(int i=0;i<v_m.MenuItems.Count-3;i++)
				{
					for(int j=0;j<v_m.MenuItems[i].MenuItems.Count;j++)
					{
						if((v_m.MenuItems[i].MenuItems[j].Text.Trim()!="-")&&(v_m.MenuItems[i].MenuItems[j].Text.Trim().ToUpper().IndexOf("LOG OFF")<0)&&(v_m.MenuItems[i].MenuItems[j].MenuItems.Count<=0))
						{
							t=v_m.MenuItems[i].MenuItems[j].Text.Trim().Replace("&","");
							try
							{
								t=t.Substring(t.IndexOf(".")+1).Trim();
							}
							catch
							{
							}
							if(t!="")
								ads.Tables[0].Rows.Add(new string[] {t});
						}
						else
						{
							for(int k=0;k<v_m.MenuItems[i].MenuItems[j].MenuItems.Count;k++)
							{
								if((v_m.MenuItems[i].MenuItems[j].MenuItems[k].Text.Trim()!="-")&&(v_m.MenuItems[i].MenuItems[j].MenuItems[k].Text.Trim().ToUpper().IndexOf("LOG OFF")<0)&&(v_m.MenuItems[i].MenuItems[j].MenuItems[k].MenuItems.Count<=0))
								{
									t=v_m.MenuItems[i].MenuItems[j].MenuItems[k].Text.Trim().Replace("&","");
									try
									{
										t=t.Substring(t.IndexOf(".")+1).Trim();
									}
									catch
									{
									}
									if(t!="")
										ads.Tables[0].Rows.Add(new string[] {t});
								}
								else
								{
									for(int l=0;l<v_m.MenuItems[i].MenuItems[j].MenuItems[k].MenuItems.Count;k++)
									{
										if((v_m.MenuItems[i].MenuItems[j].MenuItems[k].MenuItems[l].Text.Trim()!="-")&&(v_m.MenuItems[i].MenuItems[j].MenuItems[k].MenuItems[l].Text.Trim().ToUpper().IndexOf("LOG OFF")<0)&&(v_m.MenuItems[i].MenuItems[j].MenuItems[k].MenuItems[l].MenuItems.Count<=0))
										{
											t=v_m.MenuItems[i].MenuItems[j].MenuItems[k].MenuItems[l].Text.Trim().Replace("&","");
											try
											{
												t=t.Substring(t.IndexOf(".")+1).Trim();
											}
											catch
											{
											}
											if(t!="")
												ads.Tables[0].Rows.Add(new string[] {t});
										}
										else
										{
										}
									}
								}
							}
						}
					}
				}
				ads.WriteXml("..//..//..//xml//d_menubar.xml");
			}
			catch
			{
			}
		}
		private void get_nhomkho(int i_userid)
		{
			string sql="select nhomkho from "+ttb.user+".d_dlogin where id='"+i_userid+"'";
			DataSet lds=ttb.get_data(sql);
			lds.WriteXml("..\\..\\..\\xml\\d_nhomkholog.xml",XmlWriteMode.WriteSchema);
		}
		#endregion

        private void butPdf_Click(object sender, EventArgs e)
        {
            string tenfile = ReportFile.ToLower().Replace(".rpt", "");
            tenfile = ExportPath + tenfile + ".pdf";
            crDiskFileDestinationOptions = new DiskFileDestinationOptions();
            crExportOptions = oRpt.ExportOptions;
            crDiskFileDestinationOptions.DiskFileName = tenfile;
            crExportOptions.DestinationOptions = crDiskFileDestinationOptions;
            crExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
            crExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
            oRpt.Export();
            try
            {
                string filerun = "AcroRd32.exe", arg = tenfile;
                if (System.IO.File.Exists(arg))
                {
                    backup f = new backup(filerun, arg, true);
                    f.Launch();
                }
            }
            catch
            {
                MessageBox.Show("Tập tin :" + tenfile);
            }
        }
	}
}