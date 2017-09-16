namespace Main
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton3 = new MetroFramework.Controls.MetroRadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrackBar_Label = new MetroFramework.Controls.MetroLabel();
            this.Toggle_Alarm = new MetroFramework.Controls.MetroToggle();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.Toggle_RP = new MetroFramework.Controls.MetroToggle();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.Toggle_Wanted = new MetroFramework.Controls.MetroToggle();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.Toggle_Godmode = new MetroFramework.Controls.MetroToggle();
            this.Label_Alarm = new System.Windows.Forms.Label();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.Toggle_NewSession = new MetroFramework.Controls.MetroToggle();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.NumericUpDown_Playerlimit = new System.Windows.Forms.NumericUpDown();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.Toggle_NoReload = new MetroFramework.Controls.MetroToggle();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.Toggle_InfAmmo = new MetroFramework.Controls.MetroToggle();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.Toggle_Untouchable = new MetroFramework.Controls.MetroToggle();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.NumericUpDown_Wantedlevel = new System.Windows.Forms.NumericUpDown();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Toggle_FastShoot = new MetroFramework.Controls.MetroToggle();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Toggle_Ped_Drop = new MetroFramework.Controls.MetroToggle();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Playerlimit)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Wantedlevel)).BeginInit();
            this.SuspendLayout();
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Checked = true;
            this.metroRadioButton1.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.metroRadioButton1.Location = new System.Drawing.Point(321, 108);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(77, 25);
            this.metroRadioButton1.TabIndex = 2;
            this.metroRadioButton1.TabStop = true;
            this.metroRadioButton1.Text = "SLOW";
            this.metroRadioButton1.UseSelectable = true;
            this.metroRadioButton1.Visible = false;
            this.metroRadioButton1.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.metroRadioButton2.Location = new System.Drawing.Point(406, 108);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(99, 25);
            this.metroRadioButton2.TabIndex = 3;
            this.metroRadioButton2.Text = "MEDIUM";
            this.metroRadioButton2.UseSelectable = true;
            this.metroRadioButton2.Visible = false;
            this.metroRadioButton2.CheckedChanged += new System.EventHandler(this.metroRadioButton2_CheckedChanged);
            // 
            // metroRadioButton3
            // 
            this.metroRadioButton3.AutoSize = true;
            this.metroRadioButton3.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.metroRadioButton3.Location = new System.Drawing.Point(511, 108);
            this.metroRadioButton3.Name = "metroRadioButton3";
            this.metroRadioButton3.Size = new System.Drawing.Size(68, 25);
            this.metroRadioButton3.TabIndex = 4;
            this.metroRadioButton3.Text = "FAST";
            this.metroRadioButton3.UseSelectable = true;
            this.metroRadioButton3.Visible = false;
            this.metroRadioButton3.CheckedChanged += new System.EventHandler(this.metroRadioButton3_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(487, 331);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "X Pos";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Y Pos";
            this.columnHeader2.Width = 150;
            // 
            // TrackBar_Label
            // 
            this.TrackBar_Label.AutoSize = true;
            this.TrackBar_Label.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.TrackBar_Label.Location = new System.Drawing.Point(312, 317);
            this.TrackBar_Label.Name = "TrackBar_Label";
            this.TrackBar_Label.Size = new System.Drawing.Size(45, 19);
            this.TrackBar_Label.TabIndex = 15;
            this.TrackBar_Label.Text = "x1.00";
            // 
            // Toggle_Alarm
            // 
            this.Toggle_Alarm.AutoSize = true;
            this.Toggle_Alarm.Enabled = false;
            this.Toggle_Alarm.Location = new System.Drawing.Point(226, 180);
            this.Toggle_Alarm.Name = "Toggle_Alarm";
            this.Toggle_Alarm.Size = new System.Drawing.Size(80, 17);
            this.Toggle_Alarm.TabIndex = 16;
            this.Toggle_Alarm.Text = "Aus";
            this.Toggle_Alarm.UseSelectable = true;
            this.Toggle_Alarm.CheckedChanged += new System.EventHandler(this.Toggle_Alarm_CheckedChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(23, 178);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(158, 19);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "Publicsession alarm";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Toggle_RP
            // 
            this.Toggle_RP.AutoSize = true;
            this.Toggle_RP.Enabled = false;
            this.Toggle_RP.Location = new System.Drawing.Point(226, 111);
            this.Toggle_RP.Name = "Toggle_RP";
            this.Toggle_RP.Size = new System.Drawing.Size(80, 17);
            this.Toggle_RP.TabIndex = 18;
            this.Toggle_RP.Text = "Aus";
            this.Toggle_RP.UseSelectable = true;
            this.Toggle_RP.CheckedChanged += new System.EventHandler(this.Toggle_RP_CheckedChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(23, 109);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(158, 19);
            this.metroLabel4.TabIndex = 17;
            this.metroLabel4.Text = "RP Hack";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel5
            // 
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(23, 132);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(158, 19);
            this.metroLabel5.TabIndex = 17;
            this.metroLabel5.Text = "No wanted";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Toggle_Wanted
            // 
            this.Toggle_Wanted.AutoSize = true;
            this.Toggle_Wanted.Enabled = false;
            this.Toggle_Wanted.Location = new System.Drawing.Point(226, 134);
            this.Toggle_Wanted.Name = "Toggle_Wanted";
            this.Toggle_Wanted.Size = new System.Drawing.Size(80, 17);
            this.Toggle_Wanted.TabIndex = 19;
            this.Toggle_Wanted.Text = "Aus";
            this.Toggle_Wanted.UseSelectable = true;
            this.Toggle_Wanted.CheckedChanged += new System.EventHandler(this.Toggle_Wanted_CheckedChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(23, 155);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(158, 19);
            this.metroLabel6.TabIndex = 17;
            this.metroLabel6.Text = "Godmode";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Toggle_Godmode
            // 
            this.Toggle_Godmode.AutoSize = true;
            this.Toggle_Godmode.Enabled = false;
            this.Toggle_Godmode.Location = new System.Drawing.Point(226, 157);
            this.Toggle_Godmode.Name = "Toggle_Godmode";
            this.Toggle_Godmode.Size = new System.Drawing.Size(80, 17);
            this.Toggle_Godmode.TabIndex = 20;
            this.Toggle_Godmode.Text = "Aus";
            this.Toggle_Godmode.UseSelectable = true;
            this.Toggle_Godmode.CheckedChanged += new System.EventHandler(this.Toggle_Godmode_CheckedChanged);
            // 
            // Label_Alarm
            // 
            this.Label_Alarm.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Alarm.Location = new System.Drawing.Point(23, 412);
            this.Label_Alarm.Name = "Label_Alarm";
            this.Label_Alarm.Size = new System.Drawing.Size(1058, 23);
            this.Label_Alarm.TabIndex = 21;
            // 
            // metroListView1
            // 
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.metroListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Location = new System.Drawing.Point(0, 0);
            this.metroListView1.MultiSelect = false;
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(487, 331);
            this.metroListView1.TabIndex = 23;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 470;
            // 
            // metroLabel7
            // 
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(23, 201);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(197, 19);
            this.metroLabel7.TabIndex = 17;
            this.metroLabel7.Text = "On alarm -> new session";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel7.Visible = false;
            // 
            // Toggle_NewSession
            // 
            this.Toggle_NewSession.AutoSize = true;
            this.Toggle_NewSession.Location = new System.Drawing.Point(226, 203);
            this.Toggle_NewSession.Name = "Toggle_NewSession";
            this.Toggle_NewSession.Size = new System.Drawing.Size(80, 17);
            this.Toggle_NewSession.TabIndex = 16;
            this.Toggle_NewSession.Text = "Aus";
            this.Toggle_NewSession.UseSelectable = true;
            this.Toggle_NewSession.Visible = false;
            // 
            // metroLabel8
            // 
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(311, 177);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(88, 19);
            this.metroLabel8.TabIndex = 17;
            this.metroLabel8.Text = "Playerlimit";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel8.Visible = false;
            // 
            // NumericUpDown_Playerlimit
            // 
            this.NumericUpDown_Playerlimit.Location = new System.Drawing.Point(416, 177);
            this.NumericUpDown_Playerlimit.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.NumericUpDown_Playerlimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown_Playerlimit.Name = "NumericUpDown_Playerlimit";
            this.NumericUpDown_Playerlimit.Size = new System.Drawing.Size(37, 20);
            this.NumericUpDown_Playerlimit.TabIndex = 24;
            this.NumericUpDown_Playerlimit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown_Playerlimit.Visible = false;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(594, 50);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(495, 373);
            this.metroTabControl1.TabIndex = 25;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.metroPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(487, 331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Objects";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroProgressSpinner1);
            this.metroPanel1.Controls.Add(this.listView1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(487, 331);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(176, 72);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(150, 150);
            this.metroProgressSpinner1.TabIndex = 28;
            this.metroProgressSpinner1.UseSelectable = true;
            this.metroProgressSpinner1.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.metroPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(487, 331);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Players";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroListView1);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(487, 331);
            this.metroPanel2.TabIndex = 0;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel9
            // 
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(23, 224);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(197, 19);
            this.metroLabel9.TabIndex = 17;
            this.metroLabel9.Text = "No reload";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Toggle_NoReload
            // 
            this.Toggle_NoReload.AutoSize = true;
            this.Toggle_NoReload.Enabled = false;
            this.Toggle_NoReload.Location = new System.Drawing.Point(226, 226);
            this.Toggle_NoReload.Name = "Toggle_NoReload";
            this.Toggle_NoReload.Size = new System.Drawing.Size(80, 17);
            this.Toggle_NoReload.TabIndex = 16;
            this.Toggle_NoReload.Text = "Aus";
            this.Toggle_NoReload.UseSelectable = true;
            this.Toggle_NoReload.CheckedChanged += new System.EventHandler(this.Toggle_NoReload_CheckedChanged);
            // 
            // metroLabel10
            // 
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(23, 247);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(197, 19);
            this.metroLabel10.TabIndex = 17;
            this.metroLabel10.Text = "Infinite Ammo";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Toggle_InfAmmo
            // 
            this.Toggle_InfAmmo.AutoSize = true;
            this.Toggle_InfAmmo.Enabled = false;
            this.Toggle_InfAmmo.Location = new System.Drawing.Point(226, 249);
            this.Toggle_InfAmmo.Name = "Toggle_InfAmmo";
            this.Toggle_InfAmmo.Size = new System.Drawing.Size(80, 17);
            this.Toggle_InfAmmo.TabIndex = 16;
            this.Toggle_InfAmmo.Text = "Aus";
            this.Toggle_InfAmmo.UseSelectable = true;
            this.Toggle_InfAmmo.CheckedChanged += new System.EventHandler(this.Toggle_InfAmmo_CheckedChanged);
            // 
            // metroLabel11
            // 
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.Location = new System.Drawing.Point(23, 293);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(197, 19);
            this.metroLabel11.TabIndex = 17;
            this.metroLabel11.Text = "Untouchable";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Toggle_Untouchable
            // 
            this.Toggle_Untouchable.AutoSize = true;
            this.Toggle_Untouchable.Enabled = false;
            this.Toggle_Untouchable.Location = new System.Drawing.Point(226, 295);
            this.Toggle_Untouchable.Name = "Toggle_Untouchable";
            this.Toggle_Untouchable.Size = new System.Drawing.Size(80, 17);
            this.Toggle_Untouchable.TabIndex = 16;
            this.Toggle_Untouchable.Text = "Aus";
            this.Toggle_Untouchable.UseSelectable = true;
            this.Toggle_Untouchable.CheckedChanged += new System.EventHandler(this.Toggle_Untouchable_CheckedChanged);
            // 
            // metroLabel12
            // 
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.Location = new System.Drawing.Point(312, 132);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(98, 19);
            this.metroLabel12.TabIndex = 17;
            this.metroLabel12.Text = "Wantedlevel";
            this.metroLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NumericUpDown_Wantedlevel
            // 
            this.NumericUpDown_Wantedlevel.Enabled = false;
            this.NumericUpDown_Wantedlevel.Location = new System.Drawing.Point(416, 132);
            this.NumericUpDown_Wantedlevel.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumericUpDown_Wantedlevel.Name = "NumericUpDown_Wantedlevel";
            this.NumericUpDown_Wantedlevel.Size = new System.Drawing.Size(37, 20);
            this.NumericUpDown_Wantedlevel.TabIndex = 24;
            this.NumericUpDown_Wantedlevel.ValueChanged += new System.EventHandler(this.NumericUpDown_Wantedlevel_ValueChanged);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Enabled = false;
            this.metroTile1.Location = new System.Drawing.Point(23, 346);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(197, 64);
            this.metroTile1.TabIndex = 26;
            this.metroTile1.Text = "Teleport to waypoint (Purple)";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroLabel13
            // 
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel13.Location = new System.Drawing.Point(23, 317);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(197, 19);
            this.metroLabel13.TabIndex = 17;
            this.metroLabel13.Text = "Speedhack";
            this.metroLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroTrackBar1
            // 
            this.metroTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar1.Location = new System.Drawing.Point(226, 317);
            this.metroTrackBar1.Maximum = 500;
            this.metroTrackBar1.Minimum = 100;
            this.metroTrackBar1.Name = "metroTrackBar1";
            this.metroTrackBar1.Size = new System.Drawing.Size(80, 23);
            this.metroTrackBar1.TabIndex = 27;
            this.metroTrackBar1.Text = "metroTrackBar1";
            this.metroTrackBar1.Value = 100;
            this.metroTrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBar1_Scroll);
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(23, 270);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(197, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Fast shoot";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Toggle_FastShoot
            // 
            this.Toggle_FastShoot.AutoSize = true;
            this.Toggle_FastShoot.Enabled = false;
            this.Toggle_FastShoot.Location = new System.Drawing.Point(226, 272);
            this.Toggle_FastShoot.Name = "Toggle_FastShoot";
            this.Toggle_FastShoot.Size = new System.Drawing.Size(80, 17);
            this.Toggle_FastShoot.TabIndex = 16;
            this.Toggle_FastShoot.Text = "Aus";
            this.Toggle_FastShoot.UseSelectable = true;
            this.Toggle_FastShoot.CheckedChanged += new System.EventHandler(this.Toggle_FastShoot_CheckedChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(23, 86);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(197, 19);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "Money drop (ped drop)";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Toggle_Ped_Drop
            // 
            this.Toggle_Ped_Drop.AutoSize = true;
            this.Toggle_Ped_Drop.Enabled = false;
            this.Toggle_Ped_Drop.Location = new System.Drawing.Point(226, 88);
            this.Toggle_Ped_Drop.Name = "Toggle_Ped_Drop";
            this.Toggle_Ped_Drop.Size = new System.Drawing.Size(80, 17);
            this.Toggle_Ped_Drop.TabIndex = 18;
            this.Toggle_Ped_Drop.Text = "Aus";
            this.Toggle_Ped_Drop.UseSelectable = true;
            this.Toggle_Ped_Drop.CheckedChanged += new System.EventHandler(this.Toggle_Ped_Drop_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 456);
            this.Controls.Add(this.metroTrackBar1);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.Toggle_FastShoot);
            this.Controls.Add(this.Toggle_Untouchable);
            this.Controls.Add(this.Toggle_InfAmmo);
            this.Controls.Add(this.Toggle_NoReload);
            this.Controls.Add(this.Toggle_NewSession);
            this.Controls.Add(this.NumericUpDown_Wantedlevel);
            this.Controls.Add(this.NumericUpDown_Playerlimit);
            this.Controls.Add(this.Label_Alarm);
            this.Controls.Add(this.Toggle_Godmode);
            this.Controls.Add(this.Toggle_Wanted);
            this.Controls.Add(this.Toggle_Ped_Drop);
            this.Controls.Add(this.Toggle_RP);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.Toggle_Alarm);
            this.Controls.Add(this.TrackBar_Label);
            this.Controls.Add(this.metroRadioButton3);
            this.Controls.Add(this.metroRadioButton2);
            this.Controls.Add(this.metroRadioButton1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.Resizable = false;
            this.Text = "Zeziroth Simple Menu  v1.0";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Playerlimit)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Wantedlevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MetroFramework.Controls.MetroLabel TrackBar_Label;
        private MetroFramework.Controls.MetroToggle Toggle_Alarm;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroToggle Toggle_RP;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroToggle Toggle_Wanted;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroToggle Toggle_Godmode;
        internal System.Windows.Forms.Label Label_Alarm;
        private MetroFramework.Controls.MetroListView metroListView1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        internal MetroFramework.Controls.MetroToggle Toggle_NewSession;
        internal System.Windows.Forms.NumericUpDown NumericUpDown_Playerlimit;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.TabPage tabPage2;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        internal MetroFramework.Controls.MetroToggle Toggle_NoReload;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        internal MetroFramework.Controls.MetroToggle Toggle_InfAmmo;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        internal MetroFramework.Controls.MetroToggle Toggle_Untouchable;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        internal System.Windows.Forms.NumericUpDown NumericUpDown_Wantedlevel;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar1;
        internal MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        internal MetroFramework.Controls.MetroToggle Toggle_FastShoot;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroToggle Toggle_Ped_Drop;
    }
}

