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
    public partial class GUIChooseLocation : Form
    {
        private List<string> locations;
        private string chosenLocation;

        public GUIChooseLocation(List<string> locations)
        {
            this.locations = locations;
            InitializeComponent();
            listBoxLocations.DataSource = locations;
        }

        private void BtnChooseLocation_Click(object sender, EventArgs e)
        {
            chosenLocation = listBoxLocations.SelectedItem.ToString();
            this.Close();
        }

        public string ChosenLocation
        {
            get { return chosenLocation; }
        }

        private void ListBoxLocations_DoubleClick(object sender, EventArgs e)
        {
            btnChooseLocation.PerformClick();
        }
    }
}
