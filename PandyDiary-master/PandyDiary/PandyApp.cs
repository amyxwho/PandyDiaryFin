using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Phidgets;
using Phidgets.Events;

/* This application comes with our Pandy for parents to 
 * monitor their children's efforts toward taking care of Pandy.
 * We took most of our code from the RFID lab and the Phidget Interface lab in class. 
 * */
namespace WindowsFormsApplication1
{
    public partial class PandyApp : Form
    {
        private RFID rfid;
        private InterfaceKit ifKit;
        private Boolean GoodTouch = true;
        protected List<int> restData = new List<int>();
        protected List<int> socialData = new List<int>();
        protected List<int> foodData = new List<int>();
        PandyVisDesg Pandy = new PandyVisDesg();
      //  PandySocial social = new PandySocial();
      //  PandyRest rest = new PandyRest();
     //   PandyFood food = new PandyFood();
        public PandyApp()
        {
            InitializeComponent();
            Pandy.Show();
         
        }

        //applies RFID methods -- from Interface-FULL lab
        private void PandyApp_Load(object sender, EventArgs e)
        {
            rfid = new RFID();
            rfid.Attach += new AttachEventHandler(rfid_Attach);

            rfid.Detach += new DetachEventHandler(rfid_Detach);

            rfid.Tag += new TagEventHandler(rfid_Tag);
            rfid.TagLost += new TagEventHandler(rfid_TagLost);

            rfid.open();

                ifKit = new InterfaceKit();
                ifKit.Attach += new AttachEventHandler(ifKit_Attach);
                ifKit.Detach += new DetachEventHandler(ifKit_Detach);
                ifKit.SensorChange += new SensorChangeEventHandler(ifKit_SensorChange);

                openCmdLine(ifKit);
        }

        #region Command line open functions
        private void openCmdLine(Phidget p)
        {
            openCmdLine(p, null);
        }
        private void openCmdLine(Phidget p, String pass)
        {
            int serial = -1;
            int port = 5001;
            String host = null;
            bool remote = false, remoteIP = false;
            string[] args = Environment.GetCommandLineArgs();
            String appName = args[0];

            try
            { //Parse the flags
                for (int i = 1; i < args.Length; i++)
                {
                    if (args[i].StartsWith("-"))
                        switch (args[i].Remove(0, 1).ToLower())
                        {
                            case "n":
                                serial = int.Parse(args[++i]);
                                break;
                            case "r":
                                remote = true;
                                break;
                            case "s":
                                remote = true;
                                host = args[++i];
                                break;
                            case "p":
                                pass = args[++i];
                                break;
                            case "i":
                                remoteIP = true;
                                host = args[++i];
                                if (host.Contains(":"))
                                {
                                    port = int.Parse(host.Split(':')[1]);
                                    host = host.Split(':')[0];
                                }
                                break;
                            default:
                                goto usage;
                        }
                    else
                        goto usage;
                }

                if (remoteIP)
                    p.open(serial, host, port, pass);
                else if (remote)
                    p.open(serial, host, pass);
                else
                    p.open(serial);
                return; //success
            }
            catch { }
        usage:
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Invalid Command line arguments." + Environment.NewLine);
            sb.AppendLine("Usage: " + appName + " [Flags...]");
            sb.AppendLine("Flags:\t-n   serialNumber\tSerial Number, omit for any serial");
            sb.AppendLine("\t-r\t\tOpen remotely");
            sb.AppendLine("\t-s   serverID\tServer ID, omit for any server");
            sb.AppendLine("\t-i   ipAddress:port\tIp Address and Port. Port is optional, defaults to 5001");
            sb.AppendLine("\t-p   password\tPassword, omit for no password" + Environment.NewLine);
            sb.AppendLine("Examples: ");
            sb.AppendLine(appName + " -n 50098");
            sb.AppendLine(appName + " -r");
            sb.AppendLine(appName + " -s myphidgetserver");
            sb.AppendLine(appName + " -n 45670 -i 127.0.0.1:5001 -p paswrd");
            MessageBox.Show(sb.ToString(), "Argument Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Application.Exit();
        }
        #endregion

        //Hook up to touch/pressure sensor
        //Implements a timer to allow the social progress bar to decrement.
        //We've implemented a system with arbitrary values that will allow the 
        //bar to decrement by larger values so that the lonelier Pandy is, 
        //the faster the bar will decrement.
        private void timerSocial_Tick(object sender, EventArgs e)
        {
            if (prgbar_social.Value > 160)
            {
                prgbar_social.Increment(-1);
            }
            else if (prgbar_social.Value > 60)
            {
                prgbar_social.Increment(-2);
            }
            else if (prgbar_social.Value > 0)
            {
                prgbar_social.Increment(-3);
            }
            else
            {
                timerSocial.Stop();
            }

        }

        //Hook up to RFID tag
        //Implements a timer to allow the food progress bar to decrement.
        //We've implemented a system with arbitrary values that will allow the 
        //bar to decrement by a larger value when Pandy is "more hungry".
        private void timerFood_Tick(object sender, EventArgs e)
        {
            if (prgbar_food.Value > 160)
            {
                prgbar_food.Increment(-1);
            }
            else if (prgbar_food.Value > 60)
            {
                prgbar_food.Increment(-2);
            }
            else if (prgbar_food.Value > 0)
            {
                prgbar_food.Increment(-3);
            }
            else
            {
                timerFood.Stop();
            }

        }

        //Implements a timer to allow the rest progress bar to increment.
        //Rest bar starts at 0, increments by 1 to simulate charging
        //since Pandy does not have a portable battery source. 
        private void timerRest_Tick(object sender, EventArgs e)
       {
            if (prgbar_rest.Value < prgbar_rest.Maximum)
            {
                prgbar_rest.Increment(1);
            }
            else
            {
                timerRest.Stop();
            }

        }

        //Implements a timer to allow the chart values to update 
        private void graphTimer_Tick(object sender, EventArgs e)
        {
            foodData.Add(prgbar_food.Value);
            socialData.Add(prgbar_social.Value);
            restData.Add(prgbar_rest.Value);
        }


        

        // This code runs when you attach the RFID Phidget to your computer
        public void rfid_Attach(object sender, AttachEventArgs e)
        {
            RFID attached = (RFID)sender;
        }

        // This code runs when you detach the RFID Phidget from your computer
        //detach event handler...clear all the fields, display the attached status, and disable the checkboxes.
        public void rfid_Detach(object sender, DetachEventArgs e)
        {
            RFID detached = (RFID)sender;

        }

        // When the Phidget is reading an RFID...
        // We chose specific RFIDs and their IDs to represent certain features:
        public void rfid_Tag(object sender, TagEventArgs e)
        {
            //One RFID represents the cupcake, one RFID represents the bamboo
            if(e.Tag.Equals("0106934a43") || e.Tag.Equals("0106935267"))
            {
                //Differentiates between bamboo and cupcake on the Visual Designer App
                if (e.Tag.Equals("0106934a43"))
                {
                    Pandy.PandyVisDesg_bambooFoodOn();
                }
                else 
                {
                    Pandy.PandyVisDesg_cupcakeOn();
                }
                    //The RFID will increment by a larger value when Pandy is more hungry.
                    //It simulates the "getting full" feeling.
                    if (prgbar_food.Value + 10 > prgbar_food.Maximum)
                    {
                        prgbar_food.Value = prgbar_food.Maximum;
                    }
                    else if (prgbar_food.Value > 160)
                    {
                        prgbar_food.Value = prgbar_food.Value + 10;
                    }
                    else if (prgbar_food.Value > 60)
                    {
                        prgbar_food.Value = prgbar_food.Value + 15;
                    }
                    else
                    {
                        prgbar_food.Value = prgbar_food.Value + 30;
                    }
            }
            
            //The following RFIDs represent accessories and 
            //will change the visual designer application accordingly.
            else if (e.Tag.Equals("010693293c"))
            {
                Pandy.PandyVisDesg_bodySensor();
            }
            else if (e.Tag.Equals("010693613d"))
            {
                Pandy.PandyVisDesg_BodySensorNo();
            }
            else if (e.Tag.Equals("010693311e"))
            {
                Pandy.PandyVisDesg_PresentOn();
            }
        }

        //Tag lost event handler...here we simply want to clear our tag field in the GUI
        //Reverts the Visual Designer Application to its default.
        public void rfid_TagLost(object sender, TagEventArgs e)
        {
            Pandy.PandyVisDesg_bodySensorOff();
            Pandy.PandyVisDesg_bambooFoodOff();
            Pandy.PandyVisDesg_BodySensorNoOff();
            Pandy.PandyVisDesg_PresentOff();
            Pandy.PandyVisDesg_cupcakeOff();
        }


        //IfKit attach event handler
        public void ifKit_Attach(object sender, AttachEventArgs e)
        {
            InterfaceKit ifKit = (InterfaceKit)sender;
        }

        //Ifkit detach event handler
        public void ifKit_Detach(object sender, DetachEventArgs e)
        {
            InterfaceKit ifKit = (InterfaceKit)sender;
        }

        //Sensor input change event handler
        public void ifKit_SensorChange(object sender, SensorChangeEventArgs e)
        {
            //Differentiates between "good touches" and "bad touches" based on
            //amount of force exerted onto the force sensor.
            Pandy.PandyVisDesg_TouchSensorOff();
            if (e.Value < 10)
            {
                  GoodTouch = true;
                    }
            else if ((e.Value < 450) && (e.Value > 100) && GoodTouch)
            {
                if (prgbar_social.Value + 10 >= prgbar_social.Maximum)
                {
                    Pandy.PandyVisDesg_TouchSensorOn();
                    prgbar_social.Value = prgbar_social.Maximum;
                   }
                else
                {
                    Pandy.PandyVisDesg_TouchSensorOn();
                    prgbar_social.Value = prgbar_social.Value + 5;
                  }
            }
            else if (e.Value >= 450)
            {
                GoodTouch = false;
                if (prgbar_social.Value <= 10)
                {
                    Pandy.PandyVisDesg_TouchSensorOn();
                    prgbar_social.Value = 0;
                }

                else
                {
                    Pandy.PandyVisDesg_TouchSensorOn();
                    prgbar_social.Value = prgbar_social.Value - 2;
                }
            }
        }

        //Allows the social progress chart window to appear
        private void prgbar_social_Click(object sender, EventArgs e)
        {
            PandySocial social = new PandySocial();
            social.readData(socialData);
            social.Show();
        }
        //Allows the rest progress chart window to appear
        private void prgbar_rest_Click(object sender, EventArgs e)
        {
            PandyRest rest = new PandyRest();
            rest.readData(restData);
            rest.Show();
        }
        //Allows the food progress chart window to appear
        private void prgbar_food_Click(object sender, EventArgs e)
        {
            PandyFood food = new PandyFood();
            food.readData(foodData);
            food.Show();
        }



        
    }
}
