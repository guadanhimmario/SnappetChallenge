using SimpleInjector;
using SnappetChallenge.Application.Interfaces;
using SnappetChallenge.Application.Services;
using SnappetChallenge.Domain.Interfaces.Repository;
using SnappetChallenge.Domain.Interfaces.Service;
using SnappetChallenge.Domain.Services;
using SnappetChallenge.Infra.Data.Context;
using SnappetChallenge.Infra.Data.Interfaces;
using SnappetChallenge.Infra.Data.Repository;
using SnappetChallenge.Infra.Data.UoW;

namespace SnappetChallenge.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {

            // App
            container.Register<IStudentAnswerReportAppService, StudentAnswerReportAppService>();

            // Domain
            container.Register<ISubmittedAnswerService, SubmittedAnswerService>();

            // Repository
            container.Register<ISubmittedAnswerRepository, SubmittedAnswerRepository>();
            container.Register<IUnitOfWork, UnitOfWork>();
            container.Register<SnappetChallengeContext>();
        }
    }
}
