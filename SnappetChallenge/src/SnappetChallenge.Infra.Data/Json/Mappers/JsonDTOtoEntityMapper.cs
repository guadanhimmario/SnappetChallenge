using Nelibur.ObjectMapper;
using SnappetChallenge.Domain.Entities;
using SnappetChallenge.Infra.CrossCutting.DTO.Models.JsonSerializer;
using System.Collections.Generic;

namespace SnappetChallenge.Infra.Data.Json.Mappers
{
    public class JsonDTOtoEntityMapper
    {
        public static void Init()
        {
            TinyMapper.Bind<SubmittedAnswerJson, SubmittedAnswer>();
            TinyMapper.Bind<List<SubmittedAnswerJson>, List<SubmittedAnswer>>();
        }
    }
}
