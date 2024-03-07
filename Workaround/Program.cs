
using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Person person1 = new Person();
            person1.FirstName = "Salih";
            person1.LastName = "Kartay";
            person1.DateOfBirthYear = 1998;
            person1.NationalIdentity = 123;

            Person person2 = new Person { FirstName = "Fatih" };

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

       
    }
}
