using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppInterface.Classes
{
    internal class Bank
    {
        //Properties
        public string? Name { get; set; }
        public float? Budget { get; set; }
        public float? Profit { get; set; }
        public CEO? CEO { get; set; }
        public List<Worker>? Worker { get; set; }
        public List<Manager>? Manager { get; set; }
        public List<Client>? Client { get; set; }


        //Methods
        public void ShowClientCredit(string name, string surname, Guid id)
        {
            if (name is null) { throw new InvalidDataException("Name is null."); }
            if (surname is null) { throw new InvalidDataException("Surname is null."); }

            if (Client is null) { Console.WriteLine("Hec bir Client yoxdur."); return; }
            for (int i = 0; i < Client.Count; i++)
            {
                if (Client[i].Name == name && Client[i].Surname == surname && Client[i].Guid == id)
                {
                    Console.WriteLine(Client[i]?.Credit?.Amount);
                    return;
                }
            }

        }
        public void Calculate_Profit()
        {
            Console.WriteLine("Profit Calculated.");
        }
        public void Pay_Credit(Client client, float money)
        {
            if (client?.Credit?.Amount < money) { Console.WriteLine("Money yanlis daxil edilib."); return; }
            client.Credit.Amount -= money;
            Console.WriteLine("The Payment was made succesfully");
        }

        public void Show_All_Credit()
        {
            for (int i = 0; i < Client?.Count; i++)
                Client[i]?.Credit?.ToString(); Console.WriteLine();

        }
    }
}
