using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class GTAObject
    {
        public static Dictionary<IntPtr, GTAObject> objects = new Dictionary<IntPtr, GTAObject>();

        public ReflectStructure structs = null;

        public GTAObject(IntPtr addr, bool track = true)
        {
            structs = new ReflectStructure(addr, new Dictionary<string, Dictionary<int, int[]>>() {
                { "POS_X", new Dictionary<int, int[]>(){ { 4, new int[] { 0x10 } } } },
                { "POS_Y", new Dictionary<int, int[]>(){ { 4, new int[] { 0x14 } } } },
                { "ID", new Dictionary<int, int[]>(){ { 4, new int[] { 0x40 } } } }
            });

            if (track)
            {
                objects.Add(addr, this);
            }
        }

        public float Pos_X()
        {
            return this.structs.GetValue<float>("POS_X");
        }
        public float Pos_Y()
        {
            return this.structs.GetValue<float>("POS_Y");
        }
        public int ID()
        {
            return this.structs.GetValue<int>("ID");
        }
    }
}
