using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace fourien_picomeasure_app
{
    /// <summary>
    /// DataHandler object will be created each time a new file is selected from the file explorer on the form
    /// </summary>
    internal class DataHandler
    {
        public List<double> XData { get; set; }
        public List<double> YData { get; set; }
        public List<double> FitData { get; set; }   //Final product files have 3 columns of data, the 3rd is called FitData
        public string FileLocation { get; set; }
        public string FileContent { get; set; }

        public DataHandler()
        {
            XData = new List<double>();
            YData = new List<double>();
            FitData = new List<double>();
        }

        /// <summary>
        /// Method used to select a file from a directory on local machine. 
        /// </summary>
        public void FileSelection()
        {
            var fileContent = string.Empty; ///This will hold the read in file content
            var filePath = string.Empty;    ///Holds path to selected file.

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";           ///Could narrow the scope of which directory is opened if the program will always run on a proprietary system.
                openFileDialog.Filter = "dat files (*.dat)|*.dat";  ///Currently restricting selection to .dat files.
                openFileDialog.RestoreDirectory = true;     ///Doesn't work at the moment? From what I can tell this should open the file explorer to the last directory we selected from?

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    } 
                }
            }
            this.FileLocation = filePath;
            this.FileContent = fileContent;

        }

        public void Clear()
        {
            this.XData.Clear();
            this.YData.Clear();
            this.FitData.Clear();
        }


        /// <summary>
        /// Breaking the selected file down into the lists of information.
        /// One list for X values, one for Y values and a third for Fit values if they are present.
        /// </summary>
        public void GenerateDataSets()
        {
            try
            {
                List<string> data = this.FileContent.Split('\n').ToList<string>();

                if (data != null)
                {
                    data.RemoveRange(0, 9);
                    foreach (string dataLine in data)
                    {
                        string[] tempDataArray = dataLine.Split(new char[] { ',' , '\t' });
                        if (tempDataArray.Length == 2)
                        {
                            this.XData.Add(double.Parse(tempDataArray[0]));
                            this.YData.Add(double.Parse(tempDataArray[1]));
                        }
                        else if (tempDataArray.Length == 3)
                        {
                            this.XData.Add(double.Parse(tempDataArray[0]));
                            this.YData.Add(double.Parse(tempDataArray[1]));
                            this.FitData.Add(double.Parse(tempDataArray[2]));
                        }
                    }
                }
            }
            catch
            {
                return;
            }
        }

        /// <TODO>
        ///     - Look into saveFileDialog to handle saving similar file as one that already exists.
        /// </TODO>
        /// XML file is for settings. Our program will read the XML file to get the users settings.
        

    }
}

