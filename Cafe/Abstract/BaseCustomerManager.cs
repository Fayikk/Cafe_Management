using Cafe.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        
        //Aşağıdaki Virtual ifadesiyle ben bunu ezebilirm anlamına gelmektedir.
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Save to db : "+ customer.FirstName);
        }
    }
}
