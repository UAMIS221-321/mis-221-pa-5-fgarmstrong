namespace mis_221_pa_5_fgarmstrong
{
    public class Trainer
    {
        // these are our trainer instance variables
        private int trainerID;
        private string trainerName;
        private string trainerMailingAddress;
        private string trainerEmailAddress;

       // these are the class variables
        static private int count;
        private bool deleted;

        //this is going to be a the arg constructor
        public Trainer(string trainerName, int trainerID, string trainerEmailAddress, string trainerMailingAddress, bool deleted)
        {
            this.trainerName = trainerName;
            this.trainerID = trainerID;
            this.trainerEmailAddress = trainerEmailAddress;
            this.trainerMailingAddress = trainerMailingAddress;
            // count++;
            this.trainerID = count;
            this.deleted = deleted;
        }

        // this is going to tbe the no arg constructor
        public Trainer()
        {  // no return type, same name as the class
            
        }
       // private string trainerName; ????
       

        
         public int GetTrainerID()
        {
            return trainerID;
        }
        public void SetTrainerID()
        {
           // Trainer.IncCount();
            this.trainerID = count;
        }

        public string GetTrainerName()
        {
            return trainerName;
        }
        public void SetTrainerName(string trainerName)
        {
            this.trainerName = trainerName;
        }

        public string GetTrainerMailingAddress()
        {
          return trainerMailingAddress;
        }
         public void SetTrainerMailingAddress(string trainerMailingAddress)
        {
          this.trainerMailingAddress = trainerMailingAddress;
        }

        public string GetTrainerEmailAddress()
        {
            return trainerEmailAddress;
        }
         public void SetTrainerEmailAddress(string trainerEmailAddress)
        {
            this.trainerEmailAddress = trainerEmailAddress;
        }

        static public void SetCount(int count)
        {
            Trainer.count = count;
        }

        static public int GetCount() // class method
        {
            return count;
        }

        static public void IncCount() 
        {
            count++;
        }

        public bool GetDelete()
        {
            return deleted;
        }
        
        public void SetDelete(bool deleted)
        {
            this.deleted = deleted;
        }


       public override string ToString() {
            return $"{trainerName}'s trainer ID is {trainerID}, their mailing address is {trainerMailingAddress} and their email address is {trainerEmailAddress}";
        
        }

        public string ToFile() {
            return $"{trainerName}#{trainerID}#{trainerEmailAddress}#{trainerMailingAddress}#{deleted}";
        
        }

        
    }
}