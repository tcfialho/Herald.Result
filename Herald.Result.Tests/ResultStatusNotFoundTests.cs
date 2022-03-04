
using Xunit;

namespace Herald.Result.Tests
{
    public class ResultStatusNotFoundTests
    {
        [Fact]
        public void ShouldCreate()
        {
            //Arrange

            //Act
            var result = ResultStatus.NotFound();

            //Assert
            Assert.Equal(Status.NotFound, result.Status);
        }

        [Fact]
        public void ShouldReturnValue()
        {
            //Arrange
            var obj = "test";

            //Act
            var result = ResultStatus.NotFound(obj);

            //Assert
            Assert.Equal(Status.NotFound, result.Status);
            Assert.Equal(obj, result.Message);
        }
    }
}
