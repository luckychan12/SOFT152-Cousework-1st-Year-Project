using System;
using System.Windows.Forms;

namespace SOFT152_Coursework
{
    public partial class InputDialog : Form
    {
        private int nextYear;
        private int prevYear;
        private bool newLocation = false;
        private bool searching = false;
        private bool searchingLocation; //true = location, false = year 
        private Locations[] locArray;
        private Years[] yearArray;


        private int enterValue;
        public int GetEnterValue() //method to be used to find out what the user entered in this form
        {
            return enterValue;
        }

        private string searchValue;
        public string GetSearchValue() //method to be used to find out what the user entered in this form
        {
            return searchValue.ToLower();
        }

        public InputDialog(int firstYear, int lastYear) //constuctor modified to pass in values to detect if its a new location or not
        {
            InitializeComponent();
            nextYear = lastYear + 1;
            prevYear = firstYear - 1;
            searching = false;

            if (firstYear == -1 || lastYear == -1)
            {
                newLocation = true;
                lblMsgText.Text = "Please input the value of the first year you wish to add.";
                nextYear = System.DateTime.Today.Year;
                this.Text = "Add Locaton";
            }
            else //new locations dont have a max and min value
            {
                lblMsgText.Text = "Please select the year you wish to add.";
                BtnMax.Visible = true;
                BtnMin.Visible = true;
                this.Text = "Add Year";
            }
        }
        public InputDialog(Locations[] locationArray) //if this constuctor is used, the input dialog will search
        {
            InitializeComponent();
            //setup the form to suit searching
            locArray = locationArray; 
            BtnMax.Visible = false;
            BtnMin.Visible = false;
            searching = true;
            TxtInputBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TxtInputBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            searchingLocation = true;
            lblMsgText.Text = "Search Tool:\nSearch for a location";
            this.Text = "Search Location";
            //Fills textbox search with locations
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            for (int location = 0; location < locationArray.Length; location++)
            {
                col.Add(locationArray[location].GetLocName().ToString());
            }
            TxtInputBox.AutoCompleteCustomSource = col;
        }

        public InputDialog(Years[] yearsArray) //if this constructor is run, the form is being used to search years
        {
            InitializeComponent();
            //setup form for searching
            yearArray = yearsArray;
            BtnMax.Visible = false;
            BtnMin.Visible = false;
            searching = true;
            TxtInputBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TxtInputBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            searchingLocation = false;
            lblMsgText.Text = "Search Tool:\nSearch for a year";
            this.Text = "Search Year";
            //Fill with years
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            for (int year = yearArray.Length; year >= 1; year--) //counts backwards so that years are displayed in decending order (personal preference)
            {
                col.Add(yearArray[year - 1].GetYearID().ToString());
            }
            TxtInputBox.AutoCompleteCustomSource = col;
        }



        private void TxtYearInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!searching) // when adding a year
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); //check if the key the user pressed is a numebr
            }
        }



        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (!searching) //when adding a year
            {
                if (TxtInputBox.Text != "" && int.TryParse(TxtInputBox.Text, out int input))
                {
                    if (!newLocation) //new year
                    {
                        if (input >= prevYear && input <= nextYear) //check if the input is in the valid range
                        {
                            enterValue = Convert.ToInt32(TxtInputBox.Text);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Support for years +- 1 from the year range is not currently supported ( years will become out of order. )");
                            if (input < prevYear)
                            {
                                TxtInputBox.Text = prevYear.ToString();
                            }
                            else if (input > nextYear)
                            {
                                TxtInputBox.Text = nextYear.ToString();
                            }
                        }
                    }
                    else //new location: no year limit but asks the user to double check their input
                    {

                        string text = "This is the first year entry for this location.Please confirm that " + TxtInputBox.Text + " is correct as you will only be able to add years directly before and after it.";
                        DialogResult dialogResult = MessageBox.Show(text, "New Location", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (dialogResult == DialogResult.Yes)
                        {
                            enterValue = Convert.ToInt32(TxtInputBox.Text);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid year value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else //searching
            {
                if (!string.IsNullOrWhiteSpace(TxtInputBox.Text) && !string.IsNullOrEmpty(TxtInputBox.Text)) //check if the user has entered anything
                {
                    searchValue = TxtInputBox.Text.ToLower();
                    if (CheckContains(searchValue)) //check if what the user has typed matches an existing search value
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        if (searchingLocation)
                        {
                            MessageBox.Show("That location does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("No data has been recorded for that year.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private bool CheckContains(string searchValue) //matches the typed text with an item in the list of  possible options
        {
            if (searchingLocation)
            {
                foreach (Locations x in locArray)
                {
                    if (x.GetLocName().ToLower() == searchValue)
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                foreach (Years x in yearArray)
                {
                    if (x.GetYearID().ToString() == searchValue)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void InputDialog_Load(object sender, EventArgs e)  //sets the default text value for when the form loads
        {
            if (!searching && !newLocation)
            {
                TxtInputBox.Text = nextYear.ToString();
            }
            else if (newLocation) //when adding a location, use the latest year in the current locaiton
            {
                TxtInputBox.Text = (nextYear - 1).ToString();
            }
            this.ActiveControl = TxtInputBox;
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            TxtInputBox.Text = prevYear.ToString();
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            TxtInputBox.Text = nextYear.ToString();
        }

        private void TxtInputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnConfirm_Click(this, new EventArgs());
            }
        }
    }
}
