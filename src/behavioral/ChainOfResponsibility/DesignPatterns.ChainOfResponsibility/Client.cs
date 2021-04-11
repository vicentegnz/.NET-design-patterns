// <copyright file="Client.cs" company=".NetDesignPatterns">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace DesignPattern.ChainOfResponsibility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using DesignPattern.ChainOfResponsibility.Core;
    using DesignPattern.ChainOfResponsibility.Implementation;
    using DesignPattern.ChainOfResponsibility.Models;

    /// <summary>
    /// The client class creates the chain of responsibility using the concrete <see cref="DiscountChainHandler"/>
    /// and <see cref="IPurchaseHandler{TRequest, TResponse}"/> implementations.
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        public Client()
        {
        }

        /// <summary>
        /// Client class executes the logic. The client class uses the request to create a purchase context
        /// <see cref="PurchaseContext"/> and defines the chain of responsibility pipeline.
        /// </summary>
        /// <param name="request">Purchase request.</param>
        /// <returns>The price.</returns>
        public PurchaseResponse Execute(PurchaseRequest request)
        {
            IPurchaseHandler<PurchaseRequest, PurchaseResponse> pipeline = this.BuildPurchaseChainOfResponsibility(request);
            PurchaseResponse purchaseResponse = pipeline.Execute();
            return purchaseResponse;
        }

        private IPurchaseHandler<PurchaseRequest, PurchaseResponse> BuildPurchaseChainOfResponsibility(PurchaseRequest request)
        {
            var purchaseContext = new PurchaseContext(request);
            IPurchaseHandler<PurchaseRequest, PurchaseResponse> purchaseChainOfResponsibility = new PurchaseHandler(purchaseContext);

            foreach (var discountHandler in this.DiscountHandlers().Reverse())
            {
                purchaseChainOfResponsibility = discountHandler.SetSucesor(purchaseChainOfResponsibility);
            }

            return purchaseChainOfResponsibility;
        }

        private IEnumerable<DiscountChainHandler> DiscountHandlers()
        {
            yield return new MinorsDiscountHandler();
            yield return new ElderlyDiscountHandler();
        }
    }
}
