using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_2.Entities
{
    public class Manager : Employee
    {
        public string IdCode { get; set; }
        public override string ToString() => base.ToString() + $" IdCode: {IdCode}, (Manager)";
    }
}
