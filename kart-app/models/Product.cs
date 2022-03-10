using kart_app.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kart_app.models
{
    public class Product : IProduct
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal? MetricWeight { get; set; }
        public int? Quantity { get; set; }
    }
}
