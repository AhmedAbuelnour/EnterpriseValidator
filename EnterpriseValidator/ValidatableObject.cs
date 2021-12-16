using System.Collections.Generic;

namespace EnterpriseValidator
{
    public class ValidatableObject<T> : IValidatable<T>
    {
        public ValidatableObject()
        {
            ValidationsRules = new List<IValidationRule<T>>();
            Errors = new List<string>();
        }
        public List<IValidationRule<T>> ValidationsRules { get; }
        public List<string> Errors { get; private set; }
        public bool IsValid { get; private set; }
        public T Value { get; set; }
        public bool Validate()
        {
            ValidationsRules.ForEach(async a =>
            {
                if (!await a.Check(Value))
                    Errors.Add(a.ValidationMessage);
            });
            return IsValid = Errors.Count == 0;
        }
    }
}
