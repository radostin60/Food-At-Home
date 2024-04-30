using Food_At_Home.Contracts;
using Food_At_Home.Data;
using Food_At_Home.Data.Models;
using Food_At_Home.Models.Dish;
using Food_At_Home.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class DishServiceTests
    {
        private IImageService imageService;
        private IHttpContextAccessor accessor;
        private IDishService dishService;



        private Mock<IImageService> _imageServiceMock;
        private Mock<FoodDbContext> _contextMock;
        private Guid dishId = Guid.NewGuid();

        [SetUp]
        public void Setup()
        {
            _imageServiceMock = new Mock<IImageService>();
            _contextMock = new Mock<FoodDbContext>();
        }

        [Test]
        public async Task AddDish_WithValidModel_AddsDishToContext()
        {
            // Arrange
            var dishFormModel = new DishFormModel
            {

            };

            var dishService = new DishService(_contextMock.Object, _imageServiceMock.Object, accessor);

            // Act
            await dishService.AddDish(Guid.NewGuid(), dishFormModel);

            // Assert
            _contextMock.Verify(mock => mock.Dishes.Add(It.IsAny<Dish>()), Times.Once);
            //_contextMock.Verify(mock => mock.SaveChangesAsync(), Times.Once);
        }

        [Test]
        public async Task AddDish_WithImageUrl_UploadsImage()
        {
            // Arrange
            var dishFormModel = new DishFormModel
            {

            };

            _imageServiceMock.Setup(mock => mock.UploadImage(It.IsAny<IFormFile>(), It.IsAny<string>(), It.IsAny<Dish>()))
                .ReturnsAsync("uploaded_image_url");

            var dishService = new DishService(_contextMock.Object, _imageServiceMock.Object, accessor);

            // Act
            await dishService.AddDish(Guid.NewGuid(), dishFormModel);

            // Assert
            _imageServiceMock.Verify(mock => mock.UploadImage(It.IsAny<IFormFile>(), It.IsAny<string>(), It.IsAny<Dish>()), Times.Once);
            _contextMock.Verify(mock => mock.Dishes.Add(It.IsAny<Dish>()), Times.Once);
            //_contextMock.Verify(mock => mock.SaveChangesAsync(), Times.Once);

        }


        [Test]
        public async Task Delete_DishExists_RemovesDishFromContext()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<FoodDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            // Create some test data
            using (var context = new FoodDbContext(options))
            {
                var dishId = Guid.NewGuid();
                context.Dishes.Add(new Dish { Id = dishId });
                await context.SaveChangesAsync();
            }

            // Act
            using (var context = new FoodDbContext(options))
            {
                var dishService = new DishService(context, null, accessor); 
                await dishService.Delete(dishId);
            }

            // Assert
            using (var context = new FoodDbContext(options))
            {
                var deletedDish = await context.Dishes.FindAsync(dishId);
                Assert.IsNull(deletedDish);
            }


        }







    }

        

}



