namespace Models
{


  public class Categoria
  {
    string ID_Categoria { get; set; }

    private string tipo { get; set; }

    public Categoria(string tipoCategoria)
    {
      this.tipo = tipoCategoria;
    }

  }



}

