namespace exemplo_explorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionaAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"----------------------------\n| Alunos do curso de {Nome} |\n----------------------------\n|                           |\n----------------------------");
            for (int i = 0; i < Alunos.Count; i++)
            {
                string mensagem = $"| {i + 1} | {Alunos[i].NomeCompleto} |\n----------------------------";
                Console.WriteLine(mensagem);
            }
        }
    }
}