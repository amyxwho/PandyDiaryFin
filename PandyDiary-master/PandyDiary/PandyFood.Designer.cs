namespace WindowsFormsApplication1
{
    partial class PandyFood
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.foodChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_food = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.foodScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.foodChart)).BeginInit();
            this.SuspendLayout();
            // 
            // foodChart
            // 
            chartArea1.Name = "ChartArea1";
            this.foodChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.foodChart.Legends.Add(legend1);
            this.foodChart.Location = new System.Drawing.Point(2, 48);
            this.foodChart.MaximumSize = new System.Drawing.Size(351, 375);
            this.foodChart.MinimumSize = new System.Drawing.Size(351, 375);
            this.foodChart.Name = "foodChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.foodChart.Series.Add(series1);
            this.foodChart.Size = new System.Drawing.Size(351, 375);
            this.foodChart.TabIndex = 0;
            this.foodChart.Text = "chart1";
            // 
            // lbl_food
            // 
            this.lbl_food.AutoSize = true;
            this.lbl_food.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_food.Location = new System.Drawing.Point(12, 9);
            this.lbl_food.Name = "lbl_food";
            this.lbl_food.Size = new System.Drawing.Size(61, 25);
            this.lbl_food.TabIndex = 1;
            this.lbl_food.Text = "Food";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Your food score is: ";
            // 
            // foodScore
            // 
            this.foodScore.AutoSize = true;
            this.foodScore.Location = new System.Drawing.Point(217, 452);
            this.foodScore.Name = "foodScore";
            this.foodScore.Size = new System.Drawing.Size(61, 13);
            this.foodScore.TabIndex = 15;
            this.foodScore.Text = "dummyText";
            // 
            // PandyFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 511);
            this.Controls.Add(this.foodScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_food);
            this.Controls.Add(this.foodChart);
            this.MinimumSize = new System.Drawing.Size(391, 473);
            this.Name = "PandyFood";
            this.Text = "Pandy Food Over Time";
            ((System.ComponentModel.ISupportInitialize)(this.foodChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart foodChart;
        private System.Windows.Forms.Label lbl_food;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label foodScore;
    }
}