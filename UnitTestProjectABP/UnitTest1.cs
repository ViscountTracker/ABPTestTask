using ABPTestTask.Controllers;
using Moq;

namespace UnitTestProjectABP
{
    [TestClass]
    public class ExperimentServiceTests
    {
        [TestMethod]
        public void GetExperiment_Should_Return_Expected_Experiment()
        {
            //Arrange
            var repositoryMock = new Mock<IExperimentRepository>();
            repositoryMock.Setup(repo => repo.GetExperiment(It.IsAny<string>()))
                .Returns(new Experiment { Key = "button_color", Value = "#FF0000" });

            var service = new ExperimentService(repositoryMock.Object);

            //Act
            var experiment = service.GetExperiment("randomstring1");

            //Assert
            Assert.AreEqual("button_color", experiment.Key);
            Assert.AreEqual("#FF0000", experiment.Value);
        }
    }
}