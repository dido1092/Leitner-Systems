using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitner_Systems.LeitnerSystemsDataCommon
{
    public static class DbConfig
    {
        public static string userName = Environment.UserName;

        public static string ConnectionString =

        $@"Server=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\{userName}\source\repos\Leitner Systems\DB\LeitnerSystems.mdf;Database=LeitnerSystems;Integrated Security=True;Encrypt=False;MultipleActiveResultSets=true;";
    }
}
