using System;
using System.Collections.Generic;
using System.Text;

namespace GameProductManager
{
    class CustomerManager
    {
        public void Add(Customer customers)
        {
            Console.WriteLine(customers.FirstName+ " Eklendi");
           
        }
        public void CustomerList(Customer[] customers)
        {
            foreach (var item in customers)
            {
                Console.WriteLine(" {0}  {1}  {2} ",item.TcNo,item.FirstName,item.LastName);
            }
        }
        public void Update(Customer customers)
        {
            Console.WriteLine(customers.FirstName+" Kullanıcısı Güncellendi");
        }
        public void Delete(Customer customers)
        {
            Console.WriteLine(customers.FirstName+" Kullanıcısı Silindi");
        }
    }
}
