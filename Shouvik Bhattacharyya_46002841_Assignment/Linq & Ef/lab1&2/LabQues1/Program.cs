using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabQues1
{
    class Program
    {
        static void Main(string[] args)
        {
            emplist obj = new emplist();
            Console.WriteLine("#####LINQ QUERY PRACTICES#####");

            var query1 = from employee in obj.Employees select employee;
            foreach(var item in query1)
            {
                Console.WriteLine(item.EmployeeID);
                Console.WriteLine(item.FirstName);
                Console.WriteLine(item.LastName);
                Console.WriteLine(item.Title);
                Console.WriteLine(item.DOB);
                Console.WriteLine(item.DOJ);
                Console.WriteLine(item.City);

            }
            Console.WriteLine("2ND QUERY");
            var query2 = from employee in obj.Employees where employee.City != "Mumbai" select employee;
            foreach (var item in query2)
            {
                Console.WriteLine(item.EmployeeID);
                Console.WriteLine(item.FirstName);
                Console.WriteLine(item.LastName);
                Console.WriteLine(item.Title);
                Console.WriteLine(item.DOB);
                Console.WriteLine(item.DOJ);
                Console.WriteLine(item.City);

            }
            var query3 = from employee in obj.Employees where employee.Title == "Manager" select employee;
            foreach (var item in query3)
            {
                Console.WriteLine(item.EmployeeID);
                Console.WriteLine(item.FirstName);
                Console.WriteLine(item.LastName);
                Console.WriteLine(item.Title);
                Console.WriteLine(item.DOB);
                Console.WriteLine(item.DOJ);
                Console.WriteLine(item.City);

            }
            var query4 = from employee in obj.Employees where employee.LastName.StartsWith("S") select employee;
            foreach (var item in query4)
            {
                Console.WriteLine(item.EmployeeID);
                Console.WriteLine(item.FirstName);
                Console.WriteLine(item.LastName);
                Console.WriteLine(item.Title);
                Console.WriteLine(item.DOB);
                Console.WriteLine(item.DOJ);
                Console.WriteLine(item.City);

            }
            var query5 = from employee in obj.Employees where Convert.ToDateTime(employee.DOJ) < Convert.ToDateTime("01/01/2015") select employee;
            foreach (var item in query5)
            {
                Console.WriteLine(item.EmployeeID);
                Console.WriteLine(item.FirstName);
                Console.WriteLine(item.LastName);
                Console.WriteLine(item.Title);
                Console.WriteLine(item.DOB);
                Console.WriteLine(item.DOJ);
                Console.WriteLine(item.City);

            }
            var query6 = (from employee in obj.Employees select employee).Count();
            foreach (var item in query5)
            {
                Console.WriteLine(item.EmployeeID);
                Console.WriteLine(item.FirstName);
                Console.WriteLine(item.LastName);
                Console.WriteLine(item.Title);
                Console.WriteLine(item.DOB);
                Console.WriteLine(item.DOJ);
                Console.WriteLine(item.City);

            }
            
            
            var result = (from employee in obj.Employees select employee).OrderByDescending(x =>x.EmployeeID ).FirstOrDefault();
            Console.WriteLine(result.EmployeeID);
            var query7 = from employee in obj.Employees orderby (Convert.ToDateTime(employee.DOB)).Year  select employee;
            foreach (var item in query7)
            {
                
                Console.WriteLine(item.Title);
                Console.WriteLine(item.DOB);
                

            }
            Console.ReadKey();

        }
    }
}
 