namespace exemplo_explorando.Models
{
    public class Colecoes
    {
            List<string> numeros = new List<string>();
            Stack<string> pilha = new Stack<string>();
        
        public void NumerosEmCascata()
        {
            numeros.Add("2");
            numeros.Add("4");
            numeros.Add("6");
            numeros.Add("8");

            foreach (var item in numeros)
            {
                pilha.Push(item);
                Console.WriteLine(string.Join("", pilha));
            }

            while (pilha.Count > 1)
            {
                pilha.Pop();
                Console.WriteLine(string.Join("", pilha));
            }
        }        

    }
}