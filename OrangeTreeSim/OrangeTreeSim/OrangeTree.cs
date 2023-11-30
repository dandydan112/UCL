using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OrangeTreeSim
{
    public class OrangeTree
    {
        private int age;
        public int Age { get; set; }
        private int height;
        public int Height { get; set; }
        private bool treeAlive;
        public bool TreeAlive { get; set; }
        private int numOranges;
        public int NumOranges
        {
            get { return NumOranges - Count; }

        }
        private int orangesEaten;
        public int OrangesEaten
        {
            get { return Count; }
        }
        private int eatOrange;
        public void int EatOrange
        {
            set { EatOrange = EatOrange; }
        }

        public int Count;
        public void OneYearPasses()
        {
            if (TreeAlive == true)
            {
                Count = 0;
                Age++;
                if (Age < 80) { Height += 2; }
                if (Age > 1 && Age < 80)
                {
                    NumOranges = (Age - 1) * 5;
                }
                if (Age >= 80) { TreeAlive = false; }

            }
            else if (TreeAlive == false)
            {
                NumOranges = 0;
                Age++;
                Count = 0;
            }

        }


    }

}
