using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_2.Entities
{
    public class BuisnessPartner : EntityBase
    {
        public BuisnessPartner()
        {

        }
        public BuisnessPartner(string name)
        {

        }
        public string? Name { get; set; }

        public override string ToString() => $"Id: {Id}, Name: {Name}";


    }
}
