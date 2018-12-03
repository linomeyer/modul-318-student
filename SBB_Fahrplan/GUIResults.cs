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
        private string fromLocation;
        private string toLocation;
        private Connections connections;
        private Transport transport = new Transport();

        /// <summary>
        /// Sets values for member variables with given parameter values.
        /// </summary>
        /// <param name="fromLocation"></param>
        /// <param name="toLocation"></param>
        public GUIResults(string fromLocation, string toLocation)
        {
            InitializeComponent();
            this.fromLocation = fromLocation;
            this.toLocation = toLocation;
            connections = transport.GetConnections(FromLocation, ToLocation);
            LoadFormInConnectionLayout();
        }

        private void LoadFormInConnectionLayout()
        {
            //fill data grid in connection layout
            FillDataGridConnections();

            lblFromLocation.Visible = true;
            lblToLocation.Visible = true;
            lblTimeTableLocation.Visible = false;
        }

        private void FillDataGridConnections()
        {
            List<Connection> connectionList = connections.ConnectionList;
            //Sets amountOfElements to the size of the list or if the list is bigger than 5 to 5
            int amountOfElements = connectionList.Count < 5 ? connectionList.Count : 5;

            for (int i = 0; i < amountOfElements; i++)
            {
                //convert departure to datetime and cut off seconds with substring
                string departureTime = Convert.ToDateTime(connectionList[i].From.Departure).ToString().Substring(0,16);
                //adds string "Gleis" to platform for a better looking presentation
                string platform = "Gleis" + connectionList[i].From.Platform;
                //cut off days and seconds with substring
                string duration = connectionList[i].Duration.Substring(3, 5);

                dataGridConnections.Rows.Add(departureTime , connectionList[i].From.Station.Name, connectionList[i].To.Station.Name, platform, duration);
            }
        }

        public string FromLocation
        {
            get { return fromLocation; }
        }

        public string ToLocation
        {
            get { return toLocation; } 
        }

        public Connections Connections
        { 
            get { return connections; }
        }
    }
}
