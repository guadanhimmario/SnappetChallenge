using SnappetChallenge.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnappetChallenge.Application.Interfaces
{
    public interface IStudentAnswerReportAppService
    {
        StudentAnswerReportViewModel GetReport();
    }
}
