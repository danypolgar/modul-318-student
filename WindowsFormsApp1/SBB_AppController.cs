using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net;


namespace WindowsFormsApp1
{   
    
    public partial class SBB_App : Form
    {   
        //Konstruktor
        public SBB_App()
        {
            InitializeComponent();
            timeTextBox.Text = DateTime.Now.ToString("HH:mm");
            checkInternetConnection();
        }

        //Membervariablen
        SwissTransport.Transport transport = new SwissTransport.Transport();
        Utils utils = new Utils();

        //Methoden Button Klicks
        private void searchButton_Click(object sender, EventArgs e)
        {
            connectionListBox.Items.Clear();
            checkInternetConnection();
            utils.validateTimeInput(timeTextBox.Text);
            tabs.SelectedTab = connectionTab;
            if (transport.GetConnections(fromTextBox.Text, toTextBox.Text, dateTimePicker.Text, timeTextBox.Text).ConnectionList.Count > 0 && utils.validateTextBoxInput(fromTextBox.Text) && utils.validateTextBoxInput(toTextBox.Text))
            {
                foreach (SwissTransport.Connection connection in transport.GetConnections(fromTextBox.Text, toTextBox.Text, dateTimePicker.Text, timeTextBox.Text).ConnectionList)
                {
                    connectionListBox.Items.Add(utils.getConnectionFormat(connection));
                }
            }
            else
            {
                utils.showErrorMessage("Error: Suche", "Bitte geben Sie eine gültige Start- und Endstation ein.");
            }


        }



        private void mapButton_Click(object sender, EventArgs e)
        {
            checkInternetConnection();
            SwissTransport.Stations station = transport.GetStations(stationTextBox.Text);
            if (station.StationList.Count > 0 && !utils.getCoordinates(station.StationList[0]).Equals("0, 0"))
            {
                System.Diagnostics.Process.Start("https://www.google.com/maps/search/?api=1&query=" + utils.getCoordinates(station.StationList[0]));
            }
            else
            {
                utils.showErrorMessage("Error: Karte", "Bitte geben Sie eine gültige Station ein.");
            }

        }



        private void timetableButton_Click(object sender, EventArgs e)
        {

            timetableListBox.Items.Clear();
            tabs.SelectedTab = timetableTab;
            checkInternetConnection();
            if (transport.GetStationBoard(stationTextBox.Text).Entries.Count > 0 && utils.validateTextBoxInput(stationTextBox.Text))
            {
                foreach (SwissTransport.StationBoard stationBoard in transport.GetStationBoard(stationTextBox.Text).Entries)
                {
                    timetableListBox.Items.Add(utils.getTimetableFormat(stationBoard));
                }
            }
            else
            {
                utils.showErrorMessage("Error: Abfahrtstafel", "Bitte geben Sie eine gültige Station ein.");
            }

        }


        private void stationButton_Click(object sender, EventArgs e)
        {
            stationListBox.Items.Clear();
            tabs.SelectedTab = stationTab;
            checkInternetConnection();
            if (transport.GetStations(stationTextBox.Text).StationList.Count > 0 && utils.validateTextBoxInput(stationTextBox.Text))
            {
                foreach (SwissTransport.Station station in transport.GetStations(stationTextBox.Text).StationList)
                {
                    stationListBox.Items.Add(station.Name);
                }
            }
            else
            {
                utils.showErrorMessage("Error: Station", "Bitte geben Sie eine gültige Station ein.");
            }

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            checkInternetConnection();
            if (connectionListBox.Items.Count > 0 && Regex.IsMatch(targetMailTextBox.Text, "^([a-zA-Z0-9_\\-\\.]+)@([a-zA-Z0-9_\\-\\.]+)\\.([a-zA-Z]{2,5})$"))
            {
                string mailContent = "";
                for (int i = 0; i < connectionListBox.Items.Count; i++)
                {
                    mailContent += connectionListBox.Items[i].ToString() + "\n";
                }
                System.Diagnostics.Process.Start("mailto:" + targetMailTextBox.Text + "?subject=Fahrplan&body=" + mailContent);
            }
            else
            {
                utils.showErrorMessage("Error: Email", "-Bitte füllen Sie die \"Verbindung Suche\" Felder aus.\n-Bitte geben Sie einen gültigen Email ein.");
            }
        }

        private void swapButton_Click(object sender, EventArgs e)
        {
            string temp = fromTextBox.Text;
            fromTextBox.Text = toTextBox.Text;
            toTextBox.Text = temp;
        }

        //zusätzliche Methoden
        public void checkInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {

                }

            }
            catch
            {
                utils.showErrorMessage("Error: Internet", "Bitte erstellen Sie eine Internetverbindung.");
                Environment.Exit(0);
            }
        }

    }
}
