using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace CustomDictionary
{
    public class SqliteDataAccess
    {
        public  SqliteDataAccess(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public   List<Word> GetWords()
        {
            using(IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var output = con.Query<Word>("select * from Words", new DynamicParameters());
                return output.ToList();
            }
        }

        public List<Word> GetWordbyId(int Id)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var sql = "select * from Words where id =" + Id;
                var output = con.Query<Word>(sql, new DynamicParameters());
                return output.ToList();
            }
        }

        public List<Word> GetWordbytext(string inputText)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var sql = "select * from Words where value like '" + inputText +"%'";
                var output = con.Query<Word>(sql, new DynamicParameters());
                return output.ToList();
            }
        }
        private  string LoadConnectionString()
        {
           return ConfigurationExtensions.GetConnectionString(Configuration, "myDb1");
        }
    }
}
