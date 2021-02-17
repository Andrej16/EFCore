using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;
using QueriesToOracle.Core;
using System;
using System.Data;
using System.Linq;

namespace QueriesToOracle.Controllers
{
    public class RawSqlQueries : IReader
    {
        public void DoRead()
        {
            //FromSqlRaw();
            FromSqlParameter();
            //CallStoredFunction();
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
        private void FromSqlParameter()
        {
            using Context db = new Context();
            OracleParameter[] param = new OracleParameter[]
            { 
                new OracleParameter("IDATEIDENTSTARTFROM", new DateTime(2020, 10, 1)),
                new OracleParameter("ISUBJECTTYPE", 1),
                new OracleParameter("v_Return", OracleDbType.RefCursor, ParameterDirection.ReturnValue)
            };
            string sql = "DECLARE v_Return sys_refcursor; BEGIN v_Return := PKIDENTDATA.GETFROMTABLE(:IDATEIDENTSTARTFROM, :ISUBJECTTYPE); :v_Return := v_Return; END;";

            var identifies = db.IdentDatas.FromSqlRaw(sql, param).ToList();
            foreach (var item in identifies)
                Console.WriteLine($"{item.Id} - {item.SubjectId} - {item.SubjectName} - {item.Inn}");
        }
        private void CallStoredFunction()
        {
            DateTime filterDate = new DateTime(2020, 10, 1);
            using Context db = new Context();
            var identifies = db.IdentDatas.FromSqlRaw("select * from table(PkIdentData.GetTable({0}))", filterDate);
            foreach (var item in identifies)
                Console.WriteLine($"{item.Id} - {item.SubjectId} - {item.SubjectName} - {item.Inn}");
        }

    }
}
