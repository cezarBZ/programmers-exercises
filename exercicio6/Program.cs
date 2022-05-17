/* 6 - Desenvolver  um  algoritmo  que  leia a  altura  de  um  homem  e  calcule  o  seu  peso  ideal,  utilize  a seguinte fórmula: PESO IDEAL = (72.7 * H) –58, onde H = altura.*/

Console.WriteLine("Digite sua altura para calcular seu peso ideal:");
var altura = double.Parse(Console.ReadLine());
var pesoIdeal = (altura * 72.7) - 58;
Console.WriteLine($"Seu peso ideal é: {pesoIdeal.ToString("F")}");
