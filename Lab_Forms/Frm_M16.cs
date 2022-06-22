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
    public partial class Frm_M16 : Form
    {
        public Frm_M16()
        {
            InitializeComponent();
        }

        private void btn_byVT_Click(object sender, EventArgs e)
        {
            decimal Dec = 10;
            MessageBox.Show(Dec.ToString());
            byValueType(Dec);
            MessageBox.Show(Dec.ToString());
        }

        void byValueType(decimal d) 
        {
            d = 1000;
        }

        private void btn_byRT_Click(object sender, EventArgs e)
        {
            Member mbr = new Member();
            mbr.Name = "aaa";
            mbr.Age = 20;
            MessageBox.Show(mbr.Name + " , " + mbr.Age);
            byReferenceType(mbr);
            MessageBox.Show("after change: \n" + mbr.Name + " , " + mbr.Age);
        }

        void byReferenceType(Member m) 
        {
            m.Age = 30;
        }

        private void btn_VtoR_Click(object sender, EventArgs e)
        {
            decimal Dec1 = 10;
            MessageBox.Show(Dec1.ToString());
            toReferenceType(ref Dec1);
            MessageBox.Show("after reference: \n" + Dec1.ToString());
        }
        void toReferenceType(ref decimal d)
        {
            d = 1000;
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            int a;
            byOut(out a);
            MessageBox.Show(a.ToString());
        }

        void byOut(out int Age) 
        {
            Age = 10;
        }

        private void btn_params_Click(object sender, EventArgs e)
        {
            string totalC = MyParams("Chinese", 60, 80, 70);
            MessageBox.Show(totalC);
            string totalM = MyParams("Math", 90, 70, 80, 60);
            MessageBox.Show(totalM);
            MessageBox.Show($"{totalC}\n{totalM}");
        }
        static string MyParams(string cls, params int[] score) 
        {
            int total = 0;
            for (int i = 0; i < score.Length; i++) 
            {
                total += score[i];
            }
            return cls + "total score: " + total;
        }
    }
}
