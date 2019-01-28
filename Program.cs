using System;
using Builder.BuilderInheritance;
using Builder.CodeBuilder;
using Builder.CreationalBuilder;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.NewLine);
            Demo demoBuilder = new Demo();
            demoBuilder.RunDemoBuilder();
            Console.WriteLine(Environment.NewLine);
            // var cb = new Variable("Name", "string");
            // Console.WriteLine(cb.ToStringIntend(0));
            var cb = new CodeBuilderRunner();
            cb.runner();

            var bi = new BuilderInheritanceDemo();
            
         }
    }
}
