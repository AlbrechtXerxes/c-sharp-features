using System.Collections.Generic;
namespace CSharp9Features
{
    public record ParentRecord
    {
        public int Age { get; set; }
        public void DoSomething()
        {
        }
        public ParentRecord()
        {
        }

        public ParentRecord(int age)
        {
        }
    }

    public record ChildRecord : ParentRecord
    {
        public ChildRecord()
        {
        }
        public ChildRecord(string firstName, int age) : base(age)
        {
            FirstName = firstName;
        }

        public string FirstName { get; init; } = default!;
        public string LastName { get; init; } = default!;
        public string MutableProp { get; set; }
    };

    //Class to compare equality with Record
    public class PersonClass
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
    };

    //Argument in first line (42) record definition with body
    public record RecordWithComplexType(string FirstName, string LastName)
    {
        //with complex type, comparison is not so easy
        public List<string> SomeList { get; init; }
    }
    //We don't have body, C# creates it for us
    public record PersonShortRecord(string FirstName, string LastName);
    public class ClassWithComplexType
    {
        public List<string> SomeList { get; init; } = new List<string> { "a", "b" };
    }
}

