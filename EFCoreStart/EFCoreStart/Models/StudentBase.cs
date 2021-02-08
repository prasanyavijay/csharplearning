using System.Collections.Generic;

namespace EFCoreStart.Models
{
    public class StudentBase
    {
                public ICollection<Enrollment> Enrollments { get; set; }
    }
}