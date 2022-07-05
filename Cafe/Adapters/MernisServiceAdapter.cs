using Cafe.Abstract;
using Cafe.Entities;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Adapters
{//Adapter Design Pattern kullanıyoruz
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(
                customer.NationalityId, customer.FirstName, customer.LastName, customer.DateOfBirth.Year);
        }
    }
}
