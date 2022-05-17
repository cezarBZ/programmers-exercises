/* 5 - Desenvolva um algoritmo para converter a temperatura em graus Fahrenheit para Celsius, a fórmula é C = (F -32) *5 / 9;*/

Console.WriteLine("Digite a temperatura em Fahrenheit para ser convertida em Celsius");
var grausFahrenheit = double.Parse(Console.ReadLine());
var fahrenheitParaCelsius = (grausFahrenheit - 32) * 5 / 9;
Console.WriteLine($"O resultado é: {fahrenheitParaCelsius} C");


