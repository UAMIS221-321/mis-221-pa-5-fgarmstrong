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

        public void AddUserIdentity()
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

       public void SignInIdentity()
        {
            System.Console.WriteLine("Please enter your username:");
            string username = Console.ReadLine();

            System.Console.WriteLine("Please enter your password:");
            string password = Console.ReadLine();

            bool found = false;
            foreach (Identity identity in listOfIdentity)
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


        private void SaveID()  // this method is to save trainers to the file
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