/* 1 - Desenvolva um algoritmo que calcule a idade média dos alunos de uma classe da faculdade, sabendo que o aluno mais novo tem 20 anos e o mais velho tem 50 anos, utilize a seguinte fórmula para calcular: MEDIA ALUNO = (IDADE MÍNIMA + IDADE MÁXIMA) / 2;*/

int idadeMediaAlunos, idadeMinima, idadeMaxima;
idadeMaxima = 50;
idadeMinima = 20;
idadeMediaAlunos = (idadeMinima + idadeMaxima) / 2;
Console.WriteLine("Questão 1:");
Console.WriteLine($"A idade média dos alunos é {idadeMediaAlunos}");
Console.WriteLine('.');


/* 2 - Desenvolva um algoritmo que leia a cotação do euro converta para o Real e imprima o resultado;*/
Console.WriteLine("Questão 2");
var precoEuro = 5.26;
var compraDeEuro = 700;
var valorDaCompra = compraDeEuro * precoEuro;
Console.WriteLine($"Valor da compra: {valorDaCompra} reais");
Console.WriteLine('.');


/*3 - Desenvolva um algoritmo de comissão de vendas, um vendedor de carro vendeu 500 mil no mês de Maio, sabendo que a comissão dele é de 5% ao mês, qual será o valor que este vendedor receberá de comissão, calcule e imprima;*/
Console.WriteLine("Questão 3:");
var vendas = 500000;
var taxaDecomissao = 0.05;
var comissaoAReceber = vendas * taxaDecomissao;
Console.WriteLine($"O vendedor receberá de comissão: {comissaoAReceber}");
Console.WriteLine('.'); 


/* 4- Desenvolva um algoritmo para converter a temperatura em graus Celsius para Fahrenheit, a fórmula é F = (9 * C + 160) / 5;*/
Console.WriteLine("Questão 4:");
Console.WriteLine("Digite a temperatura em Celsius para ser convertida em Fahrenheit");
var grausCelsius = double.Parse(Console.ReadLine());
var celsiusParaFahrenheit = (9 * grausCelsius + 160) / 5;
Console.WriteLine($"O resultado é = {celsiusParaFahrenheit} F");
Console.WriteLine('.'); 


/* 5 - Desenvolva um algoritmo para converter a temperatura em graus Fahrenheit para Celsius, a fórmula é C = (F -32) *5 / 9;*/
Console.WriteLine("Questão 5:");
Console.WriteLine("Digite a temperatura em Fahrenheit para ser convertida em Celsius");
var grausFahrenheit = double.Parse(Console.ReadLine());
var fahrenheitParaCelsius = (grausFahrenheit - 32) * 5 / 9;
Console.WriteLine($"O resultado é: {fahrenheitParaCelsius} C");
Console.WriteLine('.');


/* 6 - Desenvolver  um  algoritmo  que  leia a  altura  de  um  homem  e  calcule  o  seu  peso  ideal,  utilize  a seguinte fórmula: PESO IDEAL = (72.7 * H) –58, onde H = altura.*/
Console.WriteLine("Questão 6:");
Console.WriteLine("Digite sua altura para calcular seu peso ideal:");
var altura = double.Parse(Console.ReadLine());
var pesoIdeal = (altura * 72.7) - 58;
Console.WriteLine($"Seu peso ideal é: {pesoIdeal}");
Console.WriteLine('.');

/* 7 - Desenvolver  um  algoritmo  que  leia quatro notas de  um  aluno,  calcular  a  média  e  imprimir. [OPCIONAL]: A  pontuação  deste  exercício  será  maior  para  quem  imprimir  se  o  aluno  for APROVADO ouREPROVADO;[CRITÉRIO APROVAÇÃO]: Média > 7*/
Console.WriteLine("Questão 7:");
Console.WriteLine("Digite as suas 4 notas:");
var nota1 = double.Parse(Console.ReadLine());
var nota2 = double.Parse(Console.ReadLine());
var nota3 = double.Parse(Console.ReadLine());
var nota4 = double.Parse(Console.ReadLine());
var media = (nota1 + nota2 + nota3 + nota4) / 4;

Console.WriteLine($"A sua média foi: {media}");

if(media >= 7)
    Console.WriteLine("Você foi aprovado");
else
    Console.WriteLine("Você foi reprovado");
Console.WriteLine('.');

/* 8 - Desenvolver um algoritmo que leia dois valores, A e B, utilizar operador aritmético de subtração e imprimir o total;[OPCIONAL]: Se o valor for negativo, imprimir TOTAL NEGATIVO senão TOTAL POSITIVO; */
Console.WriteLine("Questão 8:");
Console.WriteLine("Digite dois números para serem subtraidos");
var a = double.Parse(Console.ReadLine());
var b = double.Parse(Console.ReadLine());
var total = a - b;
Console.WriteLine($"O total é de: {total}");

if (total > 0)
    Console.WriteLine("Total positivo");
 else
    Console.WriteLine("Total negativo");
Console.WriteLine('.');

/* 9 - Desenvolver um algoritmo que leia dois valores, A e B, utilizar operador aritmético de divisão e modularização, ouseja, imprimir apenas o resto da divisão;[OPCIONAL]: Tratar divisão por 0*/
Console.WriteLine("Questão 9:");
Console.WriteLine("Digite dois números para serem divididos");
var A = double.Parse(Console.ReadLine());
var B = double.Parse(Console.ReadLine());
var resultado = A % B;

if (A <= 0 || B <= 0)
{
    Console.WriteLine("Digite números maiores que 0!!!");
    A = double.Parse(Console.ReadLine());
    B = double.Parse(Console.ReadLine());
    Console.WriteLine($"O resto da divisão é: {resultado}");
}
else
    Console.WriteLine($"O resto da divisão é: {resultado}");