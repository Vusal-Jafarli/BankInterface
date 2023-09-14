using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppInterface.Classes
{
    internal class Credit : IGuid
    {
        public Guid? Guid { get; set; }
        public Client? Client { get; set; }
        public float? Amount { get; set; }
        public float? Percent { get; set; }
        public int? Month { get; set; }

        public void Calculate_Percentage()
        {
            Console.WriteLine("Calculated Percentage.");
        }
        public void Payment(float payment)
        {
            if (Amount > payment) { Amount -= payment; }
            else { Console.WriteLine($"Maximum payment is {Amount}"); }
            Console.WriteLine("Paymented.");
        }

        public override string ToString()
        {
            string credit = Guid.ToString() + '\n' + Client.Name + " " + Client.Surname + '\n' + Amount
                + '\n' + Percent + '\n' + Month;
            return credit;
        }

    }
}
