using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oracleTest
{
    class Seat
    {
        private int id;
        private double price;
        private int rowId;
        public Seat(int temId, double temPrice, int temRow)
        {
            this.Id = temId;
            this.RowId = temRow;
            this.Price = temPrice;
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

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public int RowId
        {
            get
            {
                return rowId;
            }

            set
            {
                rowId = value;
            }
        }
    }
}
