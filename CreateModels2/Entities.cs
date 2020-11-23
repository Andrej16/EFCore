using System;
using System.Collections.Generic;

namespace CreateModels2
{
    public class Subject
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public DateTime Updated { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
    public class Department
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public List<Subject> Subjects { get; set; }
        public Department()
        {
            Subjects = new List<Subject>();
        }
    }
}
