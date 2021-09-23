using System;

//O que são tipagens no C#?
//C# e uma linguagem fortemente tipada, cada variavel que você guarda informação ira seguir um tipo especifico.

//Os tipo tem tamanho e valores possiveis:
//Tipo: bool - Tamanho: 1 byte - Valores Possiveis: True/False
//Tipo: int - Tamanho: 4 bytes - Valores Possiveis: -2147483648 a 2147483647
//entre outros...


//var: Palavra reservada, aceita qualquer tipo de dados na variavel criada, apos o sinal de atribuição "=".


namespace oQueSaoTipagensNoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int xpto = "10"; //variavel criada como inteiro e atribuido com string, não aceita

            //conversão
            int xpto = Convert.ToInt32("10"); //convertendo tipo de dados string to int
            Console.Write(xpto);

            var dataAniversario = Convert.ToDateTime("2021/09/13"); //convertendo tipo de dados data string to date time
            Console.Write(dataAniversario);
            Console.ReadLine();

            //conversao de int to string
            double saldo = 100.0;

            saldo = saldo - 10.0;

            Console.Write("O saldo atual e: " + saldo);
            Console.ReadLine();
        }
    }
}
