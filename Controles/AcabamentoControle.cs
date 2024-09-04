using Modelos;

namespace Controles;

public class AcabamentoControle : BaseControle
{
  //----------------------------------------------------------------------------

  public AcabamentoControle() : base()
  {
    NomeDaTabela = "Acabamentos";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idAcabamentos)
  {
    var collection = liteDB.GetCollection<Cliente>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idAcabamentos);
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