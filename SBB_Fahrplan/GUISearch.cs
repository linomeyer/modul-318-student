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
    public partial class GUISearch : Form
    {
        public GUISearch()
        {
            InitializeComponent();
        }

        private void BtnSearchLocation_Click(object sender, EventArgs e)
        {
            SearchLocation(txtLocation);
        }

        private void BtnSearchToLocation_Click(object sender, EventArgs e)
        {
            SearchLocation(txtToLocation);
        }

        private void BtnSearchFromLocation_Click(object sender, EventArgs e)
        {
            SearchLocation(txtFromLocation);
        }

        private void SearchLocation(TextBox txtLocation)
        {
            List<String> locations = new List<string>();

            Stations stations = GetStations(txtLocation.Text);

            foreach (Station station in stations.StationList)
            {
                locations.Add(station.Name);
            }

            txtLocation.Text = GetChosenLocation(locations);
        }


        private string GetChosenLocation(List<string> locations)
        {
            GUIChooseLocation formChooseLocation = new GUIChooseLocation(locations);
            DialogResult dialogResult = formChooseLocation.ShowDialog();
            return formChooseLocation.ChosenLocation;
        }

        private Stations GetStations(string userInput)
        {
            Transport transport = new Transport();
            return transport.GetStations(userInput);
        }

        private void txtFromTo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearchConnection.PerformClick();
            }
        }

        private void BtnSearchConnection_Click(object sender, EventArgs e)
        {

        }

        private void TxtFromToLocation_TextChanged(object sender, EventArgs e)
        {
            if(txtFromLocation.Text != "" && txtToLocation.Text != "")
            {
                btnSearchConnection.Enabled = true;
            } else
            {
                btnSearchConnection.Enabled = false;
            }
        }
    }
}
