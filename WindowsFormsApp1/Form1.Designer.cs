namespace WindowsFormsApp1
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.welcomeTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.connectionTab = new System.Windows.Forms.TabPage();
            this.connectionListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timetableTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.mapTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.stationTab = new System.Windows.Forms.TabPage();
            this.stationListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.stationTextBox = new System.Windows.Forms.TextBox();
            this.aktPosCheckBox = new System.Windows.Forms.CheckBox();
            this.mapButton = new System.Windows.Forms.Button();
            this.timetableButton = new System.Windows.Forms.Button();
            this.stationButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabs.SuspendLayout();
            this.welcomeTab.SuspendLayout();
            this.connectionTab.SuspendLayout();
            this.timetableTab.SuspendLayout();
            this.mapTab.SuspendLayout();
            this.stationTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabs.Controls.Add(this.welcomeTab);
            this.tabs.Controls.Add(this.connectionTab);
            this.tabs.Controls.Add(this.timetableTab);
            this.tabs.Controls.Add(this.mapTab);
            this.tabs.Controls.Add(this.stationTab);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabs.ItemSize = new System.Drawing.Size(0, 1);
            this.tabs.Location = new System.Drawing.Point(231, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(788, 491);
            this.tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabs.TabIndex = 10;
            // 
            // welcomeTab
            // 
            this.welcomeTab.Controls.Add(this.label1);
            this.welcomeTab.Location = new System.Drawing.Point(4, 5);
            this.welcomeTab.Name = "welcomeTab";
            this.welcomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.welcomeTab.Size = new System.Drawing.Size(780, 482);
            this.welcomeTab.TabIndex = 0;
            this.welcomeTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wilkommen";
            // 
            // connectionTab
            // 
            this.connectionTab.Controls.Add(this.label10);
            this.connectionTab.Controls.Add(this.label9);
            this.connectionTab.Controls.Add(this.label8);
            this.connectionTab.Controls.Add(this.label7);
            this.connectionTab.Controls.Add(this.label6);
            this.connectionTab.Controls.Add(this.connectionListBox);
            this.connectionTab.Controls.Add(this.label2);
            this.connectionTab.Location = new System.Drawing.Point(4, 5);
            this.connectionTab.Name = "connectionTab";
            this.connectionTab.Padding = new System.Windows.Forms.Padding(3);
            this.connectionTab.Size = new System.Drawing.Size(780, 482);
            this.connectionTab.TabIndex = 1;
            this.connectionTab.UseVisualStyleBackColor = true;
            // 
            // connectionListBox
            // 
            this.connectionListBox.FormattingEnabled = true;
            this.connectionListBox.ItemHeight = 16;
            this.connectionListBox.Location = new System.Drawing.Point(28, 233);
            this.connectionListBox.Name = "connectionListBox";
            this.connectionListBox.Size = new System.Drawing.Size(721, 212);
            this.connectionListBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Verbindungen";
            // 
            // timetableTab
            // 
            this.timetableTab.Controls.Add(this.label3);
            this.timetableTab.Location = new System.Drawing.Point(4, 5);
            this.timetableTab.Name = "timetableTab";
            this.timetableTab.Size = new System.Drawing.Size(780, 482);
            this.timetableTab.TabIndex = 2;
            this.timetableTab.Text = "tabPage3";
            this.timetableTab.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Abfahrtstafel";
            // 
            // mapTab
            // 
            this.mapTab.Controls.Add(this.label4);
            this.mapTab.Location = new System.Drawing.Point(4, 5);
            this.mapTab.Name = "mapTab";
            this.mapTab.Size = new System.Drawing.Size(780, 482);
            this.mapTab.TabIndex = 3;
            this.mapTab.Text = "tabPage4";
            this.mapTab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Karte";
            // 
            // stationTab
            // 
            this.stationTab.Controls.Add(this.stationListBox);
            this.stationTab.Controls.Add(this.label5);
            this.stationTab.Location = new System.Drawing.Point(4, 5);
            this.stationTab.Name = "stationTab";
            this.stationTab.Size = new System.Drawing.Size(780, 482);
            this.stationTab.TabIndex = 4;
            this.stationTab.Text = "stationTab";
            this.stationTab.UseVisualStyleBackColor = true;
            // 
            // stationListBox
            // 
            this.stationListBox.FormattingEnabled = true;
            this.stationListBox.ItemHeight = 16;
            this.stationListBox.Location = new System.Drawing.Point(28, 233);
            this.stationListBox.Name = "stationListBox";
            this.stationListBox.Size = new System.Drawing.Size(721, 212);
            this.stationListBox.TabIndex = 1;
            this.stationListBox.UseTabStops = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ähnliche Stationen";
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(32, 51);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(174, 22);
            this.fromTextBox.TabIndex = 11;
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(32, 93);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(174, 22);
            this.toTextBox.TabIndex = 12;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(32, 133);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(174, 22);
            this.dateTimePicker.TabIndex = 13;
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(32, 171);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(174, 22);
            this.timeTextBox.TabIndex = 14;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(32, 209);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(174, 23);
            this.searchButton.TabIndex = 15;
            this.searchButton.Text = "Suchen";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // stationTextBox
            // 
            this.stationTextBox.Location = new System.Drawing.Point(32, 273);
            this.stationTextBox.Name = "stationTextBox";
            this.stationTextBox.Size = new System.Drawing.Size(174, 22);
            this.stationTextBox.TabIndex = 16;
            // 
            // aktPosCheckBox
            // 
            this.aktPosCheckBox.AutoSize = true;
            this.aktPosCheckBox.Location = new System.Drawing.Point(53, 315);
            this.aktPosCheckBox.Name = "aktPosCheckBox";
            this.aktPosCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.aktPosCheckBox.Size = new System.Drawing.Size(153, 21);
            this.aktPosCheckBox.TabIndex = 17;
            this.aktPosCheckBox.Text = "ab aktuelle Position";
            this.aktPosCheckBox.UseVisualStyleBackColor = true;
            // 
            // mapButton
            // 
            this.mapButton.Location = new System.Drawing.Point(32, 352);
            this.mapButton.Name = "mapButton";
            this.mapButton.Size = new System.Drawing.Size(174, 23);
            this.mapButton.TabIndex = 18;
            this.mapButton.Text = "Karte";
            this.mapButton.UseVisualStyleBackColor = true;
            this.mapButton.Click += new System.EventHandler(this.MapButton_Click);
            // 
            // timetableButton
            // 
            this.timetableButton.Location = new System.Drawing.Point(32, 392);
            this.timetableButton.Name = "timetableButton";
            this.timetableButton.Size = new System.Drawing.Size(174, 23);
            this.timetableButton.TabIndex = 19;
            this.timetableButton.Text = "Abfahrtstafel";
            this.timetableButton.UseVisualStyleBackColor = true;
            this.timetableButton.Click += new System.EventHandler(this.TimetableButton_Click);
            // 
            // stationButton
            // 
            this.stationButton.Location = new System.Drawing.Point(32, 436);
            this.stationButton.Name = "stationButton";
            this.stationButton.Size = new System.Drawing.Size(174, 23);
            this.stationButton.TabIndex = 20;
            this.stationButton.Text = "Stationen";
            this.stationButton.UseVisualStyleBackColor = true;
            this.stationButton.Click += new System.EventHandler(this.StationButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ziel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Datum";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(108, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Abfahrt";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(168, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Startpunkt";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(288, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Ankunft";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 491);
            this.Controls.Add(this.stationButton);
            this.Controls.Add(this.timetableButton);
            this.Controls.Add(this.mapButton);
            this.Controls.Add(this.aktPosCheckBox);
            this.Controls.Add(this.stationTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.tabs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabs.ResumeLayout(false);
            this.welcomeTab.ResumeLayout(false);
            this.welcomeTab.PerformLayout();
            this.connectionTab.ResumeLayout(false);
            this.connectionTab.PerformLayout();
            this.timetableTab.ResumeLayout(false);
            this.timetableTab.PerformLayout();
            this.mapTab.ResumeLayout(false);
            this.mapTab.PerformLayout();
            this.stationTab.ResumeLayout(false);
            this.stationTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage welcomeTab;
        private System.Windows.Forms.TabPage connectionTab;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage timetableTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage mapTab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox stationTextBox;
        private System.Windows.Forms.CheckBox aktPosCheckBox;
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
    }
}

