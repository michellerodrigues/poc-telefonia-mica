using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Telefonia.Crud.Services.Messages
{
    public class CadastrarPlanoMessageRequest : IValidatableObject
    {
        public PlanoMessage Plano { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var listResult = new List<ValidationResult>();
            if (Plano.Min <= 0)
            {
                listResult.Add(new ValidationResult($"Min do Plano deve ser maior que 0. Valor Informado :{Plano.Min}"));
            }

            if (Plano.Valor <= 0)
            {
                listResult.Add(new ValidationResult($"Valor do Plano deve ser maior que 0. Valor Informado :{Plano.Valor}"));
            }

            if (String.IsNullOrEmpty(Plano.Operadora))
            {
                listResult.Add(new ValidationResult($"Operadora é obrigatório:{Plano.Operadora}"));
            }

            if (String.IsNullOrEmpty(Plano.TipoPlano))
            {
                listResult.Add(new ValidationResult($"Tipo de Plano é obrigatório :{Plano.TipoPlano}"));
            }

            if (Plano.Ddd <= 0)
            {
                listResult.Add(new ValidationResult($"DDD do Plano deve ser maior que 0. Valor Informado :{Plano.Min}"));
            }

            return listResult;
        }
    }
}
