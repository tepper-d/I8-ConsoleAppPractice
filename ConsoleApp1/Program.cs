using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPractice
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private string email;
    

        public Person()
        {
        }

        public Person(string firstName, string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }

        }

        public string LastName
        {
            get
            {
                return LastName;
            }

            set
            {
                LastName = value;
            }

        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }

        }

        public string GetDisplayText() => firstName + " " + lastName + ", " + email;

    }

}
