using Epsilon.DotNet.PmsApp.Repository;
using Epsilon.DotNet.PmsApp.Entities;

namespace Epsilon.DotNet.PmsApp.RepositoryTests
{
    [TestClass]
    public sealed class ProductDaoTests
    {
        private ProductDao productDao;

        //one time initialization before all the test cases
        //[ClassInitialize]
        //public void SetUp()
        //{
        //    productDao = new ProductDao();
        //}
        //one time clean up after all the test cases
        //[ClassCleanup]
        //public void TearDown()
        //{
        //    productDao = null;
        //}

        //this method will be invoked before every test case method is run
        [TestInitialize]
        public void Initialize()
        {
            //arrange
            productDao = new ProductDao();
        }

        //this method will be invoked adter every test case method is completed
        [TestCleanup]
        public void Cleanup() 
        {
            productDao = null;
        }


        [TestMethod]
        public void GetAllPositiveTest()
        {
            //arrange            
            List<Product> expectedList = [
               new Product 
               { 
                   ProductId=100, 
                   ProductName="dell xps", 
                   ProductDescription="new laptop from dell", 
                   Price=120000.00M
               },
               new Product
               { 
                   ProductDescription="new laptop from hp", 
                   ProductName="hp probook", 
                   ProductId=101, 
                   Price=110000.00M
               }];

            //act
            List<Product> actualList = productDao.GetAll();

            //assert            
            CollectionAssert.AreEqual(expectedList, actualList);
        }
        
        [TestMethod]
        public void GetPositiveTest()
        {
            //arrange            
            Product expectedProduct = new Product
            {
                ProductDescription = "new laptop from hp",
                ProductName = "hp probook",
                ProductId = 101,
                Price = 110000.00M
            };

            //act
            Product actualProduct = productDao.Get(101);

            //assert
            Assert.AreEqual(expectedProduct, actualProduct);
            //expectedProduct.Equals(actualproduct);
        }
    }
}
