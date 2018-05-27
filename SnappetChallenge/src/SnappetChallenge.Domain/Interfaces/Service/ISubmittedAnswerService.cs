using SnappetChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnappetChallenge.Domain.Interfaces.Service
{
    public interface ISubmittedAnswerService
    {
        List<SubmittedAnswer> GetAll();
    }
}
