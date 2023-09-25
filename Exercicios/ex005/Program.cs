using System.Xml.Schema;

class exe005
{
    public static void Main()
    {
        ListaDoChurrasco();
        //SonhosDeConsumo = ();
    }

    public static void ListaDoChurrasco()
    {
        string[] itens = new string[6];
       
        for (int i = 0; i < 6; i++)
        {
            Console.Writeline("Digite a quantidade e os produtos para o churrasco");
            string produto = Console.ReadLine();
            itens[i] = produto;
        }

        Array.Sort(itens);

        foreach (string item in itens){
            Console.Writeline(item);
        }
    }




    public static void ListaSonhos()
    {
        string[] sonhos = new string[3];
        decimal[] valor = new decimal[3];

        for(int i = 0; i < 3; i++){
            Console.Writeline($"Informe o seu {i}° sonho")
            string sonho = Console.ReadLine();
             Console.Writeline($"Informe o seu {i}° sonho")
             decimal valores = decimal.Parse(Console.ReadLine());
             sonhos[i] = sonho;
             valores [i] = valor;
        }

        foreach(decimal val in valores)
        {
            total = total + val;
        }

Console.Writeline($"Seus sonhos custarão aprox.${total}");
    }

