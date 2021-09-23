using System;

//Entendendo o que sao namespace: Forma que o .Net Framework utiliza para organizar os seus projeto.
//Sao formas logicas de se separar o seu software.
//Note que nesse projeto , a class Program está dentro do namespace AcademiaDontNet.CursoCSharp
//No outro projeto que criamos, AcademiaDontNet.CursoCSharp2 também há a class Program, porém, está dentro do namespace AcademiaDontNet.CursoCSharp2.
//Sendo assim, não há nenhum problema em trabalhar com ambos assim. 

namespace AcademiaDotNet.CursoCSharp.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

