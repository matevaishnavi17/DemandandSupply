
using AutoMapper;
using domainmodel=SupplyDemandAPI.Models;
using SupplyDemandAPI.Models.DTO;

namespace SupplyDemandAPI.Profiles
{
    public class AutoMapperProfile : Profile
    {
         public  AutoMapperProfile()
         {
         //ReverseMap() is used in case if we want to map DTO to the Domain Model
            
            
          CreateMap<domainmodel.Login, UserLogin>()
          .ReverseMap();
         }
        
    }
}