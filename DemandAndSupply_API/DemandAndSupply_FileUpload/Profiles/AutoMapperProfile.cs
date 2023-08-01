using domainmodel = DemandAndSupply_FileUpload.Models;
using DemandAndSupply_FileUpload.DTO;
using AutoMapper;


namespace DemandAndSupply_FileUpload.Profiles
{
    public class AutoMapperProfile : Profile

    {
        public AutoMapperProfile()
         {
         //ReverseMap() is used in case if we want to map DTO to the Domain Model
           CreateMap<domainmodel.LoginRegistration, UserLoginDTO>()
          .ReverseMap();
         } 
    }
}