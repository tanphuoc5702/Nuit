using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abcTOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = Int32.Parse(txtSo1.Text);
            b = Int32.Parse(txtSo2.Text);
            abcTion c = new abcTion(a,b);
            ketqua = c.Exectute("+");
            txtKQ.Text = ketqua.ToString(); 
        }

        private void btnLuyThua_Click(object sender, EventArgs e)
        {
            double x;
            int n;
            double ketqua;
            x = Double.Parse(txtSo1.Text);
            n = Int32.Parse(txtSo2.Text);
            ketqua = abcTion.Power(x, n);
            txtKQ.Text = ketqua.ToString();

        }
    }
}
