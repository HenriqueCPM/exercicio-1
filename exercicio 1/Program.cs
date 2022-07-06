using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double notat, nota1, nota2, total, media;
            Console.WriteLine("Escreva o nome do aluno");
            Console.ReadLine();


         
            Console.WriteLine("Digite a Nota do Trabalho");
            notat = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a Nota da Pimeira Prova");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a Nota da Segunda Prova");
            nota2 = Convert.ToDouble(Console.ReadLine());

            total = notat + nota1 + nota2;
            media = total / 3;

            if (media >= 8.5)
            {
                Console.WriteLine("média final = " + media);
                Console.WriteLine("Conceito A");
            }
            else if (media >= 7)
            {
                Console.WriteLine("média final = " + media);
                Console.WriteLine("Conceito B");
            }
            else if (media >= 6)
            {
                Console.WriteLine("média final = " + media);
                Console.WriteLine("Conceito C");
            }
            else if (media >= 0.1)
            {
                Console.WriteLine("média final = " + media);
                Console.WriteLine("Conceito D");
            }
            else if (media >= 0.0)
            {
                Console.WriteLine("média final = " + media);
                Console.WriteLine("Conceito E");
            }
            Console.ReadKey();
        }
    }
    
}
