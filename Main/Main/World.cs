using System.Collections.Generic;

namespace Main
{
    public static class World
    {
        public static ReflectStructure structs = new ReflectStructure(Base.WorldPTR, new Dictionary<string, Dictionary<int, int[]>>() {
            { "POS_X", new Dictionary<int, int[]>(){ { 4, new int[] { 0x8, 0x90} } } },
            { "POS_Y", new Dictionary<int, int[]>(){ { 4, new int[] { 0x8, 0x94 } } } },
            { "POS_Z", new Dictionary<int, int[]>(){ { 4, new int[] { 0x8, 0x98 } } } },
            { "HEALTH", new Dictionary<int, int[]>(){ { 4, new int[] { 0x8, 0x280 } } } },
            { "MAXHEALTH", new Dictionary<int, int[]>(){ { 4, new int[] { 0x8, 0x2A0 } } } },
            { "ATTACKER_BASE", new Dictionary<int, int[]>(){ { 4, new int[] { 0x8, 0x2A8 } } } },
            { "ARMOR", new Dictionary<int, int[]>(){ { 4, new int[] { 0x8, 0x14B0 } } } },

            { "RUN_SPEED", new Dictionary<int, int[]>(){ { 4, new int[] { 0x8, 0x10B8, 0x14C } } } },
            {"NICKNAME", new Dictionary<int, int[]>(){{32, new int[] {0x8, 0x10B8, 0x7C} }} },
            { "Wanted", new Dictionary<int, int[]>(){ { 4, new int[] { 0x8, 0x10B8, 0x7F8 } } } },

            {"VEHICLE_PLAYER_POS_X", new Dictionary<int, int[]>(){{4, new int[] {0x8, 0x30, 0x50 } }} },
            {"VEHICLE_PLAYER_POS_Y", new Dictionary<int, int[]>(){{4, new int[] {0x8, 0x30, 0x54 } }} },
            {"VEHICLE_PLAYER_POS_Z", new Dictionary<int, int[]>(){{4, new int[] {0x8, 0x30, 0x58} }} },

            {"IN_VEHICLE", new Dictionary<int, int[]>(){{4, new int[] {0x08, 0x146B } }} }
        });

    }
}
