using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oracleTest
{
    class hall
    {
        private int id;
        private string name;

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
        public hall(int temId, string temName)
        {
            this.Id = temId;
            this.Name = temName;
        }
    }
}
