using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppInterface.Classes
{
    internal class CEO : IInfo, IOrganize,IGuid
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int? Age { get; set; }
        public string? Position { get; set; }
        public float? Salary { get; set; }
        public Guid? Guid { get ; set; }

        public void Organize()
        {
            Console.WriteLine("Organized by CEO.");
        }

        public void Control()
        {
            Console.WriteLine("Controled by CEO.");
        }
        public void MakeMeeting()
        {
            Console.WriteLine("Maked meeting by CEO.");
        }

        public void DecreasePercentage()
        {
            Console.WriteLine("Decreased Percentage by CEO.");
        }



    }
}
