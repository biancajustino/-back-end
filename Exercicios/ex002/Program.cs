Console.Writeline("Escreva o numero da sua placa");
string placa = Console.ReadLine();


string digito = placa.Substring(placa.Length-1, 1);

Console.Writeline("O final é {digito} " );



if (digito == "1" ||  digito == "2")
{
    Console.Writeline($"O carro podera transitar so na segunda");
}
else if (digito == "3" ||  digito == "4")
{
    Console.Writeline($"O carro podera transitar so na terca");
}


else if (digito == "5" ||  digito == "6")
{
    Console.Writeline($"O carro podera transitar so na quarta");
}

else if (digito == "7" ||  digito == "8")
{
    Console.Writeline($"O carro podera transitar so na quinta");
}

else if (digito == "9" ||  digito == "0")
{
    Console.Writeline($"O carro podera transitar so na sexta");
}
else
{
    Console.Writeline($" Carro nao podera transitar ");
}




