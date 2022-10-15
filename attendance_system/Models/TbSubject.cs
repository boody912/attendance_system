using System;
using System.Collections.Generic;

#nullable disable

namespace attendance_system.Models
{
    public partial class TbSubject
    {
        public TbSubject()
        {
            TbReborts = new HashSet<TbRebort>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
        public string Description { get; set; }

        public virtual ICollection<TbRebort> TbReborts { get; set; }
    }
}
