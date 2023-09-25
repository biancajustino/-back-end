Console.Writeline("Digite o valor de x");
int x = int.Parse(Console.ReadLine());
Console.Writeline("Digite o valor de y:");
int y = int.Parse(Console.ReadLine());

//Exemplos de operadores aritmeticos 
int soma = x + y;
int subtracao = x - y;
int multiplicacao = x * y;
int divisao = x / y;
int resto = x % y;
int restoYDiv2 = x % 2;// Cauculando o resto da divisao de x / 2

//Console para dividir na tela as variaveis de cada em cada linha 
// Soma: 15
Console.Writeline($"Soma:{soma}");
Console.Writeline("Subtracao: " + subtracao);
Console.Writeline("Multiplicação: " + multiplicacao);
Console.Writeline("Divisão: " + divisao);
Console.Writeline("Resto: " + resto);

if (restoDiv2 == 0)
{
    Console.Writeline($"O número{x} é par");
}
else
{
    Console.Writeline($"O número{x} é impar");
}
//Operador ternario
// Condição? se verdade : senão
string resultado = "(restoYDiv2 == 0)"? $" O numero {x} é par": $" O numero {x} é impar"; 
Console.Writeline(resultado);

int diaSemana = 3;
//Aprendendo  o switch Case
switch (diaSemana)
{
    case 1:
    Console.Writeline("Hoje é domingo!");
    break;
    case 2:
    Console.Writeline("Hoje é segunda!");
    break;
     case 3:
    Console.Writeline("Hoje é terça!");
    break;
     case 4:
    Console.Writeline("Hoje é quarta!");
    break;
     case 5:
    Console.Writeline("Hoje é quinta!");
    break;
     case 6:
    Console.Writeline("Hoje é sabado!");
    break;
    default:
    Consale.Writeline("Dia invalido");
      break;
}