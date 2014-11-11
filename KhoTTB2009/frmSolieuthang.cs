using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Duoc

{
    public partial class frmSolieuthang : Form
    {
        public frmSolieuthang()
        {
            InitializeComponent();
        }
        public string mmyy = "";
        private void frmSolieuthang_Load(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Year.ToString().Substring(2, 2);
            button1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}