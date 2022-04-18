using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjudaProfessor.classes
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Media { get; set; }
        public bool Aprovado { get; set; }

        public double CalculaMedia(double nota1, double nota2)
        {
            var Media = ((nota1 + nota2) / 2);
            if (Media > 0 && Media < 10)
            {
                Media = Math.Truncate(Media * 100) / 100;
                return Media;
            }
            else
            {
                throw new ArgumentException("Média fora de escala!");
            }
        }
        public (string, int) AvaliaMedia(double media)
        {
            int val = (int)media;
            if (media > 6)
            {
                return ("Parabéns, você passou", val);
            }
            else if (media > 4 && media < 6)
            {
                return ("Aluno está de recuperação", val);
            }
            else
            {
                return ("Aluno reprovado!", val);
            }
        }
        public bool Passou(double media)
        {
            bool aprovado;
            if (media > 6)
            {
                aprovado = true ;
            }
            else
            {
                aprovado = false;
            }
            return aprovado;
        }
    }
}