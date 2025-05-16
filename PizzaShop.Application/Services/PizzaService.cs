using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata;
using PizzaShop.Application.Pizza;
using PizzaShop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Application.Services
{
    public class PizzaService : IPizzaService
    {
        private readonly IPizzaRepository _pizzaRepository;
        private readonly IMapper _mapper;

        public PizzaService(IPizzaRepository pizzaRepository, IMapper mapper)
        {
            _pizzaRepository = pizzaRepository;
            _mapper = mapper;
        }
        public async Task Create(PizzaDTO pizzaDto)
        {
            var pizza = _mapper.Map<Domain.entities.Pizza>(pizzaDto);
            pizza.EncodeTitle();
            await _pizzaRepository.Create(pizza);
        }
    }
}
