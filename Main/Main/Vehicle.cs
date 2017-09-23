using System;
using System.Collections.Generic;

namespace Main
{
    public class Vehicle
    {
        public ReflectStructure structs = null;
        private IntPtr _baseAddr = IntPtr.Zero;
        private static IntPtr _lastPtr = IntPtr.Zero;
        private static Vehicle _lastVehicle = null;

        public Vehicle(IntPtr addr)
        {
            _baseAddr = addr;

            structs = new ReflectStructure(_baseAddr, new Dictionary<string, Dictionary<int, int[]>>() {
            { "HEALTH", new Dictionary<int, int[]>(){ { 4, new int[] {  0x87C } } } },
            { "POS_X", new Dictionary<int, int[]>(){ { 4, new int[] {  0x30, 0x50 } } } },
            { "POS_Y", new Dictionary<int, int[]>(){ { 4, new int[] { 0x30, 0x54 } } } },
            { "POS_Z", new Dictionary<int, int[]>(){ { 4, new int[] { 0x30, 0x58 } } } },
            { "ACCELERATION", new Dictionary<int, int[]>(){ { 4, new int[] {  0x8A8, 0x4C } } } },
            { "BREAKFORCE", new Dictionary<int, int[]>(){ { 4, new int[] {  0x8A8, 0x6C } } } },
            { "CURVE_TRACTION", new Dictionary<int, int[]>(){ { 4, new int[] {  0x8A8, 0x90 } } } },
            { "DEMOLITION_MULTIPLIER", new Dictionary<int, int[]>(){ { 4, new int[] {  0x8A8, 0xF8 } } } },
            { "SUSPENSION_FORCE", new Dictionary<int, int[]>(){ { 4, new int[] {  0x8A8, 0xBC } } } },
            { "GRAVITY", new Dictionary<int, int[]>(){ { 4, new int[] {  0x8A8, 0xB7C } } } },
            });
        }
        public static Vehicle CurrenVehicle()
        {
            Vehicle vehicle = null;
            try
            {
                IntPtr currentVehiclePTR = Base.GetPtr(Base.WorldPTR, new int[] { 0x8, 0xD28 });

                if (_lastPtr == currentVehiclePTR)
                {
                    return _lastVehicle;
                }
                vehicle = new Vehicle(currentVehiclePTR);
                _lastPtr = currentVehiclePTR;
                _lastVehicle = vehicle;
                return vehicle;
            }
            catch
            {
                return vehicle;
            }
        }
        public float Get_Gravity()
        {
            return this.structs.GetValue<float>("GRAVITY");
        }
        public void Set_Gravity(float val)
        {
            this.structs.SetValue("GRAVITY", val);
        }
        public float Get_Acceleration()
        {
            return this.structs.GetValue<float>("ACCELERATION");
        }
        public void Set_Acceleration(float val)
        {
            this.structs.SetValue("ACCELERATION", val);
        }
        public float Get_Breakforce()
        {
            return this.structs.GetValue<float>("BREAKFORCE");
        }
        public void Set_Breakforce(float val)
        {
            this.structs.SetValue("BREAKFORCE", val);
        }
        public float Get_Traction()
        {
            return this.structs.GetValue<float>("CURVE_TRACTION");
        }
        public void Set_Traction(float val)
        {
            this.structs.SetValue("CURVE_TRACTION", val);
        }
        public float Get_Demolition_Multiplier()
        {
            return this.structs.GetValue<float>("DEMOLITION_MULTIPLIER");
        }
        public void Set_Demolition_Multiplier(float val)
        {
            this.structs.SetValue("DEMOLITION_MULTIPLIER", val);
        }
        public float Get_Suspension()
        {
            return this.structs.GetValue<float>("SUSPENSION_FORCE");
        }
        public void Set_Suspension(float val)
        {
            this.structs.SetValue("SUSPENSION_FORCE", val);
        }
        public float Get_PosY()
        {
            return this.structs.GetValue<float>("POS_X");
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

        public float Get_Health()
        {
            return this.structs.GetValue<float>("HEALTH");
        }

        public void Set_Health(float val)
        {
            this.structs.SetValue("HEALTH", val);
        }
        public void Destroy()
        {
            this.Set_Health(0f);
        }
        public void Repair()
        {
            this.Set_Health(1000f);
        }
        public void Burn()
        {
            this.Set_Health(-1000f);
        }
    }
}
