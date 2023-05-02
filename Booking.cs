namespace mis_221_pa_5_fgarmstrong
{
    public class Booking
    {
        // these are the booking functions instance variables
        private int trainerID;
        private string trainerName;
        private DateTime trainingDate;
        private string customerEmail;
        private string customerName;
        private int sessionID;


        // these are the class variables
        static private int count;
        private string bookingStatus;

        // arg constructor
        public Booking(int trainerID, string trainerName, string customerEmail,
        DateTime trainingDate,int sessionID, string customerName, string bookingStatus)
        {
            this.trainerID = trainerID;
            this.trainerName = trainerName;
            this.trainingDate = trainingDate;
            this.customerEmail = customerEmail;
            this.customerName = customerName;
            this.sessionID = sessionID;
            this.sessionID = count;
            this.bookingStatus = bookingStatus;
        }

        // no arg constructor
        public Booking()
        {
            // no return type here & same name as the class
        }

        public int GetTrianerID()
        {
            return trainerID;
        }

        public void SetTrainerID(int trainerID)
        {
            this.trainerID = trainerID;
        }

        public string TrainerName()
        {
            return trainerName;
        }

        public void SetTrainerName(string trainerName)
        {
            this.trainerName = trainerName;
        }

        public DateTime GetTrainingDate()
        {
            return trainingDate;
        }

        public void SetTrainingDate(DateTime trainingDate)
        {
            this.trainingDate = trainingDate;
        }

        public string GetCustomerEmail()
        {
            return customerEmail;
        }

        public void SetCustomerEmail(string customerEmail)
        {
            this.customerEmail = customerEmail;
        }

        public string GetCustomerName()
        {
            return customerName;
        }

        public void SetCustomerName(string customerName)
        {
            this.customerName = customerName;
        }

        public static int GetBookingCount()
        {
            return count;
        }

        public static void SetBookingCount(int count)
        {
            Booking.count = count;
        }

        public int GetSessionID()
        {
            return sessionID;
        }

        public void SetSessionID(int count)
        {
            this.sessionID = count;
        }

         public string GetBookingStatus()
        {
            return bookingStatus;
        }
        
        public void SetBookingStatus(string bookingStatus)
        {
            this.bookingStatus = bookingStatus;
        }

         static public void IncBookingCount() 
        {
            count++;
        }

        public override string ToString()
        {
            return $"{sessionID} is a training sesson booked by {customerName} whos email is {customerEmail} the session will occur on {trainingDate} with the trainer {trainerName} whos ID is {trainerID}";
        }

        public string ToFile()
        {
            return $"{sessionID}#{customerName}#{customerEmail}#{trainingDate}#{trainerID}#{trainerName}#{bookingStatus}";
        }
    }
}