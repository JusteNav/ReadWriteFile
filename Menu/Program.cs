namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Food.LoadMenu();

            Console.WriteLine($"Last menu item: {Food.BreakfastMenu.Last().Name}");

            var applePie = new Food
            {
                Name = "Apple Pie",
                Price = "$4.00",
                Description = "A delicious slice of our homemade pie, served with vanilla ice cream and local berries",
                Calories = 600,
            };

            Food.AddToMenu(applePie);
            Console.WriteLine($"Last menu item after update: {Food.BreakfastMenu.Last().Name}");
        }
    }
}