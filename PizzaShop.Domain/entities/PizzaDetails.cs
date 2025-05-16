using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Domain.entities
{
    public class PizzaDetails
    {
        public List<string>? Skladniki { get; set; } = new List<string>();
        public List<string>? Alergeny { get; set; } = new List<string>();
        public string opis { get; set; }
    }
}
