using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        
        public Calculator()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(txtSo1.Text);
            b = int.Parse(txtSo2.Text);
            Calculation c = new Calculation(a, b);
            ketqua = c.Execute("+");
            txtKq.Text = ketqua.ToString();
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(txtSo1.Text);
            b = int.Parse(txtSo2.Text);
            Calculation c = new Calculation(a, b);
            ketqua = c.Execute("-");
            txtKq.Text = ketqua.ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(txtSo1.Text);
            b = int.Parse(txtSo2.Text);
            Calculation c = new Calculation(a, b);
            ketqua = c.Execute("*");
            txtKq.Text = ketqua.ToString();
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(txtSo1.Text);
            b = int.Parse(txtSo2.Text);
            Calculation c = new Calculation(a, b);
            ketqua = c.Execute("/");
            txtKq.Text = ketqua.ToString();
        }
    }
}
