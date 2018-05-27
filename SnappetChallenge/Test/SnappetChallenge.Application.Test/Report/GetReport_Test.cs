using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SnappetChallenge.Application.Interfaces;
using SnappetChallenge.Application.Services;
using SnappetChallenge.Domain.Services;
using SnappetChallenge.Infra.Data.Context;
using SnappetChallenge.Infra.Data.Interfaces;
using SnappetChallenge.Infra.Data.Repository;

namespace SnappetChallenge.Application.Test.Report
{
    [TestClass]
    public class GetReport_Test
    {
        [TestMethod]
        public void GetReportWithRealData_Sucess()
        {
            //Assert
            Mock<IUnitOfWork> uow = new Mock<IUnitOfWork>();
            Mock<SnappetChallengeContext> mockContext = new Mock<SnappetChallengeContext>();

            //Act
            IStudentAnswerReportAppService objStudentAnswerReportAppService = new StudentAnswerReportAppService(
                new SubmittedAnswerService(new SubmittedAnswerRepository(mockContext.Object)),
                uow.Object
               );
            var Report = objStudentAnswerReportAppService.GetReport();

            //Assert
            Assert.IsNotNull(Report);
        }
    }
}
