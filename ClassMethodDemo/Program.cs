using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer0 = new Customer();
            customer0.Name = "Behzat";
            customer0.Surname = "Ç.";
            customer0.TC = 11111111111;
            Customer customer1 = new Customer();
            customer1.Name = "Hayalet";
            customer1.Surname = "H";
            customer1.TC = 11111111111;
            Customer customer2 = new Customer();
            customer2.Name = "Akbaba";
            customer2.Surname = "A";
            customer2.TC = 11111111111;

            CustomerManager customerManager = new CustomerManager();
            customerManager.Attach(customer0);
            customerManager.Attach(customer1);
            customerManager.Attach(customer2);
        }
    }
}
