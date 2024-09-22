// Criando um vetor multidimensional, com 5 linhas e 2 colunas

int[,] numbers = new int [5,2];

// Criando um vetor tridimensional
int[,,] triNumbers = new int [5,4,3];

// Podemos inicializar os valores do vetor no momento de sua declaração
int[,] iniNumbers = new int[,]
{
    {9,15,-90},
    {19,25,-91},
    {29,35,-92},
    {39,45,-93},
    {49,55,-94}
};

// Para acessar os valores contidos neste tipo de variável

int valor = iniNumbers[0,1]; // Neste caso = 15

Console.WriteLine($"iniNumbers[0,1] == {valor}");

int maior = 0;
int posI = 0 , posJ = 0;

for (int i=0; i<5; i++) 
{
    for (int j=0; j<3;j ++) 
    {
        if (iniNumbers[i,j] > maior) 
        {
            maior = iniNumbers[i,j];
            posI = i;
            posJ = j;
        }
    }
}

Console.WriteLine($"O maior valor de iniNumbers é: {maior}, na posição [{posI},{posJ}]");