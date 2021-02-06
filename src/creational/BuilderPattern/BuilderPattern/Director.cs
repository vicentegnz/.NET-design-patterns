// <copyright file="Director.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BuilderPattern
{
    /// <summary>
    /// The director class.
    /// </summary>
    internal class Director
    {
        private IObjectBuilder builder;

        /// <summary>
        /// Sets the builder object.
        /// </summary>
        public IObjectBuilder Builder
        {
            set { this.builder = value; }
        }

        /// <summary>
        /// The Director can construct several product variations using the same
        /// building steps. In this case we will build the minimum product.
        /// </summary>
        public void BuildMinimalViableProduct()
        {
            this.builder.BuildPartA();
        }

        /// <summary>
        /// The Director can construct several product variations using the same
        /// building steps. In this case we will build the minimum product.
        /// </summary>
        public void BuildFullFeaturedProduct()
        {
            this.builder.BuildPartA();
            this.builder.BuildPartB();
            this.builder.BuildPartC();
        }
    }
}
