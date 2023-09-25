namespace Models
{

  public class Produto
  {
    private string nome { get; set; }
    private int valor { get; set; }

    private string foto { get; set; }

    private string descricao { get; set; }

    public string ID_Produto { get; set; }

    public Produto(string nomeProduto, int valorProduto, string fotoProduto, string descricaoProduto)
    {
      this.nome = nomeProduto;
      this.valor = valorProduto;
      this.descricao = descricaoProduto;
    }

  }


}