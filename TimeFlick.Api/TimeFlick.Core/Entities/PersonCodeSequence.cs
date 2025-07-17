using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeFlick.Core.Entities
{
    public class PersonCodeSequence
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public string Prefix { get; set; } = null!;
        public string Year { get; set; } = null!;
        public int LastSerial { get; set; }
    }

}
