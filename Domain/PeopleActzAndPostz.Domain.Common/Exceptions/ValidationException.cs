namespace PeopleActzAndPostz.Domain.Common.Exceptions

{
    public class FluentValidationException:Exception
    {
        public FluentValidationException(IReadOnlyDictionary<string, string[]> errorsDictionary)
      : base("Validation Failure")
      => ErrorsDictionary = errorsDictionary;

        public IReadOnlyDictionary<string, string[]> ErrorsDictionary { get; }
    }
}
