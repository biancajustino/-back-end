
Console.Writeline("Digite o numero do mes");
int mes=int.Parse(Console.ReadLine());
switch (Mes)
{
    case 1:
    Console.Writeline("Janeiro com 31 dias ");
    break;
    case 2:
    Console.Writeline("Fevereiro com 28 ou 29 dias ");
    break;
     case 3:
    Console.Writeline("Março com 31 dias");
    break;
     case 4:
    Console.Writeline("Abril com 30 dias ");
    break;
     case 5:
    Console.Writeline("Maio com 31 dias ");
    break;
     case 6:
    Console.Writeline("Junho com 30 dias");
    break;
case 7:
    Console.Writeline("Julho com 31 dias");
    break;
case 8:
    Console.Writeline("Agosto com 31 dias");
    break;
case 9:
    Console.Writeline("Setembro com 30 dias");
    break;

case 10:
    Console.Writeline("Outubro com 30 dias");
    break;


case 11:
    Console.Writeline("Novembro com 30 dias");
    break;

case 12:
    Console.Writeline("Dezembro com 31 dias");
    break;
    default:
    Consale.Writeline("Dia invalido");
      break;
}
