
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auth.Domain.Validations
{
    public class CreateUserValidation : AbstractValidator<User>
    {
        public CreateUserValidation()
        {
            RuleFor(x => x.Email).NotNull().WithMessage("Informe o e-mail");
            RuleFor(x => x.Email).EmailAddress().WithMessage("E-mail inválido");
            RuleFor(x => x.Name).NotNull().WithMessage("Informe o nome");
            RuleFor(x => x.Password).NotNull().WithMessage("Informe uma senha");
            RuleFor(x => x.ConfirmPassword).NotEqual(x => x.Password).WithMessage("Senhas informadas são diferentes");
            RuleFor(x => x.Password).Matches("?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^A-Za-z0-9])(?=.{8,}")
                .WithMessage("A senha não atende os requisitos de segurança. Mínimo de 8 caracteres, 1 digito, 1 letra maiúscula, 1 caracter especial");

        }

    }
    public class ResetPasswordValidation : AbstractValidator<User>
    {
        public ResetPasswordValidation()
        {
            RuleFor(x => x.Password).NotNull().WithMessage("Informe uma senha");
            RuleFor(x => x.ConfirmPassword).NotEqual(x => x.Password).WithMessage("Senhas informadas são diferentes");
            RuleFor(x => x.Password).Matches("?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^A-Za-z0-9])(?=.{8,}")
                .WithMessage("A senha não atende os requisitos de segurança. Mínimo de 8 caracteres, 1 digito, 1 letra maiúscula, 1 caracter especial");
        }
    }
    public class SendPasswordValidation : AbstractValidator<User>
    {
        private readonly IUserRepository userRepository;
        public SendPasswordValidation(IUserRepository userRepository)
        {
            RuleFor(x => x.Email).NotNull().WithMessage("Informe o e-mail");
            RuleFor(x => x.Email).EmailAddress().WithMessage("E-mail inválido");
            RuleFor(x => x.Email).MustAsync(async (email, cancellation) =>
                {
                    bool exists = await userRepository.Exist(email);
                    return exists;
                }).WithMessage("E-mail não pertence a nenhum usuário");
        
            
        }
    }
}
