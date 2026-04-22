using Application.DTOs;
using AutoMapper;
using WebApi.Model;

namespace WebApi.Common.Mappings
{
    public class SpendingApiProfile:Profile
    {
        public SpendingApiProfile()
        {
            CreateMap<CreateSpendingRequest, CreateSpendingDto>().ReverseMap();
        }
    }
}
