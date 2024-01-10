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
        static Random random = new Random();
        static int[,] board = new int[4, 4];
        static bool win = false;

        Label[,] lbl = new Label[4, 4]; //tableau de Labels 4 lignes et 4 colonnes

        public Form1()
        {
            InitializeComponent();
            InitializeJeu();
            KeyDown += Form1_KeyDown;
        }

        private void InitializeJeu()
        {
            // Initialisation des coulours perso
            Color formBackgroundColor = Color.FromArgb(255, 27, 11, 37);
            Color lblScorePersoColor = Color.FromArgb(255, 27, 20, 50);
            Color gameBackgroundColor = Color.FromArgb(255, 27, 20, 50);

            // Création des labels
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    lbl[row, col] = new Label(); //Création du label

                    // le 20 + 100 * colonne détermine où placer le premier label dans le form en X
                    // le 20 + 100 * ligne détermine où placer le label en Y
                    // le 90, 90 est la taille du label
                    lbl[row, col].Bounds = new Rectangle(20 + 100 * col, 120 + 100 * row, 90, 90);

                    // met le texte au milieu du label
                    lbl[row, col].TextAlign = ContentAlignment.MiddleCenter;
                    lbl[row, col].Font = new Font("Arial", 20);

                    Controls.Add(lbl[row, col]); //Ajout visible à la page
                }
            }

            //Initialise le tableau avec 2 chiffres aléatoires
            for (int start = 0; start < 2; start++)
            {
                AddNewNumber();
                DisplayBoard();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Sauvegarde le tableau actuel dans une variable
            int[,] previousBoard = (int[,])board.Clone();

            switch (e.KeyCode)
            {
                case Keys.Right:
                    MoveRight();
                    break;

                case Keys.Left:
                    MoveLeft();
                    break;

                case Keys.Up:
                    MoveUp();
                    break;

                case Keys.Down:
                    MoveDown();
                    break;

                default:
                    MessageBox.Show("Utilise les flèches directionnelles pour déplacer les cases.");
                    break;
            }
            DisplayBoard();

            // Verifie si le tableau a changé
            if (!BoardEqual(previousBoard, board))
            {
                AddNewNumber(); // Ajoute un nombre si le tableau a changé
                DisplayBoard();
            }

            if (Lose() == true)
            {
                MessageBox.Show("Tu as perdu !");
                this.Close();
            }
            Win();
            lbl_ScorePerso.Text = score.ToString();
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

        private void DisplayBoard()
        {
            //réaffiche tout le tableau avec les bonnes couleurs et les bons textes, conformément au tableau jeu
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    if (board[row, col] > 0)
                        lbl[row, col].Text = (board[row, col]).ToString();
                    else
                        lbl[row, col].Text = "";
                    lbl[row, col].BackColor = GetColor(board[row, col]);
                }
            }
        }

        // Fonction pour déplacer les chiffres vers la droite
        static void MoveRight()
        {
            for (int row = 0; row < 4; row++)
            {
                for (int col = 2; col >= 0; col--)
                {
                    if (board[row, col] != 0)
                    {
                        int currentCol = col;

                        //Déplacement vers la droite et fusion des nombres
                        while (currentCol + 1 < 4 && (board[row, currentCol + 1] == 0 || board[row, currentCol + 1] == board[row, currentCol]))
                        {
                            if (board[row, currentCol + 1] == 0)
                            {
                                // Déplacement vers la droite
                                board[row, currentCol + 1] = board[row, currentCol];
                                board[row, currentCol] = 0;
                                currentCol++;
                            }
                            else if (board[row, currentCol + 1] == board[row, currentCol])
                            {
                                // Fusion des nombres de même valeur
                                board[row, currentCol + 1] *= 2;
                                board[row, currentCol] = 0;

                                // Ajouter la valeur fusionnée au score
                                score += board[row, currentCol + 1];
                                break;
                            }
                        }
                    }
                }
            }
        }

        // Fonction pour déplacer les chiffres vers la gauche
        static void MoveLeft()
        {
            for (int row = 0; row < 4; row++)
            {
                for (int col = 1; col < 4; col++)
                {
                    if (board[row, col] != 0)
                    {
                        int currentCol = col;

                        //Déplacement vers la gauche et fusion des nombres
                        while (currentCol - 1 >= 0 && (board[row, currentCol - 1] == 0 || board[row, currentCol - 1] == board[row, currentCol]))
                        {
                            // Déplacement vers la gauche
                            if (board[row, currentCol - 1] == 0)
                            {
                                board[row, currentCol - 1] = board[row, currentCol];
                                board[row, currentCol] = 0;
                                currentCol--;
                            }
                            else if (board[row, currentCol - 1] == board[row, currentCol])
                            {
                                // Fusion des nombres de même valeur
                                board[row, currentCol - 1] *= 2;
                                board[row, currentCol] = 0;

                                // Ajouter la valeur fusionnée au score
                                score += board[row, currentCol - 1];
                                break;
                            }
                        }
                    }
                }
            }
        }

        // Fonction pour déplacer les chiffres vers le haut
        static void MoveUp()
        {
            for (int col = 0; col < 4; col++)
            {
                for (int row = 1; row < 4; row++)
                {
                    if (board[row, col] != 0)
                    {
                        int currentRow = row;

                        //Déplacement vers le haut et fusion des nombres
                        while (currentRow - 1 >= 0 && (board[currentRow - 1, col] == 0 || board[currentRow - 1, col] == board[currentRow, col]))
                        {
                            // Déplacement vers le haut
                            if (board[currentRow - 1, col] == 0)
                            {
                                board[currentRow - 1, col] = board[currentRow, col];
                                board[currentRow, col] = 0;
                                currentRow--;
                            }
                            else if (board[currentRow - 1, col] == board[currentRow, col])
                            {
                                // Fusion des nombres de même valeur
                                board[currentRow - 1, col] *= 2;
                                board[currentRow, col] = 0;

                                // Ajouter la valeur fusionnée au score
                                score += board[currentRow - 1, col];
                                break;
                            }
                        }
                    }
                }
            }
        }

        // Fonction pour déplacer les chiffres vers le bas
        static void MoveDown()
        {
            for (int col = 0; col < 4; col++)
            {
                for (int row = 2; row >= 0; row--)
                {
                    if (board[row, col] != 0)
                    {
                        int currentRow = row;

                        //Déplacement vers le bas et fusion des nombres
                        while (currentRow + 1 < 4 && (board[currentRow + 1, col] == 0 || board[currentRow + 1, col] == board[currentRow, col]))
                        {
                            // Déplacement vers le bas
                            if (board[currentRow + 1, col] == 0)
                            {
                                board[currentRow + 1, col] = board[currentRow, col];
                                board[currentRow, col] = 0;
                                currentRow++;
                            }
                            else if (board[currentRow + 1, col] == board[currentRow, col])
                            {
                                // Fusion des nombres de même valeur
                                board[currentRow + 1, col] *= 2;
                                board[currentRow, col] = 0;

                                // Ajouter la valeur fusionnée au score
                                score += board[currentRow + 1, col];
                                break;
                            }
                        }
                    }
                }
            }
        }

        // Fonction pour ajouter un nouveau '2' dans le tableau à chaque mouvement
        static void AddNewNumber()
        {
            // Obtient la valeur du nouveau chiffre avec 90% de chance d'avoir un '2' et 10% de chance d'avoir un '4'
            int value;

            if (random.Next(10) < 9)
            {
                value = 2;  // 90% de chance d'avoir un '2'
            }
            else
            {
                value = 4;  // 10% de chance d'avoir un '4'
            }

            // Recherche d'une position vide pour ajouter un nouveau chiffre
            int row, col;

            do
            {
                row = random.Next(0, 4);
                col = random.Next(0, 4);
            }
            while (board[row, col] != 0);

            // Ajout du nouveau chiffre
            board[row, col] = value;
        }

        // Fonction pour avoir la couleur en fonction de la valeur de la case
        static Color GetColor(int value)
        {
            switch (value)
            {
                case 0: return Color.White;
                case 2: return Color.FromArgb(255, 177, 205, 68);
                case 4: return Color.FromArgb(255, 120, 186, 63);
                case 8: return Color.FromArgb(255, 58, 176, 116);
                case 16: return Color.FromArgb(255, 45, 168, 225);
                case 32: return Color.FromArgb(255, 52, 102, 175);
                case 64: return Color.FromArgb(255, 81, 69, 151);
                case 128: return Color.FromArgb(255, 125, 66, 148);
                case 256: return Color.FromArgb(255, 194, 47, 138);
                case 512: return Color.FromArgb(255, 220, 46, 79);
                case 1024: return Color.FromArgb(255, 224, 74, 50);
                case 2048: return Color.FromArgb(255, 232, 98, 37);
                default: return Color.FromArgb(255, 232, 98, 37);
            }
        }

        //Fonction qui vérifie si le joueur a perdu ou non
        static bool Lose()
        {
            //Vérifie si une case est vide
            foreach (var number in board)
            {
                if (number == 0)
                {
                    return false;
                }
            }

            // Vérifie si des mouvements sont encore possible horizontalement
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (board[row, col] == board[row, col + 1] || board[row, col] == 0 || board[row, col + 1] == 0)
                    {
                        return false;
                    }
                }
            }

            // Vérifie si des mouvements sont encore possible verticalement
            for (int col = 0; col < 4; col++)
            {
                for (int row = 0; row < 3; row++)
                {
                    if (board[row, col] == board[row + 1, col] || board[row, col] == 0 || board[row + 1, col] == 0)
                    {
                        return false;
                    }
                }
            }
            // Si aucun mouvement possible, le joueur a perdu
            return true;
        }

        // Fonction qui vérifie si le joueur a gagné
        static void Win()
        {
            // Cherche dans le tableau si une case 2048 ou plus est présente
            foreach (var number in board)
            {
                if (number == 2048 && win == false)
                {
                    win = true; // Si une case 2048 ou plus est présente retourne vrai
                    MessageBox.Show("Bravo tu as gagné ! Tu peux continuer a jouer.");
                }
            }
        }


    }
}
