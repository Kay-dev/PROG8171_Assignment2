using PROG8171_Assignment2;
namespace Products.nUnitTests
{
    public class TestProductId 
    {
        private Product _product {  get; set; }

        [SetUp]
        public void Setup()
        {
            _product = new Product(1, "iPod", 2000.99, 200);
        }

        [TestCase(1)]
        [TestCase(5000)]
        [TestCase(10000)]
        public void ProductId_Test(int id)
        {
            _product.ProductID = id;
            Assert.That(_product.ProductID, Is.EqualTo(id));
        }

        [TestCase("")]
        [TestCase("123")]
        [TestCase("ab34lf")]
        public void ProductName_Test(string name)
        {
            _product.ProductName = name;
            Assert.That(_product.ProductName, Is.EqualTo(name));
        }   

        [TestCase(1)]
        [TestCase(2500.5)]
        [TestCase(5000)]
        public void Price_Test(double price)
        {
            _product.Price = price;
            Assert.That(_product.Price, Is.EqualTo(price));
        }

        [TestCase(1)]
        [TestCase(50000)]
        [TestCase(100000)]
        public void Stock_Test(int stock)
        {
            _product.Stock = stock;
            Assert.That(_product.Stock, Is.EqualTo(stock));
        }

        [TestCase(1)]
        [TestCase(10)]
        [TestCase(100)]
        public void IncreaseStock_Test(int stock)
        {
            int origin = _product.Stock;
            _product.IncreaseStock(stock);
            Assert.That(_product.Stock, Is.EqualTo(origin + stock));
        }

        [TestCase(1)]
        [TestCase(10)]
        [TestCase(100)]
        public void DecreaseStock_Test(int stock)
        {
            int origin = 200;
            _product.Stock = origin;
            _product.DecreaseStock(stock);
            Assert.That(_product.Stock, Is.EqualTo(origin - stock));
        }
    }
}