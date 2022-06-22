using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Forms
{
    public partial class MyFirstClass
    {
        void method01()
        {
            MessageBox.Show("method01");
        }

        public void method02() 
        {
            MessageBox.Show("method02");
        }

        public void method03() 
        {
            MessageBox.Show("method03");
        }

        public void method04() 
        {
            method01();
            method02();

        }

    }
}
