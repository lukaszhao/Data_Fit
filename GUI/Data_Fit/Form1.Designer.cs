namespace Csharp_001
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonPlotData = new System.Windows.Forms.Button();
            this.buttonReadData = new System.Windows.Forms.Button();
            this.richTextBox_msg = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(32, 36);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Data";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Fit";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(425, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // buttonPlotData
            // 
            this.buttonPlotData.Location = new System.Drawing.Point(515, 65);
            this.buttonPlotData.Name = "buttonPlotData";
            this.buttonPlotData.Size = new System.Drawing.Size(75, 23);
            this.buttonPlotData.TabIndex = 1;
            this.buttonPlotData.Text = "Plot data";
            this.buttonPlotData.UseVisualStyleBackColor = true;
            this.buttonPlotData.Click += new System.EventHandler(this.buttonPlotData_Click);
            // 
            // buttonReadData
            // 
            this.buttonReadData.Location = new System.Drawing.Point(515, 36);
            this.buttonReadData.Name = "buttonReadData";
            this.buttonReadData.Size = new System.Drawing.Size(75, 23);
            this.buttonReadData.TabIndex = 2;
            this.buttonReadData.Text = "Read Data";
            this.buttonReadData.UseVisualStyleBackColor = true;
            this.buttonReadData.Click += new System.EventHandler(this.buttonReadData_Click);
            // 
            // richTextBox_msg
            // 
            this.richTextBox_msg.Location = new System.Drawing.Point(515, 223);
            this.richTextBox_msg.Name = "richTextBox_msg";
            this.richTextBox_msg.Size = new System.Drawing.Size(308, 182);
            this.richTextBox_msg.TabIndex = 3;
            this.richTextBox_msg.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 460);
            this.Controls.Add(this.richTextBox_msg);
            this.Controls.Add(this.buttonReadData);
            this.Controls.Add(this.buttonPlotData);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Data Fit";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonPlotData;
        private System.Windows.Forms.Button buttonReadData;
        private System.Windows.Forms.RichTextBox richTextBox_msg;
    }
}

