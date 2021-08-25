using AutoMapper;
using MobileRepairMT.DataTransferObjects;
using MobileRepairMT.Models;

namespace MobileRepairMT.Managers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserForRegistrationDto, User>();
        }
    }
}
