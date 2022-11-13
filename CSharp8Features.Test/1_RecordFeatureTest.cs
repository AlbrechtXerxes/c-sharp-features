using System.Collections.Generic;
using Xunit;
namespace CSharp9Features.Test
{
    public class RecordFeatureTest
    {
        [Fact]
        public void ClassAndRecord_WhenComparingWithTheSameVals_ThenGetEquality()
        {
            var record1 = new ChildRecord()
            {
                FirstName = "Joe",
            };
            var record2 = new ChildRecord()
            {
                FirstName = "Joe",
            };

            var class1 = new PersonClass()
            {
                FirstName = "Joe",
            };
            var class2 = new PersonClass()
            {
                FirstName = "Joe",
            };
            //Records are the same
            var areRecordsEqual = record1 == record2;
            //Classes are not the same
            var areClassesEqual = class1 == class2;
        }

        [Fact]
        public void RecordWithComplexTypeNotEqual()
        {
            var record1 = new RecordWithComplexType("Joe", "Doe") { SomeList = new List<string>() { "a" } };
            var record2 = new RecordWithComplexType("Joe", "Doe") { SomeList = new List<string>() { "a" } };
            //Even we have the same values, Record doesn't match well reference types like List.
            var isEqual = record1 == record2;
        }

        [Fact]
        public void InvokeParentMethodInRecord()
        {
            var childRecord = new ChildRecord("Doe", 10);
            //invoke parent method
            childRecord.DoSomething();
        }

        [Fact]
        public void ShortRecordCreation()
        {
            //Creating instance of one-line-record
            //Even we don't define First-name and Last-name, Record creates props for us
            var record1 = new PersonShortRecord("Doe", "Joe");
            
            //Cloning Record 'with'
            //Change only First Name. Last Name is still Joe.
            var record2 = record1 with { FirstName = "Goe" };
            //Pure cloning
            record2 = record1 with { };
            //Check equality
            var isEqual = record1 == record2;
        }

        [Fact]
        public void ShortRecordCreation22()
        {
            //Creating instance of one-line-record
            //Even we don't define First-name and Last-name, Record creates props for us
            var record1 = new PersonShortRecord("Doe", "Joe");

            //Cloning Record 'with'
            //Change only First Name. Last Name is still Joe.
            var record2 = record1 with { FirstName = "Goe" };
            //Pure cloning
            record2 = record1 with { };
            //Check equality
            var isEqual = record1 == record2;
        }
    }
}
