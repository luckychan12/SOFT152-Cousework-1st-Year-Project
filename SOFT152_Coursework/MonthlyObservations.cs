using System;

namespace SOFT152_Coursework
{
    public class MonthlyObservations
    {
        //initialising properties
        private int monthID;
        private double maxTemp;
        private double minTemp;
        private int numDaysOfFrost;
        private double mmOfRain;
        private double sunshine;

        //Methods:
        public MonthlyObservations(int monthID, double maxTemp, double minTemp, int numDaysOfFrost, double mmOfRain, double sunshine)
        {
            this.monthID = monthID;
            this.maxTemp = maxTemp;
            this.minTemp = minTemp;
            this.numDaysOfFrost = numDaysOfFrost;
            this.mmOfRain = mmOfRain;
            this.sunshine = sunshine;
        }

        /*getters*/
        public int GetMonthID()
        {
            return monthID;
        }
        public double GetMaxTemp()
        {
            return maxTemp;
        }
        public double GetMinTemp()
        {
            return minTemp;
        }
        public int GetNumDaysOfFrost()
        {
            return numDaysOfFrost;
        }
        public double GetMmOfRain()
        {
            return mmOfRain;
        }
        public double GetSunshine()
        {
            return sunshine;
        }
        /*setters*/
        public void SetMonthID(int value)
        {
            monthID = value;
        }
        public void SetMaxTemp(double value)
        {
            maxTemp = value;
        }
        public void SetMinTemp(double value)
        {
            minTemp = value;
        }
        public void SetNumDaysOfFrost(int value)
        {
            numDaysOfFrost = value;
        }
        public void SetMmOfRain(Double value)
        {
            mmOfRain = value;
        }
        public void SetSunshine(double value)
        {
            sunshine = value;
        }






    }
}
