using System;

namespace Main
{
    public static class Base
    {
        public static IntPtr baseAddress = IntPtr.Zero;
        public static IntPtr ReplayeInterfacePTR = IntPtr.Zero;
        public static IntPtr pedListPTR = IntPtr.Zero;
        public static IntPtr WorldPTR = IntPtr.Zero;
        public static IntPtr AmmoPTR = IntPtr.Zero;
        public static IntPtr ClipPTR = IntPtr.Zero;
        public static IntPtr BlipPTR = IntPtr.Zero;
        public static IntPtr PlayerPTR = IntPtr.Zero;
        public static IntPtr WaypointPTR_X = IntPtr.Zero;
        public static IntPtr WaypointPTR_Y = IntPtr.Zero;

        public static void RefreshBase(bool steam)
        {
            
            baseAddress = Memory.ImageBase();
            if (baseAddress == IntPtr.Zero) return;

            if (steam)
            {
                ReplayeInterfacePTR = IntPtr.Add(baseAddress, 0x1E92AB8);
                WorldPTR = IntPtr.Add(baseAddress, 0x236ADE0);
                AmmoPTR = IntPtr.Add(baseAddress, 0xE89425);
                ClipPTR = IntPtr.Add(baseAddress, 0xE893E0);
                BlipPTR = IntPtr.Add(baseAddress, 0x1F9A2C0);
                PlayerPTR = IntPtr.Add(baseAddress, 0x1CE49C0);
                WaypointPTR_X = IntPtr.Add(baseAddress, 0x1FC0C70);
                WaypointPTR_Y = IntPtr.Add(baseAddress, 0x1FC0C74);
            }
            else
            {
                ReplayeInterfacePTR = IntPtr.Add(baseAddress, 0x1E90138);
                WorldPTR = IntPtr.Add(baseAddress, 0x2366EC8);
                AmmoPTR = IntPtr.Add(baseAddress, 0xE88EB9);
                ClipPTR = IntPtr.Add(baseAddress, 0xE88E74);
                BlipPTR = IntPtr.Add(baseAddress, 0x1F9E750);
                PlayerPTR = IntPtr.Add(baseAddress, 0x1CE0AA0);
                WaypointPTR_X = IntPtr.Add(baseAddress, 0x1FBCAE0);
                WaypointPTR_Y = IntPtr.Add(baseAddress, 0x1FBCAE4);
            }

            pedListPTR = Base.GetPtr(Base.ReplayeInterfacePTR, new int[] { 0x18 });
            World.Refresh();
            Players.Refresh();
        }

        public static long GetPointer(IntPtr pointer, int[] offsets, bool debug = false)
        {
            try
            {
                IntPtr pointedto = pointer;
                foreach (int offset in offsets)
                {
                    IntPtr tmpPointed = (IntPtr)(Memory.Read<long>((long)pointedto));
                    pointedto = IntPtr.Add(tmpPointed, offset);
                    if (debug)
                    {
                        System.Windows.Forms.MessageBox.Show(tmpPointed.ToString("X") + "+" + offset.ToString("X") + " => " + pointedto.ToString("X"));
                    }
                }

                return (long)pointedto;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return 0;
            }

        }
        public static IntPtr GetPtr(IntPtr pointer, int[] offsets, bool debug = false)
        {
            try
            {
                IntPtr pointedto = pointer;
                foreach (int offset in offsets)
                {
                    IntPtr tmpPointed = (IntPtr)(Memory.Read<long>((long)pointedto));
                    pointedto = IntPtr.Add(tmpPointed, offset);
                    if (debug)
                    {
                        System.Windows.Forms.MessageBox.Show(tmpPointed.ToString("X") + "+" + offset.ToString("X") + " => " + pointedto.ToString("X"));
                    }
                }

                return pointedto;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return IntPtr.Zero;
            }
        }
    }
}
