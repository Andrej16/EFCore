using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManyToMany
{
    class Program
    {
        static void Main(string[] args)
        {
            using(Context context = new Context())
            {
                Subject s1 = new Subject() { Name = "First subject", Created = DateTime.Now };
                Subject s2 = new Subject() { Name = "Sec subject", Created = DateTime.Now };
                Subject s3 = new Subject() { Name = "Thirdth subject", Created = DateTime.Now };
                context.AddRange(new List<Subject> { s1, s2, s3 });

                IdentData i1 = new IdentData() { Info = "First Ident" };
                IdentData i2 = new IdentData() { Info = "Second Ident" };
                var i3 = new IdentData() { Info = "Thirdth ident" };
                context.AddRange(new List<IdentData> { i1, i2, i3 });
                context.SaveChanges();

                s1.IdentDataSubjects.Add(new IdentDataSubject { IdentDataId = i1.Id, SubjectId = s1.Id });
                s2.IdentDataSubjects.Add(new IdentDataSubject { IdentDataId = i1.Id, SubjectId = s2.Id });
                s3.IdentDataSubjects.Add(new IdentDataSubject { IdentDataId = i2.Id, SubjectId = s3.Id });
                context.SaveChanges();

                var subjects = context.Subjects
                    .Include(s => s.IdentDataSubjects)
                    .ThenInclude(i => i.Ident);
                Console.WriteLine("sql: " + subjects.ToQueryString());
                //Выводим всех субьектов
                foreach (var s in subjects)
                {
                    Console.WriteLine($"Subject: {s.Name}");
                    //Выводим все идентификации для каждого субьекта
                    var idents = s.IdentDataSubjects.Select(s => s.Ident);
                    foreach (var i in idents)
                    {
                        Console.WriteLine($"\tHas identify: {i.Info}");
                    }
                }
            }
        }
    }
}
