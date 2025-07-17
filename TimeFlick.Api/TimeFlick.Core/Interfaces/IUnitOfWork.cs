using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeFlick.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IPersonRepository Persons { get; }
        //IDepartmentRepository Departments { get; }
        //IDesignationRepository Designations { get; }
        //IShiftRepository Shifts { get; }

        Task<int> CommitAsync();
    }

}
