using System;
namespace UnitTestingExercise
{
    public class Calculator
    {
     
        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
           
        }


        


        // Keep track of which number is getting passed as minuend and subtrahend
        public int Subtract(int minend, int subtrahend)
        {
            return minend - subtrahend;
        }

        


        
        public int Multiply(int a, int b)
        {
            return a * b;
        }


        // Step 7: Navigate to the UnitTests.cs file and complete the MultiplyTest unit test method 


        // Step 8: 
        // Create a Divide method that passes 2 integers
        public int Divide(int a, int b)
        {
            return a / b;
        }

        // Step 9: Navigate to the UnitTests.cs file and complete the DivideTest unit test method 


        //*****NOW RUN ALL OF YOUR TESTS*********//
    }
}
