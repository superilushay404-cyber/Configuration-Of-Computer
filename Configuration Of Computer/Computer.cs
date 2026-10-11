namespace Configuration_Of_Computer
{
    internal class Computer
    {
        public Processor Processor { get; set; } = new Processor();

        public Ram Ram { get; set; } = new Ram();

        public Motherboard NaMotherboardme { get; set; } = new Motherboard();

        public GraphicsCard GraphicsCard { get; set; } = new GraphicsCard();

        public PowerSupply PowerSupply { get; set; } = new PowerSupply();


    }
}
