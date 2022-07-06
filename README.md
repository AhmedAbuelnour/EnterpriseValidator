# EnterpriseValidator

* Define your class model
```
public class Person
{
        public ValidatableObject<string> Name { get; set; } = new ValidatableObject<string>();
        public ValidatableObject<int> Age { get; set; } = new ValidatableObject<int>();
}
```
* Adding Value
```
Person Person = new Person();
Person.Name.Value = "Ahmed Abuelnour";
```
* Adding Validation Rules (Apply one of the built in rules)
```
Person.Name.AddRules(new IsValidMinimumLengthRule<string>(4, "Name must be greater than 4"), 
                     new IsValidMaximumLengthRule<string>(25, "Name must be less than 25"));

```
* Validate the rules against the input
```
bool nameValidateResult = Person.Name.Validate();
```
* Get the validation result as Json
```
string validationErrorResult = Person.Name.GetValidationRuleResultsAsJson();
```
* Get the validation result as List 
```
List<ValidationRuleResult> results = Person.Name.GetValidationRuleResults();
```
