namespace mis_221_pa_5_fgarmstrong
{
    public class BookingUtility
    {
        private Booking[] listOfBookings;
        public BookingUtility(Booking[] listOfBookings)
        {
            this.listOfBookings = listOfBookings;
            GetAllTransactionsFromFile();
            
        }
    



    public void  GetAllTransactionsFromFile() // this method populates the booking array fro the transaction file
    {
          // open transactions file
        StreamReader inFile = new StreamReader("transactions.txt"); //open the transactions file
        // process the transactions file
        Booking.SetBookingCount(0);
        string line = inFile.ReadLine();
        while(line != null && line != "")
        {
            string[] tempBooking = line.Split('#');
            listOfBookings[Booking.GetBookingCount()] = new Booking(int.Parse(tempBooking[0]), tempBooking[1], tempBooking[2], DateTime.Parse(tempBooking[3]), int.Parse(tempBooking[4]),tempBooking[5],(tempBooking[5]));
            Booking.IncBookingCount();
            line = inFile.ReadLine();
        }

        inFile.Close();
    }

    public  void VeiwAvalibleSessions(Trainer[] listOfTrainer, Listing[] listOfListings, bool listingTaken) // this method is to be able to see all avalible trainng sessions in the listing array
    {
           // open listings file
        StreamReader inFile = new StreamReader("listings.txt");// open file
        //process file
        string line = inFile.ReadLine();
        while (line != null && line != "")
        {
            if(listingTaken == false)
            {
            Console.WriteLine(line);
            }
            else
            {
                System.Console.WriteLine("No sessions avalible :(");
            }

            // set the next line as the line
            line = inFile.ReadLine();

        }

        inFile.Close();
        
        
    }

    public void BookASession(Booking[] listOfBookings, Trainer[] listOfTrainer, Listing[] listOfListings, bool listingTaken) // this method is to be able to book a training session
    {
        Booking newBooking = new Booking();
        // get user input of the session they want to book
        System.Console.WriteLine("Please enter the Listing ID of the session you want to book:");
        int choice = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Please enter your name:");
        newBooking.SetCustomerName(Console.ReadLine());

        System.Console.WriteLine("Please enter your email:");
        newBooking.SetCustomerEmail(Console.ReadLine());

        int listing = FindListing(choice, listOfListings);
        Listing currListing = listOfListings[listing];
        newBooking.SetTrainerName(currListing.GetTrainerName());
        newBooking.SetTrainingDate(currListing.GetDateAndTimeOfSession());
        //newBooking.SetBookingStatus("Booked");
        
        int trainerID = FindTrianerID(choice, listOfTrainer);
        Trainer currTrainerID = listOfTrainer[trainerID];
        newBooking.SetTrainerID(currTrainerID.GetTrainerID());

        int count = Booking.GetBookingCount();
        System.Console.WriteLine(Booking.GetBookingCount);
        listOfBookings[Booking.GetBookingCount()] = newBooking;
        Listing.IncListingCount();
        newBooking.SetSessionID(count);
        newBooking.SetBookingStatus("Booked");
        SaveBooking();

    }

      private void SaveBooking()  
    {
        StreamWriter outFile = new StreamWriter("transactions.txt");

        
        for(int i = 0; i < Booking.GetBookingCount(); i++)
        {
            outFile.WriteLine(listOfBookings[i].ToFile());
        }
        
        outFile.Close();
    
    }


    public void CompleteSession()
    {
        Booking editedBooking = new Booking();
        editedBooking.SetBookingStatus("Completed");
    }

    public void CancelSession()
    {
        Booking editedBooking = new Booking();
        editedBooking.SetBookingStatus("Open");
    }

    public void NoShowSession()
    {
        Booking editedBooking = new Booking();
        editedBooking.SetBookingStatus("No Show");
    }

    public int FindListing(int choice, Listing[] listOfListings)  // this method is to find a specific lisitng to edit 
    {
        for (int i = 0; i < Listing.GetListingCount(); i++)
        {
            if (listOfListings[i].GetListingID() == choice)
            {
                return i;
            }
        }
        return -1;
    }

    public int FindTrianerID(int choice, Trainer[] listOfTrainer)  // this method is to find a specific lisitng to edit 
    {
        for (int i = 0; i < Trainer.GetCount(); i++)
        {
            if (listOfTrainer[i].GetTrainerID() == choice)
            {
                return i;
            }
        }
        return -1;
    }
  }
}