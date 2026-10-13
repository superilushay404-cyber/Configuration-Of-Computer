namespace Configuration_Of_Computer
{
    internal class Processor
    {
        public Processor(string name, string model, int price, int id, float powerConsumption = 0)
        {
            Name = name;
            Model = model;
            Price = price;
            Id = id;
            PowerConsumption = powerConsumption;
        }

        public int Id { get; set; }

        public float PowerConsumption { get; set; }

        public string Name { get; set; }

        public string Model { get; set; }

        public int Price { get; set; }
    }
}
