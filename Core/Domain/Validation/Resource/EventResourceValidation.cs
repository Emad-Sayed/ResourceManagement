using Core.Domain.ViewModel.Resource;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Validation.Resource
{
    public class EventResourceValidation : AbstractValidator<EventCreateModel>
    {
        public EventResourceValidation()
        {
            RuleFor(x => x.End).Must((Model, End) => {
                TimeSpan toStartTime = TimeSpan.Parse(Model.Start);
                TimeSpan toEndTime = TimeSpan.Parse(End);
                return toEndTime > toStartTime;
            }).WithMessage("End Time must be larger than Start Time");
        }
    }
}
