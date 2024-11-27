using System.Data.Common;
using AtividadeArvoreBasica;
using CompanyTree;

Tree<Person> company = new Tree<Person>();
company.Root = new Node<Person>()
{
    Data = new Person("Marcim Jamro", 69, "CEO")
};
company.Root.Children =
    new List<Node<Person>>{
        new Node<Person>() {
            Data = new Person("Jhon Smith", 59, "Head Of Development"), Parent = company.Root
        },
        new Node<Person>() {
            Data = new Person("Mary Fox", 47, "Head Of Research"), Parent = company.Root
        },
        new Node<Person>() {
            Data = new Person("Lyly Smith", 49, "Head Of Sales"), Parent = company.Root
        }
    };

Node<Person> chris = new Node<Person>() { Data = new Person("Chris Morris", 40, "Senior Developer"), Parent = company.Root.Children[0]};
Node<Person> eric = new Node<Person>() { Data = new Person("Eric Green", 20, "Junior Developer"), Parent = chris};
Node<Person> ashley = new Node<Person>() { Data = new Person("Ashley Lopez", 25, "Junior Developer"), Parent = chris};

chris.Children!.Add(eric);
chris.Children.Add(ashley);

company.Root.Children[0].Children!.Add(chris);

Node<Person> emily = new Node<Person>() { Data = new Person("Emily Young", 18, "Intern Developer"), Parent = ashley};
ashley.Children!.Add(emily);

Node<Person> jimmy = new Node<Person>() { Data = new Person("Jimmy Stewart", 40, "Senior Researcher"), Parent = company.Root.Children[1]};
Node<Person> andy = new Node<Person>() { Data = new Person("Andy Wood", 38, "Senior Researcher"), Parent = company.Root.Children[1]};

company.Root.Children[1].Children!.Add(jimmy);
company.Root.Children[1].Children!.Add(andy);

Node<Person> anthony = new Node<Person>() { Data = new Person("Anthony Black", 45, "Senior Sales Specialist"), Parent = company.Root.Children[2]};
Node<Person> angela = new Node<Person>() { Data = new Person("Angela Evans", 40, "Senior Sales Specialist"), Parent = company.Root.Children[2]};
Node<Person> tommy = new Node<Person>() { Data = new Person("Tommy Buttler", 39, "Senior Account Manager"), Parent = company.Root.Children[2]};
Node<Person> paula = new Node<Person>() { Data = new Person("Paula Scott", 20, "Junior Sales Specialist"), Parent = anthony};
Node<Person> sarah = new Node<Person>() { Data = new Person("Sarah Watson", 25, "Junior Sales Specialist"), Parent = anthony};

anthony.Children!.Add(paula);
anthony.Children.Add(sarah);

company.Root.Children[2].Children!.Add(anthony);
company.Root.Children[2].Children!.Add(angela);
company.Root.Children[2].Children!.Add(tommy);

company.PrintTree(company.Root);