namespace Models
{
    public class Pessoas
    {
        //atributos da nossa classe Pessoa
        private string nome MyProperty { get; set; }
        private  int idade MyProperty { get; set; }

        private string email MyProperty { get; set; }


        
         //Metodo construtor da classe pessoa
         public Pessoa (string nomePessoa, int idadePessoa, string emailPessoa)
         {
            this.nome = nomePessoa;
            this.idade = idadePessoa;
            this.email = emailPessoa;
           this.anoNascimento = DateTime.Now.Year - idadePessoa;
         }

      //Metodo da classe Pessoa
      public void Cantar()
      {
        Console.Writeline($"{nome} esta cantando");
      }

      public void Descricao()
      {
        Console.Writeline($"{nome} tem {idade} e nasceu no ano {anoNascimento}.Seu e-mail é {email}")
      }
    }
}