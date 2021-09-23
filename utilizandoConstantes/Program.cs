using System;

//Contantes: não sofrem alteração durante a execução do codigo. 
//Este tipo de variavel é imultavel (não pode ser alterado)


namespace utilizandoConstantes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            const double Pi = 3.14159;
            double radius = 5.3;
            double area = Pi * (radius * radius);

            Console.Write("O valor da área é: " + area);
            Console.ReadLine();
        }
    }
}
