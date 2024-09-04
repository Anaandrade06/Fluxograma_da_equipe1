using Modelos;

namespace Controles;

public class ForneceMateriaPrimadorControle : BaseControle
{
  //----------------------------------------------------------------------------

  public ForneceMateriaPrimadorControle() : base()
  {
    NomeDaTabela = "FornecedorMateriaPrima";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idFornecedorMateriaPrima)
  {
    var collection = liteDB.GetCollection<Cliente>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idFornecedorMateriaPrima);
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