namespace _6._2._2_Container_management
{
    class Harbour
    {
        private string name;
        private Ship ship;
        public Harbour(string name)
        {
            this.name = name;
        }
        public int NumberOfTransportablesFitOnShip()
        {
            return ship.GetMaxLoad();
        }
        public void CreateShip(string name, int maxLoad)
        {
            ship = new Ship(name, maxLoad);
        }
    }
}
