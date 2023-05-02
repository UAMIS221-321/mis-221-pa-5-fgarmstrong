//Start main
using mis_221_pa_5_fgarmstrong;
Trainer[] listOfTrainer = new Trainer[75];
TrainerUtility tUtility = new TrainerUtility(listOfTrainer);
tUtility.GetAllTrainersFromFile();
Listing[] listOfListings = new Listing[75];
ListingUtility lUtility = new ListingUtility(listOfListings);
lUtility.GetAllListingsFromFile();
Booking[] listOfBookings = new Booking[75];
Identity[] listofIdentity = new Identity[75];
bool listingTaken = false;
//string bookingStatus = "Booked";
// PA 5 Initial Trainer/Listing/Booking Data, Report Running Menu

System.Console.WriteLine("╭━━━━┳━━┳━━━━┳━━━┳━╮╱╭╮╭╮╱╭┳━━━╮╭━━━┳╮╱╱╭┳━╮╭━╮");
System.Console.WriteLine("┃╭╮╭╮┣┫┣┫╭╮╭╮┃╭━╮┃┃╰╮┃┃┃┃╱┃┃╭━╮┃┃╭━╮┃╰╮╭╯┃┃╰╯┃┃");
System.Console.WriteLine("╰╯┃┃╰╯┃┃╰╯┃┃╰┫┃╱┃┃╭╮╰╯┃┃┃╱┃┃╰━╯┃┃┃╱╰┻╮╰╯╭┫╭╮╭╮┃");
System.Console.WriteLine("╱╱┃┃╱╱┃┃╱╱┃┃╱┃╰━╯┃┃╰╮┃┃┃┃╱┃┃╭━━╯┃┃╭━╮╰╮╭╯┃┃┃┃┃┃");
System.Console.WriteLine("╱╱┃┃╱╭┫┣╮╱┃┃╱┃╭━╮┃┃╱┃┃┃┃╰━╯┃┃╱╱╱┃╰┻━┃╱┃┃╱┃┃┃┃┃┃");
System.Console.WriteLine("╱╱╰╯╱╰━━╯╱╰╯╱╰╯╱╰┻╯╱╰━╯╰━━━┻╯╱╱╱╰━━━╯╱╰╯╱╰╯╰╯╰╯");

System.Console.WriteLine("T̶H̶E̶ G̶Y̶M̶ W̶H̶E̶R̶E̶ A̶L̶L̶ T̶H̶E̶ T̶R̶A̶I̶N̶E̶R̶S̶ A̶R̶E̶");
System.Console.WriteLine("N̶F̶L̶ A̶T̶H̶E̶L̶E̶T̶E̶S̶ O̶N̶ T̶H̶E̶ T̶E̶N̶N̶E̶S̶S̶E̶E̶ T̶I̶T̶A̶N̶S̶");

int userChoiceSignInMenu = GetUserChoiceSignINMenu(); // priming read

//while (userChoiceSignInMenu!=3) {
    RouteEmSignInMenu(userChoiceSignInMenu, listOfTrainer, listOfListings, listOfBookings,listofIdentity, listingTaken);
    //2\userChoiceSignInMenu = GetUserChoiceSignINMenu();
   
     // update read
//} 

// end main

static int GetUserChoiceSignINMenu() {// PA 5 sign in  menu-----------------------------------------------------------------------------------------
    DisplaySignInMenu(); 
    string userChoiceSignInMenu = Console.ReadLine();
    if(ValidChoiceSignINMenu(userChoiceSignInMenu)) {
        return int.Parse(userChoiceSignInMenu);
    }
    else SayInvalid();
    return 0;
}

static void DisplaySignInMenu() { // this is PA 5 sign in  Menu Display 

    Console.WriteLine("\n============================================");
    Console.WriteLine("|            WELCOME TO TITAN UP  GYM       |");
    Console.WriteLine("|___________________________________________|");
    Console.WriteLine("|                                           |");
    Console.WriteLine("|       Please choose an option below:      |");
    Console.WriteLine("|                                           |");
    Console.WriteLine("|            1. Sign in existing account    |");
    Console.WriteLine("|            2. Create account              |");
    Console.WriteLine("|            3. Exit System                 |");
    Console.WriteLine("|___________________________________________|");


}

static bool ValidChoiceSignINMenu(string userChoiceSignInMenu) {
    if(userChoiceSignInMenu== "1" || userChoiceSignInMenu== "2" || userChoiceSignInMenu=="3") {
        return true;
    }
    else return false;
}

// static void SayInvalid() {  
//     System.Console.WriteLine("That selection is Invalid!");  // only need these once 
//     PauseAction();
// }

static void RouteEmSignInMenu(int SignInMenuChoice, Trainer[] listOfTrainer, Listing[] listOfListings, Booking[] listOfBookings, Identity[] listofIdentity, bool listingTaken) { //this is PA 5 start menu
    IdentityUtility IDUtility = new IdentityUtility(listofIdentity);
    if(SignInMenuChoice==1) {
        IDUtility.SignInIdentity();
        
    }
    else if(SignInMenuChoice==2) {
        IDUtility.AddUserIdentity();
    }
    else if(SignInMenuChoice==3) {
        LeaveSystem();
    }
     
}
// static void PauseAction(){
//     System.Console.WriteLine("Press any key to return to the menu"); // only need these once 
//     Console.ReadKey();
//     Console.Clear();
// }

// static void LeaveSystem(){
//     System.Console.WriteLine("Press any key to return to Exit the System");  // only need these once 
//     Console.ReadKey();
//     Console.Clear();
// }

int userChoiceStartMenu = GetUserChoiceStartMenu(); // priming read ************************************************************************* this is a mark bc i a blind

while (userChoiceStartMenu!=5) {
    RouteEmSartMenu(userChoiceStartMenu, listOfTrainer, listOfListings, listOfBookings, listingTaken);
    userChoiceStartMenu = GetUserChoiceStartMenu(); // update read
} 

// end main

static int GetUserChoiceStartMenu() {// PA 5 start menu-----------------------------------------------------------------------------------------
    DisplayStartMenu(); 
    string userChoiceStartMenu = Console.ReadLine();
    if(ValidChoiceStartMenu(userChoiceStartMenu)) {
        return int.Parse(userChoiceStartMenu);
    }
    else SayInvalid();
    return 0;
}

static void DisplayStartMenu() { // this is PA 5 Initial Menu Display 

    Console.WriteLine("\n============================================");
    Console.WriteLine("|            WELCOME TO TITAN UP  GYM       |");
    Console.WriteLine("|___________________________________________|");
    Console.WriteLine("|                                           |");
    Console.WriteLine("|       Please choose an option below:      |");
    Console.WriteLine("|                                           |");
    Console.WriteLine("|            1. Manage Trainer Data         |");
    Console.WriteLine("|            2. Manage Listing Data         |");
    Console.WriteLine("|            3. Manage Customer Booking Data|");
    Console.WriteLine("|            4. Run Reports                 |");
    Console.WriteLine("|            5. Exit the System             |");
    Console.WriteLine("|___________________________________________|");


}

static bool ValidChoiceStartMenu(string userChoiceStartMenu) {
    if(userChoiceStartMenu== "1" || userChoiceStartMenu== "2" || userChoiceStartMenu=="3" || userChoiceStartMenu=="4" || userChoiceStartMenu=="5") {
        return true;
    }
    else return false;
}

static void SayInvalid() {  
    System.Console.WriteLine("That selection is Invalid!");
    PauseAction();
}

static void RouteEmSartMenu(int StartMenuChoice, Trainer[] listOfTrainer, Listing[] listOfListings, Booking[] listOfBookings, bool listingTaken) { //this is PA 5 start menu
    if(StartMenuChoice==1) {
        ManageTrainerMenu(listOfTrainer);
    }
    else if(StartMenuChoice==2) {
        ManageListingMenu(listOfListings);
    }
    else if(StartMenuChoice==3) {
        ManageBookingMenu(listOfBookings, listOfListings, listOfTrainer, listingTaken);
    }
     else if(StartMenuChoice==4) {
        ManageReportsMenu(listOfBookings);
    }
     else if(StartMenuChoice==5) {
        LeaveSystem();
    }
     
}
static void PauseAction(){
    System.Console.WriteLine("Press any key to return to the menu");
    Console.ReadKey();
    Console.Clear();
}

static void LeaveSystem(){
    System.Console.WriteLine("Press any key to Exit the System");
    Console.ReadKey();
    Console.Clear();
}

//Methods for user choice 1 called in Initial Menu

static void ManageTrainerMenu(Trainer[] listOfTrainer) { // PA 5 trainer menu-----------------------------------------------------------------------------------------
    int userChoiceTrainerMenu = TrainerMenuChoice(); // priming read

while (userChoiceTrainerMenu!=4) {
    RouteTrainerMenuChoice(userChoiceTrainerMenu, listOfTrainer);
    userChoiceTrainerMenu = TrainerMenuChoice(); // update read
} 
}


static int TrainerMenuChoice() {
    DisplayTrainerMenu(); 
    string userChoiceTrainerMenu = Console.ReadLine();
    if(IsValidChoiceTrainnerMenu(userChoiceTrainerMenu)) {
        return int.Parse(userChoiceTrainerMenu);
    }
    else SayInvalid();
    return 0;
}

static void DisplayTrainerMenu() {  

    Console.WriteLine("\n*******************************************");
    Console.WriteLine("*            MANAGE TRAINER DATA            *");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*                                           *");
    Console.WriteLine("*        What would you like to do?         *");
    Console.WriteLine("*                                           *");
    Console.WriteLine("*           1. Add New Trainer              *");
    Console.WriteLine("*           2. Edit Trainer Information     *");
    Console.WriteLine("*           3. Remove a Trainer             *");
    Console.WriteLine("*           4. Return to Main Menu          *");
    Console.WriteLine("*                                           *");
    Console.WriteLine("*********************************************");

}

static bool IsValidChoiceTrainnerMenu(string userChoiceTrainerMenu) {
    if(userChoiceTrainerMenu== "1" || userChoiceTrainerMenu== "2" || userChoiceTrainerMenu== "3" || userChoiceTrainerMenu== "4") {
        return true;
    }
    else return false;
}


static void RouteTrainerMenuChoice(int trainerMenuChoice, Trainer[] listOfTrainer) { 
    TrainerUtility trainerUtility = new TrainerUtility(listOfTrainer);
    if(trainerMenuChoice==1) {
        trainerUtility.AddTrainerData();
    }
    else if(trainerMenuChoice==2) {
        trainerUtility.EditTrainerData();
    }
    else if(trainerMenuChoice==3) {
        trainerUtility.DeleteTrainer();
    }
     else if(trainerMenuChoice==4) {
        GetUserChoiceStartMenu();// make this go back to main
    }
     
}


static void ManageListingMenu(Listing[] listOfListings) { // PA 5 listing menu-----------------------------------------------------------------------------------------
    int userChoiceListingMenu = GetUserChoiceListingMenu(); // priming read

while (userChoiceListingMenu!=4) {
    RouteListingMenu(userChoiceListingMenu, listOfListings);
    userChoiceListingMenu = GetUserChoiceListingMenu(); // update read
} 
}


static int GetUserChoiceListingMenu() {
    DisplayListingMenu(); 
    string userChoiceListingMenu = Console.ReadLine();
    if(IsValidChoiceListingMenu(userChoiceListingMenu)) {
        return int.Parse(userChoiceListingMenu);
    }
    else SayInvalid();
    return 0;
}

static void DisplayListingMenu() { // this is PA 5 listing Menu Display 

    Console.WriteLine("\n*******************************************");
    Console.WriteLine("*      MANAGE TRAINING SESSION LISTING      *");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*                                           *");
    Console.WriteLine("*        What would you like to do?         *");
    Console.WriteLine("*                                           *");
    Console.WriteLine("*           1. Add New Listing              *");
    Console.WriteLine("*           2. Edit Listing Information     *");
    Console.WriteLine("*           3. Remove a Listing             *");
    Console.WriteLine("*           4. Return to Main Menu          *");
    Console.WriteLine("*                                           *");
    Console.WriteLine("*********************************************");


}

static bool IsValidChoiceListingMenu(string userChoiceListingMenu) {
    if(userChoiceListingMenu== "1" || userChoiceListingMenu== "2" || userChoiceListingMenu== "3" || userChoiceListingMenu== "4") {
        return true;
    }
    else return false;
}


static void RouteListingMenu(int menuChoiceListing, Listing[] listOfListings) 
{ //this is PA 5 listing menu
    ListingUtility listingUtility = new ListingUtility(listOfListings);
    if(menuChoiceListing==1) {
        listingUtility.AddListingData();
    }
    else if(menuChoiceListing==2) {
        listingUtility.EditListingData();
    }
    else if(menuChoiceListing==3) {
        listingUtility.DeleteListingData();
    }
    else if(menuChoiceListing==4) {
        GetUserChoiceStartMenu();// make this go back to main
    }
     
}


    
static void ManageBookingMenu(Booking[] listOfBookings, Listing[] listOfListings, Trainer[] listOfTrainer, bool listingTaken) // PA 5 booking menu-----------------------------------------------------------------------------------------
{ 
    int userChoiceBookingMenu = GetUserChoiceBookingMenu(); // priming read

while (userChoiceBookingMenu!=4) {
    RouteBookingMenu(userChoiceBookingMenu, listOfBookings, listOfListings, listOfTrainer, listingTaken);
    userChoiceBookingMenu = GetUserChoiceBookingMenu(); // update read
} 
}



static int GetUserChoiceBookingMenu() {
    DisplayBookingMenu(); 
    string userChoiceBookingMenu = Console.ReadLine();
    if(IsValidChoiceBookingMenu(userChoiceBookingMenu)) {
        return int.Parse(userChoiceBookingMenu);
    }
    else SayInvalid();
    return 0;
}

static void DisplayBookingMenu() {  

    Console.WriteLine("\n*******************************************");
    Console.WriteLine("*             MANAGE BOOKINGS               *");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*                                           *");
    Console.WriteLine("*        What would you like to do?         *");
    Console.WriteLine("*                                           *");
    Console.WriteLine("*           1. View Available Sessions      *");
    Console.WriteLine("*           2. Book a Session               *");
    Console.WriteLine("*           3. Edit a Previous Booking      *");
    Console.WriteLine("*           4. Return to Main Menu          *");
    Console.WriteLine("*                                           *");
    Console.WriteLine("*********************************************");


}

static bool IsValidChoiceBookingMenu(string userChoiceBookingMenu) {
    if(userChoiceBookingMenu== "1" || userChoiceBookingMenu== "2" || userChoiceBookingMenu== "3" || userChoiceBookingMenu== "4") {
        return true;
    }
    else return false;
}


static void RouteBookingMenu(int bookingMenuChoice, Booking[] listOfBookings, Listing[] listOfListings, Trainer[] listOfTrainer, bool listingTaken) { 
    BookingUtility bookingUtility = new BookingUtility(listOfBookings);
    if(bookingMenuChoice==1) {
        bookingUtility.VeiwAvalibleSessions(listOfTrainer, listOfListings, listingTaken);
    }
    else if(bookingMenuChoice==2) {
        bookingUtility.BookASession(listOfBookings, listOfTrainer, listOfListings,  listingTaken);
    }
    else if(bookingMenuChoice==3) {
        EditBookingMenu(listOfBookings, listOfListings, listingTaken);
    }
    else if(bookingMenuChoice==4) {
        GetUserChoiceStartMenu();// make this go back to main
    }
}

static void EditBookingMenu(Booking[] listOfBookings, Listing[] listOfListings, bool listingTaken) // PA 5 second booking to change a booking menu-----------------------------------------------------------------------------------------
{ 
    int userChoiceEditBookingMenu = GetUserChoiceEditBookingMenu(); // priming read

while (userChoiceEditBookingMenu!=4) {
    RouteEditBookingMenu(userChoiceEditBookingMenu, listOfBookings, listOfListings, listingTaken);
    userChoiceEditBookingMenu = GetUserChoiceEditBookingMenu(); // update read
} 
}



static int GetUserChoiceEditBookingMenu() {
    DisplayEditBookingMenu(); 
    string userChoiceEditBookingMenu = Console.ReadLine();
    if(IsValidChoiceEditBookingMenu(userChoiceEditBookingMenu)) {
        return int.Parse(userChoiceEditBookingMenu);
    }
    else SayInvalid();
    return 0;
}

static void DisplayEditBookingMenu() {  

    Console.WriteLine("\n*******************************************");
    Console.WriteLine("*           EDIT SESSION BOOKING            *");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*                                           *");
    Console.WriteLine("*        What would you like to do?         *");
    Console.WriteLine("*                                           *");
    Console.WriteLine("*          1. Complete a Session            *");
    Console.WriteLine("*          2. Cancel a Session              *");
    Console.WriteLine("*          3. Mark as No Show               *");
    Console.WriteLine("*          4. Return to Main Menu           *");
    Console.WriteLine("*                                           *");
    Console.WriteLine("*********************************************");
   

}

static bool IsValidChoiceEditBookingMenu(string userChoiceEditBookingMenu) {
    if(userChoiceEditBookingMenu== "1" || userChoiceEditBookingMenu== "2" || userChoiceEditBookingMenu== "3" || userChoiceEditBookingMenu== "4") {
        return true;
    }
    else return false;
}


static void RouteEditBookingMenu(int EditbookingMenuChoice, Booking[] listOfBookings, Listing[] listOfListings, bool listingTaken) { 
    BookingUtility bookingUtility = new BookingUtility(listOfBookings);
    if(EditbookingMenuChoice==1) {
        bookingUtility.CompleteSession();
    }
    else if(EditbookingMenuChoice==2) {
        bookingUtility.CancelSession();
    }
    else if(EditbookingMenuChoice== 3) {
        bookingUtility.NoShowSession();
    }
    else if(EditbookingMenuChoice==4) {
        GetUserChoiceStartMenu();// make this go back to main
    }
}


 static void ManageReportsMenu(Booking[] listOfBookings) // PA 5 reports menu-----------------------------------------------------------------------------------------
    { // method to add a trainer
    int userChoiceReportsMenu = GetUserChoiceReportMenu(); // priming read

    while (userChoiceReportsMenu!=4) {
    RouteReports(userChoiceReportsMenu, listOfBookings);
    userChoiceReportsMenu = GetUserChoiceReportMenu(); // update read
    } 
    }



static int GetUserChoiceReportMenu() {
    DisplayReportsMenu(); 
    string userChoiceReportsMenu = Console.ReadLine();
    if(ValidChoiceReportsMenu(userChoiceReportsMenu)) {
        return int.Parse(userChoiceReportsMenu);
    }
    else SayInvalid();
    return 0;
}

static void DisplayReportsMenu() {  

    Console.WriteLine("\n********************************************");
    Console.WriteLine("*                 RUN REPORTS                *");
    Console.WriteLine("**********************************************");
    Console.WriteLine("*                                            *");
    Console.WriteLine("*        What would you like to do?          *");
    Console.WriteLine("*                                            *");
    Console.WriteLine("*      1. View Individual Customer Sessions  *");
    Console.WriteLine("*      2. View Historical Customer Sessions  *");
    Console.WriteLine("*      3. View Historical Revenue Report     *");
    Console.WriteLine("*      4. Return to Main Menu                *");
    Console.WriteLine("*                                            *");
    Console.WriteLine("**********************************************");



}

static bool ValidChoiceReportsMenu(string userChoiceReportsMenu) {
    if(userChoiceReportsMenu== "1" || userChoiceReportsMenu== "2" || userChoiceReportsMenu== "3" || userChoiceReportsMenu== "4") {
        return true;
    }
    else return false;
}


static void RouteReports(int reportsMenuChoice, Booking[] listOfBookings) // since my reports were so messed up i just commented these out as well to allow the app to run
{ //this is PA 5 start menu
    // Report runReport = new Report(listOfBookings);
    // if(reportsMenuChoice==1) {
    //     runReport.PrintAllPreviousSessions();
    // }
    // else if(reportsMenuChoice==2) {
    //     runReport.HistoricalCustomerSessons();
    // }
    // else if(reportsMenuChoice==3) {
    //     runReport.HistoricalRevenueReport();
    // }
    // else if(reportsMenuChoice==4) {
    //     GetUserChoiceStartMenu();// make this go back to main
    // }
}




