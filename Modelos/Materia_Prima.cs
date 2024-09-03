using System.Runtime.CompilerServices;
using LiteDB;

namespace Modelos;

public class Materia_Prima :Registro
{
public string Nome { get; set;}
public string Quantidade {get; set;}
[BsonId]
public int Id_MateriaPrima {get; set;}
}