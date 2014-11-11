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
    public partial class frmDanhgia : Form
    {
        private LibTTB.AccessData ttb;
        private decimal sttt;
        private int i_nhom;
        private decimal nam=0, tyle=0;
        private string s_mmyy,user,xxx;//sql,
        public frmDanhgia(AccessData acc,decimal _sttt,string _ten,int _nhom,string _mmyy)
        {
            InitializeComponent();
            ttb = acc; sttt = _sttt; i_nhom = _nhom; s_mmyy = _mmyy;
            this.Text = "Đánh giá tài sản [" + _ten.Trim() + "]";
        }

        private void ngay_Validated(object sender, EventArgs e)
        {
            if (ngay.Text == "") return;
            ngay.Text = ngay.Text.Trim();
            if (ngay.Text.Length == 6) ngay.Text = ngay.Text + DateTime.Now.Year.ToString();
            if (!ttb.bNgay(ngay.Text))
            {
                MessageBox.Show("Ngày không hợp lệ !", ttb.Msg);
                ngay.Focus();
                return;
            }
            ngay.Text = ttb.Ktngaygio(ngay.Text, 10);
        }

        private void phutrach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{Tab}");
        }

        private void butLuu_Click(object sender, EventArgs e)
        {
            ttb.upd_theodoitscd(s_mmyy, sttt, nam, tyle, int.Parse(phanloai.SelectedValue.ToString()), phutrach.Text, chucdanh.Text, daotao.Text, coquan.Text, tailieu.Text, quyetdinh.Text, ngay.Text, tuoitho.Text, baotri.Value, tinhhinh.Text, khauhao.Text);
            this.Close();
        }

        private void butBoqua_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDanhgia_Load(object sender, EventArgs e)
        {
            int _tuoitho = 0;
            user = ttb.user; xxx = user;// +s_mmyy;
            phanloai.DisplayMember = "TEN";
            phanloai.ValueMember = "ID";
            phanloai.DataSource = ttb.get_data("select * from " + user + ".ttb_dmloaitscd where nhom=" + i_nhom + " order by stt").Tables[0];
            foreach (DataRow r in ttb.get_data("select a.*,to_char(a.ngay,'dd/mm/yyyy') as ng,b.namsd from " + xxx + ".ttb_theodoitscd a ,"+xxx+".ttb_theodoi b where a.sttt=b.id and a.sttt=" + sttt).Tables[0].Rows)
            {
                nam = decimal.Parse(r["nam"].ToString());
                tyle = decimal.Parse(r["tyle"].ToString());
                phanloai.SelectedValue=r["phanloai"].ToString();
                phutrach.Text=r["phutrach"].ToString();
                chucdanh.Text=r["chucdanh"].ToString();
                daotao.Text = r["daotao"].ToString();
                coquan.Text = r["coquan"].ToString();
                tailieu.Text = r["tailieu"].ToString();
                quyetdinh.Text = r["quyetdinh"].ToString();
                ngay.Text = r["ng"].ToString();
                if (r["namsd"].ToString().Trim().Length==10)
                {
                    _tuoitho = DateTime.Now.Year - int.Parse(r["namsd"].ToString().Substring(6,4));
                    if (_tuoitho!=0) tuoitho.Text = _tuoitho.ToString().Trim() + " Năm";
                }
                else tuoitho.Text = r["tuoitho"].ToString();                
                baotri.Value = (r["baotri"].ToString()!="")?decimal.Parse(r["baotri"].ToString()):0;
                tinhhinh.Text = r["tinhhinh"].ToString();
                khauhao.Text = r["khauhao"].ToString();
            }
        }

        private void phanloai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (phanloai.SelectedIndex == -1 && phanloai.Items.Count > 0) phanloai.SelectedIndex = 0;
                SendKeys.Send("{Tab}");
            }
        }
    }
}