using System;




//O que são variaveis: São regiões de memorias onde são guardadas informações.

//Para criar uma variavel, podemos usar o tipo especifico dela ou o var(vamos estudalo mais adiante)

namespace oQueSaoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            var nomeCorrentista = "Ray Carneiro";
            Console.Write("O nome do correntista: " + nomeCorrentista); //apresenta na tela do usuario o valor da variavel


            var nomeCorrentista2 = ""; //variavel criada e não inicializada
            nomeCorrentista2 = Console.ReadLine(); //variavel recebera dados do usuario via teclado
            Console.Write("Nome do correntista 2: " + nomeCorrentista2);
            Console.ReadLine();


        }
    }
}
