public class Produto
{
    public int id;
    public string descricao;
    public string nome;
    public double valorCompra;
    public string categoria;
    public string unidade;
    public double lucro;
    public double precoVenda;

    public double PrecoVenda(double valorCompra, double lucro)
    {
        precoVenda = valorCompra + lucro;
        return precoVenda;
    }


}

