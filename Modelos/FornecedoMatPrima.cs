using LiteDB;

namespace Modelos;

public class Fornecedor_MateriaPrima : Registro
{
[BsonId]
public int Id_fornecedor {get; set;}

public int Id_MateriaPrima {get; set;}

}
