﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Telefonia.Crud.Services.Messages
{
    public class ObterPlanoMessageRequest : IValidatableObject
    {
        public int IdPlano { get; set; }
        public int Ddd { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var listResult = new List<ValidationResult>();
            if (IdPlano <= 0)
            {
                listResult.Add(new ValidationResult($"Id do Plano deve ser maior que 0. Valor Informado :{IdPlano}"));
            }

            if (Ddd <= 0)
            {
                listResult.Add(new ValidationResult($"Ddd do Plano deve ser maior que 0. Valor Informado :{Ddd}"));
            }
            return listResult;
        }
    }
}
