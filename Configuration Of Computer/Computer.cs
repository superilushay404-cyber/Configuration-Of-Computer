namespace Configuration_Of_Computer
{
    internal class Computer
    {
        public Computer(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
        public Processor Processor { get; set; }

        public Ram Ram { get; set; }

        public Motherboard Motherboard { get; set; }

        public GraphicsCard GraphicsCard { get; set; }

        public PowerSupply PowerSupply { get; set; }
    }
}
