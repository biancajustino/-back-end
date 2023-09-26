
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
// criando a classe TarefaController e herdando seus metodos de controller
public class TarefaController : Controller
{
    //Criando um objeto _Tarefas que armazenara uma lista de tarefas 
    private static List<Tarefa> _tarefas = new List<Tarefa>();

    public IActionResult Index()//Tela principal exbicao de todas as tarefas 
    {
        return View(_tarefas);
    }

    
        public IActionResult Adicionar()
        {
        return View();
    }

    [HttpPost]
    public IActionResult Adicionar (Tarefa novaTarefa)
    {
        //Verificando o total de tarefas da lista e somando maus 1 para criar Id
        novaTarefa.Id = _tarefas.Count + 1;
        //Adicionando minha nova tarefa a minha lista
        _tarefas.Add(novaTarefa);
        //Redirecionanando para a pagina principal com a lista de tarefas 
        return RedirectToAction("Index");

    }

  public IActionResult Editar(int Id)
  {
    //Estou buscando na minha lista a tarefa que desejo alterar
    Tarefa novaTarefa = _tarefas.FirstOrDefault(t => t.Id == Id);
    //Verificando se ela existe
    if (novaTarefa == null)
    return NotFound();

    return View(novaTarefa);
  }
[HttpPost]
public IActionResult Editar(Tarefa tarefaEditando)
{
        Tarefa tarefaEncontrada = _tarefas.FirstOrDefault(t => t.Id == tarefaEditando.Id);
        if(tarefaEncontrada ==  null)
        return NotFound();

        tarefaEncontrada.Descricao = tarefaEditando.Descricao;
         tarefaEncontrada.Concluida = tarefaEditando.Concluida;
         return RedirectToAction("Index");
}

 public IActionResult Deletar(int id)
  {
    //Estou buscando na minha lista a tarefa que desejo alterar
    Tarefa novaTarefa = _tarefas.FirstOrDefault(t => t.Id == id);
    //Verificando se ela existe
    if (novaTarefa == null)
    return NotFound();

    return View(novaTarefa);
  }

  [HttpPost]
public IActionResult DeletarConfirmado(int id)
{
        Tarefa tarefaEncontrada = _tarefas.FirstOrDefault(t => t.Id == id);
        if(tarefaEncontrada ==  null)
        return NotFound();

          _tarefas.Remove(tarefaEncontrada);
         return RedirectToAction("Index");
}

  

}


