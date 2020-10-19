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

                return  End> Model.Start;
            }).WithMessage("End Time must be larger than Start Time");
        }
    }
}
