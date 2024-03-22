using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator() {
            RuleFor(ca => ca.Id).NotEmpty();
            RuleFor(ca=>ca.ModelYear).NotEmpty();
            RuleFor(ca => ca.DailyPrice).NotEmpty();
            RuleFor(ca=>ca.ColorId).NotEmpty();
            RuleFor(ca => ca.BrandId).NotEmpty();
            RuleFor(ca => ca.Description).NotEmpty();
            
        
        }
    }
}
