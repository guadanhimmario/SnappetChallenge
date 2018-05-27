using FluentValidation;
using FluentValidation.Results;
using SnappetChallenge.Domain.Core.Models;
using System;

namespace SnappetChallenge.Domain.Entities
{
    public class SubmittedAnswer : Entity<SubmittedAnswer>
    {
        public int SubmittedAnswerId { get; set; }
        public DateTime SubmitDateTime { get; set; }
        public int Correct { get; set; }
        public int Progress { get; set; }
        public int UserId { get; set; }
        public int ExerciseId { get; set; }
        public string Difficulty { get; set; }
        public string Subject { get; set; }
        public string Domain { get; set; }
        public string LearningObjective { get; set; }

        public override bool isValid()
        {
            RuleFor(c => c.SubmittedAnswerId)
                .GreaterThan(0)
                .WithMessage("Please, Inform the Id");

            RuleFor(c => c.Subject)
            .NotEmpty().WithMessage("Please, insert a subject")
            .Length(1, 50).WithMessage("The subject must be between 1 and 50 characters");

            //This one won't go to production, just humor
            RuleFor(c => c.SubmitDateTime)
               .GreaterThan(DateTime.Now)
               .WithMessage("Your students are not Marty McFly, right?");

            ValidationResult = Validate(this);

            return ValidationResult.IsValid;
        }
    }
}
