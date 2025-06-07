using System.Threading;
using DesafioPOO.Models;


Console.WriteLine("Escolha o tipo de smartphone que deseja testar: \n 1 - Iphone \n 2 - Nokia");
int opcao = int.Parse(Console.ReadLine());

if (opcao == 1)
{
    Console.WriteLine("Digite o número do iPhone:");
    string numero = Console.ReadLine();

    Console.WriteLine("Digite o modelo do iPhone:");
    string modelo = Console.ReadLine();

    Console.WriteLine("Digite o IMEI do iPhone:");
    string imei = Console.ReadLine();

    Console.WriteLine("Digite a memória (em GB) do iPhone:");
    int memoria = int.Parse(Console.ReadLine());

    Smartphone iphone = new Iphone(numero, modelo, imei, memoria);

    Console.WriteLine("Configurando iPhone... \n Telefone: "
                     + iphone.Numero +
                      "\n Modelo: " + modelo +
                      "\n IMEI: " + imei +
                      "\n Memória: " + memoria + "GB");
    Thread.Sleep(1000);
    Console.WriteLine("Iniciando testes no iPhone...");
    Thread.Sleep(2000);
    iphone.Ligar();
    Thread.Sleep(2000);
    Console.WriteLine("Ligação realizada com sucesso!");
    Console.WriteLine("Agora qual o aplicativo que deseja instalar?");
    iphone.InstalarAplicativo(Console.ReadLine());
}
else if (opcao == 2)
{
    Console.WriteLine("Digite o número do Nokia:");
    string numero = Console.ReadLine();

    Console.WriteLine("Digite o modelo do Nokia:");
    string modelo = Console.ReadLine();

    Console.WriteLine("Digite o IMEI do Nokia:");
    string imei = Console.ReadLine();

    Console.WriteLine("Digite a memória (em GB) do Nokia:");
    int memoria = int.Parse(Console.ReadLine());

    Smartphone nokia = new Nokia(numero, modelo, imei, memoria);

    Console.WriteLine("Configurando Nokia... \n Telefone: "
                     + nokia.Numero +
                      "\n Modelo: " + modelo +
                      "\n IMEI: " + imei +
                      "\n Memória: " + memoria + "GB");
    Thread.Sleep(1000);
    Console.WriteLine("Iniciando testes no Nokia...");
    Thread.Sleep(2000);
    nokia.ReceberLigacao();
    Thread.Sleep(2000);
    Console.WriteLine("Ligação recebida com sucesso!");
    Console.WriteLine("Agora qual o aplicativo que deseja instalar?");
    nokia.InstalarAplicativo(Console.ReadLine());
}
else
{
    Console.WriteLine("Opção inválida. Por favor, escolha 1 ou 2.");
}