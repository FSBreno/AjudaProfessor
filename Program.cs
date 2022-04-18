using System;

namespace AjudaProfessor
{
    class Program
    {
        public void Main()
        {
            // Boas VIndas ao Ajuda Professor
            Console.WriteLine("Bem Vindo ao Ajuda Professor!");

            bool Continua = false;
            // Coletando informações do aluno
            do
            {
                    Console.WriteLine("Digite o nome do aluno:");
                    string Nome = Console.ReadLine();
                    Console.WriteLine("Digite o número da matrícula do aluno:");
                    string Matricula = Console.ReadLine();
                    Console.WriteLine("Digite a primeira nota do aluno(Use ','):");
                    if (!double.TryParse(Console.ReadLine(), out var Nota1)) return;
                    Console.WriteLine("Digite a segunda nota do aluno(Use ','):");
                    if (!double.TryParse(Console.ReadLine(), out var Nota2)) return;
                    Console.WriteLine("Você informou:");
                    Console.WriteLine(Nome);
                    Console.WriteLine(Matricula);
                    Console.WriteLine(Nota1);
                    Console.WriteLine(Nota2);
                    Console.WriteLine("Está correto?(Digite 1 = Sim ou 0 = Não):");
                    Continua = Convert.ToBoolean(Convert.ToInt16(Console.ReadLine()));
            } while (Continua);
        }
    }
}   
