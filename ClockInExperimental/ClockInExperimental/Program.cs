using System;

namespace ClockInExperimental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AttendanceRecord[] attendanceRecords = new AttendanceRecord[10];
            int currentIndex = 0;
            bool isClockedIn = false;

            while (true)
            {
                Console.WriteLine("Options:");
                Console.WriteLine("1. Clock In");
                Console.WriteLine("2. Clock Out");
                Console.WriteLine("3. Show Attendance Records");
                Console.WriteLine("4. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        if (!isClockedIn)
                        {
                            if (currentIndex < attendanceRecords.Length)
                            {
                                Console.Write("Enter your name: ");
                                string name = Console.ReadLine();
                                AttendanceRecord record = new AttendanceRecord(name, DateTime.Now, true);
                                attendanceRecords[currentIndex] = record;
                                currentIndex++;
                                isClockedIn = true;
                                Console.WriteLine($"{name} Clocked In at {record.TimeStamp.ToString()}");
                            }
                            else
                            {
                                Console.WriteLine("Attendance record storage is full.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("You are already clocked in.");
                        }
                        break;

                    case 2:
                        if (isClockedIn)
                        {
                            if (currentIndex < attendanceRecords.Length)
                            {
                                Console.Write("Enter your name: ");
                                string name = Console.ReadLine();
                                AttendanceRecord record = new AttendanceRecord(name, DateTime.Now, false);
                                attendanceRecords[currentIndex] = record;
                                currentIndex++;
                                isClockedIn = false;
                                Console.WriteLine($"{name} Clocked Out at {record.TimeStamp.ToString()}");
                            }
                            else
                            {
                                Console.WriteLine("Attendance record storage is full.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("You are not clocked in.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Attendance Records:");
                        for (int i = 0; i < currentIndex; i++)
                        {
                            var record = attendanceRecords[i];
                            Console.WriteLine($"{record.Name} - {record.TimeStamp} - {(record.IsClockIn ? "Clock In" : "Clock Out")}");
                        }
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option.");
                        break;
                }
            }
        }
    }

    class AttendanceRecord
    {
        public string Name { get; }
        public DateTime TimeStamp { get; }
        public bool IsClockIn { get; }

        public AttendanceRecord(string name, DateTime timeStamp, bool isClockIn)
        {
            Name = name;
            TimeStamp = timeStamp;
            IsClockIn = isClockIn;
        }
    }
}