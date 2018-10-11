namespace PCS1MockExam
{
    class BirdWatcher
    {
        private string name;
        private int record;
        private string[] birds;
        private int nrOfBirds;
        private int maxBirds;

        public BirdWatcher(string name, int record, int maxBirds)
        {
            this.name = name;
            this.record = record;
            this.maxBirds = maxBirds;
            this.birds = new string[maxBirds];
            this.nrOfBirds = 0;
        }
        public string GetName()
        {
            return name;
        }
        public int getNrOfBirds()
        {
            return nrOfBirds;
        }
        public string GetBird(int index)
        {
            return birds[index];
        }
        public string GetInfo()
        {
            return $"The record for {name} is {record} birds";
        }
        public string GetSpottedBirds()
        {
            return $"{name} has spotted {nrOfBirds} birds";
        }
        public void AddBird(string newBird)
        {
            if (nrOfBirds < maxBirds)
            {
                birds[nrOfBirds] = newBird;
                nrOfBirds++;
            }
            if (nrOfBirds > record)
            {
                record = nrOfBirds;
            }
        }
        public string GetLastBird()
        {
            return GetBird(nrOfBirds-1);
        }
        public int GetMaxBirds()
        {
            return maxBirds;
        }
        public int GetBirdCountByName(string name)
        {
            int count = 0;
            for (int i = 0; i < nrOfBirds; i++)
            {
                if (birds[i] == name)
                {
                    count++;
                }
            }
            return count;
        }
        public int GetUniqueSpecies()
        {
            string[] uniqueSpecies = new string[birds.Length];
            int count = 0;
            foreach(string bird in birds)
            {
                bool hasSpecies = false;
                foreach(string uniquespecie in uniqueSpecies)
                {
                    if (uniquespecie == bird)
                    {
                        hasSpecies = true;
                    }
                }
                if (!hasSpecies)
                {
                    uniqueSpecies[count] = bird;
                    count++;
                }

            }
            return count;
        }
    }
}
