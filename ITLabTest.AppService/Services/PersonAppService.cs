using AutoMapper;
using ITLabRepository.Interfaces;
using ITLabTest.AppService.Interfaces;
using ITLabTest.AppService.ViewModel;
using ITLabTest.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ITLabTest.AppService.Services
{
    public class PersonAppService : IPersonAppService
    {
        private readonly IPersonRepository personRepository;
        private readonly IMapper _mapper;

        public PersonAppService(IPersonRepository personRepository, IMapper mapper)
        {
            this.personRepository = personRepository;
            this._mapper = mapper;
        }

        public IEnumerable<PersonViewModel> All()
        {
            return _mapper.Map<IEnumerable<PersonViewModel>>(personRepository.All());
        }

        public async Task Delete(PersonViewModel person)
        {
            await personRepository.Delete(person.Id);
        }

        public async Task<PersonViewModel> Insert(PersonViewModel person)
        {
            var personMapped = _mapper.Map<Person>(person);
            var personInserted = await personRepository.Insert(personMapped);
            return _mapper.Map<PersonViewModel>(personInserted);
        }

        public IEnumerable<PersonViewModel> List(PersonViewModel expression)
        {
            throw new NotImplementedException();
        }

        public async Task<PersonViewModel> ListById(Guid id)
        {
            var person = await personRepository.ListById(id);
            return _mapper.Map<PersonViewModel>(person);
        }

        public async Task<PersonViewModel> Update(PersonViewModel person)
        {
            var personMapped = Mapper.Map<Person>(person);
            var personUpdated = await personRepository.Update(personMapped);
            return _mapper.Map<PersonViewModel>(personUpdated);
        }
    }
}
