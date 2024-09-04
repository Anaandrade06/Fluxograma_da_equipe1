using Modelos;

namespace Controles;

public class EstoqueControle : BaseControle
{
  //----------------------------------------------------------------------------

  public EstoqueControle() : base()
  {
    NomeDaTabela = "Estoque";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idEstoque)
  {
    var collection = liteDB.GetCollection<Cliente>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idEstoque);
  }

  //---------------------------------------------------------------------------

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