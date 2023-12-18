using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048_WF
{
    public partial class Form1 : Form
    {
        static int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void board_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Titre de la fenêtre
            Console.Title = "2048 Game";

            // Créer un tableau à 2 dimensions
            int[,] board = new int[4, 4];

            //Initialise le tableau avec 2 chiffres aléatoires
            for (int start = 0; start < 2; start++)
            {
                //AddNewNumber(board);
            }

            // Boucle principale du jeu
            while (true)
            {
                // Afficher la grille 4x4
                DisplayBoard(board);

                // Obtenir la touche pressée
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                ConsoleKey key = keyInfo.Key;

                // Sauvegarde le tableau actuel dans une variable
                int[,] previousBoard = (int[,])board.Clone();

                switch (key)
                {
                    case ConsoleKey.RightArrow:
                        //MoveRight(board);
                        break;

                    case ConsoleKey.LeftArrow:
                        //MoveLeft(board);
                        break;

                    case ConsoleKey.UpArrow:
                        //MoveUp(board);
                        break;

                    case ConsoleKey.DownArrow:
                        //MoveDown(board);
                        break;

                    default:
                        Console.WriteLine("Tu dois appuyer sur les flèches directionnelles");
                        break;
                }
                // Verifie si le tableau a changé
                if (!BoardEqual(previousBoard, board))
                {
                    //AddNewNumber(board); // Ajoute un nombre si le tableau a changé
                }
                //Lose(board);
                //Win(board);
            }
        }

        // Fonction qui verifie si 2 tableaux sont les mêmes
        static bool BoardEqual(int[,] board1, int[,] board2)
        {
            for (int row = 0; row < board1.GetLength(0); row++)
            {
                for (int col = 0; col < board1.GetLength(1); col++)
                {
                    if (board1[row, col] != board2[row, col])
                    {
                        return false;
                    }
                }
            }
            return true;
        }


        // Fonction pour afficher la grille 4x4
        static void DisplayBoard(int[,] board)
        {
            Console.Clear();

            Console.Write("-------------------------------");
            Console.Write("\n---------- 2048 Game ----------");
            Console.Write("\n-------------------------------\n\n\n");

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)

                Console.WriteLine("\n\n");
            }
            Console.WriteLine("\nScore : " + score);
        }

        // Fonction pour avoir la couleur en fonction de la valeur de la case
        static ConsoleColor GetColor(int value)
        {
            switch (value)
            {
                case 0: return ConsoleColor.White;
                case 2: return ConsoleColor.White;
                case 4: return ConsoleColor.Gray;
                case 8: return ConsoleColor.DarkGray;
                case 16: return ConsoleColor.Yellow;
                case 32: return ConsoleColor.DarkYellow;
                case 64: return ConsoleColor.Red;
                case 128: return ConsoleColor.DarkRed;
                case 256: return ConsoleColor.Magenta;
                case 512: return ConsoleColor.DarkMagenta;
                case 1024: return ConsoleColor.DarkBlue;
                case 2048: return ConsoleColor.Blue;
                default: return ConsoleColor.Blue;
            }
        }
    }
}
