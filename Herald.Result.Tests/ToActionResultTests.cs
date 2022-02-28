using System;
using System.Collections.Generic;
using System.Text;

using Xunit;

using Herald.Result.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Herald.Result.Tests
{
    public class ToActionResultTests
    {
        [Fact]
        public async Task ShouldConvertToOk()
        {
            //Arrange
            var result = Task.FromResult(ResultStatus.Sucess());

            //Act
            var actionResult = await result.ToActionResult();

            //Assert
            Assert.IsAssignableFrom<IActionResult>(actionResult);
            Assert.IsType<ObjectResult>(actionResult);
            Assert.Equal((int)HttpStatusCode.OK, ((ObjectResult)actionResult).StatusCode);
        }

        [Fact]
        public async Task ShouldConvertToBadRequest()
        {
            //Arrange
            var result = Task.FromResult(ResultStatus.Fail("Fail"));

            //Act
            var actionResult = await result.ToActionResult();

            //Assert
            Assert.IsAssignableFrom<IActionResult>(actionResult);
            Assert.IsType<ObjectResult>(actionResult);
            Assert.Equal((int)HttpStatusCode.BadRequest, ((ObjectResult)actionResult).StatusCode);
        }

        [Fact]
        public async Task ShouldConvertToNotFound()
        {
            //Arrange
            var result = Task.FromResult(ResultStatus.NotFound("NotFound"));

            //Act
            var actionResult = await result.ToActionResult();

            //Assert
            Assert.IsAssignableFrom<IActionResult>(actionResult);
            Assert.IsType<NotFoundObjectResult>(actionResult);
        }

        [Fact]
        public async Task ShouldConvertResultOfTypeToOk()
        {
            //Arrange
            var obj = new object();
            var result = Task.FromResult(ResultStatus.Sucess(obj));

            //Act
            var actionResult = await result.ToActionResult();

            //Assert
            Assert.IsAssignableFrom<IActionResult>(actionResult);
            Assert.IsType<ObjectResult>(actionResult);
            Assert.Equal((int)HttpStatusCode.OK, ((ObjectResult)actionResult).StatusCode);
        }
    }
}
