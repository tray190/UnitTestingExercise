using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
        // Righ-click on Dependencies in your .Tests project and set your reference



        // Create an Add method that passes 3 integers
        public int Add(int one, int two, int three)
        {
            return one + two + three;
        }
        // Create a Subtract method that passes 2 integers
        public int subtract(int minuend, int subtrhend)
        {
            return minuend - subtrhend;
        }

        // Create a Multiply method that passes 2 integers
        public int Multiply(int one, int two)
        {
            return one * two;
        }

        // Create a Divide method that passes 2 integers
        public int Devide(int one, int two)
        {
            return one / two;
        }


        // Create 2 methods that will utilize the [Fact] tests you wrote
       
    }
}
