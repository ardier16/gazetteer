using System;

namespace Gazetteer
{
    public class Try : SQLEditor
    {
        public static void InsertTryResults(string score, string gameId, string cityId)
        {
            int id = SetId("SELECT TryId FROM Try");
            DoSqlOperation(String.Format("INSERT INTO Try VALUES('{0}', '{1}', '{2}', '{3}')", id, score, gameId, cityId));
        }
    }
}
