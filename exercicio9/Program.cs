/* 9 - Desenvolver um algoritmo que leia dois valores, A e B, utilizar operador aritmético de divisão e modularização, ouseja, imprimir apenas o resto da divisão;[OPCIONAL]: Tratar divisão por 0*/

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