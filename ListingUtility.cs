namespace mis_221_pa_5_fgarmstrong
{
    public class ListingUtility
    {
        private Listing[] listOfListings;
        public ListingUtility(Listing[] listOfListings)
        {
            this.listOfListings = listOfListings;
            GetAllListingsFromFile();
        }
        public void GetAllListingsFromFile()  //  this method populates the array with the lisitng alrready in the file 
        {
            // open listings file
            StreamReader inFile = new StreamReader("listings.txt");// open file
                                                                   //process file
            Listing.SetListingCount(0);
            string line = inFile.ReadLine();
            while (line != null && line != "")
            {
                string[] tempListing = line.Split('#');
                listOfListings[Listing.GetListingCount()] = new Listing(int.Parse(tempListing[0]), tempListing[1], DateTime.Parse(tempListing[2]), int.Parse(tempListing[3]), bool.Parse(tempListing[4]));
                Listing.IncListingCount();
                line = inFile.ReadLine();

            }

            inFile.Close();
        }


        public void AddListingData() // this method is to add a new listing to the listing file
        {
            Listing newListing = new Listing();

            System.Console.WriteLine("Please enter trainers name:");
            // Listing newListing = new Listing();
            newListing.SetTrainerName((Console.ReadLine()));

            newListing.SetListingID();

            System.Console.WriteLine("Please enter the date and time of the listing (ex: 5/15/23 2:15PM):");
            newListing.SetDateAndTimeOfSession(DateTime.Parse((Console.ReadLine())));

            // System.Console.WriteLine("Please enter the time of the listing:");
            // newListing.SetTimeOfSession(DateTime.Parse((Console.ReadLine())));

            System.Console.WriteLine("Please enter the cost of the listing:");
            newListing.SetCostOfSession(int.Parse((Console.ReadLine())));

            int count = Listing.GetListingCount();
            System.Console.WriteLine(Listing.GetListingCount());
            listOfListings[Listing.GetListingCount()] = newListing;
            Listing.IncListingCount();

            SaveListing();
        }

        public void EditListingData()  // this methid is to edit listing data that is alread in the listings file
        {
            System.Console.WriteLine("Whats the Listing ID of the Listing you would like to update");
            int searchVal = int.Parse(Console.ReadLine()); //mightve blown up around here
            int foundIndex = Find(searchVal);
            if (foundIndex != -1)
            {
                System.Console.WriteLine("Please enter trainers name:");

                Listing newListing = new Listing();
                newListing.SetTrainerName((Console.ReadLine()));

                newListing.SetListingID();

                System.Console.WriteLine("Please enter the date and time of the listing (ex: 5/15/23 2:15PM):");
                newListing.SetDateAndTimeOfSession(DateTime.Parse((Console.ReadLine())));

                // System.Console.WriteLine("Please enter the time of the listing:");
                // newListing.SetTimeOfSession(DateTime.Parse((Console.ReadLine())));

                System.Console.WriteLine("Please enter the cost of the listing:");
                newListing.SetCostOfSession(int.Parse((Console.ReadLine())));
                listOfListings[foundIndex] = newListing;
            }
            else
            {
                System.Console.WriteLine("lisitng not found :(");
            }


            SaveListing();
        }

        public void DeleteListingData()  // this method is to soft delete a listing in a manner that the ID of the listings will not be affected
        {
            System.Console.WriteLine("Please enter the ID of the listing you would like to delete:");
            int searchVal = int.Parse(Console.ReadLine());
            int foundIndex = Find(searchVal);
            if (foundIndex != -1)
            {
                listOfListings[foundIndex].SetListingTaken(true);
            }
            SaveListing();
        }


        private void SaveListing()  // this method is to add a lisitng too the listing file
        {
            StreamWriter outFile = new StreamWriter("listings.txt");


            for (int i = 0; i < Listing.GetListingCount(); i++)
            {
                outFile.WriteLine(listOfListings[i].ToFile());
            }

            outFile.Close();

            //GetAllListingsFromFile();
        }

        public int Find(int searchVal)  // this method is to find a specific lisitng to edit 
        {
            for (int i = 0; i < Listing.GetListingCount(); i++)
            {
                if (listOfListings[i].GetListingID() == searchVal)
                {
                    return i;
                }
            }
            return -1;
        }



    }
}