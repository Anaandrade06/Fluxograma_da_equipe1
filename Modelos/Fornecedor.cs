namespace Modelos 
{
public class Fornecedor
{
    int id;
    string CNPJ;
    string Cidade;
    string MateriaPrima;
    } 
    public void  SetId ( int Id)
    { 
     this.id = Id;
    }
    public int GetId()
    {
        return id; 
    }
    private void SetCNPJ ( string CNPJ)
     {
    
     this.CNPJ = CNPJ;

     }
     private string GetCNPJ ()
     {
        return CNP;
     }
    public void SetCidade ( string Cidade )
     {
     this.Cidade = Cidade;
     }
     public string GetCidade()
     { 
        return Cidade;
     }
     public void SetMateriaPrima ( string MateriaPrima)
     { 
        this.MateriaPrima = MateriaPrima;
     }
     public string GetMateriaPrima()
     {
        return MateriaPrima;
     }
 }
