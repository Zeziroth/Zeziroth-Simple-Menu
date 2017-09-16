using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public static class Players
    {
        public static ReflectStructure structs = new ReflectStructure(Base.PlayerPTR, new Dictionary<string, Dictionary<int, int[]>>() {
            { "Playercount", new Dictionary<int, int[]>(){ { 4, new int[] { 0x178 } } } }
        });

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
