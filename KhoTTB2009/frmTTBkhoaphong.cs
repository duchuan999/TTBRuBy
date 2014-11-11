using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Duoc2009.Danhmuc;

namespace TTB
{
    public partial class frmTTBkhoaphong : frmDuockp
    {
        public frmTTBkhoaphong(LibDuoc.AccessData acc, string tab, string title, int nhom, string mmyy)
        {
            InitializeComponent();
            base.acc = acc;
            base.table_name = tab;
            base.Nhomkho = nhom;
            base.MMYY = mmyy;
            base.Text = title;
            base.init();
        }

        private void frmTTBkhoaphong_Load(object sender, EventArgs e)
        {
            base.load_data();
        }
    }
}