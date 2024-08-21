internal class Program
{
    private static void Main(string[] args)
    {
        //trabalhando com lista (list)
        List<string> frutas = new List<string>();

        //Adicionar itens na Lista
        frutas.Add("Morango");
        frutas.Add("Manga");
        frutas.Add("Goiaba");
        frutas.Add("Uva");

        //imprimir os itens da lista
        Console.WriteLine("Minha lista de frutas:");
        frutas.ForEach(Console.WriteLine);

        Console.WriteLine(); // pula linha em branco

        //imprimir elemento na posição específica
        Console.WriteLine("Fruta no indice 2: " + frutas[2]);

        //inserir um elemento no indice específico
        frutas.Insert(1, "Maracujá");

        //imprimindo a lista novamente
        Console.WriteLine();

        Console.WriteLine("Minha lista de frutas: ");
        frutas.ForEach(Console.WriteLine);

        //alterar um elemento no indice especifico
        frutas[4] = "Pêra";
        Console.WriteLine();

        Console.WriteLine("Minha lista de frutas: ");
        frutas.ForEach(Console.WriteLine);

        //remover elementos da lista no indice especifico

        frutas.RemoveAt(3);

        //remover elementos pelo valor do conteudo
        frutas.Remove("Morango");

        //imprimindo a lista novamente 
        Console.WriteLine();

        Console.WriteLine("Minha lista de frutas: ");
        frutas.ForEach(Console.WriteLine);


        //Apagar todos os elementos
        frutas.Clear();
        Console.WriteLine();


        //criando um dicionario de dados

        Dictionary<int, string> carros = new Dictionary<int, string>();
        //Adicionar Dados a um dicionario 
        carros.Add(5, "Corsa");
        carros.Add(10, "Fusca");
        carros.Add(2, "Ford Ka");

        //Imprimindo um diconario de dados

        foreach (var carro in carros)
        {
            Console.WriteLine($"{carro.Key} - {carro.Value}");


        }
        //trabalhando com fila
        //criar uma fila (queue)
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        Queue<string> filaBranco = new Queue<string>();

        //adicionar elementos em uma fila

        filaBranco.Enqueue("André Balada");
        filaBranco.Enqueue("Adriano Imperardor");
        filaBranco.Enqueue("Mario Balotelli");
        filaBranco.Enqueue("Beckham");

        filaBranco.Dequeue();
        foreach (var pessoa in filaBranco)
        {
            Console.WriteLine(pessoa);
        }

        //verificar se existe um elemento na fila

        bool achou = filaBranco.Contains("André Balada");

        if (achou == true)
        {
            Console.WriteLine("A pessoa está na fila");
        }
        else
        {
            Console.WriteLine("A pessoa não está na fila");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        //trabalhando com pilha(STACK)
        Stack<string> livros = new Stack<string>();

        //adicionar elementos na pilha
        livros.Push("Chapeuzinho Vermelho");
        livros.Push("Branca de Neve");
        livros.Push("A princesa e o Sapo");

        foreach (var livro in livros)
        {
            Console.WriteLine(livro);
        }
        Console.WriteLine();
        Console.WriteLine();
        livros.Pop();
        foreach (var livro in livros) 
        {
            Console.WriteLine(livro);
            }

    }
}