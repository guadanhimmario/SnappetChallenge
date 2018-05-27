using SnappetChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnappetChallenge.Infra.Data.EntityConfig
{
    public class SubmittedAnswerConfig : EntityTypeConfiguration<SubmittedAnswer>
    {
        public SubmittedAnswerConfig()
        {
            ToTable("SubmittedAnswer");
        }
    }
}
