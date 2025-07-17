using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeFlick.Core.Entities;

namespace TimeFlick.Core.Interfaces
{
    public interface IPersonService : IService<Person>
    {
        Task<Person?> GetByPersonCodeAsync(string personCode);
    }
}
