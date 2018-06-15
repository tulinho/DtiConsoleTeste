using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;

namespace UnitTestDtiConsoleTestes
{
    [TestClass]
    public class UnitTest1
    {

        [AssemblyInitialize]
        public static void Iniciar(TestContext context)
        {
        }

        [TestMethod]
        public void TestVerificarPalindromoSucesso()
        {
            Assert.IsTrue(Program.VerificarPalindromo(12321));
            Assert.IsTrue(Program.VerificarPalindromo(75322357));
            Assert.IsTrue(Program.VerificarPalindromo(2468642));
        }

        [TestMethod]
        public void TestVerificarPalindromoErro()
        {
            Assert.IsFalse(Program.VerificarPalindromo(1486314863));
            Assert.IsFalse(Program.VerificarPalindromo(25825));
            Assert.IsFalse(Program.VerificarPalindromo(123655321));
        }

        public bool VerificarPalindromo(int numero)
        {
            string numeroString = numero.ToString();
            bool palindromo = true;
            for (int contador = 0; contador < numeroString.Length / 2; contador++)
            {
                palindromo = palindromo && numeroString[contador] == numeroString[numeroString.Length - 1 - contador];
            }
            return palindromo;
        }

        [TestMethod]
        public void TestVerificarMaiorPalindromo()
        {
            Assert.AreEqual(MaiorPalindromo(2), Program.MaiorPalindromo(2));
            Assert.AreEqual(MaiorPalindromo(3), Program.MaiorPalindromo(3));
            Assert.AreEqual(MaiorPalindromo(4), Program.MaiorPalindromo(4));
        }

        public int MaiorPalindromo(int tamanho)
        {
            int maximo = ObterMaiorNumero(tamanho);
            int minimo = ObterMenorNumero(tamanho);

            for (int operando1 = maximo; operando1 >= minimo; operando1--)
            {
                for (int operando2 = maximo; operando2 >= minimo; operando2--)
                {
                    int produto = operando1 * operando2;
                    if (VerificarPalindromo(produto))
                        return produto;
                }
            }                        
            return 0;
        }

        private int ObterMaiorNumero(int tamanho)
        {
            string numero = "";
            return Convert.ToInt32(numero.PadRight(tamanho, '9'));
        }

        private int ObterMenorNumero(int tamanho)
        {
            string numero = "";
            return Convert.ToInt32(numero.PadRight(tamanho, '1'));
        }

        [TestMethod]
        public void TestVerificarNumeroCircularPrimoSucesso()
        {
            Assert.IsTrue(Program.VerificarNumeroCircularPrimo(7));
            Assert.IsTrue(Program.VerificarNumeroCircularPrimo(13));
            Assert.IsTrue(Program.VerificarNumeroCircularPrimo(197));
        }

        [TestMethod]
        public void TestVerificarNumeroCircularPrimoErro()
        {
            Assert.IsFalse(Program.VerificarNumeroCircularPrimo(12));
            Assert.IsFalse(Program.VerificarNumeroCircularPrimo(45));
        }

        private bool VerificarNumeroCircularPrimo(int numero)
        {
            bool circularPrimo = true;
            int numeroRotacionado = numero;
            for (int contador = 0; contador < numero.ToString().Length; contador++)
            {
                circularPrimo = circularPrimo && VerificarSeONumeroEPrimo(numeroRotacionado);
                numeroRotacionado = RotacionarNumero(numeroRotacionado);
            }
            return circularPrimo;
        }

        private int RotacionarNumero(int numeroRotacionado)
        {
            string numeroString = numeroRotacionado.ToString();
            numeroString = numeroString.PadRight(numeroString.Length + 1, numeroString[0]);
            numeroString = numeroString.Substring(1, numeroString.Length - 1);
            return Convert.ToInt32(numeroString);
        }

        private bool VerificarSeONumeroEPrimo(int numero)
        {
            for(int contador = 2; contador < numero; contador++)
            {
                if (numero % contador == 0)
                    return false;
            }
            return true;
        }
    }
}
