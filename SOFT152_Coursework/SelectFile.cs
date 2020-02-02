using System;
using System.Windows.Forms;
using System.IO; //Removes the need to type System.IO to access streamreader, Impoves readabiility

namespace SOFT152_Coursework
{
    public partial class SelectFile : Form
    {
        public SelectFile()
        {
            InitializeComponent();
        }

        private string localFilePath;
        public string GetlocalFilePath()
        {
            return localFilePath;
        }


        //private Locations[] locationArray = Data.locationArray; 

        private int GetNumLinesInFile(string filePath)
        {
            using (StreamReader file = new StreamReader(filePath))
            {
                int i = 0;
                while (file.ReadLine() != null) { i++; } //Loop through each line in file and increment till the end of file to count number of iterations
                return i;//returns number of lines in the file
            }
        }

        private void DisplayItems(string inputLine, int i)
        {
            //Adds the passed in string to the list box and 
            lstboxDisplay.Items.Add(inputLine);
            if (!(ProgressBarValidity.Value + 1 > ProgressBarValidity.Maximum))
            {
                ProgressBarValidity.Value += 1;
            }
        }

        private void ProgressBarSetUp(int numLines)
        {
            //sets up the progress bar ready to be used when selecting a file.
            lstboxDisplay.Items.Clear();
            ProgressBarValidity.Value = 0;
            if (numLines < 40)
            {
                ProgressBarValidity.Maximum = numLines;
            }
            else
            {
                ProgressBarValidity.Maximum = 40;
            }

        }

        private void GetStats(string filename)
        {
            lblFileName.Text = filename;
            lblFileLen.Text = Convert.ToString(GetNumLinesInFile(localFilePath)) + " Lines";
            FileInfo fileInfo = new FileInfo(localFilePath);
            lblFileSize.Text = Convert.ToString(fileInfo.Length) + " Bytes";
            lblFilePath.Text = localFilePath;
        }

        private void ReadFile()
        {
            try
            {
                //Using block automatically closes the streamreader 
                using (StreamReader fileReader = new StreamReader(localFilePath)) //opening file at specified filepath
                {
                    string inputLine;
                    int runningTotalOfLines = 0;
                    int numLinesinFile = GetNumLinesInFile(localFilePath);
                    ProgressBarSetUp(numLinesinFile);
                    while (((inputLine = fileReader.ReadLine()) != null) && (runningTotalOfLines <= 40))//loops through each line in file and displays them as an item in a listview
                    {
                        DisplayItems(inputLine, runningTotalOfLines++);
                    }
                    if (numLinesinFile <= 40)
                    {
                        lstboxDisplay.Items.Add("");
                        lstboxDisplay.Items.Add("");
                        lstboxDisplay.Items.Add("------End of File------");
                    }
                }
            }
            catch (Exception ex) //used to catch and debug any exceptions thrown when opening a file
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "txt files (*.txt)|*.txt";
            dlg.ShowDialog();//displays file selector
            if (File.Exists(dlg.FileName))
            {
                localFilePath = dlg.FileName; //sets the selected files address to the variable
                ReadFile();
                GetStats(dlg.SafeFileName);
                Data.currentFilePath = localFilePath;
                Data.locationArray = Data.DistributeDataToArrays(localFilePath);
                int check = Check();
                if ((check == 0))
                {
                    //ProgressBarValidity.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    //ProgressBarValidity.ForeColor = System.Drawing.Color.Red;
                    OutputErrorMessage(check);
                }
            }
        }

        private void OutputErrorMessage(int errorNumber)
        {
            if (errorNumber == 1)
            {
                MessageBox.Show("Incorrect data format", "File read error");
            }
            else if (errorNumber == 2) 
            {
                MessageBox.Show("Please Select a File", "No file selected");
            }
                
        }

        private int Check()
        {
            if ((localFilePath != "No File Selected") && (localFilePath != null))
            {
                if (Data.locationArray != null)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return 2;
            }
        }


        private void BtnConfirmFile_Click(object sender, EventArgs e)
        {
            int check = Check();

            if (check == 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                OutputErrorMessage(check);
            }
        }
    }
}
