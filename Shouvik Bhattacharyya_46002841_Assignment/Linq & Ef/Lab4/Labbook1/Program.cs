using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Labbook1
{
    class Program
    {
        static void Main(string[] args)
        {
            EMPEntities db = new EMPEntities();

            Console.WriteLine("Display detail of all the employee");

            var details = from data in db.Employees
                          select data;

            Console.WriteLine("EmployeeID\tFirstname\tLastname\tTitle\tDOB\tDOJ\tCity");
            foreach (var item in details)
            {
                Console.WriteLine(item.EmployeeID + "\t" + item.FirstName + "\t" + item.LastName + "\t" + item.Title + "\t"+ item.DOB + "\t" + item.DOJ + "\t" + item.City);
            }

            Console.WriteLine();

            Console.WriteLine("Display details of all the employee whose location is not Mumbai");

            details = from data in db.Employees
                      where !data.City.Equals("Mumbai")
                      select data;

            Console.WriteLine("EmployeeID\tFirstname\tLastname\tTitle\tDOB\tDOJ\tCity");
            foreach (var item in details)
            {
                Console.WriteLine(item.EmployeeID + "\t" + item.FirstName + "\t" + item.LastName + "\t" + item.Title + "\t" + item.DOB + "\t" + item.DOJ + "\t" + item.City);
            }

            Console.WriteLine();

            Console.WriteLine("Display details of all the employee whose title is AsstManager");

            details = from data in db.Employees
                      where data.Title.Equals("AsstManager")
                      select data;

            Console.WriteLine("EmployeeID\tFirstname\tLastname\tTitle\tDOB\tDOJ\tCity");
            foreach (var item in details)
            {
                Console.WriteLine(item.EmployeeID + "\t" + item.FirstName + "\t" + item.LastName + "\t" + item.Title + "\t" + item.DOB + "\t" + item.DOJ + "\t" + item.City);
            }

            Console.WriteLine();

            Console.WriteLine("Display details of all the employee whose Last Name start with S");

            details = from data in db.Employees
                      where data.LastName.StartsWith("S")
                      select data;

            Console.WriteLine("EmployeeID\tFirstname\tLastname\tTitle\tDOB\tDOJ\tCity");
            foreach (var item in details)
            {
                Console.WriteLine(item.EmployeeID + "\t" + item.FirstName + "\t" + item.LastName + "\t" + item.Title + "\t" + item.DOB + "\t" + item.DOJ + "\t" + item.City);
            }

            Console.WriteLine();

            Console.WriteLine("Display a list of all the employee who have joined before 1/1/2015");

            DateTime date = Convert.ToDateTime("1/1/2015");

            details = from data in db.Employees
                      where data.DOB.Value < date
                      select data;

            Console.WriteLine("EmployeeID\tFirstname\tLastname\tTitle\tDOB\tDOJ\tCity");
            foreach (var item in details)
            {
                Console.WriteLine(item.EmployeeID + "\t" + item.FirstName + "\t" + item.LastName + "\t" + item.Title + "\t" + item.DOB + "\t" + item.DOJ + "\t" + item.City);
            }

            Console.WriteLine();

            Console.WriteLine("Display a list of all the employee whose date of birth is after 1/1/1990");

            date = Convert.ToDateTime("1/1/1990");

            details = from data in db.Employees
                      where data.DOB.Value < date
                      select data;

            Console.WriteLine("EmployeeID\tFirstname\tLastname\tTitle\tDOB\tDOJ\tCity");
            foreach (var item in details)
            {
                Console.WriteLine(item.EmployeeID + "\t" + item.FirstName + "\t" + item.LastName + "\t" + item.Title + "\t" + item.DOB + "\t" + item.DOJ + "\t" + item.City);
            }

            Console.WriteLine();

            Console.WriteLine("Display a list of all the employee whose designation is Consultant and Associate");

            details = from data in db.Employees
                      where data.Title.Equals("Consultant") || data.Title.Equals("Associate")
                      select data;

            Console.WriteLine("EmployeeID\tFirstname\tLastname\tTitle\tDOB\tDOJ\tCity");
            foreach (var item in details)
            {
                Console.WriteLine(item.EmployeeID + "\t" + item.FirstName + "\t" + item.LastName + "\t" + item.Title + "\t" + item.DOB + "\t" + item.DOJ + "\t" + item.City);
            }

            Console.WriteLine();

            Console.WriteLine("Display total number of employees");

            int count = db.Employees.Count();

            Console.WriteLine($"Count : {count}");

            Console.WriteLine();

            Console.WriteLine("Display total number of employees");

            count = db.Employees.Where(p => p.City.Equals("Chennai")).Count();

            Console.WriteLine($"Count : {count}");

            Console.WriteLine();

            Console.WriteLine("Display highest employee id from the list");

            int maxID = db.Employees.Select(p => p.EmployeeID).Max();

            Console.WriteLine($"Max Employee ID : {maxID}");

            Console.WriteLine();

            Console.WriteLine("Display total number of employee who have joined after 1/1/2015");

            date = Convert.ToDateTime("1/1/2015");

            count = db.Employees.Select(p => p).Where(p => p.DOJ > date).Count();

            Console.WriteLine($"Count : {count}");

            Console.WriteLine();

            Console.WriteLine("Display total number of employee whose designation is not “Associate”");

            count = db.Employees.Select(p => p).Where(p => !p.Title.Equals("Associate")).Count();

            Console.WriteLine($"Count : {count}");

            Console.WriteLine("");

            Console.WriteLine("Display total number of employee based on City");

            var group = db.Employees.GroupBy(p => p.City).Select(g => new { city = g.Key, count = g.Count() });

            Console.WriteLine("City\tCount");

            foreach (var item in group)
            {
                Console.WriteLine(item.city + "\t" + item.count);
            }

            Console.WriteLine("");

            Console.WriteLine("Display total number of employee based on city and title");

            var det = db.Employees.GroupBy(g => new { g.City, g.Title }).Select(p => new { City = p.Key.City, Title = p.Key.Title, Count = p.Count()}); ;

            Console.WriteLine("City\tTitle\t\tCount");

            foreach (var item in det)
            {
                Console.WriteLine(item.City + "\t" + item.Title + "\t\t" +  item.Count);
            }

            Console.WriteLine("");

            Console.WriteLine("Display total number of employee who is youngest in the list");

            var maxDob = db.Employees.Max(p => p.DOB);

            count = db.Employees.Count(p => p.DOB==maxDob);

            Console.WriteLine($"Count : {count}");

            Console.ReadKey();

        }
    }
}
