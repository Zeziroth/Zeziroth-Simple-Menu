using System;

namespace Main
{
    public static class Base
    {
        public static IntPtr baseAddress = Memory.ImageBase();
        public static readonly IntPtr ReplayeInterfacePTR = IntPtr.Add(baseAddress, 0x1E90138);
        public static IntPtr pedListPTR = Base.GetPtr(Base.ReplayeInterfacePTR, new int[] { 0x18 });
        public static readonly IntPtr WorldPTR = IntPtr.Add(baseAddress, 0x2366EC8);
        public static readonly IntPtr AmmoPTR = IntPtr.Add(baseAddress, 0xE88EB9);
        public static readonly IntPtr ClipPTR = IntPtr.Add(baseAddress, 0xE88E74);
        public static readonly IntPtr BlipPTR = IntPtr.Add(baseAddress, 0x1F9E750);
        public static readonly IntPtr PlayerPTR = IntPtr.Add(baseAddress, 0x1CE0AA0);
        public static readonly IntPtr WaypointPTR_X = IntPtr.Add(baseAddress, 0x1FBCAE0);
        public static readonly IntPtr WaypointPTR_Y = IntPtr.Add(baseAddress, 0x1FBCAE4);

        public static long GetPointer(IntPtr pointer, int[] offsets, bool debug = false)
        {
            try
            {
                IntPtr pointedto = pointer;
                foreach (int offset in offsets)
                {
                    IntPtr tmpPointed = (IntPtr)(Memory.Read<long>((long)pointedto, 8));
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
                    IntPtr tmpPointed = (IntPtr)(Memory.Read<long>((long)pointedto, 8));
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
