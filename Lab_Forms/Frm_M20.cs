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
    public partial class Frm_M20 : Form
    {
        public Frm_M20()
        {
            InitializeComponent();
        }

        private void btn_conv_Click(object sender, EventArgs e)
        {
            double d = 3.4;
            //int i = (int)d;
            int i = Convert.ToInt32(d);
            MessageBox.Show(i.ToString());
        }
        bool flag = true;
        private void btn_bool_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                btn_conv.BackColor = Color.Aqua;
            }
            else 
            {
                btn_conv.BackColor = Color.Bisque;
            }
            flag = !flag;

        }

        private void btn_tenary_Click(object sender, EventArgs e)
        {
            btn_conv.BackColor = flag ? Color.AliceBlue : Color.Azure;
            flag = !flag;
        }
        
        private void btn_score_Click(object sender, EventArgs e)
        {
            //decimal score = 0;
            //bool num = decimal.TryParse(txt_score.Text, out score);
            int score = 0;
            if (int.TryParse(txt_score.Text, out score))
            {
                if (score >= 90 && score<= 100)
                    lab_grade.Text = "Grade: A";
                else if(score >= 80)
                    lab_grade.Text = "Grade: B";
                else if (score >= 70)
                    lab_grade.Text = "Grade: C";
                else if (score >= 60)
                    lab_grade.Text = "Grade: D";
                else
                {
                    lab_grade.Text = "Grade: F";
                    lab_grade.ForeColor = Color.Red;
                }
                    
            }
            else
            {
                MessageBox.Show("Please enter score in numbers!");
                txt_score.Clear();
                txt_score.Focus();
            }
                

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Is today Wednesday?", "Question?"
                , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    MessageBox.Show("Correct");
                        break;
                case DialogResult.No:
                    MessageBox.Show("Incorrect");
                        break;
                default:
                    MessageBox.Show("Default");
                    break;

            }
               
        }

        private void btn_while_Click(object sender, EventArgs e)
        {
            int i = 10;
            string result ="";
            while (i <= 9)
            {
                result += i +"\n";
                i++;
            }
            MessageBox.Show(result);
        }

        private void btn_do_Click(object sender, EventArgs e)
        {
            int i = 10;
            string result = "";
            do
            {
                result += i + "\n";
                i++;
            } while (i <= 9);
            MessageBox.Show(result);
        }

        private void btn_for_Click(object sender, EventArgs e)
        {
            string result = "";
            //for(int i =0; i<10;)
            //{
            //    result += i++ + "\n";
            //}
            //MessageBox.Show(result);

            for(int i=0, j=10, k=5; i<=j+k; i+=2, k++)
            {
                result += $"i = {i}, j = {j}, k = {k}\n";
            }
            MessageBox.Show(result);
        }

        private void btn_foreach_Click(object sender, EventArgs e)
        {
            foreach(Control item in Controls)
            {
                //if(item.GetType()!= typeof(Button))
                //{
                //    continue;
                //}
                if(!(item is Button))
                {
                    continue;
                }

                item.Left -= 10;
                item.Top -= 10;
                item.BackColor = Color.HotPink;
                item.ForeColor = Color.Honeydew;
            }
        }
    }
}
