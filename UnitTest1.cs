using NUnit.Framework;
using FizzBuzzConsoleApp;
using System;


namespace FizzBuzzTests
{
    public class Tests
    {
        //private Program _program;
        private Random _rndGenerator;

        [SetUp]
        public void Setup()
        {
            //_program = new Program();
            _rndGenerator = new Random();
            Console.WriteLine("Test");
        }

        [Test]
        public void DoTheTestPlease()
        {
            int[] testCandidates = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Test2");
                testCandidates[i] = _rndGenerator.Next(5,50);
            }

            foreach(var candidate in testCandidates)
            {
                Console.WriteLine("Test3");
                Assert.AreEqual(Program.FizzBuzz(candidate).Length, candidate);
            }
        }
    }
}