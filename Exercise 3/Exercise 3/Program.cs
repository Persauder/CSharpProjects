using System;

namespace HouseholdItemsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Household Items Drawing Program");
            Console.WriteLine("Select an item to draw:");
            Console.WriteLine("1. Chair\n2. Table\n3. Lamp");
            Console.Write("Enter your choice (1-3): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Chair chair = CreateChair();
                    chair.ShowInfo();
                    chair.Draw();
                    break;
                case "2":
                    Table table = CreateTable();
                    table.ShowInfo();
                    table.Draw();
                    break;
                case "3":
                    Lamp lamp = CreateLamp();
                    lamp.ShowInfo();
                    lamp.Draw();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        static Chair CreateChair()
        {
            Console.WriteLine("\nCreating a Chair...");
            Console.Write("Enter Height (cm): ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Enter Material: ");
            string material = Console.ReadLine();

            Console.Write("Enter Color: ");
            string color = Console.ReadLine();

            return new Chair(height, material, color);
        }

        static Table CreateTable()
        {
            Console.WriteLine("\nCreating a Table...");
            Console.Write("Enter Length (cm): ");
            int length = int.Parse(Console.ReadLine());

            Console.Write("Enter Width (cm): ");
            int width = int.Parse(Console.ReadLine());

            Console.Write("Enter Material: ");
            string material = Console.ReadLine();

            return new Table(length, width, material);
        }

        static Lamp CreateLamp()
        {
            Console.WriteLine("\nCreating a Lamp...");
            Console.Write("Enter Brightness (lm): ");
            int brightness = int.Parse(Console.ReadLine());

            Console.Write("Enter Color: ");
            string color = Console.ReadLine();

            Console.Write("Enter Style: ");
            string style = Console.ReadLine();

            return new Lamp(brightness, color, style);
        }
    }

    class Chair
    {
        public int Height { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }

        public Chair(int height, string material, string color)
        {
            Height = height;
            Material = material;
            Color = color;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a Chair:");
            Console.WriteLine("    ______ ");
            Console.WriteLine("   |      |");
            Console.WriteLine("   |______|");
            Console.WriteLine("      ||   ");
            Console.WriteLine("      ||   ");
            Console.WriteLine("     /  \\ ");
            Console.WriteLine("    /____\\ ");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"\nChair Info:\nHeight: {Height} cm\nMaterial: {Material}\nColor: {Color}\n");
        }
    }

    class Table
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public string Material { get; set; }

        public Table(int length, int width, string material)
        {
            Length = length;
            Width = width;
            Material = material;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a Table:");
            Console.WriteLine(" ________ ");
            Console.WriteLine("|        |");
            Console.WriteLine("|        |");
            Console.WriteLine("|________|");
            Console.WriteLine("    ||    ");
            Console.WriteLine("    ||    ");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"\nTable Info:\nLength: {Length} cm\nWidth: {Width} cm\nMaterial: {Material}\n");
        }
    }

    class Lamp
    {
        public int Brightness { get; set; }
        public string Color { get; set; }
        public string Style { get; set; }

        public Lamp(int brightness, string color, string style)
        {
            Brightness = brightness;
            Color = color;
            Style = style;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a Lamp:");
            Console.WriteLine("      *****      ");
            Console.WriteLine("     *     *     ");
            Console.WriteLine("    *       *    ");
            Console.WriteLine("   *         *   ");
            Console.WriteLine("    *       *    ");
            Console.WriteLine("     *     *     ");
            Console.WriteLine("      *****      ");
            Console.WriteLine("        |        ");
            Console.WriteLine("        |        ");
            Console.WriteLine("       / \\       ");
            Console.WriteLine("      /   \\      ");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"\nLamp Info:\nBrightness: {Brightness} lm\nColor: {Color}\nStyle: {Style}\n");
        }
    }
}
