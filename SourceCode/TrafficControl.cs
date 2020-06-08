using System;
using System.Windows.Forms;

namespace TrafficSimulator
{
    public partial class TrafficControl : Form
    {
        public TrafficControl()
        {
            InitializeComponent();

            // set default status of traffic lights and pedestrian lights before starting
            picRedLight.Visible = true;
            picYellowLight.Visible = false;
            picGreenLight.Visible = false;

            picRedPedestrian.Visible = true  ;
            picGreenPedestrian.Visible = false ;

            picRedLight2.Visible = true;
            picYellowLight2.Visible = false;
            picGreenLight2.Visible = false;

            picRedPedestrian2.Visible = true ;
            picGreenPedestrian2.Visible = false ;


            picRedLight3.Visible = true ;
            picYellowLight3.Visible = false;
            picGreenLight3.Visible = false ;

            picRedPedestrian3.Visible = true ;
            picGreenPedestrian3.Visible = false ;

            picRedLight4.Visible = true;
            picYellowLight4.Visible = false;
            picGreenLight4.Visible = false;

            picRedPedestrian4.Visible = true;
            picGreenPedestrian4.Visible = false;
        }
 
        // set status og all traffic lights and pedestrian lights once timer-1 control is activated
        private void timer1_Tick(object sender, EventArgs e)
        {
            // set condition if red light is turned on
            if (picRedLight.Visible == true)
            {
                picRedLight.Visible = false;
                picYellowLight.Visible = false;
                picGreenLight.Visible = true;

                picRedPedestrian.Visible = true;
                picGreenPedestrian.Visible = false;

                picRedLight2.Visible = false;
                picYellowLight2.Visible = false;
                picGreenLight2.Visible = true;

                picRedPedestrian2.Visible = true;
                picGreenPedestrian2.Visible = false;


                picRedLight3.Visible = true ;
                picYellowLight3.Visible = false;
                picGreenLight3.Visible = false ;

                picRedPedestrian3.Visible = false ;
                picGreenPedestrian3.Visible = true ;

                picRedLight4.Visible = true;
                picYellowLight4.Visible = false;
                picGreenLight4.Visible = false;

                picRedPedestrian4.Visible = false;
                picGreenPedestrian4.Visible = true;
            }

            //set condition if green light is turned on
            else if (picGreenLight.Visible == true)
            {
                picRedLight.Visible = false;
                picYellowLight.Visible = true;
                picGreenLight.Visible = false;

                picRedPedestrian.Visible = false;
                picGreenPedestrian.Visible = true;


                picRedLight2.Visible = false;
                picYellowLight2.Visible = true;
                picGreenLight2.Visible = false;

                picRedPedestrian2.Visible = false;
                picGreenPedestrian2.Visible = true;


                picRedLight3.Visible = false;
                picYellowLight3.Visible = true ;
                picGreenLight3.Visible = false ;

                picRedPedestrian3.Visible = false ;
                picGreenPedestrian3.Visible = true ;

                picRedLight4.Visible = false;
                picYellowLight4.Visible = true;
                picGreenLight4.Visible = false;

                picRedPedestrian4.Visible = false;
                picGreenPedestrian4.Visible = true;
            }

            // set condition if yellow light is turned on
            else if (picYellowLight.Visible == true)
            {
                picRedLight.Visible = true;
                picYellowLight.Visible = false;
                picGreenLight.Visible = false;

                picRedPedestrian.Visible = false;
                picGreenPedestrian.Visible = true;


                picRedLight2.Visible = true;
                picYellowLight2.Visible = false;
                picGreenLight2.Visible = false;

                picRedPedestrian2.Visible = false;
                picGreenPedestrian2.Visible = true;


                picRedLight3.Visible = false;
                picYellowLight3.Visible = false;
                picGreenLight3.Visible = true;

                picRedPedestrian3.Visible = true;
                picGreenPedestrian3.Visible = false;

                picRedLight4.Visible = false;
                picYellowLight4.Visible = false;
                picGreenLight4.Visible = true;

                picRedPedestrian4.Visible = true;
                picGreenPedestrian4.Visible = false;
            }

        }

        // activate the timer controls once Start button is clicked
        private void btnStart_Click(object sender, EventArgs e)
        {            
            timer1.Enabled = true;
            timer2.Enabled = true;

            txtTime.Visible = true;
            panel1.Visible = true;
                                    
        }

        // deactivate the timer controls once Stop button is clicked
        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;

            txtTime.Visible = false ;
            panel1.Visible = false ;
                                    
        }
                
        // exit the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Terminating...");
            //this.Close();
            Application.Exit();
        }

        // conditions for the Arrival Status
        private void cmbArrival_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbArrival.Text == "ALMOST")
            {
                lblArrival.Text = "0";
            }
            else if (cmbArrival.Text == "FEW")
            {
                lblArrival.Text = "2";
            }
            else if (cmbArrival.Text == "MANY")
            {
                lblArrival.Text = "4";
            }
            else if (cmbArrival.Text == "TOO MANY")
            {
                lblArrival.Text = "6";
            }
            

        }

        // set conditions for the Queue status
        private void cmbQueue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbQueue.Text == "VERY SMALL")
            {
                lblQueue.Text = "0";
            }
            else if (cmbQueue.Text == "SMALL")
            {
                lblQueue.Text = "2";
            }
            else if (cmbQueue.Text == "MEDIUM")
            {
                lblQueue.Text = "4";
            }
            else if (cmbQueue.Text == "LARGE")
            {
                lblQueue.Text = "6";
            }


        }

        // apply changes to the traffic light speed once Adjust SPeed button is pressed
        private void btnAdjustSpeed_Click(object sender, EventArgs e)
        {
                       
            if (cmbArrival.Text == "ALMOST" && cmbQueue.Text == "VERY SMALL")
            {
                lblExtention.Text = "0";
            }
            else if (cmbArrival.Text == "ALMOST" && cmbQueue.Text == "SMALL")
            {
                lblExtention.Text = "0";
            }
            else if (cmbArrival.Text == "ALMOST" && cmbQueue.Text == "MEDIUM")
            {
                lblExtention.Text = "0";
            }
            else if (cmbArrival.Text == "ALMOST" && cmbQueue.Text == "LARGE")
            {
                lblExtention.Text = "0";
            }

            else if (cmbArrival.Text == "FEW" && cmbQueue.Text == "VERY SMALL")
            {
                lblExtention.Text = "2";
            }
            else if (cmbArrival.Text == "FEW" && cmbQueue.Text == "SMALL")
            {
                lblExtention.Text = "2";
            }
            else if (cmbArrival.Text == "FEW" && cmbQueue.Text == "MEDIUM")
            {
                lblExtention.Text = "0";
            }
            else if (cmbArrival.Text == "FEW" && cmbQueue.Text == "LARGE")
            {
                lblExtention.Text = "0";
            }

            else if (cmbArrival.Text == "MANY" && cmbQueue.Text == "VERY SMALL")
            {
                lblExtention.Text = "4";
            }
            else if (cmbArrival.Text == "MANY" && cmbQueue.Text == "SMALL")
            {
                lblExtention.Text = "4";
            }

            else if (cmbArrival.Text == "MANY" && cmbQueue.Text == "MEDIUM")
            {
                lblExtention.Text = "2";
            }

            else if (cmbArrival.Text == "MANY" && cmbQueue.Text == "LARGE")
            {
                lblExtention.Text = "0";
            }

            else if (cmbArrival.Text == "TOO MANY" && cmbQueue.Text == "VERY SMALL")
            {
                lblExtention.Text = "6";
            }
            else if (cmbArrival.Text == "TOO MANY" && cmbQueue.Text == "SMALL")
            {
                lblExtention.Text = "4";
            }
            else if (cmbArrival.Text == "TOO MANY" && cmbQueue.Text == "MEDIUM")
            {
                lblExtention.Text = "4";
            }
            else if (cmbArrival.Text == "TOO MANY" && cmbQueue.Text == "LARGE")
            {
                lblExtention.Text = "2";
            }

            int extention = int.Parse(lblExtention.Text);
            int extendedSpeed = extention * 1000;

            timer1.Enabled = false;
            timer1.Enabled = true;

            timer1.Interval = 10000 + extendedSpeed;
            
        }
                
        // display the system time to measure traffic light speed with
        private void timer2_Tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        
    }
}
