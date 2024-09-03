using LiteDB;

namespace Modelos;
public class Produto : Registro
{
     
  public string Nome {get; set;}
  public string Quantidade {get; set;}
    
  [BsonId]
  public int Id_Produto {get; set;}
}