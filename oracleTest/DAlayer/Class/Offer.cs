using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oracleTest
{
    class Offer
    {
        private int id;
        private double percentage;
        public Offer(int temId, double temPercentage)
        {
            this.Id = temId;
            this.Percentage = temPercentage;
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

        public double Percentage
        {
            get
            {
                return percentage;
            }

            set
            {
                percentage = value;
            }
        }
    }
}
