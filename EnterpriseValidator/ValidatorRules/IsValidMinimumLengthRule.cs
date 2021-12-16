using System.Linq;
using System.Threading.Tasks;

namespace EnterpriseValidator.ValidatorRules
{
    public class IsValidMinimumLengthRule<T> : IValidationRule<T>
    {
        public string? ValidationMessage { get; set; }
        public int Minimum { get; set; }
        public ValueTask<bool> Check(T value)
        {
            if (value == null)
                return new ValueTask<bool>(false);

            string input = value as string;

            return new ValueTask<bool>(input.Where(c => !char.IsWhiteSpace(c)).Count() > Minimum);
        }
    }
}
