// <copyright file="ConcreteObjectBuilder.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DesignPattern.Builder
{
    /// <summary>
    /// The concrete object builder class.
    /// </summary>
    public class ConcreteObjectBuilder : IObjectBuilder
    {
        private Product product = new Product();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteObjectBuilder"/> class.
        /// A fresh builder instance should contain a blank product object, which
        /// is used in further assembly.
        /// </summary>
        public ConcreteObjectBuilder()
        {
            this.Reset();
        }

        /// <inheritdoc/>
        public void BuildPartA()
        {
            this.product.Add("PartA1");
        }

        /// <inheritdoc/>
        public void BuildPartB()
        {
            this.product.Add("PartB1");
        }

        /// <inheritdoc/>
        public void BuildPartC()
        {
            this.product.Add("PartC1");
        }

        /// <summary>
        /// Concrete Builders are supposed to provide their own methods for
        /// retrieving results. That's because various types of builders may
        /// create entirely different products that don't follow the same
        /// interface. Therefore, such methods cannot be declared in the base
        /// Builder interface (at least in a statically typed programming
        /// language).
        ///
        /// Usually, after returning the end result to the client, a builder
        /// instance is expected to be ready to start producing another product.
        /// That's why it's a usual practice to call the reset method at the end
        /// of the `GetProduct` method body. However, this behavior is not
        /// mandatory, and you can make your builders wait for an explicit reset
        /// call from the client code before disposing of the previous result.
        /// </summary>
        /// <returns>The product.</returns>
        public Product GetProduct()
        {
            Product result = this.product;

            this.Reset();

            return result;
        }

        /// <summary>
        /// Reset the object.
        /// </summary>
        public void Reset()
        {
            this.product = new Product();
        }
    }
}
