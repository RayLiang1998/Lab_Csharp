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
    public partial class Lab_M02_Form : Form
    {
        public Lab_M02_Form()
        {
            InitializeComponent();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            string Name = txt_name.Text;
            MessageBox.Show("Welcome, " + Name + " !");

            MessageBox.Show(UseStatic.StaticCount.ToString());
        }
    }
}
