namespace Scheduling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Eksempel på oprettelse og brug af en PCB
            PCB process1 = new PCB("A", 2, ProcessStateType.Ready);
            Console.WriteLine(process1);
            Console.ReadLine();
        }
    }
}
