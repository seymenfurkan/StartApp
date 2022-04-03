using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Yeni Müşteri : "
                    + customer.Id + "-------" +
                    customer.Name + "-------" +
                    customer.Surname + "-------" +
                    customer.Tc );
           

            Console.WriteLine("Müşteri Başarılı Bir Şekilde Eklendi!");
        }
        public void RemoveCustomer(Customer customer)
        {
            Console.WriteLine("Müşteri Siliniyor : "
                    + customer.Id + "-------" +
                    customer.Name + "-------" +
                    customer.Surname + "-------" +
                    customer.Tc);


            Console.WriteLine("Müşteri Başarılı Bir Şekilde Silindi!");
        }
        public void CustomersToList(params Customer[] customer)
        {
            
            foreach (Customer customers in customer)
            {
                Console.WriteLine("ID: "+customers.Id+"-"+" "+
                      "İsim :" + customers.Name+"     "+
                      "Soyisim :" + customers.Surname+"      "+
                      "TC No :" + customers.Tc+"       ");
            }
            Console.WriteLine("Müşteri Listesi");

        }

    }
}
