using System;
using System.Collections.Generic;
using System.Text;

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
                { "WANTED_LEVEL", new Dictionary<int, int[]>(){ { 4, new int[] { (0x8*index) + 0x180, 0xA8, 0x7F8 } } } },
                { "HEALTH", new Dictionary<int, int[]>(){ { 4, new int[] { (0x8*index) + 0x180, 0x1C8, 0x280 } } } },
                { "MAXHEALTH", new Dictionary<int, int[]>(){ { 4, new int[] { (0x8*index) + 0x180, 0x1C8, 0x2A0 } } } },
                { "POS_X", new Dictionary<int, int[]>(){ { 4, new int[] { (0x8 * index) + 0x180, 0xA8, 0x1C8, 0x90 } } } },
                { "POS_Y", new Dictionary<int, int[]>(){ { 4, new int[] { (0x8 * index) + 0x180, 0xA8, 0x1C8, 0x94 } } } },
                { "POS_Z", new Dictionary<int, int[]>(){ { 4, new int[] { (0x8 * index) + 0x180, 0xA8, 0x1C8, 0x98 } } } },
                { "IP", new Dictionary<int, int[]>(){ { 4, new int[] { (0x8 * index) + 0x180, 0xA8, 0x44 } } } },
                { "PORT", new Dictionary<int, int[]>(){ { 2, new int[] { (0x8 * index) + 0x180, 0xA8, 0x48 } } } }
            });
        }
        public int Get_IP()
        {
            return this.structs.GetValue<int>("IP");
        }
        public Int16 Get_Port()
        {
            return this.structs.GetValue<Int16>("PORT");
        }
        public float Get_PosY()
        {
            return this.structs.GetValue<float>("POS_Y");
        }
        public void Set_PosY(float val)
        {
            this.structs.SetValue("POS_Y", val);
        }
        public float Get_PosX()
        {
            return this.structs.GetValue<float>("POS_X");
        }
        public void Set_PosX(float val)
        {
            //System.Windows.Forms.MessageBox.Show(Base.GetPtr(Base.PlayerPTR, new int[] { 0x1A0 + 0x180, 0xA8, 0x1C8, 0x90 }).ToInt64().ToString("X"));
            this.structs.SetValue("POS_X", val);

        }
        public float Get_PosZ()
        {
            return this.structs.GetValue<float>("POS_Z");
        }
        public void Set_PosZ(float val)
        {
            this.structs.SetValue("POS_Z", val);
        }
        public float Get_MaxHealth()
        {
            return this.structs.GetValue<float>("MAXHEALTH");
        }

        public void Set_MaxHealth(float val)
        {
            this.structs.SetValue("MAXHEALTH", val);
        }
        public float Get_Health()
        {
            return this.structs.GetValue<float>("HEALTH");
        }

        public void Set_Health(float val)
        {
            this.structs.SetValue("HEALTH", val);
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
        public void TeleportToMe()
        {
            float x = World.structs.GetValue<float>("POS_X");
            float y = World.structs.GetValue<float>("POS_Y");
            float z = World.structs.GetValue<float>("POS_Z");

            Set_PosX(x);
            Set_PosY(y);
            Set_PosZ(z + 2.5f);
        }
    }
}
