using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Forms
{
    public partial class Frm_M15_CTS : Form
    {
        public Frm_M15_CTS()
        {
            InitializeComponent();
        }

        private void btn_callValue_Click(object sender, EventArgs e)
        {
            int A = 100;
            MessageBox.Show("A: " + A.ToString());

            int B = A;
            MessageBox.Show("A: " + A + " ,B: " + B);

            B = 200;
            MessageBox.Show("A: " + A + " ,B: " + B);
        }

        private void btn_ref_Click(object sender, EventArgs e)
        {
            TextBox tb = txtb_ref;
            tb.Text = "Reference Type";
            tb.BackColor = Color.AliceBlue;
            tb.ForeColor = Color.Coral;
            tb.Location = new Point(306, 165);
        }

        //private void btn_callReference_Click(object sender, EventArgs e)
        //{
        //    object A = "AAA";
        //    object B = "BBB";
        //    MessageBox.Show("A: " + A + " ,B: " + B);
        //    object C = B;
        //    MessageBox.Show("A: " + A + " ,B: " + B + " ,C: " + C);
        //     C = "CCC";
        //    MessageBox.Show("A: " + A + " ,B: " + B + " ,C: " + C);
        //}
    }
}
