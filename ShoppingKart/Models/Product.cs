using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingKart.Models
{
    public class Product
    {
        public int id;
        public string itemCode;
        public double price;
        public int discountQty;
        public double discountPrice;

        public Product(int id, string item, double price)
        {
            this.id = id;
            this.itemCode = item;
            this.price = price;
            this.discountQty = 0;
            this.discountPrice = 0.0;
        }

        public Product(int id, string product, double price, int discountQty, double discountPrice)
        {
            this.id = id;
            this.itemCode = product;
            this.price = price;
            this.discountQty = discountQty;
            this.discountPrice = discountPrice;
        }

    }
}
