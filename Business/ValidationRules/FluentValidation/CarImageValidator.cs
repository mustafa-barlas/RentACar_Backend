﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;
using FluentValidation.Results;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImageValidator : AbstractValidator<CarImage>
    {
        public CarImageValidator()
        {
            RuleFor(x => x.ImagePath).NotEmpty().WithMessage("resim yolu boş geçilemez");
            RuleFor(x => x.ID).NotEmpty().WithMessage("araba ıd si girilmeli");
        }

       
    }
}
