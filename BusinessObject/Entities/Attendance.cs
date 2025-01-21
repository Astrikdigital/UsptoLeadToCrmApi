using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjectsLayer.Entities
{
    public class Attendance : BaseEntity
    {
        public int SemesterCourseId { get; set; }
        public int CourseFacultyId { get; set; }
        public int RoasterId { get; set; }
        public DateTime ClassDateTime { get; set; }
        public int TotalPresentStudent { get; set; }
        public int TotalAbsentStudent { get; set; }
        public int TotalStudent { get; set; }
    }
    public class AttendanceDetail : BaseEntity
    {
        public int AttendanceId { get; set; }
        public int StudentId { get; set; }
        public bool IsPresent { get; set; }
    }
    public class AttendanceModel : BaseEntity
    {
        public int SemesterCourseId { get; set; }
        public int CourseFacultyId { get; set; }
        public int RoasterId { get; set; }
        public DateTime ClassDate { get; set; }
        public string ClassTime { get; set; }
        public int AttendanceId { get; set; }
        public List<AttendanceDetail> Students { get; set; }
    }
}
