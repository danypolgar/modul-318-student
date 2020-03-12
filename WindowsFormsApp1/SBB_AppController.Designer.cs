namespace WindowsFormsApp1
{
    partial class SBB_App
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
            this.components = new System.ComponentModel.Container();
            this.tabs = new System.Windows.Forms.TabControl();
            this.welcomeTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.connectionTab = new System.Windows.Forms.TabPage();
            this.em = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.targetMailTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.connectionListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timetableTab = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timetableListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stationTab = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.stationListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.stationTextBox = new System.Windows.Forms.TextBox();
            this.mapButton = new System.Windows.Forms.Button();
            this.timetableButton = new System.Windows.Forms.Button();
            this.stationButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.swapButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabs.SuspendLayout();
            this.welcomeTab.SuspendLayout();
            this.connectionTab.SuspendLayout();
            this.timetableTab.SuspendLayout();
            this.stationTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabs.Controls.Add(this.welcomeTab);
            this.tabs.Controls.Add(this.connectionTab);
            this.tabs.Controls.Add(this.timetableTab);
            this.tabs.Controls.Add(this.stationTab);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabs.ItemSize = new System.Drawing.Size(0, 1);
            this.tabs.Location = new System.Drawing.Point(173, 0);
            this.tabs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(591, 399);
            this.tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabs.TabIndex = 10;
            this.tabs.TabStop = false;
            // 
            // welcomeTab
            // 
            this.welcomeTab.Controls.Add(this.label1);
            this.welcomeTab.Location = new System.Drawing.Point(4, 5);
            this.welcomeTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.welcomeTab.Name = "welcomeTab";
            this.welcomeTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.welcomeTab.Size = new System.Drawing.Size(583, 390);
            this.welcomeTab.TabIndex = 0;
            this.welcomeTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wilkommen";
            // 
            // connectionTab
            // 
            this.connectionTab.Controls.Add(this.em);
            this.connectionTab.Controls.Add(this.sendButton);
            this.connectionTab.Controls.Add(this.targetMailTextBox);
            this.connectionTab.Controls.Add(this.label10);
            this.connectionTab.Controls.Add(this.label9);
            this.connectionTab.Controls.Add(this.label8);
            this.connectionTab.Controls.Add(this.label7);
            this.connectionTab.Controls.Add(this.label6);
            this.connectionTab.Controls.Add(this.connectionListBox);
            this.connectionTab.Controls.Add(this.label2);
            this.connectionTab.Location = new System.Drawing.Point(4, 5);
            this.connectionTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.connectionTab.Name = "connectionTab";
            this.connectionTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.connectionTab.Size = new System.Drawing.Size(583, 390);
            this.connectionTab.TabIndex = 1;
            this.connectionTab.UseVisualStyleBackColor = true;
            // 
            // em
            // 
            this.em.AutoSize = true;
            this.em.Location = new System.Drawing.Point(395, 116);
            this.em.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.em.Name = "em";
            this.em.Size = new System.Drawing.Size(86, 13);
            this.em.TabIndex = 9;
            this.em.Text = "Empfänger Email";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(395, 163);
            this.sendButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(158, 19);
            this.sendButton.TabIndex = 8;
            this.sendButton.Text = "in Email weiterleiten";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // targetMailTextBox
            // 
            this.targetMailTextBox.Location = new System.Drawing.Point(395, 135);
            this.targetMailTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.targetMailTextBox.Name = "targetMailTextBox";
            this.targetMailTextBox.Size = new System.Drawing.Size(159, 20);
            this.targetMailTextBox.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(216, 166);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Ankunft";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(126, 166);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Startpunkt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 166);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Abfahrt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 166);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Datum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 166);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ziel";
            // 
            // connectionListBox
            // 
            this.connectionListBox.FormattingEnabled = true;
            this.connectionListBox.Location = new System.Drawing.Point(21, 189);
            this.connectionListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.connectionListBox.Name = "connectionListBox";
            this.connectionListBox.Size = new System.Drawing.Size(542, 173);
            this.connectionListBox.TabIndex = 1;
            this.connectionListBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Verbindungen";
            // 
            // timetableTab
            // 
            this.timetableTab.Controls.Add(this.label15);
            this.timetableTab.Controls.Add(this.label13);
            this.timetableTab.Controls.Add(this.label12);
            this.timetableTab.Controls.Add(this.timetableListBox);
            this.timetableTab.Controls.Add(this.label3);
            this.timetableTab.Location = new System.Drawing.Point(4, 5);
            this.timetableTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.timetableTab.Name = "timetableTab";
            this.timetableTab.Size = new System.Drawing.Size(583, 390);
            this.timetableTab.TabIndex = 2;
            this.timetableTab.Text = "tabPage3";
            this.timetableTab.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(154, 166);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Ziel";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(83, 166);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Abfahrt";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 166);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Datum";
            // 
            // timetableListBox
            // 
            this.timetableListBox.FormattingEnabled = true;
            this.timetableListBox.Location = new System.Drawing.Point(21, 189);
            this.timetableListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.timetableListBox.Name = "timetableListBox";
            this.timetableListBox.Size = new System.Drawing.Size(542, 173);
            this.timetableListBox.TabIndex = 1;
            this.timetableListBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Abfahrtstafel";
            // 
            // stationTab
            // 
            this.stationTab.Controls.Add(this.label11);
            this.stationTab.Controls.Add(this.stationListBox);
            this.stationTab.Controls.Add(this.label5);
            this.stationTab.Location = new System.Drawing.Point(4, 5);
            this.stationTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stationTab.Name = "stationTab";
            this.stationTab.Size = new System.Drawing.Size(583, 390);
            this.stationTab.TabIndex = 4;
            this.stationTab.Text = "stationTab";
            this.stationTab.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 173);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Station";
            // 
            // stationListBox
            // 
            this.stationListBox.FormattingEnabled = true;
            this.stationListBox.Location = new System.Drawing.Point(21, 189);
            this.stationListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stationListBox.Name = "stationListBox";
            this.stationListBox.Size = new System.Drawing.Size(542, 173);
            this.stationListBox.TabIndex = 1;
            this.stationListBox.TabStop = false;
            this.stationListBox.UseTabStops = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Station Namen";
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(15, 41);
            this.fromTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(130, 20);
            this.fromTextBox.TabIndex = 11;
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(15, 84);
            this.toTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(130, 20);
            this.toTextBox.TabIndex = 12;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(15, 121);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(130, 20);
            this.dateTimePicker.TabIndex = 13;
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(15, 158);
            this.timeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(130, 20);
            this.timeTextBox.TabIndex = 14;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(15, 189);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(130, 19);
            this.searchButton.TabIndex = 15;
            this.searchButton.Text = "Suchen";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // stationTextBox
            // 
            this.stationTextBox.Location = new System.Drawing.Point(15, 50);
            this.stationTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stationTextBox.Name = "stationTextBox";
            this.stationTextBox.Size = new System.Drawing.Size(130, 20);
            this.stationTextBox.TabIndex = 16;
            // 
            // mapButton
            // 
            this.mapButton.Location = new System.Drawing.Point(15, 74);
            this.mapButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mapButton.Name = "mapButton";
            this.mapButton.Size = new System.Drawing.Size(130, 19);
            this.mapButton.TabIndex = 18;
            this.mapButton.Text = "online Karte anzeigen";
            this.mapButton.UseVisualStyleBackColor = true;
            this.mapButton.Click += new System.EventHandler(this.mapButton_Click);
            // 
            // timetableButton
            // 
            this.timetableButton.Location = new System.Drawing.Point(15, 97);
            this.timetableButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.timetableButton.Name = "timetableButton";
            this.timetableButton.Size = new System.Drawing.Size(130, 19);
            this.timetableButton.TabIndex = 19;
            this.timetableButton.Text = "Abfahrtstafel der Station";
            this.timetableButton.UseVisualStyleBackColor = true;
            this.timetableButton.Click += new System.EventHandler(this.timetableButton_Click);
            // 
            // stationButton
            // 
            this.stationButton.Location = new System.Drawing.Point(15, 120);
            this.stationButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stationButton.Name = "stationButton";
            this.stationButton.Size = new System.Drawing.Size(130, 19);
            this.stationButton.TabIndex = 20;
            this.stationButton.Text = "Station Optionen";
            this.stationButton.UseVisualStyleBackColor = true;
            this.stationButton.Click += new System.EventHandler(this.stationButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.mapButton);
            this.groupBox1.Controls.Add(this.timetableButton);
            this.groupBox1.Controls.Add(this.stationTextBox);
            this.groupBox1.Controls.Add(this.stationButton);
            this.groupBox1.Location = new System.Drawing.Point(9, 245);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(163, 143);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Station Suche";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 35);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "Station:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.swapButton);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.fromTextBox);
            this.groupBox2.Controls.Add(this.toTextBox);
            this.groupBox2.Controls.Add(this.searchButton);
            this.groupBox2.Controls.Add(this.dateTimePicker);
            this.groupBox2.Controls.Add(this.timeTextBox);
            this.groupBox2.Location = new System.Drawing.Point(9, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(163, 223);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Verbindung Suche";
            // 
            // swapButton
            // 
            this.swapButton.Location = new System.Drawing.Point(58, 63);
            this.swapButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.swapButton.Name = "swapButton";
            this.swapButton.Size = new System.Drawing.Size(49, 21);
            this.swapButton.TabIndex = 20;
            this.swapButton.TabStop = false;
            this.swapButton.Text = "↕";
            this.swapButton.UseVisualStyleBackColor = true;
            this.swapButton.Click += new System.EventHandler(this.swapButton_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 141);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "Zeit:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 104);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Datum:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 67);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "bis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "von:";
            // 
            // SBB_App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 399);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabs);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SBB_App";
            this.Text = "SBB App";
            this.tabs.ResumeLayout(false);
            this.welcomeTab.ResumeLayout(false);
            this.welcomeTab.PerformLayout();
            this.connectionTab.ResumeLayout(false);
            this.connectionTab.PerformLayout();
            this.timetableTab.ResumeLayout(false);
            this.timetableTab.PerformLayout();
            this.stationTab.ResumeLayout(false);
            this.stationTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage welcomeTab;
        private System.Windows.Forms.TabPage connectionTab;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage timetableTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox stationTextBox;
        private System.Windows.Forms.Button mapButton;
        private System.Windows.Forms.Button timetableButton;
        private System.Windows.Forms.ListBox connectionListBox;
        private System.Windows.Forms.Button stationButton;
        private System.Windows.Forms.TabPage stationTab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox stationListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox timetableListBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox targetMailTextBox;
        private System.Windows.Forms.Label em;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button swapButton;
    }
}

