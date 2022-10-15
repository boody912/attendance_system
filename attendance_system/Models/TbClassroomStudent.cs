using System;
using System.Collections.Generic;

#nullable disable

namespace attendance_system.Models
{
    public partial class TbClassroomStudent
    {
        public int? StudId { get; set; }
        public int? ClassroomId { get; set; }

        public virtual TbClassroom Classroom { get; set; }
        public virtual TbStudent Stud { get; set; }
    }
}
