using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new NeroCustomerManager();
            baseCustomerManager.Save(new Entities.Customer {
                DateOfBirth = new System.DateTime(1999,07,22) , 
                FirstName="Ceren", Id=90, LastName= "Keklik", 
                NationalityId="Turkey"});


        }
    }
}
