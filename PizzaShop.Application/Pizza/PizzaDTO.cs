using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PizzaShop.Application.Pizza
{
    public class PizzaDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tytuł jest wymagany")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Tytuł musi mieć od 2 do 50 znaków")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Opis jest wymagany")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Cena jest wymagana")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Cena musi być większa od zera")]
        public decimal Price { get; set; }

        public List<string>? Skladniki { get; set; }
        public string? Opis { get; set; }
    }
}
