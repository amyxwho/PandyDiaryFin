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

namespace WindowsFormsApplication1
{
    public partial class PandyApp : Form
    {
        private RFID rfid;
        private InterfaceKit ifKit;
        private Boolean GoodTouch = true;
        PandyVisDesg Pandy = new PandyVisDesg();
        public PandyApp()
        {
            InitializeComponent();

            
         
            Pandy.Show();

        }

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

        //hook up to touch/pressure sensor
        private void timerSocial_Tick(object sender, EventArgs e)
        {
            if (prgbar_social.Value > 0)
            {
                prgbar_social.Increment(-1);
            }
            else
            {
                timerSocial.Stop();
            }

        }

        //hook up to rfid tag
        private void timerFood_Tick(object sender, EventArgs e)
        {
            if (prgbar_food.Value > 0)
            {
                prgbar_food.Increment(-1);
            }
            else
            {
                timerFood.Stop();
            }

        }


        //done for now... investigate battery
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
        public void rfid_Tag(object sender, TagEventArgs e)
        {
           // if (e.Tag.Equals("0106932b02")) 
            if(e.Tag.Equals("0106934a43"))
            {
                if (prgbar_food.Value + 20 > prgbar_food.Maximum)
                    prgbar_food.Value = prgbar_food.Maximum;
                else
                    prgbar_food.Value = prgbar_food.Value + 20;
            }
            else if (e.Tag.Equals("010693293c"))
            {
                Pandy.PandyVisDesg_bodySensor();
            }

        }

        //Tag lost event handler...here we simply want to clear our tag field in the GUI
        public void rfid_TagLost(object sender, TagEventArgs e)
        {
            Pandy.PandyVisDesg_bodySensorOff();

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
            if (e.Value < 10)
            {
                GoodTouch = true;
            }
            else if ((e.Value < 400) && (e.Value > 100) && GoodTouch)
            {
                if (prgbar_social.Value + 10 >= prgbar_social.Maximum)
                    prgbar_social.Value = prgbar_social.Maximum;
                else
                    prgbar_social.Value = prgbar_social.Value + 5;
            }
            else if (e.Value >= 400)
            {
                GoodTouch = false;
                if(prgbar_social.Value <= 10)
                 prgbar_social.Value = 0;
                else
                 prgbar_social.Value = prgbar_social.Value - 5;
            }
        }

        
    }
}
