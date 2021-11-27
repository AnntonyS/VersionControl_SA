using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMaintenance_SA.Entities
{
    class User
    {
        public Guid ID { get; set; } = Guid.NewGuid();

        public string FirstName { get; set; }

        public string LastName { get; set; }

        //private string _fullname;

        public string Fullname 
        {
            get { return LastName + " " + FirstName; }
        }
    }
}
