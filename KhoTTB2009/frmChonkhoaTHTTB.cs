using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using LibTTB;

namespace TTB
{
    public partial class frmChonkhoaTHTTB : Form
    {
        private LibTTB.AccessData ttb;
        private LibDuoc.AccessData d = new LibDuoc.AccessData();
        private DataTable dtkhoa = new DataTable();
        private DataSet dsxml = new DataSet();
        private int i_nhom;
        private string s_makho, s_makp, user;
        public int i_makho, i_makp;
        public string mmyy, tenkho;
        public frmChonkhoaTHTTB()
        {
            InitializeComponent();
        }
        public frmChonkhoaTHTTB(AccessData acc, int nhom, string kho, string makp, string mmyy)
        {
            InitializeComponent();
            ttb = acc; i_nhom = nhom; s_makho = kho; s_makp = makp;
            mm.Value = decimal.Parse(mmyy.Substring(0, 2));
            yyyy.Value = decimal.Parse("20" + mmyy.Substring(2, 2));
        }
        private void frmChonkhoaTHTTB_Load(object sender, EventArgs e)
        {
            user = ttb.user;
            makho.DisplayMember = "TEN";
            makho.ValueMember = "ID";
            string sql = "select * from " + user + ".ttb_dmkho where nhom=" + i_nhom;
            if (s_makho != "") sql += " and id in (" + s_makho.Substring(0, s_makho.Length - 1) + ")";
            sql += " order by stt";
            makho.DataSource = ttb.get_data(sql).Tables[0];
            if (makho.Items.Count > 0) makho.SelectedIndex = 0;

            makp.DisplayMember = "TEN";
            makp.ValueMember = "ID";
            
            sql = "select id,ten from " + d.user + ".d_duockp where nhom like '%" + i_nhom.ToString() + ",%'";
            if (s_makp != "") sql += " and id in (" + s_makp.Substring(0, s_makp.Length - 1) + ")";
            sql += " order by stt";
            dtkhoa = d.get_data(sql).Tables[0];
            ttb.convertFont(dtkhoa, "ten");
           
            DataRow dr = dtkhoa.NewRow();
            dr["ID"] = 0;
            dr["TEN"] = "Tất cả .....";
            dtkhoa.Rows.Add(dr);
            makp.DataSource = dtkhoa;
            if (makp.Items.Count > 0) makp.SelectedIndex = 0;
        }

        private void mm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab) SendKeys.Send("{Tab}");
        }

        private void yyyy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab) SendKeys.Send("{Tab}{F4}");
        }

        private void makho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (makho.SelectedIndex == -1) makho.SelectedIndex = 0;
                SendKeys.Send("{Tab}");
            }
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            string s_title="Tháng "+mm.Value.ToString()+" năm "+yyyy.Value.ToString();
            string s_tenkho = makho.Text;// ToString();
            string sql = "";// "select  makp,manguon,tennguon,nhomcc,sothe,sotien,namsx,namsd,trangthietbi,model,congsuat,dvt,tenhang,tennuoc,tennhacc,tenkp,ma,idduyet,tinhtrang,count(z.mabd) as sl from (";
            sql += " select distinct a.mabd,(tondau+slnhap-slxuat) sl,a.makp,a.makho,a.manguon,k.ten as tennguon,a.nhomcc,a.losx as model,a.sothe,h.giamua sotien,a.namsx,substr(a.namsd,length(a.namsd)-3)as namsd,trim(b.ten)||' '||b.hamluong as trangthietbi,congsuat,b.dang as dvt,c.ten as tenhang,d.ten as tennuoc,e.ten as tennhacc,f.ten as tenkp,b.ma, a.idduyet,l.ten as tinhtrang";
            sql += " from " + user + ".ttb_tscdkhoa a," + user + ".ttb_dmbd b," + user + ".ttb_dmhang c," + user + ".ttb_dmnuoc d," + user + ".ttb_dmnx e," + d.user + ".d_duockp f," + user + ".ttb_dmnhom g," + user + ".ttb_dmnguon k ," + user + ".ttb_tutrucct m, " + user + ".ttb_theodoi h left join " + user + ".ttb_dmtinhtrang l on h.tinhtrang=l.id";
           sql += " where a.mabd=b.id and b.manhom=g.id and b.mahang=c.id  and a.manguon=k.id and b.manuoc=d.id and a.nhomcc=e.id and a.makp=f.id and a.stt=h.id ";
            sql += " and g.theodoi=1 and b.bhyt<>0";
            if (makho.SelectedValue.ToString() != "0") sql += " and a.makho in (" + makho.SelectedValue.ToString() + ")";
            else if (makho.SelectedValue.ToString()!= "") sql += " and a.makho in (" + s_tenkho.Substring(0, s_makho.Length - 1) + ")";
            if (makp.SelectedValue.ToString() != "0") sql += " and a.makp =" + makp.SelectedValue.ToString();
            else if (makp.SelectedValue.ToString() != "") sql += " ";
           // sql += " )z group by mabd,makp,manguon,tennguon,nhomcc,sothe,sotien,namsx,namsd,trangthietbi,model,congsuat,dvt,tenhang,tennuoc,tennhacc,tenkp,ma,idduyet,tinhtrang";
            sql += "  and m.mmyy='" + mm.Value.ToString().PadLeft(2, '0') + yyyy.Value.ToString().Substring(2, 2) + "' and m.mabd=a.mabd and m.makho=a.makho and m.makp=a.makp  and m.stt=a.stt ";
            sql += " order by trangthietbi";
            dsxml = ttb.get_data(sql);
            dsxml.WriteXml("..\\..\\..\\xml\\ttb_tonghoptheokhoa.xml", XmlWriteMode.WriteSchema);
            string tenfile = "ttb_tonghoptheokhoa.rpt";
            if (dsxml.Tables[0].Rows.Count == 0) MessageBox.Show("Không có số liệu !", ttb.Msg);
            else
            {
                frmReport f1 = new frmReport(ttb, dsxml.Tables[0], tenfile,s_tenkho, s_title, "", "", "", "", "", "", "", "");
                f1.ShowDialog(this);
            }
        }

        private void butKetthuc_Click(object sender, EventArgs e)
        {
            mmyy = "";
            this.Close();
        }

        private void makp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (makp.SelectedIndex == -1) makp.SelectedIndex = 0;
                SendKeys.Send("{Tab}");
            }	
        }
    }
}