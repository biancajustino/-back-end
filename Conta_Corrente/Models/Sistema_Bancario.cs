namespace Models
{
    //Representando uma conta Bancaria:
    public class ContaCorrente
    {
        //atributos da nossa classe Bancaria
        private string titular { get; set; }
        private double saldo { get; set; }

        public ContaCorrente(string titularConta, int saldoConta)
        {
            this.titular = titularConta;
            this.saldo = saldoConta;
        }

        //Metodo da classe Conta Corrente
        public void ConsultarSaldo()  //Exibe na tela o saldo disponivel na conta
        {
            Console.WriteLine($"Seu saldo disponivel é de R${saldo}");
        }

        public void Depositar(double valor) //Realiza um deposito na conta com o valor especificado.O valor do deposito devera
                                            //ser maior que {zero}
        {
            if (valor < 0)
            {
                
                Console.WriteLine("Valor de saldo invalido");
            }
            else
            {
                saldo = saldo + valor;
                Console.WriteLine ($"Seu saldo de ${valor} foi depositado");
            }
        }


        public void Sacar(double valor) //Realize um saque  da conta com o valor especifico
                            //O valor deve ser maior que zero e nao pode exceder o saldo disponivel    
        {

            if (saldo >= valor)
            
                saldo -= valor;
            else
            {
                Console.WriteLine("Valor do saque inregular");
            }

        }

    }

}



