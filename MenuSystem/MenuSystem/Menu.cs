using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuSystem
{
    internal class Menu
    {
        public string Title;
        public MenuItem[] MenuItems = new MenuItem[3];
        public int ItemCount;

        public void Show ()
        {
            for (int i = 0; i < ItemCount; i++)
            {
                Console.WriteLine();
            }
        }
        





    }
}
