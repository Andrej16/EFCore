using Microsoft.EntityFrameworkCore;
using QueriesToOracle.Core;
using System;
using System.Linq;

namespace QueriesToOracle.Controllers
{
    public class EntityQuery : IReader
    {
        public void DoRead()
        {
            //FilterByName();
            GroupByOrgForm();
        }
        private void GroupByOrgForm()
        {
            using (Context db = new Context())
            {
                var subjectGroupsClient = (from s in db.Subjects
                                           where EF.Functions.Like(s.SubNamefull, "%Шилін%")
                                           select s).ToList();

                var subjectGroups = from sub in subjectGroupsClient
                                    group sub by sub.SubDtfId into orgGroup
                                    select orgGroup;
                foreach (IGrouping<decimal?, Subject> g in subjectGroups)
                {
                    Console.WriteLine($"GroupId - {g.Key}, Count - {g.Count()}");
                    foreach (var item in g)
                    {
                        Console.WriteLine($"Id - {item.SubId}, Inn - {item.SubInn}, Name - {item.SubNamefull}");
                    }
                }
            }
        }

        private void FilterByName()
        {
            using (Context db = new Context())
            {
                var subjects = from s in db.Subjects
                               where EF.Functions.Like(s.SubNamefull, "%Шилін%")
                               select s;
                foreach (var item in subjects)
                    Console.WriteLine($"Id - {item.SubId}, Inn - {item.SubInn}, Name - {item.SubNamefull}");
            }
        }
        private void LoadIdentRisk()
        {
            using (Context db = new Context())
            {
                IQueryable<IdentRisk> risks = from risk in db.IdentRisks select risk;
                foreach (var item in risks)
                    Console.WriteLine($"{item.Id} - {item.Name}");
            }
        }
    }
}
