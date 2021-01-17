using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("\n Yeni Müşteri Eklendi : " + customer. Name + " " + customer.Surname);

        }
        public void Delete (Customer customer)
        {
            Console.WriteLine("\n Müşteri Silindi : " + customer.Name +" "+ customer.Surname);
        }


        public void List(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("\n Müşterinin Adi : " + customer.Name);
                Console.WriteLine("\n Müşterinin Soyadi : " + customer.Surname);
                Console.WriteLine("\n Müşteri Numarasi : " + customer.CustomerNumber);
                Console.WriteLine("\n Müşterinin Sifresi : " + customer.Password);
                Console.WriteLine("\n******************************************");
            }
        }
 

        
        } 
}
