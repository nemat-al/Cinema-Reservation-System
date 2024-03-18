using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oracleTest
{
    class RowInHall
    {
        private int id;
        private int seatsNumber;
        private int hallId;

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

        public int SeatsNumber
        {
            get
            {
                return SeatsNumber1;
            }

            set
            {
                SeatsNumber1 = value;
            }
        }

        public int SeatsNumber1
        {
            get
            {
                return seatsNumber;
            }

            set
            {
                seatsNumber = value;
            }
        }

        public RowInHall(int temid, int temseatsNumber, int temhallId)
        {
            this.Id = temid;
            this.SeatsNumber = temseatsNumber;
            this.hallId = temhallId;
        }
    }
}
