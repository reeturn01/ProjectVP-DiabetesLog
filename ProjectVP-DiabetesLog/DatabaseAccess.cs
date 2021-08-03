using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ProjectVP_DiabetesLog
{
    class DatabaseAccess
    {
        public string LoadConnectionString(string name = "Default") {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
