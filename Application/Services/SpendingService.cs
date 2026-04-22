using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class SpendingService
    {
        private readonly ISpendingRepository _spendingRepository;
        private readonly IMapper _mapper;

        public SpendingService(ISpendingRepository spendingRepository, IMapper mapper)
        {
            _spendingRepository = spendingRepository;
            _mapper = mapper;
        }
        public async Task<long> Create(CreateSpendingDto spendingDto)
        {
            var spending = new Spending
                      (
                           spendingDto.Name,
                           spendingDto.Amount,
                           spendingDto.Date,
                           spendingDto.Description
                      );
            await _spendingRepository.AddSpendingAsync(spending);
            return spending.Id;
        }

        public async Task<List<SpendingDto>> GetAll()
        {
            var spendings = await _spendingRepository.GetAllSpendingAsync();
            var data=_mapper.Map<List<SpendingDto>>(spendings);
           return data;
        }

        public Task<Spending> GetById(long id)
        {
            return _spendingRepository.GetSpendingByIdAsync(id);
        }
    }
}
