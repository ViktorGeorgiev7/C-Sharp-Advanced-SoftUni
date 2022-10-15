namespace ShoppingSpree
{
    public class Product
    {
        private string name;
        private int cost;

        public Product(string name,int cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                name = value;
            }         
        }

        public int Cost
        {
            get
            {
                return cost;
            }
            private set
            {
                cost = value;
            }
        }
    }
}
