using System;

namespace Gazetteer
{
    public class Game : SQLEditor
    {
        public static void InsertGameData(string login)
        {
            DoSqlOperation(String.Format("INSERT INTO Game VALUES('{0}', '{1}', '{2}', '{3}')", SetId("SELECT GameId FROM Game"), 0, 0, login));
        }

        public static void UpdateGameData(string gameId, string score, string time)
        {
            DoSqlOperation(String.Format("UPDATE Game SET GameScore='{0}', GameTime='{1}' WHERE GameId='{2}'", score, time, gameId));
        }
    }
}
