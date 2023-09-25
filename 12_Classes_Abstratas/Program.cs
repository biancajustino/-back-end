//Classe pai que sera herdada pelo filho-Super classe
 abstract class Animal
{
    public string cor { get; set; }

    public  virtual void EmitirSom()
    {
        Console.Writeline("Animal emitindo som ");
    }
}
//Classe filha  quer herdara da classe animal
//Recebera todos os atributos e metodos SuperClasse
class Cachorro : Animal
{

    public string tipoPelo{ get; set; }
   public void Latir()
   {
    Console.Writeline($"O cachorro {cor} esta latindo");
   }
}

class Gato : Animal
{
 public  override void EmitirSom()
    {
        Console.Writeline("O gato esta miando");
    }
}

class Program
{
    static void Main()
    {
        //nao é permitido instanciar um objeto de uma classe abstrata
        //Animal animalGenerico = new Animal() ;
        //animalGenerico.EmitirSom();

 
     Cachorro meuCachorro = new Cachorro() ;
     meuCachorro.cor = " Caramelo";
     meuCachorro.EmitirSom();
     meuCachorro.Latir();

     Gato meuGato = new Gato();
     meuGato.EmitirSom();
    }
}

//Polimorfiso é a capacicade de sobresesctrver um metodo ex "virtual" qualquer classe que herdaer da classe pai pode
//modificar esse metodo