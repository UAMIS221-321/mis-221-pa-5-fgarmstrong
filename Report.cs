// namespace mis_221_pa_5_fgarmstrong
// {
// public class Report
//     {

//         listOfBookings[] ListOfBookings;
//         public Report(listOfBookings[] listOfBookings)
//         {
//             this.listOfBookings = listOfBookings;
            
//         }
//         public void PrintAllPreviousSessions()
//         {
//             System.Console.WriteLine("Please enter customer email");
//             string customerEmail = Console.ReadLine();

//             StreamReader inFile = new StreamReader("transactions.txt");
//             string line = inFile.ReadLine();
            
//             while(line != null)
//             {
//                 string[] temp = line.Split("#");
//                 if(temp[3] == customerEmail)
//                 {
//                     System.Console.WriteLine($"Customer email: {temp[3]}");
//                     System.Console.WriteLine($"Date: {temp[4]}");
//                     System.Console.WriteLine($"Numer of Sessions: {temp[5]}");
//                 }
//                 line = inFile.ReadLine();
//             }
//             inFile.Close();
//         }

//         public void HistoricalCustomerSessons()
//         {
//             System.Console.WriteLine("Please enter name of the customer you are trying to find");
//             string customerName = Console.ReadLine();

//             StreamReader inFile = new StreamReader("Transactions.txt");
//             string line = inFile.ReadLine();

//             for (int i = 0; i < Booking.GetBookingCount() -1; i++ )
//             {
//                 int min = i;
//                 for(int j = i + 1; j < Booking.GetBookingCount(); j++)
//                 {
//                     if(listOfBookings[j].GetCustomerName().CompareTo(listOfbookings[min].GetCustomerName()) < 0 || 
//                     (listOfBookings[j].GetCustomerName() == listOfBookings[min].GetCustomerName()) && bookings[j].GetTrainingDate()< lisOfBookings[min].GetTrainingDate())
//                     {
//                         min = j;
//                     }
//                 }
//                 if(min != -1)
//                 {
//                     Swap(min, i);
//                 }

//             }

//         }

//         public void HistoricalRevenueReport()
//         {
//             System.Console.WriteLine("Please enter customer email");
//             string customerEmail = Console.ReadLine();
//         }

//     }
// }