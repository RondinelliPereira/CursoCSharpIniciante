using System;
using System.Collections.Generic; //inserido para se criar Listas

//Listas: fornecem estrutura de dados parecido com arrays, porem, voce consegue ter uma lista multavel.
//OU seja, se em uma situação voce nçao sabe o quantas estruturas precisa, entçao voce usa uma lista.
//pois ao longo do caminho voce pode adicionar mais elemento naquela lista.


namespace conhecendoListas
{
    class Program
    {
        static void Main(string[] args)
        {

            //Criando uma lista chamada nomes
            List<String> nomes = new List<String>();

            //inserindo dados na lista de string
            //nomes = nome da lista
            //. = permite acessar as opções de metodos dessa lista
            //Add = metodo de adicionar dados em uma lista
            //Count = metodo de contar quantas posições eu tenho na lista nomes

            nomes.Add("Fulano da Silva");
            nomes.Add("Beltrano da Silva");
            nomes.Add("Ray");
            
            //Console.Write("Posição inicial da lista: " + nomes[0] + ", com o tamanho de lista: " + nomes.Count);
            //Console.ReadLine();

            //Contains = metodo que verifica se existe na lista o elemento procurado
            bool existeNaLista = nomes.Contains("Ray"); //elemento a ser procurado pelo Contains, Ray.

            Console.Write("Existe na Lista? " + existeNaLista);
            Console.Read();





        }
    }
}

