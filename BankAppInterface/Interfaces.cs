using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppInterface
{
    interface IInfo
    {
        string? Name { get; set; }
        string? Surname { get; set; }
        int? Age { get; set; }
        string? Position { get; set; }
        float? Salary { get; set; }
    }

    interface IOrganize
    {
        void Organize();
    }
    interface IGuid
    {
        Guid? Guid { get; set; }
    }



}

//ByVC