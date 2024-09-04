using Modelos;

namespace Controles;

public class CorteControle : BaseControle
{
  //----------------------------------------------------------------------------

  public CorteControle() : base()
  {
    NomeDaTabela = "Coerte";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idCorte)
  {
    var collection = liteDB.GetCollection<Cliente>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idCorte);
  }

  //----------------------------------------------------------------------------
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