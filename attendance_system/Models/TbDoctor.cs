using System;
using System.Collections.Generic;

#nullable disable

namespace attendance_system.Models
{
    public partial class TbDoctor
    {
        public TbDoctor()
        {
            TbAttendances = new HashSet<TbAttendance>();
            TbClassrooms = new HashSet<TbClassroom>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TbAttendance> TbAttendances { get; set; }
        public virtual ICollection<TbClassroom> TbClassrooms { get; set; }
    }
}
