/* 7 - Desenvolver  um  algoritmo  que  leia quatro notas de  um  aluno,  calcular  a  média  e  imprimir. [OPCIONAL]: A  pontuação  deste  exercício  será  maior  para  quem  imprimir  se  o  aluno  for APROVADO ouREPROVADO;[CRITÉRIO APROVAÇÃO]: Média > 7*/

Console.WriteLine("Digite as suas 4 notas:");
var nota1 = double.Parse(Console.ReadLine());
var nota2 = double.Parse(Console.ReadLine());
var nota3 = double.Parse(Console.ReadLine());
var nota4 = double.Parse(Console.ReadLine());
var media = (nota1 + nota2 + nota3 + nota4) / 4;

Console.WriteLine($"A sua média foi: {media}");

if (media >= 7)
    Console.WriteLine("Você foi aprovado");
else
    Console.WriteLine("Você foi reprovado");