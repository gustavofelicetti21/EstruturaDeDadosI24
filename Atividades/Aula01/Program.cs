using Aula01;

// Comentário de uma linha

/*
    Comentário de
    Múltiplas linhas
*/

// Declarando variável

int number;

// Atribuindo valor
number = 10;

// Declarando contante
const int DAYS_IN_WEEK = 7;

// Imprimindo String concatenada
Console.WriteLine($"A semana tem {DAYS_IN_WEEK} dias.");

// new TipoEnumerador() -> Invoca o método construtor do objeto
// Toda classe tem o seu contrutor padrão implícito sem argumentos/params
// É possível sobreescrever este método especificado argumentos
// Todavia, se o fizermos, perdemos o original implícito e
// precisaremos defini-lo explicitamente
TipoEnumerador tipoEnum = new TipoEnumerador();
TipoEnumerador.Language enumEnglish = tipoEnum.GetLanguageEnum("inglês");
Console.WriteLine($"O enum de english é {enumEnglish}");
