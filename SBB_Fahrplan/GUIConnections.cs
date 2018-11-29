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
    public partial class GUIConnections : Form
    {
        private string fromLocation;
        private string toLocation;
        private Connections connections;
        private Transport transport = new Transport();

        public GUIConnections(string fromLocation, string toLocation)
        {
            InitializeComponent();
            this.fromLocation = fromLocation;
            this.toLocation = toLocation;
            connections = transport.GetConnections(FromLocation, ToLocation);

            lblFromLocation.Text = fromLocation;
            lblToLocation.Text = toLocation;

            fillListViewConnections();
        }

        private void fillListViewConnections()
        {
            List<Connection> connectionList = connections.ConnectionList;
            //iterate over list to a maximum of 6 elements

            for(int i = 0; i < (connectionList.Count < 6 ? connectionList.Count : 6); i++)
            {
                // HIER WEITERMACHEN
                string[] connectionInfo = { connectionList[i].From.Departure, connectionList[i].To.Arrival, connectionList[i].Duration };

                listviewConnections.Items.Add(new ListViewItem(connectionInfo));
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
