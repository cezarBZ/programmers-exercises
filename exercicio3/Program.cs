/*3 - Desenvolva um algoritmo de comissão de vendas, um vendedor de carro vendeu 500 mil no mês de Maio, sabendo que a comissão dele é de 5% ao mês, qual será o valor que este vendedor receberá de comissão, calcule e imprima;*/

var vendas = 500000;
var taxaDecomissao = 0.05;
var comissaoAReceber = vendas * taxaDecomissao;
Console.WriteLine($"O vendedor receberá comissão de: {comissaoAReceber}");
