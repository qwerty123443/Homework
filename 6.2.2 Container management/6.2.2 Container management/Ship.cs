namespace _6._2._2_Container_management
{
    class Ship
    {
        private string name;
        private int maxload;

        public Ship(string name, int maxload)
        {
            this.name = name;
            this.maxload = maxload;
        }
        public int GetMaxLoad()
        {
            return maxload;
        }
    }
}
