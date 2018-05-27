using Nelibur.ObjectMapper;
using Newtonsoft.Json;
using SnappetChallenge.Domain.Entities;
using SnappetChallenge.Domain.Interfaces.Repository;
using SnappetChallenge.Infra.CrossCutting.DTO.Models.JsonSerializer;
using SnappetChallenge.Infra.Data.Context;
using SnappetChallenge.Infra.Data.Json.Mappers;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SnappetChallenge.Infra.Data.Repository
{
    public class SubmittedAnswerRepository : Repository<SubmittedAnswer>, ISubmittedAnswerRepository
    {
        public SubmittedAnswerRepository(SnappetChallengeContext context)
            : base(context)
        {
            JsonDTOtoEntityMapper.Init();
        }

        public List<SubmittedAnswer> GetAllFromJson()
        {
            var DefaultPath =
          Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName) +
          @"\src\SnappetChallenge.Infra.Data\Json\Files\work.Json";

            return GetAllFromJson(DefaultPath);
        }

        public List<SubmittedAnswer> GetAllFromJson(string JsonPath)
        {
            var JsonText = File.ReadAllText(JsonPath);

            var Data = JsonConvert.DeserializeObject<List<SubmittedAnswerJson>>(JsonText);

            if (Data != null && Data.Any())
                return TinyMapper.Map<List<SubmittedAnswer>>(Data);
            else
                return new List<SubmittedAnswer>();
        }

    }
}
