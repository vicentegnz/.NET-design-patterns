// <copyright file="BuilderTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DesignPattern.Builder.Tests
{
    using FluentAssertions;
    using Xunit;

    /// <summary>
    /// The builder test class.
    /// </summary>
    public class BuilderTests
    {
        /// <summary>
        /// Builder pattern test.
        /// </summary>
        [Fact]
        public void BuilderPatternOk()
        {
            // The client code creates a builder object, passes it to the
            // director and then initiates the construction process. The end
            // result is retrieved from the builder object.
            var director = new Director();
            var builder = new ConcreteObjectBuilder();
            director.Builder = builder;

            // Standard basic product
            director.BuildMinimalViableProduct();
            Product minimalProduct = builder.GetProduct();
            minimalProduct.Should().BeEquivalentTo(MinimalViableProductExpected());

            // Standard full featured product
            director.BuildFullFeaturedProduct();
            Product fullProduct = builder.GetProduct();
            fullProduct.Should().BeEquivalentTo(FullProductExpected());

            // Remember, the Builder pattern can be used without a Director
            // class.

            // Custom product
            string[] expectedParts = { "PartA1", "PartC1" };
            builder.BuildPartA();
            builder.BuildPartC();
            Product customProduct = builder.GetProduct();

            customProduct.Should().BeEquivalentTo(CustomProductExpected(expectedParts));
        }

        private static Product MinimalViableProductExpected()
        {
            var product = new Product();
            product.Add("PartA1");
            return product;
        }

        private static Product FullProductExpected()
        {
            var product = new Product();
            product.Add("PartA1");
            product.Add("PartB1");
            product.Add("PartC1");

            return product;
        }

        private static Product CustomProductExpected(string[] parts)
        {
            var product = new Product();
            for (int i = 0; i < parts.Length; i++)
            {
                product.Add(parts[i]);
            }

            return product;
        }
    }
}
