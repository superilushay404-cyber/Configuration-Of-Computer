namespace Configuration_Of_Computer
{
    internal class GraphicsCard
    {
        public GraphicsCard(string name, string model)
        {
            Name = name;
            Model = model;
        }

        public string Name { get; set; }

        public string Model { get; set; }
    }
}
