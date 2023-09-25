using System.IO; //temos que importar o using para poder usar os metodos 

public class Program
{
    public static void Main()
    {
       //Gravararquivo();
       LerArquivo();
    }
    public static void LerArquivo()
    { 
        string CaminhoArquivo ="Arquivo/arquivo.txt";

        try{
        // Verificar se o arquivo existe
        if (File.Exists(CaminhoArquivo)== false)
        {
            //criando meu arquivo.txt,este comodo é executado  quando
            //a verificaçao no if é falsa ou seja o arquivo nao existe
            File.Create(CaminhoArquivo);
        }
            using (StreamReader arquivo = new StreamReader(CaminhoArquivo))
        {
            string linha;
            while ((linha = arquivo.ReadLine()) != null)
            {
                Console.WriteLine (linha);
            }
        }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro ao ler o arquivo {erro.Message}");
        }
        
    }


     public static void  Gravararquivo()
     {
         try
        { //estancia chamada arquivo posso colocar o nome q eu quiser esse true significa q eu quero gravar oq tem dentro do arquivo
         using (StreamWriter arquivo = new StreamWriter ("Arquivo/arquivo.txt", true))
         {
            Console.WriteLine("Digite uma informação para gravar no arquivo");
           arquivo.WriteLine(Console.ReadLine());
         }
        }
        catch (Exception erro)
        { 
            Console.WriteLine($"Ocorreu um erro ao gravar o arquivo:{erro.Message}");
        }

     }
    



}