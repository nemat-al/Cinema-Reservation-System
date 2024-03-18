using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oracleTest
{
   public class Ticket
    {
        private int id;
        private double price;
        private string state;
        private string wayReserved;
        private DateTime dateReserved;
        private DateTime dateCancelled;
        private DateTime datePayed;
        private int customer_id;
        private int movieShow_id;
        private int employee_Phone;
        private int employee_Reserve;
        private int employee_Cancel;
        private int employee_Pay;
        private int row_id;
        private int seat_id;


        public Ticket(int tempId,
         double tempPrice,
         string tempState,
         string tempWayReserved,
         DateTime tempDateReserved,
         DateTime tempDateCancelled,
         DateTime tempDatePayed,
         int tempCustomer_id,
         int tempMovieShow_id,
         int tempEmployee_Phone,
         int tempEmployee_Reserve,
         int tempEmployee_Cancel,
         int tempEmployee_Pay,int tempRow_id, int temp_seat)
        {
            this.Id = tempId;
            this.State = tempState;
            this.Price = tempPrice;
            this.WayReserved = tempWayReserved;
            this.DatePayed = tempDatePayed;
            this.DateReserved = tempDateReserved;
            this.DateCancelled = tempDateCancelled;
            this.Employee_Reserve = tempEmployee_Reserve;
            this.Employee_Phone = tempEmployee_Phone;
            this.Employee_Pay = tempEmployee_Pay;
            this.Employee_Cancel = tempEmployee_Cancel;
            this.MovieShow_id = tempMovieShow_id;
            this.Customer_id = tempCustomer_id;
            this.Row_id = tempRow_id;
            this.Seat_id = temp_seat;
        }
        public Ticket(int tempId, int tempEmployee_Cancel)
        {
            this.id = tempId;
            this.Employee_Cancel = tempEmployee_Cancel;
        }
        public Ticket(int tempId, int tempEmployee_Pay, int noThing=0)
        {
            this.id = tempId;
            this.Employee_Cancel = tempEmployee_Pay;
        }
        public Ticket(int tic_id)
        {
            this.Id = tic_id;
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

        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }

        public string WayReserved
        {
            get
            {
                return wayReserved;
            }

            set
            {
                wayReserved = value;
            }
        }

        public DateTime DateReserved
        {
            get
            {
                return dateReserved;
            }

            set
            {
                dateReserved = value;
            }
        }

        public DateTime DateCancelled
        {
            get
            {
                return dateCancelled;
            }

            set
            {
                dateCancelled = value;
            }
        }

        public DateTime DatePayed
        {
            get
            {
                return datePayed;
            }

            set
            {
                datePayed = value;
            }
        }

        public int Customer_id
        {
            get
            {
                return customer_id;
            }

            set
            {
                customer_id = value;
            }
        }

       

        public int MovieShow_id
        {
            get
            {
                return movieShow_id;
            }

            set
            {
                movieShow_id = value;
            }
        }

        public int Employee_Phone
        {
            get
            {
                return employee_Phone;
            }

            set
            {
                employee_Phone = value;
            }
        }

        public int Employee_Reserve
        {
            get
            {
                return employee_Reserve;
            }

            set
            {
                employee_Reserve = value;
            }
        }

        public int Employee_Cancel
        {
            get
            {
                return employee_Cancel;
            }

            set
            {
                employee_Cancel = value;
            }
        }

        public int Employee_Pay
        {
            get
            {
                return employee_Pay;
            }

            set
            {
                employee_Pay = value;
            }
        }

       

    

        public int Row_id
        {
            get
            {
                return row_id;
            }

            set
            {
                row_id = value;
            }
        }

        public int Seat_id
        {
            get
            {
                return seat_id;
            }

            set
            {
                seat_id = value;
            }
        }
    }
}
