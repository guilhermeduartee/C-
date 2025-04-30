﻿Console.WriteLine( "## Conversão de tipos ##\n");

int varInt = 100;
double varDouble = varInt;

//byte -> 1 byte
//short -> 2 bytes
//int -> 4 bytes
//long -> 8 bytes
//float -> 4 bytes
//double -> 8 bytes
//decimal -> 16 bytes

Console.WriteLine(varDouble);

int numeroInt = 2145678;
long numeroLong = numeroInt;
float numeroFloat = numeroInt;
double numeroDouble = numeroInt;
decimal numeroDecimal = numeroInt;

Console.WriteLine(numeroInt);
Console.WriteLine(numeroLong);
Console.WriteLine(numeroFloat);
Console.WriteLine(numeroDouble);
Console.WriteLine(numeroDecimal);


Console.WriteLine("## Conversão de tipos II ##\n");

int valorInt = 123;
double valorDouble = 12.45;
decimal valorDecimal = 12.45678m;

string s1 = valorInt.ToString();
string s2 = valorDouble.ToString();
string s3 = valorDecimal.ToString();


Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);


Console.WriteLine("## Conversão de tipos III ##\n");

int valorInt = 10;
double valorDouble = 5,35;
bool valorBool = true;

Console.WriteLine(Convert.ToString(valorInt);
Console.WriteLine(Convert.ToDouble(valorInt);
Console.WriteLine(Convert.ToString(valorBool);
Console.WriteLine(Convert.ToInt32(valorDouble);

int varInt = 100000;
Console.WriteLine(Convert.ToByte(varInt));
Console.WriteLine();

Console.ReadLine();