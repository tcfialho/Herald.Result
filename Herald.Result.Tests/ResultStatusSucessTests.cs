
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
        }

        [Fact]
        public void ShouldReturnValue()
        {
            //Arrange
            var obj = new object();

            //Act
            var result = ResultStatus.Sucess(obj);

            //Assert
            Assert.Equal(Status.Sucess, result.Status);
            Assert.Equal(obj, result.Data);
        }
    }
}
