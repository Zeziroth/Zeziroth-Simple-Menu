using System;

namespace Main
{
    public static class Pointer
    {
        #region WantedLevel
        //Player
        public static readonly IntPtr WantedLevel = Base.GetPtr(Base.WorldPTR, new int[] { 0x08, 0x10B8, 0x7F8 });
        #endregion
    }
}
