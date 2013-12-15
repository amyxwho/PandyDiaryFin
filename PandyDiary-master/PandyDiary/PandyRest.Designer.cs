namespace WindowsFormsApplication1
{
    partial class PandyRest
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.restChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_rest = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.restScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restChart)).BeginInit();
            this.SuspendLayout();
            // 
            // restChart
            // 
            chartArea2.Name = "ChartArea1";
            this.restChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.restChart.Legends.Add(legend2);
            this.restChart.Location = new System.Drawing.Point(9, 46);
            this.restChart.MaximumSize = new System.Drawing.Size(351, 375);
            this.restChart.MinimumSize = new System.Drawing.Size(351, 375);
            this.restChart.Name = "restChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.restChart.Series.Add(series2);
            this.restChart.Size = new System.Drawing.Size(351, 375);
            this.restChart.TabIndex = 0;
            this.restChart.Text = "chart1";
            // 
            // lbl_rest
            // 
            this.lbl_rest.AutoSize = true;
            this.lbl_rest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rest.Location = new System.Drawing.Point(12, 9);
            this.lbl_rest.Name = "lbl_rest";
            this.lbl_rest.Size = new System.Drawing.Size(56, 25);
            this.lbl_rest.TabIndex = 1;
            this.lbl_rest.Text = "Rest";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Your rest score is: ";
            // 
            // restScore
            // 
            this.restScore.AutoSize = true;
            this.restScore.Location = new System.Drawing.Point(212, 450);
            this.restScore.Name = "restScore";
            this.restScore.Size = new System.Drawing.Size(61, 13);
            this.restScore.TabIndex = 14;
            this.restScore.Text = "dummyText";
            // 
            // PandyRest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 511);
            this.Controls.Add(this.restScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_rest);
            this.Controls.Add(this.restChart);
            this.MinimumSize = new System.Drawing.Size(391, 473);
            this.Name = "PandyRest";
            this.Text = "Pandy Rest Over Time";
            ((System.ComponentModel.ISupportInitialize)(this.restChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart restChart;
        private System.Windows.Forms.Label lbl_rest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label restScore;
    }
}