namespace mis_221_pa_5_fgarmstrong
{
    public class TrainerUtility

    {
        private Trainer[] listOfTrainer;
        public TrainerUtility(Trainer[] listOfTrainer)
        {
            this.listOfTrainer = listOfTrainer;
            GetAllTrainersFromFile();
        }

        
        public void GetAllTrainersFromFile()
        {
            // open trainers file
        StreamReader inFile = new StreamReader("trainers.txt");// open file
        //process file
        Trainer.SetCount(0);
        string line = inFile.ReadLine();
        while (line != null && line != "")
        {
             
            string[] temp = line.Split('#');
            listOfTrainer[Trainer.GetCount()] = new Trainer(temp[0], int.Parse(temp[1]), (temp[2]), temp[3], bool.Parse(temp[4]));
            Trainer.IncCount();
            line = inFile.ReadLine();
            
        }

        inFile.Close();
    }

    public void AddTrainerData() // this method is to add trainers to the trainers file
    {
    Trainer newTrainer = new Trainer();
    System.Console.WriteLine("Please enter the trainers name:");
    newTrainer.SetTrainerName((Console.ReadLine()));

    newTrainer.SetTrainerID();
    
    System.Console.WriteLine("Please enter trainers email:");
    newTrainer.SetTrainerEmailAddress((Console.ReadLine()));

    System.Console.WriteLine("Please enter trainers mailing address:");
    int count = Trainer.GetCount();
    newTrainer.SetTrainerMailingAddress((Console.ReadLine()));
    System.Console.WriteLine(Trainer.GetCount());
    listOfTrainer[Trainer.GetCount()] = newTrainer;
    Trainer.IncCount();
    
    Save();
    }

    public void EditTrainerData()  /// this method is to edit trainers previously added tot he trainers file
    {
       System.Console.WriteLine("Whats the trainer ID of the trainer you would like to update");
            int searchVal = int.Parse(Console.ReadLine()); //mightve blown up around here
            int foundIndex = Find(searchVal);
            if(foundIndex != -1)
            {
                System.Console.WriteLine("Please enter the trainer name:");
                listOfTrainer[foundIndex].SetTrainerName(Console.ReadLine());
            
                System.Console.WriteLine("Please enter the trainer's email:");
                listOfTrainer[foundIndex].SetTrainerEmailAddress(Console.ReadLine());
            
                System.Console.WriteLine("Please enter the trainer's mailing address:");
                listOfTrainer[foundIndex].SetTrainerMailingAddress((Console.ReadLine()));

                Save();
            } 
            else
            {
                System.Console.WriteLine("trainer not found :(");
            }
    }

    public void DeleteTrainer()
    {
        System.Console.WriteLine("Please enter the ID of the trainer you would like to delete:");
        int searchVal = int.Parse(Console.ReadLine());
        int foundIndex = Find(searchVal);
            if(foundIndex != -1)
            {
                listOfTrainer[foundIndex].SetDelete(true);
            }
        Save();
        
    }

      private void Save()  // this method is to save trainers to the file
        {
            StreamWriter outFile = new StreamWriter("trainers.txt"); 

            // for(int i = 0; i < Trainer.GetCount(); i++)
            // {
            //     outFile.WriteLine(listOfTrainer[i].ToFile());
            // }
            for(int i = 0; i < Trainer.GetCount(); i++)
            {
                outFile.WriteLine(listOfTrainer[i].ToFile());
            }
            
            outFile.Close();

        } 

        

         public int Find(int searchVal)
        {
            for(int i = 0; i < Trainer.GetCount(); i++)
            {
                if(listOfTrainer[i].GetTrainerID() == searchVal)
                {
                    return i;
                }
            }
            return -1;
        }

    
    }
}