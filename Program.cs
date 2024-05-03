using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;

namespace Limiter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Skew SoftWare";
            string host = Dns.GetHostName();
            Console.Write("Приветствую " + host + ", это Skew Soft. Введите Ваш IP Adress: ");
            var ipAddress = Console.ReadLine();
            int timeout = 450; // Таймаут в миллисекундах

            Ping pingSender = new Ping();

            for (; ; )
            {
                PingReply reply = pingSender.Send(ipAddress, timeout);

                if (reply.Status == IPStatus.Success)
                {
                    Console.WriteLine("Пакет отправлен.");
                }
                else
                {
                    Console.WriteLine("Пакет не отправлен. Статус: " + reply.Status);
                }
            }
        }
    }
}
