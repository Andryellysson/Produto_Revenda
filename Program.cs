using System;

class aula06
{
    static void Main()
    {

        double ValorCompra;
        double ValorVenda;
        double Lucro = 0.2;
        string Produto = "Nutella";
        double qtdProduto = 15;
        double ValorPacotao = 30;

        ValorCompra = ValorPacotao / qtdProduto;
        ValorVenda = ValorCompra + (ValorCompra * Lucro);

        Console.WriteLine("Valor do Pacotão: {0:c}", ValorPacotao);
        Console.WriteLine("Quantidade de Pacotinhos: {0}", qtdProduto);
        Console.WriteLine("Produto: {0}", Produto);
        Console.WriteLine("Valor de cada produto: {0:c}", ValorCompra);
        Console.WriteLine("Lucro: {0:p}", Lucro);
        Console.WriteLine("Valor da Venda: {0:c}", ValorVenda);

    }
}