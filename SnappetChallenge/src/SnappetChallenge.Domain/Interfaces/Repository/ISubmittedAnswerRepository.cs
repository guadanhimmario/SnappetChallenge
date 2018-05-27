using SnappetChallenge.Domain.Entities;
using System.Collections.Generic;

namespace SnappetChallenge.Domain.Interfaces.Repository
{
    public interface ISubmittedAnswerRepository
    {
        List<SubmittedAnswer> GetAllFromJson();

        List<SubmittedAnswer> GetAllFromJson(string JsonPath);
    }
}
