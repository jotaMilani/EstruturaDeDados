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
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }
        Console.WriteLine(); // pula linha em branco

        //imprimir elemento na posição específica
        Console.WriteLine("Fruta no indice 2: " + frutas[2]);

        //inserir um elemento no indice específico
        frutas.Insert(1, "Maracujá");

        //imprimindo a lista novamente
        Console.WriteLine();

        Console.WriteLine("Minha lista de frutas: ");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }
        //alterar um elemento no indice especifico
        frutas[4] = "Pêra";
        Console.WriteLine();

        Console.WriteLine("Minha lista de frutas: ");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }
        //remover elementos da lista no indice especifico

        frutas.RemoveAt(3);

        //remover elementos pelo valor do conteudo
        frutas.Remove("Morango");

        //imprimindo a lista novamente 
        Console.WriteLine();

        Console.WriteLine("Minha lista de frutas: ");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        //Apagar todos os elementos
        frutas.Clear();
        Console.WriteLine();
        Console.WriteLine("Teste");

        frutas.ForEach(Console.WriteLine);
    }
}