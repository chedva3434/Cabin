using ManagementCabin;
using ManagementCabin.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uniTest
{
    public class UsersController
    {
        private readonly CastomerController _context;

        public UsersController()
        {
            FakeContext context = new FakeContext();
            _context = new CastomerController(context);
        }

        [Fact]
        public void GetReturn_All()
        {
            //Arrange

            //Act
            var controller = _context;
            var result = controller.Get();

            //Assert
            Assert.IsType<List<Castomer>>(result);
        }

        [Fact]
        public void GetAll_ReturnsCount()
        {
            //act
            var controller = _context;
            var result = controller.Get();
            //assert
            Assert.IsType<List<Castomer>>(result);
        }


        [Fact]
        public void GetById_ReturnsOk()
        {
            //Arrange
            var id = 1;

            //Act
            var controller = _context;
            var result = controller.Get(id);

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetById_ReturnsNotFound()
        {
            //Arrange
            var id = 4;

            //Act
            var controller = _context;
            var result = controller.Get(id);

            //Assert
            Assert.IsType<NotFoundResult>(result);
        }




    }
}
