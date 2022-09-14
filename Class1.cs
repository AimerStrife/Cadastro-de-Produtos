public class Fornecedor
{
    private int id;
    private string nome;
    private string cnpj;
    //private  Endereco endereco;

    //metodos construtor 1

    public Fornecedor()
    {
        this.id = 0;
        this.nome = "";
        this.cnpj = "";
    }
    //métodos construtor 2

    public Fornecedor(int par_id, string par_nome, string par_cnpj)
    {
        this.id = par_id;
        this.nome = par_nome;
        this.cnpj = par_cnpj;
    }



    //metodos - IO -  get / set

    public int getid()
    {
        return this.id; // atributo;
    }

    public void setid(int par_id)
    {
        this.id = par_id;
    }
    public string getnome()
    {
        return this.nome;
    }

    public void setnome(string par_nome)
    {
        this.nome = par_nome;
    }
    public string getcnpj()
    {
        return this.cnpj;
    }
    public void setcnpj(string par_cnpj)
    {
        { 
            this.cnpj = par_cnpj;

        }
    }
}