using System.Xml;
using AtividadeHash;

Product produto = new Product();

Dictionary<Product, string> dicProduct = new Dictionary<Product, string>();

dicProduct.Add(
    new Product()
    {
        Code = "ABC123",
        Name = "Condicionador",
        Value = 25.99
    }, "A1"
);

dicProduct.Add(
    new Product()
    {
        Code = "BCD123",
        Name = "Shampoo",
        Value = 25.99
    }, "A1"
);

dicProduct.Add(
    new Product()
    {
        Code = "CDE123",
        Name = "Sabonete",
        Value = 3.99
    }, "A1"
);

dicProduct.Add(
    new Product()
    {
        Code = "DEF123",
        Name = "Escova de Dente",
        Value = 15.99
    }, "A1"
);

dicProduct.Add(
    new Product()
    {
        Code = "EFG123",
        Name = "Creme Dental",
        Value = 11.99
    }, "A1"
);

dicProduct.Add(
    new Product()
    {
        Code = "JKL456",
        Name = "Detergente",
        Value = 5.99
    }, "B8"
);

dicProduct.Add(
    new Product()
    {
        Code = "KLM456",
        Name = "Sabão em Pó",
        Value = 23.99
    }, "B8"
);

dicProduct.Add(
    new Product()
    {
        Code = "LMN456",
        Name = "Amaciante",
        Value = 30.99
    }, "B8"
);

dicProduct.Add(
    new Product()
    {
        Code = "MNO456",
        Name = "Sabonete Líquido",
        Value = 10.99
    }, "B8"
);

dicProduct.Add(
    new Product()
    {
        Code = "NOP456",
        Name = "Esponja",
        Value = 15.99
    }, "B8"
);

dicProduct.Add(
    new Product()
    {
        Code = "STU789",
        Name = "Arroz",
        Value = 25.99
    }, "C2"
);

dicProduct.Add(
    new Product()
    {
        Code = "TUV789",
        Name = "Feijão",
        Value = 20.99
    }, "C2"
);

dicProduct.Add(
    new Product()
    {
        Code = "UVW789",
        Name = "Frango",
        Value = 99.99
    }, "C2"
);

dicProduct.Add(
    new Product()
    {
        Code = "VWX789",
        Name = "Porco",
        Value = 150.99
    }, "C2"
);

dicProduct.Add(
    new Product()
    {
        Code = "WXY789",
        Name = "Gado",
        Value = 200.99
    }, "C2"
);

dicProduct.Add(
    new Product()
    {
        Code = "XYZ789",
        Name = "Macarrão",
        Value = 10.99
    }, "C4"
);

dicProduct.Add(
    new Product()
    {
        Code = "XZA789",
        Name = "Ovo",
        Value = 7.99
    }, "C4"
);

dicProduct.Add(
    new Product()
    {
        Code = "ZAB789",
        Name = "Brócolis",
        Value = 8.99
    }, "C4"
);

dicProduct.Add(
    new Product()
    {
        Code = "GHI789",
        Name = "Batata",
        Value = 22.99
    }, "C4"
);

dicProduct.Add(
    new Product()
    {
        Code = "HIJ789",
        Name = "Maçã",
        Value = 22.99
    }, "C4"
);


do
{
    foreach (KeyValuePair<Product, string> kvp in dicProduct)
    {

        Console.Write($@"
    Products:
    Code: {kvp.Key.Code}
    Name: {kvp.Key.Name}
    Value: {kvp.Key.Value}
    ");
    }

    Console.WriteLine("Digite o código do produto que deseja saber a prateleira(sair para parar): ");
    string code = Console.ReadLine()!;

    string cd = code.ToUpper();

    if (cd == "sair")
    {
        break;
    }

    bool flag = true;
    foreach (KeyValuePair<Product, string> kvp in dicProduct)
    {
        if (kvp.Key.Code == cd) {
            Console.WriteLine($"Seu produto está na prateleira: {kvp.Value}");
            flag = false;
        }
    };

    if (flag==true) {
        Console.WriteLine("Seu código é inválido!");
    }
    Thread.Sleep(3000);

    Console.WriteLine("Digite 1 para continuar");
    string? saida = Console.ReadLine();

    if (saida == "1")
    {

    }
    else 
    {
        break;
    }
} while (true);
