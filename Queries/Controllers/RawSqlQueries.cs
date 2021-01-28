using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;
using QueriesToOracle.Core;
using System;
using System.Linq;

namespace QueriesToOracle.Controllers
{
    public class RawSqlQueries : IReader
    {
        public void DoRead()
        {
            //FromSqlRaw();
            FromSqlParameter();
        }
        private void FromSqlRaw()
        {
            using Context db = new Context();
            var dictionary = db.KeyValues.FromSqlRaw("select * from table(PkPrIdentData.DataMain({0}))", 5704).ToList();
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
        /// <summary>
        /// Doesn't work
        /// </summary>
        private void FromSqlParameter()
        {
            using Context db = new Context();
            //OracleParameter param = new OracleParameter("@Id", OracleDbType.Int32)
            //{ 
            //    Value = 5704 
            //};
            var dictionary = db.KeyValues.FromSqlInterpolated($"select * from table(PkPrIdentData.DataMain({5704}))").ToList();
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
