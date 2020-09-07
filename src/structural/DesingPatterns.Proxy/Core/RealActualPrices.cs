using System;

namespace DesignPatterns.Proxy.Core
{
    // The RealActualPrices contains some core business logic. Usually, RealActualPrices
    // are capable of doing some useful work which may also be very slow or
    // sensitive - e.g. correcting input data. A Proxy can solve these issues
    // without any changes to the RealActualPrices's code.
    internal class RealActualPrices : IActualPrices
    {
        public void RequestGoldPrice()
        {
            Console.WriteLine("RealGoldPrice: Handling Request.");
        }
    }
}
