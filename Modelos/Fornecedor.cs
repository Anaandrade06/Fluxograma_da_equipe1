namespace Modelos;
public class Fornecedor
{
    int Id;
    string CNPJ;
    string Cidade;
    string MateriaPrima;
    
    public void  SetId( int Id)
    { 
     this.Id = Id;
    }
    public int GetId()
    {
        return Id; 
    }
    private void SetCNPJ( string CNPJ)
     {
    
     this.CNPJ = CNPJ;

     }
     private string GetCNPJ ()
     {
        return CNPJ;
     }
    public void SetCidade( string Cidade )
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
