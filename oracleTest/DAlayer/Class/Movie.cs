using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oracleTest
{
    class Movie
    {
        private int id;
        private string name;
        private int duration;
        private int year;
        private string description;

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

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Duration
        {
            get
            {
                return duration;
            }

            set
            {
                duration = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public Movie(int temId, string temName, int temduration, int temYear, string temdescription)
        {
            this.Id = temId;
            this.Name = temName;
            this.Year = temYear;
            this.Description = temdescription;
            this.Duration = temduration;
        }
    }
}
