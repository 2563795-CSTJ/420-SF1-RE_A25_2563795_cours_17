using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace théorie
{
    // Hugo Gariépy
    // 2025/10/28
    // list et tableau 2 dimension
    internal class Program_cours_19
    {
        static void Main(string[] args)
        {
            // List
            string[] nomJoueurs = new string[4] { "Fred", "Bob", "Alice", "Carlos" };
            // OOR : nomJoueurs[4] = "Nouveua nom";
            // existe pas , nomJoueurs.Add("nouveau nom");
            // Bref, tableau = taille fixe

            // Solution : List 
            // List<type> nomListeAvecUnS = new List<type>();
            // List<type> nomListeAvecUnS = new List<type>() {valeur1, valeur2 ,...};
            List<string> nomDesJoueurs = new List<string>();
            List<double> montantJoueurs = new List<double>() { 100, 100, 100, 100 };

            // Ajout
            nomDesJoueurs.Add("nouveau joueur");
            // en mémoire: [], si plein, sa taille double 

            // Suppression
            nomDesJoueurs.RemoveAt(0); //(index)
            nomDesJoueurs.Remove("Bob"); // (element à enlever) ; selon le type ("Fred"), (1), (true)
            nomDesJoueurs.Clear(); // Enlève tout, mais Conserve la taille en mémoire

            // Itération
            List<string> matiere = new List<string>() { "intro prog", "physique", "philo", "Stats" };
            for (int i = 0; i < matiere.Count; i++)
            {
                string nom = matiere[i];
                Console.WriteLine($"Matière {i + 1} : {nom}");
            }

            //tableaux 2D
            // Problèmes: représenter données à desu dimensions
            // ex: jeu d'échec, connect4, matrices, calendrier, sudoku, tic-tac-toe
            // plusieurs données par joueur: 4 joueurs de bowling ont chacun 10 manches chacun...
            const int NOMBRE_LIGNE = 3;
            const int NOMBRE_COLONE = 3;
            int[,] ticTacToeValeurs = new int[NOMBRE_LIGNE, NOMBRE_COLONE]
            {
                {0,1,0 },
                {2,1,0 },
                {2,1,0 }
            };

            //Itération
            for (int ligne = 0; ligne<NOMBRE_LIGNE; ligne++)
            {
                for(int colone = 0; colone<NOMBRE_COLONE;colone++)
                {
                    Console.Write($"{ticTacToeValeurs[ligne, colone]}");
                }
                Console.WriteLine();
            }

            // modifier
            ticTacToeValeurs[0, 0] = 2;

            // Bref:
            // tableau 1D, 2D :données avec taille prédéfinie
            //      on choisit la dimention selon la représentation (jeu 2D, matrice...)
            // List: structure la p^lus utilisée (90% du temps) et versatile, taille variable

            // Exemple:
            List<string> nomEtudiants = new List<string>() { "Fred", "Alain" };

            // Ajoutons des notes: 
            List<double> noteEtudiant = new List<double>();

            for(int i = 0; i < nomEtudiants.Count; i++)
            {
                Console.Write($"{i} - Veuillez entrer la note pour {nomEtudiants[i]}: ");
                double note = double.Parse(Console.ReadLine());
                noteEtudiant.Add(note);
            }

            // Affichons les notes des étudiants:
            //c'est possible d'itérer sur 2 liste dans le même for
            // mais attention: leur TAILLE doivent être identique**
            for (int i = 0; i < nomEtudiants.Count; i++)
            {
                Console.WriteLine($"{nomEtudiants[i]} a obtenu {noteEtudiant[i]}%");
            }
        }
    }
}
