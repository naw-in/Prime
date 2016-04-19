using System;
using NUnit.Framework;
using Prime;

namespace Prime.Tests
{
    [TestFixture]
    public class PrimeNumbersTest
    {
        PrimeNumbers prime;
        //Arrange
        [TestFixtureSetUp]
        public void TestSetUp()
        {
            prime = new PrimeNumbers();
        }
        

        [Test]
        public void Returns0ElementsWhenUserInputs0()
        {
            //Act
            var primeNumbers = prime.GeneratePrimeNumbers(0);

            //Assert
            Assert.AreEqual(primeNumbers.Count, 0);
        }

        [Test]
        public void Returns3ElementsWhenUserInputs3()
        {
            //Act
            var primeNumbers = prime.GeneratePrimeNumbers(3);

            //Assert
            Assert.AreEqual(primeNumbers.Count, 3);
        }

        [Test]
        public void FirstElementReturnedIs2()
        {
            //Act
            var primeNumbers = prime.GeneratePrimeNumbers(3);

            //Assert
            Assert.AreEqual(primeNumbers[0], 2);
            
        }

        [Test]
        public void SecondElementReturnedIs3()
        {
            //Act
            var primeNumbers = prime.GeneratePrimeNumbers(3);

            //Assert
            Assert.AreEqual(primeNumbers[1], 3);

        }
    }
}
