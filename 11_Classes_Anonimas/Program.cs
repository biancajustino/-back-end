public class Program
{
    public static void Main()
    {
        //Criando uma classe anonima (classe sem definição)
        var pessoa1 = new {
            nome = "Joao",
            idade = 17
        };
        var pessoa2 = new {
            nome = "Maria",
            email = "maria@aluno.senai.br",
        };
        Console.Writeline($"A pessoa1 é {pessoa1.nome} e tem {pessoa1.idade} anos");
          Console.Writeline($"A pessoa2 é {pessoa2.nome} e tem o email {pessoa2.email} anos");
        //pessoa1.nome = "Douglas";

        //Criar 2 objetos de classe anonima de Carro 
         var carro1 = new {
            nome = "Hilux",
            modelo = "Preta"
            ano = 2023
         };

       var carro2 = new {
        marca = "Audi",
        modelo = "prata"
        ano = 2022
       }

   Console.Writeline($"O carro{carro1.marca}, modelo {carro1.modelo}  e é do ano {carro1.ano} e da marca {carro1.marca}");
     Console.Writeline($"O carro{carro2.marca}, modelo {carro1.modelo}  é do ano {carro2.ano} e da marca {carro2.marca}");

    }
}
