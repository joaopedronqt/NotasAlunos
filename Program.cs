using System;
using System.Globalization;

namespace AvaliacaoAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();    

            Aluno alu = new Aluno();

            Console.Write("Nome do aluno: ");
            alu.Nome = Console.ReadLine();
            System.Console.WriteLine("Digite as três notas do aluno");
            alu.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            alu.Nota2 = double .Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            alu.Nota3 = double .Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.WriteLine("NOTA FINAL: " + alu.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
           
            if (alu.Aprovado()) 
            {
            Console.WriteLine("APROVADO");
            } 
            else
            {
                System.Console.WriteLine("REPROVADO");
                System.Console.WriteLine("FALTARAM " + alu.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " pontos");
            }


        }
    }
}