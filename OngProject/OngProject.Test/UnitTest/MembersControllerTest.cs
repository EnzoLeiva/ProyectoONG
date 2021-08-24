using Microsoft.VisualStudio.TestTools.UnitTesting;
using OngProject.Controllers;
using OngProject.Core.DTOs;
using OngProject.Core.Interfaces;
using OngProject.Core.Interfaces.IServices.AWS;
using OngProject.Core.Interfaces.IServices.IUriPaginationService;
using OngProject.Core.Interfaces.IUnitOfWork;
using OngProject.Core.Services;
using OngProject.Core.Services.AWS;
using OngProject.Core.Services.UriPagination;
using OngProject.Infrastructure;
using OngProject.Infrastructure.Data;
using OngProject.Test.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OngProject.Test.UnitTest
{
    [TestClass]
    public class MembersControllerTest : BaseTests
    {
        //setting the enviroment
        private readonly ApplicationDbContext _context;
        private readonly MemberController membersController; 
        
        public MembersControllerTests()
        {
            _context = MakeContext("TestsDB");
            IUnitOfWork unitofWork = new UnitOfWork(_context);
            IImagenService imageService = new ImageService ();
            IUriPaginationService uriService = new UriPaginationService("test/");

            IMemberService memberService = new MemberService(unitofWork, imageService, uriService);
            membersController = new MemberController(memberService);
        }
        [TestMethod]
        public async Task Post_ShouldCreateMember_ReturnOkResult()
        {
            //Arrange
            var memberCreateDto = new MemberCreateDto() {
               Name = "testName1",
               FacebookUrl = "testfacebook1",
               InstagramUrl = "testinstagram1",
               LinkedinUrl = "testlinkedin1",
               Image = null,
               Description = "testdescription1"
        };
            //Act
            var actionResult = await membersController.Post(memberCreateDto);

            //Assert
            var expectedActionResult = Created();
            Assert.AreEqual()
        }
}
