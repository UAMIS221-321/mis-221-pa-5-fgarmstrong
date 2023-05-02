namespace mis_221_pa_5_fgarmstrong
{
    public class Identity
    {
           // these are our identity instance variables
        
        private string userName;
        private string passWord;

        static private int count;

       // these are the class variables

        //this is going to be a the arg constructor
        public Identity (string userName, string passWord)
        {
            this.userName = userName;
            this.passWord = passWord;
         }

        // this is going to tbe the no arg constructor
        public Identity()
        {  // no return type, same name as the class
            
        }

         public string GetUserName()
        {
          return userName;
        }
         public void SetUserName(string userName)
        {
          this.userName = userName;
        }

        public string GetPassWord()
        {
            return passWord;
        }
         public void SetPassWord(string passWord)
        {
            this.passWord = passWord;
        }


        static public void SetCount(int count)
        {
            Identity.count = count;
        }

        static public int GetCount() // class method
        {
            return count;
        }

         static public void IncIdentityCount() 
        {
            count++;
        }


        public string ToFile() {
            return $"{userName}#{passWord}";
        
        }
    }
}