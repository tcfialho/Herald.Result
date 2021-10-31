using System;
using System.Collections.Generic;
using System.Text;

using Xunit;

using Herald.Result.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Herald.Result.Tests
{
    public class ToActionResultTests
    {
        [Fact]
        public async Task ShouldConvertToActionResult()
        {
            //Arrange
            var result = Task.FromResult(ResultStatus.Sucess());

            //Act
            var actionResult = await result.ToActionResult();

            //Assert
            Assert.IsAssignableFrom<IActionResult>(actionResult);
        }

        [Fact]
        public async Task ShouldConvertToActionResultOfType()
        {
            //Arrange
            var obj = new object();
            var result = Task.FromResult(ResultStatus.Sucess(obj));

            //Act
            var actionResult = await result.ToActionResult();

            //Assert
            Assert.IsAssignableFrom<IActionResult>(actionResult);
        }
    }
}
