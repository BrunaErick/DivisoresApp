using NUnit.Framework;
using System.Runtime.Intrinsics.X86;
using System;


namespace DivisorFinder.Tests
{
   
    public class DivisorFinderTests
    {
        [Test]
        public void TestarEncontrarDivisores()
        {
            // Arrange
            int numero = 12;
            List<int> esperado = new List<int> { 1, 2, 3, 4, 6, 12 };

            // Act
            List<int> resultado = DivisorProgram.EncontrarDivisores(numero);

            // Assert
            CollectionAssert.AreEqual(esperado, resultado);
        }

        [Test]
        public void TestarEhPrimo()
        {
            // Testes para números primos
            Assert.IsTrue(DivisorProgram.EhPrimo(2));
            Assert.IsTrue(DivisorProgram.EhPrimo(3));
            Assert.IsTrue(DivisorProgram.EhPrimo(5));
            Assert.IsTrue(DivisorProgram.EhPrimo(7));

            // Testes para números não primos
            Assert.IsFalse(DivisorProgram.EhPrimo(1));
            Assert.IsFalse(DivisorProgram.EhPrimo(4));
            Assert.IsFalse(DivisorProgram.EhPrimo(9));
            Assert.IsFalse(DivisorProgram.EhPrimo(10));
        }
    }
}