namespace Configuration_Of_Computer
{
    internal class PowerSupply
    {
        public PowerSupply(string name, string model)
        {
            Name = name;
            Model = model;
        }

        public string Name { get; set; }

        public string Model { get; set; }
    }
}
