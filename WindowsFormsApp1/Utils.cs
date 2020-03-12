using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    class Utils
    {
        //Formatierungen
        public string getConnectionFormat(SwissTransport.Connection connection)
        {
            string[] connections = { connection.From.Departure.ToString().Substring(0, 10), " |  ", connection.From.Departure.ToString().Substring(11, 5), "  ", connection.From.Station.Name, " -->  ", connection.To.Station.Name, "  ", connection.To.Arrival.ToString().Substring(11, 5) };
            return string.Join("", connections);
        }

        public string getCoordinates(SwissTransport.Station station)
        {
            string[] coordinates = { station.Coordinate.XCoordinate.ToString().Replace(",", "."), ", ", station.Coordinate.YCoordinate.ToString().Replace(",", ".") };
            return string.Join("", coordinates);
        }

        public string getTimetableFormat(SwissTransport.StationBoard stationBoard)
        {
            string[] timetable = { stationBoard.Stop.Departure.ToString().Substring(0, 10), " |  ", stationBoard.Stop.Departure.ToString().Substring(11, 5), "   ", " -->  ", stationBoard.To };
            return string.Join("", timetable);
        }

        public string getStationFormat(SwissTransport.Station station)
        {
            string[] stationResult = { station.Name };
            return string.Join("", stationResult);
        }


        //Validierungen
        public void validateTimeInput(string input)
        {
            if (!Regex.IsMatch(input, "^([0-1][0-9]|[2][0-3]):([0-5][0-9])$"))
            {
                showErrorMessage("Error: Zeit", "ungültige Eingabe, richtig: HH:mm");
            }

        }

        public bool validateTextBoxInput(string input)
        {
            if (!Regex.IsMatch(input, "^.+$"))
            {
                return false;
            }
            return true;
        }

        //Error Meldung
        public void showErrorMessage(string title, string message)
        {
            MessageBox.Show(message, title,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


       

    }
}
