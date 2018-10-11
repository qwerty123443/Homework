namespace _6._2._4_Lottery
{
    class Lottery
    {
        private int maxValue;
        private int nrOfWantedNumbers;
        private int nrOfDrawnNumbers;
        private int[] drawnNumbers;

        public Lottery(int maxValue, int nrOfWantedNumbers)
        {
            this.maxValue = maxValue;
            this.nrOfWantedNumbers = nrOfWantedNumbers;
        }
        public void Draw1Number()
        {

        }
        public void DrawAllNumbers()
        {

        }
        public int GetLastDrawnNumber()
        {
            return drawnNumbers[nrOfDrawnNumbers];
        }
        public int getNumber(int i)
        {

        }
        public void SortNumbers()
        {
            //Sort(drawnNumbers);
        }
        public bool AllNumbersAreDrawn()
        {
            return nrOfDrawnNumbers == drawnNumbers.Length;
        }
    }
}
