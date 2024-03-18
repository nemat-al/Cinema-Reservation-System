using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oracleTest
{
    class MovieWorker
    {
        private int id;
        private string firstName;
        private string lastName;
        private string movieRole;

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

        public string MovieRole
        {
            get
            {
                return movieRole;
            }

            set
            {
                movieRole = value;
            }
        }

        public MovieWorker(int tempId, string temFname, string temLname, string temRole)
        {
            this.Id = tempId;
            this.FirstName = temFname;
            this.LastName = temLname;
            this.MovieRole = temRole;
        }
    }
}
