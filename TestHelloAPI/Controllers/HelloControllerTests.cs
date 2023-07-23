using HelloAPI.Controllers;
using Microsoft.Extensions.Logging;
using Moq;

namespace TestHelloAPI.Controllers
{
    public class HelloControllerTests
    {
        private Mock<ILogger<HelloController>> _mockLogger;
        private HelloController _controller;
        private string _testMessage;

        [SetUp]
        public void Setup()
        {
            // Mock the logger object for use in the controller
            _mockLogger = new Mock<ILogger<HelloController>>();
            _controller = new HelloController(_mockLogger.Object);

            _testMessage = "Test Message";
        }

        [Test]
        public void Get_ReturnsCorrectString()
        {
            // Act
            string result = _controller.Get(_testMessage);

            // Assert
            Assert.AreEqual($">>{_testMessage}", result);
        }
    }
}