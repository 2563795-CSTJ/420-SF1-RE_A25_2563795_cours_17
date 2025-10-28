using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    internal class Program_Exercices
    {
        const bool EXERCICE_01 = true;

        static void Main(string[] args)
        {
            //Exercice 01
            if (EXERCICE_01)
            {
                string nomEtudiantSaisie = "";
                string noteEtudiantEntree = "";
                bool noteEtudiantValide;
                int noteEtidiantCorrect = 0;
                string facteurSaisie = "";
                bool facteurValide = false;
                double facteur = 0;
                List<string> nomEtudiant = new List<string>();
                List<double> noteEtudiant = new List<double>();
                List<double> noteNormaliser = new List<double>();
                Console.WriteLine("--- Normalisation de notes ---");
                do
                {
                    Console.Write("\nNom étudiant : ");
                    nomEtudiantSaisie = Console.ReadLine();
                    if (nomEtudiantSaisie != "")
                    {
                        nomEtudiant.Add($"{nomEtudiantSaisie}");
                        Console.Write("Note [0, 100] : ");
                        noteEtudiantEntree = Console.ReadLine();
                        noteEtudiantValide = int.TryParse(noteEtudiantEntree, out noteEtidiantCorrect);
                        noteEtudiant.Add(noteEtidiantCorrect);
                    }
                } while (nomEtudiantSaisie != "");
                while (!facteurValide)
                {
                    Console.Write("\nFacteur de normalisation : ");
                    facteurSaisie = Console.ReadLine();
                    facteurValide = double.TryParse(facteurSaisie, out facteur);
                }
                for (int i = 0; i < nomEtudiant.Count; i++)
                {
                    noteNormaliser.Add(noteEtudiant[i] + noteEtudiant[i] * facteur);
                    Console.WriteLine($"{nomEtudiant[i]} : {noteNormaliser[i]}");

                }
                //for (int i = 0; i < nomEtudiant.Count; i++)
                {
                    //Console.WriteLine($"{nomEtudiant[i + 1]} : {noteNormaliser}");
                }




            }
        }
    }
}
