using System;

namespace TestAppUsingTestClassLibraryReturnValue_NUPKG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TestClassLibraryReturnValue.ReturnSumTwoValues.Sum(10, 20));
        }
    }
}
