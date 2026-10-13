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
            SeedData(computers, motherboards, rams, processors, graphicsCards, powerSupplies);

            bool isProgramNeedsToRun = true;

            while (isProgramNeedsToRun)
            {
                PrintInfo();
                bool isUserInputParseSuccess = int.TryParse(Console.ReadLine(), out int userInput);

                if (isUserInputParseSuccess)
                {
                    if (userInput == 1)
                    {
                        Console.WriteLine("Enter 1 to see motherboards, 2 to see rams, 3 to see processors, 4 to see graphics cards or 5 to see power supplies");
                        bool isUserChoiceParseSuccess = int.TryParse(Console.ReadLine(), out int userChoice);

                        if (isUserChoiceParseSuccess)
                        {
                            if (userChoice == 1)
                            {
                                for (int i = 0; i < motherboards.Count; i++)
                                {
                                    Console.WriteLine($"Motherboard: {motherboards[i].Name} {motherboards[i].Model} {motherboards[i].Id}");
                                }
                            }
                            else if (userChoice == 2)
                            {
                                for (int i = 0; i < rams.Count; i++)
                                {
                                    Console.WriteLine($"Ram: {rams[i].Name} {rams[i].Model} {rams[i].Id}");
                                }
                            }
                            else if (userChoice == 3)
                            {
                                for (int i = 0; i < processors.Count; i++)
                                {
                                    Console.WriteLine($"Processor: {processors[i].Name} {processors[i].Model} {processors[i].Id}");
                                }
                            }
                            else if (userChoice == 4)
                            {
                                for (int i = 0; i < graphicsCards.Count; i++)
                                {
                                    Console.WriteLine($"Graphics card: {graphicsCards[i].Name} {graphicsCards[i].Model} {graphicsCards[i].Id}");
                                }
                            }
                            else if (userChoice == 5)
                            {
                                for (int i = 0; i < powerSupplies.Count; i++)
                                {
                                    Console.WriteLine($"Power supplie: {powerSupplies[i].Name} {powerSupplies[i].Model} {powerSupplies[i].Id}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Wrong input");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong input");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong input");
                    }
                }
            }
        }

        static void SeedData(
            List<Computer> computers,
            List<Motherboard> motherboards,
            List<Ram> rams,
            List<Processor> processors,
            List<GraphicsCard> graphicsCards,
            List<PowerSupply> powerSupplies)
        {
            computers.Add(new Computer(0));
            motherboards.Add(new Motherboard("Asus", "ROG STRIX B550-F GAMING", 500, 1));
            motherboards.Add(new Motherboard("MSI", "B450 TOMAHAWK MAX", 450, 2));
            motherboards.Add(new Motherboard("Gigabyte", "Z390 AORUS PRO WIFI", 500, 3));
            rams.Add(new Ram("Corsair", "Vengeance LPX 16GB (2 x 8GB) DDR4-3200", 650, 1));
            rams.Add(new Ram("G.Skill", "Trident Z RGB 16GB (2 x 8GB) DDR4-3600", 715, 2));
            rams.Add(new Ram("Kingston", "HyperX Fury 16GB (2 x 8GB) DDR4-2666", 800, 3));
            processors.Add(new Processor("Intel", "Core i7-9700K", 250, 1));
            processors.Add(new Processor("AMD", "Ryzen 5 3600X", 100, 2));
            processors.Add(new Processor("Intel", "Core i9-10900K", 750, 3));
            graphicsCards.Add(new GraphicsCard("NVIDIA", "GeForce RTX 3080", 600, 1));
            graphicsCards.Add(new GraphicsCard("AMD", "Radeon RX 6800 XT", 750, 2));
            graphicsCards.Add(new GraphicsCard("NVIDIA", "GeForce GTX 1660 Super", 700, 3));
            powerSupplies.Add(new PowerSupply("Corsair", "RM850x 850W 80+ Gold", 700, 1));
            powerSupplies.Add(new PowerSupply("EVGA", "SuperNOVA 750 G5 750W 80+ Gold", 500, 2));
            powerSupplies.Add(new PowerSupply("Seasonic", "Focus GX-650 650W 80+ Gold", 400, 3));
        }

        static void PrintInfo()
        {
            Console.WriteLine("Enter 1 to see catalog of motherboards, rams, processors, graphicsCards and powerSupplies");
            Console.WriteLine("Enter 2 to choose components for building your own pc");
        }

        static Motherboard GetMotherboardById(List<Motherboard> motherboards, int id)
        {
            foreach (var motherboard in motherboards)
            {
                if (motherboard.Id == id)
                {
                    return motherboard;
                }
            }
            return null;
        }

        static Ram GetRamById(List<Ram> rams, int id)
        {
            foreach (var ram in rams)
            {
                if (ram.Id == id)
                {
                    return ram;
                }
            }
            return null;
        }

        static Processor GetProcessorById(List<Processor> processors, int id)
        {
            foreach (var processor in processors)
            {
                if (processor.Id == id)
                {
                    return processor;
                }
            }
            return null;
        }

        static GraphicsCard GetGraphicsCardById(List<GraphicsCard> graphicsCards, int id)
        {
            foreach (var graphicsCard in graphicsCards)
            {
                if (graphicsCard.Id == id)
                {
                    return graphicsCard;
                }
            }
            return null;
        }

        static PowerSupply GetPowerSupplyById(List<PowerSupply> powerSupplies, int id)
        {
            foreach (var powerSupply in powerSupplies)
            {
                if (powerSupply.Id == id)
                {
                    return powerSupply;
                }
            }
            return null;
        }
    }
}