// <copyright file="IPurchaseHandler`2.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace DesignPattern.ChainOfResponsibility.Core
{
    /// <summary>
    /// The IPurchaseHandler interface specifies the methods and properties
    /// to be implemented by concrete discount handlers for building the chain
    /// of handlers.
    /// </summary>
    /// <typeparam name="TRequest">Type of request parameter.</typeparam>
    /// <typeparam name="TResponse">Type of handler's response object.</typeparam>
    public interface IPurchaseHandler<TRequest, TResponse> : IHandler<TResponse>
    {
        /// <summary>
        /// Gets the IPurchaseHandler Context.
        /// </summary>
        IPurchaseContext<TRequest> Context { get; }
    }
}
