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

        public void PandyVisDesg_bodySensor()
        {
            RFIDBodyOn.BringToFront();
            CollarPictureLike.Visible = true;
        }

        public void PandyVisDesg_bodySensorOff()
        {
            RFIDBodyOff.BringToFront();
            CollarPictureLike.Visible = false; 
        }


    }
}
