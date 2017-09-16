using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public class Player
    {
        public ReflectStructure structs = null;

        public Player(int index)
        {
            structs = new ReflectStructure(Base.PlayerPTR, new Dictionary<string, Dictionary<int, int[]>>() {
                { "NICKNAME", new Dictionary<int, int[]>(){ { 32, new int[] { (0x8*index) + 0x180, 0xA8, 0x7C } } } },
                { "RUN_SPEED", new Dictionary<int, int[]>(){ { 4, new int[] { (0x8*index) + 0x180, 0xA8, 0x14C } } } },
                { "WANTED_LEVEL", new Dictionary<int, int[]>(){ { 4, new int[] { (0x8*index) + 0x180, 0xA8, 0x7F8 } } } }
            });
        }

        public int Get_WantedLevel()
        {
            return this.structs.GetValue<int>("WANTED_LEVEL");
        }

        public void Set_WantedLevel(int val)
        {
            this.structs.SetValue("WANTED_LEVEL", val);
        }
        public float Get_RunSpeed()
        {
            return this.structs.GetValue<float>("RUN_SPEED");
        }

        public void Get_RunSpeed(float val)
        {
            this.structs.SetValue("RUN_SPEED", val);
        }

        public string Get_Nickname()
        {
            string nickname = this.structs.GetValue<string>("NICKNAME");
            byte[] bytes = Encoding.ASCII.GetBytes(nickname);            

            List<byte> newNickBytes = new List<byte>();

            foreach (byte b in bytes)
            {
                if (b == 0x00)
                {
                    break;
                }

                newNickBytes.Add(b);
            }

            if (newNickBytes.Count <= 0)
            {
                return "";
            }

            return Encoding.ASCII.GetString(newNickBytes.ToArray());
        }
        public bool isPlayer()
        {
            return Get_Nickname() != "";
        }
    }
}
