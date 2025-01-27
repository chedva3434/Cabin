using AutoMapper;
using Clean.Core.Models;
using ManagementCabin.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementCabin.Core
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Cabin, CabinDto>().ReverseMap();
            CreateMap<Order,OrderDto>().ReverseMap();
            CreateMap<Castomer, CastomerDto>().ReverseMap();
        }
    }
}
