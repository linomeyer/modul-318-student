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

        public GUIConnections(string fromLocation, string toLocation)
        {
            InitializeComponent();
            this.fromLocation = fromLocation;
            this.toLocation = toLocation;

            lblFromLocation.Text = fromLocation;
            lblToLocation.Text = toLocation;
        }

        public string FromLocation
        {
            get { return fromLocation; }
        }

        public string ToLocation
        {
            get { return toLocation; } 
        }
    }
}
