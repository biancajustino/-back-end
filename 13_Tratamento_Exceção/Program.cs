public class Program
{
    public static void Main()
    {
        try{
             int numero = int.Parse(Console.ReadLine());
             Console.WriteLine($"Voce digitou o nº {numero}");
             int resultado = 10 / numero;
             Console.WriteLine($"O resultado é: {resultado}");
        }
        //Tratando exceçao de overflow (estouro de campo)
        catch(OverFlowException){
            Console.WriteLine("Este numero inteiro é maior que o suportado");
        }
        //Tratando exceção de erro de formato
        catch (FormatException)
        {
            Console.WriteLine($"Erro:Digite um numero inteiro");
        }
        //Catch é o tratamento do erro,normalmente colocamos as mensagens de acordo com o tipo do erro,para melhorar a compreensao do usuario
        catch(Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro:{ex.Message}");
        }
        //O finally é um bloco executado indepedente se ocorrer erro ou nao
        finally
       {
        Console.WriteLine("Entrando no finally");
       }
        }
       
     }
