using System;
using System.Collections.Generic;

namespace myFirstApp
{
    internal class Program
    {
        private static void Main( /*string[] args*/)
        {
            //LA SYNTAXE GÉNÉRALE DU C#

            Console.WriteLine("Hello World"); // affiche Hello World

            var age = 20;
            Console.WriteLine(age); // affiche 20
            age = 30;
            Console.WriteLine(age); // affiche 30

            var unautreAge = 30;
            var unautreage = 20;
            Console.WriteLine(unautreAge); // affiche 30
            Console.WriteLine(unautreage); // affiche 20

            var prenom = "karim";
            Console.WriteLine(prenom); // affiche karim
            decimal soldeCompteBancaire = 100;
            Console.WriteLine(soldeCompteBancaire); // affiche 100
            var estVrai = true;
            Console.WriteLine(estVrai); // affiche true

            var resultat = 2*3;
            Console.WriteLine(resultat); // affiche 6

            var age1 = 20;
            var age2 = 30;
            var moyenne = (age1 + age2)/2;
            Console.WriteLine(moyenne); // affiche 25

            var codePostal = "2074";
            var ville = "Ben Arous";
            var adresse = codePostal + " " + ville;
            Console.WriteLine(adresse); // affiche : 2074 Ben Arous

            var age3 = 20;
            age3 = age3 + 10; // age contient 30 (addition)
            age3++; // age contient 31 (incrémentation de 1)
            age3--; // age contient 30 (décrémentation de 1)
            age3 += 10; // équivalent à age = age + 10 (age contient 40)
            age3 /= 2; // équivalent à age = age / 2 => (age contient 20)

            var phrase = "Mon prénom est \"Karim\"";
            Console.WriteLine(phrase);

            Console.WriteLine("Passe\nà\nla\nligne\n\n\n");

            var fichier = @"c:\repertoire\fichier.cs";
            Console.WriteLine(fichier); // contient : c:\repertoire\fichier.cs

            //LES INSTRUCTIONS CONDITIONNELLES
            decimal compteEnBanque = 300;
            //IF
            if (compteEnBanque >= 0)
                Console.WriteLine("Votre compte est créditeur");
            //IF ... ELSE
            compteEnBanque = -20;
            if (compteEnBanque >= 0)
                Console.WriteLine("Votre compte est créditeur");
            else
                Console.WriteLine("Votre compte est débiteur");
            //une autre méthode
            Console.WriteLine(compteEnBanque >= 0 ? "Votre compte est créditeur" : "Votre compte est débiteur");

            age = 30;
            var estAgeDe30Ans = age == 30;
            Console.WriteLine(estAgeDe30Ans); // affiche True
            var estSuperieurA10 = age > 10;
            Console.WriteLine(estSuperieurA10); // affiche True
            var estDifferentDe30 = age != 30;
            Console.WriteLine(estDifferentDe30); // affiche False

            estVrai = true;
            if (estVrai)
                Console.WriteLine("C'est vrai !");
            else
                Console.WriteLine("C'est faux !");

            var login = "Karim";
            var motDePasse = "test";
            if (login == "Karim" && motDePasse == "test")
                Console.WriteLine("Bienvenue Karim");
            else
                Console.WriteLine("Login incorrect");

            var civilite = "Mr";
            if (civilite == "Mme" || civilite == "Mlle")
                Console.WriteLine("Vous êtes une femme");
            else
                Console.WriteLine("Vous êtes un homme");
            //IF..ELSE IF ... ELSE
            var civilite1 = "M.";
            if (civilite1 == "Mme")
                Console.WriteLine("Vous êtes une femme");
            else if (civilite1 == "Mlle")
                Console.WriteLine("Vous êtes une femme non mariée");
            else if (civilite1 == "M.")
                Console.WriteLine("Vous êtes un homme");
            else
                Console.WriteLine("Je n'ai pas pu déterminer votre civilité");
            //SWITCH
            switch (civilite)
            {
                case "M.":
                    Console.WriteLine("Vous êtes un homme");
                    break;
                case "Mme":
                    Console.WriteLine("Vous êtes une femme");
                    break;
                default:
                    Console.WriteLine("Je n'ai pas pu déterminer votre civilité");
                    break;
            }

            //TABLEAUX, LISTES ET ÉNUMÉRATIONS
            string[] jours = {"Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche"};
            Console.WriteLine(jours[3]); // affiche Jeudi
            Console.WriteLine(jours[0]); // affiche Lundi
            Console.WriteLine(jours[10]); // provoque une erreur d'exécution car l'indice n'existe pas

            var jours1 = new string[7];
            jours1[0] = "Lundi";
            jours1[1] = "Mardi";
            jours1[2] = "Mercredi";
            jours1[3] = "Jeudi";
            jours1[4] = "Vendredi";
            jours1[5] = "Samedi";
            jours1[6] = "Dimanche";
            for (var i = 0; i < jours1.Length; i++)
            {
                Console.WriteLine(jours[i]);
            }

            var chiffres = new List<int>(); // création de la liste
            chiffres.Add(8); // chiffres contient 8
            chiffres.Add(9); // chiffres contient 8, 9
            chiffres.Add(4); // chiffres contient 8, 9, 4

            chiffres.RemoveAt(1); // chiffres contient 8, 4

            foreach (var chiffre in chiffres)
            {
                Console.WriteLine(chiffre);
            }

            var j = 0;
            while (j < 50)
            {
                Console.WriteLine("Bonjour C#");
                j++;
            }

            var k = 0;
            do
            {
                Console.WriteLine("Bonjour C#");
                k++;
            } while (k < 50);

            //Console.WriteLine("Veuillez saisir une phrase et valider avec la touche \"Entrée\"");
            //string saisie = Console.ReadLine();
            //Console.WriteLine("Vous avez saisi : " + saisie);

            //Console.WriteLine("Voulez-vous continuer (O/N) ?");
            //ConsoleKeyInfo saisie = Console.ReadKey(true);
            //if (saisie.Key == ConsoleKey.O)
            //{
            //    Console.WriteLine("On continue ...");
            //}
            //else
            //{
            //    Console.WriteLine("On s'arrête ...");
            //}
        }
    }
}