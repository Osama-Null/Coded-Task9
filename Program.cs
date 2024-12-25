using ConsoleT9.Models;

Account account = new Account();

string usrName;
float usrSalary;

Console.Write("Enter username: ");
account.UserName = Console.ReadLine();

Console.Write("Enter salary: ");
account.Salary = Convert.ToInt32(Console.ReadLine());

account.GetInfo();

