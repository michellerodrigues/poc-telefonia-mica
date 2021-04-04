using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Telefonia.Crud.Services.Messages
{
    public class ObterPlanoPorOperadoraMessageRequest : IValidatableObject
    {
        public int OperadoraId { get; set; }

        public int Ddd { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var listResult = new List<ValidationResult>();
            if (OperadoraId <= 0)
            {
                listResult.Add(new ValidationResult($"Id da Operadora deve ser maior que 0. Valor Informado :{OperadoraId}"));
            }

            if (Ddd <= 0)
            {
                listResult.Add(new ValidationResult($"Ddd do Plano deve ser maior que 0. Valor Informado :{Ddd}"));
            }
            return  listResult;
        }

    }
}
