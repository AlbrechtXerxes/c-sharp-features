using Xunit;
namespace CSharp9Features.Test
{
    public class InheritageCast
    {
        public abstract class Item { }
        public class ItemA : Item { }
        public class ItemB : Item { }
        public abstract class Person
        {
            public abstract Item BuyItem();
        }
        public class PersonA : Person
        {
            //Useful for Factory method, we reduce casting
            //We override basic 'Item' and replace with 'ItemA'
            public override ItemA BuyItem() { return new ItemA(); }
        }
        public class PersonB : Person
        {
            //We override basic 'Item' and replace with 'ItemB'
            public override ItemB BuyItem() { return new ItemB(); }
        }

        [Fact]
        public void OverrideTypeWhenInheritance()
        {
            var personA = new PersonA();
            var personB = new PersonB();

            ItemA itemA = personA.BuyItem();
            ItemB itemB = personB.BuyItem();
        }

        [Fact]
        public void ShortConditionAndDirectInheritanceCast()
        {
            var personA = new PersonA();
            var personB = new PersonB();
            var expr = 2 > 1;
            //We cast from 'PersonA to 'Person' without: (Person)(expr ? personA : personB);
            //Nicer shorter expression
            Person person = expr ? personA : personB;
        }
    }
}
