using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfServiceShop;
using Domain;
using NMock;

namespace ProjectUnitaryTest.cs
{
    [TestClass]
    public class WCFServiceUnitaryTest
    {
        private MockFactory _factory = new MockFactory();

        [TestCleanup]
        public void Cleanup()
        {
            _factory.VerifyAllExpectationsHaveBeenMet();
            _factory.ClearExpectations();
        }

        [TestMethod]
        public void TestRepositoryProductGetAll()
        {
            //Assert
            var service = _factory.CreateMock<IProductService>();
            var repository = _factory.CreateMock<IRepositoryProduct>();

            // create a list of categories to return
            var products = new[] { new Product { Id = 1, Name = "Pera" , Price=Convert.ToDecimal(3.45)} };

            // tell the mock that when FindAll is called,
            // return the list of categories
            //repository.Setup(cr => cr.FindAll()).Returns(products);
            service.Expects.One.Method(c => c.GetAll()).WillReturn(products);


            // pass the mocked instance, not the mock itself, to the category
            // controller using the Object property

            // Act
            //TODO!!

            // Assert
            //TODO!!
            //var listCategories = Assert.IsAssignableFrom<IEnumerable<Category>>(result.ViewData.Model);
            //Assert.AreEqual(1, listCategories.Count());
        }
    }
}
