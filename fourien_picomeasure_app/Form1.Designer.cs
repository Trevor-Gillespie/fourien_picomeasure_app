namespace fourien_picomeasure_app
{
    partial class PicomeasureApp
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chtData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnFileSelector = new System.Windows.Forms.Button();
            this.displayFileName = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.fileContentDisplay = new System.Windows.Forms.TextBox();
            this.timerDisplay = new System.Windows.Forms.TextBox();
            this.counterDisplay = new System.Windows.Forms.TextBox();
            this.btnTimer = new System.Windows.Forms.Button();
            this.btnCounter = new System.Windows.Forms.Button();
            this.chkbxLorentz = new System.Windows.Forms.CheckBox();
            this.chkbxRaw = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chtData)).BeginInit();
            this.SuspendLayout();
            // 
            // chtData
            // 
            this.chtData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisY.ScaleView.Zoomable = false;
            chartArea1.CursorX.Interval = 0.01D;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.AutoScroll = false;
            chartArea1.CursorY.Interval = 0.01D;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 92.175F;
            chartArea1.InnerPlotPosition.Width = 95.07004F;
            chartArea1.InnerPlotPosition.X = 4.92996F;
            chartArea1.InnerPlotPosition.Y = 2.1F;
            chartArea1.Name = "RawChartArea";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 83.89304F;
            chartArea1.Position.X = 3F;
            chartArea2.AlignWithChartArea = "RawChartArea";
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.InnerPlotPosition.Auto = false;
            chartArea2.InnerPlotPosition.Height = 92.175F;
            chartArea2.InnerPlotPosition.Width = 95.07004F;
            chartArea2.InnerPlotPosition.X = 4.92996F;
            chartArea2.InnerPlotPosition.Y = 2.1F;
            chartArea2.Name = "LorentzChartArea";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 100F;
            chartArea2.Position.Width = 83.89304F;
            chartArea2.Position.X = 3F;
            this.chtData.ChartAreas.Add(chartArea1);
            this.chtData.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend1";
            this.chtData.Legends.Add(legend1);
            this.chtData.Location = new System.Drawing.Point(342, 57);
            this.chtData.Name = "chtData";
            series1.ChartArea = "RawChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Color = System.Drawing.Color.Turquoise;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "rawData";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BackImageTransparentColor = System.Drawing.Color.Turquoise;
            series2.BackSecondaryColor = System.Drawing.Color.Turquoise;
            series2.ChartArea = "LorentzChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Violet;
            series2.Legend = "Legend1";
            series2.Name = "lorentzian";
            this.chtData.Series.Add(series1);
            this.chtData.Series.Add(series2);
            this.chtData.Size = new System.Drawing.Size(1394, 553);
            this.chtData.TabIndex = 0;
            this.chtData.Text = "Data";
            this.chtData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chtData_MouseClick);
            // 
            // btnFileSelector
            // 
            this.btnFileSelector.Location = new System.Drawing.Point(12, 12);
            this.btnFileSelector.Name = "btnFileSelector";
            this.btnFileSelector.Size = new System.Drawing.Size(228, 39);
            this.btnFileSelector.TabIndex = 1;
            this.btnFileSelector.Text = "Select File";
            this.btnFileSelector.UseVisualStyleBackColor = true;
            this.btnFileSelector.Click += new System.EventHandler(this.btnFileSelectorClick);
            // 
            // displayFileName
            // 
            this.displayFileName.CausesValidation = false;
            this.displayFileName.Location = new System.Drawing.Point(246, 12);
            this.displayFileName.Multiline = true;
            this.displayFileName.Name = "displayFileName";
            this.displayFileName.ReadOnly = true;
            this.displayFileName.Size = new System.Drawing.Size(716, 39);
            this.displayFileName.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Firebrick;
            this.btnClear.Location = new System.Drawing.Point(968, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(177, 39);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClearClick);
            // 
            // fileContentDisplay
            // 
            this.fileContentDisplay.Location = new System.Drawing.Point(11, 57);
            this.fileContentDisplay.Multiline = true;
            this.fileContentDisplay.Name = "fileContentDisplay";
            this.fileContentDisplay.ReadOnly = true;
            this.fileContentDisplay.Size = new System.Drawing.Size(321, 552);
            this.fileContentDisplay.TabIndex = 5;
            // 
            // timerDisplay
            // 
            this.timerDisplay.Location = new System.Drawing.Point(1567, 22);
            this.timerDisplay.Name = "timerDisplay";
            this.timerDisplay.ReadOnly = true;
            this.timerDisplay.Size = new System.Drawing.Size(35, 20);
            this.timerDisplay.TabIndex = 6;
            // 
            // counterDisplay
            // 
            this.counterDisplay.BackColor = System.Drawing.Color.White;
            this.counterDisplay.Location = new System.Drawing.Point(1697, 18);
            this.counterDisplay.Name = "counterDisplay";
            this.counterDisplay.ReadOnly = true;
            this.counterDisplay.Size = new System.Drawing.Size(34, 20);
            this.counterDisplay.TabIndex = 7;
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(1478, 15);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(83, 32);
            this.btnTimer.TabIndex = 8;
            this.btnTimer.Text = "Timer Start";
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // btnCounter
            // 
            this.btnCounter.Location = new System.Drawing.Point(1608, 15);
            this.btnCounter.Name = "btnCounter";
            this.btnCounter.Size = new System.Drawing.Size(83, 32);
            this.btnCounter.TabIndex = 9;
            this.btnCounter.Text = "Counter++";
            this.btnCounter.UseVisualStyleBackColor = true;
            this.btnCounter.Click += new System.EventHandler(this.btnCounter_Click);
            // 
            // chkbxLorentz
            // 
            this.chkbxLorentz.AutoSize = true;
            this.chkbxLorentz.Location = new System.Drawing.Point(1158, 31);
            this.chkbxLorentz.Name = "chkbxLorentz";
            this.chkbxLorentz.Size = new System.Drawing.Size(112, 17);
            this.chkbxLorentz.TabIndex = 10;
            this.chkbxLorentz.Text = "Display Lorentzian";
            this.chkbxLorentz.UseVisualStyleBackColor = true;
            this.chkbxLorentz.CheckedChanged += new System.EventHandler(this.chkbxLorentz_CheckedChanged);
            // 
            // chkbxRaw
            // 
            this.chkbxRaw.AutoSize = true;
            this.chkbxRaw.Checked = true;
            this.chkbxRaw.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbxRaw.Location = new System.Drawing.Point(1159, 9);
            this.chkbxRaw.Name = "chkbxRaw";
            this.chkbxRaw.Size = new System.Drawing.Size(85, 17);
            this.chkbxRaw.TabIndex = 11;
            this.chkbxRaw.Text = "Display Raw";
            this.chkbxRaw.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1276, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(179, 34);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PicomeasureApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1748, 622);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkbxRaw);
            this.Controls.Add(this.chkbxLorentz);
            this.Controls.Add(this.btnCounter);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.counterDisplay);
            this.Controls.Add(this.timerDisplay);
            this.Controls.Add(this.fileContentDisplay);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.displayFileName);
            this.Controls.Add(this.btnFileSelector);
            this.Controls.Add(this.chtData);
            this.Name = "PicomeasureApp";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.chtData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtData;
        private System.Windows.Forms.Button btnFileSelector;
        private System.Windows.Forms.TextBox displayFileName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox fileContentDisplay;
        private System.Windows.Forms.TextBox timerDisplay;
        private System.Windows.Forms.TextBox counterDisplay;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Button btnCounter;
        private System.Windows.Forms.CheckBox chkbxLorentz;
        private System.Windows.Forms.CheckBox chkbxRaw;
        private System.Windows.Forms.Button btnSave;
    }
}

