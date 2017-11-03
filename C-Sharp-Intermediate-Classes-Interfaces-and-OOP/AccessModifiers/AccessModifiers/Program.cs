using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        public class Person
        {
            private DateTime _birthdate;

            public void SetBirthdate(DateTime birthdate)
            {
                _birthdate = birthdate;
         
            }

            public DateTime GetBirthdate()
            {
                return _birthdate;
            }

        }
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1999, 1 ,1));
            Console.WriteLine(person.GetBirthdate());
        }
    }
}
