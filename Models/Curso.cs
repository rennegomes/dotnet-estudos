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
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine($"| {aluno.NomeCompleto} |\n----------------------------");
            }
        }
    }
}