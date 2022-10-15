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
           for (int count = 0; count < countVoters; count++)
           {
                Console.WriteLine("Insert a vote:");
                int readVote;
                bool isParsed = int.TryParse(Console.ReadLine().ToString(), out readVote);
                if(isParsed) {
                    switch (readVote)
                    {
                        case 1:
                            receivedOption1++;
                            break;
                        case 2:
                            receivedOption2++;
                            break;
                        case 3:
                            receivedOption3++;
                            break;
                        default:
                            optionNull++;
                            break;
                    }
                }
           }
        }

        public void PrintResult()
        {
           int[] allVotes = {receivedOption1, receivedOption2, receivedOption3, optionNull};

           for (int index = 0; index < allVotes.Length; index++)
           {
                if(index < allVotes.Length - 1) Console.WriteLine("A opção" +(index + 1)+" recebeu: "+allVotes[index]+" voto(s)");
                else Console.WriteLine("Total de votos anulados: "+allVotes[index]+" voto(s)");
           }
        }
    }
}
