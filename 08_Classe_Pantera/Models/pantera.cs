using Models;

 public class Pantera
 {
    public decimal tamanho { get; set; }
    public int peso { get; set;}

    public string cor { get; set;}

     public  string especie{ get; set;}

     public string alimentaçao { get; set;}



     public void Correr(){
        Console.Writeline("A pantera esta correndo ");
     }

public void Caçar(){
        Console.Writeline("A pantera esta caçando");

     }
     public void Reproduzir(){
        Console.Writeline("A pantera esta se reproduzindo ");
     }
 }