using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeFlick.Core.Entities
{
    public class Shift
    {
        public int Id { get; set; }
        public string Name { get; set; } = "General";

        public TimeSpan StartTime { get; set; }    // Scheduled start
        public TimeSpan EndTime { get; set; }      // Scheduled end

        public int GraceInMinutes { get; set; } = 5;
        public int GraceOutMinutes { get; set; } = 0;
        public bool IsNightShift { get; set; } = false;

        // 👇 In/Out punch barrier times
        public TimeSpan? InPunchStart { get; set; }    // Earliest punch-in allowed
        public TimeSpan? InPunchEnd { get; set; }      // Latest punch-in accepted

        public TimeSpan? OutPunchStart { get; set; }   // Earliest punch-out allowed
        public TimeSpan? OutPunchEnd { get; set; }     // Latest punch-out accepted

        public string? Description { get; set; }
    }

}
