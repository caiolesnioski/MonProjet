using System;
using System.Collections.Generic;
using System.Linq;

main {

public class Etudiant
{
    private string.nom ;
    private int.age ;
    private int.note ;
}
List<Notes> note = new List<Notes>();
Disionary<string,int,int> Etudiants = new Dictionary<string,int,int>();
Console.WriteLine("Pour addicionner un etudiant, veuillez saisir son nom, son age et sa note");
Console.WriteLine("saisir un nom :");

    string nom = Console.ReadLine();
    
Console.WriteLine("saisir une note :");

    double average = Console.ReadLine.average();

Console.WriteLine("la moyenne est : " + average);




Console.WriteLine("saisir un age :");

    int age = int.Parse(Console.ReadLine());

Console.WriteLine("saisir une note :");

    int note = int.Parse(Console.ReadLine());

Etudiants.Add(nom, age, note);

Console.WriteLine("saisir le nom de l'étudiant à chercher :");
string ChercherEtudiant = Console.ReadLine();
if (Etudiants.ContainsKey(ChercherEtudiant));
{
    Console.WriteLine("l'étudiant existe");
}
else
{
    Console.WriteLine("l'étudiant n'existe pas ou vous avais mal saisi le nom");
}
}