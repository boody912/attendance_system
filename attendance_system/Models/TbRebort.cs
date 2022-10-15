using System;
using System.Collections.Generic;

#nullable disable

namespace attendance_system.Models
{
    public partial class TbRebort
    {
        public int Id { get; set; }
        public int StudId { get; set; }
        public int SubId { get; set; }
        public int AttendId { get; set; }
        public int TotalAbsent { get; set; }

        public virtual TbAttendance Attend { get; set; }
        public virtual TbStudent Stud { get; set; }
        public virtual TbSubject Sub { get; set; }
    }
}
