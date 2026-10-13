namespace Configuration_Of_Computer
{
    internal class PowerSupply
    {
        public PowerSupply(string name, string model, int price, int id, float limitOfPower)
        {
            Name = name;
            Model = model;
            Price = price;
            Id = id;
            LimitOfPower = limitOfPower;
        }

        public int Id { get; set; }

        public float LimitOfPower { get; set; }

        public string Name { get; set; }

        public string Model { get; set; }

        public int Price { get; set; }
    }
}
