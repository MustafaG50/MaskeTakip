using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.FirstName = "MUSTAFA ";
            person.LastName = "GENÇ";
            person.DateOfBirthYear = 2003;
            person.NationalIdentity = 25652401296;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person);
        }

    }
}

