using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppInterface.Classes
{
    internal class Client : IGuid
    {
        public Guid? Guid { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int? Age { get; set; }
        public string? Live_Address { get; set; }
        public string? Work_Address { get; set; }
        public float? salary { get; set; }
        public Credit? Credit { get; set; }


    }
}
