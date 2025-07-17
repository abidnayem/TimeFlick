using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeFlick.Core.Entities;
using TimeFlick.Core.Interfaces;

namespace TimeFlick.Application.Services
{
    public class PersonService : Service<Person>, IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
            : base(personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<Person?> GetByPersonCodeAsync(string personCode)
        {
            return await _personRepository.GetByPersonCodeAsync(personCode);
        }
    }
}
