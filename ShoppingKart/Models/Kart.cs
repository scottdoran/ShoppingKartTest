using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingKart.Models
{
    public class Kart
    {
        public List<Product> Products { get; set; }

        public Kart()
        {
            Products = new List<Product>();
        }
    }
}
