using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingCodeFirst
{

    /* Before Running the code 
     * Please Ensure that Your Server Name in Connection String is correct */


    class Program
    {
        static void Main(string[] args)
        {
            ProductContext context = new ProductContext();
            Product product = new Product();

            Product p1 = new Product
            {
                productId = 101,
                productName = "Note 7 Pro",
                pCategory = "Mobile",
                pPrice = 13999
            };
            Product p2 = new Product
            {
                productId = 201,
                productName = "Lost Heart",
                pCategory = "Book",
                pPrice = 699
            };
            Product p3 = new Product
            {
                productId = 301,
                productName = "Shining Shirt",
                pCategory = "Garments",
                pPrice = 1199
            };
            Product p4 = new Product
            {
                productId = 102,
                productName = "Samsung S10+",
                pCategory = "Mobile",
                pPrice = 79999
            };
            Product p5 = new Product
            {
                productId = 202,
                productName = "Doctor and the Starnger",
                pCategory = "Book",
                pPrice = 479
            };
            context.Products.Add(p1);
            context.Products.Add(p2);
            context.Products.Add(p3);
            context.Products.Add(p4);
            context.Products.Add(p5);
            context.SaveChanges();


            start:
            Console.Write("Do you want to add additional Product: Case sesitive (Yes/No) ");
            string choice = Console.ReadLine();
            if(choice =="Yes")
            {
                Console.WriteLine("Enter data to be added in database:");
                Console.Write("Product Id:");
                product.productId = int.Parse(Console.ReadLine());
                Console.Write("Product Name:");
                product.productName = Console.ReadLine();

                Console.Write("Product Category:");
                product.pCategory = Console.ReadLine();
                Console.Write("Product Price:");
                product.pPrice = Convert.ToDecimal(Console.ReadLine());


                context.Products.Add(product);
                context.SaveChanges();
                Console.WriteLine("Details Added Successfully");
                goto start;
            }
            
        }
    }
}
