using System.Net;
using System.Net.Sockets;

Console.Write("Введите ip: ");
var ip = IPAddress.Parse(Console.ReadLine()!);

var endpoint = new IPEndPoint(ip, 5555);
var receiverClient = new UdpClient(endpoint);

var data = receiverClient.Receive(ref endpoint);

int sentPackets = 0;
int receivedPackets = 256;

for (int i = 0; i < data.Length; i++)
{
    sentPackets++;
}

Console.WriteLine($"Потеряно пакетов: {receivedPackets}");