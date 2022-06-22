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
    public partial class Frm_M07 : Form
    {
        public Frm_M07()
        {
            InitializeComponent();
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            Member mem1 = new Member();

            mem1.Name = "Ray";
            mem1.Age = 24;

            string name = mem1.Name;
            int age = mem1.Age;

            MessageBox.Show("Name: " + name + " Age: " + age);

            Member mem2 = new Member() 
            {
                Name = "IU",
                Age = 29
            };

            MessageBox.Show("Name: " + mem2.Name + " Age: " + mem2.Age);

        }

        private void btn_reg0_Click(object sender, EventArgs e)
        {
            //this.btn_reg0.Click += new System.EventHandler(this.btn_reg0_Click);

            btn_reg1.Click += new EventHandler(btn_reg1Click);
            btn_reg2.Click += btn_reg2Click;

        }

        private void btn_reg2Click(object sender, EventArgs e)
        {
            MessageBox.Show("Register Success !!");
        }

        private void btn_reg1Click(object sender, EventArgs e)
        {
            MessageBox.Show("Register Success !");
        }

        private void btn_deReg_Click(object sender, EventArgs e)
        {
            btn_reg1.Click -= new EventHandler(btn_reg1Click);
        }

        delegate double Payment(double aaae);

        double discount50off(double Price) 
        {
            return Price * 0.5;
        }
        double discount20off(double Price)
        {
            return Price * 0.8;
        }

        private void btn_finalprice_Click(object sender, EventArgs e)
        {
            Payment discount;
            if (cmb_disc.Text == "50% off") 
            {
                discount = discount50off;
            }
            else 
            {
                discount = discount20off;
            }
            double Price = double.Parse(txtb_org.Text);
            double Result = discount(Price);
            MessageBox.Show("Original Price: "+txtb_org.Text+"\n"+"Chosen Discount: "+cmb_disc.Text+"\n"+"Final Price: "+ Result.ToString());
        }

        private void btn_setp_Click(object sender, EventArgs e)
        {
            Text = "Property Set";
        }

        private void btn_123_Click(object sender, EventArgs e)
        {
            //DialogResult result;
            //result = MessageBox.Show("What day is today?", "???", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question( == DRY{
            //    T= ""))
        }
    }
}
