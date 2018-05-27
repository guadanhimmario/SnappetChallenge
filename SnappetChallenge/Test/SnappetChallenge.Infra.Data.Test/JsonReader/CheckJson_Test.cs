using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SnappetChallenge.Domain.Interfaces.Repository;
using SnappetChallenge.Infra.Data.Context;
using SnappetChallenge.Infra.Data.Repository;
using System.Linq;

namespace SnappetChallenge.Infra.Data.Test
{
    [TestClass]
    public class CheckJson_Test
    {
        [TestMethod]
        public void JsonExist()
        {
            //Arrange
            Mock<SnappetChallengeContext> mockContext = new Mock<SnappetChallengeContext>();

            //Act
            ISubmittedAnswerRepository objSubmittedAnswerRepository = new SubmittedAnswerRepository(mockContext.Object);
            var JsonList = objSubmittedAnswerRepository.GetAllFromJson();

            //Assert
            Assert.IsTrue(JsonList.Any());
        }
    }
}
