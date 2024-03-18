using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oracleTest
{
    class Movie_MovieWorker
    {
        private int movie_id;
        private int movieWorker_id;

        public int Movie_id
        {
            get
            {
                return movie_id;
            }

            set
            {
                movie_id = value;
            }
        }

        public int MovieWorker_id
        {
            get
            {
                return movieWorker_id;
            }

            set
            {
                movieWorker_id = value;
            }
        }

        public Movie_MovieWorker(int temMovie, int temWorker)
        {
            this.MovieWorker_id = temWorker;
            this.Movie_id = temMovie;
        }
    }
}
