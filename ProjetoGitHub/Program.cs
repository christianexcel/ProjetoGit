namespace ProjetoGitHub;
class Program
{
    public static void Main(string[] args)
    {
        Produto produto = new Produto();
        produto.Id = 1;
        produto.Descricao = "Teclado";

        Console.WriteLine($"Produto: {produto.Descricao}");
    }
}