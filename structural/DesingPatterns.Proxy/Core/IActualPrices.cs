namespace DesignPatterns.Proxy.Core
{
    // The ActualPrices interface declares common operations for both RealActualPrices and
    // the ProxyActualPrices. As long as the client works with ActualPrices using this
    // interface, you'll be able to pass it a proxy instead of a real gold price.
    internal interface IActualPrices
    {
        void RequestGoldPrice();
    }
}
