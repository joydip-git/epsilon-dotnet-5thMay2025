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

        [TestMethod]
        public void InsertPositiveTest()
        {
            //arrange            
            Product product = new Product
            {
                ProductDescription = "new laptop from lenovo",
                ProductName = "lenovo thinkpad",
                Price = 130000.00M
            };

            //act
            bool actualStatus = productDao.Insert(product);

            //assert
            Assert.AreEqual(true, actualStatus);
        }

        [TestMethod]
        public void UpdatePositiveTest()
        {
            //arrange            
            Product product = new Product
            {
                ProductDescription = "new laptop from lenovo",
                ProductName = "lenovo thinkpad 15inch",
                Price = 140000.00M
            };

            //act
            bool actualStatus = productDao.Update(102, product);

            //assert
            Assert.AreEqual(true, actualStatus);
        }

        [TestMethod]
        //[ExpectedException(typeof(SqlException))]
        public void UpdateNegativeTestWithIncorrectProductId()
        {
            //arrange            
            Product product = new Product
            {
                ProductDescription = "new laptop from lenovo",
                ProductName = "lenovo thinkpad 15inch",
                Price = 140000.00M
            };

            //act
            bool actualStatus = productDao.Update(102, product);

            //assert
            Assert.AreEqual(false, actualStatus);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void UpdateExceptionTestWithIncorrectProductId()
        {
            //arrange            
            Product product = new Product
            {
                ProductDescription = "new laptop from lenovo",
                ProductName = "lenovo thinkpad 15inch",
                Price = 140000.00M
            };

            //act            
            productDao.Update(102, product);
        }

        [TestMethod]
        public void UpdateExceptionMessageTestWithIncorrectProductId()
        {
            //arrange            
            Product product = new Product
            {
                ProductDescription = "new laptop from lenovo",
                ProductName = "lenovo thinkpad 15inch",
                Price = 140000.00M
            };

            //act
            try
            {
                productDao.Update(102, product);
            }
            catch (Exception ex)
            {
                Assert.AreEqual($"the product with id:102 does not exist", ex.Message);
            }
        }

        [TestMethod]
        public void DeletePositiveTest()
        {
            //arrange            

            //act
            bool actualStatus = productDao.Delete(102);

            //assert
            Assert.AreEqual(true, actualStatus);
        }
    }
}
