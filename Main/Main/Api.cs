using Main.MemoryManagement;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace Main
{
    public class Api
    {

        private bool rphacking = false;
        private bool nopolice = false;
        private bool godmode = false;
        private bool vGodmode = false;
        private bool sessionalarm = false;
        private bool untouchable = false;
        private bool peddrop = false;
        private bool antiAFK = false;

        [Flags]
        public enum ThreadAccess : int
        {
            TERMINATE = (0x0001),
            SUSPEND_RESUME = (0x0002),
            GET_CONTEXT = (0x0008),
            SET_CONTEXT = (0x0010),
            SET_INFORMATION = (0x0020),
            QUERY_INFORMATION = (0x0040),
            SET_THREAD_TOKEN = (0x0080),
            IMPERSONATE = (0x0100),
            DIRECT_IMPERSONATION = (0x0200)
        }

        [DllImport("kernel32.dll")]
        static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);
        [DllImport("kernel32.dll")]
        static extern uint SuspendThread(IntPtr hThread);
        [DllImport("kernel32.dll")]
        static extern int ResumeThread(IntPtr hThread);
        [DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool CloseHandle(IntPtr handle);


        private static void SuspendProcess(string pName)
        {
            var process = Process.GetProcessesByName(pName)[0];

            if (process.ProcessName == string.Empty)
                return;

            foreach (ProcessThread pT in process.Threads)
            {
                IntPtr pOpenThread = OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)pT.Id);

                if (pOpenThread == IntPtr.Zero)
                {
                    continue;
                }

                SuspendThread(pOpenThread);

                CloseHandle(pOpenThread);
            }
        }

        public static void ResumeProcess(string pName)
        {
            var process = Process.GetProcessesByName(pName)[0];

            if (process.ProcessName == string.Empty)
                return;

            foreach (ProcessThread pT in process.Threads)
            {
                IntPtr pOpenThread = OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)pT.Id);

                if (pOpenThread == IntPtr.Zero)
                {
                    continue;
                }

                var suspendCount = 0;
                do
                {
                    suspendCount = ResumeThread(pOpenThread);
                } while (suspendCount > 0);

                CloseHandle(pOpenThread);
            }
        }

        public Api(IProcessMethods processMethods, AbstractGameProcess gameProcess)
        {
            gameProcess.Refresh();
        }

        public void PEDDrop_Start()
        {
            peddrop = true;
            float x = World.structs.GetValue<float>("POS_X");
            float y = World.structs.GetValue<float>("POS_Y");
            float z = World.structs.GetValue<float>("POS_Z");

            while (peddrop)
            {
                try
                {
                    IntPtr PEDCount = Base.GetPtr(Base.pedListPTR, new int[] { 0x110 });
                    int maxPED = Memory.Read<int>(PEDCount.ToInt64());
                    IntPtr v26 = Base.GetPtr(Base.pedListPTR, new int[] { 0x100 });
                    IntPtr localPlayer = Base.GetPtr(Base.WorldPTR, new int[] { 0x8 });

                    for (int i = 0; i < maxPED; i++)
                    {
                        //Thanks to kiddion
                        IntPtr v6 = Base.GetPtr(v26, new int[] { i * 0x10 });
                        IntPtr v24 = Base.GetPtr(v6, new int[] { 0x30 });
                        IntPtr v23 = Base.GetPtr(v6, new int[] { 0x20 });
                        IntPtr v5 = Base.GetPtr(v23, new int[] { 0x270 });

                        if (Memory.Read<byte>(v5.ToInt64()) == 77)
                        {
                            GTA5Entity ped = new GTA5Entity(v6);
                            if (ped.Get_Health() > 200f || ped.Get_Health() == 0f) continue;
                            ped.structs.SetValue("iCash", (int) Form1.frm.Numeric_PED_Value.Value);

                            ped.Kill();
                            ped.TeleportTo(x, y, z);
                        }
                    }
                }
                catch
                {
                    continue;
                }
            }
        }
        public void AntiAFK_Start()
        {
            antiAFK = true;
            float x = World.structs.GetValue<float>("POS_X");
            float y = World.structs.GetValue<float>("POS_Y");
            float z = World.structs.GetValue<float>("POS_Z");
            bool up = true;
            while (antiAFK)
            {
                z = up ? z + 0.1f : z -0.1f;
                up = !up;
                TPToCoords(x,y,z);
                Thread.Sleep(60000);
            }
        }
        public void AntiAFK_Stop()
        {
            antiAFK = false;
        }
        public void PEDDrop_Stop()
        {
            peddrop = false;
        }
        public Int32 GetWantedLevel()
        {
            return World.structs.GetValue<int>("Wanted");
        }
        public void SetWantedLevel(Int32 value)
        {
            World.structs.SetValue("Wanted", value);
        }
        public void VGodmode()
        {
            vGodmode = true;

            while (vGodmode)
            {
                Vehicle vehicle = Vehicle.CurrenVehicle();
                if (vehicle != null)
                {
                    vehicle.Set_Health(1000f);
                }
                Thread.Sleep(50);
            }
        }
        public void VGodmode_Stop()
        {
            vGodmode = false;
        }
        public void Godmode()
        {
            godmode = true;

            while (godmode)
            {
                try
                {
                    World.structs.SetValue("HEALTH", World.structs.GetValue<float>("MAXHEALTH"));

                    Thread.Sleep((int)(Form1.frm.Numeric_Refill_HP.Value * 1000));
                }
                catch
                {
                    continue;
                }
            }

            World.structs.SetValue("HEALTH", World.structs.GetValue<float>("MAXHEALTH"));
        }
        public void Godmode_Stop()
        {
            godmode = false;
        }
        public void NoPolice()
        {
            nopolice = true;

            while (nopolice)
            {
                try
                {
                    if (GetWantedLevel() > 0)
                    {
                        SetWantedLevel(0);
                    }
                    Thread.Sleep(500);
                }
                catch
                {
                    continue;
                }
            }

            SetWantedLevel(0);
        }
        public void StopNoPolice()
        {
            nopolice = false;
        }


        public void StartRP()
        {
            rphacking = true;

            while (rphacking)
            {
                try
                {
                    SetWantedLevel(5);
                    Thread.Sleep(Settings.RP_SPEED);
                    SetWantedLevel(0);
                    Thread.Sleep(Settings.RP_SPEED);
                }
                catch
                {
                    continue;
                }
            }

            SetWantedLevel(0);
        }
        public void TP_Waypoint()
        {
            float x = Memory.Read<float>(Base.WaypointPTR_X.ToInt64());
            float y = Memory.Read<float>(Base.WaypointPTR_Y.ToInt64());

            if (x != 64000f && y != 64000f)
            {
                TPToCoords(x, y);
            }
        }
        public void Untouchable_Start()
        {
            untouchable = true;

            while (untouchable)
            {
                try
                {
                    List<GTA5Entity> attackers = GTA5Entity.GetAttackers();

                    foreach (GTA5Entity attacker in attackers)
                    {
                        attacker.KillAll();
                    }

                    Thread.Sleep(300);
                }
                catch
                {
                    continue;
                }
            }
        }

        public void Untouchable_Stop()
        {
            untouchable = false;
        }
        private void InfAmmo(bool restore = false)
        {
            byte[] cur = Memory.Read<byte[]>(Base.AmmoPTR.ToInt64());
            byte[] opcode = new byte[3] { 65, 43, 209 };

            if (restore)
            {
                if (cur[0] != opcode[0])
                {
                    Memory.WriteBytes(Base.AmmoPTR.ToInt64(), opcode);
                }
                return;
            }

            if (cur[0] != 144)
            {
                Memory.WriteNops(Base.AmmoPTR.ToInt64(), 3);
            }
        }

        public void InfAmmo_Start()
        {
            InfAmmo();
        }
        public void InfAmmo_Stop()
        {
            InfAmmo(true);
        }
        private void NoReload(bool restore = false)
        {
            byte[] cur = Memory.Read<byte[]>(Base.ClipPTR.ToInt64());
            byte[] opcode = new byte[3] { 65, 43, 201 };

            if (restore)
            {
                if (cur[0] != opcode[0])
                {
                    Memory.WriteBytes(Base.ClipPTR.ToInt64(), opcode);
                }
                return;
            }

            if (cur[0] != 144)
            {
                Memory.WriteNops(Base.ClipPTR.ToInt64(), 3);
            }
        }

        public void NoReload_Start()
        {
            NoReload();
        }
        public void NoReload_Stop()
        {
            NoReload(true);
        }
        public void SessionAlarm()
        {
            sessionalarm = true;
            bool suspending = false;

            while (sessionalarm)
            {
                try
                {
                    int players = Players.structs.GetValue<int>("Playercount");

                    if (players > Form1.frm.NumericUpDown_Playerlimit.Value)
                    {
                        Invoker.SetText(Form1.frm.Label_Alarm, (players - 1) + " other players in your session!", "Red");
                        System.Media.SystemSounds.Hand.Play();
                        Thread.Sleep(500);

                        if (!suspending && Form1.frm.Toggle_NewSession.Checked)
                        {
                            suspending = true;
                            SuspendProcess("GTA5");

                            for (int i = 0; i < 12; i++)
                            {
                                Invoker.SetText(Form1.frm.Label_Alarm, "Switching to solo session (" + (12 - i) + ")");
                                Thread.Sleep(1000);
                            }

                            ResumeProcess("GTA5");
                        }
                    }
                    else
                    {
                        suspending = false;
                        Invoker.SetText(Form1.frm.Label_Alarm, "");
                    }
                }
                catch
                {
                    continue;
                }
            }
            Invoker.SetText(Form1.frm.Label_Alarm, "");
        }
        public void StopSessionAlarm()
        {
            sessionalarm = false;
        }

        public void TPToObject(GTAObject obj)
        {
            if (obj.ID() > 0)
            {
                if (World.structs.GetValue<int>("IN_VEHICLE") == 0)
                {
                    Vehicle vehicle = Vehicle.CurrenVehicle();
                    if (vehicle != null)
                    {
                        vehicle.Set_PosX(obj.Pos_X());
                        vehicle.Set_PosY(obj.Pos_Y());
                        vehicle.Set_PosZ(-210f);
                    }

                }

                World.structs.SetValue("POS_X", obj.Pos_X());
                World.structs.SetValue("POS_Y", obj.Pos_Y());
                World.structs.SetValue("POS_Z", -210f);
                return;
            }
        }
        public void TPToCoords(float x, float y)
        {
            TPToCoords(x, y, -210f);
        }
        public void TPToCoords(float x, float y, float z)
        {
            if (World.structs.GetValue<int>("IN_VEHICLE") == 0)
            {
                Vehicle vehicle = Vehicle.CurrenVehicle();
                if (vehicle != null)
                {
                    vehicle.Set_PosX(x);
                    vehicle.Set_PosY(y);
                    vehicle.Set_PosZ(-210f);

                    World.structs.SetValue("POS_X", x);
                    World.structs.SetValue("POS_Y", y);
                    World.structs.SetValue("POS_Z", z);
                }
            }
            World.structs.SetValue("POS_X", x);
            World.structs.SetValue("POS_Y", y);
            World.structs.SetValue("POS_Z", z);
        }
        public void StopRP()
        {
            rphacking = false;
        }
    }
}