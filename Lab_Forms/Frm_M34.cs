using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Forms
{
    public partial class Frm_M34 : Form
    {
        public Frm_M34()
        {
            InitializeComponent();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Student\source\repos\Lab_Csharp\Lab_Forms\bin\Debug\news.txt", Encoding.UTF8);
            txt_readwrite.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void btn_write_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\Student\source\repos\Lab_Csharp\Lab_Forms\bin\Debug\news.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(txt_readwrite.Text);
            sw.Close();
            fs.Close();

        }
    }
}
