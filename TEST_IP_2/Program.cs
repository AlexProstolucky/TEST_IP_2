using System;
using System.Net;
internal class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введіть IP-адресу (IPv4): ");
            string input = Console.ReadLine();

            if (IPAddress.TryParse(input, out IPAddress ipAddress) && ipAddress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
            {
                Console.WriteLine("Введений IP-адрес правильний: " + ipAddress.ToString());

                IPEndPoint endpoint = new IPEndPoint(ipAddress, 80);
                Console.WriteLine("Кінцева точка: " + endpoint.ToString());

                break; 
            }
            else
            {
                Console.WriteLine("Неправильний формат IP-адреси. Введіть її ще раз.");
            }
        }
    }
}