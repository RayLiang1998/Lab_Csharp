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
            for (int i = 0; i < 10; i += 2)
            {
                arr[i] = 2 + i;
                result += arr[i];
            }

            //MessageBox.Show(arr[2].ToString());
            MessageBox.Show(result);

        }


        private void btn_md_arr_Click(object sender, EventArgs e)
        {
            //int[,] marr = new int[2, 3];
            //marr[0, 0] = 1; marr[0, 1] = 2; marr[1, 0] = 3;
            //marr[1, 1] = 4; marr[2, 0] = 5; marr[2, 1] = 6;
            int[,] marr =
            {
                { 1,2},
                { 3,4},
                { 5,6}
            };

            string result = "";

            for (int i = 0; i < marr.GetLength(0); i++)
            {

                for (int j = 0; j < marr.GetLength(1); j++)
                {

                    result += $"marr[{i},{j}] = { marr[i, j]}\n";
                }

            }
            MessageBox.Show(result);
        }
        int[] CreateInsArray(int Length)
        {
            int[] arr = new int[Length];
            for (int i = 0; i < arr.GetLength(0);)
                arr[i] = ++i;
            return arr;
        }
        private void btn_return_arr_Click(object sender, EventArgs e)
        {
            int[] intarr = CreateInsArray(20);
            string result = "";
            //for (int i = 0; i < intarr.GetLength(0);i++)
            //{
            //    result += intarr[i] + ", ";
            //}
            foreach(int item in intarr)
            {
                result += $"{item}\n";
            }
            MessageBox.Show(result);
        }

        private void byn_arrr_mem_Click(object sender, EventArgs e)
        {
            Member[] arrMember = new Member[2];
            arrMember[0] = new Member();
            arrMember[0].Name = "AAA";
            arrMember[0].Age = 24;
            arrMember[1] = new Member();
            arrMember[1].Name = "BBB";
            arrMember[1].Age = 26;

            //Member mem1 = new Member() { Name = "CCC", Age = 28 };
            //Member mem2 = new Member() { Name = "DDD", Age = 27 };
            //Member[] arrMember = new Member[2] { mem1, mem2 };

            //MessageBox.Show($"Name: {arrMember[0].Name}, Age: {arrMember[0].Age}");

            string result = "";
            foreach(Member item in arrMember)
            {
                result += $"Name: {item.Name}, Age: {item.Age}\n";
            }
            MessageBox.Show(result);

        }
    }
}
