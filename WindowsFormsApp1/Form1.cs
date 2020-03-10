using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timeTextBox.Text = DateTime.Now.ToString("HH:mm");
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            connectionListBox.Items.Clear();
            SwissTransport.Transport transport = new SwissTransport.Transport();
            validateTimeInput();
            tabs.SelectedTab = connectionTab;
            foreach(SwissTransport.Connection connection in transport.GetConnections(fromTextBox.Text, toTextBox.Text, dateTimePicker.Text, timeTextBox.Text).ConnectionList)
            {
                connectionListBox.Items.Add(showConnections(connection));
                Console.WriteLine(showConnections(connection));
            }
            
        }

        private string showConnections(SwissTransport.Connection connection)
        {
            string[] connections = { connection.From.Departure.ToString().Substring(0, 10), " | ", connection.From.Departure.ToString().Substring(11, 5), " ", connection.From.Station.Name, " --> ", connection.To.Station.Name, " ", connection.To.Arrival.ToString().Substring(11, 5)};

            return string.Join(" ", connections);
        }

        private void MapButton_Click(object sender, EventArgs e)
        {
            tabs.SelectedTab = mapTab;
        }

        private void TimetableButton_Click(object sender, EventArgs e)
        {
            tabs.SelectedTab = timetableTab;
        }

        public void validateTimeInput()
        {
            if (!Regex.IsMatch(timeTextBox.Text, "^([0-1][0-9]|[2][0-3]):([0-5][0-9])$"))
            {
                showErrorMessage();
            }

        }

        public void showErrorMessage()
        {
            MessageBox.Show("ungültige Eingabe, richtig: HH:MM", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void StationButton_Click(object sender, EventArgs e)
        {
            SwissTransport.Transport a = new SwissTransport.Transport();
            tabs.SelectedTab = stationTab;
            stationListBox.Items.Add(a.GetStations(stationTextBox.Text));
        }

       
    }
}
