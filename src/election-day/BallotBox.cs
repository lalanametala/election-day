namespace election_day
{
    public class BallotBox
    {
        private int receivedOption1;
        private int receivedOption2;
        private int receivedOption3;
        private int optionNull;
        private int voters;
        
        public int GetCountVoters()
        {            
            bool isParsed;

            do
            {
                Console.Write("Insert a valid number of voters:");
                string? readVoters = Console.ReadLine();
                isParsed = int.TryParse(readVoters, out voters);
            } while (!isParsed && voters <= 0);

           return voters;
        }

        public void Start(int countVoters)
        {
           throw new NotImplementedException();
        }

        public void PrintResult()
        {
           throw new NotImplementedException();
        }
    }
}
