using Models;

public class Program
{


    public static void Main()
    {
        //Console.Clear();
        Console.WriteLine("$e$i Conta");
        Console.WriteLine("--------------------");
        Console.WriteLine("Bem-Vindo ao sistema");

        Menu();
    }

    public static void Menu()
    {
        string opcao = "";

        ContaCorrente conta = new ContaCorrente("Bianca", 0);

        do
        {
            Console.WriteLine("Opçoes que $e$i-Conta Oferece ");
            Console.WriteLine("1 - Consultar saldo");
            Console.WriteLine("2 - Depositar");
            Console.WriteLine("3 - Sacar ");
            Console.WriteLine("4 - Para fechar o sistema");
            opcao = Console.ReadLine();
            //Console.Clear();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("");
                    conta.ConsultarSaldo();
                    break;
                case "2":
                    Console.WriteLine("Deposite o valor escolhido");
                    double valor = double.Parse(Console.ReadLine());
                    conta.Depositar(valor);
                    //Depositar valor;
                    break;
                case "3":
                    Console.WriteLine("Digite o valor que deseja sacar");
                    double valorSaque = double.Parse(Console.ReadLine());
                    conta.Sacar(valorSaque);

                    break;
                case "4":
                    Console.WriteLine("Volte sempre!!!");
                    Console.WriteLine("                       ");
                    System.Threading.Thread.Sleep(1000);
                    break;

            }

        } while (opcao != "4");

    }














}
