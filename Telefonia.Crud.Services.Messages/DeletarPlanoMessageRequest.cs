using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Telefonia.Crud.Services.Messages
{
    public class DeletarPlanoMessageRequest : IValidatableObject
    {
        public int IdPlano { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var listResult = new List<ValidationResult>();
            if (IdPlano <= 0)
            {
                listResult.Add(new ValidationResult($"Id do Plano deve ser maior que 0. Valor Informado :{IdPlano}"));
            }
                       
            return listResult;
        }
    }
}
