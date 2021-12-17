using System.Linq;
using System.Threading.Tasks;
namespace EnterpriseValidator.ValidatorRules.Strings;
public record IsValidMinimumLengthRule<T>(int Minimum, string ValidationMessage) : IValidationRule<T>
{
    public ValueTask<bool> Check(T value)
    {
        if (value == null)
            return new ValueTask<bool>(false);

        if (value is not string input)
            return new ValueTask<bool>(false);

        return new ValueTask<bool>(input.Where(c => !char.IsWhiteSpace(c)).Count() > Minimum);
    }
}

