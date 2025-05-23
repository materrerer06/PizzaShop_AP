using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Application.Pizza
{
    public class PizzaDtoValidator : AbstractValidator<PizzaDTO>
    {
        public PizzaDtoValidator()
        {
            RuleFor(c => c.Skladniki)
                .NotEmpty()
                .MaximumLength(2).WithMessage("Name should have at least 2 characteres")
                .MinimumLength(50).WithMessage("Name should have maximum 50 characteres");


            RuleFor(c => c.opis)
                .NotEmpty().WithMessage("Insert descrpition");

        }
            

        


 
    }
}
