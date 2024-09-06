﻿using FluentValidation;
using FluentValidation.Results;
using Tair.Domain.Interfaces;
using Tair.Domain.Entities.Base;
using Tair.Domain.Notificacoes;

namespace Tair.Domain.Services
{
    public abstract class BaseService
    {
        private readonly INotificador _notificador;

        protected BaseService(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected void Notificar(string mensagem)
        {
            // Propagar o erro até a camada de apresentação
            _notificador.Handle(new Notificacao(mensagem));
        }

        protected void Notificar(ValidationResult validationResult)
        {
            // Recebe todos os erros do Validation Result
            foreach (var error in validationResult.Errors)
            {
                Notificar(error.ErrorMessage);
            }
        }

        // TV - Validação; TE - Entidade genérica
        protected bool ExecutarValidacao<TV, TE>(TV validacao, TE entidade) where TV : AbstractValidator<TE> where TE : BaseEntity
        {
            var validator = validacao.Validate(entidade);

            if(validator.IsValid) return true;

            Notificar(validator);

            return false;
        }
    }
}
