// <copyright file="IHandler`1.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DesignPattern.ChainOfResponsibility.Core
{
    /// <summary>
    /// The IChainHandler interface specifies the methods and properties
    /// to be implemented by concrete Handlers.
    /// </summary>
    /// <typeparam name="TResponse">Type of handler's response object.</typeparam>
    public interface IHandler<TResponse>
    {
        /// <summary>
        /// The IChainHandler interface specifies the methods and properties
        /// to be implemented by concrete Handlers.
        /// </summary>
        /// <returns>Execution result.</returns>
        TResponse Execute();
    }
}
