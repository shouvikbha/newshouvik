using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabQues1
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string DOB { get; set; }
        public string DOJ { get; set; }
        public string City { get; set; }
    }  

       
    public class emplist
        {
            List<Employee> employees = null;
            public List<Employee> Employees
            {
                get
                {
                    if (employees == null)
                    {
                        employees = new List<Employee>();
                        employees.Add(new Employee()
                        {
                            EmployeeID = 1001,
                            FirstName = "Malcolm",
                            LastName = "Daruwalla"
                        ,
                            Title = "Manager",
                            DOB = "16/11/1984",
                            DOJ = "8/6/2011",
                            City = "Mumbai"
                        });
                        employees.Add(new Employee()
                        {
                            EmployeeID = 1002,
                            FirstName = "Asdin",
                            LastName = "Dhaila"
                            ,
                            Title = "AsstManager",
                            DOB = "20/08/1984",
                            DOJ = "07/07/2012",
                            City = "Mumbai"
                        });
                        employees.Add(new Employee()
                        {
                            EmployeeID = 1003,
                            FirstName = "Madhavi",
                            LastName = "Oza"
                        ,
                            Title = "Consultant",
                            DOB = "14/11/1987",
                            DOJ = "12/4/2015",
                            City = "Pune"
                        });
                        employees.Add(new Employee()
                        {
                            EmployeeID = 1004,
                            FirstName = "Saba",
                            LastName = "Sheikh"
                        ,
                            Title = "SE",
                            DOB = "3/6/1990",
                            DOJ = "2/2/2016",
                            City = "Pune"
                        });
                        employees.Add(new Employee()
                        {
                            EmployeeID = 1005,
                            FirstName = "Nazia",
                            LastName = "Sheikh"
                        ,
                            Title = "SE",
                            DOB = "8/3/1991",
                            DOJ = "2/2/2016",
                            City = "Mumbai"
                        });
                        employees.Add(new Employee()
                        {
                            EmployeeID = 1006,
                            FirstName = "Amit",
                            LastName = "Pathak"
                        ,
                            Title = "Consultant",
                            DOB = "7/11/1989",
                            DOJ = "8/8/2014",
                            City = "Chennai"
                        });
                        employees.Add(new Employee()
                        {
                            EmployeeID = 1007,
                            FirstName = "Vijay",
                            LastName = "Natrajan"
                        ,
                            Title = "Consultatnt",
                            DOB = "02/12/1989",
                            DOJ = "01/6/2015",
                            City = "Mumbai"
                        });
                        employees.Add(new Employee()
                        {
                            EmployeeID = 1008,
                            FirstName = "Rahul",
                            LastName = "Dubey"
                        ,
                            Title = "Associate",
                            DOB = "11/11/1993",
                            DOJ = "06/11/2014",
                            City = "Chennai"
                        });
                        employees.Add(new Employee()
                        {
                            EmployeeID = 1009,
                            FirstName = "Suresh",
                            LastName = "Mistry"
                        ,
                            Title = "Associate",
                            DOB = "12/08/1992",
                            DOJ = "3/12/2014",
                            City = "Chennai"
                        });
                        employees.Add(new Employee()
                        {
                            EmployeeID = 1010,
                            FirstName = "Sumit",
                            LastName = "Shah"
                        ,
                            Title = "Associate",
                            DOB = "12/04/1991",
                            DOJ = "2/1/2016",
                            City = "Pune"
                        });
                    }
                    return employees;
                }
                set => employees = value;
            }
        }

    }


