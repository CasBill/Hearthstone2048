using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace Web
{
    public class rankDB : DBHelper
    {
        public int uploadScore(String name, Int32 score)
        {
            String sqlCommand = "insert into gamerecord values (null, @Name, @Score, now())";

            List<MySqlParameter> paramList = new List<MySqlParameter>();
            paramList.Add(new MySqlParameter("@Name", name));
            paramList.Add(new MySqlParameter("@Score", score));

            return executeSqlCommandNoQuery(sqlCommand, paramList);
        
        }

        public DataSet getRank()
        {
            String sqlCommand = "select * from gamerecord order by Score desc";

            return executeSqlCommandDataSet(sqlCommand);
        }
    }
}