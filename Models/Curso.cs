using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        //Método
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");

            //Incluindo uma numeracao na frente do nome (codigo refatorado), para este caso utilizar o for
            for (int count = 0; count < Alunos.Count; count++)
            {
                //string texto = "N°" + count + " - " + Alunos[count].NomeCompleto;
                // Interpolação de strings, utiliza do $ antes da primeira "
                string texto = $"N° {count + 1} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            }

            // foreach (Pessoa aluno in Alunos)
            // {
            //     Console.WriteLine(aluno.NomeCompleto);
            // }
        }
    }
}