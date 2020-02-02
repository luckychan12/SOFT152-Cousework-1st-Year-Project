namespace SOFT152_Coursework
{
    public class Years
    {
        //setting properties
        private int yearID;
        private string yearComment;
        private MonthlyObservations[] monthlyObservationArray;
        
        //Methods:
        
            //Constructor:
        public Years(int yearID, string yearComment, MonthlyObservations[] monthlyObservationArray)
        {
            this.yearID = yearID;
            this.yearComment = yearComment;
            this.monthlyObservationArray = monthlyObservationArray;
        }

        //Getter and setter methods:
            //Getter methods:
        public int GetYearID()
        {
            return yearID;
        }
        public string GetYearComment()
        {
            return yearComment;
        }
        public MonthlyObservations[] GetMonthlyObservationArray()
        {
            return monthlyObservationArray;
        }

            //setter methods:
        public void SetYearID(int value)
        {
            yearID = value;
        }
        public void SetYearComment(string value)
        {
            yearComment = value;
        }
        public void SetMonthlyObservationArray(MonthlyObservations[] value)
        {
            monthlyObservationArray = value;
        }
    }
}
