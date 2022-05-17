/* 8 - Desenvolver um algoritmo que leia dois valores, A e B, utilizar operador aritmético de subtração e imprimir o total;[OPCIONAL]: Se o valor for negativo, imprimir TOTAL NEGATIVO senão TOTAL POSITIVO; */

Console.WriteLine("Digite dois números para serem subtraidos");
var a = double.Parse(Console.ReadLine());
var b = double.Parse(Console.ReadLine());
var total = a - b;
Console.WriteLine($"O total é : {total}");

if (total > 0)
    Console.WriteLine("Total positivo");
else
    Console.WriteLine("Total negativo");