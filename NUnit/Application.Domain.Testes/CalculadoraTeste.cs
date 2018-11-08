using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Domain.Testes
{
    [TestFixture]
    public class CalculadoraTeste
    {
        [Test]
        public void SomarDoisNumeros()
        {
            var calc = new Calculadora();
            var result = calc.Somar(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void MultiplicarDoisNumeros()
        {

            var calc = new Calculadora();
            var result = calc.Multiplicar(2, 10);
            Assert.That(result, Is.EqualTo(20));
        }

        [Test]
        public void SubtrairDoisNumeros()
        {
            var calc = new Calculadora();
            var result = calc.Subtrair(10,5);
            Assert.That(result, Is.EqualTo(5));
        }
    }
}
