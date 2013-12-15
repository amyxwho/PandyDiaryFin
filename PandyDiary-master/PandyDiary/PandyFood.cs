using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/* This application is used so that the parents can keep track of the progress that their child has made with Pandy.
 * No background knowledge is needed at all, since the average value is stated clearly for the user to see.
 * This application, specifically, keeps a track of Pandy's "food score" out of 200. 
 * */
namespace WindowsFormsApplication1
{
    public partial class PandyFood : Form
    {
        public PandyFood()
        {
            InitializeComponent();
        }

        //Reads the input data from the food progress bar
        public void readData(List<int> data)
        {
            int score = 0;
            for (int i = 0; i < data.Count; i++)
            {
                foodChart.Series["Series1"].Points.AddXY(i, data.ElementAt(i));
                score += data.ElementAt(i);
            }
            if (data.Count == 0) { score = 0; }
            else { score = score / data.Count; }
            foodScore.Text = score.ToString(); 
        }
    }
}
