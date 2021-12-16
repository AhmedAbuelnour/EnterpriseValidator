using System.Linq;
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

            string input = value as string;
            if (input == null)
                return new ValueTask<bool>(false);
            return new ValueTask<bool>(input.All(a => char.IsDigit(a)));
        }
    }
}
