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
            var obj = new object();

            //Act
            var result = (Sucess<object>)ResultStatus.Sucess(obj);

            //Assert
            Assert.True(result.HasValue());
            Assert.Equal(obj, result.GetValue());
            Assert.Equal(obj, result.Value);
            Assert.Equal(Status.Sucess, result.Status);
        }
    }
}
