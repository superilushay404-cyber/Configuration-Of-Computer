namespace Configuration_Of_Computer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>();
            List<Motherboard> motherboards = new List<Motherboard>();
            List<Ram> rams = new List<Ram>();
            List<Processor> processors = new List<Processor>();
            List<GraphicsCard> graphicsCards = new List<GraphicsCard>();
            List<PowerSupply> powerSupplies = new List<PowerSupply>();
        }

        static void SeedData(
            List<Computer> computers,
            List<Motherboard> motherboards,
            List<Ram> rams,
            List<Processor> processors,
            List<GraphicsCard> graphicsCards,
            List<PowerSupply> powerSupplies)
        {
            motherboards.Add(new Motherboard("Asus", "ROG STRIX B550-F GAMING"));
            motherboards.Add(new Motherboard("MSI", "B450 TOMAHAWK MAX"));
            motherboards.Add(new Motherboard("Gigabyte", "Z390 AORUS PRO WIFI"));
            rams.Add(new Ram("Corsair", "Vengeance LPX 16GB (2 x 8GB) DDR4-3200"));
            rams.Add(new Ram("G.Skill", "Trident Z RGB 16GB (2 x 8GB) DDR4-3600"));
            rams.Add(new Ram("Kingston", "HyperX Fury 16GB (2 x 8GB) DDR4-2666"));
            processors.Add(new Processor("Intel", "Core i7-9700K"));
            processors.Add(new Processor("AMD", "Ryzen 5 3600X"));
            processors.Add(new Processor("Intel", "Core i9-10900K"));
            graphicsCards.Add(new GraphicsCard("NVIDIA", "GeForce RTX 3080"));
            graphicsCards.Add(new GraphicsCard("AMD", "Radeon RX 6800 XT"));
            graphicsCards.Add(new GraphicsCard("NVIDIA", "GeForce GTX 1660 Super"));
            powerSupplies.Add(new PowerSupply("Corsair", "RM850x 850W 80+ Gold"));
            powerSupplies.Add(new PowerSupply("EVGA", "SuperNOVA 750 G5 750W 80+ Gold"));
            powerSupplies.Add(new PowerSupply("Seasonic", "Focus GX-650 650W 80+ Gold"));
        }
    }
}
