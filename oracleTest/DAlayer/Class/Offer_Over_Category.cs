using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oracleTest
{
    class Offer_Over_Category
    {
        private int offerId;
        private int categoryId;
        private DateTime startDate;
        private DateTime endDate;

        public int OfferId
        {
            get
            {
                return offerId;
            }

            set
            {
                offerId = value;
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

        public DateTime StartDate
        {
            get
            {
                return startDate;
            }

            set
            {
                startDate = value;
            }
        }

        public DateTime EndDate
        {
            get
            {
                return endDate;
            }

            set
            {
                endDate = value;
            }
        }

        public Offer_Over_Category(int temOffer, int temCategory, DateTime start, DateTime end)
        {
            this.OfferId = temOffer;
            this.CategoryId = temCategory;
            this.EndDate = end;
            this.StartDate = start;
        }
    }
}
