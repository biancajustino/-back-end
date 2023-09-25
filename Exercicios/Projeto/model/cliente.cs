namespace Models
{

    public class Cliente
    {
        private string nome { get; set; }
        private string email { get; set; }

        private int Cpf { get; set; }

        private int telefone { get; set; }

        private string endereço { get; set; }

        private int senha { get; set; }

        public string ID_Cliente { get; set; }


        public Cliente(string nomeCliente, string endereçoCliente, string emailCliente, int cpfCliente, int senhaCliente, int telefoneCliente)
        {
            this.nome = nomeCliente;
            this.email = emailCliente;
            this.endereço = endereçoCliente;
            this.Cpf = cpfCliente;
            this.senha = senhaCliente;
            this.telefone = telefoneCliente;

        }
    }
}