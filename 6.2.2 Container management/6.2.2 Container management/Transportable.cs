namespace _6._2._2_Container_management
{
    class Transportable
    {
        private string description;
        private int weight;

        public Transportable(string description, int weight)
        {
            this.description = description;
            this.weight = weight;
        }
        public int getWeight()
        {
            return weight;
        }
        
    }

}
