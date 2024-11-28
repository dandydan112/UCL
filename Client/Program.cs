using System;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    class Client
    {
        static void Main()
        {
            Console.Write("Enter server IP: ");
            string serverIP = Console.ReadLine();
            Console.Write("Enter server port: ");
            int port = int.Parse(Console.ReadLine());

            TcpClient client = new TcpClient(serverIP, port);
            Console.WriteLine("Connected to server.");

            NetworkStream stream = client.GetStream();

            // Send klient-ID
            string clientID = "Client123";
            stream.Write(Encoding.UTF8.GetBytes(clientID));

            // Modtag hilsen fra serveren
            byte[] buffer = new byte[1024];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            string greeting = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            Console.WriteLine($"Server says: {greeting}");

            // Send beskeder til serveren
            while (true)
            {
                Console.Write("Enter message: ");
                string message = Console.ReadLine();

                stream.Write(Encoding.UTF8.GetBytes(message));

                if (message == "STOP")
                {
                    Console.WriteLine("Disconnecting...");
                    break;
                }
            }

            client.Close();
        }
    }
}
