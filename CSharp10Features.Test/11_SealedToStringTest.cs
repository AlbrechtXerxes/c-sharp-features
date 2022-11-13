namespace CSharp10Features.Test
{
    public record Person
    {
        public string FirstName { get; init; }
        public sealed override string ToString()
        {
            return $"{FirstName}";
        }
    }

    public record PersonA : Person
    {
        //After applying sealed, we cannot override it.
        //It forces unity across children of Person
        //public override string ToString()
        //{
        //    return "try to override it";
        //}
    }
}
