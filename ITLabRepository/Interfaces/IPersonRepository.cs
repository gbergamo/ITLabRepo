using ITLabTest.Model;
using ITLabTest.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITLabRepository.Interfaces
{
    public interface IPersonRepository: IRepository<Person>
    {
    }
}
