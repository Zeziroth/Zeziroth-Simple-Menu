using System;
using System.Collections.Generic;

namespace Main
{
    public class GTA5Entity
    {
        public ReflectStructure structs = null;
        private IntPtr _baseAddr = IntPtr.Zero;

        public GTA5Entity(int index, bool directTarget = true, IntPtr entityAddr = new IntPtr())
        {
            IntPtr baseAddr = directTarget ? Base.GetPtr(Base.WorldPTR, new int[] { 0x8, 0x2A8 }) : Base.GetPtr(entityAddr, new int[] { 0x2A8 });
            _baseAddr = baseAddr;

            structs = new ReflectStructure(baseAddr, new Dictionary<string, Dictionary<int, int[]>>() {
            { "HEALTH", new Dictionary<int, int[]>(){ { 4, new int[] { (index* 0x18), 0x280 } } } },
            { "MAXHEALTH", new Dictionary<int, int[]>(){ { 4, new int[] { (index * 0x18), 0x2A0 } } } },
            { "POS_X", new Dictionary<int, int[]>(){ { 4, new int[] { (index * 0x18), 0x110 } } } },
            { "POS_Y", new Dictionary<int, int[]>(){ { 4, new int[] { (index * 0x18), 0x114 } } } },
            { "POS_Z", new Dictionary<int, int[]>(){ { 4, new int[] { (index * 0x18), 0x118 } } } },
            { "ENTITY", new Dictionary<int, int[]>(){ { 4, new int[] { (index * 0x18) } } } }
            });
        }

        public GTA5Entity(IntPtr addr)
        {
            _baseAddr = addr;

            structs = new ReflectStructure(_baseAddr, new Dictionary<string, Dictionary<int, int[]>>() {
            { "HEALTH", new Dictionary<int, int[]>(){ { 4, new int[] {  0x280 } } } },
            { "MAXHEALTH", new Dictionary<int, int[]>(){ { 4, new int[] { 0x2A0 } } } },
            { "POS_X", new Dictionary<int, int[]>(){ { 4, new int[] {  0x90 } } } },
            { "POS_Y", new Dictionary<int, int[]>(){ { 4, new int[] {  0x94 } } } },
            { "POS_Z", new Dictionary<int, int[]>(){ { 4, new int[] {  0x98 } } } },
            { "iCash", new Dictionary<int, int[]>(){ { 4, new int[] { 0x15D4 } } } }
            });
        }
        public float Get_PosX()
        {
            return this.structs.GetValue<float>("POS_X");
        }
        public float Get_Health()
        {
            return this.structs.GetValue<float>("HEALTH");
        }

        public void Set_Health(float val)
        {
            this.structs.SetValue("HEALTH", val);
        }
        public void TeleportToMe()
        {
            float x = World.structs.GetValue<float>("POS_X");
            float y = World.structs.GetValue<float>("POS_Y");
            float z = World.structs.GetValue<float>("POS_Z");

            this.structs.SetValue("POS_X", x);
            this.structs.SetValue("POS_Y", y);
            this.structs.SetValue("POS_Z", z + 2.5f);
        }
        public void TeleportTo(float x, float y, float z)
        {
            this.structs.SetValue("POS_X", x);
            this.structs.SetValue("POS_Y", y);
            this.structs.SetValue("POS_Z", z);
        }
        public void Kill()
        {
            IntPtr a = new IntPtr(this.structs.GetValue<int>("ENTITY"));
            IntPtr b = Base.GetPtr(Base.WorldPTR, new int[] { 0x8, 0x0 });

            if (a == b) return;

            this.Set_Health(0f);
        }
        public void KillAll()
        {
            this.Kill();
            List<GTA5Entity> entityAttackers = this.Attackers();
            foreach (GTA5Entity entity in entityAttackers)
            {
                entity.Kill();
            }
        }
        public List<GTA5Entity> Attackers()
        {
            List<GTA5Entity> entitys = new List<GTA5Entity>();

            for (int i = 0; i < 3; i++)
            {
                GTA5Entity entity = new GTA5Entity(i, false, _baseAddr);
                if (entity.structs.GetValue<string>("") == "")
                    entitys.Add(entity);
            }
            return entitys;
        }
        public IntPtr GetBase()
        {
            return _baseAddr;
        }
        public static List<GTA5Entity> GetAttackers()
        {
            List<GTA5Entity> entitys = new List<GTA5Entity>();

            for (int i = 0; i < 3; i++)
            {
                GTA5Entity entity = new GTA5Entity(i);
                if (entity.Get_PosX() != 0f)
                {
                    entitys.Add(entity);
                }
            }
            return entitys;
        }
    }
}
