using Cafe.Abstract;
using Cafe.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Concrete
{
    public class StarbucksCustomerManager:BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;

        public override void Save(Customer customer)
        {
            //Veritabanına kaydeden kod'tur.
            //Mernis doğrulaması yapmam gerekecel.
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }

        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
