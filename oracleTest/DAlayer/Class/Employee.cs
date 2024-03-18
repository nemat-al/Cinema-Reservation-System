using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oracleTest
{
    public class Employee
    {
        private int id;
        private string firstName;
        private string lastName;
        private string employeeRole;
        private string address;
        private string phoneNumber;
        private string email;
        private string username;
        private string password;

        public Employee(int id,
         string tempFirstName="",
         string tempLastName="",
         string tempEmployeeRole="",
         string tempAddress="",
         string tempPhoneNumber="",
         string tempEmail="",string uname="",string pass="")
        {
            this.Id = id;
            this.FirstName = tempFirstName;
            this.LastName = tempLastName;
            this.EmployeeRole = tempEmployeeRole;
            this.Address = tempAddress;
            this.PhoneNumber = tempPhoneNumber;
            this.Emai = tempEmail;
            this.Username = uname;
            this.Password = pass;
        }
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
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
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string EmployeeRole
        {
            get
            {
                return employeeRole;
            }

            set
            {
                employeeRole = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        public string Emai
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

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
    }
}