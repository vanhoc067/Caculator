using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator
{
    public partial class FCau1 : Form
    {
        public FCau1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, ketQua;
            int n;
            FCau1 c = new FCau1();
            x = double.Parse(txtX.Text);
            n = int.Parse(txtN.Text);
            ketQua = c.Power(x,n);
            txtKQ.Text = ketQua.ToString();
        }
    }
}
