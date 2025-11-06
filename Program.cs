using exemplo_explorando.Models;
using Newtonsoft.Json;

// Pessoa p1 = new Pessoa(nome: "Renê", sobrenome: "Ferreira Dinis");
// Pessoa p2 = new Pessoa(nome: "Elza", sobrenome: "Ferreira Dinis");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionaAluno(p1);
// cursoDeIngles.AdicionaAluno(p2);
// cursoDeIngles.ListarAlunos();

// Colecoes colecoes = new Colecoes();
// colecoes.NumerosEmCascata();

// using Newtonsoft.Json;
// DateTime dataAtual = DateTime.Now;
// Vendas v1 = new Vendas(1, "teclado", 500.00M, dataAtual);
// string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);
// File.WriteAllText("Arquivos/vendas.json", serializado);
// Console.WriteLine(serializado);

// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");
// List<Vendas> listaVenda = JsonConvert.DeserializeObject<List<Vendas>>(conteudoArquivo);
// foreach (Vendas venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id}\nProduto: {venda.Produto}\nPreco: {venda.Preco}\nData: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
// }

// CCorrente cc = new CCorrente();
// cc.Creditar(200);
// cc.ExibirSaldo();

Calculadora cal = new Calculadora();
cal.divisao(1, 2);