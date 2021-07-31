using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeMVC.Utility
{
    public class ConnectionString
    {
        //public ConnectionString(IConfiguration configuration)
        //{

        //}

        private static string connectionString = "Data Source=DESKTOP-KBAPQC1;Initial Catalog=PracticeStudent;Integrated Security=True;";

        public static string conString { get => connectionString; }
    }
}
