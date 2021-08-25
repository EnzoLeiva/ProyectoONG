using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OngProject.Controllers;
using OngProject.Core.DTOs;
using OngProject.Core.Interfaces;
using OngProject.Core.Interfaces.IServices.AWS;
using OngProject.Core.Interfaces.IServices.IUriPaginationService;
using OngProject.Core.Interfaces.IUnitOfWork;
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
using System.Threading.Tasks;

namespace OngProject.Test.UnitTest
{
    [TestClass]
    public class MembersControllerTest : BaseTests
    {
        //setting the enviroment
        private ApplicationDbContext _context;
        private MemberController membersController;

        [TestInitialize]
        public void Init()
        {
            _context = MakeContext("TestsDB");
            IUnitOfWork unitofWork = new UnitOfWork(_context);
            IImagenService imageService = new ImageService();
            IUriPaginationService uriPaginationService = new UriPaginationService("test/");

            IMemberService membersService = new MemberService(unitofWork, imageService, uriPaginationService);
            membersController = new MemberController(membersService);


        }
        [TestCleanup]
        public void Cleanup()
        {
            _context.Database.EnsureDeleted();
        }

        [TestMethod]
        public async Task Post_ShouldCreateMember_ReturnCreatedResult()
        {
            //Arrange
            Cleanup();
            Init();
            var stream = File.OpenRead(@"C:\Users\chiar\OneDrive\Escritorio\t58-project\OngProject\OngProject.Test\UnitTest\Arcade.png");
            var file = new FormFile(stream, 0, stream.Length, null, Path.GetFileName(stream.Name))
            {
                Headers = new HeaderDictionary(),
                ContentType = "image/png"
            };

            var memberCreateDto = new MemberCreateDto()
            {
                Name = "testName1",
                FacebookUrl = "testfacebook1",
                InstagramUrl = "testinstagram1",
                LinkedinUrl = "testlinkedin1",
                Image = file,
                Description = "testdescription1"
            };

            var actionResult = await membersController.Post(memberCreateDto);
            var objResult = _context.Members.Count();

            //Assert 
            Assert.AreEqual(typeof(CreatedAtActionResult), actionResult.GetType());
            Assert.AreEqual(1, objResult);            
        }
        
        [TestMethod]
        public async Task Put_ShouldModifyMember_ReturnOKResult()
        {
            //Arrange
            Cleanup();
            Init();
            var stream = File.OpenRead(@"C:\Users\chiar\OneDrive\Escritorio\t58-project\OngProject\OngProject.Test\UnitTest\Arcade.png");
            var file = new FormFile(stream, 0, stream.Length, null, Path.GetFileName(stream.Name))
            {
                Headers = new HeaderDictionary(),
                ContentType = "image/png"
            };

            var memberCreateDto = new MemberCreateDto()
            {
                Name = "testName1",
                FacebookUrl = "testfacebook1",
                InstagramUrl = "testinstagram1",
                LinkedinUrl = "testlinkedin1",
                Image = file,
                Description = "testdescription1"
            };

            await membersController.Post(memberCreateDto);

            var memberUpdateDto = new MemberUpdateDto() {
                Name = "testModified2",
                Description = "testDescription2"
            };
            //Act
            
            var actionResult = await membersController.Put(1,memberUpdateDto);
            var objResult = _context.Members.Count();

            //Assert     

            Assert.AreEqual(typeof(OkObjectResult), actionResult.GetType()); 
            Assert.AreEqual(1, objResult);
        }
        
        [TestMethod]
        public async Task Put_ShouldntAcceptInexistentId_ReturnNotFoundResult()
        {
            //Arrange
            Cleanup();
            Init();
            var memberUpdateDto = new MemberUpdateDto()
            {
                Name = "testModified2",
                Description = "testDescription2"
            };

            //Act
            var actionResult = await membersController.Put(1, memberUpdateDto);
            var objResult = _context.Members.Count();

            Console.WriteLine(actionResult + " " + objResult);
            //Assert
            Assert.AreEqual(typeof(NotFoundObjectResult), actionResult.GetType());
            Assert.AreEqual(0, objResult);
        }

        [TestMethod]
        public async Task Delete__ShouldDeleteExistentMember_ReturnOkResult()
        {
            //Arrange
            Cleanup();
            Init();
            var stream = File.OpenRead(@"C:\Users\chiar\OneDrive\Escritorio\t58-project\OngProject\OngProject.Test\UnitTest\Arcade.png");
            var file = new FormFile(stream, 0, stream.Length, null, Path.GetFileName(stream.Name))
            {
                Headers = new HeaderDictionary(),
                ContentType = "image/png"
            };

            var memberCreateDto = new MemberCreateDto()
            {
                Name = "testName1",
                FacebookUrl = "testfacebook1",
                InstagramUrl = "testinstagram1",
                LinkedinUrl = "testlinkedin1",
                Image = file,
                Description = "testdescription1"
            };

            await membersController.Post(memberCreateDto);
            var objResultBefore = _context.Members.Count();
            var softDelBefore = _context.Members.Find(1).IsDeleted;
            //Act
            var actionResult = await membersController.Delete(1);
            var objResultAfter = _context.Members.Count();
            var softDelAfter = _context.Members.Find(1).IsDeleted;

            //Assert
            Assert.AreEqual(typeof(OkResult), actionResult.GetType());
            Assert.AreEqual(objResultBefore,objResultAfter);
            Assert.AreNotEqual(softDelBefore, softDelAfter);
        }

        [TestMethod]
        public async Task Delete__ShouldntDeleteInexistentMember_ReturnNotFoundResult()
        {
            //Arrange
            Cleanup();
            Init();
            var stream = File.OpenRead(@"C:\Users\chiar\OneDrive\Escritorio\t58-project\OngProject\OngProject.Test\UnitTest\Arcade.png");
            var file = new FormFile(stream, 0, stream.Length, null, Path.GetFileName(stream.Name))
            {
                Headers = new HeaderDictionary(),
                ContentType = "image/png"
            };

            var memberCreateDto = new MemberCreateDto()
            {
                Name = "testName1",
                FacebookUrl = "testfacebook1",
                InstagramUrl = "testinstagram1",
                LinkedinUrl = "testlinkedin1",
                Image = file,
                Description = "testdescription1"
            };

            await membersController.Post(memberCreateDto);

            //Act
            var actionResult = await membersController.Delete(2);
            var objResult = _context.Members.Count();
            var softDelete = _context.Members.Find(2);

            //Assert
            Assert.AreEqual(typeof(NotFoundResult), actionResult.GetType());
            Assert.AreEqual(1, objResult);
        }
    }
}
