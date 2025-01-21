using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjectsLayer.Entities
{
    public class FacultyUnavailability : BaseEntity
    { 
        public int FacultyId { get; set; }
        public DateTime Date { get; set; } 
        public string StartTime { get; set; } 
        public string EndTime { get; set; }
    }
}
