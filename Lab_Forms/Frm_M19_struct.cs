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
    public partial class Frm_M19_struct : Form
    {
        public Frm_M19_struct()
        {
            InitializeComponent();
        }

        string result = "Product:";
        int count = 0;
        decimal ttPrice = 0;


        private void btn_add_Click(object sender, EventArgs e)
        {
            //Product pd= new Product();
            //pd.ProductName = txt_PN.Text;
            //pd.ProductPrice = decimal.Parse(txt_PP.Text);

            decimal price = 0;
            bool isNum = decimal.TryParse(txt_PP.Text, out price);

            if (isNum)
            {
                Product pd = new Product(txt_PN.Text, decimal.Parse(txt_PP.Text));

                count++;
                ttPrice += pd.ProductPrice;

                //result += "\nName: " + pd.ProductName + ",  Price: " + pd.ProductPrice;
                result += $"\nName:  {pd.ProductName},  Price:  {pd.ProductPrice:c0}";
            }
            else 
            {
                MessageBox.Show("Please enter correct number format!!!");
                txt_PP.Clear();
                txt_PP.Focus();
            }

            
        }


        private void btn_show_Click(object sender, EventArgs e)
        {
            
            lab_show.Text = $"{result}\n----------------------\nItem Count: {count}\nTotal Price: {ttPrice:c0}";
            txt_PN.Clear();
            txt_PP.Clear();
            txt_PN.Focus();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            txt_PN.Clear();
            txt_PP.Clear();
            txt_PN.Focus();
        }
    }
}
