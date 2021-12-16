using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseValidator.ValidatorRules
{
    public class IsOnlyNumbersRule<T> : IValidationRule<T>
    {
        public string? ValidationMessage { get; set; }
        public ValueTask<bool> Check(T value)
        {
            if (value == null)
                return new ValueTask<bool>(false);

            string numbers = value as string; 
            
            return new ValueTask<bool>(numbers.All(a => char.IsDigit(a)));
        }
    }
}
