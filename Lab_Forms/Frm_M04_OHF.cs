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
    public partial class Frm_M04_OHF : Form
    {
        public Frm_M04_OHF()
        {
            InitializeComponent();
        }

        private void btn_OHF_Click(object sender, EventArgs e)
        {
            Lab_M02_Form helloForm = new Lab_M02_Form();
            helloForm.Show();
        }


        void Method1()
        {

            MessageBox.Show("Method 1");
        }

        private void btn_Method1_Click(object sender, EventArgs e)
        {
            Method1();
        }

        MyFirstClass mfc = new MyFirstClass();

        private void btn01_Click(object sender, EventArgs e)
        {
            //mfc.method01();
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            //mfc.method02();
        }

        private void btn03_Click(object sender, EventArgs e)
        {
            mfc.method03();
        }
        string BirthYear(int Age) 
        {
            int BY = DateTime.Now.Year - Age;
            string result = "Born in " + BY + " A.D.";
            return result;
        }

        private void btn_age_Click(object sender, EventArgs e)
        {

           string by = BirthYear(30);
            MessageBox.Show(by);
        }

        private void btn_encap_Click(object sender, EventArgs e)
        {
            MyFirstClass mfc = new MyFirstClass();
            mfc.method04();
        }

        private void btn_parcial_Click(object sender, EventArgs e)
        {
            MyFirstClass mc = new MyFirstClass();
            mc.method05();
        }
    }
}
