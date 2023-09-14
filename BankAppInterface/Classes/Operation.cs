using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppInterface.Classes
{
    internal class Operation : IGuid
    {
        public Guid? Guid { get; set; }
        public string? Process_Name { get; set; }
        public DateTime? Time { get; }

        public override string ToString()
        {
            string operation;
            return operation = Guid.ToString() + '\n' + Process_Name + '\n' + Time.ToString();
        }

    }
}
