using System;

using Microsoft.AspNetCore.Mvc;

using Xunit;

namespace Herald.Result.Tests
{
    public class ResultStatusFailTests
    {
        [Fact]
        public void ShouldCreate()
        {
            //Arrange

            //Act
            var result = ResultStatus.Fail();

            //Assert
            Assert.Equal(Status.Fail, result.Status);
            Assert.IsType<Fail>(result);
        }

        [Fact]
        public void ShouldReturnValue()
        {
            //Arrange
            var obj = "test";

            //Act
            var result = ResultStatus.Fail(obj);

            //Assert
            Assert.True(result.HasValue());
            Assert.Equal(obj, result.GetValue());            
        }
    }
}
