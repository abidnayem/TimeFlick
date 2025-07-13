using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeFlick.Core.Enums;

namespace TimeFlick.Core.Extensions
{
    public static class AttendanceStatusExtensions
    {
        public static string ToShortCode(this AttendanceStatus status)
        {
            return status switch
            {
                AttendanceStatus.Absent => "A",
                AttendanceStatus.Present => "P",
                AttendanceStatus.Late => "L",
                AttendanceStatus.Leave => "Lv",
                _ => "?"
            };
        }

        public static string ToDisplayName(this AttendanceStatus status)
        {
            return status switch
            {
                AttendanceStatus.Absent => "Absent",
                AttendanceStatus.Present => "Present",
                AttendanceStatus.Late => "Late",
                AttendanceStatus.Leave => "Leave",
                _ => "Unknown"
            };
        }
    }
}
