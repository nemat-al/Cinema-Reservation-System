using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oracleTest
{
    class OfferOverShow
    {
        private int offer_id;
        private int show_id;
        private int leastPoints;

        public int Offer_id
        {
            get
            {
                return offer_id;
            }

            set
            {
                offer_id = value;
            }
        }

        public int Show_id
        {
            get
            {
                return show_id;
            }

            set
            {
                show_id = value;
            }
        }

        public int LeastPoints
        {
            get
            {
                return leastPoints;
            }

            set
            {
                leastPoints = value;
            }
        }

        public OfferOverShow(int temOffer_id, int temShow_id, int temLeastPoints)
        {
            this.LeastPoints = temLeastPoints;
            this.Offer_id = temOffer_id;
            this.Show_id = temShow_id;
        }

    }
}
