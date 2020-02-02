using System;
using System.Windows.Forms;
using System.Drawing;

namespace SOFT152_Coursework
{
    public partial class MainForm : Form
    {
        public MainForm()
        { 
            InitializeComponent();
        }

        #region file scope variables
        //start settings
        private bool advancedMode = true;
        private bool editMode = false;

        //process variables
        private bool locDataChanged = false;
        private bool monthDataChanged = false;
        private bool commentDataChanged = false;
        private Locations[] localLocationArray;
        private Point[] pointArray = new Point[12];
        private int prevSelectedLocationIndex = -1;
        private int prevSelectedYearIndex = -1;
        private bool firstEdit = true;
        #endregion

        #region Form Load and setup
        private void MainForm_Load(object sender, EventArgs e)
        {
            ResizeForm();

            //open the select file form and hide current form 
            SelectFile selectFile = new SelectFile();
            if (selectFile.ShowDialog() == DialogResult.OK)
            {
                InitilizeComboBoxes(Data.locationArray);
                CboSelectLocation.SelectedItem = Data.locationArray[0].GetLocName();
                CboSelectYear.SelectedItem = Data.locationArray[0].GetYearArray()[Data.locationArray[0].GetYearArray().Length - 1].GetYearID();
                CboScope.SelectedIndex = 0;
                CboProperty.SelectedIndex = 0;
                this.ActiveControl = CboSelectLocation;
            }
            else
            {
                MessageBox.Show("File selection closed", "End");
                this.Close();
            }
            selectFile.Dispose();

        }

        private void UpdateLocationLabels(Locations[] locationArray, int i)
        {
            //update all text boxes
            TxtLocNameDisplay.Text = locationArray[i].GetLocName();
            TxtStrtNameDisplay.Text = locationArray[i].GetStreetName();
            TxtStrtNameDisplay.Text = locationArray[i].GetStreetName();
            TxtCountyDisplay.Text = locationArray[i].GetCounty();
            TxtPostCodeDisplay.Text = locationArray[i].GetPostcode();
            TxtLatitudeDisplay.Text = locationArray[i].GetLatitude().ToString();
            TxtLongitudeDisplay.Text = locationArray[i].GetLongitude().ToString();
        }


        //---------------------------------------------------------------------
        //Selecting first location and first year------------------------------
        private void InitilizeComboBoxes(Locations[] locationArray) //adds all the locations into the location selection box, and selects the first location, year and month.
        {     
            //Removes the "No data" fillter texts
            CboSelectLocation.Items.Clear();
            CboSelectYear.Items.Clear();
            lblcurrentFilePath.Text = Data.currentFilePath;
            //adds all the location names to the combo boxes
            for (int location = 0; location < locationArray.Length; location++)
            {
                CboSelectLocation.Items.Add(locationArray[location].GetLocName());
            }
            //adds all the years available for the first location in the locations array
            int numYears = locationArray[0].GetYearArray().Length;
            for (int year = numYears; year >= 1; year--) //counts backwards so that years are displayed in decending order (personal preference)
            {
                CboSelectYear.Items.Add(locationArray[0].GetYearArray()[year-1].GetYearID());
            }

        }
#endregion

        #region Loading year and locations into the UI
        private void LoadNewLocation(ref Locations[] locationArray)
        {
            //clears the items for the previous location
            CboSelectYear.Items.Clear();
            //adds the years for the selected location by looping though the array of years for the selected locations index
            int selectedLocation = CboSelectLocation.SelectedIndex;

                TxtCommentDisplay.Enabled = true;
                BtnNextFinalYear.Enabled = true;
                BtnNextYear.Enabled = true;
                BtnPreviousFinalYear.Enabled = true;
                BtnPreviousYear.Enabled = true;
                int numYears = locationArray[selectedLocation].GetYearArray().Length;
                for (int yearCount = numYears; yearCount >= 1; yearCount--)
                {
                    CboSelectYear.Items.Add(locationArray[selectedLocation].GetYearArray()[yearCount - 1].GetYearID()); //Reason for "[j-1]": The .length array property returns a value that counts from 0 ...
                                                                                                                        //... starting at 1 such that the value is 1 greater than the actual max value. 
                    if (editMode)
                        UpdateLocationLabels(localLocationArray, selectedLocation);
                    else
                        UpdateLocationLabels(Data.locationArray, selectedLocation);
                }
                CboSelectYear.SelectedItem = locationArray[selectedLocation].GetYearArray()[numYears - 1].GetYearID();
                TxtCommentDisplay.Text = locationArray[selectedLocation].GetYearArray()[numYears - 1].GetYearComment();
          
        }

        private void LoadNewYear(ref Locations[] locationArray)
        {
            //Clears DataGridView
            DgvDisplayData.DataSource = null;
            DgvDisplayData.Rows.Clear();
            Locations thisLocation = locationArray[CboSelectLocation.SelectedIndex];
            int numYears = thisLocation.GetYearArray().Length;
            int selectedYear = numYears - CboSelectYear.SelectedIndex;
            Years thisYear = thisLocation.GetYearArray()[selectedYear - 1];
            Console.WriteLine(thisLocation.GetLocName() + ", " + thisYear.GetYearID() + "  ||  EditMode: " + editMode); //Testing
            //loop gets all the data for each month and adds it to the DataGridView
            for (int month = 0; month < 12; month++)
            {
                //creates a local copy of the monthly observations array for readability
                MonthlyObservations[] monthArray = thisYear.GetMonthlyObservationArray();
                //a local variable for each property of a month is made
                string monthName = GetMonthName(monthArray[month].GetMonthID());
                double maxTemp = monthArray[month].GetMaxTemp();
                double minTemp = monthArray[month].GetMinTemp();
                int numDaysOfFrost = monthArray[month].GetNumDaysOfFrost();
                double mmOfRain = monthArray[month].GetMmOfRain();
                double hoursOfSunshine = monthArray[month].GetSunshine();
                DgvDisplayData.Rows.Add(monthName, maxTemp, minTemp, numDaysOfFrost, mmOfRain, hoursOfSunshine); //a new row is added to the DataGridView
                //dgvDisplayData.Rows[k].HeaderCell.Value = monthName;
            }
            TxtCommentDisplay.Text = thisYear.GetYearComment();
            LblYearDisplay.Text = thisYear.GetYearID().ToString();
            UpdateAnalysis();
            UpdatePointArray();
            GrpGraphs.Refresh();
        }
        private string GetMonthName(int monthID) //used to convert the month id into their actual names to be displayed.
        {
            string[] months = new string[] { null, "January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            return months[monthID];
        }
        #endregion

        #region Detection of new location or year selected
        /* edit mode return code Key:
         * 0 - No error
         * 1 - Not all cells contain valid month data
         * 2 - Data format error has occured in a location data field
         * 3 - User cancelled saving
         * -1 - ERROR, all checks bypassed. 
         */
        private void CboSelectLocation_SelectedIndexChanged(object sender, EventArgs e) //detects when a new location has been selected
        {
            if (CboSelectLocation.SelectedIndex != prevSelectedLocationIndex)
            {
                if (editMode)
                {
                    //Checks to see if data is valid for saving. 
                    int checkReturnVal = CheckDataChanged();
                    if (checkReturnVal == 0 || checkReturnVal == 3)
                    {
                        //if data is valid load new location
                        LoadNewLocation(ref localLocationArray);
                    }
                    else
                    {
                        //if data is not valid or an error in saving has occured, cancel chaning location.
                        Console.WriteLine("Check failed. Error number: " + checkReturnVal);
                        CboSelectLocation.SelectedIndex = prevSelectedLocationIndex;
                        UpdateLocationLabels(localLocationArray, prevSelectedLocationIndex);
                    }
                }
                else if (!editMode)
                {
                    LoadNewLocation(ref Data.locationArray);
                }
            }
            prevSelectedLocationIndex = CboSelectLocation.SelectedIndex;
            locDataChanged = false;
        }
        private void CboSelectYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            locDataChanged = false;
            if (editMode)
            {
                //Checks to see if data is valid for saving. 
                int checkReturnVal = CheckDataChanged();
                if (checkReturnVal == 0 || checkReturnVal == 3)
                {
                    //if data is valid load new year into table
                    LoadNewYear(ref localLocationArray);
                }
                else
                {
                    //cancel loading a new year into the table if the conditions for saving are not met
                    Console.WriteLine("Check failed. Error number: " + checkReturnVal);
                    CboSelectYear.SelectedIndex = prevSelectedYearIndex;
                    UpdateLocationLabels(localLocationArray, prevSelectedLocationIndex);
                }
            }
            else if (!editMode)
            {
                LoadNewYear(ref Data.locationArray);
            }
            prevSelectedYearIndex = CboSelectYear.SelectedIndex;
            
        }
        #endregion
        private int CheckDataChanged() 
        {
            //data is only saved when it needs to be (when the user has changed any of the input values.)
            if (editMode && locDataChanged)
            {
                locDataChanged = false;
                int returnVal;
                if (MessageBox.Show("Changes have been made to the location of " + CboSelectLocation.Items[prevSelectedLocationIndex] + ". Commit changes before continuing?", "Confirm", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    returnVal = LocalSaveLocData(); //if the user wishes to save the year data, attempt to save. 
                }
                else
                {
                    returnVal = 3; //Debug code 3 allows the location text to be updated without saving.
                }
                if (editMode && !(monthDataChanged||commentDataChanged))//check if table data also needs saving 
                {
                    
                    return returnVal;
                }
            }
            if (editMode && (monthDataChanged||commentDataChanged))//saving table data.
            {
                monthDataChanged = false;
                commentDataChanged = false;
                if (MessageBox.Show("Changes have been made to the monthly data of " + CboSelectYear.Items[prevSelectedYearIndex] + " in " + CboSelectLocation.Items[prevSelectedLocationIndex] + ". Commit changes before continuing?", "Confirm", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    return LocalSaveYearData(prevSelectedYearIndex,prevSelectedLocationIndex);
                }
                else
                {
                    return 3;
                }
            }
            if (editMode && !(monthDataChanged && locDataChanged && commentDataChanged)) //no data needs to be saved as there are no changes to the data.
            {
                return 0;
            }


        Console.WriteLine((monthDataChanged && commentDataChanged) + " " + locDataChanged);
        return -1;
        } //used in both loading and saving

        #region Saving year and location data
        private int LocalSaveLocData() //saves the data fromt the text boxes into the local array.
        {
            try
            {
                //read in data from UI into datastructure
                localLocationArray[prevSelectedLocationIndex].SetLocName(TxtLocNameDisplay.Text);
                localLocationArray[prevSelectedLocationIndex].SetCounty(TxtCountyDisplay.Text);
                localLocationArray[prevSelectedLocationIndex].SetLatitude(Convert.ToDouble(TxtLatitudeDisplay.Text));
                localLocationArray[prevSelectedLocationIndex].SetLongitude(Convert.ToDouble(TxtLatitudeDisplay.Text));
                localLocationArray[prevSelectedLocationIndex].SetPostcode(TxtPostCodeDisplay.Text);
                localLocationArray[prevSelectedLocationIndex].SetStreetName(TxtStrtNameDisplay.Text);
                CboSelectLocation.Items[prevSelectedLocationIndex] = TxtLocNameDisplay.Text;
                return 0;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("A data format error has occured:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 2;
            }
        }

        private int LocalSaveYearData(int year, int location) 
        {
            MonthlyObservations[] newMonthData = new MonthlyObservations[12];
            for (int i = 0; i < 12;i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (DgvDisplayData.Rows[i].Cells[j].Style.BackColor == System.Drawing.Color.Red)
                    {
                        //checking every cell to see if there are any flagged cells with invalid data.
                        MessageBox.Show("Please make sure all cells contain valid month data. (Red cells)", "Invalid data format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 1;
                    }
                    DgvDisplayData.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.White;
                    DgvDisplayData.Rows[i].Cells[j].Style.ForeColor = System.Drawing.Color.Black;
                }
                //generates a new monthly observations array and fills it using the data inside the table.
                int monthID = (i+1);
                double maxTemp = Convert.ToDouble(DgvDisplayData.Rows[i].Cells[1].Value);
                double minTemp = Convert.ToDouble(DgvDisplayData.Rows[i].Cells[2].Value);
                int numDaysOfFrost = Convert.ToInt32(DgvDisplayData.Rows[i].Cells[3].Value);
                double mmOfRain = Convert.ToDouble(DgvDisplayData.Rows[i].Cells[4].Value);
                double hoursOfSunshine = Convert.ToDouble(DgvDisplayData.Rows[i].Cells[5].Value);
                newMonthData[i] = new MonthlyObservations(monthID, maxTemp, minTemp, numDaysOfFrost, mmOfRain, hoursOfSunshine);
            }
            //replaces the previous monthly observations array with the newly generated one.
            int selectedYear = localLocationArray[location].GetYearArray().Length - year;
            localLocationArray[location].GetYearArray()[selectedYear - 1].SetMonthlyObservationArray(newMonthData);
            localLocationArray[location].GetYearArray()[selectedYear - 1].SetYearComment(TxtCommentDisplay.Text);
            monthDataChanged = false;
            commentDataChanged = false;
            return 0;
        }
        #endregion
    
        #region Adding Locations and Years
        //---------------------------------------------------------------------
        //Add Locations and Years----------------------------------------------
        private void BtnAddYear_Click(object sender, EventArgs e)
        {
            Locations thisLocation = localLocationArray[CboSelectLocation.SelectedIndex];
            int selectedYear = localLocationArray[CboSelectLocation.SelectedIndex].GetYearArray().Length - CboSelectYear.SelectedIndex;
            InputDialog inputDialog;
            if (localLocationArray[CboSelectLocation.SelectedIndex].GetYearArray().Length == 0)
            {
                inputDialog = new InputDialog(-1, -1);
            }
            else
            {
                inputDialog = new InputDialog(thisLocation.GetYearArray()[0].GetYearID(), thisLocation.GetYearArray()[thisLocation.GetYearArray().Length - 1].GetYearID());
            }
            int newYearNum;
            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (inputDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                newYearNum = inputDialog.GetEnterValue();
                int firstYear = thisLocation.GetYearArray()[0].GetYearID();
                int lastYear = thisLocation.GetYearArray()[localLocationArray[CboSelectLocation.SelectedIndex].GetYearArray().Length - 1].GetYearID();
                int foundIndex = -3;
                foundIndex = GetIndexFromYear(newYearNum);
                if (foundIndex >= 0) //year already exists
                {
                    DialogResult result = MessageBox.Show("The year you have selected already has data stored for it. Would you like to overwrite it?", "Year already exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {   //this approach has been done to allow the use to have the oppitunity to return to the original data fot that year.
                        int index = GetIndexFromYear(newYearNum);
                        CboSelectYear.SelectedIndex = localLocationArray[CboSelectLocation.SelectedIndex].GetYearArray().Length - 1 - index;
                        DgvDisplayData.Rows.Clear();
                        for (int month = 1; month < 13; month++) //resets all the data in the current location via the pre-existing data edit mechanics. This allows the user to cancel the reset by changing page.
                        {
                            string monthName = GetMonthName(month);
                            DgvDisplayData.Rows.Add(monthName, 0, 0, 0, 0, 0);
                        }
                        TxtCommentDisplay.Text = "no description available";
                    }
                    monthDataChanged = true; 
                }
                else if (foundIndex == -1) // year is above the current years
                {
                    Years[] yearArray = localLocationArray[CboSelectLocation.SelectedIndex].GetYearArray();
                    localLocationArray[CboSelectLocation.SelectedIndex].ResizeArray();//increase year array size by 1
                    int numYears = localLocationArray[CboSelectLocation.SelectedIndex].GetYearArray().Length - 1;
                    //generate and fill a monthly observations array
                    MonthlyObservations[] newMonthData = new MonthlyObservations[12]; 
                    for (int i = 0; i < 12; i++)
                    {
                        newMonthData[i] = new MonthlyObservations(i + 1, 0, 0, 0, 0, 0);
                    }
                    Years newYear = new Years(newYearNum, "no description available", newMonthData);
                    localLocationArray[CboSelectLocation.SelectedIndex].SetLastYear(newYear); //generate a year object and set it in the last year slot.
                    localLocationArray[CboSelectLocation.SelectedIndex].GetYearArray()[numYears].SetMonthlyObservationArray(newMonthData);
                    //Refreshing and updating UI:
                    InitilizeComboBoxes(localLocationArray);
                    CboSelectLocation.SelectedIndex = prevSelectedLocationIndex;
                    CboSelectYear.SelectedIndex = 0;

                }
                else if (foundIndex == -2)//year is below the current years.
                {
                    Years[] yearArray = localLocationArray[CboSelectLocation.SelectedIndex].GetYearArray();
                    localLocationArray[CboSelectLocation.SelectedIndex].ResizeArray();//increase array size by 1
                    localLocationArray[CboSelectLocation.SelectedIndex].ShiftYearsRight(0);//move everything in array right by 1
                    int numYears = localLocationArray[CboSelectLocation.SelectedIndex].GetYearArray().Length - 1; 
                    MonthlyObservations[] newMonthData = new MonthlyObservations[12];
                    for (int i = 0; i < 12; i++)
                    {
                        newMonthData[i] = new MonthlyObservations(i + 1, 0, 0, 0, 0, 0);
                    }
                    Years newYear = new Years(newYearNum, "no description available", newMonthData);//generate new complete year object
                    localLocationArray[CboSelectLocation.SelectedIndex].SetFirstYear(newYear);
                    localLocationArray[CboSelectLocation.SelectedIndex].GetYearArray()[0].SetMonthlyObservationArray(newMonthData);//place in the first slot in array
                    //Refreshing and updating UI:
                    InitilizeComboBoxes(localLocationArray);
                    CboSelectLocation.SelectedIndex = prevSelectedLocationIndex;
                    CboSelectYear.SelectedIndex = CboSelectYear.Items.Count - 1;

                }
            }
            inputDialog.Dispose();
        }

        private int GetIndexFromYear( double newYearNum)//returns the index of a given yearID or returns a negative code for whether it is below or above the current array of years.
        {
            Years[] yearArray;
            if (editMode)
            {
                yearArray = localLocationArray[CboSelectLocation.SelectedIndex].GetYearArray();
            }
            else
            {
                yearArray = Data.locationArray[CboSelectLocation.SelectedIndex].GetYearArray();
            }
            for (int yearCount = 0; yearCount < yearArray.Length; yearCount++)
            {
                Years year = yearArray[yearCount];
                if (year.GetYearID() == newYearNum)
                {
                    return yearCount;
                }
            }

            if (newYearNum > yearArray[yearArray.Length - 1].GetYearID())
            {
                return -1;//value is greater than largest
            }
            else if (newYearNum < yearArray[0].GetYearID())
            {
                return -2; //value is smaller than lowest
            }

            return -3;//error
        }


        private void BtnAddLocation_Click(object sender, EventArgs e)
        {
            InputDialog inputDialog = new InputDialog(-1, -1);
            if (inputDialog.ShowDialog(this) == DialogResult.OK) // adds a year to be the first year in the location
            {
                Array.Resize(ref localLocationArray, localLocationArray.Length + 1); //increase location array soze by 1 and fill with an empty location object.
                localLocationArray[localLocationArray.Length - 1] = new Locations("New Location", "", "", "", 0, 0, new Years[1]);
                MonthlyObservations[] newMonthData = new MonthlyObservations[12];
                for (int i = 0; i < 12; i++)
                {
                    newMonthData[i] = new MonthlyObservations(i + 1, 0, 0, 0, 0, 0);
                }
                Years newYear = new Years(inputDialog.GetEnterValue(), "no description available", newMonthData); //generates complete year object
                localLocationArray[localLocationArray.Length - 1].SetLastYear(newYear); //adds it to the new location
                //update UI:
                DgvDisplayData.Rows.Clear();
                InitilizeComboBoxes(localLocationArray);
                CboSelectLocation.SelectedIndex = localLocationArray.Length - 1;
                UpdateLocationLabels(localLocationArray, localLocationArray.Length - 1);
                prevSelectedLocationIndex = localLocationArray.Length - 1;
            }
        }
        #endregion

        #region year controls
        //---------------------------------------------------------------------
        //YEAR CONTROLS -------------------------------------------------------
        private void BtnNextYear_Click(object sender, EventArgs e)
        {
            int currentYear = Convert.ToInt32(CboSelectYear.Text);
            CboSelectYear.Text = Convert.ToString(++currentYear);
        }

        private void BtnPreviousYear_Click(object sender, EventArgs e)
        {
            int currentYear = Convert.ToInt32(CboSelectYear.Text);
            CboSelectYear.Text = Convert.ToString(--currentYear);
        }

        private void BtnNextFinalYear_Click(object sender, EventArgs e)
        {
            CboSelectYear.SelectedIndex = 0;
        }

        private void BtnPreviousFinalYear_Click(object sender, EventArgs e)
        {
            CboSelectYear.SelectedIndex = Data.locationArray[CboSelectLocation.SelectedIndex].GetYearArray().Length - 1;
        }
        #endregion

        #region Enter and exit edit mode + SAVING DATA
        private void btnEnableEditing_Click(object sender, EventArgs e)
        {
            if (!editMode)
            {
                //setup the textboxes for recieving user input.
                if (firstEdit)
                {
                    MessageBox.Show("Edit mode is active. Changes will not be saved to file until edit mode is exited.", "Edit mode active.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    firstEdit = false;
                }
                editMode = true;
                btnEnableEditing.Text = "Cancel editing";
                advancedMode = false;
                TxtLocNameDisplay.ReadOnly = !TxtLocNameDisplay.ReadOnly;
                TxtCommentDisplay.ReadOnly = !TxtCommentDisplay.ReadOnly;
                TxtCountyDisplay.ReadOnly = !TxtCountyDisplay.ReadOnly;
                TxtLatitudeDisplay.ReadOnly = !TxtLatitudeDisplay.ReadOnly;
                TxtLongitudeDisplay.ReadOnly = !TxtLongitudeDisplay.ReadOnly;
                TxtPostCodeDisplay.ReadOnly = !TxtPostCodeDisplay.ReadOnly;
                TxtStrtNameDisplay.ReadOnly = !TxtStrtNameDisplay.ReadOnly;
                TxtLocNameDisplay.BorderStyle = BorderStyle.FixedSingle;
                TxtCommentDisplay.BorderStyle = BorderStyle.FixedSingle;
                TxtCountyDisplay.BorderStyle = BorderStyle.FixedSingle;
                TxtLatitudeDisplay.BorderStyle = BorderStyle.FixedSingle;
                TxtLongitudeDisplay.BorderStyle = BorderStyle.FixedSingle;
                TxtPostCodeDisplay.BorderStyle = BorderStyle.FixedSingle;
                TxtStrtNameDisplay.BorderStyle = BorderStyle.FixedSingle;
                BtnAddLocation.Visible = true;
                BtnAddYear.Visible = true;
                BtnSaveChanges.Visible = true;
                DgvDisplayData.ReadOnly = false;
                DgvDisplayData.Columns[0].ReadOnly = true;
                localLocationArray = Data.DeepCopy();
                ResizeForm();
            }
            else if (btnEnableEditing.Text == "Cancel editing")
            {
                DialogResult dialogResult = MessageBox.Show("All changes made will be lost. Are you sure you wish to cancel?", "Cancel editing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dialogResult == DialogResult.Yes)
                {
                    localLocationArray = null;
                    EndEditingMode();

                }
            }
        }

        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to save to save the data to a new file?", "Save data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult != DialogResult.Cancel)
            {
                //Data.locationArray = localLocationArray;====================================================== 
                if (dialogResult == DialogResult.Yes) //load the file path browser form and save the data based on the selected filepath.
                {
                    int checkReturnVal = CheckDataChanged();//check to see if there is unsaved data in the UI and ask teh user if they wish to save it.
                    if (checkReturnVal == 0 || checkReturnVal == 4)
                    {
                        SaveFileDialog fileBrowser = new SaveFileDialog();

                        fileBrowser.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                        fileBrowser.FilterIndex = 1;
                        fileBrowser.RestoreDirectory = true;

                        DialogResult saveResult = fileBrowser.ShowDialog();
                        if (saveResult == DialogResult.OK) //File path has been successfully selected.
                        {
                            Data.locationArray = localLocationArray; 
                            Data.SaveDataToFile(Data.locationArray, fileBrowser.FileName); //write to the filepath
                            Data.currentFilePath = fileBrowser.FileName; //select the new file path for any data saves to the same file
                            Data.DistributeDataToArrays(fileBrowser.FileName);
                            localLocationArray = null;
                            EndEditingMode();
                        }
                        else
                        {
                            MessageBox.Show("Canceled", "Canceled",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Check failed. Error number: " + checkReturnVal);
                    }
                }
                else if (dialogResult == DialogResult.No) //save to the current file
                {
                    int checkReturnVal = CheckDataChanged(); //check to see if there is unsaved data in the UI and ask teh user if they wish to save it.
                    if (checkReturnVal == 0 || checkReturnVal == 4)
                    {
                        Data.SaveDataToFile(localLocationArray, Data.currentFilePath);
                        Data.DistributeDataToArrays(Data.currentFilePath);
                        localLocationArray = null;
                        EndEditingMode();
                    }
                    else
                    {
                        Console.WriteLine("Check failed. Error number: " + checkReturnVal);
                    }

                }
            }
        }


        private void EndEditingMode() //reverts all setting to restrict the user from editing the controls
        {
            editMode = false;
            btnEnableEditing.Text = "Enable editing";
            TxtLocNameDisplay.ReadOnly = !TxtStrtNameDisplay.ReadOnly;
            TxtCommentDisplay.ReadOnly = !TxtCommentDisplay.ReadOnly;
            TxtCountyDisplay.ReadOnly = !TxtCountyDisplay.ReadOnly;
            TxtLatitudeDisplay.ReadOnly = !TxtLatitudeDisplay.ReadOnly;
            TxtLongitudeDisplay.ReadOnly = !TxtLongitudeDisplay.ReadOnly;
            TxtPostCodeDisplay.ReadOnly = !TxtPostCodeDisplay.ReadOnly;
            TxtStrtNameDisplay.ReadOnly = !TxtStrtNameDisplay.ReadOnly;
            TxtLocNameDisplay.BorderStyle = BorderStyle.None;
            TxtCommentDisplay.BorderStyle = BorderStyle.None;
            TxtCountyDisplay.BorderStyle = BorderStyle.None;
            TxtLatitudeDisplay.BorderStyle = BorderStyle.None;
            TxtLongitudeDisplay.BorderStyle = BorderStyle.None;
            TxtPostCodeDisplay.BorderStyle = BorderStyle.None;
            TxtStrtNameDisplay.BorderStyle = BorderStyle.None;
            int selectedLoation = CboSelectLocation.SelectedIndex;
            int selectedYear = CboSelectYear.SelectedIndex;
            InitilizeComboBoxes(Data.locationArray);
            CboSelectLocation.SelectedItem = Data.locationArray[0].GetLocName();
            CboSelectYear.SelectedItem = Data.locationArray[0].GetYearArray()[Data.locationArray[0].GetYearArray().Length - 1].GetYearID();
            try
            {
                CboSelectLocation.SelectedIndex = selectedLoation;
            }
            catch(ArgumentOutOfRangeException)
            {
                CboSelectLocation.SelectedIndex = 0;
            }

            CboSelectYear.SelectedIndex = selectedYear;
            BtnSaveChanges.Visible = false;
            BtnAddLocation.Visible = false;
            BtnAddYear.Visible = false;
            DgvDisplayData.ReadOnly = true;
            ResizeForm();
        }

        #endregion

        #region TextBox focus modification
        private void TxtStrtNameDisplay_Enter(object sender, EventArgs e)
        {
            if (!editMode)
                LblHeaderYearComment.Focus();
        }
        private void TxtCommentDisplay_Enter(object sender, EventArgs e)
        {
            if (!editMode)
                LblHeaderYearComment.Focus();
        }

        private void TxtCountyDisplay_Enter(object sender, EventArgs e)
        {
            if (!editMode)
                LblHeaderCounty.Focus();
        }

        private void TxtPostCodeDisplay_Enter(object sender, EventArgs e)
        {
            if (!editMode)
                LblHeaderPostCode.Focus();
        }

        private void TxtLatitudeDisplay_Enter(object sender, EventArgs e)
        {
            if (!editMode)
                LblHeaderLatitude.Focus();
        }

        private void TxtLongitudeDisplay_Enter(object sender, EventArgs e)
        {
            if (!editMode)
                LblHeaderLongitude.Focus();
        }
        private void TxtLocNameDisplay_Enter(object sender, EventArgs e)
        {
            if (!editMode)
                LblHeaderLocationName.Focus();
        }
        #endregion

        #region TextChanged detection 
        private void TxtLocNameDisplay_TextChanged(object sender, EventArgs e)
        {
            if (editMode && TxtLocNameDisplay.Text != localLocationArray[CboSelectLocation.SelectedIndex].GetLocName().ToString())
            {
                locDataChanged = true;
            }
        }
        private void TxtStrtNameDisplay_TextChanged(object sender, EventArgs e)
        {
            if (editMode && TxtStrtNameDisplay.Text != localLocationArray[CboSelectLocation.SelectedIndex].GetStreetName().ToString())
            {
                locDataChanged = true;
            }
        }

        private void TxtCountyDisplay_TextChanged(object sender, EventArgs e)
        {
            if (editMode && TxtCountyDisplay.Text != localLocationArray[CboSelectLocation.SelectedIndex].GetCounty().ToString())
            {
                locDataChanged = true;
            }
        }

        private void TxtPostCodeDisplay_TextChanged(object sender, EventArgs e)
        {
            if (editMode && TxtPostCodeDisplay.Text != localLocationArray[CboSelectLocation.SelectedIndex].GetPostcode().ToString())
            {
                locDataChanged = true;
            }
        }

        private void TxtLatitudeDisplay_TextChanged(object sender, EventArgs e)
        {
            if (editMode && TxtLatitudeDisplay.Text != localLocationArray[CboSelectLocation.SelectedIndex].GetLatitude().ToString())
            {
                locDataChanged = true;
            }
        }

        private void TxtLongitudeDisplay_TextChanged(object sender, EventArgs e)
        {
            if (editMode && TxtLongitudeDisplay.Text != localLocationArray[CboSelectLocation.SelectedIndex].GetLongitude ().ToString())
            {
                locDataChanged = true;
            }
        }

        private void TxtCommentDisplay_TextChanged(object sender, EventArgs e)
        {
            if (editMode)
            {
                //compare new text to the expected text to detect if the user has changed teh data.
                int selectedYearIndex = localLocationArray[CboSelectLocation.SelectedIndex].GetYearArray().Length - CboSelectYear.SelectedIndex;
                if (TxtCommentDisplay.Text != localLocationArray[CboSelectLocation.SelectedIndex].GetYearArray()[selectedYearIndex - 1].GetYearComment().ToString())
                {
                    commentDataChanged = true;
                }
            }
        }
        #endregion

        #region Cell Data Changed detection and validation
        private double previousValidCellData;
        private void DgvDisplayData_CellEndEdit(object sender, DataGridViewCellEventArgs e) //used to detect when a cell has been edited and to check if the inputted data is valid.
        {
            if (e.ColumnIndex != 0)
            {   
                //checks if the data can be converted to a double. 
                bool validInputTest = Double.TryParse(DgvDisplayData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out double currentData); 

                if (validInputTest)
                {
                    if (currentData != Convert.ToDouble(previousValidCellData)) //marks successfully edited data as grey 
                    {
                        monthDataChanged = true;
                        DgvDisplayData.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = System.Drawing.Color.GreenYellow;
                        DgvDisplayData.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = System.Drawing.Color.Gray;
                        DgvDisplayData.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = "Recently edited";
                    }
                }
                else
                {
                    DgvDisplayData.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = System.Drawing.Color.Black;
                }

                if (!validInputTest) //marks data that can not be converted to double red
                {
                    DgvDisplayData.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = System.Drawing.Color.Black;
                    DgvDisplayData.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = System.Drawing.Color.Red;
                    DgvDisplayData.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = "This field only accepts numeric inputs, Previous value: " + previousValidCellData;
                }
            }
        }


        private void DgvDisplayData_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex != 0)
            {   //used to record the original valid data in the cell so that it can be used in the error tool tip
                if (Double.TryParse(DgvDisplayData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out double outValue)) 
                {
                    previousValidCellData = Convert.ToDouble(DgvDisplayData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                }
            }
        }
        #endregion

        #region Search buttons
        private void BtnLocSearch_Click(object sender, EventArgs e)
        {
            if (editMode)//search other array when in editmode
            {
                SearchLocation(localLocationArray);
            }
            else
            {
                SearchLocation(Data.locationArray);
            }
        }

        private void SearchLocation(Locations[] locationArray)
        {
            InputDialog inputDialog = new InputDialog(locationArray); //inputDialog contains a property set by the user 
            if (inputDialog.ShowDialog(this) == DialogResult.OK) //allows the user to cancel, thus aborting the search
            {
                string searchInput = inputDialog.GetSearchValue(); //gets the value set by the user
                for (int index = 0; index < locationArray.Length; index++)
                {
                    Locations location = locationArray[index]; //search for the index based on the name
                    if (location.GetLocName().ToLower() == searchInput)
                    {
                        CboSelectLocation.SelectedIndex = index;
                    }
                }
            }
        }

        private void btnYearSearch_Click(object sender, EventArgs e)
        {
            if (editMode)
            {
                SearchYear(localLocationArray[CboSelectLocation.SelectedIndex].GetYearArray());
            }
            else
            {
                SearchYear(Data.locationArray[CboSelectLocation.SelectedIndex].GetYearArray());
            }
    }
        private void SearchYear(Years[] yearArray)
        {
            InputDialog inputDialog = new InputDialog(yearArray); //show dialog and let the user search for a year
            if (inputDialog.ShowDialog(this) == DialogResult.OK)
            {
                string searchInput = inputDialog.GetSearchValue(); //get the searched year
                for (int index = 0; index < yearArray.Length; index++)
                {
                    Years year = yearArray[index];
                    if (year.GetYearID() == Convert.ToInt32(searchInput))//search for the correct index of the year based on the year ID
                    {
                        int numYears = yearArray.Length;
                        CboSelectYear.SelectedIndex = numYears - index - 1;

                    }
                }
            }
        }
        #endregion

        #region Analysis features
        private void ResizeForm() //toggle showing the analysis features
        {
            if (!editMode)
            {
                if (!advancedMode)
                {
                    btnShowStats.Text = "Enable advanced mode";
                    this.Size = new System.Drawing.Size(683, 474);
                }
                else if (advancedMode)
                {
                    btnShowStats.Text = "Disable advanced mode";
                    this.Size = new System.Drawing.Size(933, 741);
                }
            }
            else
            {
                btnShowStats.Text = "Commit changes localy";
                this.Size = new System.Drawing.Size(683, 474);
            }
        }
        private void btnShowAnalysisTools_Click(object sender, EventArgs e)//button to toggle analysis tools
        {
            if (!editMode)
            {
                advancedMode = !advancedMode;
                ResizeForm();
            }
            else
            {
                LocalSaveLocData();
                LocalSaveYearData(prevSelectedYearIndex, prevSelectedLocationIndex);
            }
        }
        #region calculate and show averages
        private void UpdateAnalysis()
        {
            int scopeMode = CboScope.SelectedIndex;
            int totalMonths = 0;
            double maxTemp = 0;
            double minTemp = 0;
            double frost = 0;
            double rain = 0;
            double sunshine = 0;
            double TopMaxTemp = 0;
            double TopMinTemp = 100000000000;
            if (scopeMode == 0)//Scope is All
            {
                for (int i = 0; i < Data.locationArray.Length; i++) //loops through all locations, years and month and sums data.
                {
                    for (int j = 0; j < Data.locationArray[i].GetYearArray().Length; j++)
                    {
                        SumMonthData(ref totalMonths, ref maxTemp, ref minTemp, ref frost, ref rain, ref sunshine, ref TopMaxTemp, ref TopMinTemp, i, j);
                    }
                }
            }
            else if (scopeMode == 1)//scope is current location
            {
                for (int j = 0; j < Data.locationArray[CboSelectLocation.SelectedIndex].GetYearArray().Length; j++) // loops throuh all years in the curerent location and sums the month data
                {
                    SumMonthData(ref totalMonths, ref maxTemp, ref minTemp, ref frost, ref rain, ref sunshine, ref TopMaxTemp, ref TopMinTemp, CboSelectLocation.SelectedIndex, j);
                }
            }
            else if (scopeMode == 2)// sums the month data for each month in the selected year
            {
                int selectedYear = Data.locationArray[CboSelectLocation.SelectedIndex].GetYearArray().Length - CboSelectYear.SelectedIndex - 1;
                SumMonthData(ref totalMonths, ref maxTemp, ref minTemp, ref frost, ref rain, ref sunshine, ref TopMaxTemp, ref TopMinTemp, CboSelectLocation.SelectedIndex, selectedYear);
            }           
            //setting the text of the labels
            //each variable must be deivided by the number of months that had be iterated through
            LblAvgMaxTemp.Text = string.Format("{0:0.00000}", maxTemp / totalMonths);
            LblAvgMinTemp.Text = string.Format("{0:0.00000}", minTemp / totalMonths);
            LblAvgFrost.Text = string.Format("{0:0.00000}", frost / totalMonths);
            LblAvgRain.Text = string.Format("{0:0.00000}", rain / totalMonths);
            LblAvgSunshine.Text = string.Format("{0:0.00000}", sunshine / totalMonths);
            LblRcdMaxTemp.Text = string.Format("{0:0.000}", TopMaxTemp);
            LblRcdMinTemp.Text = string.Format("{0:0.000}", TopMinTemp);

        }

        private static void SumMonthData(ref int totalMonths, ref double maxTemp, ref double minTemp, ref double frost, ref double rain, ref double sunshine, ref double TopMaxTemp, ref double TopMinTemp, int i, int j)
        {
            for (int k = 0; k < 12; k++)//adds the month property values to the respective variables passed in by ref for the year passed in.
            {
                maxTemp = maxTemp + Data.locationArray[i].GetYearArray()[j].GetMonthlyObservationArray()[k].GetMaxTemp();
                minTemp = minTemp + Data.locationArray[i].GetYearArray()[j].GetMonthlyObservationArray()[k].GetMinTemp();
                frost = frost + Data.locationArray[i].GetYearArray()[j].GetMonthlyObservationArray()[k].GetNumDaysOfFrost();
                rain = rain + Data.locationArray[i].GetYearArray()[j].GetMonthlyObservationArray()[k].GetMmOfRain();
                sunshine = sunshine + Data.locationArray[i].GetYearArray()[j].GetMonthlyObservationArray()[k].GetSunshine();

                if (Data.locationArray[i].GetYearArray()[j].GetMonthlyObservationArray()[k].GetMaxTemp() > TopMaxTemp)// finds the highest temperature
                {
                    TopMaxTemp = Data.locationArray[i].GetYearArray()[j].GetMonthlyObservationArray()[k].GetMaxTemp();
                }

                if (Data.locationArray[i].GetYearArray()[j].GetMonthlyObservationArray()[k].GetMinTemp() < TopMinTemp) // find lowest temperature
                {
                    TopMinTemp = Data.locationArray[i].GetYearArray()[j].GetMonthlyObservationArray()[k].GetMinTemp();
                }
            }
            totalMonths = totalMonths + 12;
        }
        #endregion
        #region Generate graphs
        private double GetMonthProperty(int property, int locInput, int yearInput, int monthInput)//returns the property value for the passed in index of the combobox
        {
            if (CboProperty.SelectedIndex == 0)
            {
                return Data.locationArray[locInput].GetYearArray()[yearInput].GetMonthlyObservationArray()[monthInput].GetMaxTemp();
            }
            else if (CboProperty.SelectedIndex == 1)
            {
                return Data.locationArray[locInput].GetYearArray()[yearInput].GetMonthlyObservationArray()[monthInput].GetMinTemp();
            }
            else if (CboProperty.SelectedIndex == 2)
            {
                return Data.locationArray[locInput].GetYearArray()[yearInput].GetMonthlyObservationArray()[monthInput].GetNumDaysOfFrost();
            }
            else if (CboProperty.SelectedIndex == 3)
            {
                return Data.locationArray[locInput].GetYearArray()[yearInput].GetMonthlyObservationArray()[monthInput].GetMmOfRain();
            }
            else //if (CboProperty.SelectedIndex == 4)
            {
                return Data.locationArray[locInput].GetYearArray()[yearInput].GetMonthlyObservationArray()[monthInput].GetSunshine();
            }
        }

        private void CboScope_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAnalysis();
            UpdatePointArray();
            GrpGraphs.Refresh();
        }
       
        private void UpdatePointArray()
        {
            if (CboScope.SelectedIndex == 0)//scope is All Lcoations
            {
                double maxVal = -10000;
                double totalMonths = 0;
                double[] avgProp = new double[12];
                for (int k = 0; k < Data.locationArray.Length; k++)//loops through all locations and years
                {
                    for (int j = 0; j < Data.locationArray[k].GetYearArray().Length; j++)
                    {
                        for (int i = 0; i < 12; i++)
                        {
                            avgProp[i] = avgProp[i] + GetMonthProperty(CboProperty.SelectedIndex, k, j, i);
                            // creates a cumulative sum of teh selected property for each month and stores it in teh respective index in the array.
                            totalMonths = totalMonths + 1;
                        }
                    }
                }

                maxVal = CalculateMaxvalue(maxVal, totalMonths, avgProp);

                CalculatePlotPoints(maxVal, avgProp);
            }
            else if (CboScope.SelectedIndex == 1 ) // Scope is Cureent location
            {

                double maxVal = -10000;
                double totalMonths = 0;
                double[] avgProp = new double[12];
                for (int j = 0; j < Data.locationArray[CboSelectLocation.SelectedIndex].GetYearArray().Length; j++)
                {
                    for (int i = 0; i < 12; i++)
                    {
                        avgProp[i] = avgProp[i] + GetMonthProperty(CboProperty.SelectedIndex, CboSelectLocation.SelectedIndex, j, i);
                        // creates a cumulative sum of the selected property for each month and stores it in teh respective index in the array.
                        totalMonths = totalMonths + 1;
                    }
                }

                maxVal = CalculateMaxvalue(maxVal, totalMonths, avgProp);

                CalculatePlotPoints(maxVal, avgProp);
            }
            else if (CboScope.SelectedIndex == 2) // Scope is current year
            {
                double[] avgProp = new double[12]; //12 months
                double maxVal = -10000; // MaxTemp is set to an extemely low number
                int selectedYear = Data.locationArray[CboSelectLocation.SelectedIndex].GetYearArray().Length - CboSelectYear.SelectedIndex - 1;
                for (int i = 0; i < 12; i++)
                {
                    avgProp[i] = avgProp[i] + GetMonthProperty(CboProperty.SelectedIndex, CboSelectLocation.SelectedIndex, selectedYear, i);// fill each item in array with month data.
                }
                maxVal = CalculateMaxvalue(maxVal, 12, avgProp); 
                CalculatePlotPoints(maxVal, avgProp);

            }
        }

        private static double CalculateMaxvalue(double maxVal, double totalMonths, double[] avgProp)
        {
            for (int i = 0; i < 12; i++)//divdes the total values for each month by the numebr of months iterated to find the average
            {
                avgProp[i] = avgProp[i] / totalMonths;
                if (avgProp[i] > maxVal)
                {
                    maxVal = avgProp[i]; // finds the highest value in array
                }
            }

            return maxVal;
        }

        private void CalculatePlotPoints(double maxVal, double[] avgProp)
        {
            for (int i = 0; i < 12; i++)
            {
                double lengthOfBar = 200 * (avgProp[i]) / maxVal;//finds the percentage of the peoperty for that month relative to the highest value 
                                                                 //percentage is multiplied by the maximum height of the graph plot to find how high the plot should be.
                Point point = new Point//creates new point object with the correct position for the plot and stores it in an array.
                {
                    X = 30 + ((561 / 11) * i),
                    Y = Convert.ToInt32(230 - lengthOfBar)
                };
                pointArray[i] = point;
            }
            pointArray[0].X = pointArray[0].X + 10;
        }

        private void GrpGraphs_Paint(object sender, PaintEventArgs e)
        {
            //creates points used for drawing the axis
            Pen pen = new Pen(Brushes.Navy, 2);
            Point xPoint1 = new Point
            {
                X = 35,
                Y = 230
            };
            Point xPoint2 = new Point
            {
                X = 596,
                Y = 230
            };
            Point yPoint1 = new Point
            {
                X = xPoint1.X + 5,
                Y = 20
            };
            Point yPoint2 = new Point
            {
                X = xPoint1.X + 5,
                Y = xPoint1.Y + 5
            };
            //draws axis
            Font font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular, GraphicsUnit.Pixel);
            e.Graphics.DrawLine(pen, xPoint1, xPoint2);
            e.Graphics.DrawLine(pen, yPoint1, yPoint2);
            int gap = (561 / 11);
            //creates the labels for the graph
            for (int i = 0; i < 12; i++)
            {
                e.Graphics.DrawString(GetMonthName(i + 1), font, Brushes.Black, xPoint1.X + (gap * i), 245);
                if (i != 0)
                e.Graphics.DrawLine(pen, new Point { X = xPoint1.X + (gap * i), Y = 226}, new Point { X = xPoint1.X  + (gap * i), Y = 231 });
            }


            for (int i = 0; i < 11; i++)// plots the line of data selected
            {
                e.Graphics.DrawLine(new Pen(Brushes.DarkCyan, 2), pointArray[i], pointArray[i+1]);
            }

        }
        #endregion

        private void CboProperty_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePointArray();
            GrpGraphs.Refresh();
        }
        #endregion
        private void BtnChangeSelectedFile_Click(object sender, EventArgs e)
        {
            //loads new file path and runs procrdure to reload and refresh all data
            SelectFile selectFile = new SelectFile();
            if (selectFile.ShowDialog() == DialogResult.OK)
            {
                InitilizeComboBoxes(Data.locationArray);
                CboSelectLocation.SelectedItem = Data.locationArray[0].GetLocName();
                CboSelectYear.SelectedItem = Data.locationArray[0].GetYearArray()[Data.locationArray[0].GetYearArray().Length - 1].GetYearID();
                CboScope.SelectedIndex = 0;
                this.ActiveControl = CboSelectLocation;
                UpdateLocationLabels(Data.locationArray, CboSelectLocation.SelectedIndex);
            }
            selectFile.Dispose();

        }
        
    }
}
