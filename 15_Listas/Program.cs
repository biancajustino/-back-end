using System.Collections.Generic;
using Sesi.Modls;

public class program
{
    public static void Main()
    {
        //Criando uma lista de inteiros 
    List<int> listaNumeros = new List<int>();

        //Adicionando elementos a lista 
        listaNumeros.Add(10); //posição [0]
        listaNumeros.Add(20); //posição [1]
        listaNumeros.Add(45); //posição [2]

        //Acessando os dados da lista pelo índice
        Console.WriteLine(listaNumeros[2]);

        //Contagem de elementos
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} elementos");

            listaNumeros.Add(55); //posição [3]
            Console.WriteLine($"Neste momento temos {listaNumeros.Count} elementos");
                 Console.WriteLine("########################");
            /////////////aqui ja nao é numero entao usamos string 
            
         List<string> listaNomes = new List<string>();

        listaNomes.Add("Bianca"); //posição [0]
        listaNomes.Add("Enzo"); //posição [1]
        listaNomes.Add("Ana"); //posição [2]
        Console.WriteLine(listaNomes[2]);
        Console.WriteLine($"Na lista tem {listaNomes.Count} nomes");
         Console.WriteLine("########################");

       //Criando uma lista de numeros ja atribuidos valores 
           List<int> numeros = new List<int> {1,2,5,6,8,9};
        Console.WriteLine($"Quantidade de elementos na lista de numeros:{numeros.Count}");
        numeros.Remove(2); //Remover o elemento 2
        numeros.RemoveAt(1); //Remover o elemnto no indice 1
       numeros.RemoveRange(2,2); //Remover 2 elementos a partir do indice 2

       //Substituindo informação do item da lista
       numeros[0] = 100;

       //Iterando sobre todos os itens da lista obs:mostra todos os itens da lista 
       foreach (int numero in numeros)
       {
        Console.WriteLine(numero);
       }

         foreach (string nome in listaNomes)
       {
        Console.WriteLine(nome);
       }

        //Criando uma lista com objetos da Classe Aluno
        List<Aluno> listaAlunos = new List<Aluno>();

        //Adicionado um novo aluno a minha linha 
     Aluno novoAluno = new Aluno ("Pedro",16);
        listaAlunos.Add(novoAluno);

        listaAlunos.Add(new Aluno("Patricia",17));
        listaAlunos.Add(new Aluno("Bob",17));

        //Exibindo lista de alunos
        Console.WriteLine("Lista Alunos:");
        foreach (Aluno item in listaAlunos )
        {
           Console.WriteLine($"Nome do aluno: {item.nome} tem {item.idade} anos ");
        }





        //LINQ utilizamos sintaxe de consulta
        var ordenacao = from aluno in listaAlunos
        where aluno.idade == 17
        orderby aluno.nome
        select aluno;

        foreach (var aluno in ordenacao)
        {
            Console.WriteLine(aluno.nome);
        }

        //Linq utilizamos Sintexe de metodo
         var consulta = listaAlunos
                        .Where(aluno => aluno.idade == 17)
                        .OrderBy(aluno => novoAluno.nome);
      foreach (var aluno in consulta)
      {
        Console.WriteLine(aluno.nome);
      }                  
    }

}
