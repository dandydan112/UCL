using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class Server
    {
        static void Main()
        {
            int port = 12345; // Hardkodet port
            IPAddress ip = GetIPAddress();

            TcpListener server = new TcpListener(ip, port);
            server.Start();
            Console.WriteLine($"Server listening on {ip}:{port}");

            TcpClient client = server.AcceptTcpClient();
            Console.WriteLine("Client connected.");

            NetworkStream stream = client.GetStream();

            // Modtag klientens ID
            byte[] buffer = new byte[1024];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            string clientID = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            Console.WriteLine($"Received Client ID: {clientID}");

            // Send hilsen til klienten
            string greeting = "Welcome to the server!";
            stream.Write(Encoding.UTF8.GetBytes(greeting));

            // Modtag beskeder fra klienten
            while (true)
            {
                bytesRead = stream.Read(buffer, 0, buffer.Length);
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine($"Received: {message}");

                if (message == "STOP")
                {
                    Console.WriteLine("Stopping server...");
                    break;
                }
            }

            client.Close();
            server.Stop();
        }

        static IPAddress GetIPAddress()
        {
            return IPAddress.Parse("127.0.0.1"); // Hardkodet til lokal host
        }
    }
}
