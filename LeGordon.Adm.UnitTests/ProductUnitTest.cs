using LeGordon.Adm.Domain.Entities;
using LeGordon.Adm.Domain.Exceptions;
using Xunit;
using Moq;

namespace LeGordon.Adm.UnitTests
{
    public class ProductUnitTest
    {
        [Fact]
        public void ChangeProductsNameTestSuccess()
        {
            //arrange 
            Mock<Product> mock = new Mock<Product>("Test", "Test", 20.0, 1);
            var productMock = mock.Object;

            //act 
            productMock.ChangeName("Changed");

            //assert
            Assert.Equal("Changed", productMock.Name) ;
        }

        [Fact]
        public void ChangeProductNameError()
        {
            //arrange 
            Mock<Product> mock = new Mock<Product>("Test", "Test", 20.0, 1);
            var productMock = mock.Object;

            //act+assert
            Assert.Throws<ProductDomainException>(() => productMock.ChangeName(""));
        }

        [Fact]
        public void ChangeProductDescriptionSuccess()
        {
            //arrange
            Mock<Product> mock = new Mock<Product>("Test", "Test", 20.0, 1);
            var productMock = mock.Object;

            //act 
            productMock.ChangesDescription("Changed");

            //assert
            Assert.Equal("Changed", productMock.Description);

        }

        [Fact]
        public void ChangeProductError()
        {
            //arrange
            Mock<Product> mock = new Mock<Product>("Test", "Test", 20.0, 1);
            var productMock = mock.Object;

            Assert.Throws<ProductDomainException>(() => productMock.ChangesDescription(""));
        }



    }
}
