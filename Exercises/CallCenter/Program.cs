using CallCenter;

Random random = new Random();

CallCente center = new CallCente();
int senha = 0;
do
{
    Console.Write("Digite s para pegar uma senha e n para parar");
    string? i = Console.ReadLine();

    if (i == "s")
    {
        senha ++;
        Console.WriteLine($"Sua senha é: {senha}");

        Thread.Sleep(3000);
        Console.WriteLine($"Chamando a senha: {senha}");

        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine()!;

        center.Call(random.Next(1000,9999), nome);
        while (center.AreWaitingCalls())
        {
            Thread.Sleep(3000);
            IncommingCall call = center.Answer("Thiago");
            Console.WriteLine(
                @$"{DateTime.Now:HH:mm:ss} 
            Chamado: #{call.Id}
            De: {call.ClientId}
            Nome: {call.Name}
            Atendido por: {call.Consultant}"
            );
            Thread.Sleep(random.Next(1000, 10000));
            center.End(call);
            Console.WriteLine(
                @$"Chamado: {call.Id}
            Encerrado às: {call.EndTime}"
            );
        }
    }
    else if (i == "n")
    {
        break;
    }
    else
    {
        Console.Write("Digite um Parâmetro válido");
    }

} while (true);
/*
while(center.AreWaitingCalls())
{
    Thread.Sleep(3000);
    IncomingCall call = center.Answer("Thiago");
    Console.WriteLine(
        @$"{DateTime.Now:HH:mm:ss} 
            Chamado: #{call.Id}
            De: {call.ClientId}
            Atendido por: {call.Consultant}"
    );
    Thread.Sleep(random.Next(1000, 10000));
    center.End(call);
    Console.WriteLine(
        @$"Chamado: {call.Id}
            Encerrado às: {call.EndTime}"
    );
}
*/
