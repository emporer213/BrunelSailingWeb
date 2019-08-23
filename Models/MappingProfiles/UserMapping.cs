using AutoMapper;
using Brunel_Sailing_Web.Models.ModelDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brunel_Sailing_Web.Models.MappingProfiles
{
    public class UserMapping : Profile
    {
        public UserMapping()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<User, UserDetailsDTO>().ReverseMap();
        }
    }
}
