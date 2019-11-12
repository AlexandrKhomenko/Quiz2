using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class User
    {
        private string firstName;
        private string lastName;
        private string phone;

        public User(string firstName, string lastName, string phone)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
        }

        public string FirstName {
            get {
                return firstName;
            }
            set {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }
    }
}
