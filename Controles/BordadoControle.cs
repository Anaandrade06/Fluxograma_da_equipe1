using Modelos;

namespace Controles;

public class BordadoControle : BaseControle
{
  //----------------------------------------------------------------------------

  public BordadoControle() : base()
  {
    NomeDaTabela = "Bordado";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idBordado)
  {
    var collection = liteDB.GetCollection<Cliente>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idBordado);
  }

  //----------------------------------------------------------------------------

  public virtual List<Cliente>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Cliente>(NomeDaTabela);
    return new List<Cliente>(tabela.FindAll().OrderBy(d => d.Sobrenome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idCliente)
  {
    var collection = liteDB.GetCollection<Cliente>(NomeDaTabela);
    collection.Delete(idCliente);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Cliente cliente)
  {
    var collection = liteDB.GetCollection<Cliente>(NomeDaTabela);
    collection.Upsert(cliente);
  }

  //----------------------------------------------------------------------------
}