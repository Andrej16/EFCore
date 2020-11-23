using System;

namespace CreateModels2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var model = new Model())
            {

                var d = new Department()
                {
                    Name = "SubjectName",
                };
                model.Add(d);
                model.SaveChanges();

                d.Subjects.Add(new Subject()
                {
                    Name = "Subject Name",
                    Updated = DateTime.Now
                });
                model.SaveChanges();
            }
        }
    }
}
