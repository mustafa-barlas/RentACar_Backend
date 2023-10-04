using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.Name).MinimumLength(2).WithMessage("isim 2 karakterden az olamaz");
            RuleFor(r => r.Name).NotEmpty().WithMessage("İsim boş geçilemez");
            //RuleFor(r => r.DailyPrice).NotEmpty();
            //RuleFor(r => r.DailyPrice).GreaterThan(0);
            //RuleFor(r => r.RenDate).NotEmpty();
            //RuleFor(r => r.Name).Must(StartWithA).WithMessage("İsim A harfi ile başlamalı");
        }

        //private bool StartWithA(string arg)
        //{
        //    return arg.StartsWith("A");
        //}
    }
}
