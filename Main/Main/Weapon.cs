using System;
using System.Collections.Generic;

namespace Main
{
    class Weapon
    {
        public ReflectStructure structs = null;
        private long _addr = 0x0;
        private static Dictionary<long, float> oldBPS = new Dictionary<long, float>();

        private Weapon(IntPtr addr)
        {
            _addr = Base.GetPtr(addr, new int[] { 0x134 }).ToInt64();
            structs = new ReflectStructure(addr, new Dictionary<string, Dictionary<int, int[]>>() {
                { "BPS", new Dictionary<int, int[]>(){ { 4, new int[] { 0x134 }} } }
            });
            Single bpsVal = this.structs.GetValue<Single>("BPS");

            if (bpsVal > 0.000000000f && !oldBPS.ContainsKey(_addr))
            {
                oldBPS.Add(_addr, bpsVal);
            }
            
        }

        public void Set_BPS(float val)
        {
            this.structs.SetValue("BPS", val);
        }

        public float Get_BPS()
        {
            return this.structs.GetValue<float>("BPS");
        }
        public void FastShoot(bool restore)
        {
            if (restore)
            {
                this.structs.SetValue("BPS", oldBPS[_addr]);
            }
            else
            {
                this.structs.SetValue("BPS", 0.000000000f);
            }
        }
        public static Weapon Get_CurrentWeapon()
        {
            IntPtr curWeaponBase = Base.GetPtr(Base.WorldPTR, new int[] { 0x8, 0x10C8, 0x20});
            return new Weapon(curWeaponBase);
        }
    }
}
