using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp_Calculation;
using System;

namespace Csharp_Test{
    [TestClass] public class TestOperation
    {
        [TestMethod] public void TestAdd(){
            Random rand = new Random();
               int num1 = rand.Next();
            int num2 = rand.Next();
            int res = num1 + num2;
            var addOp = new Add<int>();
            Assert.IsTrue(res == addOp.Operate(num1, num2));
        }

        [TestMethod]
        public void TestSub(){
            Random rand = new Random();
            int num1 = rand.Next();
            int num2 = rand.Next();
            int res = num1 - num2;
            var subOp = new Sub<int>();
            Assert.IsTrue(res == subOp.Operate(num1, num2));
        }
    }
}
