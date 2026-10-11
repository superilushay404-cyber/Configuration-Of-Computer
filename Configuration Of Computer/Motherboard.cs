namespace Configuration_Of_Computer
{
    internal class Motherboard
    {
        public Motherboard(string name, string model)
        {
            Name = name;
            Model = model;
        }

        public string Name { get; set; }

        public string Model { get; set; }
    }
}
