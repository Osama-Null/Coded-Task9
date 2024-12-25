using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleT9.Models
{
    internal class Account
    {
        private string userName;
        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                if (value != null)
                {
                    userName = value;
                }
                else Console.WriteLine("Please Enter User Name: ");
            }
        }
        private float salary;
        public float Salary 
        {
            get 
            { 
                return salary;
            }
            set 
            {
                if(value >=  350 && value <= 900)
                {
                    salary = value;
                }
                else Console.WriteLine("Out of range!");
            } 
        }
        public void GetInfo()
        {
            Console.WriteLine($"\n\nAll valid inputs!\n\nYour username: {userName}\nYour salary: {salary}");
        }
    }
}
