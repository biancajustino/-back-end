class Program
{

 public string [] poltronas = new string [43];

public static void Main()
{
    Console.Clear();
    Console.Writeline("Bem-Vindo ao SesiBus");
    Console.Writeline("--------------------");
    Console.Writeline("Contamos com 42 lugares disponiveis ");

    Menu();
}

public static void Menu()	
{
    string opcao = "";

    do{
        Console.Writeline("########## MENU ############");
        Console.Writeline("1-Para comprar passagem");
        Console.Writeline("2 - Para poltronas disponiveis");
        Console.Writeline("0 - Para fechar o sistema");
        opcao = Console.ReadLine();
        Console.Clear();
    
         switch(opcao){
            case "0": 
            Console.Writeline("Obrigado,volte sempre!!!");
            System.Threading.Thread.Sleep(1000); //Espera de 1s

            break;
        case "1":
        
            break;
            case "2":
            PoltronasDisponiveis();

         break;
         default:
         Console.Writeline("Opção invalida");
         break;

            }

 } while (opcao != "0")

}
public static void ComprarPassagem()
{
    Console.Writeline("Quantas passagens deseja comprar?");
    int nrPassagens = int.Parse(Console.ReadLine());

    for (int i = 1; i <= nrPassagens;)
    {
        Console.Writeline($"Digite a poltrona da {i}ª passagem");
        int nrPoltrona = int.Parse(Console.ReadLine());
        Console.Writeline("Informe o nome do passageiro");
        string nome = Console.ReadLine();
        MarcarPoltrona(nrPoltrona, nome);                                                                                                                                                                                                                                   
    }
}
public static void MarcarPoltrona(int nrPoltrona, string nome){
    poltronas[nrPoltrona] = nome;
}

public static void PoltronasDisponiveis()
{
    Console.Writeline("Lista de poltronas disponiveis");
    for (int i = 1; 1 <= 42; i++){
        if (Poltronas[i] == null){
            Console.Writeline($"N° {i}");
        }
    }
}

}