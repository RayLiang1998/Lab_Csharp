using System;
using System.Collections;
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
    public partial class Frm_M29 : Form
    {
        public Frm_M29()
        {
            InitializeComponent();
        }

        ArrayList lsEmp = new ArrayList();
        void ShowEmployee()
        {
            lab_show.Text = "Employee: \n";
            for (int i = 0; i < lsEmp.Count; i++)
            {
                lab_show.Text += $"Name: {((Employee)lsEmp[i]).Name}" +
                    $", Age: {((Employee)lsEmp[i]).Age}\n";
                //unboxing
            }
            lab_show.Text += $"--------------------\nTotal Employee Count: {lsEmp.Count}";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Employee emp;
            emp.Name = txt_Ename.Text;
            emp.Age = int.Parse(txt_Eage.Text);

            lsEmp.Add(emp); //boxing

            ShowEmployee();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            Employee emp;
            emp.Name = txt_Ename.Text;
            emp.Age = int.Parse(txt_Eage.Text);

            lsEmp.Insert(0, emp);

            ShowEmployee();
        }

        private void btrn_clear_Click(object sender, EventArgs e)
        {
            lsEmp.Clear();
            ShowEmployee();
        }

        private void btn_removeat_Click(object sender, EventArgs e)
        {
            lsEmp.RemoveAt(0);
            ShowEmployee();
        }

        private void btn_add_tp_Click(object sender, EventArgs e)
        {
            Employee emp;
            emp.Name = txt_Ename.Text;
            int age = 0;
            if (int.TryParse(txt_Eage.Text, out age))
            {
                emp.Age = age;
                lsEmp.Add(emp);
            }
            else
            {
                MessageBox.Show("Please enter age in numbers!");
                txt_Eage.Clear();
                txt_Eage.Focus();
            }

            //emp.Age = int.Parse(txt_Eage.Text);

            //lsEmp.Add(emp); //boxing

            ShowEmployee();
        }
    }
}
