using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Duoc2009.Danhmuc;
using LibTTB;

namespace TTB
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmMain : System.Windows.Forms.Form
	{
        private AccessData ttb = null;//new AccessData();
		private string s_userid="",s_right="",s_mmyy,s_ngay,s_makho,s_makp,s_manhom,s_loaint,s_loaikhac,user;
        public static string link = "";
		private int i_userid=0,i_nhomkho,i_loaikho;
		private bool b_giaban,b_admin;
		private DataSet ds=new DataSet();
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.MenuItem menuItem16;
        private System.Windows.Forms.MenuItem menuItem17;
		private System.Windows.Forms.MenuItem menuItem23;
		private System.Windows.Forms.MenuItem menuItem24;
		private System.Windows.Forms.MenuItem menuItem25;
		private System.Windows.Forms.MenuItem menuItem26;
		private System.Windows.Forms.MenuItem menuItem27;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem18;
		private System.Windows.Forms.MenuItem menuItem19;
		private System.Windows.Forms.MenuItem menuItem20;
        private System.Windows.Forms.MenuItem menuItem21;
		private System.Windows.Forms.MenuItem menuItem29;
		private System.Windows.Forms.MenuItem menuItem30;
		private System.Windows.Forms.MenuItem menuItem31;
		private System.Windows.Forms.MenuItem menuItem32;
		private System.Windows.Forms.MenuItem menuItem33;
		private System.Windows.Forms.MenuItem menuItem34;
		private System.Windows.Forms.MenuItem menuItem35;
		private System.Windows.Forms.MenuItem menuItem37;
		private System.Windows.Forms.MenuItem menuItem38;
		private System.Windows.Forms.MenuItem menuItem39;
        private System.Windows.Forms.MenuItem menuItem42;
		private System.Windows.Forms.MenuItem menuItem46;
        private System.Windows.Forms.MenuItem menuItem60;
		private System.Windows.Forms.MenuItem menuItem62;
        private System.Windows.Forms.MenuItem menuItem64;
		private System.Windows.Forms.MenuItem menuItem66;
		private System.Windows.Forms.MenuItem menuItem67;
		private System.Windows.Forms.MenuItem menuItem79;
		private System.Windows.Forms.MenuItem menuItem80;
		private System.Windows.Forms.MenuItem menuItem81;
		private System.Windows.Forms.MenuItem menuItem82;
        private System.Windows.Forms.MenuItem menuItem83;
		private System.Windows.Forms.MenuItem menuItem85;
		private System.Windows.Forms.MenuItem menuItem86;
		private System.Windows.Forms.MenuItem menuItem87;
		private System.Windows.Forms.MenuItem menuItem88;
		private System.Windows.Forms.MenuItem menuItem90;
		private System.Windows.Forms.MenuItem menuItem91;
		private System.Windows.Forms.MenuItem menuItem102;
		private System.Windows.Forms.MenuItem menuItem104;
        private System.Windows.Forms.MenuItem menuItem44;
        private System.Windows.Forms.MenuItem menuItem53;
		private System.Windows.Forms.MenuItem menuItem110;
		private System.Windows.Forms.MenuItem menuItem111;
		private System.Windows.Forms.MenuItem menuItem112;
		private System.Windows.Forms.MenuItem menuItem113;
		private System.Windows.Forms.MenuItem menuItem114;
        private System.Windows.Forms.MenuItem menuItem121;
        private System.Windows.Forms.MenuItem menuItem135;
		private System.Windows.Forms.MenuItem menuItem139;
		private System.Windows.Forms.MenuItem menuItem140;
        private System.Windows.Forms.MenuItem menuItem146;
		private System.Windows.Forms.MenuItem menuItem150;
        private System.Windows.Forms.MenuItem menuItem156;
		private System.Windows.Forms.MenuItem menuItem144;
		private System.Windows.Forms.MenuItem menuItem145;
		private System.Windows.Forms.MenuItem menuItem179;
		private System.Windows.Forms.MenuItem menuItem181;
		private System.Windows.Forms.MenuItem menuItem182;
		private System.Windows.Forms.MenuItem menuItem184;
		private System.Windows.Forms.MenuItem menuItem185;
		private System.Windows.Forms.MenuItem menuItem186;
		private System.Windows.Forms.MenuItem menuItem187;
		private System.Windows.Forms.MenuItem menuItem188;
		private System.Windows.Forms.MenuItem menuItem189;
        private System.Windows.Forms.MenuItem menuItem98;
		private System.Windows.Forms.MenuItem menuItem36;
		private System.Windows.Forms.MenuItem menuItem40;
		private System.Windows.Forms.MenuItem menuItem41;
		private System.Windows.Forms.MenuItem menuItem54;
        private System.Windows.Forms.MenuItem menuItem56;
		private System.Windows.Forms.MenuItem menuItem48;
		private System.Windows.Forms.MenuItem menuItem49;
		private System.Windows.Forms.MenuItem menuItem50;
		private System.Windows.Forms.MenuItem menuItem51;
        private System.Windows.Forms.MenuItem menuItem52;
		private System.Windows.Forms.MenuItem menuItem57;
		private System.Windows.Forms.MenuItem menuItem58;
		private System.Windows.Forms.MenuItem menuItem59;
        private System.Windows.Forms.MenuItem menuItem68;
        private System.Windows.Forms.MenuItem menuItem70;
        private MenuItem menuItem71;
        private MenuItem m90;
        private MenuItem m91;
        private MenuItem m92;
        private MenuItem m93;
        private MenuItem m94;
        private MenuItem menuItem63;
        private MenuItem menuItem72;
        private MenuItem menuItem73;
        private MenuItem menuItem45;
        private MenuItem menuItem43;
        private MenuItem menuItem47;
        private MenuItem menuItem69;
        private MenuItem menuItem22;
        private IContainer components;

		public frmMain()
		{
           // run r = new run("MediInit.exe");
           // r.Launch();
			InitializeComponent();
			//this.Text=ttb.Msg;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem82 = new System.Windows.Forms.MenuItem();
            this.menuItem135 = new System.Windows.Forms.MenuItem();
            this.menuItem98 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem37 = new System.Windows.Forms.MenuItem();
            this.menuItem80 = new System.Windows.Forms.MenuItem();
            this.menuItem79 = new System.Windows.Forms.MenuItem();
            this.menuItem114 = new System.Windows.Forms.MenuItem();
            this.menuItem113 = new System.Windows.Forms.MenuItem();
            this.menuItem112 = new System.Windows.Forms.MenuItem();
            this.menuItem38 = new System.Windows.Forms.MenuItem();
            this.menuItem39 = new System.Windows.Forms.MenuItem();
            this.menuItem42 = new System.Windows.Forms.MenuItem();
            this.menuItem69 = new System.Windows.Forms.MenuItem();
            this.menuItem81 = new System.Windows.Forms.MenuItem();
            this.menuItem83 = new System.Windows.Forms.MenuItem();
            this.m90 = new System.Windows.Forms.MenuItem();
            this.m91 = new System.Windows.Forms.MenuItem();
            this.m92 = new System.Windows.Forms.MenuItem();
            this.menuItem139 = new System.Windows.Forms.MenuItem();
            this.m93 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem46 = new System.Windows.Forms.MenuItem();
            this.menuItem156 = new System.Windows.Forms.MenuItem();
            this.menuItem68 = new System.Windows.Forms.MenuItem();
            this.menuItem63 = new System.Windows.Forms.MenuItem();
            this.menuItem72 = new System.Windows.Forms.MenuItem();
            this.menuItem73 = new System.Windows.Forms.MenuItem();
            this.menuItem45 = new System.Windows.Forms.MenuItem();
            this.menuItem43 = new System.Windows.Forms.MenuItem();
            this.menuItem47 = new System.Windows.Forms.MenuItem();
            this.menuItem22 = new System.Windows.Forms.MenuItem();
            this.menuItem60 = new System.Windows.Forms.MenuItem();
            this.menuItem121 = new System.Windows.Forms.MenuItem();
            this.menuItem62 = new System.Windows.Forms.MenuItem();
            this.menuItem58 = new System.Windows.Forms.MenuItem();
            this.menuItem64 = new System.Windows.Forms.MenuItem();
            this.menuItem66 = new System.Windows.Forms.MenuItem();
            this.menuItem67 = new System.Windows.Forms.MenuItem();
            this.menuItem59 = new System.Windows.Forms.MenuItem();
            this.menuItem51 = new System.Windows.Forms.MenuItem();
            this.menuItem48 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem21 = new System.Windows.Forms.MenuItem();
            this.menuItem31 = new System.Windows.Forms.MenuItem();
            this.menuItem53 = new System.Windows.Forms.MenuItem();
            this.menuItem88 = new System.Windows.Forms.MenuItem();
            this.menuItem44 = new System.Windows.Forms.MenuItem();
            this.menuItem32 = new System.Windows.Forms.MenuItem();
            this.menuItem20 = new System.Windows.Forms.MenuItem();
            this.menuItem19 = new System.Windows.Forms.MenuItem();
            this.menuItem33 = new System.Windows.Forms.MenuItem();
            this.menuItem30 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem18 = new System.Windows.Forms.MenuItem();
            this.menuItem29 = new System.Windows.Forms.MenuItem();
            this.menuItem87 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem90 = new System.Windows.Forms.MenuItem();
            this.menuItem91 = new System.Windows.Forms.MenuItem();
            this.menuItem34 = new System.Windows.Forms.MenuItem();
            this.menuItem36 = new System.Windows.Forms.MenuItem();
            this.menuItem40 = new System.Windows.Forms.MenuItem();
            this.menuItem41 = new System.Windows.Forms.MenuItem();
            this.menuItem54 = new System.Windows.Forms.MenuItem();
            this.menuItem56 = new System.Windows.Forms.MenuItem();
            this.menuItem35 = new System.Windows.Forms.MenuItem();
            this.menuItem111 = new System.Windows.Forms.MenuItem();
            this.m94 = new System.Windows.Forms.MenuItem();
            this.menuItem144 = new System.Windows.Forms.MenuItem();
            this.menuItem145 = new System.Windows.Forms.MenuItem();
            this.menuItem179 = new System.Windows.Forms.MenuItem();
            this.menuItem181 = new System.Windows.Forms.MenuItem();
            this.menuItem184 = new System.Windows.Forms.MenuItem();
            this.menuItem185 = new System.Windows.Forms.MenuItem();
            this.menuItem186 = new System.Windows.Forms.MenuItem();
            this.menuItem182 = new System.Windows.Forms.MenuItem();
            this.menuItem187 = new System.Windows.Forms.MenuItem();
            this.menuItem188 = new System.Windows.Forms.MenuItem();
            this.menuItem189 = new System.Windows.Forms.MenuItem();
            this.menuItem86 = new System.Windows.Forms.MenuItem();
            this.menuItem140 = new System.Windows.Forms.MenuItem();
            this.menuItem85 = new System.Windows.Forms.MenuItem();
            this.menuItem49 = new System.Windows.Forms.MenuItem();
            this.menuItem50 = new System.Windows.Forms.MenuItem();
            this.menuItem23 = new System.Windows.Forms.MenuItem();
            this.menuItem24 = new System.Windows.Forms.MenuItem();
            this.menuItem25 = new System.Windows.Forms.MenuItem();
            this.menuItem102 = new System.Windows.Forms.MenuItem();
            this.menuItem104 = new System.Windows.Forms.MenuItem();
            this.menuItem110 = new System.Windows.Forms.MenuItem();
            this.menuItem146 = new System.Windows.Forms.MenuItem();
            this.menuItem150 = new System.Windows.Forms.MenuItem();
            this.menuItem52 = new System.Windows.Forms.MenuItem();
            this.menuItem57 = new System.Windows.Forms.MenuItem();
            this.menuItem70 = new System.Windows.Forms.MenuItem();
            this.menuItem71 = new System.Windows.Forms.MenuItem();
            this.menuItem26 = new System.Windows.Forms.MenuItem();
            this.menuItem27 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.menuItem16 = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem81,
            this.menuItem7,
            this.menuItem3,
            this.menuItem4,
            this.menuItem5,
            this.menuItem6});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem8,
            this.menuItem82,
            this.menuItem135,
            this.menuItem98});
            this.menuItem1.MergeOrder = 900;
            this.menuItem1.Text = "&Nhập kho";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 0;
            this.menuItem8.MergeOrder = 1;
            this.menuItem8.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.menuItem8.Text = "Phiếu nhập kho";
            this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // menuItem82
            // 
            this.menuItem82.Index = 1;
            this.menuItem82.MergeOrder = 2;
            this.menuItem82.Text = "Phiếu tái nhập kho";
            this.menuItem82.Click += new System.EventHandler(this.menuItem82_Click);
            // 
            // menuItem135
            // 
            this.menuItem135.Index = 2;
            this.menuItem135.Text = "-";
            // 
            // menuItem98
            // 
            this.menuItem98.Index = 3;
            this.menuItem98.MergeOrder = 3;
            this.menuItem98.Text = "Phiếu đề nghị thanh toán";
            this.menuItem98.Click += new System.EventHandler(this.menuItem98_Click_1);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem37,
            this.menuItem80,
            this.menuItem79,
            this.menuItem114,
            this.menuItem113,
            this.menuItem112,
            this.menuItem38,
            this.menuItem39,
            this.menuItem42,
            this.menuItem69});
            this.menuItem2.MergeOrder = 901;
            this.menuItem2.Text = "&Xuất kho";
            // 
            // menuItem37
            // 
            this.menuItem37.Index = 0;
            this.menuItem37.MergeOrder = 4;
            this.menuItem37.Text = "Phiếu xuất chuyển kho";
            this.menuItem37.Click += new System.EventHandler(this.menuItem37_Click);
            // 
            // menuItem80
            // 
            this.menuItem80.Index = 1;
            this.menuItem80.MergeOrder = 5;
            this.menuItem80.Text = "Duyệt cấp theo kho dự trù";
            this.menuItem80.Click += new System.EventHandler(this.menuItem80_Click);
            // 
            // menuItem79
            // 
            this.menuItem79.Index = 2;
            this.menuItem79.Text = "-";
            // 
            // menuItem114
            // 
            this.menuItem114.Index = 3;
            this.menuItem114.MergeOrder = 6;
            this.menuItem114.Text = "Duyệt cấp tài sản";
            this.menuItem114.Click += new System.EventHandler(this.menuItem114_Click);
            // 
            // menuItem113
            // 
            this.menuItem113.Index = 4;
            this.menuItem113.MergeOrder = 7;
            this.menuItem113.Text = "Duyệt hoàn trả tài sản";
            this.menuItem113.Click += new System.EventHandler(this.menuItem113_Click);
            // 
            // menuItem112
            // 
            this.menuItem112.Index = 5;
            this.menuItem112.Text = "-";
            // 
            // menuItem38
            // 
            this.menuItem38.Index = 6;
            this.menuItem38.MergeOrder = 8;
            this.menuItem38.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.menuItem38.Text = "Phiếu xuất kho";
            this.menuItem38.Click += new System.EventHandler(this.menuItem38_Click);
            // 
            // menuItem39
            // 
            this.menuItem39.Index = 7;
            this.menuItem39.MergeOrder = 9;
            this.menuItem39.Text = "Phiếu hoàn trả";
            this.menuItem39.Click += new System.EventHandler(this.menuItem39_Click);
            // 
            // menuItem42
            // 
            this.menuItem42.Index = 8;
            this.menuItem42.MergeOrder = 10;
            this.menuItem42.Text = "Phiếu xuất khác";
            this.menuItem42.Click += new System.EventHandler(this.menuItem42_Click);
            // 
            // menuItem69
            // 
            this.menuItem69.Index = 9;
            this.menuItem69.MergeOrder = 11;
            this.menuItem69.Text = "Phiếu xuất hoàn trả nhà cung cấp";
            this.menuItem69.Click += new System.EventHandler(this.menuItem69_Click_1);
            // 
            // menuItem81
            // 
            this.menuItem81.Index = 2;
            this.menuItem81.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem83,
            this.m90,
            this.m91,
            this.m92,
            this.menuItem139,
            this.m93});
            this.menuItem81.MergeOrder = 902;
            this.menuItem81.Text = "&Dự trù";
            this.menuItem81.Click += new System.EventHandler(this.menuItem81_Click);
            // 
            // menuItem83
            // 
            this.menuItem83.Index = 0;
            this.menuItem83.MergeOrder = 12;
            this.menuItem83.Text = "Phiếu dự trù kho cấp";
            this.menuItem83.Click += new System.EventHandler(this.menuItem83_Click);
            // 
            // m90
            // 
            this.m90.Index = 1;
            this.m90.MergeOrder = 13;
            this.m90.Text = "Bảng dự trù mua hàng tháng";
            this.m90.Click += new System.EventHandler(this.m90_Click);
            // 
            // m91
            // 
            this.m91.Index = 2;
            this.m91.MergeOrder = 14;
            this.m91.Text = "Bảng dự trù mua theo kho";
            this.m91.Click += new System.EventHandler(this.m91_Click);
            // 
            // m92
            // 
            this.m92.Index = 3;
            this.m92.MergeOrder = 15;
            this.m92.Text = "Bảng dự trù mua theo năm";
            this.m92.Click += new System.EventHandler(this.m92_Click);
            // 
            // menuItem139
            // 
            this.menuItem139.Index = 4;
            this.menuItem139.MergeOrder = 16;
            this.menuItem139.Text = "Kinh phí mua sắm trong năm";
            this.menuItem139.Click += new System.EventHandler(this.menuItem139_Click);
            // 
            // m93
            // 
            this.m93.Index = 5;
            this.m93.MergeOrder = 17;
            this.m93.Text = "Bảng tổng hợp dự trù";
            this.m93.Click += new System.EventHandler(this.m93_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 3;
            this.menuItem7.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem46,
            this.menuItem60,
            this.menuItem64,
            this.menuItem66,
            this.menuItem67,
            this.menuItem59,
            this.menuItem51,
            this.menuItem48});
            this.menuItem7.MergeOrder = 903;
            this.menuItem7.Text = "&Báo cáo";
            // 
            // menuItem46
            // 
            this.menuItem46.Index = 0;
            this.menuItem46.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem156,
            this.menuItem68,
            this.menuItem63,
            this.menuItem72,
            this.menuItem73,
            this.menuItem45,
            this.menuItem43,
            this.menuItem47,
            this.menuItem22});
            this.menuItem46.MergeOrder = 18;
            this.menuItem46.Text = "1. Báo cáo";
            // 
            // menuItem156
            // 
            this.menuItem156.Index = 0;
            this.menuItem156.MergeOrder = 26;
            this.menuItem156.Text = "1.1. Xuất kho tổng hợp theo ngày";
            this.menuItem156.Click += new System.EventHandler(this.menuItem156_Click);
            // 
            // menuItem68
            // 
            this.menuItem68.Index = 1;
            this.menuItem68.MergeOrder = 27;
            this.menuItem68.Text = "1.2. Trang thiết bị y tế";
            this.menuItem68.Click += new System.EventHandler(this.menuItem68_Click_1);
            // 
            // menuItem63
            // 
            this.menuItem63.Index = 2;
            this.menuItem63.MergeOrder = 28;
            this.menuItem63.Text = "1.3. Phiếu nhập kho";
            this.menuItem63.Click += new System.EventHandler(this.menuItem63_Click);
            // 
            // menuItem72
            // 
            this.menuItem72.Index = 3;
            this.menuItem72.MergeOrder = 29;
            this.menuItem72.Text = "1.4. Bảng nhập trang thiết bị";
            this.menuItem72.Click += new System.EventHandler(this.menuItem72_Click_1);
            // 
            // menuItem73
            // 
            this.menuItem73.Index = 4;
            this.menuItem73.MergeOrder = 30;
            this.menuItem73.Text = "1.5. Bảng xuất trang thiết bị";
            this.menuItem73.Click += new System.EventHandler(this.menuItem73_Click);
            // 
            // menuItem45
            // 
            this.menuItem45.Index = 5;
            this.menuItem45.MergeOrder = 31;
            this.menuItem45.Text = "1.6. Báo cáo nhập xuất tồn trang thiết bị tại khoa";
            this.menuItem45.Click += new System.EventHandler(this.menuItem45_Click);
            // 
            // menuItem43
            // 
            this.menuItem43.Index = 6;
            this.menuItem43.MergeOrder = 32;
            this.menuItem43.Text = "1.7. Báo cáo nhập xuất tồn kho";
            this.menuItem43.Click += new System.EventHandler(this.menuItem43_Click_3);
            // 
            // menuItem47
            // 
            this.menuItem47.Index = 7;
            this.menuItem47.MergeOrder = 33;
            this.menuItem47.Text = "1.8. Tổng hợp phiếu xuất theo khoa";
            this.menuItem47.Click += new System.EventHandler(this.menuItem47_Click);
            // 
            // menuItem22
            // 
            this.menuItem22.Index = 8;
            this.menuItem22.MergeOrder = 34;
            this.menuItem22.Text = "1.9. Tổng hợp trang thiết bị theo khoa";
            this.menuItem22.Click += new System.EventHandler(this.menuItem22_Click_1);
            // 
            // menuItem60
            // 
            this.menuItem60.Index = 1;
            this.menuItem60.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem121,
            this.menuItem62,
            this.menuItem58});
            this.menuItem60.MergeOrder = 19;
            this.menuItem60.Text = "2. Biên bản";
            // 
            // menuItem121
            // 
            this.menuItem121.Index = 0;
            this.menuItem121.MergeOrder = 35;
            this.menuItem121.Text = "2.1. Kiểm nhập";
            this.menuItem121.Click += new System.EventHandler(this.menuItem121_Click);
            // 
            // menuItem62
            // 
            this.menuItem62.Index = 1;
            this.menuItem62.MergeOrder = 36;
            this.menuItem62.Text = "2.4. Thanh lý, hủy";
            this.menuItem62.Click += new System.EventHandler(this.menuItem62_Click);
            // 
            // menuItem58
            // 
            this.menuItem58.Index = 2;
            this.menuItem58.MergeOrder = 37;
            this.menuItem58.Text = "2.5. Biên bản kiểm kê TSCĐ && Dụng cụ";
            this.menuItem58.Click += new System.EventHandler(this.menuItem58_Click);
            // 
            // menuItem64
            // 
            this.menuItem64.Index = 2;
            this.menuItem64.MergeOrder = 20;
            this.menuItem64.Text = "3. Phiếu kiểm kê kho";
            this.menuItem64.Click += new System.EventHandler(this.menuItem64_Click);
            // 
            // menuItem66
            // 
            this.menuItem66.Index = 3;
            this.menuItem66.MergeOrder = 21;
            this.menuItem66.Text = "5. Sổ kho";
            this.menuItem66.Click += new System.EventHandler(this.menuItem66_Click);
            // 
            // menuItem67
            // 
            this.menuItem67.Index = 4;
            this.menuItem67.MergeOrder = 22;
            this.menuItem67.Text = "6. Thẻ kho";
            this.menuItem67.Click += new System.EventHandler(this.menuItem67_Click);
            // 
            // menuItem59
            // 
            this.menuItem59.Index = 5;
            this.menuItem59.MergeOrder = 23;
            this.menuItem59.Text = "7. Sổ theo dõi tài sản cố định và dụng cụ";
            this.menuItem59.Click += new System.EventHandler(this.menuItem59_Click);
            // 
            // menuItem51
            // 
            this.menuItem51.Index = 6;
            this.menuItem51.MergeOrder = 24;
            this.menuItem51.Text = "8. In phiếu xuất kho";
            this.menuItem51.Click += new System.EventHandler(this.menuItem51_Click_1);
            // 
            // menuItem48
            // 
            this.menuItem48.Index = 7;
            this.menuItem48.MergeOrder = 25;
            this.menuItem48.Text = "10. Thống kê nhập xuất kho theo ngày";
            this.menuItem48.Click += new System.EventHandler(this.menuItem48_Click_1);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 4;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem9,
            this.menuItem144,
            this.menuItem181,
            this.menuItem182,
            this.menuItem86,
            this.menuItem140,
            this.menuItem85,
            this.menuItem49,
            this.menuItem50,
            this.menuItem23,
            this.menuItem24,
            this.menuItem25,
            this.menuItem102,
            this.menuItem104,
            this.menuItem110,
            this.menuItem146,
            this.menuItem150,
            this.menuItem52,
            this.menuItem57,
            this.menuItem70,
            this.menuItem71,
            this.menuItem26,
            this.menuItem27});
            this.menuItem3.MergeOrder = 907;
            this.menuItem3.Text = "&Tiện ích";
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 0;
            this.menuItem9.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem21,
            this.menuItem31,
            this.menuItem53,
            this.menuItem88,
            this.menuItem44,
            this.menuItem32,
            this.menuItem20,
            this.menuItem19,
            this.menuItem33,
            this.menuItem30,
            this.menuItem11,
            this.menuItem18,
            this.menuItem29,
            this.menuItem87,
            this.menuItem10,
            this.menuItem90,
            this.menuItem91,
            this.menuItem34,
            this.menuItem36,
            this.menuItem40,
            this.menuItem41,
            this.menuItem54,
            this.menuItem56,
            this.menuItem35,
            this.menuItem111,
            this.m94});
            this.menuItem9.MergeOrder = 38;
            this.menuItem9.Text = "Danh mục";
            // 
            // menuItem21
            // 
            this.menuItem21.Index = 0;
            this.menuItem21.MergeOrder = 58;
            this.menuItem21.Text = "1.1. Nhóm báo cáo trang thiết bị bệnh viện";
            this.menuItem21.Visible = false;
            this.menuItem21.Click += new System.EventHandler(this.menuItem21_Click);
            // 
            // menuItem31
            // 
            this.menuItem31.Index = 1;
            this.menuItem31.MergeOrder = 59;
            this.menuItem31.Text = "1.2. Nhóm kế toán";
            this.menuItem31.Click += new System.EventHandler(this.menuItem31_Click);
            // 
            // menuItem53
            // 
            this.menuItem53.Index = 2;
            this.menuItem53.MergeOrder = 60;
            this.menuItem53.Text = "1.3. Nhóm in ";
            this.menuItem53.Click += new System.EventHandler(this.menuItem53_Click);
            // 
            // menuItem88
            // 
            this.menuItem88.Index = 3;
            this.menuItem88.MergeOrder = 61;
            this.menuItem88.Text = "1.4. Nhóm hãng sản xuất";
            this.menuItem88.Click += new System.EventHandler(this.menuItem88_Click);
            // 
            // menuItem44
            // 
            this.menuItem44.Index = 4;
            this.menuItem44.MergeOrder = 62;
            this.menuItem44.Text = "1.5. Nhóm nước sản xuất";
            this.menuItem44.Click += new System.EventHandler(this.menuItem44_Click);
            // 
            // menuItem32
            // 
            this.menuItem32.Index = 5;
            this.menuItem32.MergeOrder = 63;
            this.menuItem32.Text = "1.6. Nhóm nhà cung cấp";
            this.menuItem32.Click += new System.EventHandler(this.menuItem32_Click);
            // 
            // menuItem20
            // 
            this.menuItem20.Index = 6;
            this.menuItem20.MergeOrder = 64;
            this.menuItem20.Text = "1.7. Nước sản xuất";
            this.menuItem20.Click += new System.EventHandler(this.menuItem20_Click);
            // 
            // menuItem19
            // 
            this.menuItem19.Index = 7;
            this.menuItem19.MergeOrder = 65;
            this.menuItem19.Text = "1.8. Hãng sản xuất";
            this.menuItem19.Click += new System.EventHandler(this.menuItem19_Click);
            // 
            // menuItem33
            // 
            this.menuItem33.Index = 8;
            this.menuItem33.MergeOrder = 66;
            this.menuItem33.Text = "1.9. Nhà cung cấp";
            this.menuItem33.Click += new System.EventHandler(this.menuItem33_Click);
            // 
            // menuItem30
            // 
            this.menuItem30.Index = 9;
            this.menuItem30.MergeOrder = 67;
            this.menuItem30.Text = "1.10. Nguồn";
            this.menuItem30.Click += new System.EventHandler(this.menuItem30_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 10;
            this.menuItem11.MergeOrder = 68;
            this.menuItem11.Text = "1.11. Nhóm";
            this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
            // 
            // menuItem18
            // 
            this.menuItem18.Index = 11;
            this.menuItem18.MergeOrder = 69;
            this.menuItem18.Text = "1.12. Phân loại";
            this.menuItem18.Click += new System.EventHandler(this.menuItem18_Click);
            // 
            // menuItem29
            // 
            this.menuItem29.Index = 12;
            this.menuItem29.MergeOrder = 70;
            this.menuItem29.Text = "1.14. Kho";
            this.menuItem29.Click += new System.EventHandler(this.menuItem29_Click);
            // 
            // menuItem87
            // 
            this.menuItem87.Index = 13;
            this.menuItem87.MergeOrder = 71;
            this.menuItem87.Text = "1.15. Đơn vị tính";
            this.menuItem87.Click += new System.EventHandler(this.menuItem87_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 14;
            this.menuItem10.MergeOrder = 72;
            this.menuItem10.Text = "1.16. Trang thiết bị y tế";
            this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
            // 
            // menuItem90
            // 
            this.menuItem90.Index = 15;
            this.menuItem90.MergeOrder = 73;
            this.menuItem90.Text = "1.17. Nhóm phiếu";
            this.menuItem90.Click += new System.EventHandler(this.menuItem90_Click);
            // 
            // menuItem91
            // 
            this.menuItem91.Index = 16;
            this.menuItem91.MergeOrder = 74;
            this.menuItem91.Text = "1.18. Loại phiếu";
            this.menuItem91.Click += new System.EventHandler(this.menuItem91_Click);
            // 
            // menuItem34
            // 
            this.menuItem34.Index = 17;
            this.menuItem34.MergeOrder = 75;
            this.menuItem34.Text = "1.20. Khoa/phòng";
            this.menuItem34.Click += new System.EventHandler(this.menuItem34_Click);
            // 
            // menuItem36
            // 
            this.menuItem36.Index = 18;
            this.menuItem36.MergeOrder = 76;
            this.menuItem36.Text = "1.21. Danh mục nhập xuất";
            this.menuItem36.Click += new System.EventHandler(this.menuItem36_Click_1);
            // 
            // menuItem40
            // 
            this.menuItem40.Index = 19;
            this.menuItem40.MergeOrder = 77;
            this.menuItem40.Text = "1.22. Danh mục phẩm chất";
            this.menuItem40.Click += new System.EventHandler(this.menuItem40_Click);
            // 
            // menuItem41
            // 
            this.menuItem41.Index = 20;
            this.menuItem41.MergeOrder = 78;
            this.menuItem41.Text = "1.23. Danh mục nguồn gốc";
            this.menuItem41.Click += new System.EventHandler(this.menuItem41_Click);
            // 
            // menuItem54
            // 
            this.menuItem54.Index = 21;
            this.menuItem54.MergeOrder = 79;
            this.menuItem54.Text = "1.24. Danh mục tình trạng";
            this.menuItem54.Click += new System.EventHandler(this.menuItem54_Click);
            // 
            // menuItem56
            // 
            this.menuItem56.Index = 22;
            this.menuItem56.MergeOrder = 80;
            this.menuItem56.Text = "1.25. Danh mục nơi sửa chữa";
            this.menuItem56.Click += new System.EventHandler(this.menuItem56_Click_1);
            // 
            // menuItem35
            // 
            this.menuItem35.Index = 23;
            this.menuItem35.MergeOrder = 81;
            this.menuItem35.Text = "1.26. Lý do xuất khác";
            this.menuItem35.Click += new System.EventHandler(this.menuItem35_Click);
            // 
            // menuItem111
            // 
            this.menuItem111.Index = 24;
            this.menuItem111.MergeOrder = 81;
            this.menuItem111.Text = "1.27. Lý do hoàn trả";
            this.menuItem111.Click += new System.EventHandler(this.menuItem111_Click);
            // 
            // m94
            // 
            this.m94.Index = 25;
            this.m94.MergeOrder = 83;
            this.m94.Text = "1.28. Khai báo gói tài sản";
            this.m94.Click += new System.EventHandler(this.m94_Click);
            // 
            // menuItem144
            // 
            this.menuItem144.Index = 1;
            this.menuItem144.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem145,
            this.menuItem179});
            this.menuItem144.MergeOrder = 39;
            this.menuItem144.Text = "Khai báo tồn đầu";
            // 
            // menuItem145
            // 
            this.menuItem145.Index = 0;
            this.menuItem145.MergeOrder = 84;
            this.menuItem145.Text = "2.1. Kho";
            this.menuItem145.Click += new System.EventHandler(this.menuItem145_Click_1);
            // 
            // menuItem179
            // 
            this.menuItem179.Index = 1;
            this.menuItem179.MergeOrder = 85;
            this.menuItem179.Text = "2.2. Khoa";
            this.menuItem179.Click += new System.EventHandler(this.menuItem179_Click);
            // 
            // menuItem181
            // 
            this.menuItem181.Index = 2;
            this.menuItem181.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem184,
            this.menuItem185,
            this.menuItem186});
            this.menuItem181.MergeOrder = 40;
            this.menuItem181.Text = "Kho";
            // 
            // menuItem184
            // 
            this.menuItem184.Index = 0;
            this.menuItem184.MergeOrder = 86;
            this.menuItem184.Text = "3.1. Chi tiết";
            this.menuItem184.Click += new System.EventHandler(this.menuItem184_Click);
            // 
            // menuItem185
            // 
            this.menuItem185.Index = 1;
            this.menuItem185.MergeOrder = 87;
            this.menuItem185.Text = "3.2. Tổng hợp";
            this.menuItem185.Click += new System.EventHandler(this.menuItem185_Click);
            // 
            // menuItem186
            // 
            this.menuItem186.Index = 2;
            this.menuItem186.MergeOrder = 88;
            this.menuItem186.Text = "3.3. Kiểm tra tồn đầu";
            this.menuItem186.Click += new System.EventHandler(this.menuItem186_Click);
            // 
            // menuItem182
            // 
            this.menuItem182.Index = 3;
            this.menuItem182.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem187,
            this.menuItem188,
            this.menuItem189});
            this.menuItem182.MergeOrder = 41;
            this.menuItem182.Text = "Khoa";
            // 
            // menuItem187
            // 
            this.menuItem187.Index = 0;
            this.menuItem187.MergeOrder = 89;
            this.menuItem187.Text = "4.1. Chi tiết";
            this.menuItem187.Click += new System.EventHandler(this.menuItem187_Click);
            // 
            // menuItem188
            // 
            this.menuItem188.Index = 1;
            this.menuItem188.MergeOrder = 90;
            this.menuItem188.Text = "4.2. Tổng hợp";
            this.menuItem188.Click += new System.EventHandler(this.menuItem188_Click);
            // 
            // menuItem189
            // 
            this.menuItem189.Index = 2;
            this.menuItem189.MergeOrder = 91;
            this.menuItem189.Text = "4.3. Kiểm tra tồn đầu";
            this.menuItem189.Click += new System.EventHandler(this.menuItem189_Click);
            // 
            // menuItem86
            // 
            this.menuItem86.Index = 4;
            this.menuItem86.Text = "-";
            // 
            // menuItem140
            // 
            this.menuItem140.Index = 5;
            this.menuItem140.MergeOrder = 42;
            this.menuItem140.Text = "Kiểm tra số liệu tồn kho";
            this.menuItem140.Click += new System.EventHandler(this.menuItem140_Click);
            // 
            // menuItem85
            // 
            this.menuItem85.Index = 6;
            this.menuItem85.Text = "-";
            // 
            // menuItem49
            // 
            this.menuItem49.Index = 7;
            this.menuItem49.MergeOrder = 43;
            this.menuItem49.Text = "Theo dõi tài sản tại khoa";
            this.menuItem49.Click += new System.EventHandler(this.menuItem49_Click);
            // 
            // menuItem50
            // 
            this.menuItem50.Index = 8;
            this.menuItem50.MergeOrder = 44;
            this.menuItem50.Text = "Cấu hình thông số hệ thống";
            this.menuItem50.Click += new System.EventHandler(this.menuItem50_Click);
            // 
            // menuItem23
            // 
            this.menuItem23.Index = 9;
            this.menuItem23.MergeOrder = 45;
            this.menuItem23.Text = "Phân quyền sử dụng";
            this.menuItem23.Click += new System.EventHandler(this.menuItem23_Click);
            // 
            // menuItem24
            // 
            this.menuItem24.Index = 10;
            this.menuItem24.MergeOrder = 46;
            this.menuItem24.Text = "Thay đổi mật khẩu";
            this.menuItem24.Click += new System.EventHandler(this.menuItem24_Click);
            // 
            // menuItem25
            // 
            this.menuItem25.Index = 11;
            this.menuItem25.MergeOrder = 47;
            this.menuItem25.Text = "Sao lưu số liệu";
            this.menuItem25.Click += new System.EventHandler(this.menuItem25_Click);
            // 
            // menuItem102
            // 
            this.menuItem102.Index = 12;
            this.menuItem102.MergeOrder = 48;
            this.menuItem102.Text = "Truy vấn theo câu lệnh SQL";
            this.menuItem102.Click += new System.EventHandler(this.menuItem102_Click);
            // 
            // menuItem104
            // 
            this.menuItem104.Index = 13;
            this.menuItem104.MergeOrder = 49;
            this.menuItem104.Text = "Đổi ngày";
            this.menuItem104.Click += new System.EventHandler(this.menuItem104_Click);
            // 
            // menuItem110
            // 
            this.menuItem110.Index = 14;
            this.menuItem110.MergeOrder = 50;
            this.menuItem110.Text = "Gửi thông tin qua mạng nội bộ";
            this.menuItem110.Click += new System.EventHandler(this.menuItem110_Click_1);
            // 
            // menuItem146
            // 
            this.menuItem146.Index = 15;
            this.menuItem146.MergeOrder = 51;
            this.menuItem146.Text = "Thông báo qua mạng nội bộ";
            this.menuItem146.Click += new System.EventHandler(this.menuItem146_Click);
            // 
            // menuItem150
            // 
            this.menuItem150.Index = 16;
            this.menuItem150.MergeOrder = 52;
            this.menuItem150.Text = "Kiểm tra số liệu của khoa";
            this.menuItem150.Click += new System.EventHandler(this.menuItem150_Click);
            // 
            // menuItem52
            // 
            this.menuItem52.Index = 17;
            this.menuItem52.MergeOrder = 53;
            this.menuItem52.Text = "Danh sách dự trù,duyệt,in phiếu xuất";
            this.menuItem52.Click += new System.EventHandler(this.menuItem52_Click);
            // 
            // menuItem57
            // 
            this.menuItem57.Index = 18;
            this.menuItem57.MergeOrder = 54;
            this.menuItem57.Text = "Chỉnh sửa số tiền trong phiếu nhập";
            this.menuItem57.Click += new System.EventHandler(this.menuItem57_Click);
            // 
            // menuItem70
            // 
            this.menuItem70.Index = 19;
            this.menuItem70.MergeOrder = 55;
            this.menuItem70.Text = "Tạo lại số liệu";
            this.menuItem70.Click += new System.EventHandler(this.menuItem70_Click_1);
            // 
            // menuItem71
            // 
            this.menuItem71.Index = 20;
            this.menuItem71.MergeOrder = 56;
            this.menuItem71.Text = "Nhật ký người dùng";
            this.menuItem71.Click += new System.EventHandler(this.menuItem71_Click_1);
            // 
            // menuItem26
            // 
            this.menuItem26.Index = 21;
            this.menuItem26.Text = "-";
            // 
            // menuItem27
            // 
            this.menuItem27.Index = 22;
            this.menuItem27.MergeOrder = 57;
            this.menuItem27.Shortcut = System.Windows.Forms.Shortcut.CtrlL;
            this.menuItem27.Text = "Log Off";
            this.menuItem27.Click += new System.EventHandler(this.menuItem27_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 5;
            this.menuItem4.MdiList = true;
            this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem12,
            this.menuItem13,
            this.menuItem14});
            this.menuItem4.Text = "&A. Cửa sổ";
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 0;
            this.menuItem12.Text = "&1. Hiện cửa sổ theo chiều dọc";
            this.menuItem12.Click += new System.EventHandler(this.menuItem12_Click);
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 1;
            this.menuItem13.Text = "&2. Hiện cửa sổ theo chiều ngang";
            this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 2;
            this.menuItem14.Text = "&3. Đóng tất cả các cửa sổ";
            this.menuItem14.Click += new System.EventHandler(this.menuItem14_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 6;
            this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem15,
            this.menuItem16,
            this.menuItem17});
            this.menuItem5.Text = "&B. Hướng dẫn";
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 0;
            this.menuItem15.Text = "&1. Hướng dẫn sử dụng";
            this.menuItem15.Click += new System.EventHandler(this.menuItem15_Click);
            // 
            // menuItem16
            // 
            this.menuItem16.Index = 1;
            this.menuItem16.Text = "-";
            // 
            // menuItem17
            // 
            this.menuItem17.Index = 2;
            this.menuItem17.Text = "&2. About";
            this.menuItem17.Click += new System.EventHandler(this.menuItem17_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 7;
            this.menuItem6.Text = "&C. Kết thúc";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // frmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(832, 430);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Menu = this.mainMenu1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kho trang thiết bị";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

		}
		#endregion

		private bool IsLoaded(string frm)
		{
			Form[] afrm=this.MdiChildren;
			foreach(Form f in afrm)
			{
				if(f.Name.Equals(frm)){f.Activate();return true;}
			}
			return false;
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			if (MessageBox.Show ("Bạn có muốn kết thúc không ?",this.Text,MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
			{
                ttb.set_current();
				Application.Exit();
			}
		}

		private void menuItem12_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
		}

		private void menuItem13_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
		}

		private void menuItem14_Click(object sender, System.EventArgs e)
		{
			Form[] charr= this.MdiChildren;  
			foreach (Form chform in charr) chform.Close();
		}

		private void frmMain_Load(object sender, System.EventArgs e)
		{
            ttb = new AccessData();
            user = ttb.user;
            ttb.get_capid(9);
            try
            {
                Splasher.Show();
                Splasher.Status = "Connecting to Oracle Server ...";
                link = ttb.get_data("select ten from " + user + ".ttb_thongso where id=155").Tables[0].Rows[0][0].ToString().Trim();
                if (link != "")
                {
                    link = "@" + link.Trim('@');
                }
                ds = ttb.get_data("select * from " + user + ".ttb_dlogin where id=0");
                System.Threading.Thread.Sleep(1000);//2350
                Splasher.Close();
                Application.DoEvents();
            }
            catch { Splasher.Close(); }
            Application.DoEvents();
            frmLogin f = new frmLogin(ttb);
			f.ShowDialog(this);
            if (f.mExit)
            {
                Application.Exit();
                return;
            }
			if (f.mUserid!="")
			{
				s_userid=f.mUserid;
				s_right=f.mRight;
				i_userid=f.iUserid;
				i_nhomkho=f.iNhomkho;
				i_loaikho=ttb.get_loai(i_nhomkho);
				s_makho=f.mMakho;
				s_mmyy=f.mMmyy;
				s_ngay=f.mNgay;
				s_makp=f.mMakp;
				s_manhom=f.mManhom;
				b_admin=f.bAdmin;
				s_loaint=f.mLoaint;
                s_loaikhac=f.mLoaikhac;
				//ttb.writeXml("ttb_thongso","kho","Trang Thiết Bị");
                this.Text = "Trang Thiết Bị" + " - Version: " + ProductVersion; ;
                if (i_nhomkho != 0) b_giaban = false;// int.Parse(ttb.get_data("select nhom from " + user + ".ttb_dmnhomkho where id=" + i_nhomkho).Tables[0].Rows[0][0].ToString()) == 1;
                if (!b_giaban) b_giaban = false;// ttb.bGiaban_nguon(i_nhomkho);
			}
			else Application.Exit();
			gan_right();
           // menuItem81.Visible = false;
           // menuItem80.Visible = false;
           // menuItem98.Visible = false;
		}

		private void gan_right()
		{
            int n = 0, t = 0;
            bool bx = false;
            for (int i = 0; i < this.mainMenu1.MenuItems.Count - 3; i++)
            {
                bx = false;

                for (int j = 0; j < this.mainMenu1.MenuItems[i].MenuItems.Count; j++)
                {

                    if (this.mainMenu1.MenuItems[i].MenuItems[j].MenuItems.Count == 0)
                    {
                        if (this.mainMenu1.MenuItems[i].MenuItems[j].Text != "-")
                        {
                            string a = this.mainMenu1.MenuItems[i].MenuItems[j].Text;
                            this.mainMenu1.MenuItems[i].MenuItems[j].Visible = s_right.IndexOf(this.mainMenu1.MenuItems[i].MenuItems[j].MergeOrder.ToString().PadLeft(3, '0') + "+") != -1;
                            if (!bx)
                                bx = this.mainMenu1.MenuItems[i].MenuItems[j].Visible;
                            if (this.mainMenu1.MenuItems[i].MenuItems[j].Text == "19. Tạo lại số liệu tháng/năm")
                            {
                                this.mainMenu1.MenuItems[i].MenuItems[j].Visible = true;
                                bx = true;
                            }
                        }
                        else
                        {
                            this.mainMenu1.MenuItems[i].MenuItems[j].Visible = false;
                        }
                    }
                    else
                    {
                        n = 0;
                        for (int k = 0; k < this.mainMenu1.MenuItems[i].MenuItems[j].MenuItems.Count; k++)
                        {
                            if (this.mainMenu1.MenuItems[i].MenuItems[j].MenuItems[k].MenuItems.Count == 0)
                            {
                                if (this.mainMenu1.MenuItems[i].MenuItems[j].MenuItems[k].Text != "-")
                                    this.mainMenu1.MenuItems[i].MenuItems[j].MenuItems[k].Visible = s_right.IndexOf(this.mainMenu1.MenuItems[i].MenuItems[j].MenuItems[k].MergeOrder.ToString().PadLeft(3, '0') + "+") != -1;
                                else this.mainMenu1.MenuItems[i].MenuItems[j].MenuItems[k].Visible = false;
                                n += (this.mainMenu1.MenuItems[i].MenuItems[j].MenuItems[k].Visible) ? 1 : 0;

                            }
                            else
                            {
                                t = 0;
                                for (int s = 0; s < this.mainMenu1.MenuItems[i].MenuItems[j].MenuItems[k].MenuItems.Count; s++)
                                {
                                    if (this.mainMenu1.MenuItems[i].MenuItems[j].MenuItems[k].MenuItems[s].Text != "-")
                                        this.mainMenu1.MenuItems[i].MenuItems[j].MenuItems[k].MenuItems[s].Visible = s_right.IndexOf(this.mainMenu1.MenuItems[i].MenuItems[j].MenuItems[k].MenuItems[s].MergeOrder.ToString().PadLeft(3, '0') + "+") != -1;
                                    else this.mainMenu1.MenuItems[i].MenuItems[j].MenuItems[k].MenuItems[s].Visible = false;
                                    t += (this.mainMenu1.MenuItems[i].MenuItems[j].MenuItems[k].MenuItems[s].Visible) ? 1 : 0;
                                }
                                this.mainMenu1.MenuItems[i].MenuItems[j].MenuItems[k].Visible = t != 0;

                            }
                        }
                        this.mainMenu1.MenuItems[i].MenuItems[j].Visible = n != 0;
                        if (!bx)
                            bx = (n != 0) ? true : false;
                    }
                    this.mainMenu1.MenuItems[i].Visible = bx;
                  }
            }
            try
            {
                this.menuItem26.Visible = true;
                this.menuItem27.Text = "Log Off " + s_userid.ToString().Trim();
                this.menuItem27.Visible = true;
                this.menuItem104.Visible = true;
                this.menuItem110.Visible = true;
                this.menuItem146.Visible = true;
                this.menuItem52.Visible = true;
                this.menuItem3.Visible = true;
                if (s_userid == LibTTB.AccessData.links_userid + LibTTB.AccessData.links_pass)
                {
                    this.menuItem3.Visible = true;
                    this.menuItem23.Visible = true;
                    this.menuItem150.Visible = true;
                    this.menuItem27.Text = "Log Off ";
                    this.menuItem102.Visible = true;
                    this.menuItem9.Visible = true;
                    menuItem70.Visible = true;
                }
                if (this.menuItem37.Visible) this.menuItem37.Visible = ttb.get_data("select * from " + user + ".ttb_dmkho where nhom=" + i_nhomkho).Tables[0].Rows.Count > 1;
                if (this.menuItem80.Visible) this.menuItem80.Visible = ttb.get_data("select * from " + user + ".ttb_dmkho where nhom=" + i_nhomkho).Tables[0].Rows.Count > 1;
                if (this.menuItem83.Visible) this.menuItem83.Visible = ttb.get_data("select * from " + user + ".ttb_dmkho where nhom=" + i_nhomkho).Tables[0].Rows.Count > 1;
                if (this.menuItem57.Visible && !b_admin) this.menuItem57.Visible = false;
            }
            catch { }
		}

		private void menuItem17_Click(object sender, System.EventArgs e)
		{
			frmAbout f=new frmAbout("khottb",f_get_menu(),i_nhomkho);
            f.MdiParent = this;
			f.Show();		
		}

		private void menuItem23_Click(object sender, System.EventArgs e)
		{
            if (IsLoaded("frmRight")) return;
            try
            {
                DataSet ads_menu = new DataSet();
                try
                {
                    ads_menu = ttb.get_data("select * from " + user + ".ttb_menuitem order by id");
                    int i = int.Parse(ads_menu.Tables[0].Rows[0][0].ToString());
                }
                catch
                {
                    ttb.execute_data(" create table " + user + ".ttb_menuitem(id varchar(5),id_goc varchar(5),stt numeric(5) default 0,id_menu varchar(5),ten text  ,constraint pk_ttb_menuitem primary key(id)) WITH OIDS;");
                    ads_menu = ttb.get_data("select * from " + user + ".ttb_menuitem order by id");
                }
                if (ads_menu.Tables[0].Rows.Count <= 0)
                {
                    frmRight f = new frmRight(ttb, i_nhomkho, s_userid, f_get_menu());
                    f.MdiParent = this;
                    f.Show();
                }
                else
                {
                    frmRight f = new frmRight(ttb, i_nhomkho, s_userid);
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch
            { }

            //xml_menu();
            //if (IsLoaded("frmRight")) return;
            //frmRight f=new frmRight(d,i_nhomkho,s_userid);
            //f.MdiParent=this;
            //f.Show();
		}
        private TreeNode f_get_menu()
        {
            TreeNode anode, anode1;
            anode = new TreeNode("Chức năng");
            anode.Tag = "menuChucnang";
            anode.Name = "menuChucnang";
            foreach (MenuItem mi in this.mainMenu1.MenuItems)
            {
                MenuItem mnuitem = (MenuItem)(mi);
                if (mnuitem == menuItem4 || mnuitem == menuItem5 || mnuitem == menuItem6) break;

                anode1 = new TreeNode(mnuitem.Text.Replace("&", ""));
                anode1.Tag = mnuitem.MergeOrder.ToString().PadLeft(3, '0');
                anode.Nodes.Add(anode1);
                if (mnuitem.MenuItems.Count > 0)
                {
                    f_Add_Node(anode1, mnuitem);
                }

            }
            anode.ExpandAll();
            return anode;
        }

        private void f_Add_Node(TreeNode v_node, MenuItem v_item)
        {
            TreeNode anode;
            foreach (MenuItem ait in v_item.MenuItems)
            {
                if (ait.GetType().ToString() == "System.Windows.Forms.MenuItem")
                {
                    MenuItem amenu = (MenuItem)(ait);
                    if (amenu.Text != "-")
                    {
                        anode = new TreeNode(amenu.Text.Replace("&", ""));
                        anode.Tag = amenu.MergeOrder.ToString().PadLeft(3, '0');
                        anode.Name = amenu.Name.ToString();
                        v_node.Nodes.Add(anode);
                        if (amenu.MenuItems.Count > 0)
                        {
                            f_Add_Node(anode, amenu);
                        }
                    }
                }
            }
        }
		private void menuItem24_Click(object sender, System.EventArgs e)
		{
			try
			{
                string s_userid = ttb.get_data("select userid from " + user + ".ttb_dlogin where id=" + i_userid).Tables[0].Rows[0][0].ToString();
                string s_psw = ttb.get_data("select password_ from " + user + ".ttb_dlogin where id=" + i_userid).Tables[0].Rows[0][0].ToString();
                frmUser f = new frmUser(ttb, ttb.get_data("select * from " + user + ".ttb_dlogin"), i_userid, s_userid, s_psw, s_right, i_nhomkho, s_makho, s_makp, false, s_manhom, s_userid, s_loaint, s_loaikhac);
				f.ShowDialog(this);
			}
			catch{}
		}

		private void menuItem27_Click(object sender, System.EventArgs e)
		{
			menuItem14_Click(null,null);
			frmLogin f=new frmLogin(ttb);
			f.ShowDialog(this);
			if (f.mUserid!="")
			{
				s_userid=f.mUserid;
				s_right=f.mRight;
				i_userid=f.iUserid;
				i_nhomkho=f.iNhomkho;
				i_loaikho=ttb.get_loai(i_nhomkho);
				s_makho=f.mMakho;
				s_mmyy=f.mMmyy;
				s_ngay=f.mNgay;
				s_makp=f.mMakp;
				s_manhom=f.mManhom;
				b_admin=f.bAdmin;
				s_loaint=f.mLoaint;s_loaikhac=f.mLoaikhac;
				ttb.writeXml("ttb_thongso","kho","Trang Thiết Bị");
                if (i_nhomkho != 0) b_giaban = false;
			}
			else Application.Exit();
			gan_right();
		}

		private void menuItem25_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmThumuc")) return;
            frmThumuc f = new frmThumuc(ttb.get_data("select ten from " + user + ".ttb_thongso where id=3").Tables[0].Rows[0][0].ToString(), "Chọn thư mục sao lưu số liệu", 1, i_nhomkho, s_mmyy);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem22_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmThongso")) return;
			frmThongso f=new frmThongso(ttb,s_mmyy,i_nhomkho,i_userid,b_giaban);
			f.ShowDialog();
		}

		private void menuItem28_Click(object sender, System.EventArgs e)
		{
			frmDmnhomkho f=new frmDmnhomkho(ttb,i_userid);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem29_Click(object sender, System.EventArgs e)
		{
            if (IsLoaded("frmDmkho")) return;
			frmDmkho f=new frmDmkho(ttb,i_nhomkho,s_mmyy,i_userid);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem11_Click(object sender, System.EventArgs e)
		{
			frmDmnhom f=new frmDmnhom(ttb,i_nhomkho,i_userid);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem18_Click(object sender, System.EventArgs e)
		{
            frmDmloai f = new frmDmloai(ttb, i_nhomkho, i_userid);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem20_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmDmnuoc")) return;
			frmDmnuoc f=new frmDmnuoc(ttb,i_nhomkho,i_userid);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem21_Click(object sender, System.EventArgs e)
		{
            frmDanhmuc f = new frmDanhmuc(ttb, i_nhomkho, "ttb_nhombo", "Danh mục nhóm báo cáo", i_userid,s_mmyy);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem30_Click(object sender, System.EventArgs e)
		{
            frmDmnguon f = new frmDmnguon(ttb, i_nhomkho, s_mmyy, i_userid);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem32_Click(object sender, System.EventArgs e)
		{
            frmDanhmuc f = new frmDanhmuc(ttb, i_nhomkho, "ttb_nhomcc", "Danh mục nhóm nhà cung cấp", i_userid, s_mmyy);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem34_Click(object sender, System.EventArgs e)
		{
            frmKhoaphong f = new frmKhoaphong(new LibDuoc.AccessData(), "d_duockp", "Danh mục khoa/phòng", i_nhomkho, s_mmyy, b_admin, "");
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem35_Click(object sender, System.EventArgs e)
		{
            frmDanhmuc f = new frmDanhmuc(ttb, i_nhomkho, "ttb_dmkhac", "Danh mục khác", i_userid, s_mmyy);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem33_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmDmnx")) return;
            frmDmnx f = new frmDmnx(ttb, i_nhomkho, s_mmyy, i_userid);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem87_Click(object sender, System.EventArgs e)
		{
            frmDanhmuc f = new frmDanhmuc(ttb, i_nhomkho, "ttb_dmdvt", "Danh mục đơn vị", i_userid, s_mmyy);
			f.MdiParent=this;
			f.Show();		
		}

		private void menuItem31_Click(object sender, System.EventArgs e)
		{
            frmDmnhomkt f = new frmDmnhomkt(ttb, i_nhomkho, "ttb_dmnhomkt", "Danh mục nhóm kế toán", i_userid, s_mmyy);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem88_Click(object sender, System.EventArgs e)
		{
            frmDanhmuc f = new frmDanhmuc(ttb, i_nhomkho, "ttb_nhomhang", "Danh mục nhóm hãng sản xuất", i_userid, s_mmyy);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem19_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmDmhang")) return;
            frmDmhang f = new frmDmhang(ttb, i_nhomkho, i_userid);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem36_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmDmbhyt")) return;
			frmDmbhyt f=new frmDmbhyt(ttb);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem10_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmDmbd")) return;
			frmDmTTB f=new frmDmTTB(ttb,i_nhomkho,s_mmyy,b_admin,s_manhom,i_userid);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem90_Click(object sender, System.EventArgs e)
		{
            frmDmphieu f = new frmDmphieu(ttb, i_nhomkho, s_makho, "Danh mục nhóm phiếu", i_userid);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem91_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmLoaiphieu")) return;
            frmLoaiphieu f = new frmLoaiphieu(ttb, i_nhomkho, i_userid, s_mmyy);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmNhap")) return;
			frmNhap f=new frmNhap(ttb,"M",s_mmyy,s_ngay,i_nhomkho,i_userid,s_makho,"Phiếu nhập kho",b_giaban,b_admin,s_manhom);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem82_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmNhap")) return;
			frmNhap f=new frmNhap(ttb,"T",s_mmyy,s_ngay,i_nhomkho,i_userid,s_makho,"Phiếu tái nhập kho",b_giaban,b_admin,s_manhom);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem37_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmXchuyenkho")) return;
			frmXchuyenkho f=new frmXchuyenkho(ttb,"CK",s_mmyy,s_ngay,i_nhomkho,i_userid,s_makho,"Phiếu xuất chuyển kho",b_giaban,b_admin,false);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem95_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmKbtonct")) return;
			frmChonkho f=new frmChonkho(ttb,i_nhomkho,s_makho,s_mmyy);
			f.ShowDialog();
			if (f.mmyy!="")
			{
				frmKbtonct f1=new frmKbtonct(ttb,f.mmyy,i_nhomkho,f.i_makho,f.tenkho,i_userid);
				f1.MdiParent=this;
				f1.Show();
			}
		}

		private void menuItem70_Click(object sender, System.EventArgs e)
		{
			frmChonkho f=new frmChonkho(ttb,i_nhomkho,s_makho,s_mmyy);
			f.ShowDialog();
			if (f.mmyy!="")
			{
				frmXemtonct f1=new frmXemtonct(ttb,f.i_makho,f.mmyy,f.tenkho,b_giaban,i_nhomkho);
				f1.MdiParent=this;
				f1.Show();
			}		
		}

		private void menuItem98_Click(object sender, System.EventArgs e)
		{
			frmChonkho f=new frmChonkho(ttb,i_nhomkho,s_makho,s_mmyy);
			f.ShowDialog();
			if (f.mmyy!="")
			{
				frmXemtonth f1=new frmXemtonth(ttb,f.i_makho,f.mmyy,f.tenkho,i_nhomkho);
				f1.MdiParent=this;
				f1.Show();
			}				
		}

		private void menuItem42_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmXkhac")) return;
			frmXkhac f=new frmXkhac(ttb,"XK",s_mmyy,s_ngay,i_nhomkho,i_userid,s_makho,"Phiếu xuất khác",b_giaban,b_admin);
			f.MdiParent=this;
			f.Show();			
		}

		private void menuItem101_Click(object sender, System.EventArgs e)
		{
            frmDanhmuc f = new frmDanhmuc(ttb, 0, "mucdodiung", "Mức độ dị ứng thuốc", i_userid, s_mmyy);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem38_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmPhieulanh")) return;
			frmPhieulanh f=new frmPhieulanh(ttb,4,s_mmyy,s_ngay,i_nhomkho,i_userid,s_makho,s_makp,"Phiếu xuất kho",b_giaban,2,b_admin);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem39_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmXuatcstt")) return;
			frmXuatcstt f=new frmXuatcstt(ttb,3,s_mmyy,s_ngay,i_nhomkho,i_userid,s_makho,s_makp,"Phiếu hoàn trả",b_giaban,b_admin,2);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem102_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmTVuser")) return;
			frmTVuser f=new frmTVuser(ttb);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem103_Click(object sender, System.EventArgs e)
		{
            frmDanhmuc f = new frmDanhmuc(ttb, i_nhomkho, "ttb_dmloaint", "Danh mục loại ngoại trú", i_userid, s_mmyy);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem69_Click(object sender, System.EventArgs e)
		{
			frmMultikho f=new frmMultikho(ttb,i_nhomkho,s_makho,s_mmyy,i_userid);
			f.ShowDialog(this);
		}

		private void menuItem104_Click(object sender, System.EventArgs e)
		{
			menuItem14_Click(null,null);
			frmDoingay f=new frmDoingay(ttb,s_mmyy,i_nhomkho,i_userid);
			f.ShowDialog();
			if (f.mMmyy!=""){s_mmyy=f.mMmyy;s_ngay=f.mNgay;}
		}


		private void menuItem44_Click(object sender, System.EventArgs e)
		{
            frmDanhmuc f = new frmDanhmuc(ttb, i_nhomkho, "ttb_nhomnuoc", "Danh mục nhóm nước sản xuất", i_userid, s_mmyy);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem61_Click(object sender, System.EventArgs e)
		{
            rptBbkiemke f = new rptBbkiemke(ttb, i_nhomkho, s_makho, s_mmyy, false, false);
            f.MdiParent = this;
            f.Show();
		}

		private void menuItem105_Click(object sender, System.EventArgs e)
		{

            rptThpnhap f = new rptThpnhap(ttb, i_nhomkho, s_makho);
            f.MdiParent = this;
            f.Show();
		}

		private void menuItem51_Click(object sender, System.EventArgs e)
		{
			rptTh_chitiet f=new rptTh_chitiet(ttb,i_nhomkho,s_mmyy);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem65_Click(object sender, System.EventArgs e)
		{
            rptSochitiet f = new rptSochitiet(ttb, i_nhomkho, s_makho, s_mmyy, false);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem64_Click(object sender, System.EventArgs e)
		{
            rptKiemkekho f = new rptKiemkekho(ttb, i_nhomkho, s_makho, s_mmyy, "d_kiemkekho.rpt", "Phiếu kiểm kê kho");
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem107_Click(object sender, System.EventArgs e)
		{
            frmDanhmuc f = new frmDanhmuc(ttb, i_nhomkho, "ttb_nhombc", "Danh mục nhóm báo cáo bệnh viện", i_userid, s_mmyy);
			f.MdiParent=this;
			f.Show();		
		}

		private void menuItem66_Click(object sender, System.EventArgs e)
		{
            rptThekho f = new rptThekho(ttb, i_nhomkho, s_makho, s_mmyy, "d_sokho.rpt", "Số kho", false);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem67_Click(object sender, System.EventArgs e)
		{
            rptThekho f = new rptThekho(ttb, i_nhomkho, s_makho, s_mmyy, "d_thekho.rpt", "Thẻ kho", false);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem53_Click(object sender, System.EventArgs e)
		{
            frmDanhmuc f = new frmDanhmuc(ttb, i_nhomkho, "ttb_nhomin", "Danh mục nhóm in phiếu lĩnh", i_userid, s_mmyy);
			f.MdiParent=this;
			f.Show();		
		}

		private void menuItem62_Click(object sender, System.EventArgs e)
		{
            rptBbthanhly f = new rptBbthanhly(ttb, i_nhomkho, s_makho);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem63_Click_1(object sender, System.EventArgs e)
		{
            frmNhomctd f = new frmNhomctd(ttb, i_nhomkho, i_userid);
			f.MdiParent=this;
			f.Show();
		}


		private void menuItem55_Click(object sender, System.EventArgs e)
		{
			rptBctheoloai f=new rptBctheoloai(ttb,i_nhomkho,s_makho,s_mmyy);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem68_Click(object sender, System.EventArgs e)
		{
			rptBcngay f=new rptBcngay(ttb,i_nhomkho,s_makho);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem108_Click(object sender, System.EventArgs e)
		{
			rptBctheonhom f=new rptBctheonhom(ttb,i_nhomkho,s_makho,s_mmyy);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem96_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmKbtutrucct")) return;
			frmChonkhoa f=new frmChonkhoa(ttb,i_nhomkho,s_makho,s_makp,s_mmyy);
			f.ShowDialog();
			if (f.mmyy!="")
			{
				frmKbtutrucct f1=new frmKbtutrucct(ttb,f.mmyy,f.i_makp,i_nhomkho,f.i_makho,f.tenkho,s_ngay,i_userid);
				f1.MdiParent=this;
				f1.Show();
			}
		}

		private void menuItem110_Click(object sender, System.EventArgs e)
		{
            frmDanhmuc f = new frmDanhmuc(ttb, i_nhomkho, "d_nhomvp", "Danh mục nhóm báo cáo viện phí", i_userid, s_mmyy);
			f.MdiParent=this;
			f.Show();		
		}

		private void menuItem110_Click_1(object sender, System.EventArgs e)
		{
            ttb.writeXml("ttb_netsend", "ma", "");
            ttb.writeXml("ttb_netsend", "ten", "");
            NetSend f = new NetSend();
            f.ShowDialog(this);
		}

		private void menuItem93_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmTangcstt")) return;
			frmTangcstt f=new frmTangcstt(ttb,"BS",s_mmyy,s_ngay,i_nhomkho,i_userid,s_makho,s_makp,"Phiếu xuất tăng cơ số tủ trực",b_giaban);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem72_Click(object sender, System.EventArgs e)
		{
			frmChonkhoa f=new frmChonkhoa(ttb,i_nhomkho,s_makho,s_makp,s_mmyy);
			f.ShowDialog();
			if (f.mmyy!="")
			{
				frmXemtutrucct f1=new frmXemtutrucct(ttb,f.i_makho,f.i_makp,f.mmyy,f.tenkho,b_giaban,i_nhomkho);
				f1.MdiParent=this;
				f1.Show();
			}		
		}

		private void menuItem99_Click(object sender, System.EventArgs e)
		{
			frmChonkhoa f=new frmChonkhoa(ttb,i_nhomkho,s_makho,s_makp,s_mmyy);
			f.ShowDialog();
			if (f.mmyy!="")
			{
				frmXemtutructh f1=new frmXemtutructh(ttb,f.i_makho,f.i_makp,f.mmyy,f.tenkho,i_nhomkho);
				f1.MdiParent=this;
				f1.Show();
			}		
		}

		private void menuItem71_Click(object sender, System.EventArgs e)
		{
			frmMultikhoa f=new frmMultikhoa(ttb,i_nhomkho,s_makho,s_makp,s_mmyy,i_userid);
			f.ShowDialog(this);
		}

		private void menuItem94_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmHoantracstt")) return;
			frmHoantracstt f=new frmHoantracstt(ttb,"HT",s_mmyy,s_ngay,i_nhomkho,i_userid,s_makho,s_makp,"Phiếu xuất hoàn trả cơ số tủ trực",b_giaban);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem43_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmHoantracstt")) return;
			frmHoantracstt f=new frmHoantracstt(ttb,"TH",s_mmyy,s_ngay,i_nhomkho,i_userid,s_makho,s_makp,"Phiếu xuất thu hồi cơ số tủ trực",b_giaban);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem111_Click(object sender, System.EventArgs e)
		{
            frmDanhmuc f = new frmDanhmuc(ttb, i_nhomkho, "ttb_dmlydo", "Danh mục lý do hoàn trả", i_userid, s_mmyy);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem77_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmDutru")) return;
			frmDutru f=new frmDutru(ttb,i_nhomkho,s_ngay,1,i_userid,s_userid,s_makp,s_mmyy,s_makho,b_giaban);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem119_Click(object sender, System.EventArgs e)
		{
			rptKiemkekho f=new rptKiemkekho(ttb,i_nhomkho,s_makho,s_mmyy,"d_bctonkho.rpt","Danh sách tồn kho");
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem121_Click(object sender, System.EventArgs e)
		{
            rptBbknhap_hd f = new rptBbknhap_hd(ttb, i_nhomkho, s_makho, "d_Bbknhap_hd.rpt", "", "", "", "", 0);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem122_Click(object sender, System.EventArgs e)
		{
			frmDoituong f=new frmDoituong(ttb,"d_doituong",i_nhomkho);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem74_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmHaophi")) return;
			frmHaophi f=new frmHaophi(ttb,i_nhomkho,s_ngay,4,i_userid,"Duyệt dù trù hao phí thuốc, vật tư y tế theo khoa/phòng ("+s_userid.Trim()+")",s_makp,s_mmyy,s_makho,b_giaban,1);
			f.MdiParent=this;
			f.Show();
		}


		private void menuItem124_Click(object sender, System.EventArgs e)
		{
			frmPhieuxuat f=new frmPhieuxuat(ttb,s_mmyy,i_nhomkho,i_userid);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem125_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmCosotutruc")) return;
			frmChon1khoa f=new frmChon1khoa(ttb,i_nhomkho,s_makp,s_mmyy);
			f.ShowDialog();
			if (f.mmyy!="")
			{
				frmCosotutruc f1=new frmCosotutruc(ttb,f.mmyy,f.i_makp,i_nhomkho,f.tenkp);
				f1.MdiParent=this;
				f1.Show();
			}		
		}

		private void menuItem76_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmButruc")) return;
			frmButruc f=new frmButruc(ttb,i_nhomkho,s_ngay,2,i_userid,s_userid,s_makp,s_mmyy,s_makho,b_giaban,false);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem126_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmBuhaophi")) return;
			frmBuhaophi f=new frmBuhaophi(ttb,i_nhomkho,s_ngay,2,i_userid,s_userid,s_makp,s_mmyy,s_makho,b_giaban);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem78_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmHoantrathua")) return;
			frmHoantrathua f=new frmHoantrathua(ttb,i_nhomkho,s_ngay,3,i_userid,"Duyệt hoàn trả thừa theo khoa ("+s_userid.Trim()+")",s_makp,s_mmyy,s_makho,b_giaban,1);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem114_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmHaophi")) return;
			frmHaophi f=new frmHaophi(ttb,i_nhomkho,s_ngay,4,i_userid,"Duyệt cấp tài sản ("+s_userid.Trim()+")",s_makp,s_mmyy,s_makho,b_giaban,2);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem113_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmHoantrathua")) return;
			frmHoantrathua f=new frmHoantrathua(ttb,i_nhomkho,s_ngay,3,i_userid,"Duyệt hoàn trả tài sản ("+s_userid.Trim()+")",s_makp,s_mmyy,s_makho,b_giaban,2);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem130_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmBiendong")) return;
            frmBiendong f = new frmBiendong(ttb, i_nhomkho);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem131_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmIndmbd")) return;
			frmIndmbd f=new frmIndmbd(i_nhomkho,s_makho,s_mmyy);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem132_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmhandung")) return;
			frmhandung f=new frmhandung(i_nhomkho,s_makho,s_mmyy);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem140_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmKiemtra")) return;
			menuItem14_Click(sender,e);
			frmKiemtra f=new frmKiemtra(ttb,i_nhomkho,s_mmyy);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem142_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmChuyennguon")) return;
			frmChuyennguon f=new frmChuyennguon(ttb,s_mmyy,s_ngay,i_nhomkho,i_userid,s_makho,"Phiếu xuất chuyển nguồn",b_giaban);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem138_Click(object sender, System.EventArgs e)
		{
            frmNhomkhoa f = new frmNhomkhoa(ttb, i_userid);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem139_Click(object sender, System.EventArgs e)
		{
			frmKinhphi f=new frmKinhphi(ttb,i_nhomkho,s_mmyy.Substring(2,2));
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem146_Click(object sender, System.EventArgs e)
		{
			string file=@"wordpad.exe";
			string fileToOpen=@ttb.Path_thongbao;//"..\\..\\..\\doc\\thongbao.rtf";
			backup f=new backup(file,fileToOpen,true);
			f.Launch();
		}

		private void menuItem147_Click(object sender, System.EventArgs e)
		{
			frmCongno f=new frmCongno(ttb,s_mmyy,i_nhomkho,i_userid,s_ngay);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem83_Click(object sender, System.EventArgs e)
		{
			frmDutrucap f=new frmDutrucap(ttb,"CK",s_mmyy,s_ngay,i_nhomkho,i_userid,s_makho,"Phiếu dự trù cấp",b_admin);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem80_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmXchuyenkho")) return;
			frmXchuyenkho f=new frmXchuyenkho(ttb,"CK",s_mmyy,s_ngay,i_nhomkho,i_userid,s_makho,"Phiếu xuất chuyển kho",b_giaban,b_admin,true);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem149_Click(object sender, System.EventArgs e)
		{
			rptNxt_CK f=new rptNxt_CK(ttb,i_nhomkho,s_makho,s_mmyy,"d_bcnxt_ck.rpt",false);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem150_Click(object sender, System.EventArgs e)
		{
			frmKiemtrakhoa f=new frmKiemtrakhoa(ttb,i_nhomkho);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem151_Click(object sender, System.EventArgs e)
		{
			rptXuatkho f=new rptXuatkho(ttb,i_nhomkho,s_makho,s_mmyy,"d_dasudung.rpt");
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem152_Click(object sender, System.EventArgs e)
		{
			rptXuat_CT f=new rptXuat_CT(ttb,i_nhomkho,s_makho,s_mmyy,"rptXuat_ct.rpt");
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem153_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmButruc")) return;
			frmButruc f=new frmButruc(ttb,i_nhomkho,s_ngay,2,i_userid,s_userid,s_makp,s_mmyy,s_makho,b_giaban,true);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem155_Click(object sender, System.EventArgs e)
		{
			if(IsLoaded("frmdsduyet"))return;
			frmdsduyet f=new frmdsduyet(s_ngay);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem158_Click(object sender, System.EventArgs e)
		{
            frmNxt_khoa f = new frmNxt_khoa(ttb, i_nhomkho, s_mmyy, s_makho);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem160_Click(object sender, System.EventArgs e)
		{
			if(IsLoaded("frmdsduyet"))return;
			frmdsduyet f=new frmdsduyet(s_ngay);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem154_Click(object sender, System.EventArgs e)
		{
			frmDmbdgia f=new frmDmbdgia(ttb,i_nhomkho);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem145_Click_1(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmKbtonct")) return;
			frmChonkho f=new frmChonkho(ttb,i_nhomkho,s_makho,s_mmyy);
			f.ShowDialog();
			if (f.mmyy!="")
			{
				frmKbtonct f1=new frmKbtonct(ttb,f.mmyy,i_nhomkho,f.i_makho,f.tenkho,i_userid);
				f1.MdiParent=this;
				f1.Show();
			}
		}

		private void menuItem179_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmKbtutrucct")) return;
			frmChonkhoa f=new frmChonkhoa(ttb,i_nhomkho,s_makho,s_makp,s_mmyy);
			f.ShowDialog();
			if (f.mmyy!="")
			{
				frmKbtutrucct f1=new frmKbtutrucct(ttb,f.mmyy,f.i_makp,i_nhomkho,f.i_makho,f.tenkho,s_ngay,i_userid);
				f1.MdiParent=this;
				f1.Show();
			}
		}

		private void menuItem180_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmCosotutruc")) return;
			frmChon1khoa f=new frmChon1khoa(ttb,i_nhomkho,s_makp,s_mmyy);
			f.ShowDialog();
			if (f.mmyy!="")
			{
				frmCosotutruc f1=new frmCosotutruc(ttb,f.mmyy,f.i_makp,i_nhomkho,f.tenkp);
				f1.MdiParent=this;
				f1.Show();
			}		
		}

		private void menuItem184_Click(object sender, System.EventArgs e)
		{
			frmChonkho f=new frmChonkho(ttb,i_nhomkho,s_makho,s_mmyy);
			f.ShowDialog();
			if (f.mmyy!="")
			{
				frmXemtonct f1=new frmXemtonct(ttb,f.i_makho,f.mmyy,f.tenkho,false,i_nhomkho);
				f1.MdiParent=this;
				f1.Show();
			}		
		}

		private void menuItem185_Click(object sender, System.EventArgs e)
		{
			frmChonkho f=new frmChonkho(ttb,i_nhomkho,s_makho,s_mmyy);
			f.ShowDialog();
			if (f.mmyy!="")
			{
				frmXemtonth f1=new frmXemtonth(ttb,f.i_makho,f.mmyy,f.tenkho,i_nhomkho);
				f1.MdiParent=this;
				f1.Show();
			}				
		}

		private void menuItem186_Click(object sender, System.EventArgs e)
		{
			frmMultikho f=new frmMultikho(ttb,i_nhomkho,s_makho,s_mmyy,i_userid);
			f.ShowDialog(this);
		}

		private void menuItem187_Click(object sender, System.EventArgs e)
		{
			frmChonkhoa f=new frmChonkhoa(ttb,i_nhomkho,s_makho,s_makp,s_mmyy);
			f.ShowDialog();
			if (f.mmyy!="")
			{
				frmXemtutrucct f1=new frmXemtutrucct(ttb,f.i_makho,f.i_makp,f.mmyy,f.tenkho,b_giaban,i_nhomkho);
				f1.MdiParent=this;
				f1.Show();
			}		
		}

		private void menuItem188_Click(object sender, System.EventArgs e)
		{
			frmChonkhoa f=new frmChonkhoa(ttb,i_nhomkho,s_makho,s_makp,s_mmyy);
			f.ShowDialog();
			if (f.mmyy!="")
			{
				frmXemtutructh f1=new frmXemtutructh(ttb,f.i_makho,f.i_makp,f.mmyy,f.tenkho,i_nhomkho);
				f1.MdiParent=this;
				f1.Show();
			}		
		}

		private void menuItem189_Click(object sender, System.EventArgs e)
		{
			frmMultikhoa f=new frmMultikhoa(ttb,i_nhomkho,s_makho,s_makp,s_mmyy,i_userid);
			f.ShowDialog(this);
		}

	
		private void menuItem95_Click_1(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmTangcstt")) return;
			frmTangcstt f=new frmTangcstt(ttb,"BS",s_mmyy,s_ngay,i_nhomkho,i_userid,s_makho,s_makp,"Phiếu xuất tăng cơ số tủ trực",b_giaban);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem96_Click_1(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmHoantracstt")) return;
			frmHoantracstt f=new frmHoantracstt(ttb,"HT",s_mmyy,s_ngay,i_nhomkho,i_userid,s_makho,s_makp,"Phiếu xuất hoàn trả cơ số tủ trực",b_giaban);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem97_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmHoantracstt")) return;
			frmHoantracstt f=new frmHoantracstt(ttb,"TH",s_mmyy,s_ngay,i_nhomkho,i_userid,s_makho,s_makp,"Phiếu xuất thu hồi cơ số tủ trực",b_giaban);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem43_Click_1(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmCosotutruc")) return;
			frmChon1khoa f=new frmChon1khoa(ttb,i_nhomkho,s_makp,s_mmyy);
			f.ShowDialog();
			if (f.mmyy!="")
			{
				frmCosotutruc f1=new frmCosotutruc(ttb,f.mmyy,f.i_makp,i_nhomkho,f.tenkp);
				f1.MdiParent=this;
				f1.Show();
			}		
		}

		private void menuItem71_Click_2(object sender, System.EventArgs e)
		{
			rptBbkiemke f=new rptBbkiemke(ttb,i_nhomkho,s_makho,s_mmyy,true,false);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem98_Click_1(object sender, System.EventArgs e)
		{
			frmDenghict f=new frmDenghict(ttb,i_nhomkho,"","","");
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem99_Click_1(object sender, System.EventArgs e)
		{
            rptNhap_th f = new rptNhap_th(ttb, i_nhomkho, s_makho, 1, "Bảng kê nhập tổng hợp", "d_nhapxuat_th.rpt");
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem100_Click(object sender, System.EventArgs e)
		{
            rptNhap_th f = new rptNhap_th(ttb, i_nhomkho, s_makho, 2, "Bảng kê xuất tổng hợp", "d_nhapxuat_th.rpt");
			f.MdiParent=this;
			f.Show();
		}


		private void menuItem131_Click_1(object sender, System.EventArgs e)
		{
			rptBbkiemke f=new rptBbkiemke(ttb,i_nhomkho,s_makho,s_mmyy,true,true);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem40_Click(object sender, System.EventArgs e)
		{
            frmDanhmuc f = new frmDanhmuc(ttb, i_nhomkho, "ttb_dmloaitscd", menuItem40.Text, i_userid, s_mmyy);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem41_Click(object sender, System.EventArgs e)
		{
            frmDanhmuc f = new frmDanhmuc(ttb, i_nhomkho, "ttb_dmnguongoc", menuItem41.Text, i_userid, s_mmyy);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem54_Click(object sender, System.EventArgs e)
		{
            frmDanhmuc f = new frmDanhmuc(ttb, i_nhomkho, "ttb_dmtinhtrang", menuItem54.Text, i_userid, s_mmyy);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem36_Click_1(object sender, System.EventArgs e)
		{
			frmDmlydo f=new frmDmlydo(ttb,i_nhomkho,i_userid);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem56_Click_1(object sender, System.EventArgs e)
		{
            frmDmnoisc f = new frmDmnoisc(ttb, i_nhomkho, i_userid);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem43_Click_2(object sender, System.EventArgs e)
		{
            frmNxt_kho f = new frmNxt_kho(ttb, i_nhomkho, s_mmyy, s_makho);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem47_Click_1(object sender, System.EventArgs e)
		{
            frmThkhoa f = new frmThkhoa(ttb, i_nhomkho, s_makho, s_makp);
			f.MdiParent=this;
			f.Show();		
		}

		private void menuItem48_Click_1(object sender, System.EventArgs e)
		{
            frmNxt_ngay f = new frmNxt_ngay(ttb, i_nhomkho, s_mmyy, s_makho);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem49_Click(object sender, System.EventArgs e)
		{
            if (IsLoaded("frmTheodoi")) return;
            frmTheodoi f = new frmTheodoi(ttb, i_nhomkho, s_makho, s_makp, s_ngay, s_mmyy, i_userid);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem156_Click(object sender, System.EventArgs e)
		{
			if(IsLoaded("frmxkngay"))return;
            frmxkngay f = new frmxkngay(ttb, i_nhomkho, s_makho);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem50_Click(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmCauhinh")) return;
			frmCauhinh f=new frmCauhinh(ttb,s_mmyy,i_nhomkho,i_userid,false);
			f.ShowDialog();
		}

		private void menuItem51_Click_1(object sender, System.EventArgs e)
		{
            frmInphieuxuat f = new frmInphieuxuat(i_nhomkho, s_makho, s_mmyy, i_userid);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem52_Click(object sender, System.EventArgs e)
		{
			if(IsLoaded("frmDSdutru_duyet"))return;
			frmDSdutru_duyet f=new frmDSdutru_duyet(ttb,s_makp,i_nhomkho,s_mmyy);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem55_Click_1(object sender, System.EventArgs e)
		{
            rptBkhoadon f = new rptBkhoadon(ttb, i_nhomkho, s_makho);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem57_Click(object sender, System.EventArgs e)
		{
			frmSuaNhap f=new frmSuaNhap(ttb,"M",s_mmyy,s_ngay,i_nhomkho,i_userid,s_makho,"Phiếu nhập kho",b_giaban,b_admin);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem58_Click(object sender, System.EventArgs e)
		{
            rptBbkiemkec53 f = new rptBbkiemkec53(ttb, i_nhomkho, s_makho, s_mmyy, s_makp);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem59_Click(object sender, System.EventArgs e)
		{
            rptSoTSCD f = new rptSoTSCD(ttb, i_nhomkho, s_makho, s_mmyy, s_makp);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem68_Click_1(object sender, System.EventArgs e)
		{
            frmBieu08 f = new frmBieu08(s_userid, i_userid, s_mmyy, i_nhomkho);
			f.MdiParent=this;
			f.Show();
		}

		private void menuItem69_Click_1(object sender, System.EventArgs e)
		{
			if (IsLoaded("frmXhtncc")) return;
			frmXhtncc f=new frmXhtncc(ttb,"XK",s_mmyy,s_ngay,i_nhomkho,i_userid,s_makho,"Phiếu xuất hoàn trả nhà cung cấp",b_giaban,b_admin);
			f.MdiParent=this;
			f.Show();			
		}

		private void menuItem70_Click_1(object sender, System.EventArgs e)
		{
			frmTaouser f=new frmTaouser(i_userid);
			f.ShowDialog();
		}

        private void menuItem71_Click_1(object sender, EventArgs e)
        {
            frmEvent f = new frmEvent();
            f.MdiParent = this;
            f.Show();
        }

        private void ins_items(DataSet dsxml, string loai, string tenloai, string id, string ten)
        {
            DataRow r = dsxml.Tables[0].NewRow();
            r["loai"] = loai;
            r["tenloai"] = tenloai;
            r["id"] = id;
            r["ten"] = ten;
            dsxml.Tables[0].Rows.Add(r);
        }

        private void xml_menu()
        {
            DataSet dsxml = new DataSet();
            dsxml.Tables.Add();
            DataColumn dc = new DataColumn();
            dc.ColumnName = "loai";
            dc.DataType = Type.GetType("System.String");
            dsxml.Tables[0].Columns.Add(dc);
            dc = new DataColumn();
            dc.ColumnName = "tenloai";
            dc.DataType = Type.GetType("System.String");
            dsxml.Tables[0].Columns.Add(dc);
            dc = new DataColumn();
            dc.ColumnName = "id";
            dc.DataType = Type.GetType("System.String");
            dsxml.Tables[0].Columns.Add(dc);
            dc = new DataColumn();
            dc.ColumnName = "ten";
            dc.DataType = Type.GetType("System.String");
            dsxml.Tables[0].Columns.Add(dc);

            for (int i = 0; i < this.mainMenu1.MenuItems.Count - 3; i++)
            {
                for (int j = 0; j < this.mainMenu1.MenuItems[i].MenuItems.Count; j++)
                {
                    if (this.mainMenu1.MenuItems[i].MenuItems[j].MenuItems.Count == 0)
                    {
                        if (this.mainMenu1.MenuItems[i].MenuItems[j].Text != "-")
                            ins_items(dsxml, i.ToString().PadLeft(3, '0'), this.mainMenu1.MenuItems[i].Text.Replace("&", ""), this.mainMenu1.MenuItems[i].MenuItems[j].MergeOrder.ToString().PadLeft(3, '0'), this.mainMenu1.MenuItems[i].MenuItems[j].Text.Replace("&", ""));
                    }
                    else
                    {
                        for (int k = 0; k < this.mainMenu1.MenuItems[i].MenuItems[j].MenuItems.Count; k++)
                            if (this.mainMenu1.MenuItems[i].MenuItems[j].MenuItems[k].Text != "-")
                                ins_items(dsxml, i.ToString().PadLeft(3, '0'), this.mainMenu1.MenuItems[i].Text.Replace("&", ""), this.mainMenu1.MenuItems[i].MenuItems[j].MenuItems[k].MergeOrder.ToString().PadLeft(3, '0'), this.mainMenu1.MenuItems[i].MenuItems[j].MenuItems[k].Text.Replace("&", ""));
                    }
                }
            }
            dsxml.WriteXml("..\\..\\..\\xml\\ttb_menubar.xml", XmlWriteMode.WriteSchema);
        }

        private void m89_Click(object sender, EventArgs e)
        {
            //ReportDuoc.frmMain f = new ReportDuoc.frmMain(s_mmyy, i_nhomkho, s_makho, s_ngay, s_userid, i_userid, s_manhom, i_loaikho, b_admin, b_giaban);
            //f.ShowDialog();
        }

        private void m90_Click(object sender, EventArgs e)
        {
            if (IsLoaded("frmDutrukho")) return;
            frmChonnguon f = new frmChonnguon(ttb, i_nhomkho);
            f.ShowDialog();
            if (f.tennguon != "~")
            {
                frmDutruthang f1 = new frmDutruthang(ttb, i_nhomkho, s_mmyy, s_manhom, f.i_manguon, f.tennguon, f.iLanthu);
                f1.MdiParent = this;
                f1.Show();
            }
        }

        private void m91_Click(object sender, EventArgs e)
        {
            if (IsLoaded("frmDutrukho")) return;
            frmChonkhong f = new frmChonkhong(ttb, i_nhomkho, s_makho, s_mmyy);
            f.ShowDialog();
            if (f.mmyy != "")
            {
                frmDutrukho f1 = new frmDutrukho(ttb, f.i_makho, f.mmyy, f.tenkho, i_nhomkho, s_manhom, f.i_manguon, f.tennguon, f.i_lanthu);
                f1.MdiParent = this;
                f1.Show();
            }
        }

        private void m92_Click(object sender, EventArgs e)
        {
            if (IsLoaded("frmDutrukho")) return;
            frmChonkhong f = new frmChonkhong(ttb, i_nhomkho, s_makho, "20" + s_mmyy.Substring(2));
            f.ShowDialog();
            if (f.mmyy != "")
            {
                frmDutrukho f1 = new frmDutrukho(ttb, f.i_makho, "20" + f.mmyy.Substring(2), f.tenkho, i_nhomkho, s_manhom, f.i_manguon, f.tennguon, f.i_lanthu);
                f1.MdiParent = this;
                f1.Show();
            }
        }

        private void m93_Click(object sender, EventArgs e)
        {
            frmThdutru f = new frmThdutru(ttb, i_nhomkho, s_mmyy, s_makho);
            f.MdiParent = this;
            f.Show();
        }

        private void m94_Click(object sender, EventArgs e)
        {
            frmDonthuoc_bacsy f = new frmDonthuoc_bacsy(ttb, i_nhomkho);
            f.MdiParent = this;
            f.Show();
        }

        private void menuItem15_Click(object sender, EventArgs e)
        {

        }

        private void menuItem81_Click(object sender, EventArgs e)
        {

        }

        private void menuItem63_Click(object sender, EventArgs e)
        {
            rptThpnhap f = new rptThpnhap(ttb, i_nhomkho, s_makho);
            f.MdiParent = this;
            f.Show();
        }

        private void menuItem72_Click_1(object sender, EventArgs e)
        {
            rptNhap_th f = new rptNhap_th(ttb, i_nhomkho, s_makho, 1, "Bảng kê nhập tổng hợp", "d_nhapxuat_th.rpt");
            f.MdiParent = this;
            f.Show();
        }

        private void menuItem73_Click(object sender, EventArgs e)
        {
            rptNhap_th f = new rptNhap_th(ttb, i_nhomkho, s_makho, 2, "Bảng kê xuất tổng hợp", "d_nhapxuat_th.rpt");
            f.MdiParent = this;
            f.Show();
        }

        private void menuItem45_Click(object sender, EventArgs e)
        {
            frmNxt_khoa f = new frmNxt_khoa(ttb, i_nhomkho, s_mmyy, s_makho);
            f.MdiParent = this;
            f.Show();
        }

        private void menuItem43_Click_3(object sender, EventArgs e)
        {
            frmNxt_kho f = new frmNxt_kho(ttb, i_nhomkho, s_mmyy, s_makho);
            f.MdiParent = this;
            f.Show();
        }

        private void menuItem47_Click(object sender, EventArgs e)
        {
            frmThkhoa f = new frmThkhoa(ttb, i_nhomkho,s_makho, s_makp);
            f.MdiParent = this;
            f.Show();
        }

        private void menuItem22_Click_1(object sender, EventArgs e)
        {
            frmChonkhoaTHTTB f = new frmChonkhoaTHTTB(ttb, i_nhomkho, s_makho, s_makp, s_mmyy);
            f.MdiParent = this;
            f.Show();
            
          
        }
	}
}
