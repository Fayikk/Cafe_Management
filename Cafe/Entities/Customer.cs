using Cafe.Abstract;

namespace Cafe.Entities
{
    public class Customer:IEntity
    {
        //Burada Customer nesnemizi oluşturduk.
        //Sınıflar çıplak kalmamalı
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateOfBirth { get; set; }
        public long NationalityId { get; set; }
    }
}
