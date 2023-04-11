namespace Lab16
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.btnClosePort = new System.Windows.Forms.Button();
            this.btnClearChart = new System.Windows.Forms.Button();
            this.lblCurrentAcceleration = new System.Windows.Forms.Label();
            this.lblAcceleration = new System.Windows.Forms.Label();
            this.chData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chData)).BeginInit();
            this.SuspendLayout();
            // 
            // cboPorts
            // 
            this.cboPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(12, 23);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(138, 21);
            this.cboPorts.TabIndex = 0;
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(13, 60);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(65, 23);
            this.btnOpenPort.TabIndex = 1;
            this.btnOpenPort.Text = "Open Port";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // btnClosePort
            // 
            this.btnClosePort.Enabled = false;
            this.btnClosePort.Location = new System.Drawing.Point(85, 60);
            this.btnClosePort.Name = "btnClosePort";
            this.btnClosePort.Size = new System.Drawing.Size(65, 23);
            this.btnClosePort.TabIndex = 1;
            this.btnClosePort.Text = "Close Port";
            this.btnClosePort.UseVisualStyleBackColor = true;
            this.btnClosePort.Click += new System.EventHandler(this.btnClosePort_Click);
            // 
            // btnClearChart
            // 
            this.btnClearChart.Location = new System.Drawing.Point(32, 100);
            this.btnClearChart.Name = "btnClearChart";
            this.btnClearChart.Size = new System.Drawing.Size(102, 39);
            this.btnClearChart.TabIndex = 2;
            this.btnClearChart.Text = "Clear Chart";
            this.btnClearChart.UseVisualStyleBackColor = true;
            this.btnClearChart.Click += new System.EventHandler(this.btnClearChart_Click);
            // 
            // lblCurrentAcceleration
            // 
            this.lblCurrentAcceleration.AutoSize = true;
            this.lblCurrentAcceleration.Location = new System.Drawing.Point(62, 188);
            this.lblCurrentAcceleration.Name = "lblCurrentAcceleration";
            this.lblCurrentAcceleration.Size = new System.Drawing.Size(34, 13);
            this.lblCurrentAcceleration.TabIndex = 3;
            this.lblCurrentAcceleration.Text = "0.000";
            this.lblCurrentAcceleration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAcceleration
            // 
            this.lblAcceleration.AutoSize = true;
            this.lblAcceleration.Location = new System.Drawing.Point(29, 166);
            this.lblAcceleration.Name = "lblAcceleration";
            this.lblAcceleration.Size = new System.Drawing.Size(103, 13);
            this.lblAcceleration.TabIndex = 4;
            this.lblAcceleration.Text = "Current Acceleration";
            // 
            // chData
            // 
            chartArea2.Name = "ChartArea1";
            this.chData.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chData.Legends.Add(legend2);
            this.chData.Location = new System.Drawing.Point(162, 23);
            this.chData.Name = "chData";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chData.Series.Add(series2);
            this.chData.Size = new System.Drawing.Size(401, 190);
            this.chData.TabIndex = 5;
            this.chData.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 241);
            this.Controls.Add(this.chData);
            this.Controls.Add(this.lblAcceleration);
            this.Controls.Add(this.lblCurrentAcceleration);
            this.Controls.Add(this.btnClearChart);
            this.Controls.Add(this.btnClosePort);
            this.Controls.Add(this.btnOpenPort);
            this.Controls.Add(this.cboPorts);
            this.Name = "Form1";
            this.Text = "Acceleration Grapher";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPorts;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.Button btnClosePort;
        private System.Windows.Forms.Button btnClearChart;
        private System.Windows.Forms.Label lblCurrentAcceleration;
        private System.Windows.Forms.Label lblAcceleration;
        private System.Windows.Forms.DataVisualization.Charting.Chart chData;
    }
}

