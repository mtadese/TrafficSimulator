using System;
using System.Windows.Forms;

namespace TrafficSimulator
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        // open the traffic controller module once Begin button is clicked
        private void btnBegin_Click(object sender, EventArgs e)
        {
            TrafficControl trafficPage = new TrafficControl();
            trafficPage.Show();

            this.Hide();
        }        
    }
}
