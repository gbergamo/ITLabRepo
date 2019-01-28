using ITLabRepository.Interfaces;
using ITLabTest.Model;
using ITLabTest.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ITLabRepository.Repos
{
    public class PersonRepository : IPersonRepository
    {
        private readonly IRepository<Person> repository;

        public PersonRepository(IRepository<Person> repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Person> All()
        {
            return repository.All();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Person> Insert(Person entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> List(Expression<Person> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Person> ListById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Person> Update(Person entity)
        {
            throw new NotImplementedException();
        }
    }
}
