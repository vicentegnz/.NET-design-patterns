// <copyright file="IChainContext`1.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DesignPattern.ChainOfResponsibility.Core
{
    /// <summary>
    /// The IChainContext interface defines a context abstraction to be used within ChainHandlers <see cref="IChainHandler{TRequest, TResponse}"/>
    /// to manage the chain context.
    /// </summary>
    /// <typeparam name="TRequest">Type of request parameter.</typeparam>
    public interface IChainContext<TRequest>
    {
    }
}
