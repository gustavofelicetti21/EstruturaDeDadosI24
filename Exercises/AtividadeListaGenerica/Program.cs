using AtividadeListaGenerica;

List<Livro> book = new List<Livro>();

int cont = 0;

do
{
    cont++;
    if (cont > 5) {
        Console.WriteLine("Digite a letra <a> para parar: ");
        string? str = Console.ReadLine();
        if (str == "a") {
            break;
        }
    }

    Console.WriteLine("Digite o Nome do livro: ");
    string? BookName = Console.ReadLine();
    Console.WriteLine("Digite A editora do livro: ");
    string? BookPublisher = Console.ReadLine();
    Console.WriteLine("Digite o Nome do Autor livro: ");
    string? BookAuthor = Console.ReadLine();
    Console.WriteLine("Digite a quantidade de páginas do livro: ");
    string? BookPages = Console.ReadLine();
    if (!int.TryParse(BookPages, out int number))
    {
        break;
    }

    book.Add(new Livro() {
    Name = BookName,
    Publisher = BookPublisher,
    Author = BookAuthor,
    Pages = number 
});
}
while (true);

int pag = 0;
int indice = 0;
for(int i = 0; i < book.Count; i++)
{
    if (book[i].Pages > pag) {
        indice = i;
        pag =   (int)book[i].Pages;
    }
}

Console.Write("O livro com maior páginas é:\n");
Console.Write($"Nome: {book[indice].Name}\n");
Console.Write($"Editora: {book[indice].Publisher}\n");
Console.Write($"Autor: {book[indice].Author}\n");
Console.Write($"Páginas: {book[indice].Pages}");