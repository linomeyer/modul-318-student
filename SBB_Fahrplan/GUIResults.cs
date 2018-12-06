using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBB_Fahrplan
{
    public partial class GUIResults : Form
    {
        private Connections connections;
        private StationBoardRoot stationBoardRoot;
        private Transport transport = new Transport();

        /// <summary>
        /// Used to open gui in connection layout and sets member variables with given parameter values
        /// </summary>
        /// <param name="fromLocation"></param>
        /// <param name="toLocation"></param>
        public GUIResults(string fromLocation, string toLocation, string datetime)
        {
            InitializeComponent();
            stationBoardRoot = null;
            //split datetime to date and time
            string date = datetime.Substring(0, 10);
            string time = datetime.Substring(10, 6);
            connections = transport.GetConnections(fromLocation, toLocation, date, time);
            LoadFormInConnectionLayout(fromLocation, toLocation);
        }

        /// <summary>
        /// Used to open gui in timetable layout and sets member variables with given parameter values
        /// </summary>
        /// <param name="timetableLocation"></param>
        public GUIResults(string timetableLocation)
        {
            InitializeComponent();
            stationBoardRoot = transport.GetStationBoard(timetableLocation, transport.GetStations(timetableLocation).StationList[0].Id);
            connections = null;
            LoadFormInTimetableLayout(timetableLocation);
        }

        private void LoadFormInTimetableLayout(string timetableLocation)
        {
            lblFromLocation.Visible = false;
            lblToLocation.Visible = false;
            lblTimeTableLocation.Visible = true;
            lblTimeTableLocation.Text = timetableLocation;

            //fill data grid in timetable layout
            FillDataGridTimetable();
        }

        private void FillDataGridTimetable()
        {
            dataGridTimetable.Visible = true;
            foreach (StationBoard stationBoard in stationBoardRoot.Entries)
            {
                dataGridTimetable.Rows.Add(stationBoard.Stop.Departure, stationBoardRoot.Station.Name, stationBoard.To, stationBoard.Operator, stationBoard.Name);
            }
        }

        private void LoadFormInConnectionLayout(string fromLocation, string toLocation)
        {
            lblFromLocation.Visible = true;
            lblToLocation.Visible = true;
            lblTimeTableLocation.Visible = false;
            lblFromLocation.Text = fromLocation;
            lblToLocation.Text = toLocation;

            //fill data grid in connection layout
            FillDataGridConnections();
        }

        private void FillDataGridConnections()
        {
                List<Connection> connectionList = connections.ConnectionList;
                //Sets amountOfElements to the size of the list or if the list is bigger than 5 to 5
                int amountOfElements = connectionList.Count < 5 ? connectionList.Count : 5;
                dataGridConnections.Visible = true;

                for (int i = 0; i < amountOfElements; i++)
                {
                    //convert departure to datetime and cut off seconds with substring
                    string departureTime = Convert.ToDateTime(connectionList[i].From.Departure).ToString().Substring(0, 16);
                    //cut off days and seconds with substring
                    string duration = connectionList[i].Duration.Substring(3, 5);

                    dataGridConnections.Rows.Add(departureTime, connectionList[i].From.Station.Name, connectionList[i].To.Station.Name, connectionList[i].From.Platform, duration);
                }
        }

        public Connections Connections
        { 
            get { return connections; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dataGridConnections.Visible = false;
            dataGridConnections.Rows.Clear();
            dataGridTimetable.Visible = false;
            dataGridTimetable.Rows.Clear();
            this.Close();
        }

        private void DataGrid_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;
            int index = dataGridView.CurrentCell.RowIndex;
            string fromStation = dataGridView.Rows[index].Cells[1].Value.ToString();
            string toStation = dataGridView.Rows[index].Cells[2].Value.ToString();

            transport.OpenConnectionInMaps(fromStation, toStation);
        }
    }
}
