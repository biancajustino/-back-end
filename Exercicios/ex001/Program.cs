Console.Writeline("Digite a primeira nota da etapa do aluno ");
int nota1 = int.Parse(Console.ReadLine());
Console.Writeline("Digite a segunda  nota da etapa do aluno");
int nota2 = int.Parse(Console.ReadLine());
Console.Writeline("Digite a terceira nota da etapa do aluno");
int nota3 = int.Parse(Console.ReadLine());

int soma = nota1 + nota2 + nota3;
int media = soma / 3 ;


if (media >= 7)
{
    Console.Writeline($"O aluno foi Aprovado:)");
}
else
{
    Console.Writeline($" O aluno foi reprovado:(");
}