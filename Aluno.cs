using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    internal class Aluno
    {
       
        public string Nome { get; set;}
        public string Curso { get; set; }
        public Aluno(string nome, string curso)
        {
            Nome = nome;
            Curso = curso;
        }
        public static List<Aluno> listaAlunos = new List<Aluno>();
        public static void OrdenarAlunos()
        {
            int distancia = listaAlunos.Count;
            bool troca = true;
            while (distancia > 1 || troca)
            {
                if (distancia > 1)
                {
                    distancia = (int)(distancia / 1.3);
                }
                int i = 0;
                troca = false;
                while (i + distancia < listaAlunos.Count)
                {
                    if (listaAlunos[i].Nome.CompareTo(listaAlunos[i + distancia].Nome) > 0)
                    {
                        Aluno aux = listaAlunos[i];
                        listaAlunos[i] = listaAlunos[i + distancia];
                        listaAlunos[i + distancia] = aux;
                        troca = true;
                    }
                    i++;
                }
            }
        }
    }
}
