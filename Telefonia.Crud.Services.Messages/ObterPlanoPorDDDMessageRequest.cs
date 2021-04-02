using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Telefonia.Crud.Services.Messages
{
    public class ObterPlanoPorDDDMessageRequest: IValidatableObject
    {
        public int Ddd { get; set; }

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            var listResult = new List<ValidationResult>();

            if (Ddd <= 0)
            {
                listResult.Add(new ValidationResult($"Ddd do Plano deve ser maior que 0. Valor Informado :{Ddd}"));
            }
            return listResult;
        }

    }
}
