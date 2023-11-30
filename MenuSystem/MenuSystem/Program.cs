namespace MenuSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu mainMenu = new Menu();


            mainMenu.Title = "Min fantastiske menu";
            mainMenu.MenuItems = new MenuItem[10];

            // First menu item
            MenuItem mi = new MenuItem();
            mi.Title = "1. Gør dit";
            mainMenu.MenuItems[0] = mi;
            mainMenu.ItemCount++; // Increment with one; same as: ItemCount = ItemCount + 1

            // Second menu item
            mi = new MenuItem();
            mi.Title = "2. Gør dat";
            mainMenu.MenuItems[1] = mi;
            mainMenu.ItemCount++;

            // Third menu item
            mi = new MenuItem();
            mi.Title = "3. Gør noget";
            mainMenu.MenuItems[2] = mi;
            mainMenu.ItemCount++;

            // Last menu item
            mi = new MenuItem();
            mi.Title = "4. Få svaret på livet, universet og alting";
            mainMenu.MenuItems[3] = mi;
            mainMenu.ItemCount++;

            mainMenu.Show();

            Console.ReadLine();

        }
    }
}