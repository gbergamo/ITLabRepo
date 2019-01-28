using AutoMapper;
using ITLabTest.AppService.ViewModel;
using ITLabTest.Model;

namespace ITLabTest.AppService.Mapping
{
    public class ModelToViewModelMapping : Profile
    {
        public ModelToViewModelMapping()
        {
            CreateMap<Person, PersonViewModel>()
                .ForMember(x => x.SexDescription, opt => opt.MapFrom(o => o.Sex == 0 ? "Male" : "Female"));
            CreateMap<PersonViewModel, Person>();
        }
    }
}