using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Phidgets;
using Phidgets.Events;

/* Attention: This application is for prototyping purposes only. 
 * 
 * Assuming that our project is finalized, the user would not have to see these images to use the toy.
 * This application is used to keep a track of what sensors are currently being used.
 * The micro-USB image is always "on" because Pandy does not have a portable battery source 
 * and needs to be plugged in at all times in order for this demo to work.
 * The methods listed in this code will flip pictures in order to indicate to the user
 * that certain sensors or tag readers are in use. 
 * */
namespace WindowsFormsApplication1
{
    public partial class PandyVisDesg : Form
    {
       // private RFID rfid2;
        public PandyVisDesg()
        {
            InitializeComponent();
        }


        private void PandyVisDesg_Load(object sender, EventArgs e)
        {

        }

        //Flips "on" picture of body RFID sensor
        //Shows picture of collar (accessory)
        public void PandyVisDesg_bodySensor()
        {
            RFIDBodyOn.BringToFront();
            CollarPictureLike.Visible = true;
        }

        //Flips "off" picture of body RFID sensor
        //Hides picture of collar (accessory)
        public void PandyVisDesg_bodySensorOff()
        {
            RFIDBodyOff.BringToFront();
            CollarPictureLike.Visible = false; 
        }

        //Flips "on" picture of the RFID on the mouth
        //Shows picture of bamboo
        public void PandyVisDesg_bambooFoodOn()
        {
            RFIDMouthOn.BringToFront();
            BambooFood.Visible = true;
        }

        //Flips "off" picture of the RFID on the mouth
        //Hides picture of bamboo
        public void PandyVisDesg_bambooFoodOff()
        {
            RFIDMouthOff.BringToFront();
            BambooFood.Visible = false;
        }

        //Flips "on" picture of all touch sensors
        public void PandyVisDesg_TouchSensorOn()
        {
            TouchSenBellyOn.BringToFront();
            TouchSenHeadOn.BringToFront();
            TouchSenLShoulderOn.BringToFront();
            TouchSenRShoulderOn.BringToFront();
        }

        //Flips "off" picture of all touch sensors
        public void PandyVisDesg_TouchSensorOff()
        {
            TouchSenBellyOff.BringToFront();
            TouchSenHeadOff.BringToFront();
            TouchSenLShoulder.BringToFront();
            TouchSenRShoulder.BringToFront();
        }

        //Flips "on" picture of body RFID sensor
        //Shows picture of bow tie 
        public void PandyVisDesg_BodySensorNo()
        {
            RFIDBodyOn.BringToFront();
            BowPic.Visible = true;

        }

        //Flips "off" picture of body RFID sensor
        //Hides picture of bow tie 
        public void PandyVisDesg_BodySensorNoOff()
        {
            RFIDBodyOff.BringToFront();
            BowPic.Visible = false;

        }

        //Flips "on" picture of body RFID sensor
        //Shows picture of present 
        public void PandyVisDesg_PresentOn()
        {
            RFIDBodyOn.BringToFront();
            PresentPic.Visible = true;
        }

        //Flips "off" picture of body RFID sensor
        //Shows picture of present
        public void PandyVisDesg_PresentOff()
        {
            RFIDBodyOff.BringToFront();
            PresentPic.Visible = false;
        }

        //Flips "on" picture of body RFID sensor
        //Shows picture of cupcake
        public void PandyVisDesg_cupcakeOn()
        {
            cupcakePic.Visible = true;
        }

        //Flips "off" picture of body RFID sensor
        //Hides picture of cupcake
        public void PandyVisDesg_cupcakeOff()
        {
            cupcakePic.Visible = false;
        }
    }
}
