using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oracleTest
{
    class Customer_Category
    {
        private int customerId;
        private int categoryId;

        public int CustomerId
        {
            get
            {
                return customerId;
            }

            set
            {
                customerId = value;
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

        public Customer_Category(int temCustomer, int temCategory)
        {
            this.CategoryId = temCustomer;
            this.CategoryId = temCategory;
        }
    }
}
