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
    public partial class Frm_M12 : Form
    {
        public Frm_M12()
        {
            InitializeComponent();
        }
        int count = 0;
        private void btn_add_Click(object sender, EventArgs e)
        {
            count += 1;
            lab_count.Text = "Count: " + count;

        }

        private void btn_substract_Click(object sender, EventArgs e)
        {
            count -= 1;
            lab_count.Text = "Count: " + count;
        }

        private void btn_var1_Click(object sender, EventArgs e)
        {

        }

        UseStatic us = new UseStatic();

        private void btn_instanceC_Click(object sender, EventArgs e)
        {
            us.InstanceCount++;
            lab_IC.Text = "Instance Count: " + us.InstanceCount.ToString();

        }

        private void btn_staticC_Click(object sender, EventArgs e)
        {
            UseStatic.StaticCount++;
            lab_SC.Text = "Static Count: " + UseStatic.StaticCount.ToString();
        }

        private void btn_ohf_m12_Click(object sender, EventArgs e)
        {
            Lab_M02_Form frm2 = new Lab_M02_Form();
            frm2.Show();
        }
    }
}
