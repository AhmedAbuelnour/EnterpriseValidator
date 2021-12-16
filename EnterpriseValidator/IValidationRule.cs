using System.Threading.Tasks;

namespace EnterpriseValidator
{
    public interface IValidationRule<T>
    {
        string ValidationMessage { get; set; }
        ValueTask<bool> Check(T value);
    }
}
