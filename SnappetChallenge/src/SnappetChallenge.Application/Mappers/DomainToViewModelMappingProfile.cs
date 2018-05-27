using Nelibur.ObjectMapper;
using SnappetChallenge.Application.ViewModels;
using SnappetChallenge.Domain.Entities;
using System.Collections.Generic;

namespace SnappetChallenge.Application.Mappers
{
    public class DomainToViewModelMappingProfile
    {
        public static void Init()
        {
            TinyMapper.Bind<StudentAnswerReport, SubmittedAnswer>();
            TinyMapper.Bind<List<StudentAnswerReport>, List<SubmittedAnswer>>();
        }
    }
}
