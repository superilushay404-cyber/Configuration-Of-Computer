namespace Configuration_Of_Computer
{
    internal class Ram
    {
        public Ram(string name, string model, int price, int id, float powerConsumption, int capacity)
        {
            Name = name;
            Model = model;
            Price = price;
            Id = id;
            PowerConsumption = powerConsumption;
            Capacity = capacity;
        }

        public int Id { get; set; }

        public float PowerConsumption { get; set; }

        public int Capacity { get; set; }

        public string Name { get; set; }

        public string Model { get; set; }

        public int Price { get; set; }
    }
}
