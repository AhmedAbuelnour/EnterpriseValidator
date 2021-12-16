using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace EnterpriseValidator.ValidatorRules
{
    public class IsValidEmailAddressRule<T> : IValidationRule<T>
    {
        public string? ValidationMessage { get; set; }
        public ValueTask<bool> Check(T value)
        {
            if (value == null)
                return new ValueTask<bool>(false);
            string email = value as string;
            string pattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([azA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            if (Regex.IsMatch(email, pattern))
            {
                if (Regex.Replace(email, pattern, string.Empty).Length == 0)
                {
                    return new ValueTask<bool>(true);
                }
            }
            return new ValueTask<bool>(false);
        }
    }
}
