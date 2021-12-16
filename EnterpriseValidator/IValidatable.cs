using System;
using System.Collections.Generic;
using System.Text;

namespace EnterpriseValidator
{
    public interface IValidatable<T>
    {
        List<IValidationRule<T>> ValidationsRules { get; }
        List<string> Errors { get; }
        bool Validate();
        bool IsValid { get; }
    }
}
