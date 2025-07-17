using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TimeFlick.Core.Enums;

namespace TimeFlick.Core.Entities
{
    public class Person
    {
        public int Id { get; set; }

        public string PersonCode { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string? Phone { get; set; }

        public string? NationalId { get; set; }
        public DateTime? JoiningDate { get; set; }  // Joining date of employee/student/member
        public DateTime? DateOfBirth { get; set; }
        public string? Address { get; set; }

        public Gender Gender { get; set; } = Gender.Unknown;

        // Relations
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }

        public int? DesignationId { get; set; }
        public Designation? Designation { get; set; }

        public int? ShiftId { get; set; }
        public Shift? Shift { get; set; }
    }


}
