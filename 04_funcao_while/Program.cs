//Função em JavaScript 
//function nomeFuçao(nome){
    //}
    0 references
    class sesi
    {
        0 references
        public static void Main(){
            MostrarMensagem("Seja bem-vindo");
             MostrarMensagem("SESI/SENAI");
             ImprimirDataHora();
             ContagemRegressiva(10)
        }

    
        0 references
        public static double Potenciacao(int num){
            int resultado = Math.Pow(num,2);
            return resultado;
        }

        1 reference 
        public static void  ImprimirDataHora(){

            Console.Writeline(DateTime.Now.ToString());
        }

        2 references
        public static void MostrarMensagem(string mensagem)
        {
            Console.Writeline(mensagem)
        }


 
    public static void ContagemRegressiva(int n) //declarar "n" pode escrever qualquer coisa
{//while é enquanto
    while ( n >=0)
    {
        Console.Writeline(n);
        n--;
        System.Threading.Thread.Sleep(500);
    }
    Console.Writeline("BOOOOOOM");
}

public static void JogoQueNrSouEu()
{
    Console.Writeline("* * * * * * * * * * * * * * * ");
    Console.Writeline("  Bem vindo ao Jogo");
    Console.Writeline("Sorteei um nº de 1 a 20, tente adivinha-lo");
    Console.Writeline("* * * * * * * * * * * * * * * ");
    Console.Writeline("");//Linha em branco

    Random rnd = new Random();
    int nrSorteado = rnd.Next(20);
    int nrDigitado = -1;

    do{
        Console.Write("Digite um nº");  
        nrDigitado = int.Parse(Console.ReadLine());
        if (nrDigitado > nrSorteado)
        Console.Writeline("O numero digitado é MAIOR que o sorteado");
        else if (nrDigitado < nrSorteado)
        Console.Writeline("O numero digitado é MENOR que o sorteado ");
    }while(nrDigitado != nrSorteado);
    
    Console.Writeline("Parabens voce acertou ");
}

}