using System.Collections.Generic;

namespace Main
{
    public static class Players
    {
        public static ReflectStructure structs = new ReflectStructure(Base.PlayerPTR, new Dictionary<string, Dictionary<int, int[]>>() {
            { "Playercount", new Dictionary<int, int[]>(){ { 4, new int[] { 0x178 } } } }
        });
        public static void Refresh()
        {
            structs._basePTR = Base.WorldPTR;
            structs = new ReflectStructure(Base.PlayerPTR, new Dictionary<string, Dictionary<int, int[]>>() {
            { "Playercount", new Dictionary<int, int[]>(){ { 4, new int[] { 0x178 } } } }
            });
        }
        public static Player GetPlayerByName(string s)
        {
            List<Player> players = GetPlayers();
            foreach (Player player in players)
            {
                if (player.Get_Nickname().ToLower() == s.ToLower())
                {
                    return player;
                }
            }
            return null;
        }
        public static List<Player> GetPlayers()
        {
            List<Player> players = new List<Player>();
            int max = structs.GetValue<int>("Playercount");

            for (int i = 0; i < max; i++)
            {
                Player player = new Player(i);

                if (player.isPlayer())
                {
                    players.Add(player);
                }
                else
                {
                    max++;
                }

            }
            return players;
        }
    }
}
