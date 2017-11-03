using System;

namespace Properties
{
    public class Person1
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
}