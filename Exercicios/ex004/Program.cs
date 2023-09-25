class senai{
    public static void Main() {
        int divisoes = Divisao( int.Parse(Console.ReadLine()));
        Console.Writeline($"divisão {divisoes}");

         int multiplicacao = int.Parse(Console.ReadLine());
        double valor = Multiplicacao(multiplicacao);
        Console.Writeline($"O dobro do {valor}");
    }

     public static int Divisao(int num)
    {
        int resultado = num/2;
        return resultado;
    }

    public static double Multiplicacao(int num)
    {
        double resultado = num*2;
        return resultado;
    }
}


public static void Tabuada ( int numero)
    {
        int contador =1;
        while (contador <= 10)
{
    Console.Writeline($"1 x {numero} - { contacontador * numero} ");
    contador++
}
0   }

public static void ResumoSalarios()
{
    int SomaSalarios = 0;
    int menorSalario =100000;
    int maiorSalario = 0;
    int salarioEmpregado=0;

     do{
        Console.Writeline("Digite o salario do empregado");,
        salarioEmpregado = int.Parse(Console.ReadLine());
    
    somaSalarios= somaSalarios + salarioEmpregado;
    //sommaSalarios += salarioEmpregado
    if (salarioEmpregado > maiorSalario){
        maiorSalario = salarioEmpregado;
    }
if(salarioEmpregado < menorSalario)
menorSalario = salarioEmpregado;

     }while(salarioEmpregado > 0);
     



}