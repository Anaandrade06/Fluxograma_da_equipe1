using LiteDB;

namespace Modelos;
public class Fornecedor : Registro
{
   [BsonId]
    public int Id { get; set;}
    
    private string CNPj { get; set;}
   
    public  string Cidade {get; set;}
    
     public string MateriaPrima {get; set;}
 }
