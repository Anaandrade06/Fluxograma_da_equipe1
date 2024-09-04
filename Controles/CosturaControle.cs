using Modelos;

namespace Controles;

public class CosturaControle : BaseControle
{
  //----------------------------------------------------------------------------

  public CosturaControle() : base()
  {
    NomeDaTabela = "Costura";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idCostura)
  {
    var collection = liteDB.GetCollection<Cliente>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idCostura);
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