using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oracleTest
{
    class Movie_Category
    {
        private int movieId;
        private int categoryId;

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

        public int CategoryId
        {
            get
            {
                return categoryId;
            }

            set
            {
                categoryId = value;
            }
        }

        public Movie_Category(int temMovie, int temCategory)
        {
            this.MovieId = temMovie;
            this.CategoryId = temCategory;
        }
    }
}
