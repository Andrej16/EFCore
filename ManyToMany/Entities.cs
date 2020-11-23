using System;
using System.Collections.Generic;

namespace ManyToMany
{
    public class IdentData
    {
        public int Id { get; set; }
        public string Info { get; set; }
        //public ICollection<Subject> Subjects { get; set; }
        public List<IdentDataSubject> IdentDataSubjects { get; set; }
        public IdentData()
        {
            IdentDataSubjects = new List<IdentDataSubject>();
        }
    }
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        //public ICollection<IdentData> IdentDatas { get; set; }
        public List<IdentDataSubject> IdentDataSubjects { get; set; }
        public Subject()
        {
            IdentDataSubjects = new List<IdentDataSubject>();
        }
    }
    public class IdentDataSubject
    {
        public int IdentDataId { get; set; }
        public IdentData Ident { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
