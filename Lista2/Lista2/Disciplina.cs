using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    class Disciplina
    {
        private string nome;
        private double media;
        private Dictionary<Aluno, List<double>> notasAlunos;

        public Disciplina(string nome, double media){
            this.nome = nome;
            this.media = media;
            notasAlunos = new Dictionary<Aluno, List<double>>();
        }

        public Dictionary<Aluno, List<double>> NotasAlunos
        {
            get { return notasAlunos; }
        }

       public void adicionarNota(Aluno aluno, List<double> nota)
        {
            notasAlunos[aluno] = nota;
        }

        public void verAprovação(Aluno aluno)
        {
            double notasTotal = 0;
            int ctg = 0;
            for (int i = 0; i < notasAlunos.Count; i++)
            {
                if(notasAlunos.ContainsKey(aluno))
                {
                    foreach (var nota in notasAlunos[aluno])
                    {
                        notasTotal += nota;
                        ctg++;
                    }
                }
            }

            if(ctg == 4)
            {
                double mediaLocal = notasTotal / 4;
                if(mediaLocal > media){
                    Console.WriteLine("O aluno {0} foi REPROVADO com {1} de media", aluno.nome, mediaLocal);
                }
                else {
                    Console.WriteLine("O aluno {0} foi REPROVADO com {1} de media", aluno.nome, mediaLocal);
                }
            }
            else{
                Console.WriteLine("O aluno não possui notas suficientes");
            }
        }
    }
}
