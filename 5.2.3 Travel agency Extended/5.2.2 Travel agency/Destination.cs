namespace _5._2._2_Travel_agency
{
    class Destination
    {
        private string destinations;
        private double prices;
        private double profits;
        private int bookcount;
        private int season;

        public Destination(string destinations, double prices, double profits)
        {
            this.destinations = destinations;
            this.prices = prices;
            this.profits = profits;
            this.bookcount = 0;
        }

        public string getDestination()
        {
            return destinations;
        }
        public double getPrice()
        {
            return prices;
        }

        public double getProfit()
        {
            return profits;
        }
        public double getBookCount()
        {
            return bookcount;
        }
        public void book(int bookings, int season)
        {
            bookcount += bookings;
            this.season = season;
        }
    }
}
