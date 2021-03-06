using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LibTTB;

namespace TTB
{
    public partial class frmTaouser : Form
    {
        private LibTTB.AccessData ttb = new LibTTB.AccessData();
        private int i_userid;
        public frmTaouser(int userid)
        {
            InitializeComponent();
            i_userid = userid;
        }

        private void mm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{Tab}");
        }

        private void frmTaouser_Load(object sender, EventArgs e)
        {
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ttb.tao_table();
            ttb.tao_function();
            ttb.upd_dmnhomkho((decimal)LibDuoc.ID.NhomKho.TTB, "Trang thiết bị", (int)LibDuoc.ID.NhomKho.TTB, 0, 0);
            ttb.upd_dmphieu(1, "Phiếu lãnh", (int)LibDuoc.ID.NhomKho.TTB, 2);
            ttb.upd_dmphieu(2, "Phiếu tủ trực", (int)LibDuoc.ID.NhomKho.TTB, 2);
            ttb.upd_dmphieu(3, "Phiếu hoàn trả", (int)LibDuoc.ID.NhomKho.TTB, 3);
            ttb.upd_dmphieu(4, "Phiếu hao phí", (int)LibDuoc.ID.NhomKho.TTB, 4);
            ttb.upd_dmnguon(0, "", 0, 0, 1);
            ttb.upd_dmnx(0, "KXD", "", (int)LibDuoc.ID.NhomKho.TTB, 0, 1, "", "", "", "", "");
            Cursor = Cursors.Default;
            MessageBox.Show("Xong !", ttb.Msg);
        }
    }
}