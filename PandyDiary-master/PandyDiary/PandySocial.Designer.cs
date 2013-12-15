namespace WindowsFormsApplication1
{
    partial class PandySocial
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
            this.socialChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_social = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.socialScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.socialChart)).BeginInit();
            this.SuspendLayout();
            // 
            // socialChart
            // 
            chartArea1.Name = "ChartArea1";
            this.socialChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Social";
            this.socialChart.Legends.Add(legend1);
            this.socialChart.Location = new System.Drawing.Point(12, 48);
            this.socialChart.MaximumSize = new System.Drawing.Size(351, 375);
            this.socialChart.MinimumSize = new System.Drawing.Size(351, 375);
            this.socialChart.Name = "socialChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Social";
            series1.Name = "Social";
            this.socialChart.Series.Add(series1);
            this.socialChart.Size = new System.Drawing.Size(351, 375);
            this.socialChart.TabIndex = 10;
            this.socialChart.Text = "chart1";
            // 
            // lbl_social
            // 
            this.lbl_social.AutoSize = true;
            this.lbl_social.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_social.Location = new System.Drawing.Point(12, 9);
            this.lbl_social.Name = "lbl_social";
            this.lbl_social.Size = new System.Drawing.Size(71, 25);
            this.lbl_social.TabIndex = 11;
            this.lbl_social.Text = "Social";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Your social score is: ";
            // 
            // socialScore
            // 
            this.socialScore.AutoSize = true;
            this.socialScore.Location = new System.Drawing.Point(218, 435);
            this.socialScore.Name = "socialScore";
            this.socialScore.Size = new System.Drawing.Size(61, 13);
            this.socialScore.TabIndex = 15;
            this.socialScore.Text = "dummyText";
            // 
            // PandySocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 511);
            this.Controls.Add(this.socialScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_social);
            this.Controls.Add(this.socialChart);
            this.MinimumSize = new System.Drawing.Size(391, 473);
            this.Name = "PandySocial";
            this.Text = "Social Progress Over Time";
            ((System.ComponentModel.ISupportInitialize)(this.socialChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart socialChart;
        private System.Windows.Forms.Label lbl_social;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label socialScore;
    }
}