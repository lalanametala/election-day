namespace election_day
{
    public class Program
    {
        public static void Main()
        {
            var ballotBox  = new BallotBox();          

            int countVoters = ballotBox.GetCountVoters(); 
            if(countVoters > 0)
            {
                Console.WriteLine("Número de eleitores informado " + countVoters);
               
                ballotBox.Start(countVoters);
        
                ballotBox.PrintResult();                   
            }
        }
    }
}