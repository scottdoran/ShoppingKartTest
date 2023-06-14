namespace ShoppingKart.Tests
{
    public class ShoppingKartScenarios
    {
        [Fact]
        public void WithOneDiscount()
        {
            //Arrange
            Checkout checkout = new Checkout();
            var expectedPrice = 13;

            //Act
            checkout.ScanItem("A");
            checkout.ScanItem("A");
            checkout.ScanItem("A");
            var actualPrice = checkout.TotalBasket();

            //Assert
            Assert.Equal(expectedPrice, actualPrice);
        }

        [Fact]
        public void WithTwoDiscounts()
        {
            //Arrange
            Checkout checkout = new Checkout();
            var expectedPrice = 17.50;

            //Act
            checkout.ScanItem("A");
            checkout.ScanItem("A");
            checkout.ScanItem("A");
            checkout.ScanItem("B");
            checkout.ScanItem("B");
            var actualPrice = checkout.TotalBasket();

            //Assert
            Assert.Equal(expectedPrice, actualPrice);
        }

        [Fact]
        public void DistinctItemWithAndWithoutDiscounts()
        {
            //Arrange
            Checkout checkout = new Checkout();
            var expectedPrice = 23;

            //Act
            checkout.ScanItem("A");
            checkout.ScanItem("A");
            checkout.ScanItem("A");
            checkout.ScanItem("A");
            checkout.ScanItem("A");
            var actualPrice = checkout.TotalBasket();

            //Assert
            Assert.Equal(expectedPrice, actualPrice);
        }

        [Fact]
        public void VariousItemsWithAndWithoutDiscounts()
        {
            //Arrange
            Checkout checkout = new Checkout();
            var expectedPrice = 22.50;

            //Act
            checkout.ScanItem("A");
            checkout.ScanItem("A");
            checkout.ScanItem("A");
            checkout.ScanItem("A");
            checkout.ScanItem("B");
            checkout.ScanItem("D");
            var actualPrice = checkout.TotalBasket();

            //Assert
            Assert.Equal(expectedPrice, actualPrice);
        }
    }
}