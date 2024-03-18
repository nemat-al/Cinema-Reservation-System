using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess;
namespace oracleTest
{
   public class Customer
    {
        private int id;
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string email;
        private int points;

        public Customer( int tempId , string tempFirstName, string tempLastName, string tempPhonenumber, string tempEmail, int tempPoints)
        {
            this.Id = tempId;
            this.FirstName = tempFirstName;
            this.LastName = tempLastName;
            this.Email = tempEmail;
            this.PhoneNumber = tempPhonenumber;
            this.Points = tempPoints;
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



        public int Points
        {
            get
            {
                return points;
            }

            set
            {
                points = value;
            }
        }
    }
}
