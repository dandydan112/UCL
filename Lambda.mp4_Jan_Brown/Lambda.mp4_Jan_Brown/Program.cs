namespace Lambda.mp4_Jan_Brown
{
    internal class Program
    {
        public delegate int MyDelegate(int hour, int minute, int second);
        static void Main(string[] args)
        {

            MyDelegate del;
            MyDelegate del1;

            //del = delegate (int x, int y, int z)
            //{
            //    return x+y+z;
            //};

            del1 = (x, y, z) => x + y + z;    
            int pik = del1(1, 1, 1);


            Console.WriteLine(pik);

            Console.ReadLine();

        }

       
    }
}