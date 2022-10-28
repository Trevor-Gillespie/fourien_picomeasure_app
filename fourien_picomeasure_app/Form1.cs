using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;


namespace fourien_picomeasure_app
{

    public partial class PicomeasureApp : Form
    {

        //Here are some changes that I want to test a push to github - by Trevor
        //Comment added by Mikel

        DataHandler dataHandler = new DataHandler();
        //Replace old data once new data exists (Once thread is complete). Thread handles new data coming in and once the data is complete it is then assigned to the chart/dataHandler/where it needs to go.


        public PicomeasureApp()
        {
            InitializeComponent();
            fileContentDisplay.ScrollBars = ScrollBars.Vertical;
            counterDisplay.Text = "" + 0;
            timerDisplay.Text = "" + 0;
            chtData.ChartAreas[0].AxisX.LabelStyle.Format = "{0:0}";
        }
        
        ///<todo>
        /// - [DONE] Add the ability to select a point on the chart and have the coordinates display.
        /// - [DONE] Adjust the X-Axis legend so the values are whole numbers and they have a higher resolution, maybe every 100? 
        ///</todo>


        /// <summary>
        /// DataHandler object is created after the 'btnFileSelector' is clicked. Each time the button is clicked, the old DataHandler is disposed of and a new one is created. Makes sure the chart only displays 1 set of data.
        /// </summary>
        /// 
        /// <todo>
        ///     - Thread away the work happening in this method
        ///     - 
        /// </todo>
        /// 
        /// <param name="sender">Built-in</param>
        /// <param name="e">Built-in</param>
        private void btnFileSelectorClick(object sender, EventArgs e)
        {
            //Don't assign any data until the thread is done executing. If we use one.
            //Ensure the FileSelection is complete and able to pass the fileContent to the GenerateDataSets function. Events is an option.
            dataHandler.FileSelection();
            dataHandler.GenerateDataSets();
            displayFileName.Text = dataHandler.FileLocation.ToString();

            chtData.Series["rawData"].Points.DataBindXY(dataHandler.XData, dataHandler.YData);
            double yMax = dataHandler.YData.Max() + 5;
            chtData.ChartAreas[0].AxisY.Maximum = yMax;
            //MessageBox.Show(dataHandler.YData.Max().ToString());
            fileContentDisplay.Text = dataHandler.FileContent.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ///<TODO>
            ///     - Write save file method in datahandler and insert it here for on-click
            /// </TODO>
        }

        /// <summary>
        ///  Create a Point variable that is nullable and a new tooltip object outside of the function that will be used during mouse click event on chart. You must click directly on a datapoint to have it display, if you click anywhere else, the popup will be discarded.
        /// </summary>
        Point? prevPosition = null;
        ToolTip tooltip = new ToolTip();
        private void chtData_MouseClick(object sender, MouseEventArgs e)
        {
            var pos = e.Location; //Event type needs to be a MouseEventArg because a regular EventArg does not have a location value.

            if (prevPosition.HasValue && pos == prevPosition.Value)
                return; //If you click on the same area as you did previously, the function stops here.

            tooltip.RemoveAll(); 
            prevPosition = pos;
            var results = chtData.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint);
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint)
                {
                    var prop = result.Object as DataPoint;
                    if (prop != null)
                    {

                        var pointXPixel = result.ChartArea.AxisX.ValueToPixelPosition(prop.XValue);
                        var pointYPixel = result.ChartArea.AxisY.ValueToPixelPosition(prop.YValues[0]);

                        //tooltip.Show("X=" + prop.XValue + ", Y=" + prop.YValues[0], this.chtData, pos.X, pos.Y);  --This option doesn't reduce the decimal places of the datapoint.

                        tooltip.Show($"X= {prop.XValue:0.0}, Y= {prop.YValues[0]:0.0}", this.chtData);

                    }
                }
            }
        }


        /// <TODO>
        ///     - Add second chart area overlayed on first that is transparent. THIS IS THE WAY. Must do this because the Lorentz curve will not have an identical number of data points to the raw data chart. The mismatch causes an error and crash.
        /// </TODO>
        
        /// <summary>
        /// Checking this box displays the Lorentz curve over the raw data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkbxLorentz_CheckedChanged(object sender, EventArgs e)
        {
            chtData.Series["lorentzian"].Points.DataBindXY(dataHandler.XData, dataHandler.FitData);
        }


        /// <summary>
        /// This just clears the chart. Doesn't remove data from the DataHandler Object.
        /// </summary>
        private void btnClearClick(object sender, EventArgs e)
        {
            foreach(var series in chtData.Series)
            {
                dataHandler.Clear();
                series.Points.Clear();
            }
        }







        private void btnTimer_Click(object sender, EventArgs e)
        {
            Timer();
        }
        public void Timer()
        {
            int time = 0;
            for(int i = 0; i < 30; i++)
            {
                time += 1;
                timerDisplay.Text = time.ToString();
            }
        }
        private void btnCounter_Click(object sender, EventArgs e)
        {
            Counter();
            //Thread t = new Thread(Counter);
            //t.Start();
        }
        public void Counter()
        {
            int count = int.Parse(counterDisplay.Text);
            count += 1;
            counterDisplay.Text = count.ToString();
        }

        
    }
}
