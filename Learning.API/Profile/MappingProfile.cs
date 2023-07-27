
using Learning.Entities.Models;
using Learning.Shared.DataTransferObjects;

namespace Learning.API.Profile;

public class MappingProfile : AutoMapper.Profile
{
    public MappingProfile()
    {
           CreateMap<Company, CompanyDto>()
           .ForMember(c => c.FullAddress,
           opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));

        CreateMap<Employee, EmployeeDto>();

        CreateMap<CompanyForCreationDto, Company>();
        CreateMap<EmployeeForCreationDto, Employee>();

    }
}
