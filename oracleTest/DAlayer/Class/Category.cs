using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oracleTest
{
    class Category
    {
        private int id;
        private string name;
        public Category(int temId=0, string temName="")
        {
            this.Id = temId;
            this.Name = temName;
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

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }
}
