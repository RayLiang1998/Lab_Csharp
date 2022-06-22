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
    public partial class Frm_M26_array : Form
    {
        public Frm_M26_array()
        {
            InitializeComponent();
        }

        private void btn_esta_arr_Click(object sender, EventArgs e)
        {
            //int[] arr = { 1, 2, 3, 4, 5 };
            int[] arr = new int[10];  
            string result = "";
            for(int i=0; i<10; i+=2)
            {
                arr[i] = 2 + i;
                result += arr[i];
            }

            //MessageBox.Show(arr[2].ToString());
            MessageBox.Show(result);

        }
    }
}
