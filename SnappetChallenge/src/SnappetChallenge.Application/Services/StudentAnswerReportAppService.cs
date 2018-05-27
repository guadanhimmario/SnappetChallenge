using Nelibur.ObjectMapper;
using SnappetChallenge.Application.Interfaces;
using SnappetChallenge.Application.ViewModels;
using SnappetChallenge.Domain.Interfaces.Service;
using SnappetChallenge.Infra.Data.Interfaces;
using System.Collections.Generic;

namespace SnappetChallenge.Application.Services
{
    public class StudentAnswerReportAppService : ApplicationService, IStudentAnswerReportAppService
    {
        private readonly ISubmittedAnswerService _studentAnswerService;

        public StudentAnswerReportAppService(ISubmittedAnswerService studentAnswerService, IUnitOfWork uow)
            : base(uow)
        {
            _studentAnswerService = studentAnswerService;
        }

        public StudentAnswerReportViewModel GetReport()
        {
            var arrStudentAnswers = TinyMapper.Map<List<StudentAnswerReport>>(_studentAnswerService.GetAll());

            var objStudentAnswerReportViewModel = new StudentAnswerReportViewModel();
            objStudentAnswerReportViewModel.ReportData = arrStudentAnswers;

            return objStudentAnswerReportViewModel;
        }


    }
}
