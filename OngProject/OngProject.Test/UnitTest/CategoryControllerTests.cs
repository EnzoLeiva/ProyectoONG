using Microsoft.AspNetCore.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OngProject.Controllers;
using OngProject.Core.DTOs;
using OngProject.Core.Interfaces.IUnitOfWork;
using OngProject.Core.Mapper;
using OngProject.Core.Models;
using OngProject.Core.Services;
using OngProject.Core.Services.AWS;
using OngProject.Core.Services.UriPagination;
using OngProject.Infrastructure;
using OngProject.Infrastructure.Data;
using OngProject.Test.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OngProject.Test.UnitTest
{
    [TestClass]
    public class CategoryControllerTests: BaseTests
    {
        private readonly ApplicationDbContext _context;
        private readonly CategoryController categoryController;
    
        public CategoryControllerTests()
        {
            _context = MakeContext("testDb");
            IUnitOfWork unitOfWork = new UnitOfWork(_context);
            ImageService image = new ImageService();
            UriPaginationService pagination = new UriPaginationService(null);
            CategoryService service = new CategoryService(unitOfWork, image, pagination);
            categoryController = new CategoryController(service);
        }

        [TestMethod]
        public async Task Post_Should_Create_Category_And_Return_Ok()
        {
            // Arrange
            var categoryTest = new CategoryCreateDto() { 
                Name = "Tests", 
                Description = "this is a category insertion test", 
                Image = null 
            };

            // Act
            var actionResult = await categoryController.Post(categoryTest);

            // Assert
            //TODO
        }

        [TestMethod]
        public async Task GetById_Should_Return_category_FromTheDb()
        {
            // Arrange
            var categoryTest = new CategoryModel()
            {
                Name = "Category 1",
                Description = "this is a category insertion test",
                Image = null
            };

            _context.Categories.Add(categoryTest);
            await _context.SaveChangesAsync();

            // Act
            var category = _context.Categories.Single();
            var actionResult = await categoryController.GetById(category.Id);

            // Assert
            Assert.IsNotNull(actionResult);

            var CodeStatus = actionResult.GetType().GetProperty("StatusCode")?.GetValue(actionResult);
            Assert.AreEqual(200, CodeStatus);

            var value = actionResult.GetType().GetProperty("Value")?.GetValue(actionResult);
            var categoryResponse =  value as CategoryModel;

            Assert.AreEqual(category.Name, categoryResponse.Name);
        }

        [TestMethod]
        public async Task GetById_Should_Return_404_If_Not_Exist_InTheBD()
        {
            // Act

            var actionResult = await categoryController.GetById(1);

            var CodeStatus = actionResult.GetType().GetProperty("StatusCode")?.GetValue(actionResult);

            // Assert
            Assert.AreEqual(404, CodeStatus);

        }

        [TestMethod]
        public async Task Delete_Category_That_Should_Exist_InTheDb()
        {

            // Arrange
            var categoryTest = new CategoryModel()
            {
                Name = "Tests",
                Description = "this is a category insertion test",
                Image = null
            };

            _context.Categories.Add(categoryTest);
            await _context.SaveChangesAsync();

            // Act
            var category = _context.Categories.Single();
            var actionResult = await categoryController.Delete(category.Id);

            var CodeStatus = actionResult.GetType().GetProperty("StatusCode")?.GetValue(actionResult);

            // Assert
            Assert.AreEqual(200, CodeStatus);

            Assert.AreEqual(true, category.IsDeleted);

        }

        [TestMethod]
        public async Task Delete_Category_Should_Return_404_If_Not_Exist_InTheBD()
        {
            // Act

            var actionResult = await categoryController.Delete(1);

            var CodeStatus = actionResult.GetType().GetProperty("StatusCode")?.GetValue(actionResult);

            // Assert
            Assert.AreEqual(404, CodeStatus);

        }
    }

}
