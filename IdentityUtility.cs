namespace mis_221_pa_5_fgarmstrong
{
    public class IdentityUtility
    {
        private Identity[] listOfIdentity;
        public IdentityUtility(Identity[] listOfIdentity)
        {
            this.listOfIdentity = listOfIdentity;
            GetAllIdentiesFromFile();
        }

        public void GetAllIdentiesFromFile()
        {
            // open identies file
            StreamReader inFile = new StreamReader("identity.txt"); // openthe file
            // process the file
            Identity.SetCount(0);
            string line = inFile.ReadLine();
            while(line != null && line != "")
            {
                string[] temp = line.Split('#');
                listOfIdentity[Identity.GetCount()] = new Identity(temp[0], temp[1]);
                Identity.IncIdentityCount();
                line = inFile.ReadLine();
            }
        }

        public void AddUserIdentity() // this method adds a usrnm and pswrd
        {
            Identity newIdentity = new Identity();
            System.Console.WriteLine("Please Create your username:");
            newIdentity.SetUserName((Console.ReadLine()));

           
            
            System.Console.WriteLine("Please create your password:");
            newIdentity.SetPassWord((Console.ReadLine()));

            listOfIdentity[Identity.GetCount()] = newIdentity;

            Identity.IncIdentityCount();

            SaveID();
        }

       public void SignInIdentity()  // this is to sign into previously existing usrnme and pswrd
        {
            System.Console.WriteLine("Please enter your username:");
            string username = Console.ReadLine();

            System.Console.WriteLine("Please enter your password:");
            string password = Console.ReadLine();

            bool found = false;
            foreach (Identity identity in listOfIdentity) // honestly not super sure what is going on here found this on stackoverflow/ foreeach thing is pretty cool though
            {
                if (identity != null && identity.GetUserName() == username && identity.GetPassWord() == password)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                System.Console.WriteLine("Sign-in successful.");
            }
            else
            {
                System.Console.WriteLine("Incorrect username or password.");
            }

        }


        private void SaveID()  // this method is to save id to the file
        {
            StreamWriter outFile = new StreamWriter("identity.txt"); 

            for(int i = 0; i < Identity.GetCount(); i++)
            {
                outFile.WriteLine(listOfIdentity[i].ToFile());
            }
            
            outFile.Close();
        }
    }
}