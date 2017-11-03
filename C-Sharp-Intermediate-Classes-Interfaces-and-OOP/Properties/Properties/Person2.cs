using System;

namespace Properties
{
    public class Person2
    {
        private DateTime _birthdate;

        public DateTime Birthdate
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }
    }
}