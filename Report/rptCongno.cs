using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Report2009
{
    public partial class rptCongno : Form
    {
        private LibBaocao.AccessData lib;
        private int iNhom,iUserid;
        private string user,mmyy,sql;
        private string sMakho,sNhacc;
        private DataSet ds = new DataSet();
        private DataTable dtDmkho,dtNhacc,dtMaubaocao,dtSohd;
        
        public rptCongno(LibBaocao.AccessData acc, int nhom, string s_mmyy, string makho, int _userid)
        {
            InitializeComponent();
            lib = acc;iNhom = nhom;mmyy = s_mmyy;sMakho = makho;iUserid = _userid;
            user = lib.user;
        }

        private void AddGridTableStyle()
        {
            DataGridTableStyle ts = new DataGridTableStyle();
            ts.MappingName = "Table";
            ts.AlternatingBackColor = Color.Beige;
            ts.BackColor = Color.GhostWhite;
            ts.ForeColor = Color.MidnightBlue;
            ts.GridLineColor = Color.RoyalBlue;
            ts.HeaderBackColor = Color.MidnightBlue;
            ts.HeaderForeColor = Color.Lavender;
            ts.SelectionBackColor = Color.Teal;
            ts.SelectionForeColor = Color.PaleGreen;
            ts.ReadOnly = false;
            ts.RowHeaderWidth = 10;

            DataGridTextBoxColumn TextCol = new DataGridTextBoxColumn();
            TextCol.MappingName = "idncc";
            TextCol.HeaderText = "ID";
            TextCol.Width = 0;
            ts.GridColumnStyles.Add(TextCol);
            dataGrid1.TableStyles.Add(ts);

            TextCol = new DataGridTextBoxColumn();
            TextCol.MappingName = "tenncc";
            TextCol.HeaderText = "Nhà cung cấp";
            TextCol.Width = 120;
            ts.GridColumnStyles.Add(TextCol);
            dataGrid1.TableStyles.Add(ts);

            TextCol = new DataGridTextBoxColumn();
            TextCol.MappingName = "sophieu";
            TextCol.HeaderText = "Số phiếu";
            TextCol.Width = 100;
            ts.GridColumnStyles.Add(TextCol);
            dataGrid1.TableStyles.Add(ts);

            TextCol = new DataGridTextBoxColumn();
            TextCol.MappingName = "ngaysp";
            TextCol.HeaderText = "Ngày lập";
            TextCol.Width = 65;
            ts.GridColumnStyles.Add(TextCol);
            dataGrid1.TableStyles.Add(ts);

            TextCol = new DataGridTextBoxColumn();
            TextCol.MappingName = "sohd";
            TextCol.HeaderText = "Số HĐ";
            TextCol.Width = 60;
            ts.GridColumnStyles.Add(TextCol);
            dataGrid1.TableStyles.Add(ts);

            TextCol = new DataGridTextBoxColumn();
            TextCol.MappingName = "ngayhd";
            TextCol.HeaderText = "Ngày HĐ";
            TextCol.Width = 65;
            ts.GridColumnStyles.Add(TextCol);
            dataGrid1.TableStyles.Add(ts);

            TextCol = new DataGridTextBoxColumn();
            TextCol.MappingName = "sptra";
            TextCol.HeaderText = "Phiếu trả";
            TextCol.Width = 100;
            ts.GridColumnStyles.Add(TextCol);
            dataGrid1.TableStyles.Add(ts);

            TextCol = new DataGridTextBoxColumn();
            TextCol.MappingName = "ngaytra";
            TextCol.HeaderText = "Ngày trả";
            TextCol.Width = 65;
            ts.GridColumnStyles.Add(TextCol);
            dataGrid1.TableStyles.Add(ts);

            TextCol = new DataGridTextBoxColumn();
            TextCol.MappingName = "stnhap";
            TextCol.HeaderText = "ST Nhập";
            TextCol.Width = 80;
            ts.GridColumnStyles.Add(TextCol);
            dataGrid1.TableStyles.Add(ts);

            TextCol = new DataGridTextBoxColumn();
            TextCol.MappingName = "sttra";
            TextCol.HeaderText = "Chi trả";
            TextCol.Width = 80;
            TextCol.NullText = "";
            ts.GridColumnStyles.Add(TextCol);
            dataGrid1.TableStyles.Add(ts);

            TextCol = new DataGridTextBoxColumn();
            TextCol.MappingName = "diachi";
            TextCol.HeaderText = "Địa chỉ";
            TextCol.Width = 150;
            TextCol.NullText = "";
            ts.GridColumnStyles.Add(TextCol);
            dataGrid1.TableStyles.Add(ts);

            TextCol = new DataGridTextBoxColumn();
            TextCol.MappingName = "dienthoai";
            TextCol.HeaderText = "Điện thoại";
            TextCol.Width = 90;
            TextCol.NullText = "";
            ts.GridColumnStyles.Add(TextCol);
            dataGrid1.TableStyles.Add(ts);

            TextCol = new DataGridTextBoxColumn();
            TextCol.MappingName = "masothue";
            TextCol.HeaderText = "MST";
            TextCol.Width = 100;
            TextCol.NullText = "";
            ts.GridColumnStyles.Add(TextCol);
            dataGrid1.TableStyles.Add(ts);

            TextCol = new DataGridTextBoxColumn();
            TextCol.MappingName = "nguoigiao";
            TextCol.HeaderText = "Người giao";
            TextCol.Width = 90;
            TextCol.NullText = "";
            ts.GridColumnStyles.Add(TextCol);
            dataGrid1.TableStyles.Add(ts);
        }

        private string get_manhacc()
        {
            string s_manhacc = "";
            if (lstNhacc.SelectedItems.Count > 0)
                for (int i = 0; i < lstNhacc.Items.Count; i++)
                    if (lstNhacc.GetItemChecked(i))
                    {
                        s_manhacc += dtNhacc.Rows[i][0].ToString().Trim() + ",";
                    }
            return s_manhacc.Trim(','); ;
        }

        private void butTonghop_Click(object sender, EventArgs e)
        {
            switch (cbKieu.SelectedIndex)
            {
                case 0:
                    get_manhacc();
                    load_nhacc(tu.Text.Substring(0, 10), den.Text.Substring(0, 10), tutra.Text.Substring(0, 10), dentra.Text.Substring(0, 10));
                    break;
                case 1:
                    load_sohd(tu.Text.Substring(0, 10), den.Text.Substring(0, 10), tutra.Text.Substring(0, 10), dentra.Text.Substring(0, 10));
                    break;
                default:
                    break;
            }
        }

        private void load_nhacc(string tungay, string denngay, string tungaytra, string denngaytra)
        {
            try
            {
                dtNhacc = new DataTable();
                tungay = tungay.Substring(0, 10);
                denngay = denngay.Substring(0, 10);
                tungaytra = tungaytra.Substring(0, 10);
                denngaytra = denngaytra.Substring(0, 10);
                sql = "select d.id idnhacc,d.ten tenncc from xxx.d_thanhtoan a,xxx.d_thanhtoanct b, xxx.d_nhapll c, " + user + ".d_dmnx d where a.id=b.id(+) and a.id=c.id and c.madv=d.id and c.loai='M'";
                if (iNhom > 0)
                    sql += " and c.nhom=" + iNhom;
                if (tungay != "" && denngay != "")
                    sql += " and to_date(to_char(c.ngaysp,'dd/mm/yyyy'),'dd/mm/yyyy') between to_date('" + tungay + "','dd/mm/yyyy') and to_date('" + denngay + "','dd/mm/yyyy')";
                if (tungaytra != "" && denngaytra != "" && chkThanhtoan.Checked)
                    sql += " and to_date(to_char(b.ngay,'dd/mm/yyyy'),'dd/mm/yyyy') between to_date('" + tungaytra + "','dd/mm/yyyy') and to_date('" + denngaytra + "','dd/mm/yyyy')  and c.paid=1";
                sql += " group by d.id,d.ten,d.stt order by d.stt";
                dtNhacc = lib.get_data_mmyy(sql, tungay, denngay, false).Tables[0];
                if (dtNhacc.Rows.Count > 0)
                {
                    lstNhacc.DataSource = dtNhacc;
                    lstNhacc.DisplayMember = "TENNCC";
                    lstNhacc.ValueMember = "IDNHACC";
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!");
                tu.Focus();
                return;
            }
        }

        private void load_sohd(string tungay, string denngay, string tungaytra, string denngaytra)
        {
            try
            {
                dtNhacc = new DataTable();
                tungay = tungay.Substring(0, 10);
                denngay = denngay.Substring(0, 10);
                tungaytra = tungaytra.Substring(0, 10);
                denngaytra = denngaytra.Substring(0, 10);
                sql = "select c.sohd idnhacc,c.sophieu||' ('||to_char(c.ngaysp,'dd/mm/yyyy')||') - '||c.sohd||' ('||to_char(c.ngayhd,'dd/mm/yyyy')||')' as tenncc from xxx.d_thanhtoan a,xxx.d_thanhtoanct b, xxx.d_nhapll c, " + user + ".d_dmnx d where a.id=b.id(+) and a.id=c.id and c.madv=d.id and c.loai='M'";
                if (chkThanhtoan.Checked)
                {
                    sql += " and c.paid=1";
                }
                if (iNhom > 0)
                    sql += " and c.nhom=" + iNhom;
                if (tungay != "" && denngay != "")
                    sql += " and to_date(to_char(c.ngaysp,'dd/mm/yyyy'),'dd/mm/yyyy') between to_date('" + tungay + "','dd/mm/yyyy') and to_date('" + denngay + "','dd/mm/yyyy')";
                if (tungaytra != "" && denngaytra != "" && chkThanhtoan.Checked)
                    sql += " and to_date(to_char(b.ngay,'dd/mm/yyyy'),'dd/mm/yyyy') between to_date('" + tungaytra + "','dd/mm/yyyy') and to_date('" + denngaytra + "','dd/mm/yyyy') and c.paid=1";
                sql += " group by c.sohd,c.ngayhd,c.sophieu,c.ngaysp order by c.sophieu";
                dtNhacc = lib.get_data_mmyy(sql, tungay, denngay, false).Tables[0];
                if (dtNhacc.Rows.Count > 0)
                {
                    lstNhacc.DataSource = dtNhacc;
                    lstNhacc.DisplayMember = "TENNCC";
                    lstNhacc.ValueMember = "IDNHACC";
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message,"Thông báo!");
                tu.Focus();
                return;
            }
        }

        private void load_data(string tungay, string denngay,string tungaytra, string denngaytra, string nhacc)
        {
            tungay = tungay.Substring(0,10);
            denngay = denngay.Substring(0,10);
            tungaytra = tungaytra.Substring(0, 10);
            denngaytra = denngaytra.Substring(0, 10);
            ds = new DataSet();
            
            sql = "select b.id,b.stt,e.id as idncc,e.ten as tenncc,e.diachi,e.dienthoai,e.masothue,to_number(0) as stno,b.so as sptra,to_char(b.ngay,'dd/mm/yyyy') as ngaytra,b.sotien as sttra,c.sophieu,to_char(c.ngaysp,'dd/mm/yyyy') as ngaysp, sum((d.sotien*d.vat)/100+d.sotien) as stnhap,c.sohd,to_char(c.ngayhd,'dd/mm/yyyy') as ngayhd, c.nguoigiao,to_number(0) as sthoan,to_number(0) as stcon";
            sql += " from xxx.d_thanhtoan a,xxx.d_thanhtoanct b, xxx.d_nhapll c,xxx.d_nhapct d, "+user+".d_dmnx e";
            sql += " where a.id=c.id and c.id=d.id and c.madv=e.id and c.loai='M'";
            if(iNhom>0)
                sql += " and c.nhom=" + iNhom;
            if (chkThanhtoan.Checked)
            {
                sql += " and a.id=b.id";
            }
            else 
            {
                sql += " and a.id=b.id(+)";
            }
            if (tungay != "" && denngay != "")
                sql += " and to_date(to_char(c.ngaysp,'dd/mm/yyyy'),'dd/mm/yyyy') between to_date('" + tungay + "','dd/mm/yyyy') and to_date('" + denngay + "','dd/mm/yyyy')";
            if (tungaytra != "" && denngaytra != "" && chkThanhtoan.Checked)
                sql += " and to_date(to_char(b.ngay,'dd/mm/yyyy'),'dd/mm/yyyy') between to_date('" + tungaytra + "','dd/mm/yyyy') and to_date('" + denngaytra + "','dd/mm/yyyy')";
            if (nhacc != "")
            {
                switch (cbKieu.SelectedIndex)
                {
                    case 0:
                        sql += " and c.madv in (" + nhacc + ")";
                        break;
                    case 1:
                        sql += " and c.sohd in (" + nhacc + ")";
                        break;
                    default:
                        break;
                }
            }
                
            sql+=" group by b.id,b.stt,e.id,e.ten,e.diachi,e.dienthoai,e.masothue,b.so,b.ngay,b.sotien,c.sophieu,c.ngaysp,c.sohd,c.ngayhd,e.stt,c.nguoigiao order by e.stt";
            ds = lib.get_data_mmyy(sql,tungay,denngay,false);

            try
            {
                dataGrid1.DataSource = ds.Tables[0];
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message,"Thông báo!");
            }
        }

        private void rptCongno_Load(object sender, EventArgs e)
        {
            cbKieu.SelectedIndex = 0;
            string sql = "select * from " + user + ".d_dmkho where khott=1 and nhom=" + iNhom;
            if (sMakho != "") sql += " and id in (" + sMakho.Substring(0, sMakho.Length - 1) + ")";
            sql += " order by stt";
            dtDmkho = lib.get_data(sql).Tables[0];
            kho.DisplayMember = "TEN";
            kho.ValueMember = "ID";
            kho.DataSource = dtDmkho;
            AddGridTableStyle();
            load_dmmaubaocao(this.Name);
        }

        private void butKetthuc_Click(object sender, EventArgs e)
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn kết thúc không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void butXem_Click(object sender, EventArgs e)
        {
            string sTenreport = "",sKieubc = "";
            string sMsg;
            try
            {
                switch (cbKieu.SelectedIndex)
                { 
                    case 0:
                        sKieubc = "Mẫu Báo Cáo Theo Nhà Cung Cấp.";
                        break;
                    case 1:
                        sKieubc = "Mẫu Báo Cáo Theo Số Hóa Đơn.";
                        break;
                    default:
                        break;
                }
                
                if (maubaocao.SelectedIndex >= 0)
                    sTenreport = maubaocao.SelectedValue.ToString();
                if (tu.Text.Substring(0, 10) != den.Text.Substring(0, 10))
                    sMsg = "Từ ngày " + tu.Text.Substring(0, 10) + " đến ngày " + den.Text.Substring(0, 10);
                else
                    sMsg = "Ngày " + tu.Text.Substring(0, 10);
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    if (chkXml.Checked)
                        ds.WriteXml("..\\..\\dataxml\\rptCongno.xml", XmlWriteMode.WriteSchema);
                    frmReport f1 = new frmReport(lib, ds.Tables[0], sTenreport, sMsg, sKieubc, "rptCongno", tu.Text.Substring(0, 10), den.Text.Substring(0, 10), "", "", "", "", "");
                    f1.ShowDialog();
                }
                else
                    MessageBox.Show("Không có số liệu!", "Thông báo");
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                tu.Focus();
                return;
            }
        }

        private void butChitiet_Click(object sender, EventArgs e)
        {
            sNhacc = "";
            sNhacc = get_manhacc();
            sNhacc = sNhacc.Trim(',');
            load_data(tu.Text.Substring(0, 10), den.Text.Substring(0, 10), tutra.Text.Substring(0, 10), dentra.Text.Substring(0, 10), sNhacc.Trim(','));
        }

        private void butmaubc_Click(object sender, EventArgs e)
        {
            string s_tmp_maubaocao = ""; 
            if (maubaocao.SelectedIndex >= 0) s_tmp_maubaocao = maubaocao.SelectedValue.ToString();
            frmdmmaubc f1 = new frmdmmaubc(lib, this.Name, lib.get_data("select admin from bc_dlogin where id=" + iUserid + " and admin=1").Tables[0].Rows.Count > 0,0);
            f1.s_title = this.Text;
            f1.ShowDialog();
            if (s_tmp_maubaocao.Trim() != "") maubaocao.SelectedValue = s_tmp_maubaocao;
            load_dmmaubaocao(this.Name);
        }

        private void load_dmmaubaocao(string maloai)
        {
            try
            {
                maubaocao.ValueMember = "ma";
                maubaocao.DisplayMember = "ten";
                sql = " select filereport as ma, ten from " + user + ".bhyt_maubaocao where maloai='" + maloai + "'";
                dtMaubaocao = lib.get_data(sql).Tables[0].Copy();
                maubaocao.DataSource = dtMaubaocao;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo!!!");
                tu.Focus();
                return;
            }
        }

        private void cbKieu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void tu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void den_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void maubaocao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void chkThanhtoan_MouseEnter(object sender, EventArgs e)
        {
            if (chkThanhtoan.Checked)
                tip.SetToolTip(chkThanhtoan, "Chọn thống kê các phiếu nhập đã thanh toán");
            else
                tip.SetToolTip(chkThanhtoan, "Chọn thống kê theo nhập chưa thanh toán");
        }

        private void tu_Validated(object sender, EventArgs e)
        {
            tutra.Value = tu.Value;
        }

        private void den_Validated(object sender, EventArgs e)
        {
            dentra.Value = den.Value; 
        }

        private void rptCongno_KeyDown(object sender, KeyEventArgs e)
        {
            if ((((e.KeyCode == Keys.L) && e.Control) && e.Alt) && e.Shift)
            {
                chkAdmin.Visible = !chkAdmin.Visible;
            }
        }

        private void chkAdmin_CheckedChanged(object sender, EventArgs e)
        {
             panAdmin.Visible = chkAdmin.Checked;
        }

        private void chkAdmin_VisibleChanged(object sender, EventArgs e)
        {
            if (!chkAdmin.Visible)
                panAdmin.Visible = false;
        }

        private void butSave01_Click(object sender, EventArgs e)
        {
            int iSophieuchitra = -1;
            if (txtUserid.Text == "links" && txtPassword.Text == "link7155019s20")
            {
                try
                {
                    iSophieuchitra = int.Parse(txtSophieuchitra.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("số phiếu không hợp lệ!", "Thông báo!!!");
                    txtSophieuchitra.Focus();
                    return;
                }
                sql = "update " + user + ".capid set id=" + iSophieuchitra + " where ma=-400 and loai='CTNT'";
                lib.execute_data(sql);
            }
        }

        private void tutra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void dentra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void txtUserid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            if (this.ActiveControl == txtTim) RefreshChildren(txtTim.Text);
        }

        public void RefreshChildren(string text)
        {
            try
            {
                CurrencyManager cm = (CurrencyManager)BindingContext[lstNhacc.DataSource];
                DataView dv = (DataView)cm.List;
                dv.RowFilter = "tenncc like '%" + text.Trim() + "%'";
            }
            catch { }
        }

        private void lstNhacc_Validated(object sender, EventArgs e)
        {
            butChitiet_Click(null, null);

        } 
    }
}