using System;
using EstruturaDePrograma.Exemplos;

namespace EstruturaDePrograma
{
    class Program
    {
        static void Main()
        {
            var a = new Pilha();
            a.Empilha(1);
            a.Empilha(10);
            a.Empilha(100);
            Console.WriteLine(a.Desempilha());
            Console.WriteLine(a.Desempilha());
            Console.WriteLine(a.Desempilha());
        }
    }
}
