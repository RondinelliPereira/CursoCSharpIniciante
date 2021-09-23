using System;

//IF/ELSE: representam uma estrutura de controle para que voce verifique se a condição apresentada
//é verdadeira ou falsa.
//Dessa forma, voce tomará decisões durante o cliclo de execução do seu software.

namespace estruturaDeControleIF_ELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo de saldoConta
            double saldoConta = 100.00;
            Console.Write("Digite o valor para debitar da sua conta: ");
            var debitar = Convert.ToDouble(Console.ReadLine());//convert para double pois valor digitado entra
                                                               //como texto.
            saldoConta -= debitar;

            if (saldoConta > 0)
            {
                Console.Write("Seu saldo é positivo. Ainda restam {0} em conta!", saldoConta);
            }
            else
            {
                Console.Write("Seu saldo é negativo!");
            }

            Console.ReadKey();

        }
    }
}
