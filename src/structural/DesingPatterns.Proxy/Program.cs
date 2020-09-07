using DesignPatterns.Proxy;
using DesignPatterns.Proxy.Core;
using System;

namespace DesingPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            Console.WriteLine("Client: Executing the client code with a real gold price:");
            RealActualPrices realGoldPrice = new RealActualPrices();
            client.ClientCode(realGoldPrice);

            Console.WriteLine();

            Console.WriteLine("Client: Executing the same client code with a proxy:");
            var proxy = new ProxyActualPrices(realGoldPrice);
            client.ClientCode(proxy);
        }
    }
}
