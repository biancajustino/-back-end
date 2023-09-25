using Models

public class Program
{
    public static void Main()
    {
       //Criando um objeto da Classe Pessoa
        //Instanciando sem um metodo construtor
       Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "Bianca";
        pessoa1.idade = 16;
        pessoa1.Cantar ();


       //Alternativa para criançao de um objeto  sem contrutor
        pessoa1 pessoa2 = new Pessoa();{
            pessoa1.nome = "Riacardo";
            idade = 22
        };
        pessoa2.Cantar ();
        */
        Pessoa pessoa1 = new Pessoa("Bianca" , 16 "justinobianca255@gmail.com");
        pessoa1.Cantar();
        pessoa1.Descricao();



        Pessoa pessoa2 = new Pessoa("Ricardo" , 34 "ricardodias@docente.senai.br");
        pessoa2.Cantar();
        pessoa2.Descricao();

    }
}