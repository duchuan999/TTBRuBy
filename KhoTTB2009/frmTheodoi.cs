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
	/// Summary description for frmTheodoi.
	/// </summary>
	public class frmTheodoi : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox hinh;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.DataGrid dataGrid2;
		private System.Windows.Forms.DataGrid dataGrid3;
		private System.Windows.Forms.DataGrid dataGrid4;
		private System.Windows.Forms.Button butTDC;
		private System.Windows.Forms.Button butSDC;
		private System.Windows.Forms.Button butSLC;
		private System.Windows.Forms.Button butTLC;
		private System.Windows.Forms.Button butSSC;
		private System.Windows.Forms.Button butTSC;
        private DataTable dtkhoa = new DataTable();
		private DataTable dtts=new DataTable();
		private DataTable dtdc=new DataTable();
		private DataTable dtlc=new DataTable();
		private DataTable dtsc=new DataTable();
		private decimal l_id;
		private int i_nhom,i_userid;
        private LibDuoc.AccessData d=new LibDuoc.AccessData();
        private LibTTB.AccessData ttb;
		private string s_makho,s_makp,sql,hinh_ttb,s_ngay,s_mmyy,user,link;
		private System.Windows.Forms.Button butKetthuc;
		private System.Windows.Forms.ComboBox makp;
		private System.Windows.Forms.Button butLoc;
        private TextBox tim;
        private Button butXoa;
        private Button butXoadc;
        private Button butXoalc;
        private SplitContainer splitContainer1;
        private TreeView treeView1;
        private Label label1;
        private ToolTip toolTip1;
        private IContainer components;

		public frmTheodoi(AccessData acc,int nhom,string makho,string makp,string ngay,string mmyy,int userid)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();s_ngay=ngay;s_mmyy=mmyy;
			ttb=acc;i_nhom=nhom;s_makho=makho;s_makp=makp;
            i_userid = userid;
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTheodoi));
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.hinh = new System.Windows.Forms.PictureBox();
            this.dataGrid2 = new System.Windows.Forms.DataGrid();
            this.dataGrid3 = new System.Windows.Forms.DataGrid();
            this.dataGrid4 = new System.Windows.Forms.DataGrid();
            this.butTDC = new System.Windows.Forms.Button();
            this.butSDC = new System.Windows.Forms.Button();
            this.butSLC = new System.Windows.Forms.Button();
            this.butTLC = new System.Windows.Forms.Button();
            this.butSSC = new System.Windows.Forms.Button();
            this.butTSC = new System.Windows.Forms.Button();
            this.butKetthuc = new System.Windows.Forms.Button();
            this.makp = new System.Windows.Forms.ComboBox();
            this.butLoc = new System.Windows.Forms.Button();
            this.tim = new System.Windows.Forms.TextBox();
            this.butXoa = new System.Windows.Forms.Button();
            this.butXoadc = new System.Windows.Forms.Button();
            this.butXoalc = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid4)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.dataGrid1.Location = new System.Drawing.Point(4, 3);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro;
            this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.RowHeaderWidth = 10;
            this.dataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue;
            this.dataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid1.Size = new System.Drawing.Size(753, 249);
            this.dataGrid1.TabIndex = 20;
            this.dataGrid1.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
            // 
            // hinh
            // 
            this.hinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.hinh.Location = new System.Drawing.Point(3, 338);
            this.hinh.Name = "hinh";
            this.hinh.Size = new System.Drawing.Size(206, 188);
            this.hinh.TabIndex = 21;
            this.hinh.TabStop = false;
            // 
            // dataGrid2
            // 
            this.dataGrid2.AlternatingBackColor = System.Drawing.Color.Lavender;
            this.dataGrid2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid2.CaptionBackColor = System.Drawing.SystemColors.Control;
            this.dataGrid2.CaptionFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid2.CaptionForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid2.CaptionText = "Dụng cụ kèm theo";
            this.dataGrid2.DataMember = "";
            this.dataGrid2.FlatMode = true;
            this.dataGrid2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid2.GridLineColor = System.Drawing.Color.Gainsboro;
            this.dataGrid2.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dataGrid2.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dataGrid2.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid2.LinkColor = System.Drawing.Color.Teal;
            this.dataGrid2.Location = new System.Drawing.Point(4, 258);
            this.dataGrid2.Name = "dataGrid2";
            this.dataGrid2.ParentRowsBackColor = System.Drawing.Color.Gainsboro;
            this.dataGrid2.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid2.ReadOnly = true;
            this.dataGrid2.RowHeaderWidth = 10;
            this.dataGrid2.SelectionBackColor = System.Drawing.Color.CadetBlue;
            this.dataGrid2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid2.Size = new System.Drawing.Size(750, 117);
            this.dataGrid2.TabIndex = 22;
            // 
            // dataGrid3
            // 
            this.dataGrid3.AlternatingBackColor = System.Drawing.Color.Lavender;
            this.dataGrid3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGrid3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid3.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid3.CaptionBackColor = System.Drawing.SystemColors.Control;
            this.dataGrid3.CaptionFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid3.CaptionForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid3.CaptionText = "Quá trình di chuyển";
            this.dataGrid3.DataMember = "";
            this.dataGrid3.FlatMode = true;
            this.dataGrid3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid3.GridLineColor = System.Drawing.Color.Gainsboro;
            this.dataGrid3.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dataGrid3.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dataGrid3.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid3.LinkColor = System.Drawing.Color.Teal;
            this.dataGrid3.Location = new System.Drawing.Point(4, 379);
            this.dataGrid3.Name = "dataGrid3";
            this.dataGrid3.ParentRowsBackColor = System.Drawing.Color.Gainsboro;
            this.dataGrid3.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid3.ReadOnly = true;
            this.dataGrid3.RowHeaderWidth = 10;
            this.dataGrid3.SelectionBackColor = System.Drawing.Color.CadetBlue;
            this.dataGrid3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid3.Size = new System.Drawing.Size(373, 145);
            this.dataGrid3.TabIndex = 23;
            // 
            // dataGrid4
            // 
            this.dataGrid4.AlternatingBackColor = System.Drawing.Color.Lavender;
            this.dataGrid4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid4.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid4.CaptionBackColor = System.Drawing.SystemColors.Control;
            this.dataGrid4.CaptionFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid4.CaptionForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid4.CaptionText = "Quá trình sửa chữa";
            this.dataGrid4.DataMember = "";
            this.dataGrid4.FlatMode = true;
            this.dataGrid4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid4.GridLineColor = System.Drawing.Color.Gainsboro;
            this.dataGrid4.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dataGrid4.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dataGrid4.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid4.LinkColor = System.Drawing.Color.Teal;
            this.dataGrid4.Location = new System.Drawing.Point(379, 379);
            this.dataGrid4.Name = "dataGrid4";
            this.dataGrid4.ParentRowsBackColor = System.Drawing.Color.Gainsboro;
            this.dataGrid4.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid4.ReadOnly = true;
            this.dataGrid4.RowHeaderWidth = 10;
            this.dataGrid4.SelectionBackColor = System.Drawing.Color.CadetBlue;
            this.dataGrid4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid4.Size = new System.Drawing.Size(376, 145);
            this.dataGrid4.TabIndex = 24;
            // 
            // butTDC
            // 
            this.butTDC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butTDC.BackColor = System.Drawing.SystemColors.Control;
            this.butTDC.ForeColor = System.Drawing.Color.Black;
            this.butTDC.Image = ((System.Drawing.Image)(resources.GetObject("butTDC.Image")));
            this.butTDC.Location = new System.Drawing.Point(708, 260);
            this.butTDC.Name = "butTDC";
            this.butTDC.Size = new System.Drawing.Size(22, 19);
            this.butTDC.TabIndex = 25;
            this.toolTip1.SetToolTip(this.butTDC, "Thêm dụng cụ kèm theo");
            this.butTDC.UseVisualStyleBackColor = true;
            this.butTDC.Click += new System.EventHandler(this.butTDC_Click);
            // 
            // butSDC
            // 
            this.butSDC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butSDC.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.butSDC.Location = new System.Drawing.Point(888, 481);
            this.butSDC.Name = "butSDC";
            this.butSDC.Size = new System.Drawing.Size(48, 19);
            this.butSDC.TabIndex = 26;
            this.butSDC.Text = "Sửa";
            this.butSDC.Visible = false;
            // 
            // butSLC
            // 
            this.butSLC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butSLC.ForeColor = System.Drawing.Color.Black;
            this.butSLC.Image = ((System.Drawing.Image)(resources.GetObject("butSLC.Image")));
            this.butSLC.Location = new System.Drawing.Point(352, 381);
            this.butSLC.Name = "butSLC";
            this.butSLC.Size = new System.Drawing.Size(22, 19);
            this.butSLC.TabIndex = 28;
            this.toolTip1.SetToolTip(this.butSLC, "Sửa lại quá trình di chuyển dụng cụ");
            this.butSLC.Click += new System.EventHandler(this.butSLC_Click);
            // 
            // butTLC
            // 
            this.butTLC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butTLC.BackColor = System.Drawing.SystemColors.Control;
            this.butTLC.ForeColor = System.Drawing.Color.Black;
            this.butTLC.Image = ((System.Drawing.Image)(resources.GetObject("butTLC.Image")));
            this.butTLC.Location = new System.Drawing.Point(308, 381);
            this.butTLC.Name = "butTLC";
            this.butTLC.Size = new System.Drawing.Size(22, 19);
            this.butTLC.TabIndex = 27;
            this.toolTip1.SetToolTip(this.butTLC, "Thêm quá trình di chuyển dụng cụ");
            this.butTLC.UseVisualStyleBackColor = false;
            this.butTLC.Click += new System.EventHandler(this.butTLC_Click);
            // 
            // butSSC
            // 
            this.butSSC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butSSC.ForeColor = System.Drawing.Color.Black;
            this.butSSC.Image = ((System.Drawing.Image)(resources.GetObject("butSSC.Image")));
            this.butSSC.Location = new System.Drawing.Point(730, 381);
            this.butSSC.Name = "butSSC";
            this.butSSC.Size = new System.Drawing.Size(22, 19);
            this.butSSC.TabIndex = 30;
            this.toolTip1.SetToolTip(this.butSSC, "Sửa lại quá trình sửa chữa dụng cụ");
            this.butSSC.UseVisualStyleBackColor = false;
            this.butSSC.Click += new System.EventHandler(this.butSSC_Click);
            // 
            // butTSC
            // 
            this.butTSC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butTSC.BackColor = System.Drawing.SystemColors.Control;
            this.butTSC.ForeColor = System.Drawing.Color.Black;
            this.butTSC.Image = ((System.Drawing.Image)(resources.GetObject("butTSC.Image")));
            this.butTSC.Location = new System.Drawing.Point(686, 381);
            this.butTSC.Name = "butTSC";
            this.butTSC.Size = new System.Drawing.Size(22, 19);
            this.butTSC.TabIndex = 29;
            this.toolTip1.SetToolTip(this.butTSC, "Thêm quá trình sửa chữa dụng cụ");
            this.butTSC.UseVisualStyleBackColor = false;
            this.butTSC.Click += new System.EventHandler(this.butTSC_Click);
            // 
            // butKetthuc
            // 
            this.butKetthuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butKetthuc.BackColor = System.Drawing.SystemColors.Control;
            this.butKetthuc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butKetthuc.ForeColor = System.Drawing.Color.Black;
            this.butKetthuc.Image = ((System.Drawing.Image)(resources.GetObject("butKetthuc.Image")));
            this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butKetthuc.Location = new System.Drawing.Point(734, 3);
            this.butKetthuc.Name = "butKetthuc";
            this.butKetthuc.Size = new System.Drawing.Size(21, 22);
            this.butKetthuc.TabIndex = 31;
            this.butKetthuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.butKetthuc, "Kết thúc");
            this.butKetthuc.UseVisualStyleBackColor = true;
            this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
            // 
            // makp
            // 
            this.makp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makp.Location = new System.Drawing.Point(749, 22);
            this.makp.Name = "makp";
            this.makp.Size = new System.Drawing.Size(174, 21);
            this.makp.TabIndex = 32;
            this.makp.Visible = false;
            // 
            // butLoc
            // 
            this.butLoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butLoc.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLoc.Location = new System.Drawing.Point(929, 24);
            this.butLoc.Name = "butLoc";
            this.butLoc.Size = new System.Drawing.Size(24, 19);
            this.butLoc.TabIndex = 33;
            this.butLoc.Text = "...";
            this.butLoc.Visible = false;
            this.butLoc.Click += new System.EventHandler(this.butLoc_Click);
            // 
            // tim
            // 
            this.tim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tim.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tim.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tim.ForeColor = System.Drawing.Color.Red;
            this.tim.Location = new System.Drawing.Point(108, 259);
            this.tim.Name = "tim";
            this.tim.Size = new System.Drawing.Size(598, 21);
            this.tim.TabIndex = 39;
            this.tim.Text = "Tìm kiếm";
            this.tim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tim.TextChanged += new System.EventHandler(this.tim_TextChanged);
            this.tim.Enter += new System.EventHandler(this.tim_Enter);
            // 
            // butXoa
            // 
            this.butXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butXoa.BackColor = System.Drawing.SystemColors.Control;
            this.butXoa.ForeColor = System.Drawing.Color.Black;
            this.butXoa.Image = ((System.Drawing.Image)(resources.GetObject("butXoa.Image")));
            this.butXoa.Location = new System.Drawing.Point(730, 260);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(22, 19);
            this.butXoa.TabIndex = 40;
            this.toolTip1.SetToolTip(this.butXoa, "Bỏ bớt dụng cụ kèm theo");
            this.butXoa.UseVisualStyleBackColor = true;
            this.butXoa.Click += new System.EventHandler(this.butXoa_Click);
            // 
            // butXoadc
            // 
            this.butXoadc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butXoadc.BackColor = System.Drawing.SystemColors.Control;
            this.butXoadc.ForeColor = System.Drawing.Color.Black;
            this.butXoadc.Image = ((System.Drawing.Image)(resources.GetObject("butXoadc.Image")));
            this.butXoadc.Location = new System.Drawing.Point(330, 381);
            this.butXoadc.Name = "butXoadc";
            this.butXoadc.Size = new System.Drawing.Size(22, 19);
            this.butXoadc.TabIndex = 41;
            this.toolTip1.SetToolTip(this.butXoadc, "Bỏ bớt quá trình di chuyển dụng cụ");
            this.butXoadc.UseVisualStyleBackColor = false;
            this.butXoadc.Click += new System.EventHandler(this.butXoadc_Click);
            // 
            // butXoalc
            // 
            this.butXoalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butXoalc.BackColor = System.Drawing.SystemColors.Control;
            this.butXoalc.ForeColor = System.Drawing.Color.Black;
            this.butXoalc.Image = ((System.Drawing.Image)(resources.GetObject("butXoalc.Image")));
            this.butXoalc.Location = new System.Drawing.Point(708, 381);
            this.butXoalc.Name = "butXoalc";
            this.butXoalc.Size = new System.Drawing.Size(22, 19);
            this.butXoalc.TabIndex = 42;
            this.toolTip1.SetToolTip(this.butXoalc, "Bỏ bớt quá trình sửa chữa dụng cụ");
            this.butXoalc.UseVisualStyleBackColor = true;
            this.butXoalc.Click += new System.EventHandler(this.butXoalc_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(2, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Controls.Add(this.hinh);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.butKetthuc);
            this.splitContainer1.Panel2.Controls.Add(this.butXoadc);
            this.splitContainer1.Panel2.Controls.Add(this.butXoalc);
            this.splitContainer1.Panel2.Controls.Add(this.butTLC);
            this.splitContainer1.Panel2.Controls.Add(this.butXoa);
            this.splitContainer1.Panel2.Controls.Add(this.butSLC);
            this.splitContainer1.Panel2.Controls.Add(this.butSSC);
            this.splitContainer1.Panel2.Controls.Add(this.tim);
            this.splitContainer1.Panel2.Controls.Add(this.butTSC);
            this.splitContainer1.Panel2.Controls.Add(this.dataGrid3);
            this.splitContainer1.Panel2.Controls.Add(this.dataGrid1);
            this.splitContainer1.Panel2.Controls.Add(this.butTDC);
            this.splitContainer1.Panel2.Controls.Add(this.dataGrid2);
            this.splitContainer1.Panel2.Controls.Add(this.dataGrid4);
            this.splitContainer1.Size = new System.Drawing.Size(973, 527);
            this.splitContainer1.SplitterDistance = 211;
            this.splitContainer1.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Khoa phòng";
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(3, 22);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(206, 313);
            this.treeView1.TabIndex = 44;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // frmTheodoi
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.butKetthuc;
            this.ClientSize = new System.Drawing.Size(976, 531);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.butLoc);
            this.Controls.Add(this.makp);
            this.Controls.Add(this.butSDC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTheodoi";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Theo dõi tài sản tại khoa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTheodoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid4)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void frmTheodoi_Load(object sender, System.EventArgs e)
		{
            if (Screen.PrimaryScreen.WorkingArea.Width > 800) this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            user = ttb.user;
            link = ttb.dbLink;
			makp.DisplayMember="TEN";
			makp.ValueMember="ID";
			sql="select * from "+d.user+".d_duockp where nhom like '%"+i_nhom.ToString()+",%'";
            if (s_makp.Trim() != "") sql += " and id in (" + s_makp.Trim().Trim(',') + ")";
			sql+=" order by stt";
            dtkhoa = d.get_data(sql).Tables[0];
			//makp.DataSource=dtkhoa;
            treeView1.Nodes.Clear();
            TreeNode nodeKhoa = new TreeNode();
            foreach (DataRow r1 in dtkhoa.Rows)
            {
                treeView1.Nodes.Add(r1["id"].ToString(), r1["ten"].ToString());
            }
            
            hinh_ttb=ttb.hinh_ttb(i_nhom).Trim();
            if (s_makho == "") foreach (DataRow r in ttb.get_data("select * from " + user + ".ttb_dmkho where nhom=" + i_nhom).Tables[0].Rows) s_makho += r["id"].ToString() + ",";
			load_tskhoa();
            //treeView1_NodeMouseClick(null, null);
			AddGridTableStyle1();
			load_data();
			AddGridTableStyle2();
			AddGridTableStyle3();
			AddGridTableStyle4();
		}

		private void load_tskhoa()
		{
			sql="select a.id,a.mabd,a.makp,a.makho,a.manguon,a.nhomcc,a.stt,a.losx,a.sothe,h.giamua sotien,a.namsx,a.namsd,trim(b.ten)||' '||b.hamluong as ten,b.dang,c.ten as tenhang,d.ten as tennuoc,e.ten as tennx,f.ten as tenkp,b.hinh,b.ma,b.image";
            sql += " from " + user + ".ttb_tscdkhoa a," + user + ".ttb_dmbd b," + user + ".ttb_dmhang c," + user + ".ttb_dmnuoc d," + user + ".ttb_dmnx e," + d.user + ".d_duockp" + link + " f," + user + ".ttb_dmnhom g," + user + ".ttb_theodoi h";
			sql+=" where a.mabd=b.id and b.manhom=g.id and b.mahang=c.id and b.manuoc=d.id and a.nhomcc=e.id and a.makp=f.id and a.stt=h.id ";
			sql+=" and g.theodoi=1 and b.bhyt<>0";
			if (s_makho!="") sql+=" and a.makho in ("+s_makho.Substring(0,s_makho.Length-1)+")";
			//if (s_makp!="") sql+=" and a.makp in ("+s_makp.Substring(0,s_makp.Length-1)+")";
            if (s_makp != "") sql += " and a.makp ="+dtkhoa.Rows[0]["id"].ToString();
			sql+=" order by b.ten";
			dtts=ttb.get_data(sql).Tables[0];
			dataGrid1.DataSource=dtts;
		}

		private void AddGridTableStyle1()
		{
			DataGridTableStyle ts =new DataGridTableStyle();
			ts.MappingName = dtts.TableName;
			ts.AlternatingBackColor = Color.Beige;
			ts.BackColor = Color.GhostWhite;
			ts.ForeColor = Color.MidnightBlue;
			ts.GridLineColor = Color.RoyalBlue;
			ts.HeaderBackColor = Color.MidnightBlue;
			ts.HeaderForeColor = Color.Lavender;
			ts.SelectionBackColor = Color.Teal;
			ts.SelectionForeColor = Color.PaleGreen;
			ts.ReadOnly=false;
			ts.RowHeaderWidth=10;
						
			DataGridTextBoxColumn TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "id";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

            TextCol = new DataGridTextBoxColumn();
            TextCol.MappingName = "ma";
            TextCol.HeaderText = "Mã số";
            TextCol.Width = 50;
            ts.GridColumnStyles.Add(TextCol);
            dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "ten";
			TextCol.HeaderText = "Tên,ký hiệu qui cách";
			TextCol.Width = 190;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "losx";
			TextCol.HeaderText = "Số hiệu";
			TextCol.Width = 60;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "sothe";
			TextCol.HeaderText = "Số QĐ";
			TextCol.Width = 60;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tenhang";
			TextCol.HeaderText = "Tên hãng";
			TextCol.Width = 60;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tennuoc";
			TextCol.HeaderText = "Tên nước";
			TextCol.Width = 60;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tenkp";
			TextCol.HeaderText = "Khoa";
			TextCol.Width = 65;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tennx";
			TextCol.HeaderText = "Nhà phân phối";
			TextCol.Width = 120;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "sotien";
			TextCol.HeaderText = "Nguyên giá";
			TextCol.Width = 80;
			TextCol.Format="### ### ### ###";
			TextCol.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "namsx";
			TextCol.HeaderText = "Năm SX";
			TextCol.Width = 45;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "hinh";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "mabd";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "makp";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "nhomcc";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);
		}

		private void AddGridTableStyle2()
		{
			DataGridTableStyle ts =new DataGridTableStyle();
			ts.MappingName = dtdc.TableName;
			ts.AlternatingBackColor = Color.Beige;
			ts.BackColor = Color.GhostWhite;
			ts.ForeColor = Color.MidnightBlue;
			ts.GridLineColor = Color.RoyalBlue;
			ts.HeaderBackColor = Color.MidnightBlue;
			ts.HeaderForeColor = Color.Lavender;
			ts.SelectionBackColor = Color.Teal;
			ts.SelectionForeColor = Color.PaleGreen;
			ts.ReadOnly=false;
			ts.RowHeaderWidth=10;
						
			DataGridTextBoxColumn TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "stt";
			TextCol.HeaderText = "stt";
			TextCol.Width = 20;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid2.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "ngay";
			TextCol.HeaderText = "Ngày";
			TextCol.Width = 65;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid2.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "ten";
			TextCol.HeaderText = "Tên";
			TextCol.Width = 150;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid2.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tenhang";
			TextCol.HeaderText = "Tên hãng";
			TextCol.Width = 60;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid2.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tennuoc";
			TextCol.HeaderText = "Tên nước";
			TextCol.Width = 60;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid2.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "diengiai";
			TextCol.HeaderText = "Ghi chú";
			TextCol.Width = 180;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid2.TableStyles.Add(ts);
		}

		private void AddGridTableStyle3()
		{
			DataGridTableStyle ts =new DataGridTableStyle();
			ts.MappingName = dtlc.TableName;
			ts.AlternatingBackColor = Color.Beige;
			ts.BackColor = Color.GhostWhite;
			ts.ForeColor = Color.MidnightBlue;
			ts.GridLineColor = Color.RoyalBlue;
			ts.HeaderBackColor = Color.MidnightBlue;
			ts.HeaderForeColor = Color.Lavender;
			ts.SelectionBackColor = Color.Teal;
			ts.SelectionForeColor = Color.PaleGreen;
			ts.ReadOnly=false;
			ts.RowHeaderWidth=10;
						
			DataGridTextBoxColumn TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "stt";
			TextCol.HeaderText = "stt";
			TextCol.Width = 20;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid3.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "ngay";
			TextCol.HeaderText = "Ngày";
			TextCol.Width = 65;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid3.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tenkp";
			TextCol.HeaderText = "Khoa";
			TextCol.Width = 60;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid3.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "diengiai";
			TextCol.HeaderText = "Ghi chú";
			TextCol.Width = 140;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid3.TableStyles.Add(ts);
		}

		private void AddGridTableStyle4()
		{
			DataGridTableStyle ts =new DataGridTableStyle();
			ts.MappingName = dtlc.TableName;
			ts.AlternatingBackColor = Color.Beige;
			ts.BackColor = Color.GhostWhite;
			ts.ForeColor = Color.MidnightBlue;
			ts.GridLineColor = Color.RoyalBlue;
			ts.HeaderBackColor = Color.MidnightBlue;
			ts.HeaderForeColor = Color.Lavender;
			ts.SelectionBackColor = Color.Teal;
			ts.SelectionForeColor = Color.PaleGreen;
			ts.ReadOnly=false;
			ts.RowHeaderWidth=10;
						
			DataGridTextBoxColumn TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "stt";
			TextCol.HeaderText = "stt";
			TextCol.Width = 20;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid4.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "ngay";
			TextCol.HeaderText = "Ngày";
			TextCol.Width = 65;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid4.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "diengiai";
			TextCol.HeaderText = "Ghi chú";
			TextCol.Width = 100;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid4.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "nguoidenghi";
			TextCol.HeaderText = "Đề nghị";
			TextCol.Width = 90;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid4.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tensc";
			TextCol.HeaderText = "Nơi sữa chữa";
			TextCol.Width = 145;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid4.TableStyles.Add(ts);
		}

		private void dataGrid1_CurrentCellChanged(object sender, System.EventArgs e)
		{
			load_data();
		}

		private void load_data()
		{
			try
			{
				if (System.IO.File.Exists(dataGrid1[dataGrid1.CurrentCell.RowNumber,11].ToString()))
					hinh.BackgroundImage=Image.FromFile(dataGrid1[dataGrid1.CurrentCell.RowNumber,11].ToString().Trim());
				else hinh.BackgroundImage=Image.FromFile(hinh_ttb+"\\00.JPG");
			}
			catch{}
			try
			{
				l_id=decimal.Parse(dataGrid1[dataGrid1.CurrentCell.RowNumber,0].ToString());
                this.Text = "Theo dõi tài sản tại khoa [" + dataGrid1[dataGrid1.CurrentCell.RowNumber, 2].ToString().Trim() + "]";
			}
			catch{l_id=0;}
           
			load_grid();
		}

		private void load_grid()
		{
			load_dc();
			load_lc();
			load_sc();
		}

		private void butKetthuc_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void butTDC_Click(object sender, System.EventArgs e)
		{
			if (l_id==0) return;
			frmDmbdkem f=new frmDmbdkem(ttb,i_nhom,l_id,dataGrid1[dataGrid1.CurrentCell.RowNumber,2].ToString(),s_mmyy,s_ngay,int.Parse(dataGrid1[dataGrid1.CurrentCell.RowNumber,12].ToString()),int.Parse(dataGrid1[dataGrid1.CurrentCell.RowNumber,13].ToString()));
			f.ShowDialog(this);
			load_dc();
		}

		private void butTLC_Click(object sender, System.EventArgs e)
		{
			if (l_id==0) return;
			frmTscdlc f=new frmTscdlc(ttb,l_id,dataGrid1[dataGrid1.CurrentCell.RowNumber,2].ToString(),int.Parse(dataGrid1[dataGrid1.CurrentCell.RowNumber,13].ToString()),i_nhom,0);
			f.ShowDialog(this);
			if (f.Ok) 
			{
				load_tskhoa();
				load_lc();
			}
		}

		private void butSLC_Click(object sender, System.EventArgs e)
		{
            try
            {
                if (l_id == 0) return;
                frmTscdlc f = new frmTscdlc(ttb, l_id, dataGrid1[dataGrid1.CurrentCell.RowNumber, 2].ToString(), int.Parse(dataGrid1[dataGrid1.CurrentCell.RowNumber, 13].ToString()), i_nhom, int.Parse(dataGrid3[dataGrid3.CurrentCell.RowNumber, 0].ToString()));
                f.ShowDialog(this);
                if (f.Ok)
                {
                    load_tskhoa();
                    load_lc();
                }
            }
            catch //(Exception exx)
            { }
		}

		private void load_sc()
		{
			sql="select a.stt,to_char(a.ngay,'dd/mm/yyyy') as ngay,b.ten as tensc,a.diengiai,a.nguoidenghi";
            sql += " from " + user + ".ttb_tscdsc a," + user + ".ttb_dmnoisc b";
			sql+=" where a.noisc=b.id";
			sql+=" and a.id="+l_id+" order by a.stt desc";
			dtsc=ttb.get_data(sql).Tables[0];
			dataGrid4.DataSource=dtsc;
		}

		private void load_dc()
		{
			sql="select a.stt,to_char(a.ngay,'dd/mm/yyyy') as ngay,a.mabd,a.diengiai,trim(b.ten)||' '||b.hamluong as ten,b.dang,c.ten as tenhang,d.ten as tennuoc";
            sql += " from " + user + ".ttb_tscdkem a," + user + ".ttb_dmbd b," + user + ".ttb_dmhang c," + user + ".ttb_dmnuoc d";
			sql+=" where a.mabd=b.id and b.mahang=c.id and b.manuoc=d.id";
			sql+=" and a.id="+l_id+" order by a.stt desc";
			dtdc=ttb.get_data(sql).Tables[0];
			dataGrid2.DataSource=dtdc;	
		}
		private void load_lc()
		{
			sql="select a.stt,to_char(a.ngay,'dd/mm/yyyy') as ngay,b.ten as tenkp,a.diengiai";
            sql += " from " + user + ".ttb_tscdlc a," + d.user + ".d_duockp"+link+" b";
			sql+=" where a.makp=b.id";
			sql+=" and a.id="+l_id+" order by a.stt desc";
			dtlc=ttb.get_data(sql).Tables[0];
			dataGrid3.DataSource=dtlc;
		}

		private void butTSC_Click(object sender, System.EventArgs e)
		{
			if (l_id==0) return;
			try
			{
				frmTscdsc f=new frmTscdsc(ttb,l_id,dataGrid1[dataGrid1.CurrentCell.RowNumber,2].ToString(),int.Parse(dataGrid1[dataGrid1.CurrentCell.RowNumber,14].ToString()),i_nhom,0);
				f.ShowDialog(this);
				if (f.Ok) load_sc();
			}
			catch{}
		}

		private void butSSC_Click(object sender, System.EventArgs e)
		{
			if (l_id==0) return;
			try
			{
				frmTscdsc f=new frmTscdsc(ttb,l_id,dataGrid1[dataGrid1.CurrentCell.RowNumber,2].ToString(),int.Parse(dataGrid1[dataGrid1.CurrentCell.RowNumber,14].ToString()),i_nhom,int.Parse(dataGrid4[dataGrid4.CurrentCell.RowNumber,0].ToString()));
				f.ShowDialog(this);
				if (f.Ok) load_sc();
			}
			catch{}
		}

		private void butLoc_Click(object sender, System.EventArgs e)
		{
            //sql="select distinct a.id,a.mabd,a.makp,a.makho,a.manguon,a.nhomcc,a.stt,a.losx,a.sothe,a.sotien,a.namsx,a.namsd,trim(b.ten)||' '||b.hamluong as ten,b.dang,c.ten as tenhang,d.ten as tennuoc,e.ten as tennx,f.ten as tenkp,b.hinh,b.ma, a.idduyet ";
            //sql += " from " + user + ".ttb_tscdkhoa a," + user + ".ttb_dmbd b," + user + ".ttb_dmhang c," + user + ".ttb_dmnuoc d," + user + ".ttb_dmnx e," + d.user + ".d_duockp"+link+" f," + user + ".ttb_dmnhom g";
            //sql+=" where a.mabd=b.id and b.manhom=g.id and b.mahang=c.id and b.manuoc=d.id and a.nhomcc=e.id and a.makp=f.id";
            //sql+=" and g.theodoi=1 and b.bhyt<>0";
            //if (s_makho!="") sql+=" and a.makho in ("+s_makho.Substring(0,s_makho.Length-1)+")";
            //if (s_makp!="") sql+=" and a.makp in ("+s_makp.Substring(0,s_makp.Length-1)+")";
            //if (makp.SelectedIndex!=-1) sql+=" and a.makp="+int.Parse(makp.SelectedValue.ToString());
            ////sql+=" order by b.ten";
            //dtts=ttb.get_data(sql).Tables[0];
            //dataGrid1.DataSource=dtts;
            //load_data();
		}

        private void tim_TextChanged(object sender, EventArgs e)
        {
            if (this.ActiveControl == tim)
            {
                CurrencyManager cm = (CurrencyManager)BindingContext[dataGrid1.DataSource];
                DataView dv = (DataView)cm.List;
                sql = "ten like '%" + tim.Text.Trim() + "%' or ma like '%" + tim.Text.Trim() + "%' or tenhang like '%" + tim.Text.Trim() + "%' or tennuoc like '%" + tim.Text.Trim() + "%' or tennx like '%" + tim.Text.Trim() + "%' or losx like '%" + tim.Text.Trim() + "%' or sothe like '%" + tim.Text.Trim() + "%' or tenkp like '%"+tim.Text.Trim()+"%'";
                if (tim.Text != "")
                    dv.RowFilter = sql;
                else
                    dv.RowFilter = "";
                load_data();
            }
        }

        private void tim_Enter(object sender, EventArgs e)
        {
            tim.Text = "";
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            if (dtdc.Rows.Count == 0) return;
            if (MessageBox.Show("Đồng ý xóa dụng cụ "+dataGrid2[dataGrid2.CurrentCell.RowNumber,2].ToString().Trim()+"?", ttb.Msg, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ttb.execute_data("delete from " + user + ".ttb_tscdkem where id=" + l_id + " and stt=" + int.Parse(dataGrid2[dataGrid2.CurrentCell.RowNumber, 0].ToString()));
                load_dc();
            }
        }

        private void butXoadc_Click(object sender, EventArgs e)
        {
            if (dtlc.Rows.Count == 0) return;
            if (MessageBox.Show("Đồng ý xóa di chuyển " + dataGrid3[dataGrid3.CurrentCell.RowNumber, 2].ToString().Trim() + "?", ttb.Msg, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ttb.execute_data("delete from " + user + ".ttb_tscdlc where id=" + l_id + " and stt=" + int.Parse(dataGrid3[dataGrid3.CurrentCell.RowNumber, 0].ToString()));
                load_lc();
            }
        }

        private void butXoalc_Click(object sender, EventArgs e)
        {
            if (dtsc.Rows.Count == 0) return;
            if (MessageBox.Show("Đồng ý xóa sửa chữa " + dataGrid4[dataGrid4.CurrentCell.RowNumber, 2].ToString().Trim() + "?", ttb.Msg, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ttb.execute_data("delete from " + user + ".ttb_tscdsc where id=" + l_id + " and stt=" + int.Parse(dataGrid4[dataGrid4.CurrentCell.RowNumber, 0].ToString()));
                load_sc();
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                sql = "select a.id,a.mabd,a.makp,a.makho,a.manguon,a.nhomcc,a.stt,a.losx,a.sothe,h.giamua sotien,a.namsx,a.namsd,trim(b.ten)||' '||b.hamluong as ten,b.dang,c.ten as tenhang,d.ten as tennuoc,e.ten as tennx,f.ten as tenkp,b.hinh,b.ma, a.idduyet,b.image ";
                sql += " from " + user + ".ttb_tscdkhoa a," + user + ".ttb_dmbd b," + user + ".ttb_dmhang c," + user + ".ttb_dmnuoc d," + user + ".ttb_dmnx e," + d.user + ".d_duockp" + link + " f," + user + ".ttb_dmnhom g," + user + ".ttb_theodoi h , " + user + ".ttb_tutrucct m ";
                sql += " where a.mabd=b.id and b.manhom=g.id and b.mahang=c.id and b.manuoc=d.id and a.nhomcc=e.id and a.makp=f.id and a.stt=h.id ";
                sql += " and g.theodoi=1 and b.bhyt<>0";
                if (s_makho != "") sql += " and a.makho in (" + s_makho.Substring(0, s_makho.Length - 1) + ")";
                //if (s_makp != "") sql += " and a.makp in (" + s_makp.Substring(0, s_makp.Length - 1) + ")";
                //if (makp.SelectedIndex != -1) sql += " and a.makp=" + int.Parse(makp.SelectedValue.ToString());
                //sql+=" order by b.ten";
                sql += " and a.makp=" + e.Node.Name;
                sql += " and m.mmyy='"+s_mmyy+"' and m.mabd=a.mabd and m.makho=a.makho and m.makp=a.makp and m.stt=a.stt  ";
                dtts = ttb.get_data(sql).Tables[0];
                dataGrid1.DataSource = dtts;
                load_data();
            }
            catch { }
        }

        //private void textBox1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    TextBox txt = (TextBox)sender;
        //    txt.SelectAll();
        //    txt.DoDragDrop(txt.Text, DragDropEffects.Copy);
        //}

        //private void textBox2_DragEnter(object sender, DragEventArgs e)
        //{
        //    if (e.Data.GetDataPresent(DataFormats.Text))
        //    {
        //        e.Effect = DragDropEffects.Copy;
        //    }
        //    else
        //    {
        //        e.Effect = DragDropEffects.None;
        //    }
        //}

        //private void textBox2_DragDrop(object sender, DragEventArgs e)
        //{
        //    TextBox txt = (TextBox)sender;
        //    txt.Text = (string)e.Data.GetData(DataFormats.Text);
        //}
	}
}
