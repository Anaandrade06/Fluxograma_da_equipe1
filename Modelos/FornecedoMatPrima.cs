namespace Modelos;

public class Fornecedor_MateriaPrima
{
int Id_fORNECEDOR;
int Id_MateriaPrima;
public void SetId_fornecedor (int id)
{
    this.Id_fORNECEDOR =Id_fORNECEDOR;
}
public int GetId_fORNECEDOR()
{
    return Id_fORNECEDOR;
}
public void SetId_MateriaPrima (int idMateriaPrima)
{
    this.Id_MateriaPrima = idMateriaPrima; 
}
public int GetId_MateriaPrima ()
{
    return Id_MateriaPrima;
}
}
