using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Forms
{
    public partial class Frm_M32 : Form
    {
        public Frm_M32()
        {
            InitializeComponent();
        }

        private void btn_string_Click(object sender, EventArgs e)
        {
            string A = "AAA";
            string B = A;
            B = "BBB";
            MessageBox.Show($"A: {A},  B: {B}");

        }

        private void btn_stringB_Click(object sender, EventArgs e)
        {
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("stringbuilder1");
            StringBuilder sb2 = new StringBuilder();
            sb2 = sb1;
            sb2.Append("\nstringbuilder2");
            MessageBox.Show(sb1.ToString());
        }

        private void btn_path_Click(object sender, EventArgs e)
        {
            string dir = @"C:\Users\Student\Pictures\Saved Pictures\womanyellingcat.jpg";
            string result = "";
            result += Path.GetDirectoryName(dir) + "\n" + Path.GetExtension(dir) +"\n" + Path.GetFileName(dir);
            MessageBox.Show(result);
               
        }

        private void btn_stringindex_Click(object sender, EventArgs e)
        {
            string str = "冰裡來火裡去";
            char c = str[1];
            MessageBox.Show(c.ToString());

            string str2 = str.Insert(0, "他從");
            MessageBox.Show(str2);

            int w = str2.IndexOf("裡");
            MessageBox.Show(w.ToString());

            int l = str2.LastIndexOf("裡");
            MessageBox.Show(l.ToString());

            string r = str2.Replace("裡", "中");
            MessageBox.Show(r);


        }
        bool IsStrongPassword(string Password)
        {
            return Regex.IsMatch(Password, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,16}$");
        }

        bool IsValidId(string id)
        {
            return Regex.IsMatch(id, @"^[A-Z]{1}[1-2]{1}[0-9]{8}$");
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //lab_strength.Text = IsStrongPassword(txt_password.Text) ? "Password Strength:\n Strong" : "Password Strength:\n Weak";

            if(IsStrongPassword(txt_password.Text))
            {
                lab_strength.Text = "Password Strength:\n Strong";
                tmr_password.Enabled = false;
                lab_strength.ForeColor = Color.Green;
            }
            else
            {
                lab_strength.Text = "Password Strength:\n Weak";
                tmr_password.Enabled = true;
            }
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            lab_validity.Text = IsValidId(txt_id.Text) ? "Valid ID" : "Invalid ID";
        }

        bool flag = true;

        private void tmr_password_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                lab_strength.ForeColor = Color.Red;
            }
            else
            {
                lab_strength.ForeColor = Color.Yellow;
            }
            flag = !flag;
        }
    }
}
