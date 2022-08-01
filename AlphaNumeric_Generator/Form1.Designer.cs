namespace AlphaNumeric_Generator
{
    partial class AlpaNumeric_Generator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textScripts = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.Clear_Scripts = new System.Windows.Forms.Button();
            this.Load_Profile = new System.Windows.Forms.Button();
            this.Profile = new System.Windows.Forms.ComboBox();
            this.Value = new System.Windows.Forms.TextBox();
            this.Find_Element = new System.Windows.Forms.Button();
            this.Click_Element = new System.Windows.Forms.Button();
            this.panel_Body = new System.Windows.Forms.Panel();
            this.Count = new System.Windows.Forms.TextBox();
            this.Sets = new System.Windows.Forms.TextBox();
            this.Threadnum = new System.Windows.Forms.TextBox();
            this.Threadi1 = new System.Windows.Forms.TextBox();
            this.Threadi0 = new System.Windows.Forms.TextBox();
            this.Threadi2 = new System.Windows.Forms.TextBox();
            this.Threadi3 = new System.Windows.Forms.TextBox();
            this.Threadi4 = new System.Windows.Forms.TextBox();
            this.Duplicate = new System.Windows.Forms.TextBox();
            this.Panel_Custom = new System.Windows.Forms.Panel();
            this.Win_Index = new System.Windows.Forms.TextBox();
            this.WinCheck = new System.Windows.Forms.Button();
            this.Head = new System.Windows.Forms.TextBox();
            this.Console = new System.Windows.Forms.TextBox();
            this.Help = new System.Windows.Forms.Button();
            this.Xpand = new System.Windows.Forms.Button();
            this.Always_Top = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.helpProvider2 = new System.Windows.Forms.HelpProvider();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel_Body.SuspendLayout();
            this.Panel_Custom.SuspendLayout();
            this.SuspendLayout();
            // 
            // textScripts
            // 
            this.textScripts.AllowDrop = true;
            this.textScripts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textScripts.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textScripts.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textScripts.Location = new System.Drawing.Point(7, 54);
            this.textScripts.Margin = new System.Windows.Forms.Padding(1, 1, 1, 3);
            this.textScripts.Multiline = true;
            this.textScripts.Name = "textScripts";
            this.textScripts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textScripts.Size = new System.Drawing.Size(339, 76);
            this.textScripts.TabIndex = 0;
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Start.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Start.Location = new System.Drawing.Point(278, 27);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(68, 25);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Clear_Scripts
            // 
            this.Clear_Scripts.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Clear_Scripts.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Clear_Scripts.Location = new System.Drawing.Point(293, 27);
            this.Clear_Scripts.Margin = new System.Windows.Forms.Padding(1);
            this.Clear_Scripts.Name = "Clear_Scripts";
            this.Clear_Scripts.Size = new System.Drawing.Size(45, 23);
            this.Clear_Scripts.TabIndex = 4;
            this.Clear_Scripts.Text = "Clear";
            this.Clear_Scripts.UseVisualStyleBackColor = false;
            this.Clear_Scripts.Click += new System.EventHandler(this.Clear_Scripts_Click);
            // 
            // Load_Profile
            // 
            this.Load_Profile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Load_Profile.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Load_Profile.Location = new System.Drawing.Point(200, 27);
            this.Load_Profile.Name = "Load_Profile";
            this.Load_Profile.Size = new System.Drawing.Size(75, 25);
            this.Load_Profile.TabIndex = 9;
            this.Load_Profile.Text = "Load_Profile";
            this.Load_Profile.UseVisualStyleBackColor = false;
            this.Load_Profile.Click += new System.EventHandler(this.Load_Profile_Click);
            // 
            // Profile
            // 
            this.Profile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Profile.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Profile.FormattingEnabled = true;
            this.Profile.Location = new System.Drawing.Point(59, 29);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(135, 21);
            this.Profile.TabIndex = 10;
            this.Profile.SelectedIndexChanged += new System.EventHandler(this.Profile_SelectedIndexChanged);
            // 
            // Value
            // 
            this.Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Value.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value.Location = new System.Drawing.Point(3, 27);
            this.Value.Margin = new System.Windows.Forms.Padding(1);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(200, 21);
            this.Value.TabIndex = 11;
            this.Value.TextChanged += new System.EventHandler(this.Value_TextChanged);
            // 
            // Find_Element
            // 
            this.Find_Element.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Find_Element.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Find_Element.Location = new System.Drawing.Point(205, 27);
            this.Find_Element.Margin = new System.Windows.Forms.Padding(1);
            this.Find_Element.Name = "Find_Element";
            this.Find_Element.Size = new System.Drawing.Size(45, 23);
            this.Find_Element.TabIndex = 12;
            this.Find_Element.Text = "Find";
            this.Find_Element.UseVisualStyleBackColor = false;
            this.Find_Element.Click += new System.EventHandler(this.Find_Element_Click);
            // 
            // Click_Element
            // 
            this.Click_Element.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Click_Element.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Click_Element.Location = new System.Drawing.Point(250, 27);
            this.Click_Element.Margin = new System.Windows.Forms.Padding(1);
            this.Click_Element.Name = "Click_Element";
            this.Click_Element.Size = new System.Drawing.Size(45, 23);
            this.Click_Element.TabIndex = 13;
            this.Click_Element.Text = "Click";
            this.Click_Element.UseVisualStyleBackColor = false;
            this.Click_Element.Click += new System.EventHandler(this.Click_Element_Click);
            // 
            // panel_Body
            // 
            this.panel_Body.BackColor = System.Drawing.Color.DarkCyan;
            this.panel_Body.Controls.Add(this.Count);
            this.panel_Body.Controls.Add(this.Sets);
            this.panel_Body.Controls.Add(this.Threadnum);
            this.panel_Body.Controls.Add(this.Threadi1);
            this.panel_Body.Controls.Add(this.Threadi0);
            this.panel_Body.Controls.Add(this.Threadi2);
            this.panel_Body.Controls.Add(this.Threadi3);
            this.panel_Body.Controls.Add(this.Threadi4);
            this.panel_Body.Controls.Add(this.Start);
            this.panel_Body.Controls.Add(this.Duplicate);
            this.panel_Body.Controls.Add(this.Panel_Custom);
            this.panel_Body.Controls.Add(this.textScripts);
            this.panel_Body.Controls.Add(this.Xpand);
            this.panel_Body.Controls.Add(this.Always_Top);
            this.panel_Body.Controls.Add(this.Minimize);
            this.panel_Body.Controls.Add(this.Exit);
            this.panel_Body.Controls.Add(this.Profile);
            this.panel_Body.Controls.Add(this.Load_Profile);
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(0, 0);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(353, 229);
            this.panel_Body.TabIndex = 15;
            this.panel_Body.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Body_MouseDown);
            this.panel_Body.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Body_MouseMove);
            this.panel_Body.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_Body_MouseUp);
            // 
            // Count
            // 
            this.Count.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Count.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Count.Location = new System.Drawing.Point(56, 4);
            this.Count.MaximumSize = new System.Drawing.Size(50, 20);
            this.Count.Multiline = true;
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(17, 19);
            this.Count.TabIndex = 37;
            this.Count.Text = "0";
            // 
            // Sets
            // 
            this.Sets.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Sets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sets.Location = new System.Drawing.Point(7, 4);
            this.Sets.Multiline = true;
            this.Sets.Name = "Sets";
            this.Sets.Size = new System.Drawing.Size(46, 19);
            this.Sets.TabIndex = 36;
            this.Sets.Text = "1000";
            // 
            // Threadnum
            // 
            this.Threadnum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Threadnum.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Threadnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Threadnum.Location = new System.Drawing.Point(77, 3);
            this.Threadnum.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.Threadnum.Multiline = true;
            this.Threadnum.Name = "Threadnum";
            this.Threadnum.Size = new System.Drawing.Size(25, 20);
            this.Threadnum.TabIndex = 35;
            this.Threadnum.Text = "1";
            this.Threadnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Threadnum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Threadnum_KeyDown);
            // 
            // Threadi1
            // 
            this.Threadi1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Threadi1.BackColor = System.Drawing.Color.SpringGreen;
            this.Threadi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Threadi1.Location = new System.Drawing.Point(122, 3);
            this.Threadi1.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.Threadi1.Multiline = true;
            this.Threadi1.Name = "Threadi1";
            this.Threadi1.Size = new System.Drawing.Size(16, 20);
            this.Threadi1.TabIndex = 34;
            this.Threadi1.Text = "1";
            this.Threadi1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Threadi0
            // 
            this.Threadi0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Threadi0.BackColor = System.Drawing.Color.SpringGreen;
            this.Threadi0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Threadi0.Location = new System.Drawing.Point(104, 3);
            this.Threadi0.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.Threadi0.Multiline = true;
            this.Threadi0.Name = "Threadi0";
            this.Threadi0.Size = new System.Drawing.Size(16, 20);
            this.Threadi0.TabIndex = 33;
            this.Threadi0.Text = "0";
            this.Threadi0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Threadi2
            // 
            this.Threadi2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Threadi2.BackColor = System.Drawing.Color.SpringGreen;
            this.Threadi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Threadi2.Location = new System.Drawing.Point(140, 3);
            this.Threadi2.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.Threadi2.Multiline = true;
            this.Threadi2.Name = "Threadi2";
            this.Threadi2.Size = new System.Drawing.Size(16, 20);
            this.Threadi2.TabIndex = 32;
            this.Threadi2.Text = "2";
            this.Threadi2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Threadi3
            // 
            this.Threadi3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Threadi3.BackColor = System.Drawing.Color.SpringGreen;
            this.Threadi3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Threadi3.Location = new System.Drawing.Point(158, 3);
            this.Threadi3.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.Threadi3.Multiline = true;
            this.Threadi3.Name = "Threadi3";
            this.Threadi3.Size = new System.Drawing.Size(16, 20);
            this.Threadi3.TabIndex = 31;
            this.Threadi3.Text = "3";
            this.Threadi3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Threadi4
            // 
            this.Threadi4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Threadi4.BackColor = System.Drawing.Color.SpringGreen;
            this.Threadi4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Threadi4.Location = new System.Drawing.Point(178, 3);
            this.Threadi4.Multiline = true;
            this.Threadi4.Name = "Threadi4";
            this.Threadi4.Size = new System.Drawing.Size(16, 20);
            this.Threadi4.TabIndex = 30;
            this.Threadi4.Text = "4";
            this.Threadi4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Duplicate
            // 
            this.Duplicate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Duplicate.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Duplicate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duplicate.Location = new System.Drawing.Point(200, 3);
            this.Duplicate.Multiline = true;
            this.Duplicate.Name = "Duplicate";
            this.Duplicate.Size = new System.Drawing.Size(73, 20);
            this.Duplicate.TabIndex = 29;
            this.Duplicate.Text = "Duplicates";
            // 
            // Panel_Custom
            // 
            this.Panel_Custom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Custom.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Panel_Custom.Controls.Add(this.Win_Index);
            this.Panel_Custom.Controls.Add(this.WinCheck);
            this.Panel_Custom.Controls.Add(this.Head);
            this.Panel_Custom.Controls.Add(this.Console);
            this.Panel_Custom.Controls.Add(this.Help);
            this.Panel_Custom.Controls.Add(this.Click_Element);
            this.Panel_Custom.Controls.Add(this.Find_Element);
            this.Panel_Custom.Controls.Add(this.Value);
            this.Panel_Custom.Controls.Add(this.Clear_Scripts);
            this.Panel_Custom.Location = new System.Drawing.Point(7, 138);
            this.Panel_Custom.Name = "Panel_Custom";
            this.Panel_Custom.Size = new System.Drawing.Size(339, 76);
            this.Panel_Custom.TabIndex = 27;
            // 
            // Win_Index
            // 
            this.Win_Index.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Win_Index.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Win_Index.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Win_Index.Location = new System.Drawing.Point(205, 50);
            this.Win_Index.Multiline = true;
            this.Win_Index.Name = "Win_Index";
            this.Win_Index.Size = new System.Drawing.Size(61, 23);
            this.Win_Index.TabIndex = 28;
            this.Win_Index.Text = "0";
            this.Win_Index.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Win_Index_KeyDown);
            // 
            // WinCheck
            // 
            this.WinCheck.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.WinCheck.BackColor = System.Drawing.Color.PaleTurquoise;
            this.WinCheck.Location = new System.Drawing.Point(271, 50);
            this.WinCheck.Name = "WinCheck";
            this.WinCheck.Size = new System.Drawing.Size(67, 25);
            this.WinCheck.TabIndex = 28;
            this.WinCheck.Text = "WinCheck";
            this.WinCheck.UseVisualStyleBackColor = false;
            this.WinCheck.Click += new System.EventHandler(this.WinCheck_Click);
            // 
            // Head
            // 
            this.Head.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Head.BackColor = System.Drawing.Color.DarkCyan;
            this.Head.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Head.Location = new System.Drawing.Point(46, 50);
            this.Head.Multiline = true;
            this.Head.Name = "Head";
            this.Head.Size = new System.Drawing.Size(120, 25);
            this.Head.TabIndex = 28;
            this.Head.Text = "Normal_Mode";
            // 
            // Console
            // 
            this.Console.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Console.AutoCompleteCustomSource.AddRange(new string[] {
            "Show Status",
            "Show Configs",
            "Set Q",
            "Set Sound",
            "Set Profile",
            "Show Xpaths",
            "Config_Editor",
            "Stop",
            "Values",
            "Headless_ON",
            "Headless_OFF",
            "Goto_Dash",
            "Backup_Config",
            "Rewrite"});
            this.Console.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Console.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Console.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Console.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Console.Location = new System.Drawing.Point(3, 3);
            this.Console.Name = "Console";
            this.Console.Size = new System.Drawing.Size(333, 20);
            this.Console.TabIndex = 26;
            this.Console.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Console_KeyDown);
            // 
            // Help
            // 
            this.Help.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Help.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Help.Location = new System.Drawing.Point(0, 50);
            this.Help.Margin = new System.Windows.Forms.Padding(1);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(46, 25);
            this.Help.TabIndex = 25;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = false;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // Xpand
            // 
            this.Xpand.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Xpand.Location = new System.Drawing.Point(7, 29);
            this.Xpand.Name = "Xpand";
            this.Xpand.Size = new System.Drawing.Size(46, 23);
            this.Xpand.TabIndex = 22;
            this.Xpand.Text = "Xpand";
            this.Xpand.UseVisualStyleBackColor = false;
            this.Xpand.Click += new System.EventHandler(this.Expand_Click);
            // 
            // Always_Top
            // 
            this.Always_Top.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Always_Top.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Always_Top.ForeColor = System.Drawing.Color.Red;
            this.Always_Top.Location = new System.Drawing.Point(278, 0);
            this.Always_Top.Name = "Always_Top";
            this.Always_Top.Size = new System.Drawing.Size(25, 22);
            this.Always_Top.TabIndex = 17;
            this.Always_Top.Text = "T";
            this.Always_Top.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Always_Top.UseVisualStyleBackColor = true;
            this.Always_Top.Click += new System.EventHandler(this.Always_Top_Click);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.Red;
            this.Minimize.Location = new System.Drawing.Point(303, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(25, 22);
            this.Minimize.TabIndex = 16;
            this.Minimize.Text = "---";
            this.Minimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Red;
            this.Exit.Location = new System.Drawing.Point(328, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(25, 22);
            this.Exit.TabIndex = 15;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Close_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // AlpaNumeric_Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(353, 229);
            this.Controls.Add(this.panel_Body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(350, 150);
            this.Name = "AlpaNumeric_Generator";
            this.Text = "Task_Grabber";
            this.Load += new System.EventHandler(this.AlpaNumeric_Generator_Load);
            this.panel_Body.ResumeLayout(false);
            this.panel_Body.PerformLayout();
            this.Panel_Custom.ResumeLayout(false);
            this.Panel_Custom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Clear_Scripts;
        private System.Windows.Forms.Button Load_Profile;
        private System.Windows.Forms.ComboBox Profile;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.Button Find_Element;
        private System.Windows.Forms.Button Click_Element;
        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Button Always_Top;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Xpand;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.TextBox Console;
        private System.Windows.Forms.Panel Panel_Custom;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.HelpProvider helpProvider2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        public System.Windows.Forms.TextBox textScripts;
        private System.Windows.Forms.Button WinCheck;
        private System.Windows.Forms.TextBox Win_Index;
        private System.Windows.Forms.TextBox Head;
        private System.Windows.Forms.TextBox Duplicate;
        private System.Windows.Forms.TextBox Threadi3;
        private System.Windows.Forms.TextBox Threadi4;
        private System.Windows.Forms.TextBox Threadi1;
        private System.Windows.Forms.TextBox Threadi0;
        private System.Windows.Forms.TextBox Threadi2;
        private System.Windows.Forms.TextBox Threadnum;
        private System.Windows.Forms.TextBox Sets;
        private System.Windows.Forms.TextBox Count;
    }
}

