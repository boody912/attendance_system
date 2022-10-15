using System;
using System.Collections.Generic;

#nullable disable

namespace attendance_system.Models
{
    public partial class TbSubject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
        public string Description { get; set; }
    }
}
