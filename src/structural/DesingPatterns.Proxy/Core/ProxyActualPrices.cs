using System;

namespace DesignPatterns.Proxy.Core
{
    // The Proxy has an interface identical to the RealActualPrices.
    internal class ProxyActualPrices : IActualPrices
    {
        private readonly IActualPrices _realActualPrices; 

        public ProxyActualPrices(IActualPrices realActualPrices)
        {
            _realActualPrices = realActualPrices;
        }

        // The most common applications of the Proxy pattern are lazy loading,
        // caching, controlling the access, logging, etc. A Proxy can perform
        // one of these things and then, depending on the result, pass the
        // execution to the same method in a linked RealActualPrices object.
        public void RequestGoldPrice()
        {
            if (this.CheckAccess())
            {
                this._realActualPrices.RequestGoldPrice();
                
                this.LogAccess();
            }
        }

        private bool CheckAccess()
        {
            // Some real checks should go here.
            Console.WriteLine("Proxy: Checking access prior to firing a real request.");

            return true;
        }

        private void LogAccess()
        {
            Console.WriteLine("Proxy: Logging the time of request.");

        }
    }
}
