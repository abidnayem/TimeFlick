using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeFlick.Core.Entities
{
    public class Designation
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;  // Stored Name (e.g., "Manager", "Teacher")
        public string? Code { get; set; }                  // Optional short code (e.g., MGR, TCH)
        public string? Description { get; set; }           // Optional description
        public int OrderNo { get; set; } = 0; // 👈 Add this for manual sorting
        public bool IsActive { get; set; } = true;
    }
}
