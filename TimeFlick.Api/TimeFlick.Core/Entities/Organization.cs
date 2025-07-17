using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeFlick.Core.Enums;

namespace TimeFlick.Core.Entities
{
    public class Organization
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;             // e.g., "ABC Corp", "Sunrise School"
        public string? Code { get; set; }                            // Optional short code

        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }

        public OrganizationType Type { get; set; } = OrganizationType.Company;  // Enum (optional)

        public string? LogoUrl { get; set; }
        public bool IsActive { get; set; } = true;
    }

}
