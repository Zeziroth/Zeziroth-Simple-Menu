using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Main
{
    public class ReflectStructure
    {
        public IntPtr _basePTR = IntPtr.Zero;
        private Dictionary<string, Dictionary<int, int[]>> _structs = null;

        public ReflectStructure(IntPtr basePTR, Dictionary<string, Dictionary<int, int[]>> structs)
        {
            _basePTR = basePTR;
            _structs = structs;
        }

        public dynamic GetValue<T>(string s)
        {
            try
            {
                if (_structs.ContainsKey(s))
                {
                    Dictionary<int, int[]> structDetails = _structs[s];
                    int bufferSize = structDetails.ElementAt(0).Key;
                    int[] offsets = structDetails.ElementAt(0).Value;

                    IntPtr memoryLocation = Base.GetPtr(_basePTR, offsets);
                    //byte[] buffer = Memory.ReadBytes(memoryLocation.ToInt64(), bufferSize); ;

                    if (s == "NICKNAME")
                    {
                        return Memory.ReadOld<T>(memoryLocation.ToInt64(), bufferSize);
                    }
                    else
                    {
                        return Memory.Read<T>(memoryLocation.ToInt64());
                    }

                }
                return (T)Convert.ChangeType("0", typeof(T));
            }
            catch
            {
                return (T)Convert.ChangeType("0", typeof(T));
            }

            
        }

        public void SetValue(string s, dynamic value)
        {
            try
            {
                if (_structs.ContainsKey(s))
                {
                    Dictionary<int, int[]> structDetails = _structs[s];
                    int bufferSize = structDetails.ElementAt(0).Key;
                    int[] offsets = structDetails.ElementAt(0).Value;

                    IntPtr memoryLocation = Base.GetPtr(_basePTR, offsets);
                    Memory.WriteBytes(memoryLocation.ToInt64(), value);
                }
            }
            catch { }
        }
    }
}
