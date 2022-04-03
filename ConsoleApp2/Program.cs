using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Furkan";
            customer1.Surname = "Seymen";
            customer1.Tc = "15849768394";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Samet";
            customer2.Surname = "Çekin";
            customer2.Tc = "16349758416";

            CustomerManager manager = new CustomerManager();
            manager.AddCustomer(customer1);
            manager.AddCustomer(customer2);
            Console.WriteLine("" + "");
            manager.CustomersToList(customer1, customer2);         
            Console.WriteLine("" + "");
            manager.RemoveCustomer(customer2);






            Customer[] customers = new Customer[] {customer1,customer2 };

        }
    }
}
