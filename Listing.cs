namespace mis_221_pa_5_fgarmstrong
{
    public class Listing
    {
        // these are the listing instance vaiables
        private int listingID;
        private string trainerName;
        private DateTime dateAndTimeOfSession;
        private int costOfSession;
        private int ListingNumber;

        //these are the class variables, i think
        private bool listingTaken;
        static int count;

        // this is the arg constructor
        public Listing(int listingID, string trainerName, DateTime dateAndTimeOfSession, int costOfSession, bool listingTaken)
        {
            this.listingID = listingID;
            this.trainerName = trainerName;
            this.dateAndTimeOfSession = dateAndTimeOfSession;
            this.costOfSession = costOfSession;
            // count++;
            this.ListingNumber = count;
            this.listingTaken = listingTaken;

        }

        // this is the no arg constructor
        public Listing()
        {
            listingTaken = false;
        }

        public int GetListingID()
        {
            return listingID;
        }

        public void SetListingID()
        {
            this.listingID = count;
        }

         public string GetTrainerName()
        {
            return trainerName;
        }

        public void SetTrainerName(string trainerName)
        {
            this.trainerName = trainerName;
        }

            public DateTime  GetDateAndTimeOfSession()
        {
            return dateAndTimeOfSession;
        }

        public void SetDateAndTimeOfSession(DateTime dateAndTimeOfSession)
        {
            this.dateAndTimeOfSession = dateAndTimeOfSession;
        }

     

                public int  GetCostOfSession()
        {
            return costOfSession;
        }

        public void SetCostOfSession(int costOfSession)
        {
            this.costOfSession = costOfSession;
        }

     // do i need a count?
      static public void SetListingCount(int count)
        {
            Listing.count = count;
        }

        static public int GetListingCount() // class method
        {
            return count;
        }

        public bool GetListingTaken()
        {
            return listingTaken;
        }
        
        public void SetListingTaken(bool listingTaken)
        {
            this.listingTaken = listingTaken;
        }

        static public void IncListingCount() 
        {
            count++;
        }

       public override string ToString() {
            return $"{listingID} is a training session with {trainerName}, the date and time of the session is {dateAndTimeOfSession}, and the cost of the session is {costOfSession} dollars. ";
        
        }

        public string ToFile() {
            return $"{listingID}#{trainerName}#{dateAndTimeOfSession.ToString("yyyy-MM-dd HH:mm:ss.fff")}#{costOfSession}#{listingTaken}";
        
        }

    }
}