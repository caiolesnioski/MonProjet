
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





