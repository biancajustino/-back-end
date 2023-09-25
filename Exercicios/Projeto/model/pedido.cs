namespace Models
{

    public class Pedido
    {
        private string nome { get; set; }
        private int valor { get; set; }
        private decimal quantidade { get; set; }

        public string ID_Pedido { get; set; }

        public Pedido(string nomePedido, int valorPedido, decimal quatidadePedido,)
        {
            this.nome = nomePedido;
            this.valor = valorPedido;
            this.quantidade = quatidadePedido;
        }
    }

}