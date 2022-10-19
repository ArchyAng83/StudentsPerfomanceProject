using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsPerfomanceBL
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnection(bool database)
        {
            if (database)
            {
                SqlConnector sqlConnector = new SqlConnector();
                Connections.Add(sqlConnector);
            }
        }
    }
}
