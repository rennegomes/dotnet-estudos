using exemplo_explorando.Models;

Pessoa p1 = new Pessoa(nome: "Renê", sobrenome: "Ferreira Dinis");
Pessoa p2 = new Pessoa(nome: "Elza", sobrenome: "Ferreira Dinis");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionaAluno(p1);
cursoDeIngles.AdicionaAluno(p2);
cursoDeIngles.ListarAlunos();

// Colecoes colecoes = new Colecoes();
// colecoes.NumerosEmCascata();

// using Newtonsoft.Json;
// Vendas v1 = new Vendas(1, "teclado", 500.00M);
// string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);
// Console.WriteLine(serializado);