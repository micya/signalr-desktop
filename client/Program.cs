using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;

namespace client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5000/chat")
                .WithAutomaticReconnect()
                .Build();

            connection.On<string, string>("ReceiveMessage", (user, message) => {
                Console.WriteLine($"{user}: {message}");
            });

            Console.Write("Enter username: ");
            var username = Console.ReadLine();

            Console.WriteLine("Connecting to chat server...");
            await connection.StartAsync();
            Console.WriteLine("Connected to chat server");

            while (true)
            {
                var message = Console.ReadLine();

                if (message.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    break;

                await connection.SendAsync("SendMessage", username, message);
            }

            await connection.DisposeAsync();
        }
    }
}
