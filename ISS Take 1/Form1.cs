using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Runtime;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ISS_Take_1.Form1;
using static ISS_Take_1.Program;

using System.Windows.Forms;
using DotNetBrowser.Browser;
using DotNetBrowser.Engine;
using DotNetBrowser.WinForms;
using NHibernate.Linq;
using NHibernate.SqlCommand;

namespace ISS_Take_1
{
    public partial class Form1 : Form
    {
        public string NbrOfHits;
        private WebBrowser webBrowser1;
        

        public Form1()
        {
            
            InitializeComponent();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        var dataContext = new SateliteDBContext();

            List<Satelite> AllAvailSats = dataContext.Satelites.ToList();
            lstBoxSatelites.DataSource = AllAvailSats;
            lstBoxSatelites.DisplayMember = "SatName";
            lstBoxSatelites.ValueMember = "NORADId";
            LblLoadFeedback.Text = "";
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 1000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.lstBoxSatelites, "Select a Satellite to track");
            toolTip1.SetToolTip(this.lblNbrOfHits, "apparently 1000 hits/day is OK");
            //lstBoxSatelites.SelectedIndex = 0;
            //lstBoxSatelites.SelectedValueChanged += new EventHandler(lstBoxSatelites_MouseClick(System.Windows.Forms.ListBox, WindowState);

            this.webBrowser1.Location = new System.Drawing.Point(300, 110);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 27);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.webBrowser1);
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.ScrollBarsEnabled = false;

            var initPage = @"<html><h1>No satelite selected</h1></html>";

            webBrowser1.DocumentText = initPage;

        }

        private void lstBoxSatelites_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstBoxSatelites_MouseClick(object sender, MouseEventArgs e)
        {
            //initiate a timer/thread to load SatHistoryLog??
            
            lblNbrOfHits.Text = "";
            LblLoadFeedback.Text = "Loading " + lstBoxSatelites.Text + " position data";
            List<string> results = SatInfo.info(lstBoxSatelites.SelectedValue.ToString());
            LblLoadFeedback.Text = "";
            lblSatName.Text = lstBoxSatelites.Text;
            lblNORADId.Text = lstBoxSatelites.SelectedValue.ToString();
            lblLongitude.Text = results[0];
            lblLatitude.Text = results[1];
            lblTimestamp.Text = results[2];
            Global.SatID = lstBoxSatelites.SelectedValue.ToString();
            Global.Longitude = results[0];
            Global.Latitude = results[1];
            Global.TimeStamp = results[2];
            Global.NbrOfHits = results[3];
            lblNbrOfHits.Text = "API says of lookups so far = " + Global.NbrOfHits;

            var dataContext = new SateliteDBContext();

            dataContext.SatHistory.Add(new SatHistoryLog() { SatID = Int32.Parse(Global.SatID), Longitude = Global.Longitude, Latitude = Global.Latitude, TimeStamp = Global.TimeStamp });
            dataContext.SaveChanges();

            string sat1 = Global.SatID;
            var part1 = @"<html>
<meta http-equiv=""X-UA-Compatible"" content=""IE=Edge"" />
<body>

<center>

		<script>
			var norad_n2yo = '" + sat1;
            var part2 = @"';
			var size_n2yo = 'small';
			var allpasses_n2yo = '1';
			var map_n2yo = '2';
		</script>
		<script type=""text/javascript"" src=""https://www.n2yo.com/js/widget-tracker.js""></script><div id=""HQjbb""><iframe style=""border: medium none; overflow: hidden;"" src=""https://www.n2yo.com/widgets/widget-tracker.php?s=" + sat1;
            var part3 = @"&amp;size=small&amp;all=1&amp;me=5&amp;map=2&amp;foot=0"" scrolling=""no"" width=""410"" height=""450""></iframe></div>
</center>
</body>

</html>";
            var part4 = part1 + part2 + part3;
            webBrowser1.DocumentText = part4;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new Settings();
            myForm.TopMost = true;
            myForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var dataContext = new SateliteDBContext();

            //fakring around with filtering
            List<Satelite> AllAvail = dataContext.Satelites.ToList();
            List<Satelite> Filtered = new List<Satelite>();

            foreach (var sat in AllAvail)
            {
                if (sat.SatName.Contains(textBox1.Text))
                {
                    Filtered.Add(sat);
                }

            }
            lstBoxSatelites.DataSource = Filtered;

        }
    }
}