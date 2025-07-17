using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeFlick.Core.Entities;
using TimeFlick.Core.Interfaces;
using TimeFlick.Infrastructure.Data;

namespace TimeFlick.Infrastructure.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        private readonly AppDbContext _context;

        public PersonRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Person?> GetByPersonCodeAsync(string personCode)
        {     
            return await _context.Persons.FirstOrDefaultAsync(p => p.PersonCode == personCode);
        }
    }
}
