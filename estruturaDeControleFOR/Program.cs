using System;

//FOR: representa um loop onde você roda um bloco repetidamente até que a expressão se torne
//falsa, ou seja, "enquanto" FOR verdadeiro, o FOR seerá executado. O FOR é um tipo de loop
//com valor determinado de repetições.
//Usado para repetir determionadas rotinas em seu software.

namespace estruturaDeControleFOR
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanho = 10;

            //primeira posição i = inicialização variavel
            //segunda posição i = condição para iteração do loop
            //terceira  posição i = iterador

            //Exemplo loop FOR
            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("O valor da variavel i é: " + i + "\n");
            }
            Console.ReadKey();

        }
    }
}
