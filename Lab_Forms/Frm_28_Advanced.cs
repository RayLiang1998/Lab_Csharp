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
    public partial class Frm_28_Advanced : Form
    {
        public Frm_28_Advanced()
        {
            InitializeComponent();
        }

        void Swap(ref int A, ref int B)
        {
            int T = A;
            A = B;
            B = T;
        }

        void Swap(ref string A, ref string B)
        {
            string T = A;
            A = B;
            B = T;
        }

        void GenericSwap<T>(ref T a, ref T b)
        {
            T t = a;
            a = b;
            b = t;
        }


        private void btn_swap_int_Click(object sender, EventArgs e)
        {
            int a = 100, b = 200;
            MessageBox.Show($"a = {a}, b = {b}");
            Swap(ref a, ref b);
            MessageBox.Show($"a = {a}, b = {b}");
        }

        private void btn_swap_string_Click(object sender, EventArgs e)
        {
            string a = "AAA", b = "BBB";
            MessageBox.Show($"a = {a}, b = {b}");
            Swap(ref a, ref b);
            MessageBox.Show($"a = {a}, b = {b}");
        }

        private void btn_Gswap_Click(object sender, EventArgs e)
        {
            int a = 100, b = 200;
            GenericSwap<int>(ref a, ref b);
            MessageBox.Show($"a = {a}, b = {b}");

            string s1 = "s111", s2 = "s222";
            GenericSwap<string>(ref s1, ref s2);
            MessageBox.Show($"s1 = {s1}, s2 = {s2}");
        }
    }
}
