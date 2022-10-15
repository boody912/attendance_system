using System;
using System.Collections.Generic;

#nullable disable

namespace attendance_system.Models
{
    public partial class TbAttendance
    {
        public TbAttendance()
        {
            TbReborts = new HashSet<TbRebort>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Boolean { get; set; }
        public int StudId { get; set; }
        public int DocId { get; set; }

        public virtual TbDoctor Doc { get; set; }
        public virtual TbStudent Stud { get; set; }
        public virtual ICollection<TbRebort> TbReborts { get; set; }
    }
}
