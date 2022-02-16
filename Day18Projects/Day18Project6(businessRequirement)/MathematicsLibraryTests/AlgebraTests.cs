using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathematicsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsLibrary.Tests
{
    [TestClass()]
    public class AlgebraTests
    {
        [TestMethod()]
        public void FactorialTest_Zero_Input()
        {
            //arrange
            int n = 0;
            int expected = 1;
            //act
            int actual = Algebra.Factorial(n);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void FactorialTest_Greaterthan_Seven()
        {
            //arrange
            int n = 8;
            int expected = -999;

            //act
            int actual = Algebra.Factorial(n);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void FactorialTest_NegativeInput()
        {
            //arrange
            int n = -1;
            int expected = -9999;

            //act
            int actual = Algebra.Factorial(n);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void FactorialTest_One_To_Seven_Input()
        {
            //arrange
            int n = 5;
            int expected = 120;

            //act
            int actual = Algebra.Factorial(n);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void PalindromeTest_Yes()
        {
            //arrange
            int n = 232;
            int expected = 232;
            //act
            int actual = Algebra.Palindrome(n);
            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void PalindromeTest_No()
        {
            //arrange 
            int n = 145;
            int expected = 541;
            //act
            int actual= Algebra.Palindrome(n);
            //Assert
            Assert.AreNotSame(expected, actual);
            
        }
    }
}