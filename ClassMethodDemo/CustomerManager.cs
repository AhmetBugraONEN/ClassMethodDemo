using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Attach(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + ":" + "Successful! Customer Added.");
            Console.WriteLine(customer.TC + ":");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name + customer.Surname + ":" + "Succesful! Customer Deleted.");

        }

    }
}
