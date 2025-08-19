using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitner_Systems.LeitnerSystemsDataCommon
{
    public class DbConfig
    {
        public static string ConnectionString =

        @"Server=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\LeitnerSystems.mdf;Database=LeitnerSystems;Integrated Security=True;Encrypt=False;MultipleActiveResultSets=true;";

        public DbConfig()
        {

        }
    }
}
