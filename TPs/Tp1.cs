using System;

Console.WriteLine("saisir un nombre :");
int nombre = int.Parse(Console.ReadLine());

Console.WriteLine("saisir encore un nombre :");
int nombre2 = int.Parse(Console.ReadLine());

Console.WriteLine("saisir encore un nombre :");
int nombre3 = int.Parse(Console.ReadLine());

int [] MonTableau = {
    nombre,
    nombre2,
    nombre3
};

int total = MonTableau .Sum();
doble average = MonTableau.Average();
Console.WriteLine("la somme est : " + total);
Console.WriteLine("la moyenne est : " + average);

Console.WriteLine("saisir un nombre :");
int nombre4 = int.Parse(Console.ReadLine());

if (nombre4 / 2 == 0)
{
    Console.WriteLine("le nombre est pair");
}
else
{
    Console.WriteLine("le nombre est impair");
}

console.WriteLine("saisir deux nombres :");

int nombre5 = int.Parse(Console.ReadLine());
int nombre6 = int.Parse(Console.ReadLine());

console.WriteLine("Et une opération : (+, -, *, /)")

char operation = Convert.To{char}(Console.ReadLine());

switch (operation)
{
    case "+":
        Console.WriteLine("la somme est : " + (nombre5 + nombre6));
        break;
    case "-":
        Console.WriteLine("la soustraction est : " + (nombre5 - nombre6));
        break;
    case "*":
        Console.WriteLine("la multiplication est : " + (nombre5 * nombre6));
        break;
    case "/":
        if (nombre6 != 0)
        {
            Console.WriteLine("la division est : " + (nombre5 / nombre6));
        }
        else
        {
            Console.WriteLine("division par zéro n'est pas autorisée");
        }
        break;
    default:
        Console.WriteLine("opération non valide");
        break;
}

Console.WriteLine("regardez le nombre de Fibonacci :");
int n;
int a = 0;
int b = 1;
int c;

for (int i = 0; i < n; i++)
{
    Console.WriteLine(a);
    c = a + b;
    a = b;
    b = c;
}
Console.WriteLine("Combien de nombres s'affichent ?");
n = int.Parse(Console.ReadLine());

Console.WriteLine("saisir un nombre :");
int nombre7 = int.Parse(Console.ReadLine());

if (nombre7 / 1 )||(nombre7 / nombre7)
{
    Console.WriteLine("le nombre est premier");
}
else
{
    Console.WriteLine("le nombre n'est pas premier");
}

















