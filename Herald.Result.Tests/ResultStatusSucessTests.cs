using System;

using Microsoft.AspNetCore.Mvc;

using Xunit;

namespace Herald.Result.Tests
{
    public class ResultStatusSucessTests
    {
        [Fact]
        public void ShouldCreate()
        {
            //Arrange

            //Act
            var result = ResultStatus.Sucess();

            //Assert
            Assert.Equal(Status.Sucess, result.Status);
            Assert.IsType<Sucess>(result);
        }

        [Fact]
        public void ShouldReturnValue()
        {
            //Arrange
            var obj = new { Teste = "test" };

            //Act
            var result = ResultStatus.Sucess(obj);

            //Assert
            Assert.True(result.HasValue());
            Assert.Equal(obj, result.GetValue());            
        }
    }
}
