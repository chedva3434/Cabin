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
        [Fact]
        public void GetReturn_All()
        {
            //Arrange

            //Act
            var controller = new CastomerController();
            var result = controller.Get();

            //Assert
            Assert.IsType<List<Castomer>>(result);
        }

        [Fact]
        public void GetAll_ReturnsCount()
        {
            var controller = new CastomerController();
            var result = controller.Get();

            Assert.Equal(1, result.Count());
        }


        [Fact]
        public void GetById_ReturnsOk()
        {
            //Arrange
            var id = 1;

            //Act
            var controller = new CastomerController();
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
            var controller = new CastomerController();
            var result = controller.Get(id);

            //Assert
            Assert.IsType<NotFoundResult>(result);
        }




    }
}
