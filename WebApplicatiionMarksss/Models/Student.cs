using System;
using System.Collections.Generic;

namespace WebApplicatiionMarksss.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; } = null!;
        public int? ClassId { get; set; }
        public int? SubjectId { get; set; }
        public string? Marks { get; set; }

        public virtual Class? Class { get; set; }
        public virtual Subject? Subject { get; set; }
    }
}
