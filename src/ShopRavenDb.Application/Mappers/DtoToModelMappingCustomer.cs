namespace ShopRavenDb.Application.Mappers
{
    public class DtoToModelMappingCustomer : Profile
    {
        public DtoToModelMappingCustomer()
        {
            MappingCustomer();
        }

        private void MappingCustomer()
        {
            CreateMap<CustomerDto, Customer>()
                .ForMember(dest => dest.Id, opt => opt.Ignore()).ReverseMap()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(x => x.Name)).ReverseMap()
                .ForMember(dest => dest.Email, opt => opt.MapFrom(x => x.Email)).ReverseMap()
                .ForMember(dest => dest.BirthDate, opt => opt.MapFrom(x => x.BirthDate)).ReverseMap()
                .ForMember(dest => dest.Address, opt => opt.MapFrom(x => x.Address)).ReverseMap()
                .ForMember(dest => dest.CPF, opt => opt.MapFrom(x => x.CPF)).ReverseMap()
                .ForMember(dest => dest.IsActive, opt => opt.Ignore()).ReverseMap();
        }
    }
}
