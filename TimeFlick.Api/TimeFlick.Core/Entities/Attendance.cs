using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeFlick.Core.Enums;

namespace TimeFlick.Core.Entities
{
    public class Attendance
    {
        public int Id { get; set; }

        public int PersonId { get; set; }
        // public Person? Employee { get; set; }
        public int ShiftId { get; set; }
        public Shift? Shift { get; set; }
        public DateTime AttendanceDate { get; set; }

        public DateTime? InTime { get; set; }
        public DateTime? OutTime { get; set; }

        public AttendanceStatus Status { get; set; } = AttendanceStatus.Present;

        public int? LeaveTypeId { get; set; }
        //public LeaveType? LeaveType { get; set; }

        public TimeSpan? LateBy { get; set; }
        public TimeSpan? EarlyOutBy { get; set; }

        public TimeSpan? StayDuration { get; set; }       // OutTime - InTime
        public TimeSpan? OverTime { get; set; }           // Beyond shift end
        public TimeSpan? ExtraOverTime { get; set; }      //Beyond normal OT or Weekend or holiday OT

        public TimeSpan TotalOverTime =>
            (OverTime ?? TimeSpan.Zero) + (ExtraOverTime ?? TimeSpan.Zero);

        public string? Note { get; set; }

        // Audit fields
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        // Optional payable flag (depends on business rules)
        public bool IsPayable { get; set; } = true;
    }
}
