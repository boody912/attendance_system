using System;
using System.Collections.Generic;

#nullable disable

namespace attendance_system.Models
{
    public partial class TbStudent
    {
        public TbStudent()
        {
            TbAttendances = new HashSet<TbAttendance>();
            TbReborts = new HashSet<TbRebort>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TbAttendance> TbAttendances { get; set; }
        public virtual ICollection<TbRebort> TbReborts { get; set; }
    }
}
