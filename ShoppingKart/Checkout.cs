using ShoppingKart.Models;

namespace ShoppingKart
{
    public class Checkout
    {
        public Kart _kart { get; set; }
        public List<Product> _productList { get; set; }

        public Checkout()
        {
            _productList = new List<Product>();
            _kart = new Kart();

            PopulateProductList();
        }


        public void ScanItem(string product)
        {
            //Find product in product list
            var scannedItem = _productList.First(x => x.itemCode == product);

            _kart.Products.Add(scannedItem);
        }

        public double TotalBasket()
        {
            var basketTotal = 0.0;

            //For each unique item in basket
            foreach (var itemCode in _kart.Products.Select(x => x.itemCode).Distinct())
            {
                //Get total no in basket
                var itemBasketCount = _kart.Products.Where(x => x.itemCode == itemCode).Count();
                var product = _productList.First(x => x.itemCode == itemCode);

                //Divide total by discount qty
                if (product.discountQty > 0 && product.discountPrice > 0)
                {
                    basketTotal += (itemBasketCount / product.discountQty) * product.discountPrice;
                    basketTotal += (itemBasketCount % product.discountQty) * product.price;
                }
                else
                {
                    basketTotal += itemBasketCount * product.price;
                }
            }
            return basketTotal;
        }

        public void PopulateProductList()
        {
            _productList = new List<Product>
            {
                new Product(1, "A", 5, 3, 13.0),
                new Product(1, "B", 3, 2, 4.50),
                new Product(1, "C", 2),
                new Product(1, "D", 1.5),
            };
        }
    }
}
