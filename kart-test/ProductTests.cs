using kart_app.models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace kart_test
{
    [TestClass]
    public class ProductTests
    {
        private List<Product> _products;

        [TestMethod]
        public void Product()
        {
            var product = new Product()
            {
                Name = "Strawberries",
                Price = 0.99m,
                MetricWeight = null,
                Quantity = 1
            };

        }
    }
}