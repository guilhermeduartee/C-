﻿Console.WriteLine("## Inferência Tipos (var) ##\n");

var idade = 25;
var nome = "Maria";
var salario = 2500.00m;

Console.WriteLine($"{nome} tem {idade} anos e ganha {salario.ToString("c")}");

//var limitações
var salario = null;
var titulo;
var salario, imposto, total;

//não posso mudar o tipo apos inicialização
var num = 10;
num = num + 20;
num = "Teste";

var teste = new();

Console.ReadKey();


Console.ReadLine();
