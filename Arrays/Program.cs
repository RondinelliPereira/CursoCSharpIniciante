using System;


//Arrays: Pode guardar diversas variaveis do mesmo tipo dentro de uma mesma estrutura de dados.

//Exemplo: String
//String nome = "Fulano da Silva";

//Exemplo Array:
//String[] nomes = new String[] {"Fulano da Silva", "Beltrano da Silva"};


namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Variavel arrays nomes
            String[] nomes = new string[5]; // new = usada para instanciar ou começar alguma coisa.
                                            //neste caso aqui, estamos começando e colocando em memoria 5 posições 
                                            //para colocar texto. Ela aloca espaço em, memoria para trabalhar.

            //inserindo dados nas posições de array da variavel nomes
            nomes[0] = "Ray Carneiro";
            nomes[1] = "Rondinelli Pereira";

            //saida dos dados de cada posição do array da variavel nomes
            Console.Write("O valor da posição zero eh: " + nomes[0]);
            Console.Read();
            Console.Write("O valor da posição zero eh: " + nomes[1]);
            Console.Read();

        }
    }
}
