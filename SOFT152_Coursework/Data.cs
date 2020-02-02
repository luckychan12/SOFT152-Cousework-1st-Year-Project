  using System;
using System.IO; //allows direct access to the System.IO function. Improves readability

namespace SOFT152_Coursework
{
    class Data
    {
        public static Locations[] locationArray;
        public static string currentFilePath;

        public static Locations[] DistributeDataToArrays(string filepath)
        {
            //specifying number of location objects needed
            try
            {
                //Using block automatically closes the streamreader 
                using (StreamReader file = new StreamReader(filepath))
                {
                    locationArray = new Locations[Convert.ToInt32(file.ReadLine())];
                    LocationsLoop(file, ref locationArray);
                }
                return locationArray;
            }
            catch(FormatException)
            {
                return null; //returns null for error detection
            }
        }

        private static Locations[] LocationsLoop(StreamReader file, ref Locations[] locationArray)
        {
            //Gets required data from file, calls YearsLoop to get array of years, creates array of locations
            for (int location = 0; location < locationArray.Length; location++)
            {
                string locationName = file.ReadLine();
                string streetName = file.ReadLine();
                string county = file.ReadLine();
                string postcode = file.ReadLine();
                double latitude = Convert.ToDouble(file.ReadLine());
                double longitude = Convert.ToDouble(file.ReadLine());
                int numYears = Convert.ToInt32(file.ReadLine());
                Years[] yearArray = new Years[numYears];
                YearsLoop(file, numYears, ref yearArray);
                locationArray[location] = new Locations(locationName, streetName, county, postcode, latitude, longitude, yearArray);
            }
            return locationArray;
        }

        private static void YearsLoop(StreamReader file, int numYears, ref Years[] yearArray)
        {
            //year array is passed in by reference.
            for (int year = 0; year < numYears; year++)
            {
                //Gets required data from file, calls MonthlyObservationsLoop
                //to get Month array and constucts a year object
                string comment = file.ReadLine();
                int yearID = Convert.ToInt32(file.ReadLine());
                MonthlyObservations[] monthlyObservationArray = new MonthlyObservations[12];
                MonthlyObservationsLoop(file, ref monthlyObservationArray);
                yearArray[year] = new Years(yearID, comment, monthlyObservationArray);
            }
        }

        private static void MonthlyObservationsLoop(StreamReader file, ref MonthlyObservations[] monthlyObservations)
        {
            for (int month = 0; month < 12; month++)
            {
                //skips unneeded year line
                if (month != 0)
                {
                    file.ReadLine();
                }
                //Gets required data from file and constucts a MonthlyObservations object. Adds to array
                int monthID = Convert.ToInt32(file.ReadLine());
                double maxTemp = Convert.ToDouble(file.ReadLine());
                double minTemp = Convert.ToDouble(file.ReadLine());
                int numDaysOfFrost = Convert.ToInt32(file.ReadLine());
                double mmOfRain = Convert.ToDouble(file.ReadLine());
                double hoursOfSunshine = Convert.ToDouble(file.ReadLine());
                monthlyObservations[month] = new MonthlyObservations(monthID, maxTemp, minTemp, numDaysOfFrost, mmOfRain, hoursOfSunshine);
            }

        }

        
        public static void SaveDataToFile(Locations[] localLocationArray, String filePath)
        {
            using (StreamWriter streamWriter = new StreamWriter(filePath))  //Using block automatically closes the streamreader 
            {
                streamWriter.Write("");
                streamWriter.WriteLine(localLocationArray.Length.ToString());
                for (int location = 0; location < localLocationArray.Length; location++) //loops through all locations in locationArray 
                {
                    //writes the data on the current location to the file
                    streamWriter.WriteLine(localLocationArray[location].GetLocName().ToString());
                    streamWriter.WriteLine(localLocationArray[location].GetStreetName().ToString());
                    streamWriter.WriteLine(localLocationArray[location].GetCounty().ToString());
                    streamWriter.WriteLine(localLocationArray[location].GetPostcode().ToString());
                    streamWriter.WriteLine(localLocationArray[location].GetLatitude().ToString());
                    streamWriter.WriteLine(localLocationArray[location].GetLongitude().ToString());
                    streamWriter.WriteLine(localLocationArray[location].GetYearArray().Length.ToString());
                    int yearLength = localLocationArray[location].GetYearArray().Length;
                    for (int year = 0; year < yearLength; year++) //loops through eachy year in the current location
                    {
                        streamWriter.WriteLine(localLocationArray[location].GetYearArray()[year].GetYearComment().ToString());
                        for (int month = 0; month < 12; month++) //loops through each month of the current year
                        {
                            //writes the data on the current month to the file
                            streamWriter.WriteLine(localLocationArray[location].GetYearArray()[year].GetYearID().ToString());
                            streamWriter.WriteLine(localLocationArray[location].GetYearArray()[year].GetMonthlyObservationArray()[month].GetMonthID().ToString());
                            streamWriter.WriteLine(localLocationArray[location].GetYearArray()[year].GetMonthlyObservationArray()[month].GetMaxTemp().ToString());
                            streamWriter.WriteLine(localLocationArray[location].GetYearArray()[year].GetMonthlyObservationArray()[month].GetMinTemp().ToString());
                            streamWriter.WriteLine(localLocationArray[location].GetYearArray()[year].GetMonthlyObservationArray()[month].GetNumDaysOfFrost().ToString());
                            streamWriter.WriteLine(localLocationArray[location].GetYearArray()[year].GetMonthlyObservationArray()[month].GetMmOfRain().ToString());
                            if (location == localLocationArray.Length - 1 && year == yearLength-1 && month == 11) //this if statement is to avoid having an extra line at the end of the file (so it matches the given dataset)
                            {
                                streamWriter.Write(localLocationArray[location].GetYearArray()[year].GetMonthlyObservationArray()[month].GetSunshine().ToString());
                            }
                            else
                            {
                                streamWriter.WriteLine(localLocationArray[location].GetYearArray()[year].GetMonthlyObservationArray()[month].GetSunshine().ToString());
                            }
                        }
                    }
                }
            }
        }
        public static Locations[] DeepCopy() //used to clone the location array to be used to preserve the current locationArray and allow the user to cancel editing 
        {
            //deep copy works very similarly to reading in data form file method. 
            Locations[] localLocationArray = new Locations[locationArray.Length]; //create empty location array
            for (int location = 0; location < locationArray.Length; location++)
            {
                //get all the components for a location object
                string locName = locationArray[location].GetLocName();
                string streetName = locationArray[location].GetStreetName();
                string county = locationArray[location].GetCounty();
                string postCode = locationArray[location].GetPostcode();
                double latitude = locationArray[location].GetLatitude();
                double longitude = locationArray[location].GetLongitude();
                Years[] years = new Years[locationArray[location].GetYearArray().Length]; //create year array
                for (int year = 0; year < locationArray[location].GetYearArray().Length; year++)
                {
                    //get components for a year array
                    string comment = locationArray[location].GetYearArray()[year].GetYearComment();
                    int yearID = locationArray[location].GetYearArray()[year].GetYearID();
                    MonthlyObservations[] monthlyObservations = new MonthlyObservations[12]; //create month onject
                    for (int month = 0; month < 12; month++) 
                    {
                        //get components of a moneth object
                        int monthID = locationArray[location].GetYearArray()[year].GetMonthlyObservationArray()[month].GetMonthID();
                        double maxTemp = locationArray[location].GetYearArray()[year].GetMonthlyObservationArray()[month].GetMaxTemp();
                        double minTemp = locationArray[location].GetYearArray()[year].GetMonthlyObservationArray()[month].GetMinTemp();
                        int frost = locationArray[location].GetYearArray()[year].GetMonthlyObservationArray()[month].GetNumDaysOfFrost();
                        double mmRain = locationArray[location].GetYearArray()[year].GetMonthlyObservationArray()[month].GetMmOfRain();
                        double sunshine = locationArray[location].GetYearArray()[year].GetMonthlyObservationArray()[month].GetSunshine();
                        monthlyObservations[month] = new MonthlyObservations(monthID, maxTemp, minTemp, frost, mmRain, sunshine); //create month object
                    }
                    years[year] = new Years(yearID, comment, monthlyObservations); //create year object
                }
                localLocationArray[location] = new Locations(locName, streetName, county, postCode, latitude, longitude, years);//create location object
            }
            return localLocationArray;
        }
    }
}
