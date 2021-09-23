using System;
using System.Collections.Generic;

//FOREACH: representa um loop onde você roda um bloco repetidamente analisando
//o valor de cada elemento de forma individual.

//O foreach é um recurso do C# que possibilita executar um conjunto de comandos
//para cada elemento presente em uma coleção (Array, List, Stack, Queue e outras).
//Portanto, diferentemente do while e do for, não precisamos definir uma condição de parada.
//Isso é definido de forma implícita, pelo tamanho da coleção.

//Na declaração do foreach, entre parênteses criamos um elemento do tipo utilizado na coleção e,
//com o operador in, informamos a coleção a ser percorrida.
//Assim, a cada loop os dados presentes em uma posição da coleção são atribuídos ao elemento.
//Por fim, entre chaves, inserimos o código a ser executado no loop.

namespace estruturaDeControleFOREACH
{
    class Program
    {
        static void Main(string[] args)
        {
            //criando uma lista com nomes
            List<String> nomes = new List<string> { "Ray Carneiro", "Pollyana Carneiro", "Fernando Mendes" };

            //primeira posição da sintaxe = tipo de elemento
            //segunda posição da sintaxe = coleção
            foreach (var item in nomes)
            {
                Console.Write("O nome da pessoa é: " + item, "\n");
                Console.ReadKey();
            }
            
        }
    }
}
