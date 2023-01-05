using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISS_Take_1
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.lstAPIs, "Select an API, or add one below");
            toolTip1.SetToolTip(this.lstAvailableSats, "Select to add to trackable Satellite list");
            toolTip1.SetToolTip(this.lstTrackableSats, "Select to delete trackable Satellite");
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
