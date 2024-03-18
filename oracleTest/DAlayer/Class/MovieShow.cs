using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oracleTest
{
    class MovieShow
    {
        private int id;
        private DateTime date;
        private TimeSpan time;
        private int points;
        
        private double seatsAddedPrice;
        private int movieId;
        private int hallId;
        private int avilableSeats;
        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public TimeSpan Time
        {
            get
            {
                return time;
            }

            set
            {
                time = value;
            }
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

        public int AvilableSeats
        {
            get
            {
                return avilableSeats;
            }

            set
            {
                avilableSeats = value;
            }
        }

        public double SeatsAddedPrice
        {
            get
            {
                return seatsAddedPrice;
            }

            set
            {
                seatsAddedPrice = value;
            }
        }

        public int MovieId
        {
            get
            {
                return movieId;
            }

            set
            {
                movieId = value;
            }
        }

        public int HallId
        {
            get
            {
                return hallId;
            }

            set
            {
                hallId = value;
            }
        }

        public MovieShow( DateTime temDate, TimeSpan temTime, int temPoints, double temSeatsAddedPrice, int temMovieId, int temHallId, int temId=0, int temAvilableSeats=0)
        {
            this.Date = temDate;
            this.Id = temId;
            this.HallId = temHallId;
            this.MovieId = temMovieId;
            this.Points = temPoints;
            this.Time = temTime;
            this.SeatsAddedPrice = temSeatsAddedPrice;
            this.AvilableSeats = temAvilableSeats;

        }
        public MovieShow(int temId ,DateTime temDate, TimeSpan temTime, int temPoints, double temSeatsAddedPrice)
        {
            this.Date = temDate;
            this.Id = temId;
            this.Points = temPoints;
            this.Time = temTime;
            this.SeatsAddedPrice = temSeatsAddedPrice;

        }
    }
}
