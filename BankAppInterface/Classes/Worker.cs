using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppInterface.Classes
{
    internal class Worker : IInfo, IGuid
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int? Age { get; set; }
        public string? Position { get; set; }
        public float? Salary { get; set; }
        public Guid? Guid { get; set; }
        public DateTime? Start_time { get; set; }
        public DateTime? End_time { get; set; }
        public List<Operation>? Operations { get; set; }

        public void AddOperation(Operation new_operation)
        {
            if (Operations is null) { Operations = new List<Operation>(); }
            Operations.Add(new_operation);
        }









    }
}
