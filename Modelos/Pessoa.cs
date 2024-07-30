namespace Modelos;

public class Pessoa
{
string nome;
string cpf; 
string telefone;
string email;
public void SetNome (string nome)
{
    this.nome = nome;
}
public string GetNome ()
{
    return nome;
}
public void SetCpf (string Cpf)
{
    this.cpf = Cpf;
} 
public string GetCpf ()
{
    return cpf;
} 
public void Settelefone (string telefone)
{
    this.telefone =telefone;
}
public string Gettelefone ()
{
    return telefone;
}
public void Setemail (string email)
{
    this.email = email;
}
public string Getemail ()
{
    return email;
}
}