using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Telefonia.Crud.Services.Messages
{
    public class ObterPlanoPorTipoMessageRequest : IValidatableObject
    {
        public int TipoPlanoId { get; set; }

        public int Ddd { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var listResult = new List<ValidationResult>();
            if (TipoPlanoId <= 0)
            {
                listResult.Add(new ValidationResult($"Tipo do Plano deve ser maior que 0. Valor Informado :{TipoPlanoId}"));
            }

            if (Ddd <= 0)
            {
                listResult.Add(new ValidationResult($"Ddd do Plano deve ser maior que 0. Valor Informado :{Ddd}"));
            }
            return listResult;
        }

    }
}
