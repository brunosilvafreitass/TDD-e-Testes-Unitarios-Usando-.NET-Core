using NewTalents;
using System;
using Xunit;

namespace TestNewTalents
{
    public class UnitTest1
    {
        public Calculadora contruirClasse()
        {
            string data = "02/02/2020";
            Calculadora calc = new Calculadora("02/02/2020");

            return calc;
        }

        [Theory]
        [InlineData (1,2,3)]
        [InlineData (4,5,9)]
        public void TesteSomar(int num1,int num2, int resultado)
        {
            Calculadora calc = contruirClasse();

            int resultadoCalculadora = calc.somar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);

        }
        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int num1, int num2, int resultado)
        {
            Calculadora calc = contruirClasse();

            int resultadoCalculadora = calc.multiplicar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);

        }
        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDividir(int num1, int num2, int resultado)
        {
            Calculadora calc = contruirClasse();

            int resultadoCalculadora = calc.dividir(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);

        }
        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 5, 0)]
        public void TesteSubtrair(int num1, int num2, int resultado)
        {
            Calculadora calc = contruirClasse();

            int resultadoCalculadora = calc.subtrair(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);

        }
        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = contruirClasse();

            Assert.Throws<DivideByZeroException>(() => calc.dividir(3,0));
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = contruirClasse();

            calc.somar(1, 2);
            calc.somar(2, 2);
            calc.somar(3, 2);
            calc.somar(4, 2);

            var lista = calc.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}
