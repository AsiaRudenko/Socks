// © 2019 Company name. All rights reserved...

namespace WebApplication2
{
    public abstract class Class1
    {
        public abstract void Foo();
    }

    public class Class2 : Class1
    {
        public override void Foo()
        {
        }
    }


    public class Class3
    {
        public void Bar()
        {
            var myClass2 = new Class2();
            myClass2.Foo();
        }
    }
}