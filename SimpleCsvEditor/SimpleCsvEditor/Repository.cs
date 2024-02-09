using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration.Json;
namespace SimpleCsvEditor
{
    public class Repository
    {
        IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        //prøv "string" hvsi det ikke virker
        string ConnectionString;
        public Repository() 
        { ConnectionString = config.GetConnectionString("MyDBConnection"); }

    }
}
