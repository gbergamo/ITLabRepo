using ITLabTest.AppService.ViewModel;
using ITLabTest.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ITLabTest.AppService.Interfaces
{
    public interface IPersonAppService
    {
        Task<PersonViewModel> Insert(PersonViewModel person);
        Task<PersonViewModel> Update(PersonViewModel person);
        Task Delete(PersonViewModel person);
        IEnumerable<PersonViewModel> All();
        Task<PersonViewModel> ListById(Guid id);
        IEnumerable<PersonViewModel> List(PersonViewModel expression);
    }
}
