using FluentValidation;
using RestWithAsp_core5.Model;
using RestWithAsp_core5.Specification.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAsp_core5.Validator
{
    public class PersonValidator : AbstractValidator<Person>
    {
        private readonly IPersonSpecification _genericSpecification;

        public PersonValidator(IPersonSpecification genericSpecification)
        {
            _genericSpecification = genericSpecification;

            RuleFor(p => p.FirtName)
                .NotNull()
                .NotEmpty()
                .WithMessage("Informe o primeiro nome do Usuário");

            RuleFor(p => p.LastName)
                .NotNull()
                .NotEmpty()
                .WithMessage("Informe o último nome do Usuário");

            RuleFor(p => p.Address)
             .NotNull()
             .NotEmpty()
             .WithMessage("Informe o endereço do Usuário");

            RuleFor(p => p.Gender)
             .NotNull()
             .NotEmpty()
             .WithMessage("Informe o gênero do Usuário");


            RuleFor(p => p)
             .Must(VerifyExist)
             .NotEmpty()
             .WithMessage("Usuário ja cadastrado");
        }

        private bool VerifyExist(Person person)
        {
            return _genericSpecification.IsSatisfiedBy(person);
        }
    }
}
