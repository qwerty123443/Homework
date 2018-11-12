namespace BowlingApp
{
    class Player
    {
        private string name;
        private int personalBest;
        private int[] scores;
        private int nrOfScores;
        private bool isHuman;

        private int scoreCount = 0;

        public Player(string name, int personalBest, int nrOfRounds)
        {
            this.name = name;
            this.personalBest = personalBest;
            this.nrOfScores = nrOfRounds;
            scores = new int[nrOfRounds];
            isHuman = true;
        }

        public Player(int nrOfRounds)
        {
            this.nrOfScores = nrOfRounds;
            scores = new int[nrOfRounds];
            isHuman = false;
            name = "Computer";
            personalBest = nrOfRounds * 5;
        }
        public int getMaxNrOfRounds()
        {
            return nrOfScores;
        }
        public string GetName()
        {
            return name;
        }
        public int GetPersonalBest()
        {
            return personalBest;
        }

        public int[] GetScores()
        {
            return scores;
        }

        public bool GetIsHuman()
        {
            return isHuman;
        }

        public void AddScore(int score)
        {
            if (scoreCount == nrOfScores)
                return;
            scores[scoreCount++] = score;
        }

        public string GetInfo()
        {
            return isHuman ? $"{name} (Personal best: {personalBest})" : name;
        }

        public int GetTotalScore()
        {
            int total = 0;
            foreach(int score in scores)
            {
                total += score;
            }
            return total;
        }

    }
}
