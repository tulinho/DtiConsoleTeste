using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }

        /*
         * Um palíndromo é um número que, ao ser invertido, pode ser lido da mesma maneira. 
         * Exemplo: 2002, 12321, 4554...
         * Implemente a função que verifica se um determinado número é um palíndromo
         */
        public static bool VerificarPalindromo(int numero)
        {
            throw new NotImplementedException();
        }

        /*
         * O maior palíndromo obtido pela multiplicação de dois números de dois algorítimos é 9009, 
         * obtido ao se multiplicar 99 X 91 = 9009.
         * Implemente a função para calcular o maior palíndromo obtido pela multiplicação de dois números
         *  de três ou mais algarísmos. A função deverá receber o número de algarísmos dos operandos.
         */
        public static int MaiorPalindromo(int numeroDeDigitos)
        {
            throw new NotImplementedException();
        }

        /*
         * O número 197 é chamado primo circular porque todas as suas rotações de digitos também são primos: 197, 971, e 719.
         * Implemente uma função para verificar se um dado número é primo circular
         */
        public static bool VerificarNumeroCircularPrimo(int numero)
        {
            throw new NotImplementedException();
        }

        /*
         * Implemente os métodos FiltrarNumerosPares e ElevarNumeroAoCubo que devem retornar as expressões lambda necessária
         * para o correto funcionamento da do método FiltrarParesEElevarAoCubo
         */
        public static List<int> FiltrarParesEElevarAoCubo(List<int> lista)
        {
            return lista.Where(FiltrarNumerosPares()).Select(ElevarNumeroAoCubo()).ToList();
        }

        public static Func<int, bool> FiltrarNumerosPares()
        {
            throw new NotImplementedException();
        }

        public static Func<int, int> ElevarNumeroAoCubo()
        {
            throw new NotImplementedException();
        }

        /*
         * Implemente os delegates necessários à correta implementação do método CalcularMultiplicacaoMmcMdc que 
         * retorna o produto MMC x MDC de três números
         */
        public static int CalcularMultiplicacaoMmcMdc(int x, int y, int z)
        {
            return MultiplicarMmcMdc(x, y, z, null, null);
        }

        public delegate int ExecutarOperacaoEntreTresNumeros(int x, int y, int z);

        public static int MultiplicarMmcMdc(int x, int y, int z, ExecutarOperacaoEntreTresNumeros calcularMmc, ExecutarOperacaoEntreTresNumeros calcularMdc)
        {
            return calcularMmc(x, y, z) * calcularMdc(x, y, z);
        }
    }
}
