using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Domain.entities
{
    public class Pizza
    {
        public required int Id { get; set; }
        public string Title { get; set; } = default!;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public PizzaDetails Details { get; set; } = new PizzaDetails()!;
        public string EncodedTitle { get; private set; } = default!;
        public void EncodeTitle() { /* implementacja */ }
    }
}
