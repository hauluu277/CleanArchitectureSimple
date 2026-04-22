using Application.DTOs;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Mappings
{
    public class SpendingProfile:Profile
    {
        public SpendingProfile()
        {
            CreateMap<Spending, DTOs.SpendingDto>().ReverseMap();
            CreateMap<CreateSpendingDto, Spending>().ReverseMap();
        }
    }
}
