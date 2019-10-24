using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace LabQues2
{
    class Program
    {

        
        static void Main(string[] args)
        {
            string con = "Data Source = VALLABHI31"+@"\SQLEXPRESS; Initial Catalog = nikita; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(con);
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Employee",sqlConnection);
            DataSet ds = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(ds,"employee");

            //QUERY1
            var query1 = from emp in ds.Tables["employee"].AsEnumerable() orderby emp.Field<DateTime>("DOJ") , emp.Field<string>("FirstName") descending select emp;
            foreach (var item in query1)
            {
                Console.WriteLine(item.Field<string>("FirstName") );
                Console.WriteLine(item.Field<DateTime>("DOJ").ToString());
            }

            //QUERY2
            var query2 = (from emp in ds.Tables["employee"].AsEnumerable() where emp.Field<string>("Title") == "Manager" select (int)(DateTime.Now.Year - emp.Field<DateTime>("DOB").Year)).Average();
            Console.WriteLine(query2.ToString());
            Console.ReadKey();
              
                                                                                                              // order elements by date      




        }
    }
}
