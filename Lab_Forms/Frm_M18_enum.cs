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
    public partial class Frm_M18_enum : Form
    {
        public Frm_M18_enum()
        {
            InitializeComponent();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Success !!");
        }

        UserRole Role = UserRole.Admin;
        private void btn_varify_enum_Click(object sender, EventArgs e)
        {

            //if (Role == UserRole.Admin)
            //{
            //    btn_product.Enabled = true;
            //}
            //else
            //{
            //    btn_product.Enabled = false;
            //}

            btn_product.Enabled = Role == UserRole.Admin;

        }

        private void btn_switch_Click(object sender, EventArgs e)
        {
            switch (Role) 
            {
                case UserRole.Admin:
                    btn_product.Enabled = true;
                    break;

                case UserRole.User:
                    btn_product.Enabled = false;
                    break;

            }
        }
    }
}
