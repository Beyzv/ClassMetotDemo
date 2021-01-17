using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           Customer customer1 = new Customer();
            customer1.Name = "Ela";
            customer1.Surname = "Kibritçioğlu";
            customer1.CustomerNumber = 17012021;
            customer1.Password = 123456;

            Customer customer2 = new Customer();
            customer2.Name = "Erhan";
            customer2.Surname = "Barutçu";
            customer2.CustomerNumber = 18012021;
            customer2.Password = 111111;

            Customer customer3 = new Customer();
            customer3.Name = "Melek";
            customer3.Surname = "Ermiş";
            customer3.CustomerNumber = 19012021;
            customer3.Password =000000;

            Customer customer4 = new Customer();
            customer4.Name = "Haluk";
            customer4.Surname = "Avşar";
            customer4.CustomerNumber = 15012021;
            customer4.Password = 987456;

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer4);
            customerManager.Delete(customer2);
            customerManager.List(customers);

         

        }
    }
}
