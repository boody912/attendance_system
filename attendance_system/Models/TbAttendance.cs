using System;
using System.Collections.Generic;

#nullable disable

namespace attendance_system.Models
{
    public partial class TbAttendance
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Boolean { get; set; }
        public int StudId { get; set; }
        public int TechTeachId { get; set; }
    }
}
