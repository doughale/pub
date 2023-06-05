using System;
using System.Linq;

namespace ConsoleApp8
{
    public class Lambda
    {
        public static string doSomething(string a, string b, string c)
        {
            return $"You passed in {a}, {b}, and {c}";
        }
        public static void LambdaMain(string[] args)
        {
            // f1 is a func that takes 3 string arguments (the first 3) and returns a string argument (last one)
            // (a, b, c) => ... is a "lambda" (aka an anonymous function). The lambda body calls a named function, but it is still a lambda.
            // the types of the lambda parameters "(a, b, c)" are inferred from the "Func" signature: "Func<string, string, string, string>"
            // the body of the lambda returns the result of "doSomething" which is itself a function that takes 3 strings and returns a string
            Func<string, string, string, string> f1 = (a, b, c) =>
            {
                return doSomething(a, b, c);
            };

            // f2 is just like f1 without the lambda: f2 is a func that takes 3 string args and returns the string returned by doSomething
            // no "lambda"s are present here. Everything has names.
            var f2 = new Func<string, string, string, string>(doSomething);

            // f3 is just like f1 only the lambda is has typed parameters
            Func<string, string, string, string> f3 = (string a, string b, string c)=> {
                return $"You passed in {a}, {b}, and {c}";
            };

            Console.WriteLine(f1("Neil", "Geddy", "Alex"));
            Console.WriteLine(f2("Neil", "Geddy", "Alex"));
            Console.WriteLine(f3("Neil", "Geddy", "Alex"));

        }
    }
}
