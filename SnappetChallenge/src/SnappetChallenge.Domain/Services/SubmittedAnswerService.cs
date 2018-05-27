using SnappetChallenge.Domain.Entities;
using SnappetChallenge.Domain.Interfaces.Repository;
using SnappetChallenge.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnappetChallenge.Domain.Services
{
    public class SubmittedAnswerService : ISubmittedAnswerService
    {
        private readonly ISubmittedAnswerRepository _submittedAnswerRepository;

        public SubmittedAnswerService(ISubmittedAnswerRepository submittedAnswerRepository)
        {
            _submittedAnswerRepository = submittedAnswerRepository;
        }

        public List<SubmittedAnswer> GetAll()
        {
            return _submittedAnswerRepository.GetAllFromJson();
        }

    }
}
