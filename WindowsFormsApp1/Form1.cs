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
using System.IO;
using System.Net;
using System.Net.Mail;


namespace WindowsFormsApp1
{
    public partial class SBB_App : Form
    {
        public SBB_App()
        {
            InitializeComponent();
            timeTextBox.Text = DateTime.Now.ToString("HH:mm");
        }

        SwissTransport.Transport transport = new SwissTransport.Transport();


        private void searchButton_Click(object sender, EventArgs e)
        {
            connectionListBox.Items.Clear();
            validateTimeInput();
            tabs.SelectedTab = connectionTab;
            if (transport.GetConnections(fromTextBox.Text, toTextBox.Text, dateTimePicker.Text, timeTextBox.Text).ConnectionList.Count > 0 && validateTextBoxInput(fromTextBox.Text) && validateTextBoxInput(toTextBox.Text))
            {
                foreach (SwissTransport.Connection connection in transport.GetConnections(fromTextBox.Text, toTextBox.Text, dateTimePicker.Text, timeTextBox.Text).ConnectionList)
                {
                    connectionListBox.Items.Add(getConnectionFormat(connection));
                }
            }
            else
            {
                showErrorMessage("Error: Suche", "Bitte geben Sie eine gültige Start- und Endstation ein.");
            }


        }

        private string getConnectionFormat(SwissTransport.Connection connection)
        {
            string[] connections = { connection.From.Departure.ToString().Substring(0, 10), " |  ", connection.From.Departure.ToString().Substring(11, 5), "  ", connection.From.Station.Name, " -->  ", connection.To.Station.Name, "  ", connection.To.Arrival.ToString().Substring(11, 5) };
            return string.Join("", connections);
        }

        private void mapButton_Click(object sender, EventArgs e)
        {
            SwissTransport.Stations station = transport.GetStations(stationTextBox.Text);
            if (station.StationList.Count > 0 && !getCoordinates(station.StationList[0]).Equals("0, 0"))
            {
                System.Diagnostics.Process.Start("https://www.google.com/maps/search/?api=1&query=" + getCoordinates(station.StationList[0]));
            }
            else
            {
                showErrorMessage("Error: Karte", "Bitte geben Sie eine gültige Station ein.");
            }

        }

        private string getCoordinates(SwissTransport.Station station)
        {
            string[] coordinates = { station.Coordinate.XCoordinate.ToString().Replace(",", "."), ", ", station.Coordinate.YCoordinate.ToString().Replace(",", ".") };
            return string.Join("", coordinates);
        }

        private void timetableButton_Click(object sender, EventArgs e)
        {
            
            timetableListBox.Items.Clear();
            tabs.SelectedTab = timetableTab;
            if (transport.GetStationBoard(stationTextBox.Text).Entries.Count > 0 && validateTextBoxInput(stationTextBox.Text))
            {
                foreach (SwissTransport.StationBoard stationBoard in transport.GetStationBoard(stationTextBox.Text).Entries)
                {
                    timetableListBox.Items.Add(getTimetableFormat(stationBoard));
                }
            }
            else
            {
                showErrorMessage("Error: Abfahrtstafel", "Bitte geben Sie eine gültige Station ein.");
            }

        }

        private string getTimetableFormat(SwissTransport.StationBoard stationBoard)
        {
            string[] timetable = { stationBoard.Stop.Departure.ToString().Substring(0, 10), " |  ", stationBoard.Stop.Departure.ToString().Substring(11, 5), "   ", " -->  ", stationBoard.To };
            return string.Join("", timetable);
        }

        public void validateTimeInput()
        {
            if (!Regex.IsMatch(timeTextBox.Text, "^([0-1][0-9]|[2][0-3]):([0-5][0-9])$"))
            {
                showErrorMessage("Error: Zeit", "ungültige Eingabe, richtig: HH:mm");
            }

        }

        public void showErrorMessage(string title, string message)
        {
            MessageBox.Show(message, title,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void stationButton_Click(object sender, EventArgs e)
        {
            stationListBox.Items.Clear();
            tabs.SelectedTab = stationTab;
            if (transport.GetStations(stationTextBox.Text).StationList.Count > 0 && validateTextBoxInput(stationTextBox.Text))
            {
                foreach (SwissTransport.Station station in transport.GetStations(stationTextBox.Text).StationList)
                {
                    stationListBox.Items.Add(station.Name);
                }
            }
            else
            {
                showErrorMessage("Error: Station", "Bitte geben Sie eine gültige Station ein.");
            }


        }

        private void sendButton_Click(object sender, EventArgs e)
        {

            if (connectionListBox.Items.Count > 0 && validateEmailTextBoxInput(targetMailTextBox.Text))
            {
                string mailContent = "";
                for (int i = 0; i < connectionListBox.Items.Count; i++)
                {
                    mailContent += connectionListBox.Items[i].ToString() + "\n";
                }
                System.Diagnostics.Process.Start("mailto:" + targetMailTextBox.Text + "?subject=Fahrplan&body=" + mailContent);
            }
        }

        private void validateSearchTextBoxInput(string input)
        {
            if (!Regex.IsMatch(input, "^.+$"))
            {
                showErrorMessage("Error: von/bis", "Bitte geben Sie ein Start und Ziel Station ein.");
            }
        }

        private bool validateTextBoxInput(string input)
        {
            if (!Regex.IsMatch(input, "^.+$"))
            {
                return false;
            }
            return true;
        }
        private bool validateEmailTextBoxInput(string input)
        {
            if (!Regex.IsMatch(input, "^([a-zA-Z0-9_\\-\\.]+)@([a-zA-Z0-9_\\-\\.]+)\\.([a-zA-Z]{2,5})$"))
            {
                showErrorMessage("Error: Email", "Bitte geben Sie einen gültigen Email ein.");
                return false;
            }
            else
            {
                return true;
            }

        }

    }
}
