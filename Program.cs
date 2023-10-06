/*
condicionales
> < >= <= != == !
operadores 
|| &&



*/

string nombre = "Alex";
int edad = 16;

if (edad >= 18)
{
    Console.WriteLine(nombre + " ya puedes manejar");
}
else
{
    int anios = 18 - edad;
    Console.WriteLine(nombre + " te faltan " + anios + " años para poder manejar");
    Console.WriteLine($"{nombre} te faltan {anios} años para poder manejar");
}


char num = '8';
int num2 = 56; //Mirar codigo ASCII

if (num==num2)
{
Console.WriteLine("Son iguales");
}else
{
    Console.WriteLine("Son diferentes");
}