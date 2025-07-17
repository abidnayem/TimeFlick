using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeFlick.Core.Entities;

namespace TimeFlick.Core.Interfaces
{
    public interface IPersonRepository : IRepository<Person>
    {
        Task<Person?> GetByPersonCodeAsync(string personCode);
    }
}
