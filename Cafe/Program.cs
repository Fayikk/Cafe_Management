using Cafe.Abstract;
using Cafe.Concrete;
using Cafe.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1998, 8, 9),
            FirstName = "Fayik", LastName = "Veznedaroglu", NationalityId = "12345678910" });
            Console.ReadLine();
        }
    }
}
