using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Forms
{
    partial class MyFirstClass
    {

        public void method05()
        {
            MessageBox.Show("Partial class success !");

        }

    }

    public class Member
        {
        public string Name;
        public int Age;

        }

    public class UseStatic
    {

        public int InstanceCount;
        public static int StaticCount;
    
    }

    public enum UserRole 
    {
        Admin, 
        User = 2
    }

    public struct Product 
    {
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }

        public Product(string name, decimal price) 
        {
            ProductName = name;
            ProductPrice = price;

        }
        
    }

    public struct Employee
    {
        public string Name;
        public int Age;
    }

}
