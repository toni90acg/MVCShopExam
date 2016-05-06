using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfServiceShop;
using System.Collections.Generic;
using Domain;
using Infraestructure;

namespace ProjectTest
{
    [TestClass]
    public class WCFServiceIntegrationTest
    {
        ProductService _productService;
        int CONSTANT = 1;

        [TestInitialize]
        public void Setup()
        {
           IDbBase dbbase = new UsersContext();
           RepositoryProduct repository = new RepositoryProduct(dbbase);
            _productService = new ProductService(repository);

            using (var ctx = new UsersContext())
            {
                if (ctx.Database.Exists())
                    ctx.Database.Delete();
                ctx.Database.Create();
            }

        }

        [TestMethod]
        public void TestProductServiceGet()
        {

             using (var ctx = new UsersContext())
            {
                ctx.Products.Add(new Product() { Id=1 , Name="Pera" , Price=Convert.ToDecimal(3.45)});
                ctx.SaveChanges();
            }

            var result = _productService.GetAll();

            Assert.AreEqual(CONSTANT, result);
        }
    }
}
