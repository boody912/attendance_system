using System;
using System.Collections.Generic;

#nullable disable

namespace attendance_system.Models
{
    public partial class TbClassroom
    {
        public int Id { get; set; }
        public string Section { get; set; }
        public string Grade { get; set; }
        public int DocId { get; set; }

        public virtual TbDoctor Doc { get; set; }
    }
}
