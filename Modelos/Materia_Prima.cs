using System.Runtime.CompilerServices;

namespace Modelos;

public class Materia_Prima
{
string nome; 
int quantidade; 
int Id_MateriaPrima;
public void SetNome (string Nome)
{
this.nome = Nome;
}
public string GetNome()
{ 
    return nome;
}
public void SetQuantidade (int quantidade)
{
this.quantidade = quantidade;
}
public int GetQuantidade()
{
    return quantidade;
}
public void  SetId_MateriaPrima (int Id_MateriaPrima)
{
    this.Id_MateriaPrima =Id_MateriaPrima;
}
public int GetId_MateriaPrima()
{
    return Id_MateriaPrima;
}



}