// <copyright file="IChainHandler`2.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DesignPattern.ChainOfResponsibility.Core
{
    /// <summary>
    /// The IChainHandler interface specifies the methods and properties
    /// to be implemented by concrete ChainHandlers.
    /// </summary>
    /// <typeparam name="TRequest">Type of request parameter.</typeparam>
    /// <typeparam name="TResponse">Type of handler's response object.</typeparam>
    public interface IChainHandler<TRequest, TResponse> : IHandler<TResponse>
    {
        /// <summary>
        /// Gets the ChainHandler Context.
        /// </summary>
        IChainContext<TRequest> Context { get; }

        /// <summary>
        /// Sets IChainHandler sucessor.
        /// </summary>
        /// <param name="sucessor">The sucessor IChainHandler to be executed.</param>
        /// <returns>IChainHandler.</returns>
        IChainHandler<TRequest, TResponse> SetSucesor(IChainHandler<TRequest, TResponse> sucessor);
    }
}
