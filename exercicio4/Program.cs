/* 4- Desenvolva um algoritmo para converter a temperatura em graus Celsius para Fahrenheit, a fórmula é F = (9 * C + 160) / 5;*/

Console.WriteLine("Digite a temperatura em Celsius para ser convertida em Fahrenheit");
var grausCelsius = double.Parse(Console.ReadLine());
var celsiusParaFahrenheit = (9 * grausCelsius + 160) / 5;
Console.WriteLine($"O resultado é = {celsiusParaFahrenheit} F");
