using System;

//Enums: Palavra chave no C# usada para declarar uma enumerção. Pode se dizer que é uma estrutura de dados.
//Um tipo destinto que consiste de diversas constantes dentro de uma lista.
//É uma forma de garantir que o programador utilize os padrões que voce definiu.
//Programadores utilizam para garantir que não havera alteração do valor durante execulão do sistema

namespace conhecendoEnums
{
    class Program
    {
        //criando estrutura enum
        enum DiasUteisDaSemana
        {
            Domingo = 0,
            SegundaFeira = 1,
            TercaFeira = 2,
            QuartaFeria = 3,
            QuintaFeira = 4,
            SextaFeria = 5,
            Sabado = 6
        };


        static void Main(string[] args)
        {

            var diaDaSemana = DiasUteisDaSemana.SegundaFeira;
            int diaDasemana2 = (int)DiasUteisDaSemana.SegundaFeira;

            Console.WriteLine("Hoje é dia: " + diaDaSemana);
            Console.WriteLine("e seu valor é: " + diaDasemana2);
            Console.Read();
            

        }
    }
}
