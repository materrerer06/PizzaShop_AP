using AutoMapper;
using PizzaShop.Application.Pizza;
using PizzaShop.Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Application.Mappings
{
    public class PizzaMappingProfile : Profile
    {
        public PizzaMappingProfile()
        {
            CreateMap<PizzaDTO, Domain.entities.Pizza>().ForMember(dest => dest.Details, opt => opt.MapFrom(src => MapPizzaDetails(src)));
        }

        private static PizzaDetails MapPizzaDetails(PizzaDTO src)
        {
            return new PizzaDetails
            {
                Skladniki = src.Skladniki != null ? src.Skladniki.Select(s => s.Trim()).ToList() : null,
                opis = src.Opis // Poprawiono nazwę właściwości na "Opis"
            };
        }
    }
}
