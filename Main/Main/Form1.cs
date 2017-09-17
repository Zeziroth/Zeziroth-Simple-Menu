using System;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;

namespace Main
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public static Form1 frm = null;
        private static bool globalStop = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frm = this;
            Core.RunThread(Init);
        }
        private void ToggleElements(bool toggle)
        {
            Invoker.ChangeEnable(Toggle_RP, toggle);
            Invoker.ChangeEnable(Toggle_Alarm, toggle);
            Invoker.ChangeEnable(Toggle_Godmode, toggle);
            Invoker.ChangeEnable(Toggle_Wanted, toggle);
            Invoker.ChangeEnable(Toggle_NoReload, toggle);
            Invoker.ChangeEnable(Toggle_InfAmmo, toggle);
            Invoker.ChangeEnable(Toggle_Untouchable, toggle);
            Invoker.ChangeEnable(Toggle_Ped_Drop, toggle);
            Invoker.ChangeEnable(Toggle_FastShoot, toggle);
            Invoker.ChangeEnable(Toggle_Car_Godmode, toggle);
            Invoker.ChangeEnable(Tile_BurnCar, toggle);
            Invoker.ChangeEnable(Tile_RepairCar, toggle);
            Invoker.ChangeEnable(NumericUpDown_Wantedlevel, toggle);
            Invoker.ChangeEnable(metroTile1, toggle);
        }
        public void Init()
        {
            ToggleElements(false);
            Memory.api = null;
            globalStop = true;

            while (!Memory.isRunning() && Memory.api == null)
            {
                Invoker.SetText(Label_Alarm, "Please open GTA5 (SC Version)", "Red");
            }
            Base.RefreshBase();
            globalStop = false;
            Invoker.SetText(Label_Alarm, "");

            ToggleElements(true);


            Core.RunThread(LoadBlip);
            Core.RunThread(TrackVehicle);

            TrackPlayer();
        }
        private void TrackPlayer()
        {
            int oldPlayers = 0;
            while (!globalStop)
            {
                int newPlayers = Players.structs.GetValue<int>("Playercount");

                if (newPlayers != oldPlayers)
                {
                    oldPlayers = newPlayers;
                    List<Player> players = Players.GetPlayers();

                    Invoker.ClearList(metroListView1);
                    foreach (Player player in players)
                    {
                        Invoker.AddListItem(metroListView1, new ListViewItem(player.Get_Nickname()));
                    }
                }
                Thread.Sleep(500);
            }
        }
        private void TrackVehicle()
        {
            while (!globalStop)
            {
                Vehicle vehicle = Vehicle.CurrenVehicle();
                if (vehicle != null)
                {
                    float fHealth = vehicle.Get_Health();
                    fHealth = fHealth < 0f ? 0 : fHealth;

                    Invoker.SetPrgbState(metroProgressBar1, (int)fHealth, Invoker.Mode.SetValue);
                }
                Thread.Sleep(1000);
                TrackBar_Acceleration.Value = (int)(vehicle.Get_Acceleration() * 100);
                Invoker.SetText(Label_Acceleration, (TrackBar_Acceleration.Value / 100f).ToString("0.00").Replace(",", "."));
                Trackbar_Breakforce.Value = (int)(vehicle.Get_Breakforce() * 100);
                Invoker.SetText(Label_Breakforce, (Trackbar_Breakforce.Value / 100f).ToString("0.00").Replace(",", "."));
                Trackbar_Suspension.Value = (int)(vehicle.Get_Suspension() * 100);
                Invoker.SetText(Label_Suspension,(Trackbar_Suspension.Value / 100f).ToString("0.00").Replace(",", "."));
                Trackbar_Traction.Value = (int)(vehicle.Get_Traction() * 100);
                Invoker.SetText(Label_Traction, (Trackbar_Traction.Value / 100f).ToString("0.00").Replace(",", "."));
                Thread.Sleep(500);
            }
        }
        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ChangeRPSpeed();
        }

        private void ChangeRPSpeed()
        {
            if (metroRadioButton3.Checked)
            {
                Settings.RP_SPEED = 10;
            }
            else if (metroRadioButton2.Checked)
            {
                Settings.RP_SPEED = 200;
            }
            else
            {
                Settings.RP_SPEED = 500;
            }
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ChangeRPSpeed();
        }

        private void metroRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ChangeRPSpeed();
        }

        private void LoadBlip()
        {
            Invoker.ClearList(listView1);

            Invoker.ChangeVisible(metroProgressSpinner1, true);

            List<GTAObject> objects = new List<GTAObject>();
            
            for (int i = 1; i < 0x800; i++)
            {

                try
                {
                    IntPtr addr = IntPtr.Add(Base.BlipPTR, i * 8);
                    GTAObject obj = new GTAObject(addr);
                    if (obj.ID() > 0)
                    {
                        if (obj.ID() > 1000)
                        {
                            break; ;
                        }
                        objects.Add(obj);
                    }
                }
                catch { continue; }
            }

            Invoker.ProgressSpinner_SetMaximum(Form1.frm.metroProgressSpinner1, objects.Count);
            Invoker.UpdateList(listView1, true);
            int objCount = 1;

            foreach (GTAObject obj in objects)
            {
                Invoker.ProgressSpinner_SetValue(Form1.frm.metroProgressSpinner1, objCount);
                objCount++;
                ListViewItem itm = new ListViewItem();
                itm.Text = obj.ID().ToString();
                itm.SubItems.Add(obj.Pos_X().ToString());
                itm.SubItems.Add(obj.Pos_Y().ToString());
                itm.Tag = obj;
                Invoker.AddListItem(listView1, itm);
            }

            Invoker.ChangeVisible(Form1.frm.metroProgressSpinner1, false);
            Invoker.UpdateList(listView1, false);
        }
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                Memory.api.TPToCoords(float.Parse(listView1.SelectedItems[0].SubItems[1].Text), float.Parse(listView1.SelectedItems[0].SubItems[2].Text));
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Core.CloseThreads();
        }

        private void Toggle_RP_CheckedChanged(object sender, EventArgs e)
        {
            metroRadioButton1.Visible = Toggle_RP.Checked;
            metroRadioButton2.Visible = Toggle_RP.Checked;
            metroRadioButton3.Visible = Toggle_RP.Checked;

            if (Toggle_RP.Checked)
            {
                Core.RunThread(Memory.api.StartRP);
            }
            else
            {
                Core.RunThread(Memory.api.StopRP);
            }
        }

        private void Toggle_Alarm_CheckedChanged(object sender, EventArgs e)
        {
            if (Toggle_Alarm.Checked)
            {
                Core.RunThread(Memory.api.SessionAlarm);
            }
            else
            {
                Core.RunThread(Memory.api.StopSessionAlarm);
            }
            metroLabel7.Visible = Toggle_Alarm.Checked;
            metroLabel8.Visible = Toggle_Alarm.Checked;
            Toggle_NewSession.Visible = Toggle_Alarm.Checked;
            NumericUpDown_Playerlimit.Visible = Toggle_Alarm.Checked;
        }
        private void Toggle_Wanted_CheckedChanged(object sender, EventArgs e)
        {
            if (Toggle_Wanted.Checked)
            {
                Core.RunThread(Memory.api.NoPolice);
            }
            else
            {
                Core.RunThread(Memory.api.StopNoPolice);
            }
        }

        private void Toggle_Godmode_CheckedChanged(object sender, EventArgs e)
        {
            if (Toggle_Godmode.Checked)
            {
                Core.RunThread(Memory.api.Godmode);
            }
            else
            {
                Core.RunThread(Memory.api.Godmode_Stop);
            }
        }

        private void Toggle_NoReload_CheckedChanged(object sender, EventArgs e)
        {
            if (Toggle_NoReload.Checked)
            {
                Core.RunThread(Memory.api.NoReload_Start);
            }
            else
            {
                Core.RunThread(Memory.api.NoReload_Stop);
            }
        }

        private void Toggle_InfAmmo_CheckedChanged(object sender, EventArgs e)
        {
            if (Toggle_InfAmmo.Checked)
            {
                Core.RunThread(Memory.api.InfAmmo_Start);
            }
            else
            {
                Core.RunThread(Memory.api.InfAmmo_Stop);
            }
        }

        private void Toggle_Untouchable_CheckedChanged(object sender, EventArgs e)
        {
            if (Toggle_Untouchable.Checked)
            {
                Core.RunThread(Memory.api.Untouchable_Start);
            }
            else
            {
                Core.RunThread(Memory.api.Untouchable_Stop);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NumericUpDown_Wantedlevel_ValueChanged(object sender, EventArgs e)
        {
            Memory.api.SetWantedLevel((int)NumericUpDown_Wantedlevel.Value);
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Memory.api.TP_Waypoint();
        }

        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            TrackBar_Label.Text = "x" + (metroTrackBar1.Value / 100f).ToString("0.00").Replace(",", ".");
            World.structs.SetValue("RUN_SPEED", (metroTrackBar1.Value / 100f));
        }

        private void Toggle_FastShoot_CheckedChanged(object sender, EventArgs e)
        {
            Weapon.Get_CurrentWeapon().FastShoot(!Toggle_FastShoot.Checked);
        }

        private void Toggle_Ped_Drop_CheckedChanged(object sender, EventArgs e)
        {
            if (Toggle_Ped_Drop.Checked)
            {
                Core.RunThread(Memory.api.PEDDrop_Start);
            }
            else
            {
                Core.RunThread(Memory.api.PEDDrop_Stop);
            }
        }

        private void Toggle_Car_Godmode_CheckedChanged(object sender, EventArgs e)
        {
            if (Toggle_Car_Godmode.Checked)
            {
                Core.RunThread(Memory.api.VGodmode);
            }
            else
            {
                Core.RunThread(Memory.api.VGodmode_Stop);
            }
        }

        private void TrackBar_Acceleration_Scroll(object sender, ScrollEventArgs e)
        {
            Label_Acceleration.Text = (TrackBar_Acceleration.Value / 100f).ToString("0.00").Replace(",", ".");
            Vehicle vehicle = Vehicle.CurrenVehicle();

            if (vehicle != null)
            {
                vehicle.Set_Acceleration((TrackBar_Acceleration.Value / 100f));
            }
        }

        private void Trackbar_Breakforce_Scroll(object sender, ScrollEventArgs e)
        {
            Label_Breakforce.Text = (Trackbar_Breakforce.Value / 100f).ToString("0.00").Replace(",", ".");
            Vehicle vehicle = Vehicle.CurrenVehicle();

            if (vehicle != null)
            {
                vehicle.Set_Breakforce((Trackbar_Breakforce.Value / 100f));
            }
        }

        private void Trackbar_Traction_Scroll(object sender, ScrollEventArgs e)
        {
            Label_Traction.Text = (Trackbar_Traction.Value / 100f).ToString("0.00").Replace(",", ".");
            Vehicle vehicle = Vehicle.CurrenVehicle();

            if (vehicle != null)
            {
                vehicle.Set_Traction((Trackbar_Traction.Value / 100f));
            }
        }

        private void Trackbar_Suspension_Scroll(object sender, ScrollEventArgs e)
        {
            Label_Suspension.Text = (Trackbar_Suspension.Value / 100f).ToString("0.00").Replace(",", ".");
            Vehicle vehicle = Vehicle.CurrenVehicle();

            if (vehicle != null)
            {
                vehicle.Set_Suspension((Trackbar_Suspension.Value / 100f));
            }
        }

        private void Tile_BurnCar_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = Vehicle.CurrenVehicle();
            if (vehicle != null)
            {
                vehicle.Burn();
            }
        }

        private void Tile_RepairCar_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = Vehicle.CurrenVehicle();
            if (vehicle != null)
            {
                vehicle.Repair();
            }
        }
    }
}
