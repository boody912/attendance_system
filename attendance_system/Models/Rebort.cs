using System;
using System.Collections.Generic;

#nullable disable

namespace attendance_system.Models
{
    public partial class Rebort
    {
        public int Id { get; set; }
        public int? StudId { get; set; }
        public int? SubId { get; set; }
        public int? Mark { get; set; }
    }
}
