using Newtonsoft.Json;
using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBB_Fahrplan
{
    public partial class GUISearch : Form
    {
        private Transport transport = new Transport();

        public GUISearch()
        {
            InitializeComponent();
            //is set to empty here to still see the label in gui designer
            lblErrorMessage.Text = "";
            //set dateTimePicker to a custom format
            dateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePicker.Value = DateTime.Now;
        }

        private void BtnSearchTimetableLocation_Click(object sender, EventArgs e)
        {
            SearchLocation(txtTimetableLocation);
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

            txtLocation.Text = SelectLocation(locations);
        }


        private string SelectLocation(List<string> locations)
        {
            //opens the form GUIChooseLocation modal
            GUIChooseLocation formChooseLocation = new GUIChooseLocation(locations); 
            DialogResult dialogResult = formChooseLocation.ShowDialog();
            return formChooseLocation.ChosenLocation;
        }

        private Stations GetStations(string userInput)
        {
            return transport.GetStations(userInput);
        }

        private void TxtFromToLocation_TextChanged(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;
            lblErrorMessage.Text = "";

            //if to and from location have text enable search button, disable it if not
            if (txtFromLocation.Text != "" && txtToLocation.Text != "")
            {
                btnSearchConnection.Enabled = true;
            } else
            {
                btnSearchConnection.Enabled = false;
            }
        }

        private void BtnSearchConnection_Click(object sender, EventArgs e)
        {
            // catches WebException if no connection to the internet is available
            try
            {
                Stations stationsOfFromLocation = transport.GetStations(txtFromLocation.Text);
                Stations stationsOfToLocation = transport.GetStations(txtToLocation.Text);

                bool hasErrors = SearchConnectionErrors(stationsOfFromLocation, stationsOfToLocation);

                if (!hasErrors)
                {
                    /* StationList[0] is alway the most likely location or if you already have a valid location it will be that
                     * this way if you for example have a to location with value "lu" it will automatically be turned into "Luzern"
                     * if you already have "Luzern" it will stay "Luzern" */
                    string fromLocation = stationsOfFromLocation.StationList[0].Name;
                    string toLocation = stationsOfToLocation.StationList[0].Name;
                    // catches JsonSerializableException if no coordinates were found for a given location
                    try
                    {
                        GUIResults formConnections = new GUIResults(fromLocation, toLocation, dateTimePicker.Text);
                        formConnections.ShowDialog();
                    }
                    catch (JsonSerializationException)
                    {
                        MessageBox.Show("Von der SBB Schnittstelle wurden keine Koordinaten zu diesem Ort gefunden.");
                    }
                }
            }
            catch(WebException)
            {
                MessageBox.Show("Sie benötigen eine funktionierende Internetverbindung.");
            }
        }

        private bool SearchConnectionErrors(Stations stationsOfFromLocation, Stations stationsOfToLocation)
        {
            bool hasErrors = false;
            // if no from location was found show error message
            if (stationsOfFromLocation.StationList.Count() == 0)
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Es wurde keine Abfahrtstation mit dem Namen " + txtFromLocation.Text + " gefunden";
                hasErrors = true;
            }
            // if no to location was found show error message
            if (stationsOfToLocation.StationList.Count() == 0)
            {
                lblErrorMessage.Visible = true;
                string toLocationError = "Es wurde keine Ankunftstation mit dem Namen " + txtToLocation.Text + " gefunden";              
                // if both locations were not found show both error messages on seperate lines
                if (lblErrorMessage.Text != "")
                {
                    lblErrorMessage.Text += Environment.NewLine + toLocationError;
                }
                else
                {
                    lblErrorMessage.Text = toLocationError;
                }
                hasErrors = true;
            }
            return hasErrors;
        }

        private void BtnCreateTimetable_Click(object sender, EventArgs e)
        {
            try
            {
                Stations stationsOfTimetableLocation = transport.GetStations(txtTimetableLocation.Text);
                bool hasErrors = SearchTimetableErrors(stationsOfTimetableLocation);

                if (!hasErrors)
                {
                    try
                    {
                        string timetableLocation = stationsOfTimetableLocation.StationList[0].Name;
                        GUIResults formTimetable = new GUIResults(timetableLocation);
                        formTimetable.ShowDialog();
                    }
                    catch (JsonSerializationException)
                    {
                        MessageBox.Show("Von der SBB Schnittstelle wurden keine Koordinaten zu diesem Ort gefunden.");
                    }
                }
            }
            catch (WebException)
            {
                MessageBox.Show("Von der SBB Schnittstelle wurden keine Koordinaten zu diesem Ort gefunden.");
            }
        }

        private bool SearchTimetableErrors(Stations stationsOfTimetableLocation)
        {
            if(stationsOfTimetableLocation.StationList.Count() == 0)
            {
                lblTimetableErrors.Visible = true;
                lblTimetableErrors.Text = "Es wurde keine Station mit dem Namen " + txtTimetableLocation.Text + " gefunden.";
                return true;
            }
            return false;
        }
        private void TxtTimetableLocation_TextChanged(object sender, EventArgs e)
        {
            lblTimetableErrors.Visible = false;
            if(txtTimetableLocation.Text != "")
            {
                btnCreateTimeTable.Enabled = true;
            } else
            {
                btnCreateTimeTable.Enabled = false;
            }
        }

        private void TxtFromToLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchConnection.PerformClick();
            }
        }

        private void TxtTimetableLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCreateTimeTable.PerformClick();
            }
        }
    }
}
