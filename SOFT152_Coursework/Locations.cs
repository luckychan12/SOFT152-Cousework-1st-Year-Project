namespace SOFT152_Coursework
{
    public class Locations
    {
        //setting properties
        private string locName;
        private string streetName;
        private string county;
        private string postcode;
        private double latitude;
        private double longitude;
        private Years[] yearArray;

        /*Methods*/
            //constructor:
        public Locations(string locName, string streetName, string county, string postcode, double latitude, double longitude, Years[] yearArray)
        {
            this.locName = locName;
            this.streetName = streetName;
            this.county = county;
            this.postcode = postcode;
            this.latitude = latitude;
            this.longitude = longitude;
            this.yearArray = yearArray;
        }


        public void SetLastYear(Years year)
        {
            yearArray[yearArray.Length - 1] = year;
        }

        public void SetFirstYear(Years year)
        {
            yearArray[0] = year;
        }

        public void ResizeArray()
        {
            System.Array.Resize(ref yearArray, yearArray.Length + 1);
        }

        public void ShiftYearsRight(int startPoint)
        {
            for (int i = yearArray.Length - 2; i >= startPoint; --i)
            {
                yearArray[i + 1] = yearArray[i];
            }
                yearArray[startPoint] = null;
        }

        /*getters*/
        public string GetLocName()
        {
            return locName;
        }
        public string GetCounty()
        {
            return county;
        }
        public string GetPostcode()
        {
            return postcode;
        }
        public string GetStreetName()
        {
            return streetName;
        }
        public double GetLatitude()
        {
            return latitude;
        }
        public double GetLongitude()
        {
            return longitude;
        }
        public Years[] GetYearArray()
        {
            return yearArray;
        }

        /*setters*/
        public void SetLocName(string value)
        {
            locName = value;
        }
        /*public void SetStreetname(int value)
        {
            streetNum = value;
        }*/
        public void SetStreetName(string value)
        {
            streetName = value;
        }
        public void SetCounty(string value)
        {
            county = value;
        }
        public void SetPostcode(string value)
        {
            postcode = value;
        }
        public void SetLatitude(double value)
        {
            latitude = value;
        }
        public void SetLongitude(double value)
        {
            longitude = value;
        }
        public void SetYearArray(Years[] value)
        {
            yearArray = value;
        }

    }
}
