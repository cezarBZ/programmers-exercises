/* 1 - Desenvolva um algoritmo que calcule a idade média dos alunos de uma classe da faculdade, sabendo que o aluno mais novo tem 20 anos e o mais velho tem 50 anos, utilize a seguinte fórmula para calcular: MEDIA ALUNO = (IDADE MÍNIMA + IDADE MÁXIMA) / 2;*/

int idadeMediaAlunos, idadeMinima, idadeMaxima;
idadeMaxima = 50;
idadeMinima = 20;
idadeMediaAlunos = (idadeMinima + idadeMaxima) / 2;

Console.WriteLine($"A idade média dos alunos é {idadeMediaAlunos}");